using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NodeJS_Invisible.Core
{
    class DependenciesInstaller
    {
        static Process appProc = new Process();

        public void install(string installCommand, Boolean showWindow)
        {
            var DependenciesInstaller_Form = new DependenciesInstaller_Form();

            if (showWindow)
            {
                DependenciesInstaller_Form.Show();
            }

            appProc.StartInfo.FileName = "cmd.exe";
            appProc.StartInfo.RedirectStandardInput = true;
            appProc.StartInfo.RedirectStandardOutput = true;
            appProc.StartInfo.CreateNoWindow = true;
            appProc.StartInfo.UseShellExecute = false;
            appProc.Start();

            appProc.StandardInput.WriteLine("cd NJSI_Data/app");
            appProc.StandardInput.WriteLine(installCommand);
            appProc.StandardInput.Flush();
            appProc.StandardInput.Close();
            appProc.WaitForExit();

            DependenciesInstaller_Form.Close();
        }
    }
}
