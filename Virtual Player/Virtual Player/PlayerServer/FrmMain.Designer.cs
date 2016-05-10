namespace PlayerServer
{
    partial class FrmMain
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
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.tstbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.stbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbStatus});
            this.stbMain.Location = new System.Drawing.Point(0, 243);
            this.stbMain.Name = "stbMain";
            this.stbMain.Size = new System.Drawing.Size(409, 22);
            this.stbMain.TabIndex = 0;
            this.stbMain.Text = "statusStrip1";
            // 
            // tstbStatus
            // 
            this.tstbStatus.AutoSize = false;
            this.tstbStatus.Name = "tstbStatus";
            this.tstbStatus.Size = new System.Drawing.Size(394, 17);
            this.tstbStatus.Spring = true;
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.Location = new System.Drawing.Point(12, 12);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(385, 121);
            this.lstCommands.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 265);
            this.Controls.Add(this.lstCommands);
            this.Controls.Add(this.stbMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Server";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbMain;
        private System.Windows.Forms.ToolStripStatusLabel tstbStatus;
        private System.Windows.Forms.ListBox lstCommands;
    }
}

