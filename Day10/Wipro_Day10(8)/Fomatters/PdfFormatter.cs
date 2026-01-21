using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;

namespace Wipro_Day10_8_.Fomatters
{
    public class PdfFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[PDF FORMAT] {content}";
        }
    }
}
