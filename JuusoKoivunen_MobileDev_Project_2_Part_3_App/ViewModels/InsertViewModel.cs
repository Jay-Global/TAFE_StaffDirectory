namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class InsertViewModel : ObservableObject
{
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
    List<Person> contacts;

    public InsertViewModel()
    {
        contacts = new List<Person>(); // This could be retrieved from a data store
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
        Person newContact = new()
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
            DataManager.Contacts = new List<Person>();

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
        await Shell.Current.GoToAsync("..");

        // Call this method to refresh the list after adding a new contact

       
    }


}

