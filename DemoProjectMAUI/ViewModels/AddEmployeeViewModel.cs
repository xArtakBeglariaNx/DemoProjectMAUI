using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoProjectMAUI.Models;
using DemoProjectMAUI.Services;
using DemoProjectMAUI.Views;

namespace DemoProjectMAUI.ViewModels
{
    [QueryProperty(nameof(EmployeeDetail), "EmployeeDetail")]
    public partial class AddEmployeeViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employeeDetail = new EmployeeModel();

        private readonly IDemoDataService _demoDataService;

        public AddEmployeeViewModel(IDemoDataService demoDataService)
        {
            _demoDataService = demoDataService;
        }

        [RelayCommand]
        public async void AddEmployee()
        {
            await _demoDataService.AddEmployee(new EmployeeModel()
            {
                FirstName = EmployeeDetail.FirstName,
                LastName = EmployeeDetail.LastName,
                Post = EmployeeDetail.Post,
                Date = EmployeeDetail.Date
            });
            await Shell.Current.GoToAsync("..");
        }
    }
}
