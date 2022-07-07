
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
            this.jsonbttn = new System.Windows.Forms.Button();
            this.datatxtbox = new System.Windows.Forms.TextBox();
            this.readjdonfilebttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonbttn
            // 
            this.jsonbttn.Location = new System.Drawing.Point(28, 462);
            this.jsonbttn.Name = "jsonbttn";
            this.jsonbttn.Size = new System.Drawing.Size(150, 35);
            this.jsonbttn.TabIndex = 0;
            this.jsonbttn.Text = "Create Json File";
            this.jsonbttn.UseVisualStyleBackColor = true;
            this.jsonbttn.Click += new System.EventHandler(this.displaybttn_Click);
            // 
            // datatxtbox
            // 
            this.datatxtbox.Location = new System.Drawing.Point(12, 12);
            this.datatxtbox.Multiline = true;
            this.datatxtbox.Name = "datatxtbox";
            this.datatxtbox.Size = new System.Drawing.Size(391, 444);
            this.datatxtbox.TabIndex = 1;
            this.datatxtbox.TextChanged += new System.EventHandler(this.datatxtbox_TextChanged);
            // 
            // readjdonfilebttn
            // 
            this.readjdonfilebttn.Location = new System.Drawing.Point(206, 463);
            this.readjdonfilebttn.Name = "readjdonfilebttn";
            this.readjdonfilebttn.Size = new System.Drawing.Size(132, 34);
            this.readjdonfilebttn.TabIndex = 2;
            this.readjdonfilebttn.Text = "Read Json File";
            this.readjdonfilebttn.UseVisualStyleBackColor = true;
            this.readjdonfilebttn.Click += new System.EventHandler(this.readjdonfilebttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 530);
            this.Controls.Add(this.readjdonfilebttn);
            this.Controls.Add(this.datatxtbox);
            this.Controls.Add(this.jsonbttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jsonbttn;
        private System.Windows.Forms.TextBox datatxtbox;
        private System.Windows.Forms.Button readjdonfilebttn;
    }
}

