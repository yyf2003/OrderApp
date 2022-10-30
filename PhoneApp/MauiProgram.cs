using CommunityToolkit.Maui;
using PhoneApp.Views;
using Sharpnado.Tabs;

namespace PhoneApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSharpnadoTabs(loggerEnable:false)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddScoped<ShopPage>();
            builder.Services.AddTransient<ShopInfoPage>();
            //builder.Services.AddScoped<ShopDetailView>();
            //builder.Services.AddScoped<ShopPOPView>();
            //builder.Services.AddScoped<ShopMachineFrameView>();
            return builder.Build();
        }
    }
}