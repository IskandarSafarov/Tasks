using hr.Entities.Employees;
using hr.Services.Employees;

var employeeService = new EmployeeService();

Console.WriteLine("Выберете действия: \r\n" +
    "1. Создать сотрудника;\r\n" +
    "2. Удалить сотрудника;\r\n" +
    "3. Изменить сотрудника;\r\n" +
    "4. Получить список сотрудников;\r\n" +
    "5. Получить сотрудника;\r\n");

//var employees = employeeService.GetAll();

//foreach (var item in employees)
//{
//    Console.WriteLine(item.Name);
//}

var asw = Convert.ToInt32(Console.ReadLine());

switch (asw)
{
    case 1:
        Console.WriteLine();

        var address = Console.ReadLine();

        var employee = new Employee
        {
            Address = address,
        };

        employeeService.Create(employee);

        Console.WriteLine();
        break;
    case 2:


    default:
        Console.WriteLine("Такого действия нет!");
        break;
}