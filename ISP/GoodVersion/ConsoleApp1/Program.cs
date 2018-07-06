using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Employee
    {
        private string name;
        private string surname;
        private double salary;
        private int idUnic;
        private static int id;
        
        public Employee(string name, string surname, double salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
            this.idUnic = id++;
        }

        public int GetId()
        {
            return this.idUnic;
        }

        public double GetSalary()
        {
            return this.salary;
        }
    }

    public static class EmployeeAgregator
    {
        public static List<Employee> list = new List<Employee>();
        public static void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        public static void DeleteEmployee(Employee employee)
        {
            list.Remove(employee);
        }

    }

    public class Accountant : Employee, IAccountant
    {
        public Accountant(string name, string surname, double salary) : base(name, surname, salary)
        {
        }

        public void CalculateSalary(Employee employee)
        {
            foreach(Employee employes in EmployeeAgregator.list)
            {
                if (employes.Equals(employee))
                    Console.Write("Salary: " + employes.GetSalary());
            }
        }

        public double PaySalary(Employee employee)
        {
            foreach (Employee employes in EmployeeAgregator.list)
            {
                if (employes.Equals(employee))
                    return  employes.GetSalary();
            }
            return -1;
        }
    }

    interface IAccountant
    {
        void CalculateSalary(Employee employee);
        double PaySalary(Employee employee);
    }

    public class Worker : Employee, IWorker
    {
        private List<Product> list = new List<Product>();
        public Worker(string name, string surname, double salary) : base(name, surname, salary)
        {
        }

        public void MakeProducts(Product product)
        {
            list.Add(product);
        }

        public List<Product> GetProducts()
        {
            return this.list;
        }
    }

    interface IWorker
    {
        void MakeProducts(Product product);
    }

    public class Manager : Employee, IManager
    {
        public Manager(string name, string surname, double salary) : base(name, surname, salary)
        {
        }

        public void Employ(Employee employee)
        {
            EmployeeAgregator.AddEmployee(employee);
        }

        public void FireEmployee(Employee employee)
        {
            EmployeeAgregator.DeleteEmployee(employee);
        }
    }

    interface IManager
    {
        void Employ(Employee employee);
        void FireEmployee(Employee employee);
    }

    public class Product
    {

    }
}
