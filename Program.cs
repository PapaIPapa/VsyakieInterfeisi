using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsyakieInterfeisi
{
    public interface IAnimal
    {
        string Name { get; set; }
        void MakeSound();
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Гав!");
        }
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Мяу!");
        }
    }

    public interface IShape
    {
        double Area();
        double Perimeter();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area() {
            return Math.PI * this.radius * this.radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }

        public double Perimeter() 
        { 
            return 2 * (width + height);
        }
    }

    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            
        }
        public double Perimeter() 
        { 
            return a + b + c; 
        }
    }

    public interface IComparable<T>
    {
        int CompareTo(T other);
    }

    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            if (Age == other.Age) 
            {
                return 1;
            }
            else { return 0; }
        }
    }

    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public int CompareTo(Book other)
        {
            if (Price == other.Price)
            {
                return 1;
            }
            else { return 0; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Dog barbos = new Dog("Барбос");
            barbos.MakeSound();
            Cat murzik = new Cat("Мурзик");
            murzik.MakeSound();

            Circle f1 = new Circle(5);
            double f1_area = f1.Area();
            double f1_perim = f1.Perimeter();
            Console.WriteLine($"area: {f1_area}  perim: {f1_perim}");

            Student s1 = new Student("Валера", 20, 5);
            Student s2 = new Student("Егор", 20, 5);
            Student s3 = new Student("Игорь", 25, 10);
            int comp = s1.CompareTo(s2);
            Console.WriteLine(comp);
            comp = s1.CompareTo(s3);
            Console.WriteLine(comp);
            Console.ReadLine();


        }
    }
}
