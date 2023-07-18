using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11
{
    public class Person
    {
        public string Name { get; set; }
        public static int Count = 0;
        public Person()
        {
            Count++;
        }
    }
}
