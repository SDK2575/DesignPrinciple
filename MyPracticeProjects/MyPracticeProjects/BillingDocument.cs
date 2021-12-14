﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.Factory_Patteren
{
    public class BillingDocument : IDocuments
    {
        public void Email()
        {
            Console.WriteLine("Billing Document email to customer");
        }

        public void Print()
        {
            Console.WriteLine("Billing Document sent to printer");
        }
    }
}
