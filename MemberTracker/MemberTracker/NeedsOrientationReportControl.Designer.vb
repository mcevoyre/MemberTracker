<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeedsOrientationReportControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgvReportData = New System.Windows.Forms.DataGridView()
        Me.gbReports = New System.Windows.Forms.GroupBox()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.txtEmailBody = New System.Windows.Forms.TextBox()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.txtEmailSubject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvReportData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReportData
        '
        Me.dgvReportData.AllowUserToAddRows = False
        Me.dgvReportData.AllowUserToDeleteRows = False
        Me.dgvReportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReportData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportData.Location = New System.Drawing.Point(3, 16)
        Me.dgvReportData.Name = "dgvReportData"
        Me.dgvReportData.Size = New System.Drawing.Size(598, 229)
        Me.dgvReportData.TabIndex = 0
        '
        'gbReports
        '
        Me.gbReports.Controls.Add(Me.dgvReportData)
        Me.gbReports.Location = New System.Drawing.Point(0, 0)
        Me.gbReports.Name = "gbReports"
        Me.gbReports.Size = New System.Drawing.Size(604, 248)
        Me.gbReports.TabIndex = 1
        Me.gbReports.TabStop = False
        Me.gbReports.Text = "Report Title"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(3, 253)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'txtEmailBody
        '
        Me.txtEmailBody.Location = New System.Drawing.Point(132, 280)
        Me.txtEmailBody.Multiline = True
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(469, 252)
        Me.txtEmailBody.TabIndex = 3
        Me.txtEmailBody.Text = "Body:"
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Location = New System.Drawing.Point(3, 282)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(75, 47)
        Me.btnSendEmail.TabIndex = 4
        Me.btnSendEmail.Text = "Send Email to Selected Members"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'txtEmailSubject
        '
        Me.txtEmailSubject.Location = New System.Drawing.Point(132, 255)
        Me.txtEmailSubject.Name = "txtEmailSubject"
        Me.txtEmailSubject.Size = New System.Drawing.Size(469, 20)
        Me.txtEmailSubject.TabIndex = 5
        Me.txtEmailSubject.Text = "Upcoming Body of Christ Church Orientation on "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Body"
        '
        'NeedsOrientationReportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmailSubject)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Controls.Add(Me.txtEmailBody)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.gbReports)
        Me.Name = "NeedsOrientationReportControl"
        Me.Size = New System.Drawing.Size(607, 538)
        CType(Me.dgvReportData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReports.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReportData As System.Windows.Forms.DataGridView
    Friend WithEvents gbReports As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents txtEmailBody As System.Windows.Forms.TextBox
    Friend WithEvents btnSendEmail As System.Windows.Forms.Button
    Friend WithEvents txtEmailSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
