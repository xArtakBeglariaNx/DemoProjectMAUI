using DemoProjectMAUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectMAUI.Views;

public partial class AddEmployeePage : ContentPage
{
    public AddEmployeePage(AddEmployeeViewModel addEmployeeViewModel)
    {
        InitializeComponent();
        BindingContext = addEmployeeViewModel;
    }
}