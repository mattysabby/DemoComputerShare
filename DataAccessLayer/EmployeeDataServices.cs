using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDataServices
    {
        private List<Employee> Employees { get; set; }

        public EmployeeDataServices()
        {
            if (File.Exists("./Employee.dat"))
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream("./Employee.dat", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    this.Employees = (List<Employee>)formatter.Deserialize(stream);
                }
            }
            else
            {
                this.Employees = new List<Employee>();
                SeedEmployess();
            }
        }

        private void Save()
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("./Employee.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, this.Employees);
            }
        }

        private void SeedEmployess()
        {
            var pun = new Employee
            {
                EmployeeId = 6,
                Email = "john.doe@medical.com",
                FirstName = "John",
                LastName = "Joe",
                Phone = "6478541278",
                Sex = "Male"
            };

            this.Employees.Add(pun);
            Save();
        }
        public Employee[] GetEmployees()
        {
            return this.Employees.ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            return this.Employees.SingleOrDefault(p => p.EmployeeId == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            var found = this.Employees.SingleOrDefault(p => p.EmployeeId == employee.EmployeeId);
            if (found != null)
            {
                this.Employees.Remove(found);
                this.Employees.Add(employee);
                Save();
            }
        }

        public void AddEmployee(Employee employee)
        {
            var lastID = this.Employees.Max(p => p.EmployeeId);
            employee.EmployeeId = lastID + 1;
            this.Employees.Add(employee);
            Save();
        }

        public void DeleteEmployee(int id)
        {
            var pun = this.Employees.SingleOrDefault(p => p.EmployeeId == id);
            this.Employees.Remove(pun);
            Save();
        }
    }
}
