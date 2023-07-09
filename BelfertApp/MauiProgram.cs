using Microsoft.Extensions.Logging;

namespace BelfertApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("YouTubeSansDarkBlack.ttf", "YouTubeSansDarkBlack");
				fonts.AddFont("YouTubeSansDarkBold.ttf", "YouTubeSansDarkBold");
				fonts.AddFont("YouTubeSansDarkExtraBold.ttf", "YouTubeSansDarkExtraBold");
				fonts.AddFont("YouTubeSansDarkLight.ttf", "YouTubeSansDarkLight");
				fonts.AddFont("YouTubeSansDarkMedium.ttf", "YouTubeSansDarkMedium");
				fonts.AddFont("YouTubeSansDarkRegular.ttf", "YouTubeSansDarkRegular");
				fonts.AddFont("YouTubeSansDarkSemiBold.ttf", "YouTubeSansDarkSemiBold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
