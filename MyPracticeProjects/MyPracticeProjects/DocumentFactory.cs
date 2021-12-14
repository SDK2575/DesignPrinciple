using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.Factory_Patteren
{

    /// <summary>
    /// Document Factory to create difference type of documents
    /// </summary>
    public class DocumentFactory
    {

        static public IDocuments GetDocuments(int DocType)
        {

            IDocuments objDoc = null;

            if (DocType == 1)
            {
                objDoc = new PolicyDocument();

                objDoc.Email();
                objDoc.Print();
            }

            if (DocType == 2)
            {

                objDoc = new BillingDocument();
                objDoc.Email();
                objDoc.Print();
            }

            return objDoc;

        }

    }
}
