using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_8_.Interfaces;

namespace Wipro_Day10_8_.Models
{
    public class InventoryReport : IReport
    {
        public string GetContent()
        {
            return "Inventory Report Content";
        }
    }

}
