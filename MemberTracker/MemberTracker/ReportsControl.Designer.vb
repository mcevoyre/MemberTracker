<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsControl
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
        Me.dgvReportData.Size = New System.Drawing.Size(362, 237)
        Me.dgvReportData.TabIndex = 0
        '
        'gbReports
        '
        Me.gbReports.Controls.Add(Me.dgvReportData)
        Me.gbReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbReports.Location = New System.Drawing.Point(0, 0)
        Me.gbReports.Name = "gbReports"
        Me.gbReports.Size = New System.Drawing.Size(368, 256)
        Me.gbReports.TabIndex = 1
        Me.gbReports.TabStop = False
        Me.gbReports.Text = "Report Title"
        '
        'ReportsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbReports)
        Me.Name = "ReportsControl"
        Me.Size = New System.Drawing.Size(368, 256)
        CType(Me.dgvReportData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvReportData As System.Windows.Forms.DataGridView
    Friend WithEvents gbReports As System.Windows.Forms.GroupBox

End Class
