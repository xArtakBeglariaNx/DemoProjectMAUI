using SQLite;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoProjectMAUI.Models;

public class EmployeeModel
{
    [AutoIncrement, PrimaryKey]
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }    
    
    public string Post { get; set; }

    public DateTime Date { get; set; } = DateTime.Now.Date;
}
