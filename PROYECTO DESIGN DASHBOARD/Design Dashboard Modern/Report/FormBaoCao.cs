using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment;

namespace Design_Dashboard_Modern
{
    public partial class FormBaoCao : Form
    {
        private readonly string Temp = System.Windows.Forms.Application.StartupPath + @"/Baocao.docx";
        public FormBaoCao()
        {
            InitializeComponent();
        }
        public int SumData(DataGridView DGV)
        {
            int Sum = 0;
            int row = DGV.Rows.Count;
            int col = DGV.Columns.Count;
            for (int i = 0; i < row - 1; i++)
            {
                Sum += int.Parse(DGV.Rows[i].Cells[col - 1].Value == null ? "0" : DGV.Rows[i].Cells[col - 1].Value.ToString());
            }
            return Sum;

        }
        public void SumData_for_C(DataGridView DGV)
        {
     
            int row = DGV.Rows.Count;
            for (int i = 0; i < row - 1; i++)
            {
                DGV.Rows[i].Cells[2].Value = (120 - int.Parse(DGV.Rows[i].Cells[1].Value.ToString())).ToString();

            }
        }
        private void Replace_Grid(int Vi_tri_bang, string Ten_file1, string Ten_file2, DataGridView DGV)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            int col = DGV.Columns.Count;
            int row = DGV.Rows.Count;
            //Creat a new document and load the document form file 
            Document doc = new Document();
            doc.LoadFromFile(Ten_file2);

            //Get the first table from the word document
            Table table = doc.Sections[0].Tables[Vi_tri_bang] as Spire.Doc.Table;

            //Insert a new row as the THIRD row

            for (int i = 1; i < row; i++)
            {
                table.AddRow();
            }
            for (int i = 1; i < row; i++)
            {
                TableRow oRow = table.Rows[i];

                //format Row
                oRow.Height = 30;

                for (int j = 0; j < DGV.Columns.Count; j++)
                {
                    ////Viết nội dung cho Cell[i][j]
                    TableCell cell = oRow.Cells[j];

                    //Align Cell
                    cell.CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                    //Fill data in row
                    cell.Paragraphs.Clear();
                    Paragraph p2 = cell.AddParagraph();
                    string str = DGV.Rows[i - 1].Cells[j].Value == null ? "null" : DGV.Rows[i - 1].Cells[j].Value.ToString();

                    TextRange TR2 = p2.AppendText(str);//Cai nay de modify code chu khong phai de set Text           

                    //Format Cell
                    p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    TR2.CharacterFormat.FontName = "Time New Roman";
                    TR2.CharacterFormat.FontSize = 14;
                    TR2.CharacterFormat.TextColor = Color.Black;
                }
            }

            //Save the document to file and set its file format
            doc.SaveToFile(Ten_file1, FileFormat.Docx2010);
        }
        public void ReplaceWordStub(string stubtoReplace, string text, Microsoft.Office.Interop.Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();//Clear dữ liệutimfkieesmtrcđấy
            range.Find.Execute(FindText: stubtoReplace, ReplaceWith: text);
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Replace_Grid(1, "Baocao.docx", "Reports.docx", dataGridView1);
            Replace_Grid(3, "Baocao.docx", "Baocao.docx", dataGridView2);
            Replace_Grid(5, "Baocao.docx", "Baocao.docx", dataGridView3);
            Replace_Grid(7, "Baocao.docx", "Baocao.docx", dataGridView4);
            Replace_Grid(9, "Baocao.docx", "Baocao.docx", dataGridView5);
            Replace_Grid(11, "Baocao.docx", "Baocao.docx", dataGridView6);
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDocument= wordApp.Documents.Open(Temp);

            var hoTen = TbHoTen == null ? "null" : TbHoTen.Text;
            var khoa = cbKhoa == null ? "null" : cbKhoa.Text;
            var toBoMon = cbBoMon_0 == null ? "null" : cbBoMon_0.Text;
            var ngay = numDay == null ? "null" : numDay.Text;
            var thang = numMonth == null ? "null" : numMonth.Text;
            var nam = numYear == null ? "null" : numYear.Text;
            var namHoc = TbNam == null ? "null" : TbNam.Text;
            var namSinh = cbNamSinh == null ? "null" : cbNamSinh.Text;
            var chucVu = cbChucVu == null ? "null" : cbChucVu.Text;
            var luongThuc = numLuong == null ? "null" : numLuong.Text;
            var hocHam = TbHocHam == null ? "null" : TbHocHam.Text;

            var tong1 = Tong1 == null ? "null" : Tong1.Text;
            var tong2 = Tong2 == null ? "null" : Tong2.Text;
            var tong3 = Tong3 == null ? "null" : Tong3.Text;
            var tong4 = Tong4 == null ? "null" : Tong4.Text;
            var tongA = TongA == null ? "null" : TongA.Text;
            var tongB = TongA == null ? "null" : TongB.Text;
            var TongSoTiet = TbTongSoTiet == null ? "null" : TbTongSoTiet.Text;
            var SoTietGiang = TbSoTietGiang == null ? "null" : TbSoTietGiang.Text;
            var SoGioChuaHT = TbSoGioChuaHT == null ? "null" : TbSoGioChuaHT.Text;
            var SoTietDuocGiam = TbSoTietDuocGiam == null ? "null" : TbSoTietDuocGiam.Text;
            var TongSoTietVuot = TbTongSoTietVuot == null ? "null" : TbTongSoTietVuot.Text;
            var LyDoGiamTru = TbLyDoGiamTru == null ? "null" : TbLyDoGiamTru.Text;
            var phantram = Phantram == null ? "null" : Phantram.Text;


            ReplaceWordStub("{Khoa}", khoa, wordDocument);
            ReplaceWordStub("{Tobomon}", toBoMon, wordDocument);
            ReplaceWordStub("{d}", ngay, wordDocument);
            ReplaceWordStub("{m}", thang, wordDocument);
            ReplaceWordStub("{y}", nam, wordDocument);
            ReplaceWordStub("{Year}", namHoc, wordDocument);
            ReplaceWordStub("{Hoten}", hoTen, wordDocument);
            ReplaceWordStub("{Birthday}", namSinh, wordDocument);
            ReplaceWordStub("{Chucvu}", chucVu, wordDocument);
            ReplaceWordStub("{Luongthucnhan}", luongThuc, wordDocument);
            ReplaceWordStub("{Hocham}", hocHam, wordDocument);

            ReplaceWordStub("{SUM1c}", tong1, wordDocument);
            ReplaceWordStub("{SUM2c}", tong2, wordDocument);
            ReplaceWordStub("{SUM3c}", tong3, wordDocument);
            ReplaceWordStub("{SUM4c}", tong4, wordDocument);
            ReplaceWordStub("{SUMAc}", tongA, wordDocument);
            ReplaceWordStub("{SUMBc}", tongB, wordDocument);
            ReplaceWordStub("{TStieest}", TongSoTiet, wordDocument);
            ReplaceWordStub("{STpharig}", SoTietGiang, wordDocument);
            ReplaceWordStub("{STchwaht}", SoGioChuaHT, wordDocument);
            ReplaceWordStub("{STdgt}", SoTietDuocGiam, wordDocument);
            ReplaceWordStub("{STthanht}", TongSoTietVuot, wordDocument);
            ReplaceWordStub("{Lydogiarmtrw}", LyDoGiamTru, wordDocument);
            ReplaceWordStub("{phantrwm}", phantram, wordDocument);
            ReplaceWordStub(@"Evaluation Warning: The document was created with Spire.Doc for .NET.", "", wordDocument);
            string output = @"Baocao_" + hoTen.Trim() + @"_" + namHoc.Trim() + @".docx";
            //string output = @"/Output/Baocao.docx";
            wordDocument.SaveAs(Application.StartupPath + output);
            wordApp.Documents.Open(Application.StartupPath + output);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Cái nay nhập ngày tháng năm hiện tại vào chỗ Hà nội ngày
            DateTime dt = DateTime.Now;
            numDay.Value = dt.Day;
            numMonth.Value = dt.Month;
            numYear.Value = dt.Year;

            //Chỉ lả gen ra các năm tuổi thôi 
            for (int i = 1970; i <= dt.Year; i++)
            {
                cbNamSinh.Items.Add(i);
            }
        }
        private void Tong1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
        }
        private void Tong2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
        }
        private void Tong3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong3.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
        }
        private void Tong4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }

            if (!string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (string.IsNullOrEmpty(Tong1.Text) && !string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong4.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong2.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(Tong1.Text) && string.IsNullOrEmpty(Tong2.Text) && !string.IsNullOrEmpty(Tong3.Text) && !string.IsNullOrEmpty(Tong4.Text))
            {
                TongA.Text = (Convert.ToInt32(Tong1.Text) + Convert.ToInt32(Tong3.Text) + Convert.ToInt32(Tong4.Text)).ToString();
            }
        }
        private void TongA_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TongA.Text) && !string.IsNullOrEmpty(TongB.Text))
            {
                TbTongSoTiet.Text = (Convert.ToInt32(TongA.Text) + Convert.ToInt32(TongB.Text)).ToString();
            }
            if (!string.IsNullOrEmpty(TongA.Text) && string.IsNullOrEmpty(TongB.Text))
            {
                TbTongSoTiet.Text = (Convert.ToInt32(TongA.Text)).ToString();
            }


        }
        private void TongB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TongA.Text) && !string.IsNullOrEmpty(TongB.Text))
            {
                TbTongSoTiet.Text = (Convert.ToInt32(TongA.Text) + Convert.ToInt32(TongB.Text)).ToString();
            }
            if (string.IsNullOrEmpty(TongA.Text) && !string.IsNullOrEmpty(TongB.Text))
            {
                TbTongSoTiet.Text = (Convert.ToInt32(TongB.Text)).ToString();
            }
        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Tong1.Text = SumData(dataGridView1).ToString();
        }
        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Tong2.Text = SumData(dataGridView2).ToString();
        }
        private void dataGridView3_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Tong3.Text = SumData(dataGridView3).ToString();
        }
        private void dataGridView4_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Tong4.Text = SumData(dataGridView4).ToString();
        }
        private void dataGridView5_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            TongB.Text = SumData(dataGridView5).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SumData_for_C(dataGridView6);
            TbSoGioChuaHT.Text = SumData(dataGridView6).ToString();
            var Tongsotiet = string.IsNullOrEmpty(TbTongSoTiet.Text) == true ? "0" : TbTongSoTiet.Text;
            var SoTietGiang = string.IsNullOrEmpty(TbSoTietGiang.Text) == true ? "0" : TbSoTietGiang.Text;
            var SoGioChuaHT = string.IsNullOrEmpty(TbSoGioChuaHT.Text) == true ? "0" : TbSoGioChuaHT.Text;
            var SoTietDuocGiam = string.IsNullOrEmpty(TbSoTietDuocGiam.Text) == true ? "0" : TbSoTietDuocGiam.Text;
            var phantram = string.IsNullOrEmpty(Phantram.Text) == true ? "0" : Phantram.Text;



            TbTongSoTietVuot.Text = (Convert.ToInt32(Tongsotiet) - Convert.ToInt32(SoTietGiang) - Convert.ToInt32(SoGioChuaHT) + Convert.ToInt32(SoTietDuocGiam)).ToString();
            TbSoTietDuocGiam.Text = (double.Parse(SoTietGiang) - double.Parse(SoTietGiang) * double.Parse(phantram) / 100).ToString();

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView2.Rows[e.RowIndex].Cells["stt1"].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView3.Rows[e.RowIndex].Cells["stt2"].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridView4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView4.Rows[e.RowIndex].Cells["stt3"].Value = (e.RowIndex + 1).ToString();

        }

        private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView5.Rows[e.RowIndex].Cells["stt4"].Value = (e.RowIndex + 1).ToString();

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

