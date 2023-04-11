using DemoProjectMAUI.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectMAUI.Services
{
    public class DemoDataService : IDemoDataService
    {
        private SQLiteAsyncConnection _dataBase;

        public async Task Init()
        {
            if (_dataBase == null)
            {
                string dataBasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DemoProject.db3");
                _dataBase = new SQLiteAsyncConnection(dataBasePath);
                await _dataBase.CreateTableAsync<EmployeeModel>();
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            await Init();

            var employeesList = await _dataBase.Table<EmployeeModel>().ToListAsync();
            return employeesList;
        }

        public async Task<EmployeeModel> GetEmployeeById(EmployeeModel employee)
        {
            await Init();

            return await _dataBase.Table<EmployeeModel>().Where(i => i.Id == employee.Id).FirstOrDefaultAsync();
        }
        
        public async Task<int> AddEmployee(EmployeeModel employeeModel)
        {
            return await _dataBase.InsertAsync(employeeModel);
        }

        public async Task<int> EditEmployeeInfo(EmployeeModel employeeModel)
        {
            await Init();
            return await _dataBase.UpdateAsync(employeeModel);
        }

        public async Task<int> DeleteAsync(EmployeeModel employee)
        {
            await Init();

            return await _dataBase.DeleteAsync(employee);
        }

    }
}
