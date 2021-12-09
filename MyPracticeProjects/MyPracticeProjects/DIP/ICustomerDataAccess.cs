using System;
using System.Collections.Generic;
using System.Text;

namespace MyPracticeProjects.DIP
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);

    }
}
