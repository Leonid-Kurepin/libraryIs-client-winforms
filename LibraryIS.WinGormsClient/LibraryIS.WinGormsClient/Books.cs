﻿using System;
using System.Windows.Forms;

namespace LibraryIS.WinGormsClient
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }

        private void ButtonToMainMenu_Click(object sender, EventArgs e)
        {
            FormsNavigationHelper.GoToMainMenu(this);
        }
    }
}
