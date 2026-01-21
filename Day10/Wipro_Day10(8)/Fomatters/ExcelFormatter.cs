using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;

namespace Wipro_Day10_8_.Fomatters
{
    public class ExcelFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[EXCEL FORMAT] {content}";
        }
    }
}
