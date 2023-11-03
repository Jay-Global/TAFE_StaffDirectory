namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string name, department, role, email;
    int mobile;


    public bool IsNotBusy => !IsBusy;
}

