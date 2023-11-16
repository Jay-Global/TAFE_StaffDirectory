namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(Person selectedContact)
    {
        InitializeComponent();
        BindingContext = new DetailsViewModel(selectedContact);
    }
}
