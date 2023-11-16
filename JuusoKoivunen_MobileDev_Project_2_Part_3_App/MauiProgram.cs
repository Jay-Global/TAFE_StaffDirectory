using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        ConfigureMauiApp(builder);

        var app = builder.Build();

        // Since we cannot run async code directly here, we start it and block the main thread.
        // This is not recommended for production code, but will suffice for initialization purposes.
        //InitializeDatabase(app.Services).GetAwaiter().GetResult();

        return app;
    }

    private static void ConfigureMauiApp(MauiAppBuilder builder)
    {
        var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydatabase.db");

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Services configuration
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<ListViewPage>();
        builder.Services.AddTransient<ListViewModel>();
        builder.Services.AddTransient<InsertPage>();
        builder.Services.AddTransient<InsertViewModel>();

        //// Register the database helper as a singleton
        //builder.Services.AddSingleton(new DatabaseHelper(databasePath));

#if DEBUG
        builder.Logging.AddDebug();
#endif
    }

    //private static async Task InitializeDatabase(IServiceProvider services)
    //{
    //    // Retrieve the database helper from the service provider
    //    var databaseHelper = services.GetService<DatabaseHelper>();

    //    if (databaseHelper != null)
    //    {
    //        await databaseHelper.InitializeDatabaseAsync();
    //    }
    //}
}


