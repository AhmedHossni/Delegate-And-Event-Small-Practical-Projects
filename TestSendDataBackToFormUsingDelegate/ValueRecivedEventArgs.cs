using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSendDataBackToFormUsingDelegate
{
    public class ValueRecivedEventArgs : EventArgs
    {
        public int Value { get; set; }

        public ValueRecivedEventArgs(int value)
        {
            Value = value;
        }
    }
}
