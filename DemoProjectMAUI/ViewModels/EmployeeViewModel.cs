using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoProjectMAUI.Models;
using DemoProjectMAUI.Services;
using DemoProjectMAUI.Views;

namespace DemoProjectMAUI.ViewModels;

public partial class EmployeeViewModel : ObservableObject
{
    public static List<EmployeeModel> SearchEmployees { get; private set; } = new List<EmployeeModel>();

    public ObservableCollection<EmployeeModel> EmployeesList { get; set; } = new ObservableCollection<EmployeeModel>();

    private readonly IDemoDataService _demoDataService;

    public EmployeeViewModel(IDemoDataService demoDataService1)
    {
        _demoDataService = demoDataService1;
    }

    [RelayCommand]
    public async void GetEmployeesList()
    {
        EmployeesList.Clear();
        var employeeList = await _demoDataService.GetEmployees();
        if (employeeList.Count > 0)
        {
            employeeList = employeeList.OrderBy(f => f.FirstName).ToList();
            foreach (var employee in employeeList)
            {
                EmployeesList.Add(employee);
            }
        }
        SearchEmployees.Clear();
        SearchEmployees.AddRange(employeeList);
    }

    [RelayCommand]
    public async void AddEmployee()
    {
        await Shell.Current.GoToAsync(nameof(AddEmployeePage));
    }

    [RelayCommand]
    public async void EditEmployee(EmployeeModel employeeModel)
    {
        var navParam = new Dictionary<string, object>();
        navParam.Add("EmployeeDetailEdit", employeeModel );
        await Shell.Current.GoToAsync(nameof(EditEmployeePage), navParam);
    }

    [RelayCommand]
    public async void DeleteEmployee(EmployeeModel employeeModel)
    {
        var navParam = new Dictionary<string, object>();
        navParam.Add("EmployeeDetailDel", employeeModel);
        await Shell.Current.GoToAsync(nameof(DeleteEmployeePage), navParam);
    }
}