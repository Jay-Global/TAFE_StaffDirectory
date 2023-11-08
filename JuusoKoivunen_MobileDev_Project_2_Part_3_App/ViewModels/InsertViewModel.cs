//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using System.Threading.Tasks;
//using System.Windows.Input;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels
{
    public partial class InsertViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CanSubmit))]
        string firstname, lastName, department, role, mobileNumber, email;

        [RelayCommand]
        async Task Insert()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            var contact = new Contact
            {
                FirstName = this.Firstname,
                LastName = this.LastName,
                Department = this.Department,
                Role = this.Role,
                MobileNumber = this.MobileNumber,
                Email = this.Email
            };

            var databaseHelper = new DatabaseHelper("contacts.db");
            await databaseHelper.SaveContactAsync(contact);

            // Handle navigation and user feedback here

            IsBusy = false;
        }

        public bool CanSubmit => !string.IsNullOrWhiteSpace(Firstname) &&
                                 !string.IsNullOrWhiteSpace(LastName) &&
                                 !string.IsNullOrWhiteSpace(Department) &&
                                 !string.IsNullOrWhiteSpace(Role) &&
                                 !string.IsNullOrWhiteSpace(MobileNumber) &&
                                 !string.IsNullOrWhiteSpace(Email);
    }
}



