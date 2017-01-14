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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Input = New System.Windows.Forms.ListBox()
        Me.Output = New System.Windows.Forms.ListBox()
        Me.Import = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.FormattingEnabled = True
        Me.Input.Location = New System.Drawing.Point(46, 32)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(146, 446)
        Me.Input.TabIndex = 0
        '
        'Output
        '
        Me.Output.FormattingEnabled = True
        Me.Output.Location = New System.Drawing.Point(439, 32)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(146, 446)
        Me.Output.TabIndex = 1
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(76, 484)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(75, 23)
        Me.Import.TabIndex = 2
        Me.Import.Text = "Import"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(274, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 68)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(274, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 68)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 534)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Import)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Input)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SellyOG Checker by Shadow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Input As ListBox
    Friend WithEvents Output As ListBox
    Friend WithEvents Import As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
