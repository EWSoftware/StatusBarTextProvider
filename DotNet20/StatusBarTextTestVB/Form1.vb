Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports EWSoftware.StatusBarText

Public Class Form1
    Inherits System.Windows.Forms.Form

    Friend WithEvents sbMessage As EWSoftware.StatusBarText.StatusBarTextProvider
    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents loadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents windowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents listToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents minimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents blankStatusTextOnThisOneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslStatusText As ToolStripStatusLabel
    Friend WithEvents tslProgressNote As ToolStripStatusLabel
    Friend WithEvents tspbProgressBar As ToolStripProgressBar
    Friend WithEvents toolStrip1 As ToolStrip
    Friend WithEvents toolStripButton1 As ToolStripButton
    Friend WithEvents toolStripLabel1 As ToolStripLabel
    Friend WithEvents toolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents test1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents test2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents test3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents test1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents test2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents test3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripComboBox1 As ToolStripComboBox
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents toolStripTextBox1 As ToolStripTextBox

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Tell the StatusBarTextProvider component the component
        ' to use to display the text.  When using a tool strip
        ' component, the ApplicationDisplayPanel property is ignored.
        StatusBarTextProvider.ApplicationStatusBar = tslStatusText

        ' Define the status label and progress bar too.  This allows
        ' easy access to those items from anywhere within the
        ' application.
        StatusBarTextProvider.StatusLabel = tslProgressNote
        StatusBarTextProvider.ProgressBar = tspbProgressBar
    End Sub

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sbMessage = New EWSoftware.StatusBarText.StatusBarTextProvider(Me.components)
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.loadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.windowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.listToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.minimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.maximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.blankStatusTextOnThisOneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.test3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.test1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.test2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.test3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.toolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.tslProgressNote = New System.Windows.Forms.ToolStripStatusLabel
        Me.tspbProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tslStatusText = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.menuStrip1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loadToolStripMenuItem, Me.saveToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.sbMessage.SetStatusBarText(Me.fileToolStripMenuItem, "File related commands")
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'loadToolStripMenuItem
        '
        Me.loadToolStripMenuItem.Name = "loadToolStripMenuItem"
        Me.loadToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.sbMessage.SetStatusBarText(Me.loadToolStripMenuItem, "Load a file of some sort")
        Me.loadToolStripMenuItem.Text = "&Load"
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.sbMessage.SetStatusBarText(Me.saveToolStripMenuItem, "Save a file of some sort")
        Me.saveToolStripMenuItem.Text = "&Save"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.sbMessage.SetStatusBarText(Me.exitToolStripMenuItem, "Exit the application")
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'windowToolStripMenuItem
        '
        Me.windowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.listToolStripMenuItem, Me.minimizeToolStripMenuItem, Me.maximizeToolStripMenuItem})
        Me.windowToolStripMenuItem.Name = "windowToolStripMenuItem"
        Me.windowToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.sbMessage.SetStatusBarText(Me.windowToolStripMenuItem, "Window related commands")
        Me.windowToolStripMenuItem.Text = "&Window"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.sbMessage.SetStatusBarText(Me.newToolStripMenuItem, "Open a new window")
        Me.newToolStripMenuItem.Text = "&New"
        '
        'listToolStripMenuItem
        '
        Me.listToolStripMenuItem.Name = "listToolStripMenuItem"
        Me.listToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.sbMessage.SetStatusBarText(Me.listToolStripMenuItem, "View the window list")
        Me.listToolStripMenuItem.Text = "&List"
        '
        'minimizeToolStripMenuItem
        '
        Me.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem"
        Me.minimizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.sbMessage.SetStatusBarText(Me.minimizeToolStripMenuItem, "Minimize the window")
        Me.minimizeToolStripMenuItem.Text = "&Minimize"
        '
        'maximizeToolStripMenuItem
        '
        Me.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem"
        Me.maximizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.sbMessage.SetStatusBarText(Me.maximizeToolStripMenuItem, "Maximize the window")
        Me.maximizeToolStripMenuItem.Text = "M&aximize"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem, Me.toolStripMenuItem1, Me.blankStatusTextOnThisOneToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.sbMessage.SetShowAsBlank(Me.helpToolStripMenuItem, True)
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.helpToolStripMenuItem.Text = "&Help"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.sbMessage.SetStatusBarText(Me.aboutToolStripMenuItem, "View copyright and contact information")
        Me.aboutToolStripMenuItem.Text = "&About..."
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(254, 6)
        '
        'blankStatusTextOnThisOneToolStripMenuItem
        '
        Me.blankStatusTextOnThisOneToolStripMenuItem.Name = "blankStatusTextOnThisOneToolStripMenuItem"
        Me.sbMessage.SetShowAsBlank(Me.blankStatusTextOnThisOneToolStripMenuItem, True)
        Me.blankStatusTextOnThisOneToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.blankStatusTextOnThisOneToolStripMenuItem.Text = "&Blank status text on this one"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.sbMessage.SetStatusBarText(Me.toolStripButton1, "A toolstrip button")
        Me.toolStripButton1.Text = "toolStripButton1"
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(73, 23)
        Me.sbMessage.SetStatusBarText(Me.toolStripLabel1, "A toolstrip label")
        Me.toolStripLabel1.Text = "Enter Text"
        '
        'toolStripSplitButton1
        '
        Me.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.test1ToolStripMenuItem, Me.test2ToolStripMenuItem, Me.test3ToolStripMenuItem})
        Me.toolStripSplitButton1.Image = CType(resources.GetObject("toolStripSplitButton1.Image"), System.Drawing.Image)
        Me.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
        Me.toolStripSplitButton1.Size = New System.Drawing.Size(32, 23)
        Me.sbMessage.SetStatusBarText(Me.toolStripSplitButton1, "A toolstrip split button")
        Me.toolStripSplitButton1.Text = "toolStripSplitButton1"
        '
        'test1ToolStripMenuItem
        '
        Me.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem"
        Me.test1ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test1ToolStripMenuItem, "Split dropdown button item #1")
        Me.test1ToolStripMenuItem.Text = "Test 1"
        '
        'test2ToolStripMenuItem
        '
        Me.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem"
        Me.test2ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test2ToolStripMenuItem, "Split dropdown button item #2")
        Me.test2ToolStripMenuItem.Text = "Test 2"
        '
        'test3ToolStripMenuItem
        '
        Me.test3ToolStripMenuItem.Name = "test3ToolStripMenuItem"
        Me.test3ToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test3ToolStripMenuItem, "Split dropdown button item #3")
        Me.test3ToolStripMenuItem.Text = "Test 3"
        '
        'toolStripDropDownButton1
        '
        Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.test1ToolStripMenuItem1, Me.test2ToolStripMenuItem1, Me.test3ToolStripMenuItem1})
        Me.toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
        Me.toolStripDropDownButton1.Size = New System.Drawing.Size(29, 23)
        Me.sbMessage.SetStatusBarText(Me.toolStripDropDownButton1, "A toolstrip dropdown button")
        Me.toolStripDropDownButton1.Text = "toolStripDropDownButton1"
        '
        'test1ToolStripMenuItem1
        '
        Me.test1ToolStripMenuItem1.Name = "test1ToolStripMenuItem1"
        Me.test1ToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test1ToolStripMenuItem1, "Dropdown button item #1")
        Me.test1ToolStripMenuItem1.Text = "Test 1"
        '
        'test2ToolStripMenuItem1
        '
        Me.test2ToolStripMenuItem1.Name = "test2ToolStripMenuItem1"
        Me.test2ToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test2ToolStripMenuItem1, "Dropdown button item #2")
        Me.test2ToolStripMenuItem1.Text = "Test 2"
        '
        'test3ToolStripMenuItem1
        '
        Me.test3ToolStripMenuItem1.Name = "test3ToolStripMenuItem1"
        Me.test3ToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.test3ToolStripMenuItem1, "Dropdown button item #3")
        Me.test3ToolStripMenuItem1.Text = "Test 3"
        '
        'toolStripComboBox1
        '
        Me.toolStripComboBox1.Items.AddRange(New Object() {"Item #1", "Item #2", "Item #3", "Item #4"})
        Me.toolStripComboBox1.Name = "toolStripComboBox1"
        Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.sbMessage.SetStatusBarText(Me.toolStripComboBox1, "A toolstrip combo box")
        '
        'toolStripTextBox1
        '
        Me.toolStripTextBox1.Name = "toolStripTextBox1"
        Me.toolStripTextBox1.Size = New System.Drawing.Size(150, 26)
        Me.sbMessage.SetStatusBarText(Me.toolStripTextBox1, "A toolstrip text box")
        Me.toolStripTextBox1.Text = "Toolstrip text box"
        '
        'tslProgressNote
        '
        Me.tslProgressNote.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.tslProgressNote.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.tslProgressNote.Margin = New System.Windows.Forms.Padding(0)
        Me.tslProgressNote.Name = "tslProgressNote"
        Me.tslProgressNote.Size = New System.Drawing.Size(4, 27)
        Me.sbMessage.SetStatusBarText(Me.tslProgressNote, "Progress message")
        Me.tslProgressNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tspbProgressBar
        '
        Me.tspbProgressBar.Name = "tspbProgressBar"
        Me.tspbProgressBar.Size = New System.Drawing.Size(100, 21)
        Me.sbMessage.SetStatusBarText(Me.tspbProgressBar, "Progress bar")
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.windowToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(816, 25)
        Me.menuStrip1.TabIndex = 2
        Me.menuStrip1.Text = "menuStrip1"
        '
        'statusStrip1
        '
        Me.statusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.tslStatusText, Me.tslProgressNote, Me.tspbProgressBar})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(816, 27)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(40, 27)
        Me.toolStripStatusLabel1.Text = "Test"
        '
        'tslStatusText
        '
        Me.tslStatusText.Name = "tslStatusText"
        Me.tslStatusText.Size = New System.Drawing.Size(655, 22)
        Me.tslStatusText.Spring = True
        Me.tslStatusText.Text = "Ready"
        Me.tslStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolStrip1
        '
        Me.toolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripSeparator2, Me.toolStripSplitButton1, Me.toolStripDropDownButton1, Me.toolStripSeparator1, Me.toolStripComboBox1, Me.toolStripSeparator3, Me.toolStripLabel1, Me.toolStripTextBox1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(816, 26)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.Text = "StatusBarTextProvider Demo"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Show the test forms with a bunch of controls as an MDI child
    Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) _
      Handles loadToolStripMenuItem.Click
        Dim mdiForm As New Form2()
        mdiForm.MdiParent = Me
        mdiForm.Show()
    End Sub

    ' Show the test forms with a bunch of controls as a modal dialog
    Private Sub menuItem11_Click(sender As Object, e As System.EventArgs) _
      Handles aboutToolStripMenuItem.Click
        Dim dlg As New Form2()
        dlg.ShowDialog()
        dlg.Dispose()
    End Sub

    ' Exit the application
    Private Sub menuItem4_Click(sender As Object, e As System.EventArgs) _
      Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
