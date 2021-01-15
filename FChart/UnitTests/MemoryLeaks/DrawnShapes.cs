using System;
using System.Diagnostics;
using System.Windows.Controls;
using FChart;
using FChart.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.MemoryLeaks
{
    [TestClass]
    public class DrawnShapes
    {
        [TestMethod]
        public void ShapesMemoryLeaks()
        {
            //var theGuy = BuildATestDude();
            //theGuy.MockIt(new CoreSize(200,200));
            //theGuy.Update();

            //var a = theGuy.GetDrawMarginElements();

            //Action countIt = () => Debug.WriteLine("Canvas -- {0} --, DrawMargin -- {1} --",
            //    theGuy.GetCanvasElements(), theGuy.GetDrawMarginElements());

            //Action<Canvas> iterateChildren = c =>
            //{
            //    foreach (var child in c.Children)
            //    {
            //        Debug.WriteLine("{0} ({1})", child.GetType().Name, child.GetHashCode());
            //    }
            //};

            //var canvas = (Canvas) theGuy.GetCanvas();

            ////Initial Count...
            //countIt();
            //iterateChildren(canvas);

            ////when cleaning series...
            //theGuy.Series.Clear();
            //countIt();
            //iterateChildren(canvas);

            ////When cleaning axes...
            //countIt();
            //theGuy.AxisX.Clear();
            //countIt();
            //theGuy.AxisY.Clear();
            //countIt();
            //iterateChildren(canvas);

            //Assert.IsTrue(a > 0, "No shapes were drawn to test the garbage collector!");
            //Assert.IsTrue(theGuy.GetDrawMarginElements() == 0,
            //    "There are shapes in the current DrawMargin, and no series to draw!");
            //Assert.IsTrue(theGuy.GetCanvasElements() == 1,
            //    "There are unnecessary elements in the current chart!");
        }

        private static FChart.Wpf.CartesianChart BuildATestDude()
        {
            return new FChart.Wpf.CartesianChart
            {
                Series = new SeriesCollection
                {
                    new FChart.Wpf.LineSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.VerticalLineSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.ColumnSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.RowSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.StackedAreaSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.VerticalStackedAreaSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.StackedRowSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.StackedRowSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.StackedColumnSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.StackedRowSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.OhlcSeries()
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    },
                    new FChart.Wpf.ScatterSeries
                    {
                        Values = new ChartValues<double> {2, 4, 5, 2}
                    }
                },
                AxisX = new FChart.Wpf.AxesCollection
                {
                    new FChart.Wpf.Axis
                    {
                        Sections = new FChart.Wpf.SectionsCollection
                        {
                            new FChart.Wpf.AxisSection { Value = 10, Label = "Hello!"},
                            new FChart.Wpf.AxisSection { Value = 10},
                            new FChart.Wpf.AxisSection { Value = 10}
                        }
                    }
                }
            };

        }
    }
}
