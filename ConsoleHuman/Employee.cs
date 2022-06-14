using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHuman
{
    class Employee:Human
    {
        public string Position { get; set; }
        public Employee()
        {

        }
        public Employee(string empname, string empsurname, int empage, string position) : base(empname, empsurname, empage)
        {
            Position = position;
        }
    }
}
