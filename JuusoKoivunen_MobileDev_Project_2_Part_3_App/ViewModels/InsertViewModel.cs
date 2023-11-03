namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class InsertViewModel : BaseViewModel
{
    public ContactCard ContactCard { get; set; }

    public InsertViewModel()
	{
        this.ContactCard = new ContactCard();
        ContactCard.FirstName = "Clara";
        ContactCard.LastName = "David";
        ContactCard.Department = "California";
        ContactCard.Role = "(742) 121-3133";
        ContactCard.MobileNumber = "+1 731 220-9832";
        ContactCard.Email = "clasravenus@gmail.com";

    }
}

