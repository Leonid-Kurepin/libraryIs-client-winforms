namespace LibraryIS.WinGormsClient
{
    partial class Books
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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.labelBooks = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.labelFilterAuthor = new System.Windows.Forms.Label();
            this.labelFilterTitle = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonToMainMenu = new System.Windows.Forms.Button();
            this.buttonBookFromMember = new System.Windows.Forms.Button();
            this.buttonBookToMember = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(485, 87);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(496, 500);
            this.listBoxBooks.TabIndex = 0;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooks.Location = new System.Drawing.Point(482, 42);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(70, 25);
            this.labelBooks.TabIndex = 1;
            this.labelBooks.Text = "Книги";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(847, 608);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(120, 31);
            this.buttonNextPage.TabIndex = 2;
            this.buttonNextPage.Text = "Вперед";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Location = new System.Drawing.Point(502, 608);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(120, 31);
            this.buttonPreviousPage.TabIndex = 3;
            this.buttonPreviousPage.Text = "Назад";
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // labelFilterAuthor
            // 
            this.labelFilterAuthor.AutoSize = true;
            this.labelFilterAuthor.Location = new System.Drawing.Point(64, 136);
            this.labelFilterAuthor.Name = "labelFilterAuthor";
            this.labelFilterAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelFilterAuthor.TabIndex = 14;
            this.labelFilterAuthor.Text = "Автор";
            // 
            // labelFilterTitle
            // 
            this.labelFilterTitle.AutoSize = true;
            this.labelFilterTitle.Location = new System.Drawing.Point(64, 67);
            this.labelFilterTitle.Name = "labelFilterTitle";
            this.labelFilterTitle.Size = new System.Drawing.Size(72, 17);
            this.labelFilterTitle.TabIndex = 15;
            this.labelFilterTitle.Text = "Название";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(15, 38);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(96, 17);
            this.labelFilter.TabIndex = 13;
            this.labelFilter.Text = "Фильтровать";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 12;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(641, 608);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(187, 31);
            this.buttonAddBook.TabIndex = 8;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(67, 507);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(339, 37);
            this.buttonDeleteBook.TabIndex = 9;
            this.buttonDeleteBook.Text = "Удалить книгу";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(313, 201);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(93, 31);
            this.buttonFilter.TabIndex = 10;
            this.buttonFilter.Text = "Применить";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonToMainMenu
            // 
            this.buttonToMainMenu.Location = new System.Drawing.Point(67, 591);
            this.buttonToMainMenu.Name = "buttonToMainMenu";
            this.buttonToMainMenu.Size = new System.Drawing.Size(339, 48);
            this.buttonToMainMenu.TabIndex = 9;
            this.buttonToMainMenu.Text = "В главное меню";
            this.buttonToMainMenu.UseVisualStyleBackColor = true;
            this.buttonToMainMenu.Click += new System.EventHandler(this.ButtonToMainMenu_Click);
            // 
            // buttonBookFromMember
            // 
            this.buttonBookFromMember.Location = new System.Drawing.Point(67, 346);
            this.buttonBookFromMember.Name = "buttonBookFromMember";
            this.buttonBookFromMember.Size = new System.Drawing.Size(339, 50);
            this.buttonBookFromMember.TabIndex = 8;
            this.buttonBookFromMember.Text = "Принять от читателя";
            this.buttonBookFromMember.UseVisualStyleBackColor = true;
            // 
            // buttonBookToMember
            // 
            this.buttonBookToMember.Location = new System.Drawing.Point(67, 275);
            this.buttonBookToMember.Name = "buttonBookToMember";
            this.buttonBookToMember.Size = new System.Drawing.Size(339, 50);
            this.buttonBookToMember.TabIndex = 8;
            this.buttonBookToMember.Text = "Выдать читателю";
            this.buttonBookToMember.UseVisualStyleBackColor = true;
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(67, 439);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(339, 37);
            this.buttonEditBook.TabIndex = 8;
            this.buttonEditBook.Text = "Редактировать книгу";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 698);
            this.Controls.Add(this.labelFilterAuthor);
            this.Controls.Add(this.labelFilterTitle);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBookToMember);
            this.Controls.Add(this.buttonBookFromMember);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonToMainMenu);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonPreviousPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "Books";
            this.Text = "Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Books_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Label labelFilterAuthor;
        private System.Windows.Forms.Label labelFilterTitle;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonToMainMenu;
        private System.Windows.Forms.Button buttonBookFromMember;
        private System.Windows.Forms.Button buttonBookToMember;
        private System.Windows.Forms.Button buttonEditBook;
    }
}