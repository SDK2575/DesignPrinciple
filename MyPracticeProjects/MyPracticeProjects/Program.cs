using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPracticeProjects.DIP;

namespace MyPracticeProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            //calling IOC Code
            A objA = new A();
            objA.Task1();

            //calling DIP Code 

            CustomerBusinessLogic cbl = new CustomerBusinessLogic();
            string custName = cbl.GetCustomerName(5);

            Console.WriteLine("Customer Name: " + custName);
            Console.ReadLine();

        }
    }
}
