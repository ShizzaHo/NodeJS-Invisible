using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NodeJS_Invisible.Core
{
    class ConfigChecker
    {
        INIManager config;

        public ConfigChecker()
        {
            config = new INIManager("NJSI_Data/config.ini");
        }

        public string getProgramName()
        {
            return config.GetPrivateString("Info", "ProgramName");
        }

        public Boolean getIntegratedNodeJS()
        {
            return Convert.ToBoolean(config.GetPrivateString("NodeJS", "IntegratedNodeJS"));
        }

        public string getStartCommand()
        {
            return config.GetPrivateString("Running", "StartCommand");
        }

        public string getInstallCommand()
        {
            return config.GetPrivateString("Dependencies", "InstallCommand");
        }

        public Boolean getShowConsole()
        {
            return Convert.ToBoolean(config.GetPrivateString("Running", "ShowConsole"));
        }

        public Boolean getInstallDependencies()
        {
            return Convert.ToBoolean(config.GetPrivateString("Running", "InstallDependencies"));
        }

        public string getDependenciesWindowText()
        {
            return config.GetPrivateString("Dependencies", "WindowText");
        }

        public Boolean getDependenciesShowWindow()
        {
            return Convert.ToBoolean(config.GetPrivateString("Dependencies", "ShowWindow"));
        }
    }
}
