using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details("sravani","15a81a0589","cse",4,40);
            Details d1 = new Details("sravan", "15a81a059", "cse", 84, 040);
            /*d.Name = "sravani";
              d.Rollno = "15a81a0589";
              d.Sem = 1;
              d.AcceptStudentDetails();*/
            d.DisplayDetails();
            d1.DisplayDetails();
            Console.ReadKey();
        }
    }
}
