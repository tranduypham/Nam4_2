Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Documents

Namespace SetTableStyleAndBorder
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Create a document and load file
			Dim document As New Document()
			document.LoadFromFile("..\..\..\..\..\..\Data\TableSample.docx")

			Dim section As Section = document.Sections(0)

			'Get the first table
			Dim table As Table = TryCast(section.Tables(0), Table)

			'Apply the table style
			table.ApplyStyle(DefaultTableStyle.ColorfulList)

			'Set right border of table
			table.TableFormat.Borders.Right.BorderType = Spire.Doc.Documents.BorderStyle.Hairline
			table.TableFormat.Borders.Right.LineWidth = 1.0F
			table.TableFormat.Borders.Right.Color = Color.Red

			'Set top border of table
			table.TableFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.Hairline
			table.TableFormat.Borders.Top.LineWidth = 1.0F
			table.TableFormat.Borders.Top.Color = Color.Green

			'Set left border of table
			table.TableFormat.Borders.Left.BorderType = Spire.Doc.Documents.BorderStyle.Hairline
			table.TableFormat.Borders.Left.LineWidth = 1.0F
			table.TableFormat.Borders.Left.Color = Color.Yellow

			'Set bottom border is none
			table.TableFormat.Borders.Bottom.BorderType = Spire.Doc.Documents.BorderStyle.DotDash

			'Set vertical and horizontal border 
			table.TableFormat.Borders.Vertical.BorderType = Spire.Doc.Documents.BorderStyle.Dot
			table.TableFormat.Borders.Horizontal.BorderType = Spire.Doc.Documents.BorderStyle.None
			table.TableFormat.Borders.Vertical.Color = Color.Orange

			'Save the file and launch it
			document.SaveToFile("TableStyleAndBorder.docx", FileFormat.Docx)
			FileViewer("TableStyleAndBorder.docx")
		End Sub
		Private Sub FileViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub
	End Class
End Namespace
