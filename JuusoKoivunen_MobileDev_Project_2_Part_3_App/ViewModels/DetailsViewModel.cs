using System;
namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public class DetailsViewModel : ObservableObject
{
    public Model.Contact CurrentContact { get; }

    public DetailsViewModel(Model.Contact contact)
    {
        CurrentContact = contact;
    }
}

