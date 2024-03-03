using Microsoft.Build.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    //concept is that- high-level class must not depend upon a lower level class
     
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    } 



}
