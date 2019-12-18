using System;
using System.Windows.Forms;

namespace LibraryIS.WinGormsClient
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
