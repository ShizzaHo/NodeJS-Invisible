using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NodeJS_Invisible.Core
{
    public class AppRunner
    {
        static Process appProc = new Process();

        public void RunApp(string startCommand, Boolean showConsole, Boolean integratedNodeJS)
        {
            appProc.StartInfo.FileName = "cmd.exe";
            appProc.StartInfo.RedirectStandardInput = true;
            appProc.StartInfo.RedirectStandardOutput = true;
            appProc.StartInfo.CreateNoWindow = !showConsole;
            appProc.StartInfo.UseShellExecute = false;
            appProc.Start();

            appProc.StandardInput.WriteLine("cd NJSI_Data/app");
            if (integratedNodeJS)
            {
                appProc.StandardInput.WriteLine("\""+System.IO.Directory.GetCurrentDirectory() + "/NJSI_Data/Integrated_NodeJS/\"" + startCommand);
            } else
            {
                appProc.StandardInput.WriteLine(startCommand);
            }
            appProc.StandardInput.Flush();
            ExitApp();
        }

        public void ExitApp()
        {
            appProc.StandardInput.Close();
            appProc.WaitForExit();
            Console.WriteLine(appProc.StandardOutput.ReadToEnd());
        }
    }
}
