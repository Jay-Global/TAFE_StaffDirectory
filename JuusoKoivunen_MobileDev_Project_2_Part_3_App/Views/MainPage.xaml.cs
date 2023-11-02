using JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

}


