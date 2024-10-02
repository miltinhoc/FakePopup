namespace FakePopup
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.PanelSeverity = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.BtnAction = new System.Windows.Forms.PictureBox();
            this.PictureFooter = new System.Windows.Forms.PictureBox();
            this.PictureInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSeverity
            // 
            this.PanelSeverity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.PanelSeverity.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSeverity.Location = new System.Drawing.Point(0, 0);
            this.PanelSeverity.Name = "PanelSeverity";
            this.PanelSeverity.Size = new System.Drawing.Size(13, 224);
            this.PanelSeverity.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::FakePopup.Properties.Resources.x_normal;
            this.BtnClose.Location = new System.Drawing.Point(492, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(14, 14);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.ButtonClick);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // BtnAction
            // 
            this.BtnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAction.Image = global::FakePopup.Properties.Resources.btn_normal;
            this.BtnAction.Location = new System.Drawing.Point(408, 173);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(100, 40);
            this.BtnAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnAction.TabIndex = 3;
            this.BtnAction.TabStop = false;
            this.BtnAction.Click += new System.EventHandler(this.ButtonClick);
            this.BtnAction.MouseEnter += new System.EventHandler(this.BtnAction_MouseEnter);
            this.BtnAction.MouseLeave += new System.EventHandler(this.BtnAction_MouseLeave);
            // 
            // PictureFooter
            // 
            this.PictureFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PictureFooter.Image = ((System.Drawing.Image)(resources.GetObject("PictureFooter.Image")));
            this.PictureFooter.Location = new System.Drawing.Point(13, 160);
            this.PictureFooter.Name = "PictureFooter";
            this.PictureFooter.Size = new System.Drawing.Size(507, 64);
            this.PictureFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureFooter.TabIndex = 2;
            this.PictureFooter.TabStop = false;
            // 
            // PictureInfo
            // 
            this.PictureInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureInfo.Image = global::FakePopup.Properties.Resources.auto_updates;
            this.PictureInfo.Location = new System.Drawing.Point(13, 0);
            this.PictureInfo.Name = "PictureInfo";
            this.PictureInfo.Size = new System.Drawing.Size(507, 154);
            this.PictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureInfo.TabIndex = 1;
            this.PictureInfo.TabStop = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 224);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAction);
            this.Controls.Add(this.PictureFooter);
            this.Controls.Add(this.PictureInfo);
            this.Controls.Add(this.PanelSeverity);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSeverity;
        private System.Windows.Forms.PictureBox PictureInfo;
        private System.Windows.Forms.PictureBox PictureFooter;
        private System.Windows.Forms.PictureBox BtnAction;
        private System.Windows.Forms.PictureBox BtnClose;
    }
}

