Imports System.IO
Imports System.Security.Cryptography
Public Class frmMain
    Public strAppPath As String = Application.StartupPath.ToString
    Dim dtList As New DataTable
    Public chrCharSet() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")"}

    Private Sub btnGetFile_Click(sender As Object, e As EventArgs) Handles btnGetFile.Click
        dgvFileList.Rows.Clear()
        dtList.Clear()
        Call subGetFile()
    End Sub

    Private Sub btnZip_Click(sender As Object, e As EventArgs) Handles btnZip.Click
        If MessageBox.Show("Process file: " & txtFile.Text & " ?", "Confirm", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Call subZipEncrypt()
            Call SaveToCSV(Me.strAppPath & "PasswordPair.txt")
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFileList.Columns.Add("clmNo", "No")
        dgvFileList.Columns.Add("clmFileList", "File Name")
        dgvFileList.Columns.Add("clmPassword", "Password")
        dtList.Columns.Add("No")
        dtList.Columns.Add("FilePath")
        dtList.Columns.Add("Password")
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
        Dim swWriter As New StreamWriter(strFilePath)

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
    End Sub

    Private Sub subZipEncrypt()
        Try
            For Each drFileList As DataRow In dtList.Rows
                Dim zipFile As New Ionic.Zip.ZipFile

                zipFile.Password = drFileList(2).ToString
                zipFile.Encryption = Ionic.Zip.EncryptionAlgorithm.WinZipAes128
                zipFile.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed
                zipFile.AddFile(drFileList(1).ToString, "")
                zipFile.Save(drFileList(1).ToString + txtFile.Text)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub subGetFile()
        Dim strList() As String
        Dim intNo As UInt32 = 0

        Try

            For Each foundFile As String In IO.Directory.GetFiles(strAppPath, txtFile.Text, IO.SearchOption.TopDirectoryOnly)
                intNo += 1
                strList = {intNo, foundFile, PasswordCreator()}
                dtList.Rows.Add(strList)
                dgvFileList.Rows.Add(strList)
            Next

            lblFileCount.Text = dtList.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
