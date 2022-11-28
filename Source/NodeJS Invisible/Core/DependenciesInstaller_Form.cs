using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NodeJS_Invisible.Core
{
    public partial class DependenciesInstaller_Form : Form
    {
        static ConfigChecker Config = new ConfigChecker();

        public DependenciesInstaller_Form()
        {
            InitializeComponent();
            this.Text = Config.getProgramName();
            label1.Text = Config.getDependenciesWindowText();
        }

        private void DependenciesInstaller_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
