Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports EWSoftware.StatusBarText

Public Class Form1
    Inherits System.Windows.Forms.Form

    Friend WithEvents sbMessage As EWSoftware.StatusBarText.StatusBarTextProvider
    Friend WithEvents mainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents sbStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents sbTextPanel As System.Windows.Forms.StatusBarPanel
    Friend WithEvents statusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents gripSpacer As System.Windows.Forms.StatusBarPanel
    Friend WithEvents statusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem13 As System.Windows.Forms.MenuItem

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Tell the StatusBarTextProvider component the status bar to use
        StatusBarTextProvider.ApplicationStatusBar = sbStatusBar

        ' You can also use any panel you like.  The default is zero
        ' (the left-most panel).  For the demo, we'll use the one
        ' in the middle.
        StatusBarTextProvider.ApplicationDisplayPanel = 1
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
        Me.sbMessage = New EWSoftware.StatusBarText.StatusBarTextProvider(Me.components)
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.menuItem11 = New System.Windows.Forms.MenuItem
        Me.menuItem13 = New System.Windows.Forms.MenuItem
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem10 = New System.Windows.Forms.MenuItem
        Me.menuItem12 = New System.Windows.Forms.MenuItem
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.sbStatusBar = New System.Windows.Forms.StatusBar
        Me.statusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.sbTextPanel = New System.Windows.Forms.StatusBarPanel
        Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.gripSpacer = New System.Windows.Forms.StatusBarPanel
        CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbTextPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gripSpacer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.sbMessage.SetStatusBarText(Me.menuItem2, "Load a file of some sort")
        Me.menuItem2.Text = "&Load"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.sbMessage.SetStatusBarText(Me.menuItem3, "Save a file of some sort")
        Me.menuItem3.Text = "&Save"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 2
        Me.sbMessage.SetStatusBarText(Me.menuItem4, "Exit the application")
        Me.menuItem4.Text = "&Exit"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 0
        Me.sbMessage.SetStatusBarText(Me.menuItem6, "Open a new window")
        Me.menuItem6.Text = "&New"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 1
        Me.sbMessage.SetStatusBarText(Me.menuItem7, "View the window list")
        Me.menuItem7.Text = "&List"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 2
        Me.sbMessage.SetStatusBarText(Me.menuItem8, "Minimize the window")
        Me.menuItem8.Text = "&Minimize"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 3
        Me.sbMessage.SetStatusBarText(Me.menuItem9, "Maximize the window")
        Me.menuItem9.Text = "M&aximize"
        '
        'menuItem11
        '
        Me.menuItem11.Index = 0
        Me.sbMessage.SetStatusBarText(Me.menuItem11, "View copyright and contact information")
        Me.menuItem11.Text = "&About"
        '
        'menuItem13
        '
        Me.menuItem13.Index = 2
        Me.sbMessage.SetShowAsBlank(Me.menuItem13, True)
        Me.menuItem13.Text = "&Blank status text on this one"
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4})
        Me.sbMessage.SetStatusBarText(Me.menuItem1, "File related commands")
        Me.menuItem1.Text = "&File"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 1
        Me.menuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9})
        Me.sbMessage.SetStatusBarText(Me.menuItem5, "Window related commands")
        Me.menuItem5.Text = "&Window"
        '
        'menuItem10
        '
        Me.menuItem10.Index = 2
        Me.menuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem11, Me.menuItem12, Me.menuItem13})
        Me.sbMessage.SetShowAsBlank(Me.menuItem10, True)
        Me.menuItem10.Text = "&Help"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 1
        Me.menuItem12.Text = "-"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem5, Me.menuItem10})
        '
        'sbStatusBar
        '
        Me.sbStatusBar.Location = New System.Drawing.Point(0, 513)
        Me.sbStatusBar.Name = "sbStatusBar"
        Me.sbStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel2, Me.sbTextPanel, Me.statusBarPanel1, Me.gripSpacer})
        Me.sbStatusBar.ShowPanels = True
        Me.sbStatusBar.Size = New System.Drawing.Size(816, 22)
        Me.sbStatusBar.TabIndex = 0
        '
        'statusBarPanel2
        '
        Me.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.statusBarPanel2.Text = "Test"
        Me.statusBarPanel2.Width = 41
        '
        'sbTextPanel
        '
        Me.sbTextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.sbTextPanel.Text = "Ready"
        Me.sbTextPanel.Width = 708
        '
        'statusBarPanel1
        '
        Me.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.statusBarPanel1.Text = "Test"
        Me.statusBarPanel1.Width = 41
        '
        'gripSpacer
        '
        Me.gripSpacer.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.gripSpacer.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.gripSpacer.Width = 10
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(816, 535)
        Me.Controls.Add(Me.sbStatusBar)
        Me.IsMdiContainer = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "StatusBarTextProvider Demo"
        CType(Me.statusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbTextPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gripSpacer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Show the test forms with a bunch of controls as an MDI child
    Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) _
      Handles menuItem2.Click
        Dim mdiForm As New Form2()
        mdiForm.MdiParent = Me
        mdiForm.Show()
    End Sub

    ' Show the test forms with a bunch of controls as a modal dialog
    Private Sub menuItem11_Click(sender As Object, e As System.EventArgs) _
      Handles menuItem11.Click
        Dim dlg As New Form2()
        dlg.ShowDialog()
        dlg.Dispose()
    End Sub

    ' Exit the application
    Private Sub menuItem4_Click(sender As Object, e As System.EventArgs) _
      Handles menuItem4.Click
        Me.Close()
    End Sub

End Class
