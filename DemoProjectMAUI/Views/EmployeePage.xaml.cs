using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoProjectMAUI.Models;
using DemoProjectMAUI.Services;
using DemoProjectMAUI.ViewModels;

namespace DemoProjectMAUI.Views;

public partial class EmployeePage : ContentPage
{
    private EmployeeViewModel _employeeViewModel;
    
    public EmployeePage(EmployeeViewModel employeeViewModel)
    {
        InitializeComponent();
        _employeeViewModel = employeeViewModel;
        BindingContext = employeeViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _employeeViewModel.GetEmployeesListCommand.Execute(null);
    }
}