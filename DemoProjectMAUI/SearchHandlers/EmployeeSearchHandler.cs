using DemoProjectMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectMAUI.SearchHandlers
{
    public class EmployeeSearchHandler : SearchHandler
    {
        public IList<EmployeeModel> Employees { get; set; }

        public string NavigationRout { get; set; }
        public Type NavigationType { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Employees.Where(employee => employee.FirstName.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            var navParams = new Dictionary<string, object>
            {
                { "EmployeeDetailEdit", item }
            };
            if (!string.IsNullOrWhiteSpace(NavigationRout))
            {
                await Shell.Current.GoToAsync(NavigationRout, navParams);
            }
        }
    }
}
