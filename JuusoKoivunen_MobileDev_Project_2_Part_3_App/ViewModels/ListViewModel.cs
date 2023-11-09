namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class ListViewModel : ObservableObject
{
    public ObservableCollection<Model.Contact> Contacts { get; } = new ObservableCollection<Model.Contact>();

    public ListViewModel()
    {
        Contacts = new ObservableCollection<Model.Contact>(DataManager.Contacts);
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



    [RelayCommand]
    async Task SelectContact(Model.Contact selectedContact)
    {
        if (selectedContact != null)
        {
            // Navigate to details page with the selected contact
        }
    }

    // This command will be triggered when a user selects a contact from the list
    [RelayCommand]
    async Task ShowContactDetails(Model.Contact contact)
    {
        if (contact != null)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<string, object>
        {
            { "Contact", contact }
        });
        }
    }

    [RelayCommand]

	Task GoBack() => Shell.Current.GoToAsync(nameof(ListViewPage));
}
