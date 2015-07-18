<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomReportControl
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chkArchive = New System.Windows.Forms.CheckBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.btnToSource = New System.Windows.Forms.Button()
        Me.btnToBottom = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnToTop = New System.Windows.Forms.Button()
        Me.btnToOutput = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.lbSource = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpStopDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.dgvReportOutput = New System.Windows.Forms.DataGridView()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnDeSelectAll = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReportOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDeSelectAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMoveAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkArchive)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkActive)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnToSource)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnToBottom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDown)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnToTop)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnToOutput)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbOutput)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbSource)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGenerateReport)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvReportOutput)
        Me.SplitContainer1.Size = New System.Drawing.Size(742, 447)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 0
        '
        'chkArchive
        '
        Me.chkArchive.AutoSize = True
        Me.chkArchive.Location = New System.Drawing.Point(131, 303)
        Me.chkArchive.Name = "chkArchive"
        Me.chkArchive.Size = New System.Drawing.Size(92, 17)
        Me.chkArchive.TabIndex = 14
        Me.chkArchive.Text = "Archive Only?"
        Me.chkArchive.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(12, 303)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(86, 17)
        Me.chkActive.TabIndex = 13
        Me.chkActive.Text = "Active Only?"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'btnToSource
        '
        Me.btnToSource.Location = New System.Drawing.Point(133, 125)
        Me.btnToSource.Name = "btnToSource"
        Me.btnToSource.Size = New System.Drawing.Size(28, 23)
        Me.btnToSource.TabIndex = 12
        Me.btnToSource.Text = "<"
        Me.btnToSource.UseVisualStyleBackColor = True
        '
        'btnToBottom
        '
        Me.btnToBottom.Location = New System.Drawing.Point(294, 154)
        Me.btnToBottom.Name = "btnToBottom"
        Me.btnToBottom.Size = New System.Drawing.Size(28, 23)
        Me.btnToBottom.TabIndex = 11
        Me.btnToBottom.Text = "vv"
        Me.btnToBottom.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(294, 125)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(28, 23)
        Me.btnDown.TabIndex = 10
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(294, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(28, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "x"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(294, 67)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(28, 23)
        Me.btnUp.TabIndex = 8
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnToTop
        '
        Me.btnToTop.Location = New System.Drawing.Point(294, 38)
        Me.btnToTop.Name = "btnToTop"
        Me.btnToTop.Size = New System.Drawing.Size(28, 23)
        Me.btnToTop.TabIndex = 7
        Me.btnToTop.Text = "^^"
        Me.btnToTop.UseVisualStyleBackColor = True
        '
        'btnToOutput
        '
        Me.btnToOutput.Location = New System.Drawing.Point(133, 96)
        Me.btnToOutput.Name = "btnToOutput"
        Me.btnToOutput.Size = New System.Drawing.Size(28, 23)
        Me.btnToOutput.TabIndex = 6
        Me.btnToOutput.Text = ">"
        Me.btnToOutput.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.Location = New System.Drawing.Point(166, 3)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbOutput.Size = New System.Drawing.Size(125, 212)
        Me.lbOutput.TabIndex = 5
        '
        'lbSource
        '
        Me.lbSource.FormattingEnabled = True
        Me.lbSource.Items.AddRange(New Object() {"First Name", "Last Name", "Date of Birth", "Age", "Spouse", "Anniversary Date", "Baptized", "Salvation", "Share Information", "Ministry Topic", "Attended Orientation", "Orientation Date", "Pastor COntact", "Notes", "Active", "Archived", "Address", "Cell Phone", "City", "Email Address", "Home Phone", "Household ID", "Date Joined Church", "State", "Zip Code", "Picture Location"})
        Me.lbSource.Location = New System.Drawing.Point(3, 3)
        Me.lbSource.Name = "lbSource"
        Me.lbSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbSource.Size = New System.Drawing.Size(125, 212)
        Me.lbSource.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpStopDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 65)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Members who joined between:"
        '
        'dtpStopDate
        '
        Me.dtpStopDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStopDate.Location = New System.Drawing.Point(125, 28)
        Me.dtpStopDate.Name = "dtpStopDate"
        Me.dtpStopDate.ShowCheckBox = True
        Me.dtpStopDate.Size = New System.Drawing.Size(113, 20)
        Me.dtpStopDate.TabIndex = 1
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(6, 28)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(113, 20)
        Me.dtpStartDate.TabIndex = 0
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(104, 327)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(95, 23)
        Me.btnGenerateReport.TabIndex = 2
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'dgvReportOutput
        '
        Me.dgvReportOutput.AllowUserToAddRows = False
        Me.dgvReportOutput.AllowUserToDeleteRows = False
        Me.dgvReportOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportOutput.Location = New System.Drawing.Point(0, 0)
        Me.dgvReportOutput.Name = "dgvReportOutput"
        Me.dgvReportOutput.Size = New System.Drawing.Size(413, 447)
        Me.dgvReportOutput.TabIndex = 0
        '
        'btnMoveAll
        '
        Me.btnMoveAll.Location = New System.Drawing.Point(132, 67)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(28, 23)
        Me.btnMoveAll.TabIndex = 15
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = True
        '
        'btnDeSelectAll
        '
        Me.btnDeSelectAll.Location = New System.Drawing.Point(133, 154)
        Me.btnDeSelectAll.Name = "btnDeSelectAll"
        Me.btnDeSelectAll.Size = New System.Drawing.Size(28, 23)
        Me.btnDeSelectAll.TabIndex = 16
        Me.btnDeSelectAll.Text = "<<"
        Me.btnDeSelectAll.UseVisualStyleBackColor = True
        '
        'CustomReportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CustomReportControl"
        Me.Size = New System.Drawing.Size(742, 447)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvReportOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnToBottom As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnToTop As System.Windows.Forms.Button
    Friend WithEvents btnToOutput As System.Windows.Forms.Button
    Friend WithEvents lbOutput As System.Windows.Forms.ListBox
    Friend WithEvents lbSource As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents dgvReportOutput As System.Windows.Forms.DataGridView
    Friend WithEvents dtpStopDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnToSource As System.Windows.Forms.Button
    Friend WithEvents chkArchive As System.Windows.Forms.CheckBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll As System.Windows.Forms.Button

End Class
