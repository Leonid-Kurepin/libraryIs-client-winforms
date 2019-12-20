namespace LibraryIS.WinFormsClient.Forms
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
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonToMainMenu = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(55, 120);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(249, 37);
            this.buttonAddUser.TabIndex = 23;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // buttonToMainMenu
            // 
            this.buttonToMainMenu.Location = new System.Drawing.Point(55, 362);
            this.buttonToMainMenu.Name = "buttonToMainMenu";
            this.buttonToMainMenu.Size = new System.Drawing.Size(249, 63);
            this.buttonToMainMenu.TabIndex = 24;
            this.buttonToMainMenu.Text = "В главное меню";
            this.buttonToMainMenu.UseVisualStyleBackColor = true;
            this.buttonToMainMenu.Click += new System.EventHandler(this.ButtonToMainMenu_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(55, 218);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(249, 37);
            this.buttonDeleteUser.TabIndex = 25;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(374, 49);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(159, 25);
            this.labelUsers.TabIndex = 17;
            this.labelUsers.Text = "Пользователи";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(807, 394);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(120, 31);
            this.buttonNextPage.TabIndex = 26;
            this.buttonNextPage.Text = "Вперед";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(379, 394);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(120, 31);
            this.buttonPreviousPage.TabIndex = 27;
            this.buttonPreviousPage.Text = "Назад";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(370, 77);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(566, 295);
            this.dataGridViewUsers.TabIndex = 28;
            this.dataGridViewUsers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridViewUsers_RowStateChanged);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 508);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonToMainMenu);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonToMainMenu;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}