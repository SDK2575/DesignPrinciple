using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.Factory_Patteren
{
    /// <summary>
    /// Interface for Printing and email documents
    /// </summary>
    public interface IDocuments
    {
        //Print Document 
        void Print();

        //email Document 
        void Email();
               

    }
}
