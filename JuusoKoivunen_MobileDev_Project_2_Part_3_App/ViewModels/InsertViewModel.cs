using Contact = JuusoKoivunen_MobileDev_Project_2_Part_3_App.Model.Contact;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class InsertViewModel : ObservableObject
{
    //// Properties for data binding
    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    //public string Department { get; set; }
    //public string Role { get; set; }
    //public string MobileNumber { get; set; }
    //public string Email { get; set; }

    [ObservableProperty]
    string firstName;

    [ObservableProperty]
    string lastName;

    [ObservableProperty]
    string department;

    [ObservableProperty]
    string role;

    [ObservableProperty]
    string mobileNumber;

    [ObservableProperty]
    string email;


    [ObservableProperty]
    List<Contact> contacts;

    public InsertViewModel()
    {
        contacts = new List<Contact>(); // This could be retrieved from a data store
    }

    [RelayCommand]
    async Task AddContact()
    {
        // Validate the inputs
        if (string.IsNullOrWhiteSpace(FirstName) ||
            string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(Department) ||
            string.IsNullOrWhiteSpace(Role) ||
            string.IsNullOrWhiteSpace(MobileNumber) ||
            string.IsNullOrWhiteSpace(Email))
        {
            await App.Current.MainPage.DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        // Validate the mobile number (assumes only numbers are valid)
        if (!MobileNumber.All(char.IsDigit))
        {
            await App.Current.MainPage.DisplayAlert("Error", "Please enter a valid mobile number (digits only).", "OK");
            return;
        }

        // Basic email validation
        if (!Email.Contains('@') || !Email.Contains('.'))
        {
            await App.Current.MainPage.DisplayAlert("Error", "Please enter a valid email address.", "OK");
            return;
        }

        // If validation passes, create a new contact
        Contact newContact = new Contact
        {
            FirstName = FirstName,
            LastName = LastName,
            Department = Department,
            Role = Role,
            MobileNumber = MobileNumber,
            Email = Email
        };

        // Add the new contact to the DataManager's Contacts collection
        if (DataManager.Contacts == null)
            DataManager.Contacts = new List<Contact>();

        DataManager.Contacts.Add(newContact);

        // Save the contacts list to the file
        await DataManager.SaveContactsAsync();

        // Clear the form after adding the contact
        FirstName = string.Empty;
        LastName = string.Empty;
        Department = string.Empty;
        Role = string.Empty;
        MobileNumber = string.Empty;
        Email = string.Empty;

        // Inform the user or navigate back to the list
        await App.Current.MainPage.DisplayAlert("Success", "Contact added", "OK");
        // Optionally navigate back
        // await Shell.Current.GoToAsync("..");

        // Call this method to refresh the list after adding a new contact
    }


}

