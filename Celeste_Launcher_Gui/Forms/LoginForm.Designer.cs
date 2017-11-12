﻿namespace Celeste_Launcher_Gui.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxButtonCustom1 = new Celeste_AOEO_Controls.PictureBoxButtonCustom();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.linkLbl_ForgotPwd = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSmall2 = new Celeste_AOEO_Controls.CustomBtn();
            this.cb_RememberMe = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonCustom1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.DialogBoxSmall;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBoxButtonCustom1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 233);
            this.panel2.TabIndex = 59;
            // 
            // pictureBoxButtonCustom1
            // 
            this.pictureBoxButtonCustom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxButtonCustom1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButtonCustom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonCustom1.HoverImage = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Hover;
            this.pictureBoxButtonCustom1.Image = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Normal;
            this.pictureBoxButtonCustom1.Location = new System.Drawing.Point(571, 14);
            this.pictureBoxButtonCustom1.Name = "pictureBoxButtonCustom1";
            this.pictureBoxButtonCustom1.NormalImage = global::Celeste_Launcher_Gui.Properties.Resources.XButton_Normal;
            this.pictureBoxButtonCustom1.ShowToolTip = true;
            this.pictureBoxButtonCustom1.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxButtonCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxButtonCustom1.TabIndex = 59;
            this.pictureBoxButtonCustom1.TabStop = false;
            this.pictureBoxButtonCustom1.ToolTipText = "Close";
            this.pictureBoxButtonCustom1.Click += new System.EventHandler(this.PictureBoxButtonCustom1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel5.Location = new System.Drawing.Point(23, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 161);
            this.panel5.TabIndex = 58;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Mail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Mail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLbl_ForgotPwd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 161);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(149, 41);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Password.MaxLength = 32;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(418, 26);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Mail
            // 
            this.tb_Mail.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Mail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mail.Location = new System.Drawing.Point(149, 5);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Mail.MaxLength = 128;
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(418, 26);
            this.tb_Mail.TabIndex = 2;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Mail.Location = new System.Drawing.Point(3, 0);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(138, 36);
            this.lbl_Mail.TabIndex = 18;
            this.lbl_Mail.Text = "Email:";
            this.lbl_Mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.BackColor = System.Drawing.Color.Transparent;
            this.lb_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Password.Location = new System.Drawing.Point(3, 36);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(138, 36);
            this.lb_Password.TabIndex = 19;
            this.lb_Password.Text = "Password:";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLbl_ForgotPwd
            // 
            this.linkLbl_ForgotPwd.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.linkLbl_ForgotPwd.AutoSize = true;
            this.linkLbl_ForgotPwd.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_ForgotPwd.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLbl_ForgotPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLbl_ForgotPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLbl_ForgotPwd.LinkColor = System.Drawing.Color.DarkBlue;
            this.linkLbl_ForgotPwd.Location = new System.Drawing.Point(3, 72);
            this.linkLbl_ForgotPwd.Name = "linkLbl_ForgotPwd";
            this.linkLbl_ForgotPwd.Size = new System.Drawing.Size(138, 89);
            this.linkLbl_ForgotPwd.TabIndex = 4;
            this.linkLbl_ForgotPwd.TabStop = true;
            this.linkLbl_ForgotPwd.Text = "Forgot Password?";
            this.linkLbl_ForgotPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLbl_ForgotPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl_ForgotPwd_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cb_RememberMe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(149, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 89);
            this.panel1.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSmall2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 89);
            this.panel3.TabIndex = 43;
            // 
            // btnSmall2
            // 
            this.btnSmall2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmall2.BackgroundImage")));
            this.btnSmall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmall2.BtnText = "LOGIN";
            this.btnSmall2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSmall2.Location = new System.Drawing.Point(0, 0);
            this.btnSmall2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSmall2.Name = "btnSmall2";
            this.btnSmall2.Size = new System.Drawing.Size(180, 89);
            this.btnSmall2.TabIndex = 1;
            this.btnSmall2.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // cb_RememberMe
            // 
            this.cb_RememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cb_RememberMe.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_RememberMe.Location = new System.Drawing.Point(0, 0);
            this.cb_RememberMe.Margin = new System.Windows.Forms.Padding(5);
            this.cb_RememberMe.Name = "cb_RememberMe";
            this.cb_RememberMe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_RememberMe.Size = new System.Drawing.Size(217, 89);
            this.cb_RememberMe.TabIndex = 5;
            this.cb_RememberMe.Text = "Remember Me";
            this.cb_RememberMe.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImage = global::Celeste_Launcher_Gui.Properties.Resources.BackgroundTexture;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updaterToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 52);
            // 
            // updaterToolStripMenuItem
            // 
            this.updaterToolStripMenuItem.Name = "updaterToolStripMenuItem";
            this.updaterToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.updaterToolStripMenuItem.Text = "Updater";
            this.updaterToolStripMenuItem.Click += new System.EventHandler(this.UpdaterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 24);
            this.toolStripMenuItem1.Text = "Game Scan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 233);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celeste Fan Project";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonCustom1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_Password;
        private Celeste_AOEO_Controls.CustomBtn btnSmall2;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.CheckBox cb_RememberMe;
        private System.Windows.Forms.LinkLabel linkLbl_ForgotPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Celeste_AOEO_Controls.PictureBoxButtonCustom pictureBoxButtonCustom1;
        private System.Windows.Forms.Panel panel3;
    }
}