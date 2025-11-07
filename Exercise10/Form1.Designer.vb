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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReadSort = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblInstruction.Location = New System.Drawing.Point(12, 136)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(255, 118)
        Me.lblInstruction.TabIndex = 0
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(12, 12)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(255, 121)
        Me.txtNumber.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(295, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 62)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(295, 80)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 62)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReadSort
        '
        Me.btnReadSort.Location = New System.Drawing.Point(295, 148)
        Me.btnReadSort.Name = "btnReadSort"
        Me.btnReadSort.Size = New System.Drawing.Size(136, 62)
        Me.btnReadSort.TabIndex = 4
        Me.btnReadSort.Text = "SORT"
        Me.btnReadSort.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(12, 302)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(255, 121)
        Me.lstNumbers.TabIndex = 5
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.Location = New System.Drawing.Point(277, 302)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(255, 117)
        Me.lblResult.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnReadSort)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReadSort As Button
    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents lblResult As Label
End Class
