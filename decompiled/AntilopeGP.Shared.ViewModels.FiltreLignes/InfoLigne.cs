using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.FiltreLignes
{
	public class InfoLigne : INotifyPropertyChanged
	{
		public string ModeImagePath
		{
			[CompilerGenerated]
			get
			{
				return _003CModeImagePath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CModeImagePath_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CModeImagePath_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.ModeImagePath);
				}
			}
		}

		public string LigneImagePath
		{
			[CompilerGenerated]
			get
			{
				return _003CLigneImagePath_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CLigneImagePath_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CLigneImagePath_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.LigneImagePath);
				}
			}
		}

		public string Ligne
		{
			[CompilerGenerated]
			get
			{
				return _003CLigne_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CLigne_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CLigne_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Ligne);
				}
			}
		}

		public string Sens
		{
			[CompilerGenerated]
			get
			{
				return _003CSens_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CSens_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CSens_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Sens);
				}
			}
		}

		public string Destination
		{
			[CompilerGenerated]
			get
			{
				return _003CDestination_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CDestination_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CDestination_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Destination);
				}
			}
		}

		public bool TempsReel
		{
			[CompilerGenerated]
			get
			{
				return _003CTempsReel_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CTempsReel_003Ek__BackingField != value)
				{
					_003CTempsReel_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.TempsReel);
				}
			}
		}

		public bool Selected
		{
			[CompilerGenerated]
			get
			{
				return _003CSelected_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CSelected_003Ek__BackingField != value)
				{
					_003CSelected_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Selected);
				}
			}
		}

		public bool Proximity
		{
			[CompilerGenerated]
			get
			{
				return _003CProximity_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CProximity_003Ek__BackingField != value)
				{
					_003CProximity_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Proximity);
				}
			}
		}

		public bool AlternateRow
		{
			[CompilerGenerated]
			get
			{
				return _003CAlternateRow_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CAlternateRow_003Ek__BackingField != value)
				{
					_003CAlternateRow_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.BackgroundColor);
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.AlternateRow);
				}
			}
		}

		public Color BackgroundColor
		{
			get
			{
				if (!AlternateRow)
				{
					return Color.FromHex("#F8F5F7");
				}
				return Color.FromHex("#ECE8EA");
			}
		}

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		public void SetSelected(bool selected)
		{
			if (TempsReel)
			{
				Selected = selected;
			}
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.1.0")]
		[DebuggerNonUserCode]
		protected void _003C_003EOnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			this.PropertyChanged?.Invoke(this, eventArgs);
		}
	}
}
