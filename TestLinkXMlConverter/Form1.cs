using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLinkXMlConverter
{
    public partial class TestLinkXMLConverterForm : Form
    {
        public Converter converter = new Converter();
        public TestLinkXMLConverterForm()
        {
            InitializeComponent();
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            converter.OpenFileButton_Click(sender, e);
            FileName_tb.Text = converter.FilePath;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            converter.SaveButton_Click(sender, e);
        }


    }
}
