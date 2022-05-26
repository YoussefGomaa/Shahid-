
namespace user
{
    partial class CheckWatchList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckWatchList));
            this.loadwatchlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBListID = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.stepback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadwatchlist
            // 
            this.loadwatchlist.BackColor = System.Drawing.Color.Teal;
            this.loadwatchlist.Location = new System.Drawing.Point(965, 21);
            this.loadwatchlist.Name = "loadwatchlist";
            this.loadwatchlist.Size = new System.Drawing.Size(126, 49);
            this.loadwatchlist.TabIndex = 0;
            this.loadwatchlist.Text = "Load Watchlist";
            this.loadwatchlist.UseVisualStyleBackColor = false;
            this.loadwatchlist.Click += new System.EventHandler(this.loadwatchlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(550, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "WatchList ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBListID
            // 
            this.CBListID.FormattingEnabled = true;
            this.CBListID.Location = new System.Drawing.Point(737, 34);
            this.CBListID.Name = "CBListID";
            this.CBListID.Size = new System.Drawing.Size(121, 24);
            this.CBListID.TabIndex = 2;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(51, 109);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1192, 406);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // stepback
            // 
            this.stepback.BackColor = System.Drawing.Color.Teal;
            this.stepback.Location = new System.Drawing.Point(84, 37);
            this.stepback.Name = "stepback";
            this.stepback.Size = new System.Drawing.Size(92, 34);
            this.stepback.TabIndex = 4;
            this.stepback.Text = "back";
            this.stepback.UseVisualStyleBackColor = false;
            this.stepback.Click += new System.EventHandler(this.stepback_Click);
            // 
            // CheckWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::user.Properties.Resources.shahid1;
            this.ClientSize = new System.Drawing.Size(1298, 570);
            this.Controls.Add(this.stepback);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.CBListID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadwatchlist);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckWatchList";
            this.Text = "CheckWatchList";
            this.Load += new System.EventHandler(this.CheckWatchList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadwatchlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBListID;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button stepback;
    }
}