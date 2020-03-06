using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AntilopeGP.Shared.Busy
{
	public class BusyHelper
	{
		private bool _busyAnimationVisible;

		private BusyPage _busyPage;

		public BusyHelper()
		{
			_busyPage = new BusyPage();
		}

		public async Task DisplayBusyAnimation(string text, bool animated = false)
		{
			if (!_busyAnimationVisible)
			{
				await Device.InvokeOnMainThreadAsync(async delegate
				{
					_busyPage.Message = text;
					await PopupNavigation.Instance.PushAsync(_busyPage, animate: false);
					_busyAnimationVisible = true;
				});
			}
		}

		public async Task HideBusyAnimation(bool animated = false)
		{
			if (_busyAnimationVisible)
			{
				await Device.InvokeOnMainThreadAsync(async delegate
				{
					await PopupNavigation.Instance.PopAsync(animate: false);
					_busyAnimationVisible = false;
				});
			}
		}
	}
}
