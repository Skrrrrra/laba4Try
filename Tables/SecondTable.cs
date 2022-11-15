using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4Try.Tables
{
    internal class SecondTable
    { 
        public double naSales { get; set; }
        public double euSales { get; set; }
        public double jpSales { get; set; }
        public double otherSales { get; set; }
        public double globalSales { get; set; }
        public SecondTable()
        {

        }
        public SecondTable(double NA,double EU,double JP,double OTHER,double GLOBAL)
        {
            naSales = NA;
            euSales = EU;
            jpSales = JP;
            otherSales = OTHER;
            globalSales = GLOBAL;
        }

    }
}
