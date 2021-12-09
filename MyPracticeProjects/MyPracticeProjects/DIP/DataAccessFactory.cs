using System;
using System.Collections.Generic;
using System.Text;

namespace MyPracticeProjects.DIP
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
