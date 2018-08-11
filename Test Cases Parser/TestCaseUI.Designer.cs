namespace Test_Cases_Generator
{
    partial class TestCaseUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTcNumber = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.RichTextBox();
            this.lblYourOutput = new System.Windows.Forms.Label();
            this.tbxYourOutput = new System.Windows.Forms.RichTextBox();
            this.lblVerdict = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTcNumber
            // 
            this.lblTcNumber.AutoSize = true;
            this.lblTcNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTcNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTcNumber.Location = new System.Drawing.Point(3, 0);
            this.lblTcNumber.Name = "lblTcNumber";
            this.lblTcNumber.Size = new System.Drawing.Size(87, 20);
            this.lblTcNumber.TabIndex = 0;
            this.lblTcNumber.Text = "Test case";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInput.Location = new System.Drawing.Point(3, 29);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(41, 16);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblOutput.Location = new System.Drawing.Point(4, 111);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 16);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxOutput.DetectUrls = false;
            this.tbxOutput.ForeColor = System.Drawing.Color.Black;
            this.tbxOutput.Location = new System.Drawing.Point(4, 130);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(439, 60);
            this.tbxOutput.TabIndex = 4;
            this.tbxOutput.Text = "";
            // 
            // lblYourOutput
            // 
            this.lblYourOutput.AutoSize = true;
            this.lblYourOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblYourOutput.Location = new System.Drawing.Point(4, 193);
            this.lblYourOutput.Name = "lblYourOutput";
            this.lblYourOutput.Size = new System.Drawing.Size(86, 16);
            this.lblYourOutput.TabIndex = 5;
            this.lblYourOutput.Text = "Your output";
            // 
            // tbxYourOutput
            // 
            this.tbxYourOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbxYourOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxYourOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxYourOutput.DetectUrls = false;
            this.tbxYourOutput.Location = new System.Drawing.Point(4, 212);
            this.tbxYourOutput.Name = "tbxYourOutput";
            this.tbxYourOutput.ReadOnly = true;
            this.tbxYourOutput.Size = new System.Drawing.Size(439, 60);
            this.tbxYourOutput.TabIndex = 6;
            this.tbxYourOutput.Text = "";
            // 
            // lblVerdict
            // 
            this.lblVerdict.AutoSize = true;
            this.lblVerdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVerdict.Location = new System.Drawing.Point(4, 275);
            this.lblVerdict.Name = "lblVerdict";
            this.lblVerdict.Size = new System.Drawing.Size(61, 16);
            this.lblVerdict.TabIndex = 7;
            this.lblVerdict.Text = "Verdict:";
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxInput.DetectUrls = false;
            this.tbxInput.ForeColor = System.Drawing.Color.Black;
            this.tbxInput.Location = new System.Drawing.Point(4, 48);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.ReadOnly = true;
            this.tbxInput.Size = new System.Drawing.Size(439, 60);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(412, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(381, 275);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(61, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // TestCaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblVerdict);
            this.Controls.Add(this.lblYourOutput);
            this.Controls.Add(this.tbxYourOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTcNumber);
            this.Name = "TestCaseUI";
            this.Size = new System.Drawing.Size(449, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTcNumber;
        public System.Windows.Forms.Label lblInput;
        public System.Windows.Forms.Label lblOutput;
        public System.Windows.Forms.RichTextBox tbxOutput;
        public System.Windows.Forms.Label lblYourOutput;
        public System.Windows.Forms.RichTextBox tbxYourOutput;
        public System.Windows.Forms.Label lblVerdict;
        public System.Windows.Forms.RichTextBox tbxInput;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnRun;
    }
}
