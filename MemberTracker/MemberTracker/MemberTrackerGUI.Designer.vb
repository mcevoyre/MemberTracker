<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberTracker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(memberTracker))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiConfiguration = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeedsOrientationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbBOCC = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.WelcomeControl1 = New WelcomeControl()
        Me.ReportsControl1 = New ReportsControl()
        Me.Maintain_Members1 = New Maintain_Members()
        Me.Configuration1 = New Configuration()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbBOCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintainMembersToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiConfiguration})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'tsmiConfiguration
        '
        Me.tsmiConfiguration.Name = "tsmiConfiguration"
        Me.tsmiConfiguration.Size = New System.Drawing.Size(148, 22)
        Me.tsmiConfiguration.Text = "Configuration"
        '
        'MaintainMembersToolStripMenuItem
        '
        Me.MaintainMembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAddEdit})
        Me.MaintainMembersToolStripMenuItem.Name = "MaintainMembersToolStripMenuItem"
        Me.MaintainMembersToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.MaintainMembersToolStripMenuItem.Text = "Maintain Members"
        '
        'tsmiAddEdit
        '
        Me.tsmiAddEdit.Name = "tsmiAddEdit"
        Me.tsmiAddEdit.Size = New System.Drawing.Size(180, 22)
        Me.tsmiAddEdit.Text = "Add / Edit Members"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeedsOrientationToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'NeedsOrientationToolStripMenuItem
        '
        Me.NeedsOrientationToolStripMenuItem.Name = "NeedsOrientationToolStripMenuItem"
        Me.NeedsOrientationToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NeedsOrientationToolStripMenuItem.Text = "Needs Orientation"
        '
        'pbBOCC
        '
        Me.pbBOCC.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBOCC.Image = CType(resources.GetObject("pbBOCC.Image"), System.Drawing.Image)
        Me.pbBOCC.Location = New System.Drawing.Point(0, 24)
        Me.pbBOCC.Name = "pbBOCC"
        Me.pbBOCC.Size = New System.Drawing.Size(784, 174)
        Me.pbBOCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbBOCC.TabIndex = 3
        Me.pbBOCC.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.WelcomeControl1)
        Me.pnlMain.Controls.Add(Me.ReportsControl1)
        Me.pnlMain.Controls.Add(Me.Maintain_Members1)
        Me.pnlMain.Controls.Add(Me.Configuration1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 198)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(784, 414)
        Me.pnlMain.TabIndex = 4
        '
        'WelcomeControl1
        '
        Me.WelcomeControl1.Location = New System.Drawing.Point(23, 183)
        Me.WelcomeControl1.Name = "WelcomeControl1"
        Me.WelcomeControl1.Size = New System.Drawing.Size(642, 113)
        Me.WelcomeControl1.TabIndex = 3
        '
        'ReportsControl1
        '
        Me.ReportsControl1.Location = New System.Drawing.Point(390, 40)
        Me.ReportsControl1.Name = "ReportsControl1"
        Me.ReportsControl1.Size = New System.Drawing.Size(368, 256)
        Me.ReportsControl1.TabIndex = 2
        '
        'Maintain_Members1
        '
        Me.Maintain_Members1.Location = New System.Drawing.Point(318, 67)
        Me.Maintain_Members1.Member_HouseHolds = Nothing
        Me.Maintain_Members1.Name = "Maintain_Members1"
        Me.Maintain_Members1.Size = New System.Drawing.Size(608, 512)
        Me.Maintain_Members1.TabIndex = 1
        '
        'Configuration1
        '
        Me.Configuration1.FilePath = "Select File"
        Me.Configuration1.Location = New System.Drawing.Point(3, 16)
        Me.Configuration1.Name = "Configuration1"
        Me.Configuration1.Size = New System.Drawing.Size(296, 91)
        Me.Configuration1.TabIndex = 0
        '
        'memberTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 612)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pbBOCC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(650, 650)
        Me.Name = "memberTracker"
        Me.Text = "Member Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbBOCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiConfiguration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbBOCC As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Configuration1 As Configuration
    Friend WithEvents Maintain_Members1 As Maintain_Members
    Friend WithEvents NeedsOrientationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsControl1 As ReportsControl
    Friend WithEvents WelcomeControl1 As WelcomeControl

End Class
