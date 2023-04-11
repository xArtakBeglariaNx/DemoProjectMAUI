using DemoProjectMAUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectMAUI.Views;

public partial class DeleteEmployeePage : ContentPage
{
    public DeleteEmployeePage(DeleteEmployeeViewModel deleteEmployeeViewModel)
    {
        InitializeComponent();
        BindingContext = deleteEmployeeViewModel;
    }
}