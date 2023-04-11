using DemoProjectMAUI.Views;

namespace DemoProjectMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AddEmployeePage), typeof(AddEmployeePage));
        Routing.RegisterRoute(nameof(EditEmployeePage), typeof(EditEmployeePage));
        Routing.RegisterRoute(nameof(DeleteEmployeePage), typeof(DeleteEmployeePage));
    }

	private void ExitButton_OnClicked(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}
}
