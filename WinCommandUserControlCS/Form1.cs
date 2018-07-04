using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCommandUserControlCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void commandButtons1_CommandButtonClickEvent(object sender, UserControls.CommandButtons.CommandUCArgs e)
        {
            MessageBox.Show(string.Format("{0}, {1}",e.TargetKind.ToString(),e.Target.Name.ToString()));
        }
    }
}
