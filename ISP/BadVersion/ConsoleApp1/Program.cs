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

        public abstract void CalculateSalary(Employee employee);
        public abstract double PaySalary(Employee employee);
        public abstract void MakeProducts(Product product);
        public abstract void Employ(Employee employee);
        public abstract void FireEmployee(Employee employee);
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

    public class Accountant : Employee
    {
        public Accountant(string name, string surname, double salary) : base(name, surname, salary)
        { }


        public override void CalculateSalary(Employee employee)
        {
            foreach (Employee employes in EmployeeAgregator.list)
            {
                if (employes.Equals(employee))
                    Console.Write("Salary: " + employes.GetSalary());
            }
        }

        public override void Employ(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void FireEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void MakeProducts(Product product)
        {
            throw new NotImplementedException();
        }

        public override double PaySalary(Employee employee)
        {
            foreach (Employee employes in EmployeeAgregator.list)
            {
                if (employes.Equals(employee))
                    return employes.GetSalary();
            }
            return -1;
        }
    }

    public class Worker : Employee
    {
        private List<Product> list = new List<Product>();
        public Worker(string name, string surname, double salary) : base(name, surname, salary)
        {
        }

        public List<Product> GetProducts()
        {
            return this.list;
        }

        public override void CalculateSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override double PaySalary(Employee employee)
        {
            throw new NotImplementedException();
        }


        public override void Employ(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void FireEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void MakeProducts(Product product)
        {
            list.Add(product);
        }
    }

    public class Manager : Employee { 
        public Manager(string name, string surname, double salary) : base(name, surname, salary)
        {
        }

        public override void CalculateSalary(Employee employee)
        {
            throw new NotImplementedException();
        }


        public override void Employ(Employee employee)
        {
            EmployeeAgregator.AddEmployee(employee);
        }

        public override void FireEmployee(Employee employee)
        {
            EmployeeAgregator.DeleteEmployee(employee);
        }

        public override void MakeProducts(Product product)
        {
            throw new NotImplementedException();
        }

        public override double PaySalary(Employee employee)
        {
            throw new NotImplementedException();
        }
    }


    public class Product
    {

    }

}
