using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    public class Student : Person
    {
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public static int count=0;
        public Stack<Int32> Grades;
        public Student(string firstname,string name,string date,string address,string state,string country)
        {
            this.Firstname = firstname;
            this.Name = name;
            this.Birthdate = date;
            this.Address = address;
            this.State = state;
            this.Country = country;
            count++;
        }
        public void AddGrades()
        {
            Grades.Push(100);
            Grades.Push(95);
            Grades.Push(98);
            Grades.Push(97);
            Grades.Push(100);
        }
        public void PrintGrades()
        {
            foreach(int i in Grades)
            {
                Console.WriteLine(Grades.Peek());
                Grades.Pop();
            }
        }
        private string _birthdate;

        public string Birthdate
        {
          get { return _birthdate; }
          set { _birthdate = value; }
        }
        
        private string _state;

        public string State
        {
          get { return _state; }
          set { _state = value; }
        }
        private string _country;

        public string Country
        {
          get { return _country; }
          set { _country = value; }
        }

        public void TakeTest()
        {
            Console.WriteLine("Student take test!");
        }
    }


    class Student1
    {
        public static int count=0;
        public Student1(string name,string date,string address,string state,string country)
        {
            this.Firstname = name;
            this.Birthdate = date;
            this.AddressLine = address;
            this.State = state;
            this.Country = country;
            count++;
        }
        private string _firstname;

        public string Firstname
        {
          get { return _firstname; }
          set { _firstname = value; }
        }
        private string _birthdate;

        public string Birthdate
        {
          get { return _birthdate; }
          set { _birthdate = value; }
        }
        private string _addressLine;

        public string AddressLine
        {
          get { return _addressLine; }
          set { _addressLine = value; }
        }
        private string _state;

        public string State
        {
          get { return _state; }
          set { _state = value; }
        }
        private string _country;

        public string Country
        {
          get { return _country; }
          set { _country = value; }
        }
    }

}

