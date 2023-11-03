using Syncfusion.Maui.Core.Hosting;
using Microsoft.Extensions.Logging;
//using JuusoKoivunen_MobileDev_Project_2_Part_3_App.Helpers;
//using JuusoKoivunen_MobileDev_Project_2_Part_3_App.PlatformImplementations;
using JuusoKoivunen_MobileDev_Project_2_Part_3_App.ViewModels;

namespace JuusoKoivunen_MobileDev_Project_2_Part_3_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .ConfigureSyncfusionCore()
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

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
    }
}

