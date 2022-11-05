using Magic_Counter.ViewModels;
using Microsoft.AspNetCore.Components.WebView.Maui;
using MudBlazor.Services;

namespace Magic_Counter;

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
			});

		builder.Services.AddTransient<PlayerViewModel>();



		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddMudServices();
        return builder.Build();
	}
}
