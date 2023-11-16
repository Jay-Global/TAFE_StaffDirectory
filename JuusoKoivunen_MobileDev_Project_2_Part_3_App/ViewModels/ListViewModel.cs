namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class ListViewModel : ObservableObject
{
    public ObservableCollection<Person> Contacts { get; } = new ObservableCollection<Person>();

    public ListViewModel()
    {
        Contacts = new ObservableCollection<Person>(DataManager.Contacts);
        LoadContacts();
    }

    private void LoadContacts()
    {
        // Assuming DataManager has been loaded with contacts at app startup
        foreach (var contact in DataManager.Contacts)
        {
            Contacts.Add(contact);
        }
    }

    // Call this method to refresh the list after adding a new contact
    public void RefreshContacts()
    {
        Contacts.Clear();
        LoadContacts();
    }



    //[RelayCommand]
    //async Task SelectContact(Model.Contact selectedContact)
    //{
    //    if (selectedContact != null)
    //    {
    //        // Navigate to details page with the selected contact
    //    }
    //}






    private Person _selectedContact;
    public Person SelectedContact
    {
        get => _selectedContact;
        set
        {
            if (SetProperty(ref _selectedContact, value))
            {
                // Check for null because SetProperty is called even when the value is set to null
                if (value != null)
                {
                    ShowContactDetails(value);
                }
            }
        }
    }

    private async void ShowContactDetails(Person contact)
    {
        // Check if the contact is already null, to prevent navigation when deselecting
        if (contact != null)
        {
            await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
            {
                { "selectedContact", contact }
            });
            // Reset the selected item to ensure subsequent selections are detected
            SelectedContact = null;
        }
    }





    // This command will be triggered when a user selects a contact from the list
    //[RelayCommand]
    //async Task ShowContactDetails(Model.Contact contact)
    //{
    //    if (contact != null)
    //    {
    //        await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
    //    {
    //        { "selectedContact", contact } // Use the same key as the parameter name in DetailsPage constructor
    //    });
    //    }
    //}

    [RelayCommand]

	Task GoBack() => Shell.Current.GoToAsync(nameof(ListViewPage));

    private string lastName;

    public string LastName { get => lastName; set => SetProperty(ref lastName, value); }
}
