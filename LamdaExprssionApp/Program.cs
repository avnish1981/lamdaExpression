using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExprssionApp
{
   /* => is called lamda operator and read as Goes TO. Notice that within lamda expression you don't have to use delegate 
    keyword explicity and you don't have to specify the input parameter type explicity. */
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemp = new List<Employee>
            {
                new Employee{eid=101,ename="Avnish"},
                 new Employee{eid=102,ename="Manish"},
                  new Employee{eid=103,ename="Sohan"},
                   new Employee{eid=104,ename="Kanita"}
                   

            };

            LamdaExprssionApp.Employee emp = listemp.Find(empl => empl.eid == 102); // => read as "GOES TO "
            Console.WriteLine("Eid :{0} and Name :{1}", emp.eid, emp.ename);
        }
    }

    public class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }
    }
}
