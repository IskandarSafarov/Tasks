using hr.Entities.Common;

namespace hr.Entities.Employees
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Departament { get; set; }
    }
}
