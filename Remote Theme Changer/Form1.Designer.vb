<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gridPCList = New System.Windows.Forms.DataGridView()
        Me.colPCList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        CType(Me.gridPCList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridPCList
        '
        Me.gridPCList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPCList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPCList})
        Me.gridPCList.Location = New System.Drawing.Point(12, 12)
        Me.gridPCList.Name = "gridPCList"
        Me.gridPCList.Size = New System.Drawing.Size(387, 238)
        Me.gridPCList.TabIndex = 2
        '
        'colPCList
        '
        Me.colPCList.HeaderText = "PC Name"
        Me.colPCList.Name = "colPCList"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(405, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Location = New System.Drawing.Point(435, 236)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(32, 13)
        Me.lblHelp.TabIndex = 4
        Me.lblHelp.Text = "Help!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 262)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.gridPCList)
        Me.Name = "Form1"
        Me.Text = "Remote Theme Changer"
        CType(Me.gridPCList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridPCList As System.Windows.Forms.DataGridView
    Friend WithEvents colPCList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblHelp As System.Windows.Forms.Label

End Class
