using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;

namespace Wipro_Day10_8_.Services
{
    public class ReportSaver
    {
        public void Save(string content)
        {
            Console.WriteLine("Saving Report...");
            Console.WriteLine(content);
        }
    }
}
