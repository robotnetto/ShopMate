using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Microsoft.Maui.Embedding;
using MudBlazor.Services;
using ShopMate.Data;
using ShopMate.Service;
using Microsoft.EntityFrameworkCore;

namespace ShopMate
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
                }
                );

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDbContext<LocalDbService>();
            builder.Services.AddSingleton<IRecipe, RecipeRepository>();
            builder.Services.AddSingleton<IShopCart, ShopCartRepository>();
            //builder.Services.AddSingleton<IFileService, FileService>();
            builder.Services.AddMudServices();
            builder.Services.AddHttpClient();

            var dbContext = new LocalDbService();
            //dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
