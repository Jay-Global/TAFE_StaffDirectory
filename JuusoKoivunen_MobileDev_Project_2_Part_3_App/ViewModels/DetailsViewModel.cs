namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class DetailsViewModel : ObservableObject
{
    public Person CurrentContact { get; }

    public DetailsViewModel(Person contact)
    {
        CurrentContact = contact;
    }
}

