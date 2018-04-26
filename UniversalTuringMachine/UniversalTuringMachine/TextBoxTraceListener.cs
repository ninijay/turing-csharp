using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalTuringMachine
{
    class TextBoxTraceListener : TraceListener
    {
        private TextBox tBox;

        public TextBoxTraceListener(TextBox box)
        {
            this.tBox = box;
        }

        public override void Write(string msg)
        {
            if (tBox.InvokeRequired)
            {
                tBox.Invoke(new MethodInvoker(delegate {
                    tBox.Text += msg;
                }));
            }
            else
            {
                tBox.Text += msg;
            }
            //allows tBox to be updated from different thread
            //tBox.Parent.Invoke(new MethodInvoker(delegate ()
            //{
            //    tBox.Text += msg;
            //}));
        }

        public override void WriteLine(string msg)
        {
            Write(msg + "\r\n");
        }
    }
}
