using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class Program1
    {
        static void main(string[] args)
        {
            

            string firstname, lastname, birthdate, addressLine1, addressLine2, city, state, zip, country;
            // contains student information
            string profname, profdegree;
            // contains professor name and degree
            string university_degree;
            string university_program;
            string university_department_head;
            string university_degrees_offered;

            firstname = "Lalith";
            lastname = "Rallabhandi";
            birthdate = "31-07-1995";
            addressLine1 = "Sri Satya Sai appts";
            addressLine2 = "Mohannagar";
            city = "Hyderabad";
            state = "Telangana";
            zip = "500060";
            country = "India";
            profname = "EDX";
            profdegree = "Phd";
            university_degree = "BE";
            university_program = "Computer science";
            university_department_head = "Dean";
            university_degrees_offered = "BE,MS,Phd";
            // Printing each details
            Console.WriteLine("Firstname " + firstname);
            Console.WriteLine("Lastname " + lastname);
            Console.WriteLine("Birthdate " + birthdate);
            Console.WriteLine("Address Line 1 " + addressLine1);
            Console.WriteLine("Address Line 2 " + addressLine2);
            Console.WriteLine("city " + city);
            Console.WriteLine("State " + state);
            Console.WriteLine("country " + country);
            Console.WriteLine("Zip " + zip);
            Console.WriteLine("Professor Name " + profname);
            Console.WriteLine("Professor Degree " + profdegree);
            Console.WriteLine("University Degree " + university_degree);
            Console.WriteLine("University program " + university_program);
            Console.WriteLine("University Department Head " + university_department_head);
            Console.WriteLine("University degrees Offered " + university_degrees_offered);

        }
    }
}
