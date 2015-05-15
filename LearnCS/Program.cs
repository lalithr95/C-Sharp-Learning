using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnCS
{
    public class Program
    {
        private static string program_name;

        public string Program_name
        {
            get { return program_name; }
            set { program_name = value; }
        }
        public static Degree d;
        static void Main(string[] args)
        {
            d = new Degree("Bachelor of Science Degree");
            d.c = new Course("Programming with C#");
            program_name = "Information of Technology";
            Console.WriteLine("The {0} program contains the {1}", program_name, d.Degree1);
            Console.WriteLine();
            Console.WriteLine("The {0} contains the course {1}", d.Degree1, d.c.Course1);
            Console.WriteLine();
            Console.WriteLine("The {0} course contains {1} student<s>", d.c.Course1, Student.count);
            Console.ReadLine();

        }


    }
}