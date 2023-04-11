using DemoProjectMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectMAUI.Services
{
    public interface IDemoDataService
    {
        public Task<List<EmployeeModel>> GetEmployees();

        public Task<EmployeeModel> GetEmployeeById(EmployeeModel employeeModel);

        public Task<int> AddEmployee(EmployeeModel employeeModel);

        public Task<int> EditEmployeeInfo(EmployeeModel employeeModel);

        public Task<int> DeleteAsync(EmployeeModel employeeModel);
    }
}
