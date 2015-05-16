using System;

namespace LearnCS1
{
    public struct student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string birthdate { get; set; }
        public string addressLine { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
    }
    public struct teacher
    {
        public string profname { get; set; }
        public string profdegree { get; set; }
        public string courses { get; set; }
        public string address { get; set; }

    }
    public struct program1
    {
        public string program_name { get; set; }
        public string program_duration { get; set; }
        public string program_fac { get; set; }
    }
    public struct course
    {
        public string course_duration { get; set; }
        public string course_name { get; set; }
    }
     class Module
    {
        static void main(string[] args)
        {
            student[] s = new student[5];
            s[0].firstname = "Lalith";
            s[0].lastname = "Rallabhandi";
            s[0].birthdate = "31-07-1995";
            s[0].addressLine = "Sri satya Sai";
            s[0].city = "Hyderbad";
            s[0].state = "Telangana";
            s[0].zip = "500060";
            s[0].country = "India";
            Console.WriteLine("Name is {0} {1}", s[0].firstname, s[0].lastname);
            Console.WriteLine("Birth date is {0}", s[0].birthdate);
            Console.WriteLine("Address Line is {0}", s[0].addressLine);
            Console.WriteLine("City is {0}", s[0].city);
            Console.WriteLine("state is {0}", s[0].state);
            Console.WriteLine("zip is {0}", s[0].zip);
            Console.WriteLine("country is {0}", s[0].country);
            Console.ReadLine();
        }
    }
}

