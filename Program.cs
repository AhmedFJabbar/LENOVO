using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace oop3assignement
{
    class Student
    {
        public int id;
        public string name;
        public double mark;
        public Student(int id ,string name , double mark )
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student ;
            List<Student> studentslist = new List<Student>();
            Console.WriteLine("Enter the number of the student you want to add : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<number;i++)
            {
                Console.WriteLine($"Information of the student number {i+1} :");
                Console.WriteLine("Enter the student id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the student mark : ");
                double mark = Convert.ToInt32(Console.ReadLine());
                Student studenti = new Student(id,name,mark);
                studentslist.Add(studenti);
            }
            Console.WriteLine("The names of the students that have passed : ");
            for (int i = 0; i < number; i++)
                if (studentslist[i].mark >= 50)
                    Console.WriteLine(studentslist[i].name);

            
                Console.ReadKey();
        }
    }
}
