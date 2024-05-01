using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SqlServerTest ;

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
            // builder.Services.AddDbContext<UserDbContext>(options=>options.UseSqlServer(
            //     "Server=win2016-770ir.hostnegar.com\\MSSQLSERVER2022;Database=RaterDataBase;User ID=alireza;Password=15iX#6to0;TrustServerCertificate=True"
            //     ));

            // var dbContextOptions = new DbContextOptionsBuilder<UserDbContext>()
            //     .UseSqlServer("Server=win2016-770ir.hostnegar.com\\MSSQLSERVER2022;Database=RaterDataBase;User ID=alireza;Password=15iX#6to0;TrustServerCertificate=True")
            //     .Options;

            // builder.Services.AddSingleton(new UserDbContext(dbContextOptions));
            builder.Services.AddSingleton<UserDbContext>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }