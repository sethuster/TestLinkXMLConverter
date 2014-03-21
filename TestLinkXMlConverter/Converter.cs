using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TestLinkXMlConverter
{
    public class Converter
    {
        private string filepath;

        public String FilePath{get { return filepath; }}
        
        private StringBuilder CSVText;
        private string seperator = ",";

        public Converter()
        {
           
        }

        public void ReadXML()
        {
            XmlTextReader reader = new XmlTextReader(filepath);
            CSVText = new StringBuilder();
            String text = "";
            

            while (reader.Read())
            {
                if (reader.Name == "testsuite")
                {
                    text += "\"" + RemoveCrap(reader.GetAttribute("name")) + "\"";
                    CSVText.Append(text + "\n");
                }

                if (reader.Name == "testcase")
                {
                    text = "\"" + RemoveCrap(reader.GetAttribute("internalid")) + "\"";
                    text += seperator + "\"" + RemoveCrap(reader.GetAttribute("name")) + "\"" + seperator;
                    //this damn testlink XML is all weird 
                    CSVText.Append(text);

                }
                
                
            }
        }

        private void writeFile(string Filename)
        {
            string filePath = @Filename;
            File.WriteAllText(filePath, CSVText.ToString());
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sdlg.FileName = "TestLink-Conversion";
            sdlg.DefaultExt = "csv";
            sdlg.Filter = "Comma Seperated File (*.csv)|*.csv";

            if (sdlg.ShowDialog() == DialogResult.OK)
            {
                writeFile(sdlg.FileName);
            }
        }

        public void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dlg.Filter = "XML File (*.xml)|*.xml";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filepath = dlg.FileName;
                ReadXML();
            }
        }

        private string RemoveCrap(string stringtoescape)
        {
            string escapedstring = "";
            if (stringtoescape != null)
            {
                escapedstring = stringtoescape.Replace("</p>", "");
                escapedstring = escapedstring.Replace("<p>", "");
                escapedstring = escapedstring.Replace("<br />", "");
            }
            return escapedstring;

        }

    }
}
