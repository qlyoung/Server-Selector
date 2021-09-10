using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Echo_Arena_Private_Match_Creator
{
    class CMD
    {

        public void ConsoleInput(string exe, string region)
        {
            Regions reg = new Regions();
            LocateExe locate = new LocateExe();
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true; //set true after, false for debug purposes.
            cmd.StartInfo.UseShellExecute = false; //false
            cmd.Start();

            cmd.StandardInput.WriteLine($@"{exe}\echovr.exe -region {region}"); //{exe}\\echovr.exe -region {region}
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        public string ConsoleReturn(string input)
        {
            Regions reg = new Regions();
            LocateExe locate = new LocateExe();
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true; //set true after, false for debug purposes.
            cmd.StartInfo.UseShellExecute = false; //false
            cmd.Start();

            //cmd.StandardInput.WriteLine(input); //{exe}\\echovr.exe -region {region}
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return (cmd.StandardOutput.ReadToEnd()).ToString();
        }

        public string FindExeD()
        {
            //https://www.computerhope.com/issues/ch000309.htm
            Regions reg = new Regions();
            LocateExe locate = new LocateExe();
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true; 
            cmd.StartInfo.UseShellExecute = false; 
            cmd.Start();

            //cmd.StandardInput.WriteLine($"d:"); //d:
            cmd.StandardInput.WriteLine($"dir D: echovr.exe /s"); //dir echovr.exe /s
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            string output = (cmd.StandardOutput.ReadToEnd()).ToString();



            return output;
        }

    }
}
