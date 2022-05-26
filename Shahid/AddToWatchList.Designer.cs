
namespace user
{
    partial class AddToWatchList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToWatchList));
            this.CreateNew = new System.Windows.Forms.Button();
            this.Addto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stepback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNew
            // 
            this.CreateNew.BackColor = System.Drawing.Color.Teal;
            this.CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateNew.Location = new System.Drawing.Point(83, 125);
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(376, 42);
            this.CreateNew.TabIndex = 0;
            this.CreateNew.Text = "Create New Watch List";
            this.CreateNew.UseVisualStyleBackColor = false;
            this.CreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // Addto
            // 
            this.Addto.BackColor = System.Drawing.Color.Teal;
            this.Addto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Addto.Location = new System.Drawing.Point(56, 228);
            this.Addto.Name = "Addto";
            this.Addto.Size = new System.Drawing.Size(148, 110);
            this.Addto.TabIndex = 1;
            this.Addto.Text = "Add To Existing Watch List";
            this.Addto.UseVisualStyleBackColor = false;
            this.Addto.Click += new System.EventHandler(this.Addto_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(380, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 34);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter the new list name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Stepback
            // 
            this.Stepback.BackColor = System.Drawing.Color.Teal;
            this.Stepback.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Stepback.Location = new System.Drawing.Point(395, 358);
            this.Stepback.Name = "Stepback";
            this.Stepback.Size = new System.Drawing.Size(92, 34);
            this.Stepback.TabIndex = 5;
            this.Stepback.Text = "back";
            this.Stepback.UseVisualStyleBackColor = false;
            this.Stepback.Click += new System.EventHandler(this.Stepback_Click);
            // 
            // AddToWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::user.Properties.Resources.shahid1;
            this.ClientSize = new System.Drawing.Size(611, 467);
            this.Controls.Add(this.Stepback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Addto);
            this.Controls.Add(this.CreateNew);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToWatchList";
            this.Text = "AddToWatchList";
            this.Load += new System.EventHandler(this.AddToWatchList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNew;
        private System.Windows.Forms.Button Addto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stepback;
    }
}