using System;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Text.RegularExpressions;

namespace RemoveTableOfContent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a document
            Document document = new Document();

            //Load the document from disk.
            document.LoadFromFile(@"..\..\..\..\..\..\Data\TableOfContent.docx");

            //Get the first body from the first section
            Body body = document.Sections[0].Body;

            //Remove TOC from first body
            Regex regex = new Regex("TOC\\w+");
            for (int i = 0; i < body.Paragraphs.Count; i++)
            {
                if (regex.IsMatch(body.Paragraphs[i].StyleName))
                {
                    body.Paragraphs.RemoveAt(i);
                    i--;
                }
            }

            //Save the document.
            document.SaveToFile("Output.docx", FileFormat.Docx);

            //Launch the Word file.
            WordDocViewer("Output.docx");
        }
        private void WordDocViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }

    }
}
