using GitPublishTool.Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitPublishTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string ProjectPath { get; set; }

        private void txtProjectPath_TextChanged(object sender, EventArgs e)
        {
            ProjectPath = (sender as TextBox).Text;

            if (string.IsNullOrWhiteSpace(ProjectPath))
                return;

            if (!Directory.Exists(ProjectPath))
            {
                AppendOutLog("目录不存在");
                CsprojPathAutoComplete(null);
                return;
            }

            string[] slnFiles = Directory.GetFiles(@ProjectPath, "*.sln", SearchOption.TopDirectoryOnly);
            if (!slnFiles.Any())
            {
                AppendOutLog("未找到解决方案文件(*.sln)");
                CsprojPathAutoComplete(null);
                return;
            }

            List<KeyValuePair<string, string>> csprojPathList = new List<KeyValuePair<string, string>>();

            foreach (var slnFile in slnFiles)
            {
                SolutionParser solution = null;
                try
                {
                    solution = new SolutionParser(slnFile);
                }
                catch (Exception ex)
                {
                    AppendOutLog("解析方案文件解析失败：" + ex.Message);
                    CsprojPathAutoComplete(null);
                    continue;
                }

                if (solution == null)
                {
                    AppendOutLog("解析方案文件解析失败：NULL");
                    CsprojPathAutoComplete(null);
                    continue;
                }

                if (solution.Projects == null || !solution.Projects.Any())
                {
                    AppendOutLog("未解析出工程文件");
                    CsprojPathAutoComplete(null);
                    continue;
                }

                foreach (var project in solution.Projects)
                {
                    if (project.FullName != null && project.FullName.Contains(".csproj"))
                        csprojPathList.Add(new KeyValuePair<string, string>(project.ProjectName, project.FullName));
                }
            }

            if (!csprojPathList.Any())
            {
                AppendOutLog("未解析出工程文件");
                CsprojPathAutoComplete(null);
                return;
            }


            BindCbxCsprojPath(csprojPathList);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        
        private void BindCbxCsprojPath(List<KeyValuePair<string, string>> csprojPaths)
        {
            cbxCsprojPath.DataSource = null;
            if (csprojPaths != null && csprojPaths.Any())
            {
                cbxCsprojPath.DataSource = csprojPaths;
                cbxCsprojPath.DisplayMember = "Key";
                cbxCsprojPath.ValueMember = "Value";
                cbxCsprojPath.SelectedIndex = 0;   //选中第一项
            }
        }

        private void CsprojPathAutoComplete(string[] csprojPaths)
        {
            txtCsprojPath.AutoCompleteCustomSource.Clear();

            if (csprojPaths != null && csprojPaths.Any())
            {
                txtCsprojPath.AutoCompleteCustomSource.AddRange(csprojPaths);
                txtCsprojPath.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCsprojPath.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void AppendOutLog(string logStr)
        {
            txtOutLog.Text += logStr + Environment.NewLine;
            txtOutLog.Select(txtOutLog.TextLength, 1);
            txtOutLog.ScrollToCaret();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectPath))
                return;

            string pullCmdStr = "pull";

            bool isAsnc = true;
            if (isAsnc)
            {
                var cmdStream = GitCmd.RunStream(pullCmdStr, ProjectPath);

                Task<string> line;
                while ((line = cmdStream.ReadLineAsync()) != null)
                {
                    if (line.Result == null)
                        break;
                    AppendOutLog(line.Result);
                }
                cmdStream.Close();
            }
            else
            {
                string result = GitCmd.Run(pullCmdStr, ProjectPath);
                AppendOutLog(result);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtOutLog.Text = "";
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            AppendOutLog("btnPublish_Click");
        }
    }
}