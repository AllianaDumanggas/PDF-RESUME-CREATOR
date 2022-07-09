
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
            this.datatxtbox = new System.Windows.Forms.TextBox();
            this.readjdonfilebttn = new System.Windows.Forms.Button();
            this.pdfconvertbttn = new System.Windows.Forms.Button();
            this.closebttn = new System.Windows.Forms.Button();
            this.CreateJsonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datatxtbox
            // 
            this.datatxtbox.BackColor = System.Drawing.Color.White;
            this.datatxtbox.Location = new System.Drawing.Point(12, 12);
            this.datatxtbox.Multiline = true;
            this.datatxtbox.Name = "datatxtbox";
            this.datatxtbox.ReadOnly = true;
            this.datatxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datatxtbox.Size = new System.Drawing.Size(539, 353);
            this.datatxtbox.TabIndex = 1;
            this.datatxtbox.TextChanged += new System.EventHandler(this.datatxtbox_TextChanged);
            // 
            // readjdonfilebttn
            // 
            this.readjdonfilebttn.BackColor = System.Drawing.Color.AliceBlue;
            this.readjdonfilebttn.Location = new System.Drawing.Point(183, 384);
            this.readjdonfilebttn.Name = "readjdonfilebttn";
            this.readjdonfilebttn.Size = new System.Drawing.Size(93, 48);
            this.readjdonfilebttn.TabIndex = 2;
            this.readjdonfilebttn.Text = "Read Json File";
            this.readjdonfilebttn.UseVisualStyleBackColor = false;
            this.readjdonfilebttn.Click += new System.EventHandler(this.readjdonfilebttn_Click);
            // 
            // pdfconvertbttn
            // 
            this.pdfconvertbttn.BackColor = System.Drawing.Color.AliceBlue;
            this.pdfconvertbttn.Location = new System.Drawing.Point(282, 384);
            this.pdfconvertbttn.Name = "pdfconvertbttn";
            this.pdfconvertbttn.Size = new System.Drawing.Size(93, 48);
            this.pdfconvertbttn.TabIndex = 3;
            this.pdfconvertbttn.Text = "Convert to PDF";
            this.pdfconvertbttn.UseVisualStyleBackColor = false;
            this.pdfconvertbttn.Click += new System.EventHandler(this.pdfconvertbttn_Click);
            // 
            // closebttn
            // 
            this.closebttn.BackColor = System.Drawing.Color.AliceBlue;
            this.closebttn.Location = new System.Drawing.Point(381, 384);
            this.closebttn.Name = "closebttn";
            this.closebttn.Size = new System.Drawing.Size(93, 48);
            this.closebttn.TabIndex = 4;
            this.closebttn.Text = "EXIT";
            this.closebttn.UseVisualStyleBackColor = false;
            this.closebttn.Click += new System.EventHandler(this.closebttn_Click);
            // 
            // CreateJsonFile
            // 
            this.CreateJsonFile.BackColor = System.Drawing.Color.AliceBlue;
            this.CreateJsonFile.Location = new System.Drawing.Point(84, 384);
            this.CreateJsonFile.Name = "CreateJsonFile";
            this.CreateJsonFile.Size = new System.Drawing.Size(93, 48);
            this.CreateJsonFile.TabIndex = 5;
            this.CreateJsonFile.Text = "Create My JSON file";
            this.CreateJsonFile.UseVisualStyleBackColor = false;
            this.CreateJsonFile.Click += new System.EventHandler(this.CreateJsonFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(563, 444);
            this.Controls.Add(this.CreateJsonFile);
            this.Controls.Add(this.closebttn);
            this.Controls.Add(this.pdfconvertbttn);
            this.Controls.Add(this.readjdonfilebttn);
            this.Controls.Add(this.datatxtbox);
            this.Name = "Form1";
            this.Text = "PDF RESUME CREATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox datatxtbox;
        private System.Windows.Forms.Button readjdonfilebttn;
        private System.Windows.Forms.Button pdfconvertbttn;
        private System.Windows.Forms.Button closebttn;
        private System.Windows.Forms.Button CreateJsonFile;
    }
}

