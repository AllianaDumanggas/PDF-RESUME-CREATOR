﻿
namespace PDF_RESUME_CREATOR
{
    partial class Form1
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
            this.displaybttn = new System.Windows.Forms.Button();
            this.datatxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displaybttn
            // 
            this.displaybttn.Location = new System.Drawing.Point(69, 473);
            this.displaybttn.Name = "displaybttn";
            this.displaybttn.Size = new System.Drawing.Size(150, 35);
            this.displaybttn.TabIndex = 0;
            this.displaybttn.Text = "Display Data ";
            this.displaybttn.UseVisualStyleBackColor = true;
            this.displaybttn.Click += new System.EventHandler(this.displaybttn_Click);
            // 
            // datatxtbox
            // 
            this.datatxtbox.Location = new System.Drawing.Point(12, 23);
            this.datatxtbox.Multiline = true;
            this.datatxtbox.Name = "datatxtbox";
            this.datatxtbox.Size = new System.Drawing.Size(287, 444);
            this.datatxtbox.TabIndex = 1;
            this.datatxtbox.TextChanged += new System.EventHandler(this.datatxtbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 530);
            this.Controls.Add(this.datatxtbox);
            this.Controls.Add(this.displaybttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displaybttn;
        private System.Windows.Forms.TextBox datatxtbox;
    }
}
