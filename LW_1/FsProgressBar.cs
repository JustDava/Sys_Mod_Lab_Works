using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_1
{
    class FsProgressBar : ProgressBar
    {
        public new int Value
        {
            get { return base.Value; }
            set
            {
                base.Value = value;
                OnValueChanged(new ProgressBarChangedEventArgs() { Value = value });
                Invalidate();
            }
        }
        public event EventHandler<ProgressBarChangedEventArgs> ValueChanged;
        protected virtual void OnValueChanged(ProgressBarChangedEventArgs e)
        {
            EventHandler<ProgressBarChangedEventArgs> handler = ValueChanged;
            if (handler != null)
                handler(this, e);
        }
        public class ProgressBarChangedEventArgs
        {
            public int Value { get; set; }
        }
    }
}
