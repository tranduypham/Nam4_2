Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices

Namespace XpsPrint
	''' <summary>
	''' An utility class to print a file via Windows  XpsPrint API.
	''' </summary>
	Public Class XpsPrintHelper

		Private Sub New()
		End Sub

		''' <summary>
		''' Sends a stream that contains a document in the XPS format to a printer using the XpsPrint API.
		''' </summary>
		''' <param name="stream"></param>
		''' <param name="printerName"></param>
		''' <param name="jobName">Job name. Can be null.</param>
		''' <param name="isWait">True to wait for the job to complete. False to return immediately after submitting the job.</param>
		''' <exception cref="Exception">Thrown if any error occurs.</exception>
		Public Shared Sub Print(ByVal stream As Stream, ByVal printerName As String, ByVal jobName As String, ByVal isWait As Boolean)
			If stream Is Nothing Then
				Throw New ArgumentNullException("stream")
			End If
			If printerName Is Nothing Then
				Throw New ArgumentNullException("printerName")
			End If

			Dim completionEvent As IntPtr = CreateEvent(IntPtr.Zero, True, False, Nothing)
			If completionEvent = IntPtr.Zero Then
				Throw New Win32Exception()
			End If

			Try
				Dim job As IXpsPrintJob
				Dim jobStream As IXpsPrintJobStream
				StartJob(printerName, jobName, completionEvent, job, jobStream)

				CopyJob(stream, job, jobStream)

				If isWait Then
					WaitForJob(completionEvent)
					CheckJobStatus(job)
				End If
			Finally
				If completionEvent <> IntPtr.Zero Then
					CloseHandle(completionEvent)
				End If
			End Try
		End Sub
		Private Shared Sub StartJob(ByVal printerName As String, ByVal jobName As String, ByVal completionEvent As IntPtr, ByRef job As IXpsPrintJob, ByRef jobStream As IXpsPrintJobStream)
			Dim result As Integer = StartXpsPrintJob(printerName, jobName, Nothing, IntPtr.Zero, completionEvent, Nothing, 0, job, jobStream, IntPtr.Zero)
			If result <> 0 Then
				Throw New Win32Exception(result)
			End If
		End Sub

		Private Shared Sub CopyJob(ByVal stream As Stream, ByVal job As IXpsPrintJob, ByVal jobStream As IXpsPrintJobStream)
			Try
				Dim buff(4095) As Byte
				Do
					Dim read As UInteger = CUInt(stream.Read(buff, 0, buff.Length))
					If read = 0 Then
						Exit Do
					End If

					Dim written As UInteger
					jobStream.Write(buff, read, written)

					If read <> written Then
						Throw New Exception("Failed to copy data to the print job stream.")
					End If
				Loop


				jobStream.Close()
			Catch e1 As Exception

				job.Cancel()
				Throw
			End Try
		End Sub

		Private Shared Sub WaitForJob(ByVal completionEvent As IntPtr)
			Const INFINITE As Integer = -1
			Select Case WaitForSingleObject(completionEvent, INFINITE)
				Case WAIT_RESULT.WAIT_OBJECT_0

				Case WAIT_RESULT.WAIT_FAILED
					Throw New Win32Exception()
				Case Else
					Throw New Exception("Unexpected result when waiting for the print job.")
			End Select
		End Sub

		Private Shared Sub CheckJobStatus(ByVal job As IXpsPrintJob)
			Dim jobStatus As XPS_JOB_STATUS
			job.GetJobStatus(jobStatus)
			Select Case jobStatus.completion
				Case XPS_JOB_COMPLETION.XPS_JOB_COMPLETED
					' Expected result, do nothing.
				Case XPS_JOB_COMPLETION.XPS_JOB_FAILED
					Throw New Win32Exception(jobStatus.jobStatus)
				Case Else
					Throw New Exception("Unexpected print job status.")
			End Select
		End Sub

		<DllImport("XpsPrint.dll", EntryPoint := "StartXpsPrintJob")>
		Private Shared Function StartXpsPrintJob(<MarshalAs(UnmanagedType.LPWStr)> ByVal printerName As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal jobName As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal outputFileName As String, ByVal progressEvent As IntPtr, ByVal completionEvent As IntPtr, <MarshalAs(UnmanagedType.LPArray)> ByVal printablePagesOn() As Byte, ByVal printablePagesOnCount As UInt32, ByRef xpsPrintJob As IXpsPrintJob, ByRef documentStream As IXpsPrintJobStream, ByVal printTicketStream As IntPtr) As Integer ' This is actually "out IXpsPrintJobStream", but we don't use it and just want to pass null, hence IntPtr. -  HANDLE -  HANDLE
		End Function

		<DllImport("Kernel32.dll", SetLastError := True)>
		Private Shared Function CreateEvent(ByVal lpEventAttributes As IntPtr, ByVal bManualReset As Boolean, ByVal bInitialState As Boolean, ByVal lpName As String) As IntPtr
		End Function

		<DllImport("Kernel32.dll", SetLastError := True, ExactSpelling := True)>
		Private Shared Function WaitForSingleObject(ByVal handle As IntPtr, ByVal milliseconds As Int32) As WAIT_RESULT
		End Function

		<DllImport("Kernel32.dll", SetLastError := True)>
		Private Shared Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Function
	End Class

	<Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
	Friend Interface IXpsPrintJobStream ' This is IID of ISequenatialSteam.
		' ISequentualStream methods.
		Sub Read(<MarshalAs(UnmanagedType.LPArray)> ByVal pv() As Byte, ByVal cb As UInteger, ByRef pcbRead As UInteger)
		Sub Write(<MarshalAs(UnmanagedType.LPArray)> ByVal pv() As Byte, ByVal cb As UInteger, ByRef pcbWritten As UInteger)
		' IXpsPrintJobStream methods.
		Sub Close()
	End Interface

	<Guid("5ab89b06-8194-425f-ab3b-d7a96e350161"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
	Friend Interface IXpsPrintJob
		Sub Cancel()
		Sub GetJobStatus(ByRef jobStatus As XPS_JOB_STATUS)
	End Interface

	<StructLayout(LayoutKind.Sequential)>
	Friend Structure XPS_JOB_STATUS
		Public jobId As UInt32
		Public currentDocument As Int32
		Public currentPage As Int32
		Public currentPageTotal As Int32
		Public completion As XPS_JOB_COMPLETION
		Public jobStatus As Int32 ' UInt32
	End Structure

	Friend Enum XPS_JOB_COMPLETION
		XPS_JOB_IN_PROGRESS = 0
		XPS_JOB_COMPLETED = 1
		XPS_JOB_CANCELLED = 2
		XPS_JOB_FAILED = 3
	End Enum

	Friend Enum WAIT_RESULT
		WAIT_OBJECT_0 = 0
		WAIT_ABANDONED = &H80
		WAIT_TIMEOUT = &H102
		WAIT_FAILED = -1 ' 0xFFFFFFFF
	End Enum
End Namespace
