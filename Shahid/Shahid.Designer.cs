
namespace user
{
    partial class Shahid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shahid));
            this.label1 = new System.Windows.Forms.Label();
            this.ShowContent = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Shahid";
            // 
            // ShowContent
            // 
            this.ShowContent.BackColor = System.Drawing.Color.Teal;
            this.ShowContent.Location = new System.Drawing.Point(322, 255);
            this.ShowContent.Name = "ShowContent";
            this.ShowContent.Size = new System.Drawing.Size(152, 57);
            this.ShowContent.TabIndex = 2;
            this.ShowContent.Text = "Let\'s Watch";
            this.ShowContent.UseVisualStyleBackColor = false;
            this.ShowContent.Click += new System.EventHandler(this.ShowContent_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Teal;
            this.InfoButton.Location = new System.Drawing.Point(322, 136);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(152, 57);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Display Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Teal;
            this.Exitbutton.Location = new System.Drawing.Point(43, 378);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(93, 36);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Shahid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::user.Properties.Resources.shahid1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ShowContent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shahid";
            this.Text = "Shahid";
            this.Load += new System.EventHandler(this.Shahid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowContent;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button Exitbutton;
    }
}