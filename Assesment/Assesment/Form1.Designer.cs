namespace Assesment
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelShowAllBooks = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show All Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelShowAllBooks
            // 
            this.labelShowAllBooks.AutoSize = true;
            this.labelShowAllBooks.Location = new System.Drawing.Point(424, 37);
            this.labelShowAllBooks.Name = "labelShowAllBooks";
            this.labelShowAllBooks.Size = new System.Drawing.Size(0, 13);
            this.labelShowAllBooks.TabIndex = 1;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(263, 36);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(86, 13);
            this.labelBookTitle.TabIndex = 2;
            this.labelBookTitle.Text = "Enter Book Title:";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(263, 69);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(100, 13);
            this.labelAuthorName.TabIndex = 3;
            this.labelAuthorName.Text = "Enter Author Name:";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(263, 98);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(63, 13);
            this.labelISBN.TabIndex = 4;
            this.labelISBN.Text = "Enter ISBN:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(263, 125);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 13);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Enter Price:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(397, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(233, 20);
            this.textBoxTitle.TabIndex = 6;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(397, 69);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(233, 20);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(397, 98);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(233, 20);
            this.textBoxISBN.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(397, 125);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(233, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add a Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 478);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.labelShowAllBooks);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelShowAllBooks;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}