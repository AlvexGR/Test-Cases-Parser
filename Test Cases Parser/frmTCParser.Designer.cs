namespace Test_Cases_Generator
{
    partial class frmTCParser
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
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.Problemset = new System.Windows.Forms.TabPage();
            this.problemset_tbxWorkingDir = new System.Windows.Forms.TextBox();
            this.problemset_tbxContestId = new System.Windows.Forms.TextBox();
            this.problemset_tbxProblemID = new System.Windows.Forms.TextBox();
            this.problemset_lblWorkingDir = new System.Windows.Forms.Label();
            this.problemset_lblExe = new System.Windows.Forms.Label();
            this.problemset_tbxExe = new System.Windows.Forms.TextBox();
            this.problemset_gbUserTest = new System.Windows.Forms.GroupBox();
            this.problemset_btnCleanAll = new System.Windows.Forms.Button();
            this.problemset_btnRunAllUserTest = new System.Windows.Forms.Button();
            this.problemset_btnAddTest = new System.Windows.Forms.Button();
            this.problemset_flpUserTest = new System.Windows.Forms.FlowLayoutPanel();
            this.problemset_gbSample = new System.Windows.Forms.GroupBox();
            this.problemset_btnRunAllSample = new System.Windows.Forms.Button();
            this.problemset_flpSample = new System.Windows.Forms.FlowLayoutPanel();
            this.problemset_btnSearch = new System.Windows.Forms.Button();
            this.problemset_lblProblemId = new System.Windows.Forms.Label();
            this.problemset_lblContestId = new System.Windows.Forms.Label();
            this.Contest = new System.Windows.Forms.TabPage();
            this.contest_lblProblems = new System.Windows.Forms.Label();
            this.contest_cbxProblems = new System.Windows.Forms.ComboBox();
            this.contest_lblWorkingDir = new System.Windows.Forms.Label();
            this.contest_tbxWorkingDir = new System.Windows.Forms.TextBox();
            this.contest_lblExe = new System.Windows.Forms.Label();
            this.contest_tbxExe = new System.Windows.Forms.TextBox();
            this.contest_tbxContestId = new System.Windows.Forms.TextBox();
            this.contest_btnSearch = new System.Windows.Forms.Button();
            this.contest_lblContestId = new System.Windows.Forms.Label();
            this.contest_gbUserTest = new System.Windows.Forms.GroupBox();
            this.contest_btnCleanAll = new System.Windows.Forms.Button();
            this.contest_btnRunAllUserTest = new System.Windows.Forms.Button();
            this.contest_btnAddTest = new System.Windows.Forms.Button();
            this.contest_flpUserTest = new System.Windows.Forms.FlowLayoutPanel();
            this.contest_gbSample = new System.Windows.Forms.GroupBox();
            this.contest_btnRunAllSample = new System.Windows.Forms.Button();
            this.contest_flpSample = new System.Windows.Forms.FlowLayoutPanel();
            this.tcMain.SuspendLayout();
            this.Problemset.SuspendLayout();
            this.problemset_gbUserTest.SuspendLayout();
            this.problemset_gbSample.SuspendLayout();
            this.Contest.SuspendLayout();
            this.contest_gbUserTest.SuspendLayout();
            this.contest_gbSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 9);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "Language: ";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt"});
            this.cbxLanguage.Location = new System.Drawing.Point(79, 4);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbxLanguage.TabIndex = 7;
            this.cbxLanguage.Text = "English";
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.Problemset);
            this.tcMain.Controls.Add(this.Contest);
            this.tcMain.Location = new System.Drawing.Point(12, 31);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1025, 597);
            this.tcMain.TabIndex = 10;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // Problemset
            // 
            this.Problemset.Controls.Add(this.problemset_tbxWorkingDir);
            this.Problemset.Controls.Add(this.problemset_tbxContestId);
            this.Problemset.Controls.Add(this.problemset_tbxProblemID);
            this.Problemset.Controls.Add(this.problemset_lblWorkingDir);
            this.Problemset.Controls.Add(this.problemset_lblExe);
            this.Problemset.Controls.Add(this.problemset_tbxExe);
            this.Problemset.Controls.Add(this.problemset_gbUserTest);
            this.Problemset.Controls.Add(this.problemset_gbSample);
            this.Problemset.Controls.Add(this.problemset_btnSearch);
            this.Problemset.Controls.Add(this.problemset_lblProblemId);
            this.Problemset.Controls.Add(this.problemset_lblContestId);
            this.Problemset.Location = new System.Drawing.Point(4, 22);
            this.Problemset.Name = "Problemset";
            this.Problemset.Padding = new System.Windows.Forms.Padding(3);
            this.Problemset.Size = new System.Drawing.Size(1017, 571);
            this.Problemset.TabIndex = 0;
            this.Problemset.Text = "Problemset";
            this.Problemset.UseVisualStyleBackColor = true;
            // 
            // problemset_tbxWorkingDir
            // 
            this.problemset_tbxWorkingDir.Location = new System.Drawing.Point(565, 6);
            this.problemset_tbxWorkingDir.Name = "problemset_tbxWorkingDir";
            this.problemset_tbxWorkingDir.Size = new System.Drawing.Size(446, 20);
            this.problemset_tbxWorkingDir.TabIndex = 31;
            this.problemset_tbxWorkingDir.TextChanged += new System.EventHandler(this.problemset_tbxWorkingDir_TextChanged);
            // 
            // problemset_tbxContestId
            // 
            this.problemset_tbxContestId.Location = new System.Drawing.Point(85, 6);
            this.problemset_tbxContestId.Name = "problemset_tbxContestId";
            this.problemset_tbxContestId.Size = new System.Drawing.Size(189, 20);
            this.problemset_tbxContestId.TabIndex = 21;
            // 
            // problemset_tbxProblemID
            // 
            this.problemset_tbxProblemID.Location = new System.Drawing.Point(85, 32);
            this.problemset_tbxProblemID.Name = "problemset_tbxProblemID";
            this.problemset_tbxProblemID.Size = new System.Drawing.Size(189, 20);
            this.problemset_tbxProblemID.TabIndex = 20;
            // 
            // problemset_lblWorkingDir
            // 
            this.problemset_lblWorkingDir.AutoSize = true;
            this.problemset_lblWorkingDir.Location = new System.Drawing.Point(451, 9);
            this.problemset_lblWorkingDir.Name = "problemset_lblWorkingDir";
            this.problemset_lblWorkingDir.Size = new System.Drawing.Size(93, 13);
            this.problemset_lblWorkingDir.TabIndex = 18;
            this.problemset_lblWorkingDir.Text = "Working directory:";
            // 
            // problemset_lblExe
            // 
            this.problemset_lblExe.AutoSize = true;
            this.problemset_lblExe.Location = new System.Drawing.Point(451, 35);
            this.problemset_lblExe.Name = "problemset_lblExe";
            this.problemset_lblExe.Size = new System.Drawing.Size(44, 13);
            this.problemset_lblExe.TabIndex = 15;
            this.problemset_lblExe.Text = "Exe file:";
            // 
            // problemset_tbxExe
            // 
            this.problemset_tbxExe.Location = new System.Drawing.Point(565, 32);
            this.problemset_tbxExe.Name = "problemset_tbxExe";
            this.problemset_tbxExe.Size = new System.Drawing.Size(190, 20);
            this.problemset_tbxExe.TabIndex = 14;
            this.problemset_tbxExe.TextChanged += new System.EventHandler(this.problemset_tbxExe_TextChanged);
            // 
            // problemset_gbUserTest
            // 
            this.problemset_gbUserTest.Controls.Add(this.problemset_btnCleanAll);
            this.problemset_gbUserTest.Controls.Add(this.problemset_btnRunAllUserTest);
            this.problemset_gbUserTest.Controls.Add(this.problemset_btnAddTest);
            this.problemset_gbUserTest.Controls.Add(this.problemset_flpUserTest);
            this.problemset_gbUserTest.Location = new System.Drawing.Point(512, 87);
            this.problemset_gbUserTest.Name = "problemset_gbUserTest";
            this.problemset_gbUserTest.Size = new System.Drawing.Size(500, 478);
            this.problemset_gbUserTest.TabIndex = 13;
            this.problemset_gbUserTest.TabStop = false;
            this.problemset_gbUserTest.Text = "Your test cases - Maximum 30 test cases";
            // 
            // problemset_btnCleanAll
            // 
            this.problemset_btnCleanAll.Location = new System.Drawing.Point(169, 449);
            this.problemset_btnCleanAll.Name = "problemset_btnCleanAll";
            this.problemset_btnCleanAll.Size = new System.Drawing.Size(75, 23);
            this.problemset_btnCleanAll.TabIndex = 4;
            this.problemset_btnCleanAll.Text = "Clean all";
            this.problemset_btnCleanAll.UseVisualStyleBackColor = true;
            this.problemset_btnCleanAll.Click += new System.EventHandler(this.problemset_btnCleanAll_Click);
            // 
            // problemset_btnRunAllUserTest
            // 
            this.problemset_btnRunAllUserTest.Location = new System.Drawing.Point(7, 449);
            this.problemset_btnRunAllUserTest.Name = "problemset_btnRunAllUserTest";
            this.problemset_btnRunAllUserTest.Size = new System.Drawing.Size(75, 23);
            this.problemset_btnRunAllUserTest.TabIndex = 3;
            this.problemset_btnRunAllUserTest.Text = "Run all";
            this.problemset_btnRunAllUserTest.UseVisualStyleBackColor = true;
            this.problemset_btnRunAllUserTest.Click += new System.EventHandler(this.problemset_btnRunAllUserTest_Click);
            // 
            // problemset_btnAddTest
            // 
            this.problemset_btnAddTest.Location = new System.Drawing.Point(88, 449);
            this.problemset_btnAddTest.Name = "problemset_btnAddTest";
            this.problemset_btnAddTest.Size = new System.Drawing.Size(75, 23);
            this.problemset_btnAddTest.TabIndex = 2;
            this.problemset_btnAddTest.Text = "Add test";
            this.problemset_btnAddTest.UseVisualStyleBackColor = true;
            this.problemset_btnAddTest.Click += new System.EventHandler(this.problemset_btnAddTest_Click);
            // 
            // problemset_flpUserTest
            // 
            this.problemset_flpUserTest.AutoScroll = true;
            this.problemset_flpUserTest.Location = new System.Drawing.Point(7, 20);
            this.problemset_flpUserTest.Name = "problemset_flpUserTest";
            this.problemset_flpUserTest.Size = new System.Drawing.Size(487, 423);
            this.problemset_flpUserTest.TabIndex = 1;
            // 
            // problemset_gbSample
            // 
            this.problemset_gbSample.Controls.Add(this.problemset_btnRunAllSample);
            this.problemset_gbSample.Controls.Add(this.problemset_flpSample);
            this.problemset_gbSample.Location = new System.Drawing.Point(6, 87);
            this.problemset_gbSample.Name = "problemset_gbSample";
            this.problemset_gbSample.Size = new System.Drawing.Size(500, 478);
            this.problemset_gbSample.TabIndex = 12;
            this.problemset_gbSample.TabStop = false;
            this.problemset_gbSample.Text = "Sample test cases";
            // 
            // problemset_btnRunAllSample
            // 
            this.problemset_btnRunAllSample.Location = new System.Drawing.Point(7, 449);
            this.problemset_btnRunAllSample.Name = "problemset_btnRunAllSample";
            this.problemset_btnRunAllSample.Size = new System.Drawing.Size(75, 23);
            this.problemset_btnRunAllSample.TabIndex = 1;
            this.problemset_btnRunAllSample.Text = "Run all";
            this.problemset_btnRunAllSample.UseVisualStyleBackColor = true;
            this.problemset_btnRunAllSample.Click += new System.EventHandler(this.problemset_btnRunAllSample_Click);
            // 
            // problemset_flpSample
            // 
            this.problemset_flpSample.AutoScroll = true;
            this.problemset_flpSample.Location = new System.Drawing.Point(7, 20);
            this.problemset_flpSample.Name = "problemset_flpSample";
            this.problemset_flpSample.Size = new System.Drawing.Size(487, 423);
            this.problemset_flpSample.TabIndex = 0;
            // 
            // problemset_btnSearch
            // 
            this.problemset_btnSearch.Location = new System.Drawing.Point(85, 58);
            this.problemset_btnSearch.Name = "problemset_btnSearch";
            this.problemset_btnSearch.Size = new System.Drawing.Size(75, 23);
            this.problemset_btnSearch.TabIndex = 11;
            this.problemset_btnSearch.Text = "Search";
            this.problemset_btnSearch.UseVisualStyleBackColor = true;
            this.problemset_btnSearch.Click += new System.EventHandler(this.problemset_btnSearch_Click);
            // 
            // problemset_lblProblemId
            // 
            this.problemset_lblProblemId.AutoSize = true;
            this.problemset_lblProblemId.Location = new System.Drawing.Point(6, 35);
            this.problemset_lblProblemId.Name = "problemset_lblProblemId";
            this.problemset_lblProblemId.Size = new System.Drawing.Size(62, 13);
            this.problemset_lblProblemId.TabIndex = 3;
            this.problemset_lblProblemId.Text = "Problem ID:";
            // 
            // problemset_lblContestId
            // 
            this.problemset_lblContestId.AutoSize = true;
            this.problemset_lblContestId.Location = new System.Drawing.Point(6, 9);
            this.problemset_lblContestId.Name = "problemset_lblContestId";
            this.problemset_lblContestId.Size = new System.Drawing.Size(60, 13);
            this.problemset_lblContestId.TabIndex = 1;
            this.problemset_lblContestId.Text = "Contest ID:";
            // 
            // Contest
            // 
            this.Contest.Controls.Add(this.contest_lblProblems);
            this.Contest.Controls.Add(this.contest_cbxProblems);
            this.Contest.Controls.Add(this.contest_lblWorkingDir);
            this.Contest.Controls.Add(this.contest_tbxWorkingDir);
            this.Contest.Controls.Add(this.contest_lblExe);
            this.Contest.Controls.Add(this.contest_tbxExe);
            this.Contest.Controls.Add(this.contest_tbxContestId);
            this.Contest.Controls.Add(this.contest_btnSearch);
            this.Contest.Controls.Add(this.contest_lblContestId);
            this.Contest.Controls.Add(this.contest_gbUserTest);
            this.Contest.Controls.Add(this.contest_gbSample);
            this.Contest.Location = new System.Drawing.Point(4, 22);
            this.Contest.Name = "Contest";
            this.Contest.Padding = new System.Windows.Forms.Padding(3);
            this.Contest.Size = new System.Drawing.Size(1017, 571);
            this.Contest.TabIndex = 1;
            this.Contest.Text = "Contest";
            this.Contest.UseVisualStyleBackColor = true;
            // 
            // contest_lblProblems
            // 
            this.contest_lblProblems.AutoSize = true;
            this.contest_lblProblems.Location = new System.Drawing.Point(6, 35);
            this.contest_lblProblems.Name = "contest_lblProblems";
            this.contest_lblProblems.Size = new System.Drawing.Size(53, 13);
            this.contest_lblProblems.TabIndex = 33;
            this.contest_lblProblems.Text = "Problems:";
            // 
            // contest_cbxProblems
            // 
            this.contest_cbxProblems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contest_cbxProblems.FormattingEnabled = true;
            this.contest_cbxProblems.Location = new System.Drawing.Point(85, 32);
            this.contest_cbxProblems.Name = "contest_cbxProblems";
            this.contest_cbxProblems.Size = new System.Drawing.Size(189, 21);
            this.contest_cbxProblems.TabIndex = 11;
            this.contest_cbxProblems.SelectedIndexChanged += new System.EventHandler(this.contest_cbxProblems_SelectedIndexChanged);
            // 
            // contest_lblWorkingDir
            // 
            this.contest_lblWorkingDir.AutoSize = true;
            this.contest_lblWorkingDir.Location = new System.Drawing.Point(451, 9);
            this.contest_lblWorkingDir.Name = "contest_lblWorkingDir";
            this.contest_lblWorkingDir.Size = new System.Drawing.Size(93, 13);
            this.contest_lblWorkingDir.TabIndex = 31;
            this.contest_lblWorkingDir.Text = "Working directory:";
            // 
            // contest_tbxWorkingDir
            // 
            this.contest_tbxWorkingDir.Location = new System.Drawing.Point(565, 6);
            this.contest_tbxWorkingDir.Name = "contest_tbxWorkingDir";
            this.contest_tbxWorkingDir.Size = new System.Drawing.Size(446, 20);
            this.contest_tbxWorkingDir.TabIndex = 30;
            this.contest_tbxWorkingDir.TextChanged += new System.EventHandler(this.contest_tbxWorkingDir_TextChanged);
            // 
            // contest_lblExe
            // 
            this.contest_lblExe.AutoSize = true;
            this.contest_lblExe.Location = new System.Drawing.Point(451, 35);
            this.contest_lblExe.Name = "contest_lblExe";
            this.contest_lblExe.Size = new System.Drawing.Size(44, 13);
            this.contest_lblExe.TabIndex = 28;
            this.contest_lblExe.Text = "Exe file:";
            // 
            // contest_tbxExe
            // 
            this.contest_tbxExe.Location = new System.Drawing.Point(565, 32);
            this.contest_tbxExe.Name = "contest_tbxExe";
            this.contest_tbxExe.Size = new System.Drawing.Size(190, 20);
            this.contest_tbxExe.TabIndex = 27;
            this.contest_tbxExe.TextChanged += new System.EventHandler(this.contest_tbxExe_TextChanged);
            // 
            // contest_tbxContestId
            // 
            this.contest_tbxContestId.Location = new System.Drawing.Point(85, 6);
            this.contest_tbxContestId.Name = "contest_tbxContestId";
            this.contest_tbxContestId.Size = new System.Drawing.Size(189, 20);
            this.contest_tbxContestId.TabIndex = 26;
            // 
            // contest_btnSearch
            // 
            this.contest_btnSearch.Location = new System.Drawing.Point(85, 58);
            this.contest_btnSearch.Name = "contest_btnSearch";
            this.contest_btnSearch.Size = new System.Drawing.Size(75, 23);
            this.contest_btnSearch.TabIndex = 24;
            this.contest_btnSearch.Text = "Search";
            this.contest_btnSearch.UseVisualStyleBackColor = true;
            this.contest_btnSearch.Click += new System.EventHandler(this.contest_btnSearch_Click);
            // 
            // contest_lblContestId
            // 
            this.contest_lblContestId.AutoSize = true;
            this.contest_lblContestId.Location = new System.Drawing.Point(6, 9);
            this.contest_lblContestId.Name = "contest_lblContestId";
            this.contest_lblContestId.Size = new System.Drawing.Size(57, 13);
            this.contest_lblContestId.TabIndex = 22;
            this.contest_lblContestId.Text = "Contest ID";
            // 
            // contest_gbUserTest
            // 
            this.contest_gbUserTest.Controls.Add(this.contest_btnCleanAll);
            this.contest_gbUserTest.Controls.Add(this.contest_btnRunAllUserTest);
            this.contest_gbUserTest.Controls.Add(this.contest_btnAddTest);
            this.contest_gbUserTest.Controls.Add(this.contest_flpUserTest);
            this.contest_gbUserTest.Location = new System.Drawing.Point(512, 87);
            this.contest_gbUserTest.Name = "contest_gbUserTest";
            this.contest_gbUserTest.Size = new System.Drawing.Size(500, 478);
            this.contest_gbUserTest.TabIndex = 15;
            this.contest_gbUserTest.TabStop = false;
            this.contest_gbUserTest.Text = "Your test cases - Maximum 30 test cases";
            // 
            // contest_btnCleanAll
            // 
            this.contest_btnCleanAll.Location = new System.Drawing.Point(169, 449);
            this.contest_btnCleanAll.Name = "contest_btnCleanAll";
            this.contest_btnCleanAll.Size = new System.Drawing.Size(75, 23);
            this.contest_btnCleanAll.TabIndex = 11;
            this.contest_btnCleanAll.Text = "Clean all";
            this.contest_btnCleanAll.UseVisualStyleBackColor = true;
            this.contest_btnCleanAll.Click += new System.EventHandler(this.contest_btnCleanAll_Click);
            // 
            // contest_btnRunAllUserTest
            // 
            this.contest_btnRunAllUserTest.Location = new System.Drawing.Point(7, 449);
            this.contest_btnRunAllUserTest.Name = "contest_btnRunAllUserTest";
            this.contest_btnRunAllUserTest.Size = new System.Drawing.Size(75, 23);
            this.contest_btnRunAllUserTest.TabIndex = 3;
            this.contest_btnRunAllUserTest.Text = "Run all";
            this.contest_btnRunAllUserTest.UseVisualStyleBackColor = true;
            this.contest_btnRunAllUserTest.Click += new System.EventHandler(this.contest_btnRunAllUserTest_Click);
            // 
            // contest_btnAddTest
            // 
            this.contest_btnAddTest.Enabled = false;
            this.contest_btnAddTest.Location = new System.Drawing.Point(88, 449);
            this.contest_btnAddTest.Name = "contest_btnAddTest";
            this.contest_btnAddTest.Size = new System.Drawing.Size(75, 23);
            this.contest_btnAddTest.TabIndex = 2;
            this.contest_btnAddTest.Text = "Add test";
            this.contest_btnAddTest.UseVisualStyleBackColor = true;
            this.contest_btnAddTest.Click += new System.EventHandler(this.contest_btnAddTest_Click);
            // 
            // contest_flpUserTest
            // 
            this.contest_flpUserTest.AutoScroll = true;
            this.contest_flpUserTest.Location = new System.Drawing.Point(7, 20);
            this.contest_flpUserTest.Name = "contest_flpUserTest";
            this.contest_flpUserTest.Size = new System.Drawing.Size(487, 423);
            this.contest_flpUserTest.TabIndex = 1;
            // 
            // contest_gbSample
            // 
            this.contest_gbSample.Controls.Add(this.contest_btnRunAllSample);
            this.contest_gbSample.Controls.Add(this.contest_flpSample);
            this.contest_gbSample.Location = new System.Drawing.Point(6, 87);
            this.contest_gbSample.Name = "contest_gbSample";
            this.contest_gbSample.Size = new System.Drawing.Size(500, 478);
            this.contest_gbSample.TabIndex = 14;
            this.contest_gbSample.TabStop = false;
            this.contest_gbSample.Text = "Sample test cases";
            // 
            // contest_btnRunAllSample
            // 
            this.contest_btnRunAllSample.Location = new System.Drawing.Point(7, 449);
            this.contest_btnRunAllSample.Name = "contest_btnRunAllSample";
            this.contest_btnRunAllSample.Size = new System.Drawing.Size(75, 23);
            this.contest_btnRunAllSample.TabIndex = 1;
            this.contest_btnRunAllSample.Text = "Run all";
            this.contest_btnRunAllSample.UseVisualStyleBackColor = true;
            this.contest_btnRunAllSample.Click += new System.EventHandler(this.contest_btnRunAllSample_Click);
            // 
            // contest_flpSample
            // 
            this.contest_flpSample.AutoScroll = true;
            this.contest_flpSample.Location = new System.Drawing.Point(7, 20);
            this.contest_flpSample.Name = "contest_flpSample";
            this.contest_flpSample.Size = new System.Drawing.Size(487, 423);
            this.contest_flpSample.TabIndex = 0;
            // 
            // frmTCParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbxLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTCParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Cases Parser - by Nhan K10";
            this.tcMain.ResumeLayout(false);
            this.Problemset.ResumeLayout(false);
            this.Problemset.PerformLayout();
            this.problemset_gbUserTest.ResumeLayout(false);
            this.problemset_gbSample.ResumeLayout(false);
            this.Contest.ResumeLayout(false);
            this.Contest.PerformLayout();
            this.contest_gbUserTest.ResumeLayout(false);
            this.contest_gbSample.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.TabPage Problemset;
        private System.Windows.Forms.Label problemset_lblContestId;
        private System.Windows.Forms.TabPage Contest;
        private System.Windows.Forms.Label problemset_lblProblemId;
        private System.Windows.Forms.Button problemset_btnSearch;
        private System.Windows.Forms.GroupBox problemset_gbSample;
        private System.Windows.Forms.GroupBox problemset_gbUserTest;
        private System.Windows.Forms.Label problemset_lblExe;
        private System.Windows.Forms.TextBox problemset_tbxExe;
        private System.Windows.Forms.Label problemset_lblWorkingDir;
        private System.Windows.Forms.TextBox problemset_tbxContestId;
        private System.Windows.Forms.TextBox problemset_tbxProblemID;
        private System.Windows.Forms.FlowLayoutPanel problemset_flpUserTest;
        private System.Windows.Forms.FlowLayoutPanel problemset_flpSample;
        private System.Windows.Forms.Button problemset_btnAddTest;
        private System.Windows.Forms.GroupBox contest_gbUserTest;
        private System.Windows.Forms.Button contest_btnAddTest;
        private System.Windows.Forms.FlowLayoutPanel contest_flpUserTest;
        private System.Windows.Forms.GroupBox contest_gbSample;
        private System.Windows.Forms.FlowLayoutPanel contest_flpSample;
        private System.Windows.Forms.TextBox contest_tbxContestId;
        private System.Windows.Forms.Button contest_btnSearch;
        private System.Windows.Forms.Label contest_lblContestId;
        private System.Windows.Forms.Label contest_lblWorkingDir;
        private System.Windows.Forms.TextBox contest_tbxWorkingDir;
        private System.Windows.Forms.Label contest_lblExe;
        private System.Windows.Forms.TextBox contest_tbxExe;
        private System.Windows.Forms.ComboBox contest_cbxProblems;
        private System.Windows.Forms.Label contest_lblProblems;
        private System.Windows.Forms.TextBox problemset_tbxWorkingDir;
        public System.Windows.Forms.TabControl tcMain;
        public System.Windows.Forms.Button problemset_btnRunAllUserTest;
        public System.Windows.Forms.Button problemset_btnRunAllSample;
        public System.Windows.Forms.Button contest_btnRunAllSample;
        public System.Windows.Forms.Button contest_btnRunAllUserTest;
        public System.Windows.Forms.Button problemset_btnCleanAll;
        public System.Windows.Forms.Button contest_btnCleanAll;
    }
}

