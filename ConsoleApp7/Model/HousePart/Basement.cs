using ConsoleApp7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Model.HousePart
{
    public class Basement : IPart
    {
        public int countPart { get; set; }
        public double price { get; set; }
        public string partName { get; set; }
        public int order { get; set; }

    }
}
