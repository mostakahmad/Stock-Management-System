namespace StockManagementSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.CategoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.StockInButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.erdRictureBox = new System.Windows.Forms.PictureBox();
            this.ERDiagramButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.introLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HomButton = new System.Windows.Forms.Button();
            this.groupMemberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erdRictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(332, 58);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(95, 24);
            this.CategoryButton.TabIndex = 0;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(341, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Management System";
            // 
            // CompanyButton
            // 
            this.CompanyButton.Location = new System.Drawing.Point(231, 58);
            this.CompanyButton.Name = "CompanyButton";
            this.CompanyButton.Size = new System.Drawing.Size(95, 24);
            this.CompanyButton.TabIndex = 3;
            this.CompanyButton.Text = "Company";
            this.CompanyButton.UseVisualStyleBackColor = true;
            this.CompanyButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(433, 58);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(95, 24);
            this.ItemButton.TabIndex = 4;
            this.ItemButton.Text = "Items";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // StockInButton
            // 
            this.StockInButton.Location = new System.Drawing.Point(534, 58);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(95, 24);
            this.StockInButton.TabIndex = 5;
            this.StockInButton.Text = "Stock In";
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(635, 58);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(95, 24);
            this.StockOutButton.TabIndex = 6;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search and View Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "View Report of Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupMemberGroupBox
            // 
            this.groupMemberGroupBox.Controls.Add(this.erdRictureBox);
            this.groupMemberGroupBox.Controls.Add(this.ERDiagramButton);
            this.groupMemberGroupBox.Controls.Add(this.label4);
            this.groupMemberGroupBox.Controls.Add(this.introLable);
            this.groupMemberGroupBox.Controls.Add(this.label3);
            this.groupMemberGroupBox.Controls.Add(this.pictureBox1);
            this.groupMemberGroupBox.Controls.Add(this.label2);
            this.groupMemberGroupBox.Location = new System.Drawing.Point(70, 133);
            this.groupMemberGroupBox.Name = "groupMemberGroupBox";
            this.groupMemberGroupBox.Size = new System.Drawing.Size(801, 459);
            this.groupMemberGroupBox.TabIndex = 9;
            this.groupMemberGroupBox.TabStop = false;
            this.groupMemberGroupBox.Text = "Owner Details";
            // 
            // erdRictureBox
            // 
            this.erdRictureBox.Image = ((System.Drawing.Image)(resources.GetObject("erdRictureBox.Image")));
            this.erdRictureBox.Location = new System.Drawing.Point(-18, 0);
            this.erdRictureBox.Name = "erdRictureBox";
            this.erdRictureBox.Size = new System.Drawing.Size(848, 479);
            this.erdRictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erdRictureBox.TabIndex = 12;
            this.erdRictureBox.TabStop = false;
            // 
            // ERDiagramButton
            // 
            this.ERDiagramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERDiagramButton.Location = new System.Drawing.Point(587, 12);
            this.ERDiagramButton.Name = "ERDiagramButton";
            this.ERDiagramButton.Size = new System.Drawing.Size(206, 43);
            this.ERDiagramButton.TabIndex = 11;
            this.ERDiagramButton.Text = "View E-R Diagram";
            this.ERDiagramButton.UseVisualStyleBackColor = true;
            this.ERDiagramButton.Click += new System.EventHandler(this.ERDiagramButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Copyright 2019 @ All Rights Reserved By Infinity";
            // 
            // introLable
            // 
            this.introLable.AutoSize = true;
            this.introLable.BackColor = System.Drawing.SystemColors.Window;
            this.introLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.introLable.Location = new System.Drawing.Point(98, 336);
            this.introLable.Name = "introLable";
            this.introLable.Size = new System.Drawing.Size(0, 17);
            this.introLable.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mostak Ahmad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(333, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Infinity";
            // 
            // HomButton
            // 
            this.HomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomButton.Location = new System.Drawing.Point(745, 633);
            this.HomButton.Name = "HomButton";
            this.HomButton.Size = new System.Drawing.Size(206, 43);
            this.HomButton.TabIndex = 10;
            this.HomButton.Text = "Go Back Home";
            this.HomButton.UseVisualStyleBackColor = true;
            this.HomButton.Click += new System.EventHandler(this.HomButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 688);
            this.Controls.Add(this.HomButton);
            this.Controls.Add(this.groupMemberGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.StockInButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.CompanyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        Stock Management System";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupMemberGroupBox.ResumeLayout(false);
            this.groupMemberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erdRictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupMemberGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomButton;
        private System.Windows.Forms.Label introLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ERDiagramButton;
        private System.Windows.Forms.PictureBox erdRictureBox;
    }
}

