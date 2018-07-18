namespace Parser
{
    partial class FormParser
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
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.LableStartPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(404, 355);
            this.ListTitles.TabIndex = 0;
            // 
            // LableStartPoint
            // 
            this.LableStartPoint.AutoSize = true;
            this.LableStartPoint.Location = new System.Drawing.Point(450, 25);
            this.LableStartPoint.Name = "LableStartPoint";
            this.LableStartPoint.Size = new System.Drawing.Size(56, 13);
            this.LableStartPoint.TabIndex = 1;
            this.LableStartPoint.Text = "Start Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop Point";
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(453, 41);
            this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(61, 20);
            this.numericStart.TabIndex = 3;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(453, 92);
            this.numericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(61, 20);
            this.numericEnd.TabIndex = 4;
            this.numericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(441, 176);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(441, 221);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // FormParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 383);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LableStartPoint);
            this.Controls.Add(this.ListTitles);
            this.Name = "FormParser";
            this.Text = "Parser";
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label LableStartPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}

