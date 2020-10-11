Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Fields

Namespace ModifyTableFormat
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Load Word document from disk
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\ModifyTableFormat.docx")

			'Get the first section
			Dim section As Section = document.Sections(0)

			'Get tables 
			Dim tb1 As Table = TryCast(section.Tables(0), Table)
			Dim tb2 As Table = TryCast(section.Tables(1), Table)
			Dim tb3 As Table = TryCast(section.Tables(2), Table)

			MoidyTableFormat(tb1)
			ModifyRowFormat(tb2)
			ModifyCellFormat(tb3)

			Dim output As String = "ModifyTableFormat_out.docx"
			document.SaveToFile(output, FileFormat.Docx2013)

			'Launch Word file.
			WordDocViewer(output)
		End Sub
		Private Shared Sub MoidyTableFormat(ByVal table As Table)
			'Set table width
			table.PreferredWidth = New PreferredWidth(WidthType.Twip,CShort(6000))

			'Apply style for table
			table.ApplyStyle(DefaultTableStyle.ColorfulGridAccent3)

			'Set table padding
			table.TableFormat.Paddings.All =5

			'Set table title and description
			table.Title = "Spire.Doc for .NET"
			table.TableDescription = "Spire.Doc for .NET is a professional Word .NET library"
		End Sub
		Private Shared Sub ModifyRowFormat(ByVal table As Table)
			'Set cell spacing
			table.Rows(0).RowFormat.CellSpacing = 2

			'Set row height
			table.Rows(1).HeightType = TableRowHeightType.Exactly
			table.Rows(1).Height = 20f

			'Set background color
			table.Rows(2).RowFormat.BackColor = Color.DarkSeaGreen
		End Sub
		Private Shared Sub ModifyCellFormat(ByVal table As Table)
			'Set alignment
			table.Rows(0).Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
			table.Rows(0).Cells(0).Paragraphs(0).Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center

			'Set background color
			table.Rows(1).Cells(0).CellFormat.BackColor = Color.DarkSeaGreen

			'Set cell border
			table.Rows(2).Cells(0).CellFormat.Borders.BorderType = Spire.Doc.Documents.BorderStyle.Single
			table.Rows(2).Cells(0).CellFormat.Borders.LineWidth = 1f
			table.Rows(2).Cells(0).CellFormat.Borders.Left.Color = Color.Red
			table.Rows(2).Cells(0).CellFormat.Borders.Right.Color = Color.Red
			table.Rows(2).Cells(0).CellFormat.Borders.Top.Color = Color.Red
			table.Rows(2).Cells(0).CellFormat.Borders.Bottom.Color = Color.Red

			'Set text direction
			table.Rows(3).Cells(0).CellFormat.TextDirection = TextDirection.RightToLeft
		End Sub

		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace