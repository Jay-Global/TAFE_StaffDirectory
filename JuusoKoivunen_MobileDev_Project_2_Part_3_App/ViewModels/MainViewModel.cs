namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Initialize();
    }

    private static async void Initialize()
    {
        await DataManager.LoadContactsAsync();
    }

    [RelayCommand]

	Task Navigate() => Shell.Current.GoToAsync(nameof(ListViewPage));
}
