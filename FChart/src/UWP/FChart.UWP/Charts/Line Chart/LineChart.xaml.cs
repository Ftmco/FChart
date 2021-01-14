using FChart.UWP.Charts.BaseLineCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FChart.UWP.Charts.Line_Chart
{
    public sealed partial class LineChart : UserControl
    {
        public LineChart()
        {
            this.InitializeComponent();
        }

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
