using System;
using System.Collections.Generic;
using System.Text;

namespace MyPracticeProjects.DIP
{
    public class CustomerDataAccess : ICustomerDataAccess
    {

        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
