using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace AddContentControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creat a new word document.
            Document document = new Document();
            Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph();
            TextRange txtRange = paragraph.AppendText("The following example shows how to add content controls in a Word document.");
            paragraph = section.AddParagraph();
            
            //Add Combo Box Content Control.
            paragraph = section.AddParagraph();
            txtRange=paragraph.AppendText("Add Combo Box Content Control:  ");
            txtRange.CharacterFormat.Italic = true;
            StructureDocumentTagInline sd = new StructureDocumentTagInline(document);
            paragraph.ChildObjects.Add(sd);
            sd.SDTProperties.SDTType = SdtType.ComboBox;
            SdtComboBox cb = new SdtComboBox();
            cb.ListItems.Add(new SdtListItem("Spire.Doc"));
            cb.ListItems.Add(new SdtListItem("Spire.XLS"));
            cb.ListItems.Add(new SdtListItem("Spire.PDF"));
            sd.SDTProperties.ControlProperties = cb;
            TextRange rt = new TextRange(document);
            rt.Text = cb.ListItems[0].DisplayText;
            sd.SDTContent.ChildObjects.Add(rt);

            section.AddParagraph();

            //Add Text Content Control.
            paragraph = section.AddParagraph();
            txtRange = paragraph.AppendText("Add Text Content Control:  ");
            txtRange.CharacterFormat.Italic = true;
            sd = new StructureDocumentTagInline(document);
            paragraph.ChildObjects.Add(sd);
            sd.SDTProperties.SDTType = SdtType.Text;
            SdtText text = new SdtText(true);
            text.IsMultiline = true;
            sd.SDTProperties.ControlProperties = text;
            rt = new TextRange(document);
            rt.Text = "Text";
            sd.SDTContent.ChildObjects.Add(rt);

            section.AddParagraph();

            //Add Picture Content Control.
            paragraph = section.AddParagraph();
            txtRange = paragraph.AppendText("Add Picture Content Control:  ");
            txtRange.CharacterFormat.Italic = true;
            sd = new StructureDocumentTagInline(document);
            paragraph.ChildObjects.Add(sd);
            sd.SDTProperties.SDTType = SdtType.Picture;
            DocPicture pic = new DocPicture(document);
            pic.Width = 10;
            pic.Height = 10;
            pic.LoadImage(Image.FromFile(@"..\..\..\..\..\..\Data\logo.png"));
            sd.SDTContent.ChildObjects.Add(pic);

            section.AddParagraph();

            //Add Date Picker Content Control.
            paragraph = section.AddParagraph();
            txtRange = paragraph.AppendText("Add Date Picker Content Control:  ");
            txtRange.CharacterFormat.Italic = true;
            sd = new StructureDocumentTagInline(document);
            paragraph.ChildObjects.Add(sd);
            sd.SDTProperties.SDTType = SdtType.DatePicker;
            SdtDate date = new SdtDate();
            date.CalendarType = CalendarType.Default;
            date.DateFormat = "yyyy.MM.dd";
            date.FullDate = DateTime.Now;
            sd.SDTProperties.ControlProperties = date;
            rt = new TextRange(document);
            rt.Text = "1990.02.08";
            sd.SDTContent.ChildObjects.Add(rt);

            section.AddParagraph();

            //Add Drop-Down List Content Control.
            paragraph = section.AddParagraph();
            txtRange = paragraph.AppendText("Add Drop-Down List Content Control:  ");
            txtRange.CharacterFormat.Italic = true;
            sd = new StructureDocumentTagInline(document);
            paragraph.ChildObjects.Add(sd);
            sd.SDTProperties.SDTType = SdtType.DropDownList;
            SdtDropDownList sddl = new SdtDropDownList();
            sddl.ListItems.Add(new SdtListItem("Harry"));
            sddl.ListItems.Add(new SdtListItem("Jerry"));
            sd.SDTProperties.ControlProperties = sddl;
            rt = new TextRange(document);
            rt.Text = sddl.ListItems[0].DisplayText;
            sd.SDTContent.ChildObjects.Add(rt);

            //Save the document.
            string resultfile = "Output.docx";
            document.SaveToFile(resultfile, FileFormat.Docx);

            //Launch the Word file.
            FileViewer(resultfile);
        }
        private void FileViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AddContentControls.Properties.Resources.Word;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(376, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 63;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 65);
            this.label1.TabIndex = 64;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Content Controls";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

    }
}