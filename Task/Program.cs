using System;
using System.Collections.Generic;

namespace Task
{
    enum Departments
    {
        ChiefDirector,
        FinanceDirector,
        Accounting,
        DirectorOfAutomation,
        InformationTechnologyDepartment,
        SystemsAnalyst,
        SystemsAnalystEmployee,
        Development,
        DevelopmentEmployee
    }
    internal class Program
    {
        static void Main()
        {
            bool flag = true;
            string name;
            string department;
            Employee employeeFrom;
            Employee employeeTo;
            var Employees = new List<Employee>();
            Employees.Add(new Employee("Tom", Departments.Development, Employee.NewID()));
            Employees.Add(new Employee("Beer", Departments.SystemsAnalyst, Employee.NewID()));
            Employees.Add(new Employee("Cool", Departments.SystemsAnalystEmployee, Employee.NewID()));
            while (flag)
            {
                Console.WriteLine("-------------------------------------------------------------\n");
                Console.WriteLine("break — выход из программы.");
                Console.WriteLine("getEmployees — получить информацию о всех работниках выбранного отдела.");
                Console.WriteLine("getDepartments — получить информацию о всех отделах");
                Console.WriteLine("setTask — присвоить задачу сотруднику.");
                Console.WriteLine("setEmployee — создать нового сотрудника в выбранный отдел.");
                Console.WriteLine("deleteEmployee — удалить сотрудника в выбранном отделе.");
                Console.WriteLine("\n-------------------------------------------------------------\n");
                Console.Write("Введите команду: ");
                string answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {
                    case "break":
                        flag = false;
                        break;
                    case "getEmployees":
                        for (int i = 0; i < Employees.Count; i++)
                        {
                            Employees[i].PrintEmployee();
                        }
                        Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "getDepartments":
                        Employee.PrintDepartments();
                        Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "setTask":
                        Console.Write("Введите ID сотрудника, который даёт задание: ");
                        int IDFrom = int.Parse(Console.ReadLine());
                        Console.Write("Введите ID сотрудника, который получает задание: ");
                        int IDTo = int.Parse(Console.ReadLine());
                        foreach (var item in Employees)
                        {
                            if (item.GetID() == IDFrom)
                            {
                                employeeFrom = item;
                            }
                            else if (item.GetID() == IDTo)
                            {
                                employeeTo = item;
                            }
                        }
                        Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "setEmployee":
                        Console.Write("Введите имя нового сотрудника: ");
                        name = Console.ReadLine();
                        Employee.PrintDepartments();
                        Console.Write("Введите отдел в который хотите определить сотрудника: ");
                        department = Console.ReadLine();
                        Employee.TryToDepartment(department, out Departments DeDepartment);
                        Employees.Add(new Employee(name, DeDepartment, Employee.NewID()));
                        Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "deleteEmployee":
                        Console.Write("Введите ID сотрудника, которого хотите удалить: ");
                        int IDDelete = int.Parse(Console.ReadLine());
                        foreach (var item in Employees)
                        {
                            if (item.GetID() == IDDelete)
                            {
                                Employees.Remove(item);
                            }
                        }
                            Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Команда введена не правильно.");
                        Console.Write("Для продолжение нажмите любую клавишу: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
