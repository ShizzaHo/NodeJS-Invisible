using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

using NodeJS_Invisible.Core;

namespace NodeJS_Invisible
{
    static class Program
    {
        static ConfigChecker Config = new ConfigChecker();
        static DependenciesInstaller Dependencies = new DependenciesInstaller();
        static AppRunner Runner = new AppRunner();

        [STAThread]
        static void Main()
        {
            if (!Config.getInstallDependencies())
            {
                Runner.RunApp(Config.getStartCommand(), Config.getShowConsole(), Config.getIntegratedNodeJS());
            } else
            {
                Dependencies.install(Config.getInstallCommand(), Config.getDependenciesShowWindow());
                Runner.RunApp(Config.getStartCommand(), Config.getShowConsole(), Config.getIntegratedNodeJS());
            }
        }

        static void HandleAppExit(object sender, EventArgs e)
        {
            Runner.ExitApp();
        }
    }
}
