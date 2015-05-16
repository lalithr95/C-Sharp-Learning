using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    public class Teacher : Person
    {
        public Teacher(string prof,string profdeg,string courses,string addr)
        {
            this.Name = prof;
            this.Profdegree = profdeg;
            this.Courses = courses;
            this.Address = addr;
        }
        
        private string _profdegree;

        public string Profdegree
        {
            get { return _profdegree; }
            set { _profdegree = value; }
        }
        private string _courses;

        public string Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher Grades test!");
        }
        
    }

    class Teacher1
    {
        public Teacher1(string prof,string profdeg,string courses,string addr)
        {
            this.Profname = prof;
            this.Profdegree = profdeg;
            this.Courses = courses;
            this.Address = addr;
        }
        private string _profname;

        public string Profname
        {
            get { return _profname; }
            set { _profname = value; }
        }
        private string _profdegree;

        public string Profdegree
        {
            get { return _profdegree; }
            set { _profdegree = value; }
        }
        private string _courses;

        public string Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        } 
    }
}
