namespace LibraryIS.WinFormsClient
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonToMainMenu = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.labelMembers = new System.Windows.Forms.Label();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(85, 154);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(249, 37);
            this.buttonAddMember.TabIndex = 23;
            this.buttonAddMember.Text = "Добавить";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // buttonToMainMenu
            // 
            this.buttonToMainMenu.Location = new System.Drawing.Point(85, 362);
            this.buttonToMainMenu.Name = "buttonToMainMenu";
            this.buttonToMainMenu.Size = new System.Drawing.Size(249, 63);
            this.buttonToMainMenu.TabIndex = 24;
            this.buttonToMainMenu.Text = "В главное меню";
            this.buttonToMainMenu.UseVisualStyleBackColor = true;
            this.buttonToMainMenu.Click += new System.EventHandler(this.ButtonToMainMenu_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(85, 250);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(249, 37);
            this.buttonDeleteMember.TabIndex = 25;
            this.buttonDeleteMember.Text = "Удалить";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembers.Location = new System.Drawing.Point(410, 49);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(159, 25);
            this.labelMembers.TabIndex = 17;
            this.labelMembers.Text = "Пользователи";
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 16;
            this.listBoxMembers.Location = new System.Drawing.Point(413, 94);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(496, 276);
            this.listBoxMembers.TabIndex = 16;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(776, 394);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(120, 31);
            this.buttonNextPage.TabIndex = 26;
            this.buttonNextPage.Text = "Вперед";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(427, 394);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(120, 31);
            this.buttonPreviousPage.TabIndex = 27;
            this.buttonPreviousPage.Text = "Назад";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 508);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonToMainMenu);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.labelMembers);
            this.Controls.Add(this.listBoxMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonToMainMenu;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
    }
}