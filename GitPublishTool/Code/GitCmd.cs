using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPublishTool.Code
{
    public static class GitCmd
    {
        public static string Run(string command, string dirPath)
        {
            StreamReader streamReader = RunStream(command, dirPath);
            // 返回执行的结果
            string result = streamReader.ReadToEnd();
            streamReader.Close();

            return result;
        }

        public static StreamReader RunStream(string command, string dirPath)
        {
            // 需用引用命名空间System.Diagnostics;
            // 打开一个新进程
            Process p = new Process();
            // 指定进程程序名称
            p.StartInfo.FileName = @"D:\Git\cmd\git.exe";
            //
            p.StartInfo.WorkingDirectory = dirPath;
            // 设定要输入命令
            p.StartInfo.Arguments = command;
            // 关闭Shell的使用
            p.StartInfo.UseShellExecute = false;
            // 重定向标准输入
            p.StartInfo.RedirectStandardInput = true;
            // 重定向标准输出
            p.StartInfo.RedirectStandardOutput = true;
            // 重定向错误输出
            p.StartInfo.RedirectStandardError = true;
            // 不显示命令提示符窗口
            p.StartInfo.CreateNoWindow = true;
            //回调事件
            //p.OutputDataReceived += p_OutputDataReceived;
            //p.BeginOutputReadLine();
            // 启动程序
            p.Start();
            // 返回执行的结果

            //string tmp = p.StandardOutput.ReadToEnd();

            var streamReader = p.StandardOutput;
            p.WaitForExit();
            return streamReader;
        }
    }
}