using System;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("John Doe", "1234567890", "ID123456");
            Console.WriteLine("Person:");
            person.Output();
            Console.WriteLine();

            Student student = new Student("Jane Smith", "0987654321", "ID654321", "Computer Science", "Group A", "123456");
            Console.WriteLine("Student:");
            student.Output();

        }
    }



    class Person
    {
        protected string name;
        protected string egn;
        protected string idCard;

       
        public Person()
        {
            name = "";
            egn = "";
            idCard = "";
        }

        
        public Person(string n, string e, string id)
        {
            name = n;
            egn = e;
            idCard = id;
        }

       
        public virtual void Output()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("EGN: " + egn);
            Console.WriteLine("ID Card: " + idCard);
        }
    }

    
    class Student : Person
    {
        protected string specialty;
        protected string group;
        protected string facultyNumber;

       
        public Student() : base()
        {
            specialty = "";
            group = "";
            facultyNumber = "";
        }

        
        public Student(string n, string e, string id, string spec, string grp, string facNum) : base(n, e, id)
        {
            specialty = spec;
            group = grp;
            facultyNumber = facNum;
        }

        
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Specialty: " + specialty);
            Console.WriteLine("Group: " + group);
            Console.WriteLine("Faculty Number: " + facultyNumber);
        }
    }

}