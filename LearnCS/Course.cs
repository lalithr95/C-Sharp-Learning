﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    public class Course
    {
        public Student[] std;
        public Teacher []tech;
        
        public Course(string cname)
        {
            this.Course1 = cname;
            std = new Student[3];
            std[0] = new Student("Lalith","5/6/2015","Sample address","Telangane","India");
            std[1] = new Student("Lalith","5/6/2015","Sample address","Telangane","India");
            std[2] = new Student("Lalith","5/6/2015","Sample address","Telangane","India");

            tech = new Teacher[3];
            tech[0] = new Teacher("Bill Gates","Professor","C,C#,ASP","Micrsoft Inc.");



        }
        private string _course;

        
        public string Course1
        {
            get { return _course; }
            set { _course = value; }
        }
        
    }
}
