using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;


namespace Wipro_Day10_8_.Services
{
    public class ReportFormatter
    {
        private readonly IReportFormatter _formatter;

        public ReportFormatter(IReportFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Format(string content)
        {
            return _formatter.Format(content);
        }
    }
}
