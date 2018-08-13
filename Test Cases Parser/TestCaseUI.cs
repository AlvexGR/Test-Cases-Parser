using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Test_Cases_Generator
{
    public partial class TestCaseUI : UserControl
    {
        private BackgroundWorker bgw;
        private Process p;
        private int curLang = 1;
        private string input;
        private string yourOutput;
        private string output;
        private bool correct = false;
        private bool finished = false;
        private bool correctPath = true;
        private bool isUserTC;

        public TestCaseUI()
        {
            InitializeComponent();
            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_Completed);
            bgw.WorkerSupportsCancellation = true;
        }

        public int CurLang { get => curLang; set => curLang = value; }
        public bool IsUserTC { get => isUserTC; set => isUserTC = value; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int curIndex = Convert.ToInt32(lblTcNumber.Text.Split('-')[1]);
            for (int i = curIndex; i < (Parent as FlowLayoutPanel).Controls.Count; i++)
            {
                ((Parent as FlowLayoutPanel).Controls[i] as TestCaseUI).lblTcNumber.Text = 
                    ((Parent as FlowLayoutPanel).Controls[i] as TestCaseUI).lblTcNumber.Text.Split('-')[0] + "- " + i.ToString();
            }
            Dispose();
        }

        private string[] PreprocessingData(string[] data)
        {
            List<string> lst = data.ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i] = lst[i].Trim();
            }
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i] == "")
                {
                    lst.RemoveAt(i);
                }
            }
            return lst.ToArray();
        }

        public void ExecuteExefile()
        {
            p = new Process();
            try
            {
                if (Program.type == 0)
                {
                    p.StartInfo.FileName = Program.problemset_directory.Trim() + @"\" + Program.problemset_exe.Trim() + ".exe";
                }
                else
                {
                    p.StartInfo.FileName = Program.contest_directory.Trim() + @"\" + Program.contest_exe.Trim() + ".exe";
                }
            }
            catch
            {
                correctPath = false;
                if (curLang == 1)
                {
                    MessageBox.Show("Recheck your current directory or exe file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại đường dẫn thư mục gốc hoặc tên tập tin exe của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            try
            {
                p.Start();
                if ((Parent as FlowLayoutPanel).Name == "problemset_flpUserTest")
                {
                    Program.problemset_pId.Add(p.Id);
                }
                if ((Parent as FlowLayoutPanel).Name == "contest_flpUserTest")
                {
                    Program.contest_pId.Add(p.Id);
                }
                Program.all_pId.Add(p.Id);
            }
            catch
            {
                correctPath = false;
                if (curLang == 1)
                {
                    MessageBox.Show("Recheck your current directory or exe file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại đường dẫn thư mục gốc hoặc tên tập tin exe của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            p.StandardInput.WriteLine(input);
            p.StandardInput.Close();
            Task<string> readOutput = p.StandardOutput.ReadToEndAsync();
            finished = readOutput.Wait(10000);
            p.StandardOutput.Close();
            if (finished)
            {
                yourOutput = readOutput.Result;
                yourOutput = yourOutput.Replace("\r\n", "\n");
                correct = output == yourOutput.Trim();
                p.Close();
                // if enter endless loop, p.Close() won't kill it completely we'll need kill process
                return;
            }
            try
            {
                Process.GetProcessById(p.Id).Kill();
                // normally kill it won't work because it finds the process by name and kill them all with the same name.
                // solution is to find the process by its own id manually then kill it
            }
            catch
            { }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            ExecuteExefile();
        }

        private void bgw_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Parent is null)
            {
                return;
            }
            int tc = Convert.ToInt32(lblTcNumber.Text.Split(new[] { " - " }, StringSplitOptions.None)[1]);
            if ((Parent as FlowLayoutPanel).Controls.Count == tc)
            {
                if ((Parent as FlowLayoutPanel).Name == "problemset_flpSample")
                {
                    (ParentForm as frmTCParser).problemset_btnRunAllSample.Visible = true;
                    (ParentForm as frmTCParser).problemset_btnSearch.Enabled = true;
                }
                else if ((Parent as FlowLayoutPanel).Name == "problemset_flpUserTest")
                {
                    (ParentForm as frmTCParser).problemset_btnRunAllUserTest.Visible = true;
                }
                else if ((Parent as FlowLayoutPanel).Name == "contest_flpSample")
                {
                    (ParentForm as frmTCParser).contest_btnRunAllSample.Visible = true;
                    (ParentForm as frmTCParser).contest_cbxProblems.Enabled = true;
                    (ParentForm as frmTCParser).contest_btnSearch.Enabled = true;
                }
                else
                {
                    (ParentForm as frmTCParser).contest_btnRunAllUserTest.Visible = true;
                }
            }
            btnRun.Visible = true;
            if (isUserTC)
            {
                btnDelete.Visible = true;
                tbxInput.ReadOnly = false;
                tbxOutput.ReadOnly = false;
            }
            if (!correctPath)
            {
                return;
            }
            if (!finished)
            {
                if (CurLang == 0)
                {
                    lblVerdict.Text = "Đánh giá: Quá thời gian";
                }
                else
                {
                    lblVerdict.Text = "Verdict: Time limit exceeded";
                }
                lblVerdict.ForeColor = Color.Red;
                return;
            }
            tbxYourOutput.Text = yourOutput;
            if (correct)
            {
                if (CurLang == 0)
                {
                    lblVerdict.Text = "Đánh giá: Đúng";
                }
                else
                {
                    lblVerdict.Text = "Verdict: Correct";
                }
                lblVerdict.ForeColor = Color.Green;
                
            }
            else
            {
                if (CurLang == 0)
                {
                    lblVerdict.Text = "Đánh giá: Sai";
                }
                else
                {
                    lblVerdict.Text = "Verdict: Wrong answer";
                }
                lblVerdict.ForeColor = Color.Red;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            input = tbxInput.Text;
            if (input == "")
            {
                return;
            }
            tbxOutput.Lines = PreprocessingData(tbxOutput.Lines);
            output = tbxOutput.Text;
            btnDelete.Visible = false;
            btnRun.Visible = false;
            tbxInput.ReadOnly = true;
            tbxOutput.ReadOnly = true;
            bgw.RunWorkerAsync();
        }
    }
}
