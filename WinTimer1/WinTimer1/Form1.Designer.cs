﻿namespace WinTimer1
{
    partial class WinTimer1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControlTimer1 = new UserControlTimer();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(58, 62);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(80, 43);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // WinTimer1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userControlTimer1);
            Name = "WinTimer1";
            Text = "WinTimer1";
            Load += WinTimer1_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
    }
}