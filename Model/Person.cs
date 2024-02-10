using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_WPF_App.Model
{
    public class Person
    {        
        public string? Name { get; set; }
        public string? Address { get; set; }        
        public int PostalNumber { get; set; }
        public string? City { get; set; }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(Name)) 
                return true;
            /*
            if (string.IsNullOrEmpty(Address))
                return true;

            if (PostalNumber == 0) 
                return true;
            
            if (string.IsNullOrEmpty(City))
                return true;
            */
            return false;
        }
    }
}
