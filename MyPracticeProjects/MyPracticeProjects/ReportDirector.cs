using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.BuilderPatteren
{
    public class ReportDirector
    {

        public clsReport MakeReport(ReportBuilder objBuilder)
        {
            objBuilder.setReportType();           
            return objBuilder.GetReport();
        }
    }
}
