using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Student(string fname, string lname, string contact)
        {
            this.Firstname = fname;
            this.Lastname = lname;
            this.City = contact;
        }
        
    }
}
