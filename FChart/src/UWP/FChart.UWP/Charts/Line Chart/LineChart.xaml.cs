using FChart.UWP.Charts.BaseLineCharts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    /// <summary>
    /// Line Charts
    /// </summary>
    public sealed partial class LineChart : UserControl
    {
        public LineChart()
        {
            this.InitializeComponent();
            CreateChart();
        }

        #region __Props__


        /// <summary>
        /// Set Forgrand Color For Grid
        /// </summary>
        public Brush ForgrandColor { get; set; }

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
        public int[,] ChartArray { get; set; }

        /// <summary>
        /// X Spaces Columns
        /// </summary>
        public double SpaceX { get; set; }

        /// <summary>
        /// Y Spaces Row
        /// </summary>
        public double SpaceY { get; set; }

        #endregion

        private void CreateChart()
        {
            
        }
    }
}
