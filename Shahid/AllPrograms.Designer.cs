
namespace user
{
    partial class AllPrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPrograms));
            this.Genrate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.stepback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Genrate
            // 
            this.Genrate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Genrate.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genrate.Location = new System.Drawing.Point(535, 37);
            this.Genrate.Name = "Genrate";
            this.Genrate.Size = new System.Drawing.Size(426, 60);
            this.Genrate.TabIndex = 0;
            this.Genrate.Text = "Generate Programs";
            this.Genrate.UseVisualStyleBackColor = false;
            this.Genrate.Click += new System.EventHandler(this.Genrate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 128);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1410, 613);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // stepback
            // 
            this.stepback.BackColor = System.Drawing.SystemColors.HotTrack;
            this.stepback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepback.Location = new System.Drawing.Point(28, 73);
            this.stepback.Name = "stepback";
            this.stepback.Size = new System.Drawing.Size(88, 34);
            this.stepback.TabIndex = 2;
            this.stepback.Text = "Back";
            this.stepback.UseVisualStyleBackColor = false;
            this.stepback.Click += new System.EventHandler(this.stepback_Click);
            // 
            // AllPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::user.Properties.Resources.shahid1;
            this.ClientSize = new System.Drawing.Size(1477, 753);
            this.Controls.Add(this.stepback);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Genrate);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllPrograms";
            this.Text = "AllPrograms";
            this.Load += new System.EventHandler(this.AllPrograms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Genrate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button stepback;
    }
}