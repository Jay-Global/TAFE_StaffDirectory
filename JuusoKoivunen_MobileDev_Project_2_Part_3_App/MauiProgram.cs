using Microsoft.Extensions.Logging;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddTransient<ListViewPage>();
        builder.Services.AddTransient<ListViewModel>();

		builder.Services.AddTransient<InsertPage>();
        builder.Services.AddTransient<InsertViewModel>();

        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient<DetailsViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
    }
}

