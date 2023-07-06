using hr.Absractions.Repositories;
using hr.Entities.Employees;

namespace hr.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Tom",
                Address = "Some address",
                Email = "Tom@mail.ru",
                Username = "tommy",
                Password = "1234",
                Salary = 1000M,
                Departament = "IT",
                Position = "Junior developer"
            }
        };

        public void Create(Employee employee)
        {
            employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = employees.Where(c => c.Id == id).FirstOrDefault();

            if (employee == null)
            {
                Console.WriteLine("Пользователь не найден!");

                return;
            }

            employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            var employee =  employees.Where(c => c.Id == id).FirstOrDefault();

            if (employee == null)
            {
                Console.WriteLine("Пользователь не найден!");

                return null;
            }

            return employee;
        }
    }
}
