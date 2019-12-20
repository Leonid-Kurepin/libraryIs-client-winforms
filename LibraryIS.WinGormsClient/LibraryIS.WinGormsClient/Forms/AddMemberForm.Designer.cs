namespace LibraryIS.WinFormsClient.Forms
{
    partial class AddMemberForm
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
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxDob = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxPassportSeries = new System.Windows.Forms.TextBox();
            this.labelPassportSeries = new System.Windows.Forms.Label();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Brown;
            this.labelErrorMessage.Location = new System.Drawing.Point(162, 67);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(227, 17);
            this.labelErrorMessage.TabIndex = 15;
            this.labelErrorMessage.Text = "Error when attempt to add member";
            this.labelErrorMessage.Visible = false;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(19, 348);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(347, 32);
            this.buttonAddUser.TabIndex = 14;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(51, 35);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(286, 20);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Добавление нового читателя";
            // 
            // textBoxDob
            // 
            this.textBoxDob.Location = new System.Drawing.Point(19, 299);
            this.textBoxDob.Name = "textBoxDob";
            this.textBoxDob.Size = new System.Drawing.Size(347, 22);
            this.textBoxDob.TabIndex = 9;
            this.textBoxDob.Text = "01/02/1992";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(16, 279);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(82, 17);
            this.labelDateOfBirth.TabIndex = 5;
            this.labelDateOfBirth.Text = "DateOfBirth";
            // 
            // textBoxPassportSeries
            // 
            this.textBoxPassportSeries.Location = new System.Drawing.Point(19, 237);
            this.textBoxPassportSeries.Name = "textBoxPassportSeries";
            this.textBoxPassportSeries.Size = new System.Drawing.Size(347, 22);
            this.textBoxPassportSeries.TabIndex = 10;
            this.textBoxPassportSeries.Text = "1512";
            // 
            // labelPassportSeries
            // 
            this.labelPassportSeries.AutoSize = true;
            this.labelPassportSeries.Location = new System.Drawing.Point(16, 217);
            this.labelPassportSeries.Name = "labelPassportSeries";
            this.labelPassportSeries.Size = new System.Drawing.Size(104, 17);
            this.labelPassportSeries.TabIndex = 6;
            this.labelPassportSeries.Text = "PassportSeries";
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(19, 170);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(347, 22);
            this.textBoxPassportNumber.TabIndex = 11;
            this.textBoxPassportNumber.Text = "123485";
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Location = new System.Drawing.Point(16, 150);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(114, 17);
            this.labelPassportNumber.TabIndex = 7;
            this.labelPassportNumber.Text = "PassportNumber";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(19, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(347, 22);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.Text = "Member New";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 403);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.textBoxDob);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.textBoxPassportSeries);
            this.Controls.Add(this.labelPassportSeries);
            this.Controls.Add(this.textBoxPassportNumber);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMemberForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxDob;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPassportSeries;
        private System.Windows.Forms.Label labelPassportSeries;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Label labelPassportNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}