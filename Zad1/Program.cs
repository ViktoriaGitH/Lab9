using System;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5);
            Console.WriteLine("Лицето на кръга: " + circle.CalculateArea());

          
            Cylinder cylinder = new Cylinder(3, 7);
            Console.WriteLine("Обема на цилиндъра: " + cylinder.CalculateVolume());

            
            Cone cone = new Cone(4, 6);
            Console.WriteLine("Обема на конуса: " + cone.CalculateVolume());

        }
    }


    class Circle
    {
        protected double radius;

        // Конструктор по подразбиране
        public Circle()
        {
            radius = 0;
        }

        // Конструктор за инициализация на радиуса
        public Circle(double r)
        {
            radius = r;
        }

        
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }


    class Cylinder : Circle
    {
        protected double height;

        // Конструктор по подразбиране
        public Cylinder() : base()
        {
            height = 0;
        }

        
        public Cylinder(double r, double h) : base(r)
        {
            height = h;
        }

        
        public double CalculateVolume()
        {
            return base.CalculateArea() * height;
        }
    }


    class Cone : Circle
    {
        protected double height;

        
        public Cone() : base()
        {
            height = 0;
        }

        
        public Cone(double r, double h) : base(r)
        {
            height = h;
        }

        
        public double CalculateVolume()
        {
            return (1.0 / 3.0) * base.CalculateArea() * height;
        }
    }


}