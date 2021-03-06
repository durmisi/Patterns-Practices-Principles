﻿using Patterns_Practices_Principles.Principles.SOLID.Single_responsibility_principle;

namespace Patterns_Practices_Principles.Principles.SOLID.Open_closed_principle
{
    //Now take the same ‘ReportGeneration’ class as an example of this principle.
    //Can you guess what is the problem with the below class!!

    public class ReportGeneration
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    //Brilliant!! Yes you are right, too much ‘If’ clauses are there
    //and if we want to introduce another new report type like ‘Excel’, then you need to write another ‘if’.
    //This class should be open for extension but closed for modification.But how to do that!!

    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }

    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate crystal report.
        }
    }

    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate PDF report.
        }
    }

    //So if you want to introduce a new report type, then just inherit from IReportGeneration.
    //So IReportGeneration is open for extension but closed for modification.
}