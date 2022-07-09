using Aspose.Words;
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
using Word = Microsoft.Office.Interop.Word;

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
         
        public class Info
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public byte Age { get; set; }
            public string Birthday { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
            public string Skill01 { get; set; }
            public string Skill02 { get; set; }
            public string Skill03 { get; set; }
            public string Skill04 { get; set; }
            public string Skill05 { get; set; }
            public string Skill06 { get; set; }
            public string Skill07 { get; set; }
            public string Experiencee { get; set; }
            public string Experienceee { get; set; } 
            public string SeniorHigh { get; set; }
            public string College { get; set; }
            public string Referencee { get; set; }
            public string Referenceee { get; set; } 
        }
        private void Converttojson()
        {
            Info mydata = new Info
            {
                LastName = "Dumanggas",
                FirstName = "Alliana",
                Age = 19,
                Birthday = "July 11 2003 ",
                Address = "Brgy.Danlagan Padre Burgos Quezon",
                ContactNumber = "09123456789",
                Email = "MaritesChizmoza@gmail.com",
                Skill01 = "Creative Design",
                Skill02 = "Communication Skills",
                Skill03 = "Multitasking",
                Skill04 = "Time Management",
                Skill05 = "Efficiency",
                Skill06 = "Self-Discipline",
                Skill07 = "Perseverance",
                Experiencee= "Data Analyst at XXX Company",
                Experienceee = "Programmer at YYY Company",
                SeniorHigh = "St.Martin Montessori School Inc.",
                College = "Polytechnic University of the Philippines",
                Referencee = "xxxxx xxxxx (Restaurant Manager)",
                Referenceee = "yyyy yyyy (Technology Alignment Engineer)",


            };
            string strresultsjson = JsonConvert.SerializeObject(mydata, Formatting.Indented);
            File.WriteAllText(@"Data.json", strresultsjson);      
        }

        private void readjdonfilebttn_Click(object sender, EventArgs e)
        {
            Info mydata = new Info
            {
                LastName = "Dumanggas",
                FirstName = "Alliana",
                Age = 19,
                Birthday = "July 11 2003 ",
                Address = "Brgy.Danlagan Padre Burgos Quezon",
                ContactNumber = "09123456789",
                Email = " MaritesChizmoza@gmail.com",
                Skill01 = "Creative Design",
                Skill02 = "Communication Skills",
                Skill03 = "Multitasking",
                Skill04 = "Time Management",
                Skill05 = "Efficiency",
                Skill06 = "Self-Discipline",
                Skill07 = "Perseverance",
                Experiencee = "Data Analyst at XXX Company",
                Experienceee = "Programmer at YYY Company",
                SeniorHigh ="St.Martin Montessori School Inc.",
                College="Polytechnic University of the Philippines",
                Referencee="xxxxx xxxxx (Restaurant Manager)",
                Referenceee ="yyyy yyyy (Technology Alignment Engineer)",


            };
            string strresultsjson = JsonConvert.SerializeObject(mydata, Formatting.Indented);  
            datatxtbox.Text = strresultsjson;
        }

        private void pdfconvertbttn_Click(object sender, EventArgs e)
        {
            string file = (@"C:\Users\universal\source\repos\PDF RESUME CREATOR\PDF RESUME CREATOR\bin\Debug\Data.json");
            string data = File.ReadAllText(file);
            Info info = JsonSerializer.Deserialize<Info>(data);

            string Lastname = info.LastName;
            string Firstname = info.FirstName;
            byte Age = info.Age;
            string Birthday = info.Birthday;
            string Address = info.Address;
            string ContactNumber = info.ContactNumber;
            string Email = info.Email;
            string Skills1 = info.Skill01;
            string Skills2 = info.Skill02;
            string Skills3 = info.Skill03;
            string Skills4 = info.Skill04;
            string Skills5 = info.Skill05;
            string Skills6 = info.Skill06;
            string Skills7 = info.Skill07;
            string Experience = info.Experiencee;
            string Experiences = info.Experienceee;
            string SeniorHigh = info.SeniorHigh;
            string College = info.College;
            string Reference = info.Referencee;
            string References = info.Referenceee;

            var application = new Microsoft.Office.Interop.Word.Application();
            var document = new Microsoft.Office.Interop.Word.Document();
            // adding the template
            document = application.Documents.Add(Template: @"C:\Users\universal\Documents\yeahtemplate.docx");
            application.Visible = true;

            foreach (Microsoft.Office.Interop.Word.Field field in document.Fields)
            {
                if (field.Code.Text.Contains("FIRST NAME"))
                {
                    field.Select();
                    application.Selection.TypeText(Firstname);
                }
                else if  (field.Code.Text.Contains("LAST NAME"))
                {
                        field.Select();
                        application.Selection.TypeText(Lastname );
                }
                else if (field.Code.Text.Contains("Age"))
                {
                    field.Select();
                    application.Selection.TypeText(Age.ToString());
                }
                else if (field.Code.Text.Contains("Birthday"))
                {
                    field.Select();
                    application.Selection.TypeText(Birthday);
                }
                else if (field.Code.Text.Contains("Address"))
                {
                    field.Select();
                    application.Selection.TypeText(Address);
                }
                else if (field.Code.Text.Contains("Contact Number"))
                {
                    field.Select();
                    application.Selection.TypeText(ContactNumber );
                }
                else if (field.Code.Text.Contains("Email"))
                {
                    field.Select();
                    application.Selection.TypeText(Email);
                }
                else if (field.Code.Text.Contains("1"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills1);
                }
                else if (field.Code.Text.Contains("2"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills2);
                }
                else if (field.Code.Text.Contains("3"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills3);
                }
                else if (field.Code.Text.Contains("4"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills4);
                }
                else if (field.Code.Text.Contains("5"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills5);
                }
                else if (field.Code.Text.Contains("6"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills6);
                }
                else if (field.Code.Text.Contains("7"))
                {
                    field.Select();
                    application.Selection.TypeText(Skills7);
                }
                else if (field.Code.Text.Contains("hello"))
                {
                    field.Select();
                    application.Selection.TypeText(Experience);
                }
                else if (field.Code.Text.Contains("excited"))
                {
                    field.Select();
                    application.Selection.TypeText(Experiences);
                }
                else if (field.Code.Text.Contains("Senior High"))
                {
                    field.Select();
                    application.Selection.TypeText(SeniorHigh);
                }
                else if (field.Code.Text.Contains("College"))
                {
                    field.Select();
                    application.Selection.TypeText(College);
                }
                else if (field.Code.Text.Contains("great"))
                {
                    field.Select();
                    application.Selection.TypeText(Reference);
                }
                else if (field.Code.Text.Contains("astig"))
                {
                    field.Select();
                    application.Selection.TypeText(References);
                }
            }
            document.SaveAs(FileName: @"C:\Users\universal\Downloads\DUMANGGAS_ALLIANA.docx"); 
            var doc = new Document(@"C:\Users\universal\Downloads\DUMANGGAS_ALLIANA.docx");
            doc.Save("DUMANGGAS_ALLIANA.pdf");
        }

        private void closebttn_Click(object sender, EventArgs e)
        { 
          this.Close();
        }

        private void CreateJsonFile_Click(object sender, EventArgs e)
        {
            Converttojson();
        }
    }
    
}
