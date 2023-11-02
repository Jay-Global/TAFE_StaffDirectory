using JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
		BindingContext = new ListViewModel();
	}
}
