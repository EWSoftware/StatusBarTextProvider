Imports EWSoftware.StatusBarText

Public Class UserControlWithProvider
    Inherits System.Windows.Forms.UserControl

    Friend WithEvents sbMessage As EWSoftware.StatusBarText.StatusBarTextProvider
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox

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
        Me.components = New System.ComponentModel.Container
        Me.sbMessage = New EWSoftware.StatusBarText.StatusBarTextProvider(Me.components)
        Me.button1 = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(212, 64)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(24, 23)
        Me.sbMessage.SetStatusBarText(Me.button1, "Button in a user control")
        Me.button1.TabIndex = 3
        Me.button1.Text = "..."
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(108, 64)
        Me.textBox1.Name = "textBox1"
        Me.sbMessage.SetStatusBarText(Me.textBox1, "Text box in a user control")
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = ""
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(304, 40)
        Me.label1.TabIndex = 0
        Me.label1.Text = "User controls can contain their own status bar text provider as well."
        '
        'UserControlWithProvider
        '
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "UserControlWithProvider"
        Me.Size = New System.Drawing.Size(344, 96)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' The status bar text provider is exposed so that the parent can
    ' make adjustments to it.
    Public ReadOnly Property StatusBarTextProvider As StatusBarTextProvider
        Get
            Return sbMessage
        End Get
    End Property

End Class
