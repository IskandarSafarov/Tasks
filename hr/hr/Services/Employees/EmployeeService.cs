using hr.Absractions.Services.Employees;
using hr.Entities.Employees;
using hr.Repositories;
using hr.Services.Emails;

namespace hr.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private EmailService _emailService = new();
        private EmployeeRepository _repository = new();

        public void Create(Employee employee)
        {
            _repository.Create(employee);

            _emailService.Send(employee.Email, employee.Name);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public Employee GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
