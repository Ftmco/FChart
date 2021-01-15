using System.Collections.Generic;
using FChart.Helpers;

namespace FChart.Wpf
{
    /// <summary>
    /// 
    /// </summary>
    public class AxisWindowCollection : NoisyCollection<AxisWindow>
    {
        public AxisWindowCollection()
        {
            NoisyCollectionChanged += OnNoisyCollectionChanged;
        }

        private void OnNoisyCollectionChanged(IEnumerable<AxisWindow> oldItems, IEnumerable<AxisWindow> newItems)
        {
            
        }
    }
}