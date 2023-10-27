using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

public partial class ListViewModel : ObservableObject
{
	public ListViewModel()
	{

	}

	[RelayCommand]

	Task GoBack() => Shell.Current.GoToAsync(nameof(ListViewPage));
}
