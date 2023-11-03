namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class ListViewModel : BaseViewModel
{
	public ListViewModel()
	{

	}

	[RelayCommand]

	Task GoBack() => Shell.Current.GoToAsync(nameof(ListViewPage));

}
