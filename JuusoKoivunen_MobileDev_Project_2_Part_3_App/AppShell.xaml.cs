namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		Routing.RegisterRoute(nameof(ListViewPage), typeof(ListViewPage));
		Routing.RegisterRoute(nameof(ListViewPage), typeof(ListViewPage));
		Routing.RegisterRoute(nameof(InsertPage), typeof(InsertPage));
	}
}

