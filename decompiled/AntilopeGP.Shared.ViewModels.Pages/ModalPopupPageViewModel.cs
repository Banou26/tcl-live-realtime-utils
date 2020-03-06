using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class ModalPopupPageViewModel : ViewModelBase, IAutoInitialize, IAbracadabra
	{
		[AutoInitialize(true)]
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return _003CText_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CText_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CText_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.Text);
				}
			}
		}

		public ICommand ContentTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CContentTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CContentTapCommand_003Ek__BackingField, value))
				{
					_003CContentTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.ContentTapCommand);
				}
			}
		}

		public ModalPopupPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			ContentTapCommand = new Command(OnContentTapped);
		}

		private void OnContentTapped()
		{
			base.NavigationService.GoBackAsync();
		}
	}
}
