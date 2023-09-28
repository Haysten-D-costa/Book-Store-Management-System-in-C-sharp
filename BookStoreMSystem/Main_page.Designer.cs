namespace BookStoreMSystem
{
    partial class Main_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.sideMenuBar = new System.Windows.Forms.Label();
            this.booksButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(355, 25, 355, 25);
            this.label1.Size = new System.Drawing.Size(930, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAIN PAGE";
            this.label1.Click += new System.EventHandler(this.main_page_label);
            // 
            // sideMenuBar
            // 
            this.sideMenuBar.AutoSize = true;
            this.sideMenuBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideMenuBar.Location = new System.Drawing.Point(12, 118);
            this.sideMenuBar.Name = "sideMenuBar";
            this.sideMenuBar.Padding = new System.Windows.Forms.Padding(0, 0, 100, 300);
            this.sideMenuBar.Size = new System.Drawing.Size(185, 318);
            this.sideMenuBar.TabIndex = 4;
            this.sideMenuBar.Text = "MAIN MENU";
            this.sideMenuBar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sideMenuBar.Click += new System.EventHandler(this.main_page_side_bar);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(30, 158);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(145, 40);
            this.booksButton.TabIndex = 5;
            this.booksButton.Text = "BOOKS";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.books_button_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Black;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(30, 293);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(145, 38);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Black;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.Location = new System.Drawing.Point(30, 204);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(145, 36);
            this.categoryButton.TabIndex = 7;
            this.categoryButton.Text = "CATEGORY";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.category_button_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.Black;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartButton.Location = new System.Drawing.Point(30, 246);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(145, 38);
            this.cartButton.TabIndex = 8;
            this.cartButton.Text = "CART";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cart_button_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Black;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(30, 337);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(145, 38);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.sideMenuBar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "Main_Page";
            this.RightToLeftLayout = true;
            this.Text = "Main_Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sideMenuBar;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}