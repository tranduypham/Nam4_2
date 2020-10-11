Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents
Imports Spire.Doc.Formatting
Imports System.IO
Imports Spire.Doc.Fields
Imports System.Drawing.Imaging

Namespace ConvertObjectToImage
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document
			Dim document As New Document()
			'Load file
			document.LoadFromFile("..\..\..\..\..\..\Data\ConvertObjectToImage.docx")
			'Get the first section
			Dim section As Section = document.Sections(0)
			'Get body of section
			Dim body As Body = section.Body

			'Get the first paragraph
			Dim paragraph As Paragraph = body.Paragraphs(0)
			Dim image As Image = ConvertParagraphToImage(paragraph)
			image.Save("ConvertParagraphToImage.png",ImageFormat.Png)

			'Get the first table
			Dim table As Table = TryCast(body.Tables(0), Table)
			image = ConvertTableToImage(table)
			image.Save("ConvertTableToImage.jpg", ImageFormat.Jpeg)

			'Get the first row of the first table
			Dim row As TableRow = table.Rows(0)
			image = ConvertTableRowToImage(row)
			image.Save("ConvertTableRowToImage.bmp", ImageFormat.Bmp)

			'Get the first cell of the first row
			Dim cell As TableCell = row.Cells(0)
			image = ConvertTableCellToImage(cell)
			image.Save("ConvertTableCellToImage.png", ImageFormat.Png)

			'Get a shape
			Dim i As Integer = 0
			For Each p As Paragraph In section.Paragraphs
				For Each obj As DocumentObject In p.ChildObjects
					If obj.DocumentObjectType = DocumentObjectType.Shape Then
						image = ConvertShapeToImage(TryCast(obj, ShapeObject))
						image.Save(String.Format("ConvertShapeToImage-{0}.png",i), ImageFormat.Png)
						i += 1
					End If
				Next obj
			Next p

		End Sub
		Private Function ConvertParagraphToImage(ByVal obj As Paragraph) As Image
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()

			section.Body.ChildObjects.Add(obj.Clone())
			Dim image As Image = doc.SaveToImages(0, ImageType.Bitmap)
			doc.Close()
			Return CutImageWhitePart(TryCast(image, Bitmap), 1)
		End Function
		Private Function ConvertTableToImage(ByVal obj As Table) As Image
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()

			section.Body.ChildObjects.Add(obj.Clone())

			Dim image As Image = doc.SaveToImages(0, ImageType.Bitmap)
			doc.Close()
			Return CutImageWhitePart(TryCast(image, Bitmap), 1)
		End Function
		Private Function ConvertTableRowToImage(ByVal obj As TableRow) As Image
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()
			Dim table As Table = section.AddTable()
			table.Rows.Add(obj.Clone())
			Dim image As Image = doc.SaveToImages(0, ImageType.Bitmap)
			doc.Close()
			Return CutImageWhitePart(TryCast(image, Bitmap), 1)
		End Function
		Private Function ConvertTableCellToImage(ByVal obj As TableCell) As Image
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()
			Dim table As Table = section.AddTable()
			table.AddRow().Cells.Add(obj.Clone())
			Dim image As Image = doc.SaveToImages(0, ImageType.Bitmap)
			doc.Close()
			Return CutImageWhitePart(TryCast(image, Bitmap), 1)
		End Function
		Private Function ConvertShapeToImage(ByVal obj As ShapeObject) As Image
			Dim doc As New Document()
			Dim section As Section = doc.AddSection()
			section.AddParagraph().ChildObjects.Add(obj.Clone())
			Dim ms As New MemoryStream()
			doc.SaveToStream(ms, FileFormat.Docx)
			doc.LoadFromStream(ms,FileFormat.Docx)
			Dim image As Image = doc.SaveToImages(0, ImageType.Bitmap)
			ms.Close()
			doc.Close()
			Return CutImageWhitePart(TryCast(image, Bitmap), 1)
		End Function
		Public Function CutImageWhitePart(ByVal bmp As Bitmap, ByVal WhiteBarRate As Integer) As Image
			Dim top As Integer = 0, left As Integer = 0
			Dim right As Integer = bmp.Width, bottom As Integer = bmp.Height
			Dim white As Color = Color.White

			For i As Integer = 0 To bmp.Height - 1
				Dim find As Boolean = False
				For j As Integer = 0 To bmp.Width - 1
					Dim c As Color = bmp.GetPixel(j, i)
					If IsWhite(c) Then
						top = i
						find = True
						Exit For
					End If
				Next j
				If find Then
					Exit For
				End If
			Next i

			For i As Integer = 0 To bmp.Width - 1
				Dim find As Boolean = False
				For j As Integer = top To bmp.Height - 1
					Dim c As Color = bmp.GetPixel(i, j)
					If IsWhite(c) Then
						left = i
						find = True
						Exit For
					End If
				Next j
				If find Then
					Exit For
				End If

			Next i

			For i As Integer = bmp.Height - 1 To 0 Step -1
				Dim find As Boolean = False
				For j As Integer = left To bmp.Width - 1
					Dim c As Color = bmp.GetPixel(j, i)
					If IsWhite(c) Then
						bottom = i
						find = True
						Exit For
					End If
				Next j
				If find Then
					Exit For
				End If
			Next i

			For i As Integer = bmp.Width - 1 To 0 Step -1
				Dim find As Boolean = False
				For j As Integer = 0 To bottom
					Dim c As Color = bmp.GetPixel(i, j)
					If IsWhite(c) Then
						right = i
						find = True
						Exit For
					End If
				Next j
				If find Then
					Exit For
				End If
			Next i
			Dim iWidth As Integer = right - left
			Dim iHeight As Integer = bottom - left
			Dim blockWidth As Integer = Convert.ToInt32(iWidth * WhiteBarRate \ 100)
			bmp = Cut(bmp, left - blockWidth, top - blockWidth, right - left + 2 * blockWidth, bottom - top + 2 * blockWidth)

			Return bmp

		End Function
		Public Function Cut(ByVal b As Bitmap, ByVal StartX As Integer, ByVal StartY As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As Bitmap
			If b Is Nothing Then
				Return Nothing
			End If
			Dim w As Integer = b.Width
			Dim h As Integer = b.Height
			If StartX >= w OrElse StartY >= h Then
				Return Nothing
			End If
			If StartX + iWidth > w Then
				iWidth = w - StartX
			End If
			If StartY + iHeight > h Then
				iHeight = h - StartY
			End If
			Try
				Dim bmpOut As New Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb)
				Dim g As Graphics = Graphics.FromImage(bmpOut)
				g.DrawImage(b, New Rectangle(0, 0, iWidth, iHeight), New Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel)
				g.Dispose()
				Return bmpOut
			Catch
				Return Nothing
			End Try
		End Function


		Public Function IsWhite(ByVal c As Color) As Boolean
			If c.R < 245 OrElse c.G < 245 OrElse c.B < 245 Then
				Return True
			Else
				Return False
			End If
		End Function
	End Class
End Namespace
