using ConsoleApp2;
using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a helLo world program in C#
            //Create instances of value types 
            var s = "Hello world :)";
            Console.WriteLine(s);

            //Create instances of reference types
            //Use static methods

            Employee e1 = new Employee("Elon", "Mask", new DateTime(1995,08,10));
            Employee e2 = new Employee("Sam", "Smith", new DateTime(2005, 12, 10));
            Employee e3 = new Employee("Jennifer", "Lawrence", new DateTime(1985, 12, 12));
            EmployeeAgregator.AddEmployee(e1);
            EmployeeAgregator.AddEmployee(e3);
            EmployeeAgregator.ShowAllEmployees();
            Console.WriteLine("Virsta angajatului " + e3.GetName() + " " + e3.GetSurname() + " este " + EmployeeAgregator.GetEmployeeAge(e3));

            //example of Parameter modifier
            //using ref to calculate recursive factorial, without return instruction
            int iteratii = 0;
            int value = 1;
            ParameterModifier.Recursive(5, ref value,  ref iteratii);
            Console.WriteLine("Factorialul numarului 5 este: " + value);
            Console.WriteLine("S-au efectuat " + iteratii + " iteratii");

            //using out to calculate number of vowels and consonants
            string text = "\"Acesta este stringul analizat\"";
            ParameterModifier.VowelsAndConsonants(text, out int vowels, out int consonants);
            Console.WriteLine(text + " \n Vocale: " + vowels + " Consoane: " + consonants);

            //boxing and unboxing
            BoxingAndUnboxing.Boxing(1);
            BoxingAndUnboxing.Boxing('s');
            BoxingAndUnboxing.Boxing("str");
            BoxingAndUnboxing.Boxing(120);
            BoxingAndUnboxing.Boxing(14.5);
            Console.WriteLine("Suma elementelor intregi este: " + BoxingAndUnboxing.SumOfIntElements());

            Console.ReadKey();


        }

    }

    public class Employee
    {
        private string name;
        private string surname;
        private DateTime birthday;

        public Employee(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            if (DateTime.Today.Year - birthday.Year < 18)
                Console.WriteLine("Nu pot fi angajati minori");
            else
                this.birthday = birthday;
        }

        public string GetName() { return this.name; }
        public string GetSurname() { return this.surname; }
        public DateTime GetBirthday() { return this.birthday; }

        public override string ToString()
        {
            return this.GetName() + " " + this.GetSurname() + " " + this.GetBirthday().ToShortDateString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee p = (Employee)obj;
            return ((this.GetName().ToLower() == p.GetName().ToLower()) 
                && (this.GetSurname().ToLower() == p.GetSurname().ToLower())
                && (this.GetBirthday().Date == p.GetBirthday().Date));
        }
    }

    public class EmployeeAgregator
    {
        private static List<Employee> list = new List<Employee>();

        public static void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        public static void DeleteEmployee(Employee employee)
        {
            foreach(Employee emp in list)
            {
                if (emp.Equals(employee)) list.Remove(emp);
            }
        }

        public static int GetEmployeeAge(Employee employee)
        {
            DateTime today = DateTime.Today;
            foreach (Employee emp in list)
            {
                if (emp.Equals(employee)) return today.Year - emp.GetBirthday().Year;
            }
            return -1;
        }

        public static void ShowAllEmployees()
        {
            Console.WriteLine("Toti angajatii:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
