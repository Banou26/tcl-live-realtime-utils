using AntilopeGP.Configuration;
using AntilopeGP.FileSystem;
using Keolis.AntilopeGrandPublic.Common.Model;
using SkiaSharp;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AntilopeGP.Symbology
{
	public class SymbolsManager
	{
		private readonly IFileManager _fileManager;

		private readonly Config _config;

		public SymbolsManager(IFileManager fileManager, Config config)
		{
			_fileManager = fileManager;
			_config = config;
		}

		public async Task<VehiculeSymbol> GetMapVehiculeSymbol(Vehicule vehicule, bool displayDirection)
		{
			try
			{
				int symbolHeight = Convert.ToInt32((double)_config.Map.VehiculeSymbolHeight * _config.DeviceInfo.ScreenScale);
				int vehiculeHeight = Convert.ToInt32((float)symbolHeight * 0.7f);
				_ = (float)vehiculeHeight / 2f;
				int ligneRibbonHeight = Convert.ToInt32((float)symbolHeight * 0.25f);
				SKImage sKImage = await GetMapVehiculeSymbol(vehicule, symbolHeight, vehiculeHeight, ligneRibbonHeight, displayDirection);
				sKImage.Encode(SKEncodedImageFormat.Png, 100).AsStream();
				return new VehiculeSymbol
				{
					Stream = sKImage.Encode(SKEncodedImageFormat.Png, 100).AsStream(),
					Width = sKImage.Width,
					Height = sKImage.Height,
					YOffsetFromCenter = (double)(symbolHeight - vehiculeHeight) / 2.0
				};
			}
			catch (Exception)
			{
				return null;
			}
		}

		private async Task<SKImage> GetMapVehiculeSymbol(Vehicule vehicule, int symbolHeight, int vehiculeHeight, int ligneRibbonHeight, bool displayDirection)
		{
			_ = 2;
			try
			{
				_ = symbolHeight - vehiculeHeight - ligneRibbonHeight;
				SKPaint paint = new SKPaint
				{
					FilterQuality = SKFilterQuality.High,
					IsAntialias = true
				};
				SKBitmap vehiculeBitmap = await GetVehiculeBitmap(vehicule.Ligne);
				SKBitmap headingBitmap = await GetVehiculeHeadingBitmap(vehicule.Ligne, vehicule.Cap);
				SKBitmap sKBitmap = await GetLigneSymbolBitmap(vehicule.Ligne, displayDirection ? vehicule.Destination : null, ligneRibbonHeight, 20);
				SKBitmap sKBitmap2 = new SKBitmap(Math.Max(vehiculeBitmap.Width, sKBitmap.Width), symbolHeight);
				sKBitmap2.Erase(SKColors.Transparent);
				using (SKCanvas sKCanvas = new SKCanvas(sKBitmap2))
				{
					SKRect vehiculeSpriteRect = GetVehiculeSpriteRect(vehiculeBitmap, vehiculeHeight, sKBitmap2.Width);
					sKCanvas.DrawBitmap(headingBitmap, vehiculeSpriteRect, paint);
					sKCanvas.DrawBitmap(vehiculeBitmap, vehiculeSpriteRect, paint);
					int num = ligneRibbonHeight * sKBitmap.Width / sKBitmap.Height;
					float num2 = (float)(sKBitmap2.Width - num) / 2f;
					SKRect dest = new SKRect(num2, symbolHeight - ligneRibbonHeight, (float)sKBitmap2.Width - num2, symbolHeight);
					sKCanvas.DrawBitmap(sKBitmap, dest, paint);
				}
				return SKImage.FromBitmap(sKBitmap2);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public async Task<string> GetLigneRibbon(string ligne, string destination)
		{
			try
			{
				string str = ligne + destination;
				string hash = str.GetHash();
				string symbolCacheFilename = "Ribbons/" + hash + ".png";
				if (!_fileManager.CacheFileExists(symbolCacheFilename))
				{
					SKImage sKImage = SKImage.FromBitmap(await GetLigneSymbolBitmap(ligne, destination, 100));
					using (Stream stream = sKImage.Encode(SKEncodedImageFormat.Png, 100).AsStream())
					{
						_fileManager.WriteCacheFile(stream, symbolCacheFilename);
					}
				}
				return _fileManager.GetCacheFilePath(symbolCacheFilename);
			}
			catch
			{
				return null;
			}
		}

		private async Task<SKBitmap> GetLigneSymbolBitmap(string ligne, string destination, int height, int? maxDestinationlength = null)
		{
			_ = 2;
			try
			{
				float elementsSpacing = (float)height * 0.2f;
				float backgroundPadding = (float)height * 0.2f;
				if (destination != null && maxDestinationlength.HasValue && destination.Length > maxDestinationlength.Value)
				{
					destination = destination.Substring(0, maxDestinationlength.Value) + "...";
				}
				SKPaint bitmapPaint = new SKPaint
				{
					FilterQuality = SKFilterQuality.High,
					IsAntialias = true
				};
				SKPaint sKPaint = new SKPaint
				{
					Style = SKPaintStyle.StrokeAndFill,
					StrokeWidth = 1f,
					Color = new SKColor(48, 48, 47)
				};
				SKPaint sKPaint2 = sKPaint;
				sKPaint2.Typeface = SKTypeface.FromStream(await _fileManager.GetBundleBinaryFile("Fonts/TCL-Regular_0.otf"));
				sKPaint.TextAlign = SKTextAlign.Left;
				sKPaint.TextEncoding = SKTextEncoding.Utf8;
				sKPaint.TextSize = (float)height * 0.8f;
				sKPaint.FilterQuality = SKFilterQuality.High;
				sKPaint.IsAntialias = true;
				SKPaint destinationPaint = sKPaint;
				SKPaint backgroundPaint = new SKPaint
				{
					Style = SKPaintStyle.StrokeAndFill,
					Color = new SKColor(255, 255, 255, 255)
				};
				SKBitmap modeBitmap = await GetModeBitmap(ligne);
				SKBitmap bitmap = await GetLigneBitmap(ligne);
				SKRect modeSpriteRect = GetModeSpriteRect(modeBitmap, height);
				SKRect ligneSpriteRect = GetLigneSpriteRect(bitmap, height, modeSpriteRect.Right + elementsSpacing / 2f);
				SKRect bounds = default(SKRect);
				if (destination != null)
				{
					destinationPaint.MeasureText(destination, ref bounds);
				}
				float num = (destination != null) ? (elementsSpacing * 1.5f) : elementsSpacing;
				SKRect rect = new SKRect(0f, 0f, modeSpriteRect.Width + ligneSpriteRect.Width + num + bounds.Width, height);
				rect.Inflate(backgroundPadding, backgroundPadding);
				rect.Offset(backgroundPadding, backgroundPadding);
				modeSpriteRect.Offset(backgroundPadding, backgroundPadding);
				ligneSpriteRect.Offset(backgroundPadding, backgroundPadding);
				SKBitmap sKBitmap = new SKBitmap((int)rect.Width, (int)rect.Height);
				sKBitmap.Erase(SKColors.Transparent);
				SKRoundRect rect2 = new SKRoundRect(rect, rect.Height / 4f, rect.Height / 4f);
				using (SKCanvas sKCanvas = new SKCanvas(sKBitmap))
				{
					sKCanvas.DrawRoundRect(rect2, backgroundPaint);
					sKCanvas.DrawBitmap(modeBitmap, modeSpriteRect, bitmapPaint);
					sKCanvas.DrawBitmap(bitmap, ligneSpriteRect, bitmapPaint);
					if (destination != null)
					{
						sKCanvas.DrawText(destination, ligneSpriteRect.Right + elementsSpacing - bounds.Left, destinationPaint.TextSize + backgroundPadding, destinationPaint);
					}
				}
				SKRect dest = SKRect.Create(0f, 0f, rect.Width * (float)height / rect.Height, height);
				SKBitmap sKBitmap2 = new SKBitmap((int)dest.Width, (int)dest.Height);
				sKBitmap2.Erase(SKColors.Transparent);
				using (SKCanvas sKCanvas2 = new SKCanvas(sKBitmap2))
				{
					sKCanvas2.DrawBitmap(sKBitmap, dest, bitmapPaint);
				}
				return sKBitmap2;
			}
			catch (Exception)
			{
				return null;
			}
		}

		private async Task<SKBitmap> GetVehiculeBitmap(string ligne)
		{
			bool flag = _config.Lignes.First((InfosLigne x) => x.Ligne == ligne).Mode == "T";
			using (Stream stream = await _fileManager.GetBundleBinaryFile(flag ? "Symboles/Tram.png" : "Symboles/Bus.png"))
			{
				return SKBitmap.Decode(stream);
			}
		}

		private async Task<SKBitmap> GetVehiculeHeadingBitmap(string ligne, int heading)
		{
			bool flag = _config.Lignes.First((InfosLigne x) => x.Ligne == ligne).Mode == "T";
			using (Stream stream = await _fileManager.GetBundleBinaryFile(flag ? "Symboles/FlecheTram.png" : "Symboles/FlecheBus.png"))
			{
				using (SKBitmap sKBitmap = SKBitmap.Decode(stream))
				{
					SKBitmap sKBitmap2 = new SKBitmap(sKBitmap.Width, sKBitmap.Height);
					sKBitmap2.Erase(SKColors.Transparent);
					using (SKPaint paint = new SKPaint
					{
						FilterQuality = SKFilterQuality.High,
						IsAntialias = true
					})
					{
						using (SKCanvas sKCanvas = new SKCanvas(sKBitmap2))
						{
							sKCanvas.RotateDegrees(heading, (float)sKBitmap.Width / 2f, (float)sKBitmap.Height / 2f);
							sKCanvas.DrawBitmap(sKBitmap, 0f, 0f, paint);
							return sKBitmap2;
						}
					}
				}
			}
		}

		private async Task<SKBitmap> GetModeBitmap(string ligne)
		{
			string mode = _config.Lignes.First((InfosLigne x) => x.Ligne == ligne).Mode;
			string modeImageFilename = _fileManager.GetModeImageFilename(mode);
			using (Stream stream = await _fileManager.GetBundleBinaryFile(modeImageFilename))
			{
				return SKBitmap.Decode(stream);
			}
		}

		private async Task<SKBitmap> GetLigneBitmap(string ligne)
		{
			string ligneImageFilename = _fileManager.GetLigneImageFilename(ligne);
			using (Stream stream = await _fileManager.GetBundleBinaryFile(ligneImageFilename))
			{
				return SKBitmap.Decode(stream);
			}
		}

		private SKRect GetVehiculeSpriteRect(SKBitmap bitmap, float height, float parentWidth)
		{
			float num = height * (float)bitmap.Width / (float)bitmap.Height;
			float num2 = (parentWidth - num) / 2f;
			int num3 = 0;
			float right = num2 + num;
			return new SKRect(num2, num3, right, height);
		}

		private SKRect GetModeSpriteRect(SKBitmap bitmap, float height)
		{
			float num = height * (float)bitmap.Width / (float)bitmap.Height;
			int num2 = 0;
			int num3 = 0;
			float right = (float)num2 + num;
			return new SKRect(num2, num3, right, height);
		}

		private SKRect GetLigneSpriteRect(SKBitmap bitmap, float height, float leftMargin)
		{
			float num = height * (float)bitmap.Width / (float)bitmap.Height;
			int num2 = 0;
			float right = leftMargin + num;
			return new SKRect(leftMargin, num2, right, height);
		}

		private SKRect GetBackgroundRect(float textWidth, float height, float padding, float leftMargin)
		{
			float num = textWidth + 2f * padding;
			int num2 = 0;
			float right = leftMargin + num;
			return new SKRect(leftMargin, num2, right, height);
		}
	}
}
