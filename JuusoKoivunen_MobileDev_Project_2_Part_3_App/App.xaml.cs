namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public partial class App : Application
{
    private readonly DatabaseHelper databaseHelper;

    public App(DatabaseHelper databaseHelper)
    {
        InitializeComponent();

        this.databaseHelper = databaseHelper;
        MainPage = new AppShell();
    }

    protected override async void OnStart()
    {
        // Handle when your app starts
        await databaseHelper.InitializeDatabaseAsync();
    }
}

