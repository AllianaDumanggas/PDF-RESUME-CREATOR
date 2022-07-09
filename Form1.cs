using Aspose.Words.Reporting;
using GroupDocs.Assembly;
using Newtonsoft.Json;
using OpenXmlPowerTools;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using JsonSerializer = System.Text.Json.JsonSerializer;

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

        private void information()
        {
            Info mydata = new Info
            {
                LastName = "Dumanggas",
                FirstName = "Alliana",
                Age = 25,
                Birthday = "July 27 1995",
                Address = "Brgy.Danlagan Padre Burgos Quezon",
                ContactNumber = "09123456789",
                Email = "Email: MaritesChizmoza@gmail.com",

                Skills = new List<string>()
                {
                    "Technology Skills",
                    "Computer Skills",
                    "Creative Design",
                    "Creative Problem-Solving Skills",
                    "Multitasking",
                    "Time Management",
                    "Customer Service",
                    "Efficiency",
                    "Self-Discipline",
                    "Perseverance",
                },
                Education = new List<string>()
                {
                    "Margareth Science School: STEM (2010-1012)",
                    "Harvard University: Bachelor of Science in Mass Communication(2012-2018)",
                },
                Experience = new List<string>()
                {
                    "Administrative Secretary at Grand Cali, San Francsico (2019-2022)",
                    "Data Manager at Monaco Inc, Real California (2022-2025)",
                    "Executive Data Analyst at Casanix, Toronto, Canada (2025-present)",
                },
                References = new List<string>()
                {
                    "Maria Chismis (Analyst Director at Issuan Company in Mexico",
                    "Juan Balita (Software Engineer at Techwix in New York)",
                    "Jose News (Resaturant and Hotel Manger at Micasa in Usa)",
                }
            };
        }
         
        public class Info
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public byte Age { get; set; }
            public string Birthday { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
            public List<string> Skills { get; set; }
            public List<string> Education { get; set; }
            public List<string> Experience { get; set; }
            public List<string> References { get; set; }

        }
         

        private void readjdonfilebttn_Click(object sender, EventArgs e)
        {
            Info mydata = new Info
            {
                LastName = "Dumanggas",
                FirstName = "Alliana",
                Age = 25,
                Birthday = "July 27 1995",
                Address = "Brgy.Danlagan Padre Burgos Quezon",
                ContactNumber = "09123456789",
                Email = "Email: MaritesChizmoza@gmail.com",

                Skills = new List<string>()
                {
                    "Technology Skills",
                    "Computer Skills",
                    "Creative Design",
                    "Creative Problem-Solving Skills",
                    "Multitasking",
                    "Time Management",
                    "Customer Service",
                    "Efficiency",
                    "Self-Discipline",
                    "Perseverance",
                },
                Education = new List<string>()
                {
                    "Margareth Science School: STEM (2010-1012)",
                    "Harvard University: Bachelor of Science in Mass Communication(2012-2018)",
                },
                Experience = new List<string>()
                {
                    "Administrative Secretary at Grand Cali, San Francsico (2019-2022)",
                    "Data Manager at Monaco Inc, Real California (2022-2025)",
                    "Executive Data Analyst at Casanix, Toronto, Canada (2025-present)",
                },
                References = new List<string>()
                {
                    "Maria Chismis (Analyst Director at Issuan Company in Mexico",
                    "Juan Balita (Software Engineer at Techwix in New York)",
                    "Jose News (Resaturant and Hotel Manger at Micasa in Usa)",
                }
            };
            string strresultsjson = JsonConvert.SerializeObject(mydata);
            datatxtbox.Text = strresultsjson;
        }

        private void pdfconvertbttn_Click(object sender, EventArgs e)
        {
             
        }
        private void Generate()
        {
             

        }
    }
    
}
