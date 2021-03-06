﻿namespace ShinyCountPlus
{
    partial class AccentColorForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pinkBtn = new System.Windows.Forms.Button();
            this.tealBtn = new System.Windows.Forms.Button();
            this.salmonBtn = new System.Windows.Forms.Button();
            this.purpleBtn = new System.Windows.Forms.Button();
            this.exitIcon = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 32);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pinkBtn
            // 
            this.pinkBtn.BackgroundImage = global::ShinyCountPlus.Properties.Resources.pinkAccent;
            this.pinkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinkBtn.FlatAppearance.BorderSize = 0;
            this.pinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinkBtn.Location = new System.Drawing.Point(268, 40);
            this.pinkBtn.Name = "pinkBtn";
            this.pinkBtn.Size = new System.Drawing.Size(60, 60);
            this.pinkBtn.TabIndex = 10;
            this.pinkBtn.TabStop = false;
            this.pinkBtn.UseVisualStyleBackColor = true;
            this.pinkBtn.Click += new System.EventHandler(this.pinkBtn_Click);
            // 
            // tealBtn
            // 
            this.tealBtn.BackgroundImage = global::ShinyCountPlus.Properties.Resources.tealAccent;
            this.tealBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tealBtn.FlatAppearance.BorderSize = 0;
            this.tealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tealBtn.Location = new System.Drawing.Point(187, 40);
            this.tealBtn.Name = "tealBtn";
            this.tealBtn.Size = new System.Drawing.Size(60, 60);
            this.tealBtn.TabIndex = 9;
            this.tealBtn.TabStop = false;
            this.tealBtn.UseVisualStyleBackColor = true;
            this.tealBtn.Click += new System.EventHandler(this.tealBtn_Click);
            // 
            // salmonBtn
            // 
            this.salmonBtn.BackgroundImage = global::ShinyCountPlus.Properties.Resources.salmonAccent2;
            this.salmonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salmonBtn.FlatAppearance.BorderSize = 0;
            this.salmonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salmonBtn.Location = new System.Drawing.Point(106, 40);
            this.salmonBtn.Name = "salmonBtn";
            this.salmonBtn.Size = new System.Drawing.Size(60, 60);
            this.salmonBtn.TabIndex = 7;
            this.salmonBtn.TabStop = false;
            this.salmonBtn.UseVisualStyleBackColor = true;
            this.salmonBtn.Click += new System.EventHandler(this.salmonBtn_Click);
            // 
            // purpleBtn
            // 
            this.purpleBtn.BackgroundImage = global::ShinyCountPlus.Properties.Resources.purpleAccent1;
            this.purpleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.purpleBtn.FlatAppearance.BorderSize = 0;
            this.purpleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.purpleBtn.Location = new System.Drawing.Point(25, 40);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(60, 60);
            this.purpleBtn.TabIndex = 6;
            this.purpleBtn.TabStop = false;
            this.purpleBtn.UseVisualStyleBackColor = true;
            this.purpleBtn.Click += new System.EventHandler(this.purpleBtn_Click);
            // 
            // exitIcon
            // 
            this.exitIcon.BackgroundImage = global::ShinyCountPlus.Properties.Resources.icons8_delete_32px;
            this.exitIcon.Location = new System.Drawing.Point(323, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(32, 32);
            this.exitIcon.TabIndex = 5;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // AccentColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(355, 113);
            this.ControlBox = false;
            this.Controls.Add(this.pinkBtn);
            this.Controls.Add(this.tealBtn);
            this.Controls.Add(this.salmonBtn);
            this.Controls.Add(this.purpleBtn);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Fredoka One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccentColorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel exitIcon;
        private System.Windows.Forms.Button purpleBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button salmonBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tealBtn;
        private System.Windows.Forms.Button pinkBtn;
    }
}