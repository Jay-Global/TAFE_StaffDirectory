using System;
using CommunityToolkit.Mvvm.Input;
using JuusoKoivunen_MobileDev_Project_2_Part_3_App.Pages.Mobile;
using JuusoKoivunen_MobileDev_Project_2_Part_3_App.Pages.Tablet;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModel
{
	public partial class MainPageViewModel
	{
		private INavigation _navigationService;

		public MainPageViewModel(INavigation navigation)
		{
			this._navigationService = navigation;
		}

		[RelayCommand]
		private async Task NavigateToDetailViewPage()
		{
			// Here need to find tablet/mobile specific or other way for the screen size

#if IOS || ANDROID
			await _navigationService.PushAsync(new DetailViewPageMobile());
#else
			await _navigationService.PushAsync(new DetailViewPageTablet());

#endif
		}
	}
}

 