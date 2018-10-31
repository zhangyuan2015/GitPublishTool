using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPublishTool.Code
{
    public static class Cmd
    {
        public static string RunCmd(string command)
        {
            // 需用引用命名空间System.Diagnostics;
            // 打开一个新进程
            Process p = new Process();
            // 指定进程程序名称
            p.StartInfo.FileName = "cmd.exe";
            // 设定要输入命令
            p.StartInfo.Arguments = "/c " + command;
            // 关闭Shell的使用
            p.StartInfo.UseShellExecute = false;
            // 重定向标准输入
            p.StartInfo.RedirectStandardInput = true;
            // 重定向标准输出
            p.StartInfo.RedirectStandardOutput = true;
            // 重定向错误输出
            p.StartInfo.RedirectStandardError = true;
            // 不显示命令提示符窗口
            p.StartInfo.CreateNoWindow = false;
            // 启动程序
            p.Start();
            // 返回执行的结果
            return p.StandardOutput.ReadToEnd();
        }

        public static StreamReader RunCmdStream(string command)
        {
            // 需用引用命名空间System.Diagnostics;
            // 打开一个新进程
            Process p = new Process();
            // 指定进程程序名称
            p.StartInfo.FileName = "cmd.exe";
            // 设定要输入命令
            p.StartInfo.Arguments = "/c " + command;
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
            // 启动程序
            p.Start();
            // 返回执行的结果
            return p.StandardOutput;
        }
    }
}