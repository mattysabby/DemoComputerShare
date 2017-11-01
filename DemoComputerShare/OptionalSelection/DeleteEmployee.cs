using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DemoComputerShare.OptionalSelection
{
    public class DeleteEmployee : ISelectionOption
    {

        public override void ExecuteOption()
        {
            EmployeeDataServices dataService = new EmployeeDataServices();
            Console.WriteLine("Enter employeeId to delete");
            var eID = Console.ReadLine();
            int employeeId = Convert.ToInt32(eID);
            if(employeeId!= 0)
                dataService.DeleteEmployee(employeeId);
            

        }

        public DeleteEmployee()
        {
            Option = SelectionEnum.GetAllRecords;
        }
    }
}
