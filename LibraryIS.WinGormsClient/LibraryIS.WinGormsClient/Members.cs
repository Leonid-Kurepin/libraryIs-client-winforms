using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryIS.WinGormsClient
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
