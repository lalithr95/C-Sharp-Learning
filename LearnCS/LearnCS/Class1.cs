using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class Class1
    {
        static string firstname, lastname, dob, addressline1, addressline2, city, state, country, zip, degree, course;
        static string fac_firstname, fac_lastname, fac_dob, fac_addressline1, fac_addressline2, fac_city, fac_state, fac_country, fac_zip, fac_degree, fac_course;
        static string course_duration, course_name, course_faculty;
        static string program_name, program_duration, program_fac;
        static void ValidateStudentDOB()
        {
            // method not yet developed
            throw new NotImplementedException();

        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter Student First name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter Student Last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            dob = Console.ReadLine();
            Console.WriteLine("Enter Address Line 1");
            addressline1 = Console.ReadLine();
            Console.WriteLine("Enter Address Line 2");
            addressline2 = Console.ReadLine();
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            Console.WriteLine("Enter State");
            state = Console.ReadLine();
            Console.WriteLine("Enter Country");
            country = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            zip = Console.ReadLine();
            Console.WriteLine("Enter Degree");
            degree = Console.ReadLine();
            Console.WriteLine("Enter course");
            course = Console.ReadLine();
        }
        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter faculty First name");
            fac_firstname = Console.ReadLine();
            Console.WriteLine("Enter faculty Last name");
            fac_lastname = Console.ReadLine();
            Console.WriteLine("Enter faculty Date of Birth");
            fac_dob = Console.ReadLine();
            Console.WriteLine("Enter faculty Address Line 1");
            fac_addressline1 = Console.ReadLine();
            Console.WriteLine("Enter faculty Address Line 2");
            fac_addressline2 = Console.ReadLine();
            Console.WriteLine("Enter faculty City");
            fac_city = Console.ReadLine();
            Console.WriteLine("Enter faculty State");
            fac_state = Console.ReadLine();
            Console.WriteLine("Enter faculty Country");
            fac_country = Console.ReadLine();
            Console.WriteLine("Enter faculty Zip");
            fac_zip = Console.ReadLine();
            Console.WriteLine("Enter Teaching Experience in years");
            fac_degree = Console.ReadLine();
            Console.WriteLine("Enter Teaching course");
            fac_course = Console.ReadLine();
        }
        static void GetCourseInfo()
        {
            Console.WriteLine("Enter Course name");
            course_name = Console.ReadLine();
            Console.WriteLine("Enter Course duration");
            course_duration = Console.ReadLine();
            Console.WriteLine("Enter Course faculty");
            course_faculty = Console.ReadLine();

        }
        static void GetProgramDetails()
        {
            Console.WriteLine("Enter Program name");
            program_name = Console.ReadLine();
            Console.WriteLine("Enter Program duration");
            program_duration = Console.ReadLine();
            Console.WriteLine("Enter Program faculty head");
            program_fac = Console.ReadLine();
        }

        static void PrintStudentDetails()
        {
            Console.WriteLine("Student First name " + firstname);

            Console.WriteLine("Student Last name " + lastname);

            Console.WriteLine("Date of Birth " + dob);

            Console.WriteLine("Address Line 1 " + addressline1);

            Console.WriteLine("Address Line 2 " + addressline2);

            Console.WriteLine("City " + city);

            Console.WriteLine("State " + state);

            Console.WriteLine("Country " + country);

            Console.WriteLine("Zip " + zip);

            Console.WriteLine("Degree " + degree);

            Console.WriteLine("course " + course);

        }
        static void PrintTeacherDetails()
        {
            Console.WriteLine("Faculty First name " + fac_firstname);

            Console.WriteLine("Faculty Last name " + fac_lastname);

            Console.WriteLine("Date of Birth " + fac_dob);

            Console.WriteLine("Address Line 1 " + fac_addressline1);

            Console.WriteLine("Address Line 2 " + fac_addressline2);

            Console.WriteLine("City " + fac_city);

            Console.WriteLine("State " + fac_state);

            Console.WriteLine("Country " + fac_country);

            Console.WriteLine("Zip " + fac_zip);

            Console.WriteLine("Teaching Experience in years " + fac_degree);

            Console.WriteLine("Faculty course " + fac_course);
        }
        static void PrintCourseDetails()
        {
            Console.WriteLine("Course name " + course_name);

            Console.WriteLine("Course duration " + course_duration);

            Console.WriteLine("Course faculty " + course_faculty);

        }
        static void PrintProgramDetails()
        {
            Console.WriteLine("Program name " + program_name);

            Console.WriteLine("Program duration " + program_duration);

            Console.WriteLine("Program faculty head " + program_fac);

        }
        static void Main(string[] args)
        {
            try
            {
                ValidateStudentDOB();
            }
            catch (NotImplementedException nie)
            {
                Console.WriteLine(nie.Message);
            }
            Console.WriteLine("Enter Student Details");
            GetStudentInfo();
            Console.WriteLine("Student Details");
            PrintStudentDetails();
            Console.WriteLine("Enter Teacher Details");
            GetTeacherInfo();
            Console.WriteLine("Teacher Details");
            PrintTeacherDetails();
            Console.WriteLine("Enter Course Details");
            GetCourseInfo();
            Console.WriteLine("Course Details");
            PrintCourseDetails();
            Console.WriteLine("Enter Program Details");
            GetProgramDetails();
            Console.WriteLine("Program Details");
            PrintCourseDetails();
        }
    }
}
