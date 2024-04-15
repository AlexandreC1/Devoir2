using CommunityToolkit.Maui;
using Devoir2.Services;
using Devoir2.ViewModels;
using Devoir2.Views;
using Microsoft.Extensions.Logging;

namespace Devoir2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<PersonneService>();

            builder.Services.AddSingleton<AjoutPage>();
            builder.Services.AddSingleton<AjoutPageViewModel>();

            builder.Services.AddSingleton<PersonneDatabase>();

            return builder.Build();
        }
    }
}
