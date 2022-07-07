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

namespace PDF_RESUME_CREATOR
{
    public partial class datainformation : Form
    {
        public datainformation()
        {
            InitializeComponent();
        }

        private void datatxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        private void displaybttn_Click(object sender, EventArgs e)
        {
            Info mydata = new Info
            {
                CompleteName = "Marites Chizmoza",
                Age = 25,
                Birthday = "July 27 1995",
                Address = "123 Anywhere St, New YOrk City",
                Profile = "A responsible and committed individual who has the ability to function and be flexible in a team environment and has a strong leadership and time management skills.Strong analytical and creative skills with an eye for details.Passionate about working in a multi - cultural environment, as that involves creation, growth and experience in my field of profession.",
                Contact = new List<string>()
                {
                    "Phone Number: 09123456789",
                    "Email: MaritesChizmoza@gmail.com"
                },
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
            File.WriteAllText( @"myinfos.json", strresultsjson);

        }
        public class Info
        {
            public string CompleteName { get; set; }
            public byte Age { get; set; }
            public string Birthday { get; set; }
            public string Address { get; set; }
            public string Profile { get; set; }
            public List<string> Contact { get; set; }
            public List<string> Skills { get; set; }
            public List<string> Education { get; set; }
            public List<string> Experience { get; set; }
            public List<string> References { get; set; }

        }
         

        private void readjdonfilebttn_Click(object sender, EventArgs e)
        {
            var mydata = new Info
            {
                CompleteName = "Marites Chizmoza",
                Age = 25,
                Birthday = "July 27 1995",
                Address = "123 Anywhere St, New YOrk City",
                Profile = "A responsible and committed individual who has the ability to function and be flexible in a team environment and has a strong leadership and time management skills.Strong analytical and creative skills with an eye for details.Passionate about working in a multi - cultural environment, as that involves creation, growth and experience in my field of profession.",
                Contact = new List<string>()
                {
                    "Phone Number: 09123456789",
                    "Email: MaritesChizmoza@gmail.com"
                },
                Skills = new List<string>()
                {
                    ":Technology Skills",
                    ":Computer Skills",
                    ":Creative Design",
                    "Creative Problem-Solving Skills",
                    ":Multitasking",
                    ":Time Management",
                    ":Customer Service",
                    ":Efficiency",
                    ":Self-Discipline",
                    ":Perseverance",
                },
                Education = new List<string>()
                {
                    "Margareth Science School " ,
                    " STEM (2010-1012)",
                    "Harvard University",
                    "Bachelor of Science in Mass Communication(2012-2018)",
                },
                Experience = new List<string>()
                {
                    "Administrative Secretary",
                    "Grand Cali, San Francsico (2019-2022)",
                    "Data Manager ",
                    " Monaco Inc, Real California (2022-2025)",
                    "Executive Data Analyst " ,
                    "at Casanix, Toronto, Canada (2025-present)",
                },
                References = new List<string>()
                {
                    "Maria Chismis (Analyst Director at Issuan Company in Mexico",
                    "Juan Balita (Software Engineer at Techwix in New York)",
                    "Jose News (Resaturant and Hotel Manger at Micasa in Usa)",
                }
            };
            string strresultsjson = JsonConvert.SerializeObject(mydata, Formatting.Indented);
            datatxtbox.Text = strresultsjson;
        }

        private void pdfconvertbttn_Click(object sender, EventArgs e)
        {
             var mydata = new Info
            {
                CompleteName = "Marites Chizmoza",
                Age = 25,
                Birthday = "July 27 1995",
                Address = "123 Anywhere St, New YOrk City",
                Profile = "A responsible and committed individual who has the ability to function and be flexible in a team environment and has a strong leadership and time management skills.Strong analytical and creative skills with an eye for details.Passionate about working in a multi - cultural environment, as that involves creation, growth and experience in my field of profession.",
                Contact = new List<string>()
                {
                    "Phone Number: 09123456789",
                    "Email: MaritesChizmoza@gmail.com"
                },
                Skills = new List<string>()
                {
                    ":Technology Skills",
                    ":Computer Skills",
                    ":Creative Design",
                    "Creative Problem-Solving Skills",
                    ":Multitasking",
                    ":Time Management",
                    ":Customer Service",
                    ":Efficiency",
                    ":Self-Discipline",
                    ":Perseverance",
                },
                Education = new List<string>()
                {
                    "Margareth Science School " ,
                    " STEM (2010-1012)",
                    "Harvard University",
                    "Bachelor of Science in Mass Communication(2012-2018)",
                },
                Experience = new List<string>()
                {
                    "Administrative Secretary",
                    "Grand Cali, San Francsico (2019-2022)",
                    "Data Manager ",
                    " Monaco Inc, Real California (2022-2025)",
                    "Executive Data Analyst " ,
                    "at Casanix, Toronto, Canada (2025-present)",
                },
                References = new List<string>()
                {
                    "Maria Chismis (Analyst Director at Issuan Company in Mexico",
                    "Juan Balita (Software Engineer at Techwix in New York)",
                    "Jose News (Resaturant and Hotel Manger at Micasa in Usa)",
                }
            };
            var options = new JsonSerializerOptions { IncludeFields = true };
            var json = System.Text.Json.JsonSerializer.Serialize(mydata, options);
            var information = System.Text.Json.JsonSerializer.Deserialize<Info>(json, options);
            CustomMailMergeDataSource customDataSource = new CustomMailMergeDataSource(information);
            string templatePath = @"C:\Users\universal\Downloads\Resume template.docx";
            DocumentCore docu = DocumentCore.Load(templatePath);  
            string resultPath = "Chizmoza,Marites.pdf";
            docu.Save(resultPath); 

        }


    }
    
}
