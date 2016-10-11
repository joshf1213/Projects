using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class personinfo
    {
        public string firstName { get; set; }
        public string lastname { get; set; }
        public string birthDate { get; set; }
        public int age { get; set; }
       public static object PersonList { get; internal set; }
    }
     
}
