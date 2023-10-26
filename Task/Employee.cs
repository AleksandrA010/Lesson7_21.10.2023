using System;
using System.Collections.Generic;

namespace Task
{
    class Employee
    {
        private Dictionary<Departments, int> departments = new Dictionary<Departments, int>()
        {
            { Departments.ChiefDirector, 1},
            { Departments.FinanceDirector, 2},
            { Departments.Accounting, 3 },
            { Departments.DirectorOfAutomation, 2 },
            { Departments.InformationTechnologyDepartment, 3 },
            { Departments.SystemsAnalyst, 4 },
            { Departments.SystemsAnalystEmployee, 5 },
            { Departments.Development, 4 },
            { Departments.DevelopmentEmployee, 5 },
        };
        private string name;
        private Departments department;
        private int access;
        private int ID;
        private static int id = 0;
        private List<string> CurrentTasks = new List<string>();
        public Employee(string name, Departments department, int ID)
        {
            this.name = name;
            this.department = department;
            this.ID = ID;
            access = departments[department];
        }
        static public bool TryToDepartment(string department, out Departments DeDepartment)
        {
            bool flag = false;
            switch (department)
            {

                case "Development": 
                    DeDepartment = Departments.Development;
                    flag = true;
                    break;
                case "DevelopmentEmployee":
                    DeDepartment = Departments.DevelopmentEmployee;
                    flag = true;
                    break;
                case "InformationTechnologyDepartment":
                    DeDepartment = Departments.InformationTechnologyDepartment;
                    flag = true;
                    break;
                case "FinanceDirector":
                    DeDepartment = Departments.FinanceDirector;
                    flag = true;
                    break;
                case "SystemsAnalystEmployee":
                    DeDepartment = Departments.SystemsAnalystEmployee;
                    flag = true;
                    break;
                case "Accounting":
                    DeDepartment = Departments.Accounting;
                    flag = true;
                    break;
                case "DirectorOfAutomation":
                    DeDepartment = Departments.DirectorOfAutomation;
                    flag = true;
                    break;
                case "SystemsAnalyst":
                    DeDepartment = Departments.SystemsAnalyst;
                    flag = true;
                    break;
                default:
                    DeDepartment = Departments.Development;
                    Console.WriteLine("Такого отдела нет.");
                    break;
            }
            return flag;
        }
        public int GetID()
        {
            return ID;
        }
        public static void PrintDepartments()
        {
            foreach (var item in Enum.GetValues(typeof(Departments)))
                Console.WriteLine(item);
        }
        static public bool TryToDepartment(string department)
        {
            bool flag = false;
            switch (department)
            {

                case "Development":
                    flag = true;
                    break;
                case "DevelopmentEmployee":
                    flag = true;
                    break;
                case "InformationTechnologyDepartment":
                    flag = true;
                    break;
                case "FinanceDirector":
                    flag = true;
                    break;
                case "SystemsAnalystEmployee":
                    flag = true;
                    break;
                case "Accounting":
                    flag = true;
                    break;
                case "DirectorOfAutomation":
                    flag = true;
                    break;
                case "SystemsAnalyst":
                    flag = true;
                    break;
                default:
                    Console.WriteLine("Такого отдела нет.");
                    break;
            }
            return flag;
        }
        private void PrintTasks(List<string> CurrentTasks)
        {
            foreach (string item in CurrentTasks)
            {
                Console.WriteLine($"|{item}");
            }
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Имя — {name}");
            Console.WriteLine($"Отдел — {department}");
            Console.WriteLine($"ID — #{ID}");
            Console.WriteLine($"Точка доступа — {access}");
            Console.WriteLine("Текущие задачи:\n");
            PrintTasks(CurrentTasks);
        }
        public void AddTask(string Task) 
        {
            CurrentTasks.Add(Task);
        }
        public int GetAccess()
        {
            return access;
        }
        public static int NewID()
        {
            id++;
            return id;
        }
    }
}
