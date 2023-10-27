namespace EmployeeManagementSystem.Models
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployees();
    }
}