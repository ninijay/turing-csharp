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

        public UniversalTuringMachine Machine { get; set; }
        public List<State> States { get; set; }
        public List<Calc> Calcs { get; set; }
        int cnt = 0;
        public Setup()
        {
            var dirs = new[]
            {
                new { Val = 1, Text = "Right"},
                new { Val = -1, Text = "Left"},
                new { Val = 0, Text = "Nowhere"}

            };
            States = new List<State>();
            Calcs = new List<Calc>();
            InitializeComponent();
            dataGridView1.UserDeletedRow += DataGridView1_UserDeletedRow;
            lstSymbols.Items.Add(string.Format("{0}",UniversalTuringMachine._blank));
            ddSymbols.Items.Add(string.Format("{0}", UniversalTuringMachine._blank));
            ddWrite.Items.Add(string.Format("{0}", UniversalTuringMachine._blank));

            cbDir.DataSource = dirs;
            cbDir.DisplayMember = "Text";
            cbDir.ValueMember = "Val";
            updateStates();
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine(Calcs);
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
                ddSymbols.Items.Add(txtSymbols.Text);
                ddWrite.Items.Add(txtSymbols.Text);
                comboBox1.Items.Add(txtSymbols.Text);
                txtSymbols.Text = "";
                txtSymbols.Select();
            }

        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            // Fix bug eith strings and chars
            Calcs.Add(new Calc(States[Int32.Parse(ddCurr.SelectedValue.ToString())], 
                        States[Int32.Parse(ddNext.SelectedValue.ToString())], 
                        Int32.Parse(cbDir.SelectedValue.ToString()), 
                        ddSymbols.Text.ToCharArray()[0], 
                        ddWrite.Text.ToCharArray()[0]));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new BindingList<Calc>(Calcs);
        }

        private void tape_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < tape.Items.Count; ++ix)
                if (ix != e.Index) tape.SetItemChecked(ix, false);
        }

        private void btnAddToTape_Click(object sender, EventArgs e)
        {
            tape.Items.Add(comboBox1.Text);
        }

        private void GenerateMachine()
        {
            Machine = new UniversalTuringMachine(States, listToChar(), listToChar(), Calcs, getInitial(), getAccepted(), createTape());
        }

        private List<State> getAccepted()
        {
            List<State> states = new List<State>();
            foreach (object item in lstStates.CheckedItems)
            {
                states.Add(States[lstStates.Items.IndexOf(item)]);
            }

            return states;
        }

        private State getInitial()
        {
            return States[Int32.Parse(ddInitial.SelectedValue.ToString())];
        }

        private Tape createTape()
        {
            Tape tp = new Tape();
            List<char> left = new List<char>();
            List<char> right = new List<char>();
            int pos = tape.Items.IndexOf(tape.CheckedItems[0]);
            int i = 0;

            while(i<pos && i<tape.Items.Count)
            {
                left.Add(tape.Items[i].ToString().ToCharArray()[0]);
                ++i;
            }

            while(i<tape.Items.Count)
            {
                right.Add(tape.Items[i].ToString().ToCharArray()[0]);
                ++i;
            }

            tp.Left = left;
            tp.Right = right;
            return tp;
        }

        private List<Char> listToChar(ListView lw)
        {
            List<char> chars = new List<char>();
            foreach (ListViewItem item in lw.Items)
            {
                chars.Add(item.Text.ToCharArray()[0]);
            }
            return chars;
        }

        private List<Char> listToChar()
        {
            return listToChar(lstSymbols);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            GenerateMachine();
            Execution x = new Execution(Machine);
            x.Show();
        }
    }
}
