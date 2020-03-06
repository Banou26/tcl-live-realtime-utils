using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class ViewModelBase : BindableBase, INavigationAware, INavigatedAware, IInitializeAsync, IDestructible
	{
		private string _title;

		protected INavigationService NavigationService
		{
			[CompilerGenerated]
			get
			{
				return _003CNavigationService_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CNavigationService_003Ek__BackingField, value))
				{
					_003CNavigationService_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.NavigationService);
				}
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				if (!string.Equals(_title, value, StringComparison.Ordinal))
				{
					SetProperty(ref _title, value, "Title");
				}
			}
		}

		public ViewModelBase(INavigationService navigationService)
		{
			NavigationService = navigationService;
		}

		public virtual void OnNavigatedFrom(INavigationParameters parameters)
		{
		}

		public virtual void OnNavigatedTo(INavigationParameters parameters)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual async Task InitializeAsync(INavigationParameters parameters)
		{
			await Task.CompletedTask;
		}
	}
}
