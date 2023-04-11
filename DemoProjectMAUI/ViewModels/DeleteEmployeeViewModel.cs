using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoProjectMAUI.Models;
using DemoProjectMAUI.Services;
using DemoProjectMAUI.Views;

namespace DemoProjectMAUI.ViewModels
{
    [QueryProperty(nameof(EmployeeDetail), "EmployeeDetailDel")]
    public partial class DeleteEmployeeViewModel : ObservableObject
    {
        [ObservableProperty] 
        private EmployeeModel _employeeDetail = new EmployeeModel();
        
        private readonly IDemoDataService _demoDataService;

        public DeleteEmployeeViewModel(IDemoDataService demoDataService)
        {
            _demoDataService = demoDataService;
        }

        [RelayCommand]
        public async void DeleteEmployee()
        {
            await _demoDataService.DeleteAsync(EmployeeDetail);
            await Shell.Current.GoToAsync("..");
        }
    }
}
