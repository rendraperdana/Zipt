<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGetFile = New System.Windows.Forms.Button()
        Me.btnZip = New System.Windows.Forms.Button()
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFileList = New System.Windows.Forms.GroupBox()
        Me.lblFileCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.pbProcess = New System.Windows.Forms.ProgressBar()
        Me.lblFileProgress = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbProgress = New System.Windows.Forms.GroupBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.bwWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFileList.SuspendLayout()
        Me.gbProgress.SuspendLayout()
        Me.gbInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetFile
        '
        Me.btnGetFile.Location = New System.Drawing.Point(129, 83)
        Me.btnGetFile.Name = "btnGetFile"
        Me.btnGetFile.Size = New System.Drawing.Size(237, 74)
        Me.btnGetFile.TabIndex = 0
        Me.btnGetFile.Text = "Get File"
        Me.btnGetFile.UseVisualStyleBackColor = True
        '
        'btnZip
        '
        Me.btnZip.Location = New System.Drawing.Point(441, 83)
        Me.btnZip.Name = "btnZip"
        Me.btnZip.Size = New System.Drawing.Size(237, 74)
        Me.btnZip.TabIndex = 1
        Me.btnZip.Text = "Zip-and-Encrypt"
        Me.btnZip.UseVisualStyleBackColor = True
        '
        'dgvFileList
        '
        Me.dgvFileList.AllowUserToAddRows = False
        Me.dgvFileList.AllowUserToDeleteRows = False
        Me.dgvFileList.AllowUserToOrderColumns = True
        Me.dgvFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFileList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFileList.Location = New System.Drawing.Point(12, 35)
        Me.dgvFileList.MultiSelect = False
        Me.dgvFileList.Name = "dgvFileList"
        Me.dgvFileList.ReadOnly = True
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.RowHeadersWidth = 82
        Me.dgvFileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFileList.RowTemplate.Height = 41
        Me.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFileList.Size = New System.Drawing.Size(1643, 817)
        Me.dgvFileList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Count:"
        '
        'gbFileList
        '
        Me.gbFileList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbFileList.Controls.Add(Me.dgvFileList)
        Me.gbFileList.Location = New System.Drawing.Point(0, 322)
        Me.gbFileList.Name = "gbFileList"
        Me.gbFileList.Size = New System.Drawing.Size(1667, 906)
        Me.gbFileList.TabIndex = 2
        Me.gbFileList.TabStop = False
        '
        'lblFileCount
        '
        Me.lblFileCount.AutoSize = True
        Me.lblFileCount.Location = New System.Drawing.Point(162, 58)
        Me.lblFileCount.Name = "lblFileCount"
        Me.lblFileCount.Size = New System.Drawing.Size(0, 32)
        Me.lblFileCount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "File to process:"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(302, 193)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(376, 39)
        Me.txtFile.TabIndex = 4
        Me.txtFile.Text = "*.pdf"
        '
        'pbProcess
        '
        Me.pbProcess.Location = New System.Drawing.Point(28, 211)
        Me.pbProcess.Name = "pbProcess"
        Me.pbProcess.Size = New System.Drawing.Size(530, 46)
        Me.pbProcess.Step = 1
        Me.pbProcess.TabIndex = 5
        '
        'lblFileProgress
        '
        Me.lblFileProgress.AutoSize = True
        Me.lblFileProgress.Location = New System.Drawing.Point(196, 135)
        Me.lblFileProgress.Name = "lblFileProgress"
        Me.lblFileProgress.Size = New System.Drawing.Size(63, 32)
        Me.lblFileProgress.TabIndex = 7
        Me.lblFileProgress.Text = "(0/0)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "File Progress:"
        '
        'gbProgress
        '
        Me.gbProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProgress.Controls.Add(Me.lblPercent)
        Me.gbProgress.Controls.Add(Me.lblFileCount)
        Me.gbProgress.Controls.Add(Me.pbProcess)
        Me.gbProgress.Controls.Add(Me.lblFileProgress)
        Me.gbProgress.Controls.Add(Me.Label3)
        Me.gbProgress.Controls.Add(Me.Label1)
        Me.gbProgress.Location = New System.Drawing.Point(815, 12)
        Me.gbProgress.Name = "gbProgress"
        Me.gbProgress.Size = New System.Drawing.Size(840, 315)
        Me.gbProgress.TabIndex = 9
        Me.gbProgress.TabStop = False
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(579, 216)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(47, 32)
        Me.lblPercent.TabIndex = 9
        Me.lblPercent.Text = "0%"
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.btnGetFile)
        Me.gbInput.Controls.Add(Me.btnZip)
        Me.gbInput.Controls.Add(Me.txtFile)
        Me.gbInput.Controls.Add(Me.Label2)
        Me.gbInput.Location = New System.Drawing.Point(12, 12)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(797, 315)
        Me.gbInput.TabIndex = 10
        Me.gbInput.TabStop = False
        '
        'bwWorker
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1667, 1258)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.gbProgress)
        Me.Controls.Add(Me.gbFileList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zip-and-Encrypt v1.0.1"
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFileList.ResumeLayout(False)
        Me.gbProgress.ResumeLayout(False)
        Me.gbProgress.PerformLayout()
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetFile As Button
    Friend WithEvents btnZip As Button
    Friend WithEvents dgvFileList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents gbFileList As GroupBox
    Friend WithEvents lblFileCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents pbProcess As ProgressBar
    Friend WithEvents lblFileProgress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbProgress As GroupBox
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents bwWorker As System.ComponentModel.BackgroundWorker
End Class
