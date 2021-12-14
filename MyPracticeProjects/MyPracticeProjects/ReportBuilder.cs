using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPracticeProjects.BuilderPatteren
{
    public abstract class ReportBuilder
    {
        protected clsReport objReport;

        public abstract void setReportType();


        public clsReport GetReport()
        {

            return objReport;
        }

    }
}
