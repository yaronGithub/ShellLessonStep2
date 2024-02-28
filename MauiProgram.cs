using Microsoft.Extensions.Logging;
using ShellLessonStep2.ViewModels;
using ShellLessonStep2.Views;

namespace ShellLessonStep2;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
    /*
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MonkeysView>();
        builder.Services.AddTransient<MonkeyDetailsView>();
        return builder;
    }
    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MonkeysService>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<MonkeysViewModel>();

        //--------Transient ViewModels
        builder.Services.AddTransient<MonkeyDetailsViewModel>();

        return builder;
    }
    */
}
