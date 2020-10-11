Imports System.ComponentModel
Imports System.Text
Imports Spire.Doc
Imports Spire.Doc.Fields.OMath
Imports Spire.Doc.Documents

Namespace AddMathEquation
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim latexMathCode() As String = { "x^{2}+\\sqrt{x^{2}+1}=2", "2\alpha - \sin y + x", "1 \over 2 + x", "(1 + \vert x-[a-b] \vert)", "\mbox{if $x=1$ or $x=2$}", "\begin{cases} 1 & \mbox{if $x>0$,} \\ 2 & \mbox{otherwise.} \end{cases}" }

			Dim doc As New Document()
			doc.LoadFromFile("..\..\..\..\..\..\Data\AddMathEquation.docx")
			Dim section As Section = doc.Sections(0)

			Dim paragraph As Paragraph
			Dim officeMath As OfficeMath
			'Add LaTeX code
			Dim table1 As Table = TryCast(section.Tables(0), Table)
			Dim mathEquations As New List(Of OfficeMath)()
			For i As Integer = 1 To 6
				paragraph = table1.Rows(i).Cells(0).AddParagraph()
				paragraph.Text = latexMathCode(i - 1)
				paragraph = table1.Rows(i).Cells(1).AddParagraph()
				officeMath = New OfficeMath(doc)
				officeMath.FromLatexMathCode(latexMathCode(i - 1))
				paragraph.Items.Add(officeMath)
				mathEquations.Add(officeMath)
			Next i

			'Add MathML code
			Dim table2 As Table = TryCast(section.Tables(1), Table)
			For i As Integer = 1 To 6
				paragraph = table2.Rows(i).Cells(0).AddParagraph()
				paragraph.Text = mathEquations(i-1).ToMathMLCode()
				paragraph = table2.Rows(i).Cells(1).AddParagraph()
				officeMath = New OfficeMath(doc)
				officeMath.FromMathMLCode(mathEquations(i - 1).ToMathMLCode())
				paragraph.Items.Add(officeMath)

			Next i
			Dim result As String = "AddMathEquation_result.docx"
			doc.SaveToFile(result, FileFormat.Docx)
			WordDocViewer(result)
		End Sub
		Private Sub WordDocViewer(ByVal fileName As String)
			Try
				Process.Start(fileName)
			Catch
			End Try
		End Sub

	End Class
End Namespace
