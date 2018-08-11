using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Cases_Generator
{
    public partial class frmTCParser : Form
    {
        private int curLang = 1;
        private List<Problem> contest_problems;
        private Dictionary<string, List<TestCaseUI>> contest_usertests;
        private Dictionary<string, List<TestCaseUI>> contest_sampletests;
        private Problem problemset_problem;
        private frmLoading loading;
        private List<string> lst_prob;
        private BackgroundWorker bgw;
        private string oldKey;

        public frmTCParser()
        {
            InitializeComponent();
            contest_problems = new List<Problem>();
            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(SearchProblem);
            bgw.ProgressChanged += new ProgressChangedEventHandler(DownloadingProblem);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DownloadCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            contest_usertests = new Dictionary<string, List<TestCaseUI>>();
            contest_sampletests = new Dictionary<string, List<TestCaseUI>>();
        }

        private void ConvertLanguage()
        {
            // Language 
            if (curLang == 1)
            {
                lblLanguage.Text = "Language:";
                Problemset.Text = "Problem Set";
                Contest.Text = "Contest";
            }
            else
            {
                lblLanguage.Text = "Ngôn ngữ:";
                Problemset.Text = "Danh sách bài";
                Contest.Text = "Kì thi";
            }
            // Problemset
            if (curLang == 1)
            {
                problemset_lblContestId.Text = "Contest ID:";
                problemset_lblProblemId.Text = "Problem ID:";
                problemset_lblWorkingDir.Text = "Working directory:";
                problemset_lblExe.Text = "Exe file:";
                problemset_btnAddTest.Text = "Add test";
                problemset_btnRunAllSample.Text = "Run all";
                problemset_btnRunAllUserTest.Text = "Run all";
                problemset_btnSearch.Text = "Search";
                problemset_gbSample.Text = "Sample test cases";
                problemset_gbUserTest.Text = "Your test cases - Maximum 30 test cases";
                problemset_btnCleanAll.Text = "Clean all";
                foreach (TestCaseUI item in problemset_flpSample.Controls)
                {
                    item.lblInput.Text = "Input";
                    item.lblOutput.Text = "Output";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Mẫu thử", "Test case");
                    if (item.lblVerdict.Text == "Đánh giá: Đúng")
                    {
                        item.lblVerdict.Text = "Verdict: Correct";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Sai")
                    {
                        item.lblVerdict.Text = "Verdict: Wrong answer";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Verdict:";
                    }
                    item.lblYourOutput.Text = "Your output";
                    item.btnRun.Text = "Run";
                    item.CurLang = 1;
                }
                foreach (TestCaseUI item in problemset_flpUserTest.Controls)
                {
                    item.lblInput.Text = "Input";
                    item.lblOutput.Text = "Output";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Mẫu thử", "Test case");
                    if (item.lblVerdict.Text == "Đánh giá: Đúng")
                    {
                        item.lblVerdict.Text = "Verdict: Correct";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Sai")
                    {
                        item.lblVerdict.Text = "Verdict: Wrong answer";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Quá thời gian")
                    {
                        item.lblVerdict.Text = "Verdict: Time limit exceeded";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Verdict:";
                    }
                    item.lblYourOutput.Text = "Your output";
                    item.btnRun.Text = "Run";
                    item.CurLang = 1;
                }
            }
            else
            {
                problemset_lblContestId.Text = "Mã kì thi:";
                problemset_lblProblemId.Text = "Mã bài:";
                problemset_lblWorkingDir.Text = "Thư mục gốc:";
                problemset_lblExe.Text = "Tập tin exe:";
                problemset_btnAddTest.Text = "Thêm mẫu";
                problemset_btnRunAllSample.Text = "Chạy hết";
                problemset_btnRunAllUserTest.Text = "Chạy hết";
                problemset_btnSearch.Text = "Tìm kiếm";
                problemset_gbSample.Text = "Mẫu thử";
                problemset_gbUserTest.Text = "Mẫu thử của bạn - Tối đa 30 mẫu";
                problemset_btnCleanAll.Text = "Xoá hết";
                foreach (TestCaseUI item in problemset_flpSample.Controls)
                {
                    item.lblInput.Text = "Đầu vào";
                    item.lblOutput.Text = "Đầu ra";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Test case", "Mẫu thử");
                    if (item.lblVerdict.Text == "Verdict: Correct")
                    {
                        item.lblVerdict.Text = "Đánh giá: Đúng";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Wrong answer")
                    {
                        item.lblVerdict.Text = "Đánh giá: Sai";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Time limit exceeded")
                    {
                        item.lblVerdict.Text = "Đánh giá: Quá thời gian";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Đánh giá:";
                    }
                    item.lblYourOutput.Text = "Đầu ra của bạn";
                    item.btnRun.Text = "Chạy";
                    item.CurLang = 0;
                }
                foreach (TestCaseUI item in problemset_flpUserTest.Controls)
                {
                    item.lblInput.Text = "Đầu vào";
                    item.lblOutput.Text = "Đầu ra";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Test case", "Mẫu thử");
                    if (item.lblVerdict.Text == "Verdict: Correct")
                    {
                        item.lblVerdict.Text = "Đánh giá: Đúng";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Wrong answer")
                    {
                        item.lblVerdict.Text = "Đánh giá: Sai";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Time limit exceeded")
                    {
                        item.lblVerdict.Text = "Đánh giá: Quá thời gian";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Đánh giá:";
                    }
                    item.lblYourOutput.Text = "Đầu ra của bạn";
                    item.btnRun.Text = "Chạy";
                    item.CurLang = 0;
                }
            }
            // Contest
            if (curLang == 1)
            {
                contest_lblContestId.Text = "Contest ID:";
                contest_lblProblems.Text = "Problems:";
                contest_lblWorkingDir.Text = "Working directory:";
                contest_lblExe.Text = "Exe file:";
                contest_btnAddTest.Text = "Add test";
                contest_btnRunAllSample.Text = "Run all";
                contest_btnRunAllUserTest.Text = "Run all";
                contest_btnSearch.Text = "Search";
                contest_gbSample.Text = "Sample test cases";
                contest_gbUserTest.Text = "Your test cases - Maximum 30 test cases";
                contest_btnCleanAll.Text = "Clean all";
                foreach (TestCaseUI item in contest_flpSample.Controls)
                {
                    item.lblInput.Text = "Input";
                    item.lblOutput.Text = "Output";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Mẫu thử", "Test case");
                    if (item.lblVerdict.Text == "Đánh giá: Đúng")
                    {
                        item.lblVerdict.Text = "Verdict: Correct";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Sai")
                    {
                        item.lblVerdict.Text = "Verdict: Wrong answer";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Quá thời gian")
                    {
                        item.lblVerdict.Text = "Verdict: Time limit exceeded";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Verdict:";
                    }
                    item.lblYourOutput.Text = "Your output";
                    item.btnRun.Text = "Run";
                    item.CurLang = 1;
                }
                foreach (TestCaseUI item in contest_flpUserTest.Controls)
                {
                    item.lblInput.Text = "Input";
                    item.lblOutput.Text = "Output";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Mẫu thử", "Test case");
                    if (item.lblVerdict.Text == "Đánh giá: Đúng")
                    {
                        item.lblVerdict.Text = "Verdict: Correct";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Sai")
                    {
                        item.lblVerdict.Text = "Verdict: Wrong answer";
                    }
                    else if (item.lblVerdict.Text == "Đánh giá: Quá thời gian")
                    {
                        item.lblVerdict.Text = "Verdict: Time limit exceeded";
                    }
                    item.lblYourOutput.Text = "Your output";
                    item.btnRun.Text = "Run";
                    item.CurLang = 1;
                }
            }
            else
            {
                contest_lblContestId.Text = "Mã kì thi:";
                contest_lblProblems.Text = "Bài:";
                contest_lblWorkingDir.Text = "Thư mục gốc:";
                contest_lblExe.Text = "Tập tin exe:";
                contest_btnAddTest.Text = "Thêm mẫu";
                contest_btnRunAllSample.Text = "Chạy hết";
                contest_btnRunAllUserTest.Text = "Chạy hết";
                contest_btnSearch.Text = "Tìm kiếm";
                contest_gbSample.Text = "Mẫu thử";
                contest_gbUserTest.Text = "Mẫu thử của bạn - Tối đa 30 mẫu";
                contest_btnCleanAll.Text = "Xoá hết";
                foreach (TestCaseUI item in contest_flpSample.Controls)
                {
                    item.lblInput.Text = "Đầu vào";
                    item.lblOutput.Text = "Đầu ra";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Test case", "Mẫu thử");
                    if (item.lblVerdict.Text == "Verdict: Correct")
                    {
                        item.lblVerdict.Text = "Đánh giá: Đúng";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Wrong answer")
                    {
                        item.lblVerdict.Text = "Đánh giá: Sai";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Time limit exceeded")
                    {
                        item.lblVerdict.Text = "Đánh giá: Quá thời gian";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Đánh giá:";
                    }
                    item.lblYourOutput.Text = "Đầu ra của bạn";
                    item.btnRun.Text = "Chạy";
                    item.CurLang = 0;
                }
                foreach (TestCaseUI item in contest_flpUserTest.Controls)
                {
                    item.lblInput.Text = "Đầu vào";
                    item.lblOutput.Text = "Đầu ra";
                    item.lblTcNumber.Text = item.lblTcNumber.Text.Replace("Test case", "Mẫu thử");
                    if (item.lblVerdict.Text == "Verdict: Correct")
                    {
                        item.lblVerdict.Text = "Đánh giá: Đúng";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Wrong answer")
                    {
                        item.lblVerdict.Text = "Đánh giá: Sai";
                    }
                    else if (item.lblVerdict.Text == "Verdict: Time limit exceeded")
                    {
                        item.lblVerdict.Text = "Đánh giá: Quá thời gian";
                    }
                    else
                    {
                        item.lblVerdict.Text = "Đánh giá:";
                    }
                    item.lblYourOutput.Text = "Đầu ra của bạn";
                    item.btnRun.Text = "Chạy";
                    item.CurLang = 0;
                }
            }
        }

        private List<string> FindListOfProblem(string data)
        {
            List<string> lst = new List<string>();
            bool found = true;
            int sidx = data.IndexOf("<table class=\"problems\">");
            int eidx = data.IndexOf("</table>", sidx + 1);
            data = data.Substring(sidx, eidx - sidx);
            int start_pos = 0;
            do
            {
                int start_idx = data.IndexOf("<a href=\"/contest/" + contest_tbxContestId.Text + "/problem/", start_pos);
                int end_idx = 0;
                if (start_idx != -1)
                {
                    end_idx = data.IndexOf("\">", start_idx);
                    string sub_str = data.Substring(start_idx, end_idx - start_idx);
                    TestCase tc = new TestCase();
                    lst.Add(sub_str.Split('/')[4]);
                    start_pos = end_idx + 1;
                }
                else
                {
                    found = false;
                }
            } while (found);
            var unique = new HashSet<String>(lst);
            return new List<string>(unique);
        }

        private Problem FindInputOutput(string data)
        {
            Problem p = new Problem();
            p.Testcases = new List<TestCase>();
            bool found = true;
            int start_pos = 0;
            do
            {
                int start_idx = data.IndexOf("<pre>", start_pos);
                int end_idx = 0;
                if (start_idx != -1)
                {
                    end_idx = data.IndexOf("</pre>", start_idx);
                    string sub_str = data.Substring(start_idx + 5, end_idx - start_idx - 5);
                    TestCase tc = new TestCase();
                    tc.Input = sub_str.Replace("<br />", "\n").Trim();
                    start_pos = end_idx + 1;
                    start_idx = data.IndexOf("<pre>", start_pos);
                    end_idx = data.IndexOf("</pre>", start_idx);
                    sub_str = data.Substring(start_idx + 5, end_idx - start_idx - 5);
                    tc.Output = sub_str.Replace("<br />", "\n").Trim();
                    p.Testcases.Add(tc);
                    start_pos = end_idx + 1;
                }
                else
                {
                    found = false;
                }         
            } while (found);
            return p;
        }

        private bool ValidatePage(string data, int type)
        {
            bool ans = true;
            int start_idx = data.IndexOf("<title>");
            int end_index = data.IndexOf("</title>");
            string title = data.Substring(start_idx + 7, end_index - start_idx - 7);
            if (title == "Codeforces")
            {
                ans = false;
            }
            if (!ans)
            {
                if (curLang == 1)
                {
                    if (type == 0)
                    {
                        MessageBox.Show("Couldn't find: \nhttp://codeforces.com/problemset/problem/" + problemset_tbxContestId.Text 
                            + "/" + problemset_tbxProblemID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't find:\nhttp://codeforces.com/contest/" + contest_tbxContestId.Text, 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (type == 0)
                    {
                        MessageBox.Show("Không tìm thấy:\nhttp://codeforces.com/problemset/problem/" + problemset_tbxContestId.Text
                            + "/" + problemset_tbxProblemID.Text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy:\nhttp://codeforces.com/contest/" + contest_tbxContestId.Text,
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return ans;
        }

        private void SearchProblem(object sender, DoWorkEventArgs e)
        {
            bgw.ReportProgress(0); // any value, just to raise the DownloadingProblem()
            int type = (int)e.Argument;
            e.Result = type;
            string str_url = "http://codeforces.com/";
            lst_prob = new List<string>();
            if (type == 0)
            {
                str_url += "problemset/problem/";
                str_url += problemset_tbxContestId.Text + "/";
                str_url += problemset_tbxProblemID.Text.ToUpper();
            }
            else
            {
                str_url += "contest/";
                str_url += contest_tbxContestId.Text;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }
                string data = readStream.ReadToEnd();
                if (type == 0)
                {
                    if (ValidatePage(data, 0))
                    {
                        problemset_problem = FindInputOutput(data);
                        problemset_problem.ProblemID = problemset_tbxProblemID.Text;
                    }
                    else
                    {
                        response.Close();
                        readStream.Close();
                        return;
                    }
                }
                else
                {
                    if (ValidatePage(data, 1))
                    {
                        lst_prob = FindListOfProblem(data);
                    }
                    else
                    {
                        response.Close();
                        readStream.Close();
                        return;
                    }
                }
                response.Close();
                readStream.Close();
            }
            if (type == 1)
            {
                contest_problems.Clear();
                foreach (var prob in lst_prob)
                {
                    string tmp_url = str_url;
                    tmp_url += "/problem/" + prob;
                    request = (HttpWebRequest)WebRequest.Create(tmp_url);
                    response = (HttpWebResponse)request.GetResponse();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream receiveStream = response.GetResponseStream();
                        StreamReader readStream = null;
                        if (response.CharacterSet == null)
                        {
                            readStream = new StreamReader(receiveStream);
                        }
                        else
                        {
                            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                        }
                        string data = readStream.ReadToEnd();
                        Problem p = FindInputOutput(data);
                        p.ProblemID = prob;
                        contest_problems.Add(p);
                        response.Close();
                        readStream.Close();
                    }
                }
            }
        }

        private void DownloadingProblem(object sender, ProgressChangedEventArgs e)
        {
            loading = new frmLoading(curLang);
            loading.ShowDialog();
            bgw.CancelAsync();
        }

        private void DownloadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((int)e.Result == 1)
            {
                contest_btnAddTest.Enabled = true;
                contest_usertests.Clear();
                contest_sampletests.Clear();
                for (int k = 0; k < lst_prob.Count; k++)
                {
                    contest_sampletests.Add(lst_prob[k], new List<TestCaseUI>());
                    contest_usertests.Add(lst_prob[k], new List<TestCaseUI>());
                    for (int i = 0; i < contest_problems[k].Testcases.Count; i++)
                    {
                        CreateTestCaseUI(contest_problems[k].Testcases[i], 1, i + 1, lst_prob[k]);
                    }
                }
                contest_cbxProblems.DataSource = lst_prob;
            }
            else
            {
                problemset_flpSample.Controls.Clear();
                problemset_flpUserTest.Controls.Clear();
                for (int i = 0; i < problemset_problem.Testcases.Count; i++)
                {
                    CreateTestCaseUI(problemset_problem.Testcases[i], 0, i + 1, "");
                }
            }
            loading.Close();
        }

        private void CreateTestCaseUI(TestCase tc, int type, int index, string key)
        {
            TestCaseUI tcu = new TestCaseUI();
            if (curLang == 0)
            {
                tcu.lblInput.Text = "Đầu vào";
                tcu.lblOutput.Text = "Đầu ra";
                tcu.lblTcNumber.Text = "Mẫu thử";
                tcu.lblVerdict.Text = "Đánh giá";
                tcu.lblYourOutput.Text = "Đầu ra của bạn";
                tcu.btnRun.Text = "Chạy";
                tcu.CurLang = 0;
            }
            tcu.lblTcNumber.Text += " - " + index.ToString();
            tcu.tbxInput.Text = tc.Input;
            tcu.tbxOutput.Text = tc.Output;
            if (type == 0) // problemset
            {
                if (index == -1) // user test case
                {
                    tcu.lblTcNumber.Text = tcu.lblTcNumber.Text.Split('-')[0] + "- " + (problemset_flpUserTest.Controls.Count + 1).ToString();
                    tcu.tbxInput.ReadOnly = false;
                    tcu.tbxOutput.ReadOnly = false;
                    tcu.IsUserTC = true;
                    problemset_flpUserTest.Controls.Add(tcu);
                }
                else // sample
                {
                    tcu.btnDelete.Visible = false;
                    problemset_flpSample.Controls.Add(tcu);
                }
            }
            else // contest
            {
                if (index == -1) // user test cases
                {
                    tcu.lblTcNumber.Text = tcu.lblTcNumber.Text.Split('-')[0] + "- " + (contest_flpUserTest.Controls.Count + 1).ToString();
                    tcu.tbxInput.ReadOnly = false;
                    tcu.tbxOutput.ReadOnly = false;
                    contest_usertests[key].Add(tcu);
                    contest_flpUserTest.Controls.Add(tcu);
                }
                else // sample
                {
                    tcu.btnDelete.Visible = false;
                    contest_sampletests[key].Add(tcu);
                }
            }
        }

        private void problemset_btnSearch_Click(object sender, EventArgs e)
        {
            if (problemset_tbxContestId.Text == "" || problemset_tbxProblemID.Text == "")
            {
                if (curLang == 1)
                {
                    MessageBox.Show("Enter Contest ID and Problem ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ Mã kì thi và Mã bài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            bgw.RunWorkerAsync(0);
        }

        private void contest_btnSearch_Click(object sender, EventArgs e)
        {
            if (contest_tbxContestId.Text == "")
            {
                if (curLang == 1)
                {
                    MessageBox.Show("Enter contest ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ Mã kì thi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            bgw.RunWorkerAsync(1);
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbxLanguage.Text == "English" && curLang == 0) || (cbxLanguage.Text == "Tiếng Việt" && curLang == 1))
            {
                curLang ^= 1;
                ConvertLanguage();
            }
        }

        private void contest_cbxProblems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = contest_cbxProblems.Text;
            if (oldKey != null)
            {
                contest_usertests[oldKey].Clear();
                foreach (TestCaseUI item in contest_flpUserTest.Controls)
                {
                    contest_usertests[oldKey].Add(item);
                }
            }
            oldKey = key;
            contest_flpUserTest.Controls.Clear();
            contest_flpSample.Controls.Clear();
            foreach (var item in contest_sampletests[key])
            {
                contest_flpSample.Controls.Add(item);
            }

            foreach (var item in contest_usertests[key])
            {
                contest_flpUserTest.Controls.Add(item);
            }
        }

        private void problemset_btnAddTest_Click(object sender, EventArgs e)
        {
            if (problemset_flpUserTest.Controls.Count == 30)
            {
                if (curLang == 1)
                {
                    MessageBox.Show("You've created 30 test cases", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã tạo đủ 30 mẫu thử", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            CreateTestCaseUI(new TestCase(), tcMain.SelectedIndex, -1, "");
        }

        private void contest_btnAddTest_Click(object sender, EventArgs e)
        {
            string key = contest_cbxProblems.Text;
            if (contest_usertests[key].Count == 30)
            {
                if (curLang == 1)
                {
                    MessageBox.Show("You've created 30 test cases", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Bạn đã tạo đủ 30 mẫu thử", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            CreateTestCaseUI(new TestCase(), tcMain.SelectedIndex, -1, key);
        }

        private void contest_tbxWorkingDir_TextChanged(object sender, EventArgs e)
        {
            Program.contest_directory = contest_tbxWorkingDir.Text;
        }

        private void contest_tbxExe_TextChanged(object sender, EventArgs e)
        {
            Program.contest_exe = contest_tbxExe.Text;
        }

        private void problemset_tbxWorkingDir_TextChanged(object sender, EventArgs e)
        {
            Program.problemset_directory = problemset_tbxWorkingDir.Text;
        }

        private void problemset_tbxExe_TextChanged(object sender, EventArgs e)
        {
            Program.problemset_exe = problemset_tbxExe.Text;
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.type = tcMain.SelectedIndex;
        }

        private void contest_btnRunAllSample_Click(object sender, EventArgs e)
        {
            if (contest_tbxWorkingDir.Text == "" || contest_tbxExe.Text == "")
            {
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
            if (contest_flpSample.Controls.Count == 0)
            {
                return;
            }
            contest_btnRunAllSample.Visible = false;
            foreach (TestCaseUI item in contest_flpSample.Controls)
            {
                item.btnRun.PerformClick();
            }
        }

        private void contest_btnRunAllUserTest_Click(object sender, EventArgs e)
        {
            if (contest_tbxWorkingDir.Text == "" || contest_tbxExe.Text == "")
            {
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
            if (contest_flpUserTest.Controls.Count == 0)
            {
                return;
            }
            contest_btnRunAllUserTest.Visible = false;
            contest_btnCleanAll.Visible = false;
            foreach (TestCaseUI item in contest_flpUserTest.Controls)
            {
                item.btnRun.PerformClick();
            }
        }

        private void problemset_btnRunAllSample_Click(object sender, EventArgs e)
        {
            if (problemset_tbxWorkingDir.Text == "" || problemset_tbxWorkingDir.Text == "")
            {
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
            if (problemset_flpSample.Controls.Count == 0)
            {
                return;
            }
            problemset_btnRunAllSample.Visible = false;
            foreach (TestCaseUI item in problemset_flpSample.Controls)
            {
                item.btnRun.PerformClick();
            }
        }

        private void problemset_btnRunAllUserTest_Click(object sender, EventArgs e)
        {
            if (problemset_tbxWorkingDir.Text == "" || problemset_tbxWorkingDir.Text == "")
            {
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
            if (problemset_flpUserTest.Controls.Count == 0)
            {
                return;
            }
            problemset_btnRunAllUserTest.Visible = false;
            problemset_btnCleanAll.Visible = false;
            foreach (TestCaseUI item in problemset_flpUserTest.Controls)
            {
                item.btnRun.PerformClick();
            }
        }

        private void contest_btnCleanAll_Click(object sender, EventArgs e)
        {
            contest_flpUserTest.Controls.Clear();
        }

        private void problemset_btnCleanAll_Click(object sender, EventArgs e)
        {
            problemset_flpUserTest.Controls.Clear();
        }
    }
}
