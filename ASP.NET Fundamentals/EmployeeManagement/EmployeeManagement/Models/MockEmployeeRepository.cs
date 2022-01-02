using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeelist;

        public MockEmployeeRepository()
        {
            _employeelist = new List<Employee>()
            {
                new Employee(){ID=1, Name= "mary",Email="abc@gmail.com" ,Department="computer",},
                new Employee(){ID=2, Name= "d",Email="cds@gmail.com" ,Department="it",},
                new Employee(){ID=3, Name= "abc",Email="ddcb@gmail.com" ,Department="civil",}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeelist;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeelist.FirstOrDefault(e => e.ID == Id);
        }

       
    }
}
