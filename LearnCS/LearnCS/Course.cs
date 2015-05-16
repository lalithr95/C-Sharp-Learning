using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    public class Course
    {
        public List<Student> std;
        public List<Teacher> tech;
        
        public Course(string cname)
        {
            this.Course1 = cname;
            std = new List<Student>();
            std.Add(new Student("Lalith","Rallabhandi","5/6/2015","Sample address","Telangane","India"));
            std.Add(new Student("Test","User","5/6/2015","Sample address","Telangane","India"));
            std.Add(new Student("Rallabhandi","Hacker","5/6/2015","Sample address","Telangane","India"));
            

            tech = new List<Teacher>();
            tech.Add(new Teacher("Bill Gates","Professor","C,C#,ASP","Micrsoft Inc."));



        }

        public void ListStudents()
        {
            foreach(Student s in std)
            {
                Console.WriteLine("{0} {1}",s.Firstname,s.Name);
            }
        }
        private string _course;

        
        public string Course1
        {
            get { return _course; }
            set { _course = value; }
        }
        
    }
    class Course2
    {
        public Student[] std;
        public Teacher[] tech;

        public Course2(string cname)
        {
            this.Course1 = cname;
            std = new Student[3];
            std[0] = new Student("Lalith","Test", "5/6/2015", "Sample address", "Telangane", "India");
            std[1] = new Student("Lalith","Yesy" ,"5/6/2015", "Sample address", "Telangane", "India");
            std[2] = new Student("Lalith","Lol", "5/6/2015", "Sample address", "Telangane", "India");

            tech = new Teacher[3];
            tech[0] = new Teacher("Bill Gates", "Professor", "C,C#,ASP", "Micrsoft Inc.");



        }
        private string _course;


        public string Course1
        {
            get { return _course; }
            set { _course = value; }
        }

    }
}
