﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StansGroceryForm))
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.AllItemsRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterGroupBox.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(26, 33)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(239, 22)
        Me.SearchTextBox.TabIndex = 0
        Me.MainToolTip.SetToolTip(Me.SearchTextBox, "Type the name of the product you're looking for")
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(541, 401)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(170, 90)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.MainToolTip.SetToolTip(Me.SearchButton, "Press it to search for the item typed in the searching box")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(26, 81)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(239, 24)
        Me.FilterComboBox.TabIndex = 2
        Me.MainToolTip.SetToolTip(Me.FilterComboBox, "Combo box where you can select specific item sorted by aisles and categories depe" &
        "nding on which filter is selected.")
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 16
        Me.DisplayListBox.Location = New System.Drawing.Point(26, 130)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(503, 356)
        Me.DisplayListBox.TabIndex = 3
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Displays all the items available acording to filtering or all items available")
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(279, 61)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(90, 16)
        Me.DisplayLabel.TabIndex = 4
        Me.DisplayLabel.Text = "Display Label"
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.AllItemsRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(541, 130)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(170, 147)
        Me.FilterGroupBox.TabIndex = 5
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "FilterGroupBox"
        Me.MainToolTip.SetToolTip(Me.FilterGroupBox, "Select the filter for items search")
        '
        'AllItemsRadioButton
        '
        Me.AllItemsRadioButton.AutoSize = True
        Me.AllItemsRadioButton.Location = New System.Drawing.Point(10, 115)
        Me.AllItemsRadioButton.Name = "AllItemsRadioButton"
        Me.AllItemsRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.AllItemsRadioButton.TabIndex = 2
        Me.AllItemsRadioButton.TabStop = True
        Me.AllItemsRadioButton.Text = "All Items"
        Me.AllItemsRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(10, 72)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(134, 20)
        Me.FilterByCategoryRadioButton.TabIndex = 1
        Me.FilterByCategoryRadioButton.TabStop = True
        Me.FilterByCategoryRadioButton.Text = "Filter By Category"
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(10, 27)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(109, 20)
        Me.FilterByAisleRadioButton.TabIndex = 0
        Me.FilterByAisleRadioButton.TabStop = True
        Me.FilterByAisleRadioButton.Text = "Filter By Aisle"
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(123, 52)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(801, 28)
        Me.TopMenuStrip.TabIndex = 6
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 503)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGroceryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stan's Grocery"
        Me.MainToolTip.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllItemsRadioButton As RadioButton
End Class
