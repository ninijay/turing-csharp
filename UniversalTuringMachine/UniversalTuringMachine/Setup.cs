using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalTuringMachine
{
    public partial class Setup : Form
    {

        public List<State> States { get; set; }
        public List<Calc> Calcs { get; set; }
        int cnt = 0;
        public Setup()
        {
            States = new List<State>();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            States.Add(new State("q" + cnt, cnt));
            lstStates.Items.Add(States[cnt].Name);
            updateStates();
             cnt++;
        }


        private void updateStates()
        {
            ddInitial.DataSource = null;
            ddInitial.DataSource = States;
            ddInitial.DisplayMember = "Name";
            ddInitial.ValueMember = "Cnt";

            ddCurr.DataSource = null;
            ddCurr.DataSource = States;
            ddCurr.DisplayMember = "Name";
            ddCurr.ValueMember = "Cnt";

            ddNext.DataSource = null;
            ddNext.DataSource = States;
            ddNext.DisplayMember = "Name";
            ddNext.ValueMember = "Cnt";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(cnt-1 < 0)
            {

            }
            else
            {
                States.RemoveAt(cnt - 1);
                lstStates.Items.RemoveAt(cnt - 1);
                cnt--;
            }

            updateStates();
        }

        private void btnAddSymbol_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtSymbols.Text))
            {
                MessageBox.Show("Please enter a Symbol");
            }
            else if(txtSymbols.Text.Count() > 1)
            {
                MessageBox.Show("Please enter only ONE Symbol");
            }
            else
            {
                lstSymbols.Items.Add(txtSymbols.Text);
            }

        }

        private void lstSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            Calcs.Add(new Calc(States[Int32.Parse(ddCurr.SelectedValue.ToString())], 
                        States[Int32.Parse(ddNext.SelectedValue.ToString())], 
                        Int32.Parse(cbDir.SelectedValue.ToString()), 
                        ddSymbols.SelectedText[0], 
                        ddWrite.SelectedText[0]));
        }
    }
}
