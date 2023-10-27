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
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<ListViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
    }
}

