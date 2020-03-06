using Prism.Navigation;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class TutorialPageViewModel : ViewModelBase
	{
		private const string TUTORIAL_ACCEPTED_PREFERENCES_KEY = "fr.tcl.antilopegp.tutorial";

		public ICommand AcceptTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CAcceptTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CAcceptTapCommand_003Ek__BackingField, value))
				{
					_003CAcceptTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.AcceptTapCommand);
				}
			}
		}

		public static bool InitialTutorialAccepted => Preferences.Get("fr.tcl.antilopegp.tutorial", defaultValue: false);

		public TutorialPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			AcceptTapCommand = new Command(OnAcceptTapped);
		}

		private void OnAcceptTapped()
		{
			Preferences.Set("fr.tcl.antilopegp.tutorial", value: true);
			base.NavigationService.GoBackAsync();
		}
	}
}
