using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Reid = new Student();
            Reid.FirstName = "Reid";
            Reid.LastName = "Harrington";
            Reid.SoonerID = 113395107;
            Reid.IsOnProbation = false;
            Reid.GPA = 3.72;

            Student Tim = new Student(3, "Timothy", "Fisher", 85000);
        }
    }
}
