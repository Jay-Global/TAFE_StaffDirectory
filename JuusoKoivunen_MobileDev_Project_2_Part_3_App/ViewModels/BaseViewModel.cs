namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        public string _firstName, _lastName, _department, _role, _mobileNumber, _email;

        public bool IsNotBusy => !IsBusy;



    }

}