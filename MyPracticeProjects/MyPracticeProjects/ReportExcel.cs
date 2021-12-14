using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.BuilderPatteren
{
    public class ReportExcel : ReportBuilder
    {
        public override void setReportType()
        {
            Console.WriteLine("Excel Report Created");
            objReport.strReportType = "Excel";
        }
    }
}
