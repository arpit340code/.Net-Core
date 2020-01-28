using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FirstProject.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> _empList;
        public MockEmployeeRepository()
        {
            _empList = new List<Employee>()
            {
                new Employee(){ Id = 1,Name = "ABC", Department = "HR",Email = "ABC@gmail.com"},
                new Employee(){ Id = 2,Name = "ABC", Department = "IT",Email = "ABC@gmail.com"},
                new Employee(){ Id = 3,Name = "ABC", Department = "IT",Email = "ABC@gmail.com"},
                new Employee(){ Id = 4,Name = "ABC", Department = "IT",Email = "ABC@gmail.com"},
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _empList.FirstOrDefault(x => x.Id == Id);
        }

        public void Save()
        {
            
        }
    }
}