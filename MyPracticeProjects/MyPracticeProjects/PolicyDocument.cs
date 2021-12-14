using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.Factory_Patteren
{
    public class PolicyDocument : IDocuments
    {
        public void Email()
        {
            Console.WriteLine("Policy Document email to customer");
        }

        public void Print()
        {
            Console.WriteLine("Policy Document sent to printer");
        }
    }
}
