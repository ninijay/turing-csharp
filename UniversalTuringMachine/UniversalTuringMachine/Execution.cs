using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalTuringMachine
{


    public partial class Execution : Form
    {
        public Execution(UniversalTuringMachine machine)
        {
            InitializeComponent();
            machine.StateComputed += Machine_StateComputed;
            machine.Perform();
            Trace.Listeners.Add(new TextBoxTraceListener(txtLog));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.WriteLine("Starting Main");
            Trace.Unindent();
        }

        private void Machine_StateComputed(string text)
        {
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = text;
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lvComputedOutputs.Items.Add(lvItem);
                }));
            }
            else
            {
                lvComputedOutputs.Items.Add(lvItem);
            }
        }
    }
}
