using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private RelayCommand navigateToDetailPage;
    public ICommand NavigateToDetailPage => navigateToDetailPage ??= new RelayCommand(PerformNavigateToDetailPage);

    private void PerformNavigateToDetailPage()
    {
    }
}


