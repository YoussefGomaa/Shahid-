
namespace user
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Content = new System.Windows.Forms.RadioButton();
            this.Users = new System.Windows.Forms.RadioButton();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.loading = new System.Windows.Forms.Button();
            this.stepback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Teal;
            this.Save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Save.Location = new System.Drawing.Point(973, 662);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 45);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(374, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 79);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome  Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Content);
            this.groupBox1.Controls.Add(this.Users);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(86, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Content
            // 
            this.Content.AutoSize = true;
            this.Content.Location = new System.Drawing.Point(42, 64);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(88, 24);
            this.Content.TabIndex = 1;
            this.Content.TabStop = true;
            this.Content.Text = "Content";
            this.Content.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Location = new System.Drawing.Point(42, 21);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(75, 24);
            this.Users.TabIndex = 0;
            this.Users.TabStop = true;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.Teal;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(59, 191);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(1022, 446);
            this.DGV.TabIndex = 6;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Teal;
            this.loading.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loading.Location = new System.Drawing.Point(852, 112);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(125, 44);
            this.loading.TabIndex = 11;
            this.loading.Text = "load Data";
            this.loading.UseVisualStyleBackColor = false;
            this.loading.Click += new System.EventHandler(this.loading_Click_1);
            // 
            // stepback
            // 
            this.stepback.BackColor = System.Drawing.Color.Teal;
            this.stepback.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stepback.Location = new System.Drawing.Point(59, 662);
            this.stepback.Name = "stepback";
            this.stepback.Size = new System.Drawing.Size(103, 45);
            this.stepback.TabIndex = 12;
            this.stepback.Text = "back";
            this.stepback.UseVisualStyleBackColor = false;
            this.stepback.Click += new System.EventHandler(this.stepback_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::user.Properties.Resources.shahid1;
            this.ClientSize = new System.Drawing.Size(1143, 749);
            this.Controls.Add(this.stepback);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Content;
        private System.Windows.Forms.RadioButton Users;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button loading;
        private System.Windows.Forms.Button stepback;
    }
}