namespace UniversalTuringMachine
{
    partial class Execution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lvComputedOutputs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(35, 10);
            this.txtLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(260, 38);
            this.txtLog.TabIndex = 0;
            // 
            // lvComputedOutputs
            // 
            this.lvComputedOutputs.Location = new System.Drawing.Point(35, 84);
            this.lvComputedOutputs.Name = "lvComputedOutputs";
            this.lvComputedOutputs.Size = new System.Drawing.Size(1783, 853);
            this.lvComputedOutputs.TabIndex = 1;
            this.lvComputedOutputs.UseCompatibleStateImageBehavior = false;
            // 
            // Execution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.lvComputedOutputs);
            this.Controls.Add(this.txtLog);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Execution";
            this.Text = "Execution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ListView lvComputedOutputs;
    }
}