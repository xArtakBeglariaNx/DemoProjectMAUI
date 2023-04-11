using DemoProjectMAUI.Services;
using DemoProjectMAUI.ViewModels;
using DemoProjectMAUI.Views;
using Microsoft.Extensions.Logging;

namespace DemoProjectMAUI;

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
		//Services
		builder.Services.AddSingleton<IDemoDataService, DemoDataService>();

		//Views
		builder.Services.AddSingleton<EmployeePage>();
		builder.Services.AddTransient<AddEmployeePage>();
        builder.Services.AddTransient<EditEmployeePage>();
        builder.Services.AddTransient<DeleteEmployeePage>();

        //ViewModels
        builder.Services.AddSingleton<EmployeeViewModel>();
        builder.Services.AddTransient<AddEmployeeViewModel>();
        builder.Services.AddTransient<EditEmployeeViewModel>();
        builder.Services.AddTransient<DeleteEmployeeViewModel>();


        return builder.Build();
	}
}
