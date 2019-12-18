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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            Books booksForm = new Books();
            booksForm.Tag = this;
            booksForm.Show();
            this.Hide();
        }

        private void ButtonMembers_Click(object sender, EventArgs e)
        {
            Users membersForm = new Users();
            membersForm.Tag = this;
            membersForm.Show(this);
            this.Hide();
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            Members usersForm = new Members();
            usersForm.Tag = this;
            usersForm.Show();
            this.Hide();
        }
    }
}
