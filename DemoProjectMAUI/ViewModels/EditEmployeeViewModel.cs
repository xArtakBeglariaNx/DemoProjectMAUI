using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoProjectMAUI.Models;
using DemoProjectMAUI.Services;
using DemoProjectMAUI.Views;

namespace DemoProjectMAUI.ViewModels
{
    [QueryProperty(nameof(EmployeeDetail), "EmployeeDetailEdit")]
    public partial class EditEmployeeViewModel : ObservableObject
    {
        [ObservableProperty] 
        private EmployeeModel _employeeDetail = new EmployeeModel();
        
        private readonly IDemoDataService _demoDataService;

        public EditEmployeeViewModel(IDemoDataService demoDataService)
        {
            _demoDataService = demoDataService;
        }

        [RelayCommand]
        public async void EditEmployeeInfo()
        {
            await _demoDataService.EditEmployeeInfo(EmployeeDetail);
            await Shell.Current.GoToAsync("..");
        }
    }
}
