//using System.Collections.ObjectModel;
//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using System.Threading.Tasks;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels
{
    public partial class ListViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> Contacts { get; } = new();

        [RelayCommand]
        async Task LoadContacts()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            var databaseHelper = new DatabaseHelper("contacts.db");
            var contacts = await databaseHelper.GetContactsAsync();

            Contacts.Clear();
            foreach (var contact in contacts)
            {
                Contacts.Add(contact);
            }

            IsBusy = false;
        }
    }
}

