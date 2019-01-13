Public Class DemoUserControl
    Inherits System.Windows.Forms.UserControl

    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents button1 As System.Windows.Forms.Button

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(3, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = ""
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(107, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(24, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "..."
        '
        'DemoUserControl
        '
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "DemoUserControl"
        Me.Size = New System.Drawing.Size(136, 32)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
