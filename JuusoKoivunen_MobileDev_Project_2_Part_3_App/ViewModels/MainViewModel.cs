namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class MainViewModel : BaseViewModel
{
	public MainViewModel()
	{
        
    }

	[RelayCommand]

	Task Navigate() => Shell.Current.GoToAsync(nameof(ListViewPage));
}
