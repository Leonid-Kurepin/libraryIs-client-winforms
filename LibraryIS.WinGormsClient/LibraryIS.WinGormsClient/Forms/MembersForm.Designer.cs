namespace LibraryIS.WinFormsClient.Forms
{
    partial class Members
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
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonBookToMember = new System.Windows.Forms.Button();
            this.buttonBookFromMember = new System.Windows.Forms.Button();
            this.buttonEditMember = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonToMainMenu = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.labelMembers = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(466, 609);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(120, 31);
            this.buttonPreviousPage.TabIndex = 37;
            this.buttonPreviousPage.Text = "Назад";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(1177, 609);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(120, 31);
            this.buttonNextPage.TabIndex = 36;
            this.buttonNextPage.Text = "Вперед";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonBookToMember
            // 
            this.buttonBookToMember.Location = new System.Drawing.Point(59, 128);
            this.buttonBookToMember.Name = "buttonBookToMember";
            this.buttonBookToMember.Size = new System.Drawing.Size(339, 50);
            this.buttonBookToMember.TabIndex = 30;
            this.buttonBookToMember.Text = "Выдать книгу читателю";
            this.buttonBookToMember.UseVisualStyleBackColor = true;
            // 
            // buttonBookFromMember
            // 
            this.buttonBookFromMember.Location = new System.Drawing.Point(59, 220);
            this.buttonBookFromMember.Name = "buttonBookFromMember";
            this.buttonBookFromMember.Size = new System.Drawing.Size(339, 50);
            this.buttonBookFromMember.TabIndex = 31;
            this.buttonBookFromMember.Text = "Принять книгу от читателя";
            this.buttonBookFromMember.UseVisualStyleBackColor = true;
            // 
            // buttonEditMember
            // 
            this.buttonEditMember.Location = new System.Drawing.Point(59, 432);
            this.buttonEditMember.Name = "buttonEditMember";
            this.buttonEditMember.Size = new System.Drawing.Size(339, 37);
            this.buttonEditMember.TabIndex = 32;
            this.buttonEditMember.Text = "Изменить";
            this.buttonEditMember.UseVisualStyleBackColor = true;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(59, 370);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(339, 37);
            this.buttonAddMember.TabIndex = 33;
            this.buttonAddMember.Text = "Добавить";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            // 
            // buttonToMainMenu
            // 
            this.buttonToMainMenu.Location = new System.Drawing.Point(59, 592);
            this.buttonToMainMenu.Name = "buttonToMainMenu";
            this.buttonToMainMenu.Size = new System.Drawing.Size(339, 48);
            this.buttonToMainMenu.TabIndex = 34;
            this.buttonToMainMenu.Text = "В главное меню";
            this.buttonToMainMenu.UseVisualStyleBackColor = true;
            this.buttonToMainMenu.Click += new System.EventHandler(this.ButtonToMainMenu_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(59, 494);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(339, 37);
            this.buttonDeleteMember.TabIndex = 35;
            this.buttonDeleteMember.Text = "Удалить";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembers.Location = new System.Drawing.Point(461, 53);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(112, 25);
            this.labelMembers.TabIndex = 29;
            this.labelMembers.Text = "Читатели";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToDeleteRows = false;
            this.dataGridViewMembers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(435, 81);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.RowTemplate.Height = 24;
            this.dataGridViewMembers.Size = new System.Drawing.Size(885, 502);
            this.dataGridViewMembers.TabIndex = 38;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 698);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonBookToMember);
            this.Controls.Add(this.buttonBookFromMember);
            this.Controls.Add(this.buttonEditMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonToMainMenu);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.labelMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing);
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonBookToMember;
        private System.Windows.Forms.Button buttonBookFromMember;
        private System.Windows.Forms.Button buttonEditMember;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonToMainMenu;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
    }
}

