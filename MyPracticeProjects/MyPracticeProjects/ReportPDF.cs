using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.BuilderPatteren
{
    public class ReportPDF : ReportBuilder
    {
        public override void setReportType()
        {                    
            Console.WriteLine("PDF Report Created");
            objReport.strReportType = "PDF";

        }
    }
}
