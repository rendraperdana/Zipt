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
        Me.components = New System.ComponentModel.Container()
        Me.btnGetFile = New System.Windows.Forms.Button()
        Me.btnZip = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvFileList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFileList = New System.Windows.Forms.GroupBox()
        Me.lblFileCount = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFileList.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetFile
        '
        Me.btnGetFile.Location = New System.Drawing.Point(547, 38)
        Me.btnGetFile.Name = "btnGetFile"
        Me.btnGetFile.Size = New System.Drawing.Size(237, 74)
        Me.btnGetFile.TabIndex = 0
        Me.btnGetFile.Text = "Get File"
        Me.btnGetFile.UseVisualStyleBackColor = True
        '
        'btnZip
        '
        Me.btnZip.Location = New System.Drawing.Point(859, 38)
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
        Me.dgvFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFileList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFileList.Location = New System.Drawing.Point(6, 100)
        Me.dgvFileList.Name = "dgvFileList"
        Me.dgvFileList.ReadOnly = True
        Me.dgvFileList.RowHeadersVisible = False
        Me.dgvFileList.RowHeadersWidth = 82
        Me.dgvFileList.RowTemplate.Height = 41
        Me.dgvFileList.Size = New System.Drawing.Size(1534, 740)
        Me.dgvFileList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Count:"
        '
        'gbFileList
        '
        Me.gbFileList.Controls.Add(Me.lblFileCount)
        Me.gbFileList.Controls.Add(Me.Label1)
        Me.gbFileList.Controls.Add(Me.dgvFileList)
        Me.gbFileList.Location = New System.Drawing.Point(29, 246)
        Me.gbFileList.Name = "gbFileList"
        Me.gbFileList.Size = New System.Drawing.Size(1546, 846)
        Me.gbFileList.TabIndex = 2
        Me.gbFileList.TabStop = False
        '
        'lblFileCount
        '
        Me.lblFileCount.AutoSize = True
        Me.lblFileCount.Location = New System.Drawing.Point(151, 44)
        Me.lblFileCount.Name = "lblFileCount"
        Me.lblFileCount.Size = New System.Drawing.Size(84, 32)
        Me.lblFileCount.TabIndex = 3
        Me.lblFileCount.Text = "          "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(547, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "File extention to process:"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(827, 170)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(274, 39)
        Me.txtFile.TabIndex = 4
        Me.txtFile.Text = "*.pdf"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1593, 1128)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbFileList)
        Me.Controls.Add(Me.btnZip)
        Me.Controls.Add(Me.btnGetFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zip-and-Encrypt v1.0"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFileList.ResumeLayout(False)
        Me.gbFileList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetFile As Button
    Friend WithEvents btnZip As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents dgvFileList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents gbFileList As GroupBox
    Friend WithEvents lblFileCount As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFile As TextBox
End Class
