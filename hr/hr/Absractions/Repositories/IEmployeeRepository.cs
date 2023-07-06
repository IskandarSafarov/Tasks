using hr.Entities.Employees;

namespace hr.Absractions.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void Create(Employee employee);
        public void Delete(int id);
        
    }
}
