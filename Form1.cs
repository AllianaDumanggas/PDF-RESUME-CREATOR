using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_RESUME_CREATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datatxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displaybttn_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Users\universal\source\repos\JSON FILE CREATOR\JSON FILE CREATOR\bin\Debug");
            string jsonString = read.ReadToEnd();
            datatxtbox.Text = jsonString;
        }
    }
}
