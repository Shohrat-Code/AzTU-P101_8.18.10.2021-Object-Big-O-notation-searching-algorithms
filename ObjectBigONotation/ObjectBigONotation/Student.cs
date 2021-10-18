using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBigONotation
{
    class Student
    {
        public int Height = 15;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public bool IsMarried { get; set; }

        public void Fullinfo()
        {
            Console.WriteLine(this.Name + " " + this.Surname + " - " + this.Age);
        }
    }
}
