using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary
{
    public class BarChartObject
    {
        public string Label { get; set; }
        public float Value { get; set; }

        // constructor
        public BarChartObject( string l, float v)
        {
            Label = l;
            Value = v;
        }
    }
}
