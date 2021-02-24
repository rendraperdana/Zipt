Imports System.IO
Imports System.Security.Cryptography
Public Class frmMain
    Public strAppPath As String = Application.StartupPath.ToString
    Dim dtList As New DataTable
    Public chrCharSet() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "$", "%", "^", "*", "(", ")"}

    Private Sub btnGetFile_Click(sender As Object, e As EventArgs) Handles btnGetFile.Click
        Call ResetState()
        Call subGetFile()
        Call PrepareState()
    End Sub

    Private Sub ResetState()
        dtList.Clear()
        dtList.Dispose()
        gbInput.Enabled = True
        lblFileCount.Text = "0"
        lblFileProgress.Text = "0/0"
        lblPercent.Text = "0%"
        pbProcess.Value = 0
        pbProcess.Minimum = 0
        pbProcess.Maximum = 1
    End Sub

    Private Sub PrepareState()
        lblFileCount.Text = dtList.Rows.Count
        lblFileProgress.Text = "0/" & dtList.Rows.Count
        lblPercent.Text = "0%"
        pbProcess.Maximum = dtList.Rows.Count
        pbProcess.Value = 0
    End Sub

    Private Sub btnZip_Click(sender As Object, e As EventArgs) Handles btnZip.Click
        If MessageBox.Show("Process file: " & txtFile.Text & " ?", "Confirm", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            gbInput.Enabled = False
            Call subZipEncrypt()
            Call SaveToCSV(Me.strAppPath & "PasswordPair.txt")
            Call ResetState()
        End If
    End Sub

    Private Sub backgroundProcess() Handles bwWorker.DoWork

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtList.Columns.Add("No")
        dtList.Columns.Add("File Path")
        dtList.Columns.Add("Password")
        dgvFileList.DataSource = dtList
    End Sub

    Private Function PasswordCreator() As String
        Dim rngSeed As New Random
        Dim strRandom As String = ""

        For i = 0 To 13 Step 1
            strRandom &= chrCharSet(rngSeed.Next(1, 44))
        Next

        Return strRandom
    End Function

    Private Sub SaveToCSV(strFilePath As String)
        Dim swWriter As New StreamWriter(strFilePath, 0)

        Try

            For i = 0 To dtList.Columns.Count - 1
                swWriter.Write(dtList.Columns(i).ColumnName)
                If i < dtList.Columns.Count - 1 Then
                    swWriter.Write(",")
                Else
                    swWriter.WriteLine("")
                End If
            Next

            For Each drListRow As DataRow In dtList.Rows
                swWriter.Write(drListRow(1).ToString)
                swWriter.Write(",")
                swWriter.Write(drListRow(2).ToString)
                swWriter.WriteLine("")
            Next

            swWriter.Close()
            MessageBox.Show("Password file created in: " & strFilePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            swWriter.Dispose()
            GC.Collect()
        End Try

    End Sub

    Private Sub UpdatepbProcess(ByVal pb As ProgressBar)
        If pb.InvokeRequired Then
            pb.Invoke(New UpdatepbProcessInvoker(AddressOf UpdatepbProcess), pb)
        Else
            pbProcess.PerformStep()
        End If
    End Sub
    Private Delegate Sub UpdatepbProcessInvoker(ByVal pb As ProgressBar)

    Private Sub SetPercentText(ByVal text As String, ByVal lblpercent As Label)
        If lblpercent.InvokeRequired Then
            lblpercent.Invoke(New SetPercentTextInvoker(AddressOf SetPercentText), text, lblpercent)
        Else
            lblpercent.Text = text
        End If
    End Sub
    Private Delegate Sub SetPercentTextInvoker(ByVal test As String, ByVal lblPercent As Label)

    Private Sub SetFileProgressText(ByVal text As String, ByVal lblProgress As Label)
        If lblProgress.InvokeRequired Then
            lblProgress.Invoke(New SetFileProgressTextInvoker(AddressOf SetFileProgressText), text, lblProgress)
        Else
            lblProgress.Text = text
        End If
    End Sub
    Private Delegate Sub SetFileProgressTextInvoker(ByVal text As String, ByVal lblProgress As Label)

    Private Sub subZipEncrypt()
        'Strong object disposal and cleanup required here

        Try
            For Each drFileList As DataRow In dtList.Rows
                Dim zipFile As New Ionic.Zip.ZipFile

                zipFile.Password = drFileList(2).ToString
                zipFile.Encryption = Ionic.Zip.EncryptionAlgorithm.WinZipAes128
                zipFile.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed
                zipFile.AddFile(drFileList(1).ToString, "")
                zipFile.Save(drFileList(1).ToString + ".zip")
                pbProcess.PerformStep()
                lblPercent.Text = FormatPercent(pbProcess.Value / pbProcess.Maximum, 0)
                lblFileProgress.Text = "(" & pbProcess.Value & "/" & pbProcess.Maximum & ")"
                Me.Refresh()
                zipFile.Dispose()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub subGetFile()
        Dim strList() As String
        Dim intNo As UInt32 = 0

        Try
            dgvFileList.DataSource = ""

            For Each foundFile As String In IO.Directory.GetFiles(strAppPath, txtFile.Text, IO.SearchOption.TopDirectoryOnly)
                intNo += 1
                strList = {intNo, foundFile, PasswordCreator()}
                dtList.Rows.Add(strList)
            Next

            dgvFileList.DataSource = dtList
            lblFileCount.Text = dtList.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
