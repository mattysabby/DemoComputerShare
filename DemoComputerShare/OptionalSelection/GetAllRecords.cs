using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DemoComputerShare.OptionalSelection
{
    public class GetAllRecords : ISelectionOption
    {
        
        public override void ExecuteOption()
        {
            EmployeeDataServices dataService = new EmployeeDataServices();
            var employees =  dataService.GetEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine("Current Employees");
                Console.WriteLine($"Employee Name: {employee.FirstName}  {employee.LastName}");
                Console.WriteLine($"Employee Email: {employee.Email}  and Phone: {employee.Phone}");
                Console.WriteLine("**********");
            }
           
        }

        public GetAllRecords()
        {
            Option = SelectionEnum.GetAllRecords;
        }
    }
}
