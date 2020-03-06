using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace AntilopeGP.Shared.Display
{
	public class InsetsManager
	{
		private bool _forceUseSafeInsets;

		public void StartManagingInsets(Xamarin.Forms.Page page, bool forceUseSafeInsets = false)
		{
			_forceUseSafeInsets = forceUseSafeInsets;
			page.Appearing += delegate
			{
				AdjustInsets(page);
			};
			page.SizeChanged += delegate
			{
				AdjustInsets(page);
			};
		}

		private void AdjustInsets(Xamarin.Forms.Page page)
		{
			if (!(Device.RuntimePlatform == "Android"))
			{
				Thickness padding = page.On<iOS>().SafeAreaInsets();
				if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
				{
					page.Padding = default(Thickness);
				}
				else
				{
					padding.Top = 30.0;
					padding.Bottom = 0.0;
					page.Padding = padding;
				}
				if (_forceUseSafeInsets)
				{
					page.Padding = page.On<iOS>().SafeAreaInsets();
				}
			}
		}
	}
}
