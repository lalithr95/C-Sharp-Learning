using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    public class Degree 
    {
        public Degree(string name)
        {
            this.Degree1 = name;
            
        }
        private string _degree1;

        public string Degree1
        {
            get { return _degree1; }
            set { _degree1 = value; }
        }
        public Course c;
        
    }
}
