
namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class InsertPage : ContentPage
{
    public InsertPage()
	{
        InitializeComponent();
		BindingContext = new InsertViewModel();
	}
}
