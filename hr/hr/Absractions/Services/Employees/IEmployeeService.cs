using hr.Entities.Employees;

namespace hr.Absractions.Services.Employees
{
    public interface IEmployeeService
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void Create(Employee employee);
        public void Delete(int id);
    }
}
