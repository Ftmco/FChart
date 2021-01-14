using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FChart.UWP.Charts.BaseLineCharts
{
    /// <summary>
    /// Base Line Charts 
    /// Line Chart 
    /// Area Chart 
    /// </summary>
    public class BaseLineChart
    {
        /// <summary>
        /// X 
        /// </summary>
        public int LineX { get; set; }

        /// <summary>
        /// -X
        /// </summary>
        public int Line_X { get; set; }

        /// <summary>
        /// Y
        /// </summary>
        public int LineY { get; set; }

        /// <summary>
        /// -Y
        /// </summary>
        public int Line_Y { get; set; }

        /// <summary>
        /// Array Chart
        /// </summary>
        public int[,] MyProperty { get; set; }
    }
}
