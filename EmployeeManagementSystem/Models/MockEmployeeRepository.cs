using System.Security.Cryptography.X509Certificates;

namespace EmployeeManagementSystem.Models
{
    public class MockEmployeeRepository: IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList=new List<Employee>()
                   {
            new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
            new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
            new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" },
        };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
        
        public Employee GetEmployee(int Id)
        {
            foreach(var e in this._employeeList){
                if(e.Id == Id){
                    return e;
                }
            }
            return null;
            //return this._employeeList.FirstOrDefault
        
        }
    }
}