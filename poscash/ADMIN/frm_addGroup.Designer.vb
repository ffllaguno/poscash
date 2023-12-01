<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addGroup
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
        Label1 = New Label()
        txtGroup = New TextBox()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 21)
        Label1.TabIndex = 0
        Label1.Text = "Enter New Group"
        ' 
        ' txtGroup
        ' 
        txtGroup.Location = New Point(62, 68)
        txtGroup.Name = "txtGroup"
        txtGroup.Size = New Size(125, 29)
        txtGroup.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(64, 116)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' frm_addGroup
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 184)
        Controls.Add(btnSave)
        Controls.Add(txtGroup)
        Controls.Add(Label1)
        Name = "frm_addGroup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Produc Group"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents btnSave As Button
End Class
