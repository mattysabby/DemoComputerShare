using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DemoComputerShare.OptionalSelection
{
    public class AddRecord : ISelectionOption
    {

        public override void ExecuteOption()
        {
            Console.WriteLine("New Employee Details");
            Console.WriteLine("Enter First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Sex");
            string sex = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname) && !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(sex))
            {
                Employee employee = new Employee()
                {
                    Email = email,
                    FirstName = firstname,
                    LastName = lastname,
                    Phone = phoneNumber,
                    Sex = sex
                };
                EmployeeDataServices dal = new EmployeeDataServices();
                dal.AddEmployee(employee);
                Console.WriteLine("Employee Added");
            }
            else
            {
                Console.WriteLine("Incomplete details were entered");
            }
        }

        public AddRecord()
        {
            Option = SelectionEnum.AddRecord;
        }
    }
    
}
