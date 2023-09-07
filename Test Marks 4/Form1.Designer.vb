<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtResults = New Button()
        Label1 = New Label()
        txtMarks = New TextBox()
        SuspendLayout()
        ' 
        ' txtResults
        ' 
        txtResults.Location = New Point(217, 221)
        txtResults.Name = "txtResults"
        txtResults.Size = New Size(173, 37)
        txtResults.TabIndex = 0
        txtResults.Text = "Results"
        txtResults.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your marks"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(298, 101)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(217, 31)
        txtMarks.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMarks)
        Controls.Add(Label1)
        Controls.Add(txtResults)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResults As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMarks As TextBox
End Class
