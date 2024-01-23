using DataAccesLayer.Data;
using DataAccesLayer.Repositories;
using DataAccesLayer.Repository;
using Desktop.Bankomats;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Desktop;

public static class Program
{

    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();
        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();

        var form1 = serviceProvider.GetRequiredService<Bankomat>();

        Application.Run(form1);
    }
    private static void ConfigureServices(IServiceCollection services)
    {
        const string connectionString = "Host=localhost;Port=5432;Database=Navbat;Username=postgres;Password=1234";

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString, o => o.EnableRetryOnFailure()), ServiceLifetime.Transient, ServiceLifetime.Transient);
        services.AddTransient<IClientInterface, ClientRepository>();
        services.AddTransient<IUserInterface, UserRepository>();
        services.AddScoped<Bankomat>();

    }

}