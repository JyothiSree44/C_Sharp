using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;
using Wipro_Day10_8_.Fomatters;
using Wipro_Day10_8_.Models;
using Wipro_Day10_8_.Services;

namespace Wipro_Day10_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            // LSP: Using IReport reference
            IReport report = new SalesReport();

            // OCP: Choose formatter without modifying code
            IReportFormatter formatter = new PdfFormatter();

            // SRP + DIP: Inject dependencies
            var reportService = new ReportService(
                new ReportGenerator(),
                new ReportFormatter(formatter),
                new ReportSaver()
            );

            // Process the report
            reportService.ProcessReport(report);

            Console.ReadLine();
        }
    }
}
