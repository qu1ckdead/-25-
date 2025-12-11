using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: struct Color - копирование значений
            Console.WriteLine("=== Задание 1: struct Color ===");
            var c1 = new Color(255, 128, 0);
            var c2 = c1;  
            c2.R = 100;
            Console.WriteLine(c1); 
            Console.WriteLine(c2); 

            // Задание 2: class Order - ссылочная передача
            Console.WriteLine("\n=== Задание 2: class Order ===");
            var order1 = new Order { Id = 1001, Total = 1500.50m };
            var order2 = order1;  
            order2.Total = 2000.00m;
            Console.WriteLine(order1.Total); 
            Console.WriteLine(order1);

            // Задание 3: enum FileAccess + struct File
            Console.WriteLine("\n=== Задание 3: FileAccess и File ===");
            var file = new File { Permissions = FileAccess.Read | FileAccess.Write };
            Console.WriteLine($"Может читать: {file.CanRead()}");     
            Console.WriteLine($"Может писать: {file.CanWrite()}");   
            Console.WriteLine($"Может выполнять: {file.CanExecute()}"); 

            // Проверка флагов
            var executableFile = new File { Permissions = FileAccess.Execute | FileAccess.Read };
            Console.WriteLine($"Битовое представление: {(int)executableFile.Permissions}"); 

            // Задание 4: nullable double? - температура
            Console.WriteLine("\n=== Задание 4: struct Weather ===");
            var w1 = new Weather { City = "Москва", Temperature = 22.5 };
            var w2 = new Weather { City = "Сочи", Temperature = null };

            Console.WriteLine(w1); 
            Console.WriteLine(w2); 

            // Использование оператора ??
            Console.WriteLine($"Температура в Сочи: {w2.Temperature ?? -999}"); 
            Console.WriteLine($"Температура в Москве: {w1.GetTemperatureOrDefault(-999)}");

            // Проверка HasValue
            if (!w2.Temperature.HasValue)
            {
                Console.WriteLine("Данные о температуре в Сочи отсутствуют");
            }

            // Задание 5: class Employee + DateTime? + enum Status
            Console.WriteLine("\n=== Задание 5: class Employee ===");
            var emp = new Employee
            {
                Name = "Пётр",
                HireDate = new DateTime(2020, 3, 15),
                Status = EmploymentStatus.Active
            };

            Console.WriteLine($"Годы работы: {emp.GetYearsWorked()}"); 
            Console.WriteLine(emp);

            // Работа с nullable DateTime
            emp.HireDate = null;
            Console.WriteLine($"\nПосле обнуления даты приема:");
            Console.WriteLine($"Годы работы: {emp.GetYearsWorked()}"); 
            Console.WriteLine(emp);

            // Примеры с разными статусами
            var emp2 = new Employee
            {
                Name = "Анна",
                HireDate = new DateTime(2018, 7, 1),
                Status = EmploymentStatus.OnLeave
            };
            Console.WriteLine($"\nДругой сотрудник:");
            Console.WriteLine(emp2);

            // Проверка HasValue для DateTime?
            if (emp2.HireDate.HasValue)
            {
                Console.WriteLine($"Анна была принята {emp2.HireDate.Value:dd.MM.yyyy}");
            }
        }
    }
}
