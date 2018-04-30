using System.Collections.Generic;

namespace UniversalTuringMachine
{
    partial class Setup
    {
        

        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddCurr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddSymbols = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddWrite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddNext = new System.Windows.Forms.ComboBox();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lstStates = new System.Windows.Forms.CheckedListBox();
            this.txtSymbols = new System.Windows.Forms.TextBox();
            this.btnAddSymbol = new System.Windows.Forms.Button();
            this.lstSymbols = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.ddInitial = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clbTape = new System.Windows.Forms.CheckedListBox();
            this.cBTapeValues = new System.Windows.Forms.ComboBox();
            this.btnAddToTape = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add or Remove state (Check if accepted)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(160, 62);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 55);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Configure Your Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 491);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "If State";
            // 
            // ddCurr
            // 
            this.ddCurr.FormattingEnabled = true;
            this.ddCurr.Location = new System.Drawing.Point(859, 484);
            this.ddCurr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ddCurr.Name = "ddCurr";
            this.ddCurr.Size = new System.Drawing.Size(97, 39);
            this.ddCurr.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(981, 491);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "and Symbol";
            // 
            // ddSymbols
            // 
            this.ddSymbols.FormattingEnabled = true;
            this.ddSymbols.Location = new System.Drawing.Point(1163, 484);
            this.ddSymbols.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ddSymbols.Name = "ddSymbols";
            this.ddSymbols.Size = new System.Drawing.Size(81, 39);
            this.ddSymbols.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1512, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Move ";
            // 
            // cbDir
            // 
            this.cbDir.FormattingEnabled = true;
            this.cbDir.Location = new System.Drawing.Point(1627, 484);
            this.cbDir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(145, 39);
            this.cbDir.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1267, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Write";
            // 
            // ddWrite
            // 
            this.ddWrite.FormattingEnabled = true;
            this.ddWrite.Location = new System.Drawing.Point(1368, 484);
            this.ddWrite.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ddWrite.Name = "ddWrite";
            this.ddWrite.Size = new System.Drawing.Size(121, 39);
            this.ddWrite.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1797, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "And change to";
            // 
            // ddNext
            // 
            this.ddNext.FormattingEnabled = true;
            this.ddNext.Location = new System.Drawing.Point(2019, 486);
            this.ddNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ddNext.Name = "ddNext";
            this.ddNext.Size = new System.Drawing.Size(119, 39);
            this.ddNext.TabIndex = 15;
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(733, 548);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(200, 55);
            this.btnAddStep.TabIndex = 16;
            this.btnAddStep.Text = "Add Step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(733, 620);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1411, 451);
            this.dataGridView1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(717, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Define Symbols";
            // 
            // lstStates
            // 
            this.lstStates.CheckOnClick = true;
            this.lstStates.FormattingEnabled = true;
            this.lstStates.Location = new System.Drawing.Point(32, 134);
            this.lstStates.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(671, 928);
            this.lstStates.TabIndex = 19;
            // 
            // txtSymbols
            // 
            this.txtSymbols.Location = new System.Drawing.Point(725, 174);
            this.txtSymbols.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSymbols.Name = "txtSymbols";
            this.txtSymbols.Size = new System.Drawing.Size(47, 38);
            this.txtSymbols.TabIndex = 20;
            // 
            // btnAddSymbol
            // 
            this.btnAddSymbol.Location = new System.Drawing.Point(795, 172);
            this.btnAddSymbol.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddSymbol.Name = "btnAddSymbol";
            this.btnAddSymbol.Size = new System.Drawing.Size(72, 55);
            this.btnAddSymbol.TabIndex = 21;
            this.btnAddSymbol.Text = "+";
            this.btnAddSymbol.UseVisualStyleBackColor = true;
            this.btnAddSymbol.Click += new System.EventHandler(this.btnAddSymbol_Click);
            // 
            // lstSymbols
            // 
            this.lstSymbols.Location = new System.Drawing.Point(725, 236);
            this.lstSymbols.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstSymbols.Name = "lstSymbols";
            this.lstSymbols.Size = new System.Drawing.Size(316, 178);
            this.lstSymbols.TabIndex = 22;
            this.lstSymbols.UseCompatibleStateImageBehavior = false;
            this.lstSymbols.View = System.Windows.Forms.View.List;
            this.lstSymbols.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstSymbols_PreviewKeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(717, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Initial State";
            // 
            // ddInitial
            // 
            this.ddInitial.FormattingEnabled = true;
            this.ddInitial.Location = new System.Drawing.Point(725, 67);
            this.ddInitial.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ddInitial.Name = "ddInitial";
            this.ddInitial.Size = new System.Drawing.Size(97, 39);
            this.ddInitial.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1163, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(462, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tape (Check current Head position)";
            // 
            // clbTape
            // 
            this.clbTape.CheckOnClick = true;
            this.clbTape.FormattingEnabled = true;
            this.clbTape.Location = new System.Drawing.Point(1171, 134);
            this.clbTape.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.clbTape.Name = "clbTape";
            this.clbTape.Size = new System.Drawing.Size(967, 268);
            this.clbTape.TabIndex = 26;
            this.clbTape.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tape_ItemCheck);
            this.clbTape.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.clbTape_PreviewKeyDown);
            // 
            // cBTapeValues
            // 
            this.cBTapeValues.FormattingEnabled = true;
            this.cBTapeValues.Location = new System.Drawing.Point(1171, 67);
            this.cBTapeValues.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cBTapeValues.Name = "cBTapeValues";
            this.cBTapeValues.Size = new System.Drawing.Size(81, 39);
            this.cBTapeValues.TabIndex = 27;
            // 
            // btnAddToTape
            // 
            this.btnAddToTape.Location = new System.Drawing.Point(1275, 67);
            this.btnAddToTape.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddToTape.Name = "btnAddToTape";
            this.btnAddToTape.Size = new System.Drawing.Size(77, 55);
            this.btnAddToTape.TabIndex = 28;
            this.btnAddToTape.Text = "+";
            this.btnAddToTape.UseVisualStyleBackColor = true;
            this.btnAddToTape.Click += new System.EventHandler(this.btnAddToTape_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1944, 1085);
            this.btnRun.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(200, 55);
            this.btnRun.TabIndex = 29;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2195, 1164);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnAddToTape);
            this.Controls.Add(this.cBTapeValues);
            this.Controls.Add(this.clbTape);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ddInitial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstSymbols);
            this.Controls.Add(this.btnAddSymbol);
            this.Controls.Add(this.txtSymbols);
            this.Controls.Add(this.lstStates);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.ddNext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddWrite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddSymbols);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddCurr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Setup";
            this.Text = "Programming Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddCurr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddSymbols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddWrite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddNext;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox lstStates;
        private System.Windows.Forms.TextBox txtSymbols;
        private System.Windows.Forms.Button btnAddSymbol;
        private System.Windows.Forms.ListView lstSymbols;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddInitial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox clbTape;
        private System.Windows.Forms.ComboBox cBTapeValues;
        private System.Windows.Forms.Button btnAddToTape;
        private System.Windows.Forms.Button btnRun;
    }
}

