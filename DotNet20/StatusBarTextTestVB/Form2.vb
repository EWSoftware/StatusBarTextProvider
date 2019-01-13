Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports EWSoftware.StatusBarText

Public Class Form2
    Inherits System.Windows.Forms.Form

    Friend WithEvents sbMessage As EWSoftware.StatusBarText.StatusBarTextProvider
    Friend WithEvents tabDemo As System.Windows.Forms.TabControl
    Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents udDomain As System.Windows.Forms.DomainUpDown
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents chkTest As System.Windows.Forms.CheckBox
    Friend WithEvents lbCheckedLB As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents lnkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents lbListBox As System.Windows.Forms.ListBox
    Friend WithEvents lvListView As System.Windows.Forms.ListView
    Friend WithEvents tabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents tvTree As System.Windows.Forms.TreeView
    Friend WithEvents monthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkUseDialog As System.Windows.Forms.CheckBox
    Friend WithEvents sbDialog As System.Windows.Forms.StatusBar
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents tabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents demoUserControl1 As DemoUserControl
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents btnProgress As System.Windows.Forms.Button
    Friend WithEvents ucDemo As UserControlWithProvider

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Dim al As New ArrayList()

        al.Add(New ListItem(1, "Item #1"))
        al.Add(New ListItem(2, "Item #2"))
        al.Add(New ListItem(3, "Item #3"))
        al.Add(New ListItem(4, "Item #4"))
        dataGrid1.DataSource = al
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
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item 1")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item 2")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item 3")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Item 4")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Me.sbMessage = New EWSoftware.StatusBarText.StatusBarTextProvider(Me.components)
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.lvListView = New System.Windows.Forms.ListView
        Me.lbListBox = New System.Windows.Forms.ListBox
        Me.lnkLabel = New System.Windows.Forms.LinkLabel
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker
        Me.dataGrid1 = New System.Windows.Forms.DataGrid
        Me.cboComboBox = New System.Windows.Forms.ComboBox
        Me.lbCheckedLB = New System.Windows.Forms.CheckedListBox
        Me.chkTest = New System.Windows.Forms.CheckBox
        Me.udDomain = New System.Windows.Forms.DomainUpDown
        Me.btnClose = New System.Windows.Forms.Button
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.monthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label5 = New System.Windows.Forms.Label
        Me.rb2 = New System.Windows.Forms.RadioButton
        Me.rb1 = New System.Windows.Forms.RadioButton
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.chkUseDialog = New System.Windows.Forms.CheckBox
        Me.demoUserControl1 = New StatusBarTextTestVB.DemoUserControl
        Me.panel2 = New System.Windows.Forms.Panel
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label9 = New System.Windows.Forms.Label
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.panel1 = New System.Windows.Forms.Panel
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.label7 = New System.Windows.Forms.Label
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label6 = New System.Windows.Forms.Label
        Me.tvTree = New System.Windows.Forms.TreeView
        Me.tabPage4 = New System.Windows.Forms.TabPage
        Me.ucDemo = New StatusBarTextTestVB.UserControlWithProvider
        Me.label8 = New System.Windows.Forms.Label
        Me.tabDemo = New System.Windows.Forms.TabControl
        Me.sbDialog = New System.Windows.Forms.StatusBar
        Me.btnProgress = New System.Windows.Forms.Button
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tabPage4.SuspendLayout()
        Me.tabDemo.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbMessage
        '
        Me.sbMessage.InstanceDefaultText = Nothing
        Me.sbMessage.InstanceDisplayPanel = 0
        Me.sbMessage.InstanceStatusBar = Nothing
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(248, 304)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(168, 22)
        Me.sbMessage.SetStatusBarText(Me.textBox1, "A standard text box control")
        Me.textBox1.TabIndex = 15
        Me.textBox1.Text = "Standard text box"
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(440, 240)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.sbMessage.SetStatusBarText(Me.richTextBox1, "A rich text box control")
        Me.richTextBox1.TabIndex = 14
        Me.richTextBox1.Text = "A rich text box"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(144, 56)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(72, 22)
        Me.sbMessage.SetStatusBarText(Me.numericUpDown1, "A numeric up/down control")
        Me.numericUpDown1.TabIndex = 5
        '
        'lvListView
        '
        Me.lvListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.lvListView.Location = New System.Drawing.Point(16, 240)
        Me.lvListView.Name = "lvListView"
        Me.lvListView.Size = New System.Drawing.Size(184, 80)
        Me.sbMessage.SetStatusBarText(Me.lvListView, "A list view control")
        Me.lvListView.TabIndex = 11
        Me.lvListView.UseCompatibleStateImageBehavior = False
        Me.lvListView.View = System.Windows.Forms.View.List
        '
        'lbListBox
        '
        Me.lbListBox.ItemHeight = 16
        Me.lbListBox.Items.AddRange(New Object() {"Item 1", "Item 2", "Item 3", "Item 4"})
        Me.lbListBox.Location = New System.Drawing.Point(24, 96)
        Me.lbListBox.Name = "lbListBox"
        Me.lbListBox.Size = New System.Drawing.Size(128, 84)
        Me.sbMessage.SetStatusBarText(Me.lbListBox, "A list box control")
        Me.lbListBox.TabIndex = 8
        '
        'lnkLabel
        '
        Me.lnkLabel.Location = New System.Drawing.Point(328, 256)
        Me.lnkLabel.Name = "lnkLabel"
        Me.lnkLabel.Size = New System.Drawing.Size(88, 16)
        Me.sbMessage.SetStatusBarText(Me.lnkLabel, "A link label")
        Me.lnkLabel.TabIndex = 13
        Me.lnkLabel.TabStop = True
        Me.lnkLabel.Text = "A Link Label"
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTime.Location = New System.Drawing.Point(376, 56)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(104, 22)
        Me.sbMessage.SetStatusBarText(Me.dtpDateTime, "A date/time picker")
        Me.dtpDateTime.TabIndex = 7
        '
        'dataGrid1
        '
        Me.dataGrid1.CaptionText = "DataGrid"
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(376, 96)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(208, 136)
        Me.sbMessage.SetStatusBarText(Me.dataGrid1, "A data grid control")
        Me.dataGrid1.TabIndex = 10
        '
        'cboComboBox
        '
        Me.cboComboBox.Items.AddRange(New Object() {"Item 1", "Item 2", "Item 3", "Item 4"})
        Me.cboComboBox.Location = New System.Drawing.Point(104, 16)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(136, 24)
        Me.sbMessage.SetStatusBarText(Me.cboComboBox, "A combo box control")
        Me.cboComboBox.TabIndex = 1
        '
        'lbCheckedLB
        '
        Me.lbCheckedLB.Items.AddRange(New Object() {"Item 1", "Item 2", "Item 3", "Item 4"})
        Me.lbCheckedLB.Location = New System.Drawing.Point(240, 96)
        Me.lbCheckedLB.Name = "lbCheckedLB"
        Me.lbCheckedLB.Size = New System.Drawing.Size(120, 89)
        Me.sbMessage.SetStatusBarText(Me.lbCheckedLB, "A checked list box control")
        Me.lbCheckedLB.TabIndex = 9
        '
        'chkTest
        '
        Me.chkTest.Location = New System.Drawing.Point(216, 256)
        Me.chkTest.Name = "chkTest"
        Me.chkTest.Size = New System.Drawing.Size(104, 24)
        Me.sbMessage.SetStatusBarText(Me.chkTest, "A checkbox control")
        Me.chkTest.TabIndex = 12
        Me.chkTest.Text = "Checkbox"
        '
        'udDomain
        '
        Me.udDomain.Items.Add("Item 1")
        Me.udDomain.Items.Add("Item 2")
        Me.udDomain.Items.Add("Item 3")
        Me.udDomain.Items.Add("Item 4")
        Me.udDomain.Location = New System.Drawing.Point(376, 16)
        Me.udDomain.Name = "udDomain"
        Me.udDomain.Size = New System.Drawing.Size(120, 22)
        Me.sbMessage.SetStatusBarText(Me.udDomain, "A domain up/down control")
        Me.udDomain.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(528, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 32)
        Me.sbMessage.SetStatusBarText(Me.btnClose, "Close this dialog box")
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'propertyGrid1
        '
        Me.propertyGrid1.HelpVisible = False
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(20, 232)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.SelectedObject = Me
        Me.propertyGrid1.Size = New System.Drawing.Size(568, 120)
        Me.sbMessage.SetStatusBarText(Me.propertyGrid1, "A property grid control")
        Me.propertyGrid1.TabIndex = 1
        Me.propertyGrid1.ToolbarVisible = False
        '
        'monthCalendar1
        '
        Me.monthCalendar1.Location = New System.Drawing.Point(165, 15)
        Me.monthCalendar1.Name = "monthCalendar1"
        Me.sbMessage.SetStatusBarText(Me.monthCalendar1, "A month calendar control in a panel")
        Me.monthCalendar1.TabIndex = 0
        '
        'radioButton1
        '
        Me.radioButton1.Location = New System.Drawing.Point(16, 56)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(128, 24)
        Me.sbMessage.SetStatusBarText(Me.radioButton1, "Radio button 2 status bar text")
        Me.radioButton1.TabIndex = 1
        Me.radioButton1.Text = "Radio Button 2"
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(16, 24)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(128, 24)
        Me.sbMessage.SetStatusBarText(Me.radioButton2, "Radio button 1 status bar text")
        Me.radioButton2.TabIndex = 0
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Radio Button 1"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.rb2)
        Me.groupBox1.Controls.Add(Me.rb1)
        Me.groupBox1.Location = New System.Drawing.Point(336, 8)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(248, 160)
        Me.sbMessage.SetStatusBarText(Me.groupBox1, "A group box control")
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "A Group Box"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(8, 88)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(224, 64)
        Me.label5.TabIndex = 2
        Me.label5.Text = "The radio buttons in this group box have no status bar text so the group box's st" & _
            "atus bar text is shown instead."
        '
        'rb2
        '
        Me.rb2.Location = New System.Drawing.Point(16, 56)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(128, 24)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "Radio Button 2"
        '
        'rb1
        '
        Me.rb1.Location = New System.Drawing.Point(16, 24)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(128, 24)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "Radio Button 1"
        '
        'trackBar1
        '
        Me.trackBar1.Location = New System.Drawing.Point(52, 16)
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(256, 53)
        Me.sbMessage.SetStatusBarText(Me.trackBar1, "A track bar control")
        Me.trackBar1.TabIndex = 0
        '
        'chkUseDialog
        '
        Me.chkUseDialog.Location = New System.Drawing.Point(32, 408)
        Me.chkUseDialog.Name = "chkUseDialog"
        Me.chkUseDialog.Size = New System.Drawing.Size(200, 24)
        Me.sbMessage.SetStatusBarText(Me.chkUseDialog, "Switch between the application status bar and the dialog's status bar")
        Me.chkUseDialog.TabIndex = 1
        Me.chkUseDialog.Text = "&Use the dialog's status bar"
        '
        'demoUserControl1
        '
        Me.demoUserControl1.Location = New System.Drawing.Point(32, 200)
        Me.demoUserControl1.Name = "demoUserControl1"
        Me.demoUserControl1.Size = New System.Drawing.Size(136, 32)
        Me.sbMessage.SetStatusBarText(Me.demoUserControl1, "A custom user control")
        Me.demoUserControl1.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.textBox2)
        Me.panel2.Controls.Add(Me.checkBox1)
        Me.panel2.Controls.Add(Me.label9)
        Me.panel2.Location = New System.Drawing.Point(24, 16)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(424, 120)
        Me.sbMessage.SetStatusBarText(Me.panel2, "A panel control")
        Me.panel2.TabIndex = 0
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(184, 72)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(88, 22)
        Me.textBox2.TabIndex = 2
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(24, 72)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(104, 24)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "checkBox1"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(16, 16)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(392, 40)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Like the group box, if controls in a panel do not have status bar text, the text " & _
            "for the panel is displayed."
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.textBox1)
        Me.tabPage1.Controls.Add(Me.richTextBox1)
        Me.tabPage1.Controls.Add(Me.numericUpDown1)
        Me.tabPage1.Controls.Add(Me.label4)
        Me.tabPage1.Controls.Add(Me.lvListView)
        Me.tabPage1.Controls.Add(Me.lbListBox)
        Me.tabPage1.Controls.Add(Me.lnkLabel)
        Me.tabPage1.Controls.Add(Me.label3)
        Me.tabPage1.Controls.Add(Me.dtpDateTime)
        Me.tabPage1.Controls.Add(Me.dataGrid1)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Controls.Add(Me.cboComboBox)
        Me.tabPage1.Controls.Add(Me.lbCheckedLB)
        Me.tabPage1.Controls.Add(Me.chkTest)
        Me.tabPage1.Controls.Add(Me.label1)
        Me.tabPage1.Controls.Add(Me.udDomain)
        Me.tabPage1.Location = New System.Drawing.Point(4, 25)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(608, 363)
        Me.sbMessage.SetStatusBarText(Me.tabPage1, "Tab page #1")
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Tab 1"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 56)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(120, 22)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Numeric Up/Down"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(248, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(120, 22)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Date/Time Picker"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(8, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 22)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Combo Box"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(248, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(120, 22)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Domain Up/Down"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.propertyGrid1)
        Me.tabPage2.Controls.Add(Me.panel1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 25)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(608, 363)
        Me.sbMessage.SetStatusBarText(Me.tabPage2, "Tab page #2")
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Tab 2"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.monthCalendar1)
        Me.panel1.Location = New System.Drawing.Point(28, 8)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(552, 216)
        Me.panel1.TabIndex = 0
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.label7)
        Me.tabPage3.Controls.Add(Me.groupBox2)
        Me.tabPage3.Controls.Add(Me.groupBox1)
        Me.tabPage3.Controls.Add(Me.tvTree)
        Me.tabPage3.Controls.Add(Me.trackBar1)
        Me.tabPage3.Location = New System.Drawing.Point(4, 25)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(608, 363)
        Me.sbMessage.SetStatusBarText(Me.tabPage3, "Tab page #3")
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Tab 3"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(52, 80)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(264, 56)
        Me.label7.TabIndex = 1
        Me.label7.Text = "The tree view uses an AfterSelect event to update its status bar text as each nod" & _
            "e is selected."
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.radioButton1)
        Me.groupBox2.Controls.Add(Me.radioButton2)
        Me.groupBox2.Location = New System.Drawing.Point(336, 192)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(248, 152)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "A Group Box"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 88)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(224, 40)
        Me.label6.TabIndex = 2
        Me.label6.Text = "The radio buttons in this group box do have status bar text."
        '
        'tvTree
        '
        Me.tvTree.Location = New System.Drawing.Point(52, 136)
        Me.tvTree.Name = "tvTree"
        TreeNode13.Name = ""
        TreeNode13.Text = "Node2"
        TreeNode14.Name = ""
        TreeNode14.Text = "Node3"
        TreeNode15.Name = ""
        TreeNode15.Text = "Node4"
        TreeNode16.Name = ""
        TreeNode16.Text = "Node1"
        TreeNode17.Name = ""
        TreeNode17.Text = "Node5"
        TreeNode18.Name = ""
        TreeNode18.Text = "Node0"
        Me.tvTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode18})
        Me.tvTree.Size = New System.Drawing.Size(248, 208)
        Me.tvTree.TabIndex = 2
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.ucDemo)
        Me.tabPage4.Controls.Add(Me.panel2)
        Me.tabPage4.Controls.Add(Me.label8)
        Me.tabPage4.Controls.Add(Me.demoUserControl1)
        Me.tabPage4.Location = New System.Drawing.Point(4, 25)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Size = New System.Drawing.Size(608, 363)
        Me.sbMessage.SetStatusBarText(Me.tabPage4, "Tab page #4")
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Tab 4"
        '
        'ucDemo
        '
        Me.ucDemo.Location = New System.Drawing.Point(24, 248)
        Me.ucDemo.Name = "ucDemo"
        Me.ucDemo.Size = New System.Drawing.Size(336, 96)
        Me.ucDemo.TabIndex = 3
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(32, 152)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(360, 40)
        Me.label8.TabIndex = 1
        Me.label8.Text = "This is a custom user control with status bar text defined by this form"
        '
        'tabDemo
        '
        Me.tabDemo.Controls.Add(Me.tabPage1)
        Me.tabDemo.Controls.Add(Me.tabPage2)
        Me.tabDemo.Controls.Add(Me.tabPage3)
        Me.tabDemo.Controls.Add(Me.tabPage4)
        Me.tabDemo.Location = New System.Drawing.Point(8, 8)
        Me.tabDemo.Name = "tabDemo"
        Me.tabDemo.SelectedIndex = 0
        Me.sbMessage.SetShowAsBlank(Me.tabDemo, True)
        Me.tabDemo.Size = New System.Drawing.Size(616, 392)
        Me.tabDemo.TabIndex = 0
        '
        'sbDialog
        '
        Me.sbDialog.Location = New System.Drawing.Point(0, 456)
        Me.sbDialog.Name = "sbDialog"
        Me.sbDialog.Size = New System.Drawing.Size(632, 22)
        Me.sbDialog.SizingGrip = False
        Me.sbDialog.TabIndex = 3
        Me.sbDialog.Text = "Dialog status bar"
        '
        'btnProgress
        '
        Me.btnProgress.Location = New System.Drawing.Point(322, 408)
        Me.btnProgress.Name = "btnProgress"
        Me.btnProgress.Size = New System.Drawing.Size(96, 32)
        Me.sbMessage.SetStatusBarText(Me.btnProgress, "Utilize the status strip progress bar")
        Me.btnProgress.TabIndex = 4
        Me.btnProgress.Text = "&Progress"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(632, 478)
        Me.Controls.Add(Me.btnProgress)
        Me.Controls.Add(Me.chkUseDialog)
        Me.Controls.Add(Me.sbDialog)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabDemo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control Demo"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.tabPage4.ResumeLayout(False)
        Me.tabDemo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Close the dialog box
    Private Sub btnClose_Click(sender As Object, e As System.EventArgs) _
      Handles btnClose.Click
        Me.Close()
    End Sub

    ' Switch between the application status bar and this form's
    ' status bar for displaying the messages.
    Private Sub chkUseDialog_CheckedChanged(sender As Object, _
      e As System.EventArgs) Handles chkUseDialog.CheckedChanged
        If chkUseDialog.Checked Then
            sbMessage.InstanceStatusBar = sbDialog
            ucDemo.StatusBarTextProvider.InstanceStatusBar = sbDialog

            ' Make the instance default text the same for any nested
            ' status bar text providers.  If not, they pick up the
            ' status bar text of the current control as the default.
            ucDemo.StatusBarTextProvider.InstanceDefaultText = _
                sbMessage.InstanceDefaultText
        Else
            sbMessage.InstanceStatusBar = Nothing
            ucDemo.StatusBarTextProvider.InstanceStatusBar = Nothing
        End If
    End Sub

    ' Change the status bar text to show info about the selected node
    Private Sub tvTree_AfterSelect(sender As Object, _
      e As System.Windows.Forms.TreeViewEventArgs) _
      Handles tvTree.AfterSelect
        sbMessage.SetStatusBarText(tvTree, "Selected Node: " & e.Node.Text)
    End Sub

    ' Utilize the status strip label and progress bar via the status bar
    ' text provider.
    Private Sub btnProgress_Click( ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles btnProgress.Click
        Dim i As Integer

        StatusBarTextProvider.InitializeProgressBar(100)

        For i = 0 To 99
            StatusBarTextProvider.UpdateProgress(i + 1, _
                String.Format("Step #{0}", i + 1))

            System.Threading.Thread.Sleep(25)
        Next i

        StatusBarTextProvider.ResetProgressBar()
    End Sub
End Class

' A simple data source for the data grid
Public Class ListItem
    Private nIdx As Integer
    Private strDescr As String

    Public ReadOnly Property Index As Integer
        Get
            Return nIdx
        End Get
    End Property

    Public ReadOnly Property Description As String
        Get
            Return strDescr
        End Get
    End Property

    Public Sub New(idx As Integer, desc As String)
        nIdx = idx
        strDescr = desc
    End Sub
End Class
