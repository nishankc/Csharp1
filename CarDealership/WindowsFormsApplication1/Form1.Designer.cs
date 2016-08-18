namespace WindowsFormsApplication1
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
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonCarList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(127, 51);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(191, 53);
            this.buttonAddCar.TabIndex = 0;
            this.buttonAddCar.Text = "Add A Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCarList
            // 
            this.buttonCarList.Location = new System.Drawing.Point(127, 129);
            this.buttonCarList.Name = "buttonCarList";
            this.buttonCarList.Size = new System.Drawing.Size(191, 51);
            this.buttonCarList.TabIndex = 1;
            this.buttonCarList.Text = "List Cars";
            this.buttonCarList.UseVisualStyleBackColor = true;
            this.buttonCarList.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 437);
            this.Controls.Add(this.buttonCarList);
            this.Controls.Add(this.buttonAddCar);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonCarList;
    }
}

