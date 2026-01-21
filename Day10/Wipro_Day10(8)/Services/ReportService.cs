using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;

namespace Wipro_Day10_8_.Services
{
    public class ReportService
    {
        private readonly ReportGenerator _generator;
        private readonly ReportFormatter _formatter;
        private readonly ReportSaver _saver;

        public ReportService(
            ReportGenerator generator,
            ReportFormatter formatter,
            ReportSaver saver)
        {
            _generator = generator;
            _formatter = formatter;
            _saver = saver;
        }

        public void ProcessReport(IReport report)
        {
            var content = _generator.Generate(report);
            var formattedContent = _formatter.Format(content);
            _saver.Save(formattedContent);
        }
    }
}
