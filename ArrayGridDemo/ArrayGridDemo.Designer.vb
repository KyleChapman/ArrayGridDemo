<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayGridDemo
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
        Me.components = New System.ComponentModel.Container()
        Me.lblRow0Prompt = New System.Windows.Forms.Label()
        Me.lblRow1Prompt = New System.Windows.Forms.Label()
        Me.lblRow2Prompt = New System.Windows.Forms.Label()
        Me.lblRow3Prompt = New System.Windows.Forms.Label()
        Me.lblColumn0Prompt = New System.Windows.Forms.Label()
        Me.lblColumn1Prompt = New System.Windows.Forms.Label()
        Me.lblColumn2Prompt = New System.Windows.Forms.Label()
        Me.lblColumn3Prompt = New System.Windows.Forms.Label()
        Me.lblRow0Column0 = New System.Windows.Forms.Label()
        Me.lblRow0Column1 = New System.Windows.Forms.Label()
        Me.lblRow0Column2 = New System.Windows.Forms.Label()
        Me.lblRow0Column3 = New System.Windows.Forms.Label()
        Me.lblRow1Column3 = New System.Windows.Forms.Label()
        Me.lblRow1Column2 = New System.Windows.Forms.Label()
        Me.lblRow1Column1 = New System.Windows.Forms.Label()
        Me.lblRow1Column0 = New System.Windows.Forms.Label()
        Me.lblRow2Column3 = New System.Windows.Forms.Label()
        Me.lblRow2Column2 = New System.Windows.Forms.Label()
        Me.lblRow2Column1 = New System.Windows.Forms.Label()
        Me.lblRow2Column0 = New System.Windows.Forms.Label()
        Me.lblRow3Column3 = New System.Windows.Forms.Label()
        Me.lblRow3Column2 = New System.Windows.Forms.Label()
        Me.lblRow3Column1 = New System.Windows.Forms.Label()
        Me.lblRow3Column0 = New System.Windows.Forms.Label()
        Me.lblChangeValuePrompt = New System.Windows.Forms.Label()
        Me.nudChangeRowIndex = New System.Windows.Forms.NumericUpDown()
        Me.nudChangeColumnIndex = New System.Windows.Forms.NumericUpDown()
        Me.lblValuePrompt = New System.Windows.Forms.Label()
        Me.txtValueInput = New System.Windows.Forms.TextBox()
        Me.lblChangeComma = New System.Windows.Forms.Label()
        Me.btnMakeChange = New System.Windows.Forms.Button()
        Me.ttpArrayGridTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpChangeValue = New System.Windows.Forms.GroupBox()
        Me.grpFindValue = New System.Windows.Forms.GroupBox()
        Me.btnFindValue = New System.Windows.Forms.Button()
        Me.lblFindValuePrompt = New System.Windows.Forms.Label()
        Me.nudFindRowIndex = New System.Windows.Forms.NumericUpDown()
        Me.nudFindColumnIndex = New System.Windows.Forms.NumericUpDown()
        Me.lblFindComma = New System.Windows.Forms.Label()
        CType(Me.nudChangeRowIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudChangeColumnIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChangeValue.SuspendLayout()
        Me.grpFindValue.SuspendLayout()
        CType(Me.nudFindRowIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFindColumnIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRow0Prompt
        '
        Me.lblRow0Prompt.Location = New System.Drawing.Point(13, 60)
        Me.lblRow0Prompt.Name = "lblRow0Prompt"
        Me.lblRow0Prompt.Size = New System.Drawing.Size(100, 24)
        Me.lblRow0Prompt.TabIndex = 4
        Me.lblRow0Prompt.Text = "Row Index 0"
        Me.lblRow0Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRow1Prompt
        '
        Me.lblRow1Prompt.Location = New System.Drawing.Point(13, 98)
        Me.lblRow1Prompt.Name = "lblRow1Prompt"
        Me.lblRow1Prompt.Size = New System.Drawing.Size(100, 24)
        Me.lblRow1Prompt.TabIndex = 9
        Me.lblRow1Prompt.Text = "Row Index 1"
        Me.lblRow1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRow2Prompt
        '
        Me.lblRow2Prompt.Location = New System.Drawing.Point(13, 136)
        Me.lblRow2Prompt.Name = "lblRow2Prompt"
        Me.lblRow2Prompt.Size = New System.Drawing.Size(100, 24)
        Me.lblRow2Prompt.TabIndex = 14
        Me.lblRow2Prompt.Text = "Row Index 2"
        Me.lblRow2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRow3Prompt
        '
        Me.lblRow3Prompt.Location = New System.Drawing.Point(13, 174)
        Me.lblRow3Prompt.Name = "lblRow3Prompt"
        Me.lblRow3Prompt.Size = New System.Drawing.Size(100, 24)
        Me.lblRow3Prompt.TabIndex = 19
        Me.lblRow3Prompt.Text = "Row Index 3"
        Me.lblRow3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblColumn0Prompt
        '
        Me.lblColumn0Prompt.Location = New System.Drawing.Point(131, 4)
        Me.lblColumn0Prompt.Name = "lblColumn0Prompt"
        Me.lblColumn0Prompt.Size = New System.Drawing.Size(100, 45)
        Me.lblColumn0Prompt.TabIndex = 0
        Me.lblColumn0Prompt.Text = "Column" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Index 0"
        Me.lblColumn0Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColumn1Prompt
        '
        Me.lblColumn1Prompt.Location = New System.Drawing.Point(249, 4)
        Me.lblColumn1Prompt.Name = "lblColumn1Prompt"
        Me.lblColumn1Prompt.Size = New System.Drawing.Size(100, 45)
        Me.lblColumn1Prompt.TabIndex = 1
        Me.lblColumn1Prompt.Text = "Column" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Index 1"
        Me.lblColumn1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColumn2Prompt
        '
        Me.lblColumn2Prompt.Location = New System.Drawing.Point(367, 4)
        Me.lblColumn2Prompt.Name = "lblColumn2Prompt"
        Me.lblColumn2Prompt.Size = New System.Drawing.Size(100, 45)
        Me.lblColumn2Prompt.TabIndex = 2
        Me.lblColumn2Prompt.Text = "Column" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Index 2"
        Me.lblColumn2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColumn3Prompt
        '
        Me.lblColumn3Prompt.Location = New System.Drawing.Point(485, 4)
        Me.lblColumn3Prompt.Name = "lblColumn3Prompt"
        Me.lblColumn3Prompt.Size = New System.Drawing.Size(100, 45)
        Me.lblColumn3Prompt.TabIndex = 3
        Me.lblColumn3Prompt.Text = "Column" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Index 3"
        Me.lblColumn3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow0Column0
        '
        Me.lblRow0Column0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow0Column0.Location = New System.Drawing.Point(131, 60)
        Me.lblRow0Column0.Name = "lblRow0Column0"
        Me.lblRow0Column0.Size = New System.Drawing.Size(100, 24)
        Me.lblRow0Column0.TabIndex = 5
        Me.lblRow0Column0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow0Column1
        '
        Me.lblRow0Column1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow0Column1.Location = New System.Drawing.Point(249, 60)
        Me.lblRow0Column1.Name = "lblRow0Column1"
        Me.lblRow0Column1.Size = New System.Drawing.Size(100, 24)
        Me.lblRow0Column1.TabIndex = 6
        Me.lblRow0Column1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow0Column2
        '
        Me.lblRow0Column2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow0Column2.Location = New System.Drawing.Point(367, 59)
        Me.lblRow0Column2.Name = "lblRow0Column2"
        Me.lblRow0Column2.Size = New System.Drawing.Size(100, 24)
        Me.lblRow0Column2.TabIndex = 7
        Me.lblRow0Column2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow0Column3
        '
        Me.lblRow0Column3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow0Column3.Location = New System.Drawing.Point(485, 60)
        Me.lblRow0Column3.Name = "lblRow0Column3"
        Me.lblRow0Column3.Size = New System.Drawing.Size(100, 22)
        Me.lblRow0Column3.TabIndex = 8
        Me.lblRow0Column3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow1Column3
        '
        Me.lblRow1Column3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow1Column3.Location = New System.Drawing.Point(485, 98)
        Me.lblRow1Column3.Name = "lblRow1Column3"
        Me.lblRow1Column3.Size = New System.Drawing.Size(100, 22)
        Me.lblRow1Column3.TabIndex = 13
        Me.lblRow1Column3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow1Column2
        '
        Me.lblRow1Column2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow1Column2.Location = New System.Drawing.Point(367, 97)
        Me.lblRow1Column2.Name = "lblRow1Column2"
        Me.lblRow1Column2.Size = New System.Drawing.Size(100, 24)
        Me.lblRow1Column2.TabIndex = 12
        Me.lblRow1Column2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow1Column1
        '
        Me.lblRow1Column1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow1Column1.Location = New System.Drawing.Point(249, 98)
        Me.lblRow1Column1.Name = "lblRow1Column1"
        Me.lblRow1Column1.Size = New System.Drawing.Size(100, 24)
        Me.lblRow1Column1.TabIndex = 11
        Me.lblRow1Column1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow1Column0
        '
        Me.lblRow1Column0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow1Column0.Location = New System.Drawing.Point(131, 98)
        Me.lblRow1Column0.Name = "lblRow1Column0"
        Me.lblRow1Column0.Size = New System.Drawing.Size(100, 24)
        Me.lblRow1Column0.TabIndex = 10
        Me.lblRow1Column0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow2Column3
        '
        Me.lblRow2Column3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow2Column3.Location = New System.Drawing.Point(485, 136)
        Me.lblRow2Column3.Name = "lblRow2Column3"
        Me.lblRow2Column3.Size = New System.Drawing.Size(100, 22)
        Me.lblRow2Column3.TabIndex = 18
        Me.lblRow2Column3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow2Column2
        '
        Me.lblRow2Column2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow2Column2.Location = New System.Drawing.Point(367, 135)
        Me.lblRow2Column2.Name = "lblRow2Column2"
        Me.lblRow2Column2.Size = New System.Drawing.Size(100, 24)
        Me.lblRow2Column2.TabIndex = 17
        Me.lblRow2Column2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow2Column1
        '
        Me.lblRow2Column1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow2Column1.Location = New System.Drawing.Point(249, 136)
        Me.lblRow2Column1.Name = "lblRow2Column1"
        Me.lblRow2Column1.Size = New System.Drawing.Size(100, 24)
        Me.lblRow2Column1.TabIndex = 16
        Me.lblRow2Column1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow2Column0
        '
        Me.lblRow2Column0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow2Column0.Location = New System.Drawing.Point(131, 136)
        Me.lblRow2Column0.Name = "lblRow2Column0"
        Me.lblRow2Column0.Size = New System.Drawing.Size(100, 24)
        Me.lblRow2Column0.TabIndex = 15
        Me.lblRow2Column0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow3Column3
        '
        Me.lblRow3Column3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow3Column3.Location = New System.Drawing.Point(485, 174)
        Me.lblRow3Column3.Name = "lblRow3Column3"
        Me.lblRow3Column3.Size = New System.Drawing.Size(100, 22)
        Me.lblRow3Column3.TabIndex = 23
        Me.lblRow3Column3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow3Column2
        '
        Me.lblRow3Column2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow3Column2.Location = New System.Drawing.Point(367, 173)
        Me.lblRow3Column2.Name = "lblRow3Column2"
        Me.lblRow3Column2.Size = New System.Drawing.Size(100, 24)
        Me.lblRow3Column2.TabIndex = 22
        Me.lblRow3Column2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow3Column1
        '
        Me.lblRow3Column1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow3Column1.Location = New System.Drawing.Point(249, 174)
        Me.lblRow3Column1.Name = "lblRow3Column1"
        Me.lblRow3Column1.Size = New System.Drawing.Size(100, 24)
        Me.lblRow3Column1.TabIndex = 21
        Me.lblRow3Column1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRow3Column0
        '
        Me.lblRow3Column0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRow3Column0.Location = New System.Drawing.Point(131, 174)
        Me.lblRow3Column0.Name = "lblRow3Column0"
        Me.lblRow3Column0.Size = New System.Drawing.Size(100, 24)
        Me.lblRow3Column0.TabIndex = 20
        Me.lblRow3Column0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChangeValuePrompt
        '
        Me.lblChangeValuePrompt.AutoSize = True
        Me.lblChangeValuePrompt.Location = New System.Drawing.Point(15, 24)
        Me.lblChangeValuePrompt.Name = "lblChangeValuePrompt"
        Me.lblChangeValuePrompt.Size = New System.Drawing.Size(111, 17)
        Me.lblChangeValuePrompt.TabIndex = 0
        Me.lblChangeValuePrompt.Text = "&Change value at"
        '
        'nudChangeRowIndex
        '
        Me.nudChangeRowIndex.Location = New System.Drawing.Point(135, 21)
        Me.nudChangeRowIndex.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudChangeRowIndex.Name = "nudChangeRowIndex"
        Me.nudChangeRowIndex.ReadOnly = True
        Me.nudChangeRowIndex.Size = New System.Drawing.Size(50, 22)
        Me.nudChangeRowIndex.TabIndex = 1
        Me.nudChangeRowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpArrayGridTips.SetToolTip(Me.nudChangeRowIndex, "Select the Row value to change")
        '
        'nudChangeColumnIndex
        '
        Me.nudChangeColumnIndex.Location = New System.Drawing.Point(215, 21)
        Me.nudChangeColumnIndex.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudChangeColumnIndex.Name = "nudChangeColumnIndex"
        Me.nudChangeColumnIndex.ReadOnly = True
        Me.nudChangeColumnIndex.Size = New System.Drawing.Size(50, 22)
        Me.nudChangeColumnIndex.TabIndex = 3
        Me.nudChangeColumnIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpArrayGridTips.SetToolTip(Me.nudChangeColumnIndex, "Select the Column value to change")
        '
        'lblValuePrompt
        '
        Me.lblValuePrompt.AutoSize = True
        Me.lblValuePrompt.Location = New System.Drawing.Point(274, 24)
        Me.lblValuePrompt.Name = "lblValuePrompt"
        Me.lblValuePrompt.Size = New System.Drawing.Size(20, 17)
        Me.lblValuePrompt.TabIndex = 4
        Me.lblValuePrompt.Text = "&to"
        '
        'txtValueInput
        '
        Me.txtValueInput.Location = New System.Drawing.Point(303, 21)
        Me.txtValueInput.Name = "txtValueInput"
        Me.txtValueInput.Size = New System.Drawing.Size(100, 22)
        Me.txtValueInput.TabIndex = 5
        Me.txtValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpArrayGridTips.SetToolTip(Me.txtValueInput, "Enter the value you would like things changed to")
        '
        'lblChangeComma
        '
        Me.lblChangeComma.AutoSize = True
        Me.lblChangeComma.Location = New System.Drawing.Point(194, 24)
        Me.lblChangeComma.Name = "lblChangeComma"
        Me.lblChangeComma.Size = New System.Drawing.Size(12, 17)
        Me.lblChangeComma.TabIndex = 2
        Me.lblChangeComma.Text = ","
        '
        'btnMakeChange
        '
        Me.btnMakeChange.Location = New System.Drawing.Point(409, 21)
        Me.btnMakeChange.Name = "btnMakeChange"
        Me.btnMakeChange.Size = New System.Drawing.Size(142, 23)
        Me.btnMakeChange.TabIndex = 6
        Me.btnMakeChange.Text = "&Make the Change!"
        Me.ttpArrayGridTips.SetToolTip(Me.btnMakeChange, "Click to execute the change that has been described")
        Me.btnMakeChange.UseVisualStyleBackColor = True
        '
        'grpChangeValue
        '
        Me.grpChangeValue.Controls.Add(Me.btnMakeChange)
        Me.grpChangeValue.Controls.Add(Me.lblChangeValuePrompt)
        Me.grpChangeValue.Controls.Add(Me.nudChangeRowIndex)
        Me.grpChangeValue.Controls.Add(Me.nudChangeColumnIndex)
        Me.grpChangeValue.Controls.Add(Me.lblValuePrompt)
        Me.grpChangeValue.Controls.Add(Me.txtValueInput)
        Me.grpChangeValue.Controls.Add(Me.lblChangeComma)
        Me.grpChangeValue.Location = New System.Drawing.Point(22, 216)
        Me.grpChangeValue.Name = "grpChangeValue"
        Me.grpChangeValue.Size = New System.Drawing.Size(563, 60)
        Me.grpChangeValue.TabIndex = 24
        Me.grpChangeValue.TabStop = False
        Me.grpChangeValue.Text = "Change Values"
        '
        'grpFindValue
        '
        Me.grpFindValue.Controls.Add(Me.btnFindValue)
        Me.grpFindValue.Controls.Add(Me.lblFindValuePrompt)
        Me.grpFindValue.Controls.Add(Me.nudFindRowIndex)
        Me.grpFindValue.Controls.Add(Me.nudFindColumnIndex)
        Me.grpFindValue.Controls.Add(Me.lblFindComma)
        Me.grpFindValue.Location = New System.Drawing.Point(22, 288)
        Me.grpFindValue.Name = "grpFindValue"
        Me.grpFindValue.Size = New System.Drawing.Size(563, 60)
        Me.grpFindValue.TabIndex = 25
        Me.grpFindValue.TabStop = False
        Me.grpFindValue.Text = "Find Values"
        '
        'btnFindValue
        '
        Me.btnFindValue.Location = New System.Drawing.Point(409, 21)
        Me.btnFindValue.Name = "btnFindValue"
        Me.btnFindValue.Size = New System.Drawing.Size(142, 23)
        Me.btnFindValue.TabIndex = 4
        Me.btnFindValue.Text = "&Find that Value!"
        Me.ttpArrayGridTips.SetToolTip(Me.btnFindValue, "Click to execute the change that has been described")
        Me.btnFindValue.UseVisualStyleBackColor = True
        '
        'lblFindValuePrompt
        '
        Me.lblFindValuePrompt.AutoSize = True
        Me.lblFindValuePrompt.Location = New System.Drawing.Point(15, 24)
        Me.lblFindValuePrompt.Name = "lblFindValuePrompt"
        Me.lblFindValuePrompt.Size = New System.Drawing.Size(105, 17)
        Me.lblFindValuePrompt.TabIndex = 0
        Me.lblFindValuePrompt.Text = "&Report value at"
        '
        'nudFindRowIndex
        '
        Me.nudFindRowIndex.Location = New System.Drawing.Point(135, 21)
        Me.nudFindRowIndex.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudFindRowIndex.Name = "nudFindRowIndex"
        Me.nudFindRowIndex.ReadOnly = True
        Me.nudFindRowIndex.Size = New System.Drawing.Size(50, 22)
        Me.nudFindRowIndex.TabIndex = 1
        Me.nudFindRowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpArrayGridTips.SetToolTip(Me.nudFindRowIndex, "Select the Row value to find")
        '
        'nudFindColumnIndex
        '
        Me.nudFindColumnIndex.Location = New System.Drawing.Point(215, 21)
        Me.nudFindColumnIndex.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudFindColumnIndex.Name = "nudFindColumnIndex"
        Me.nudFindColumnIndex.ReadOnly = True
        Me.nudFindColumnIndex.Size = New System.Drawing.Size(50, 22)
        Me.nudFindColumnIndex.TabIndex = 3
        Me.nudFindColumnIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpArrayGridTips.SetToolTip(Me.nudFindColumnIndex, "Select the Column value to find")
        '
        'lblFindComma
        '
        Me.lblFindComma.AutoSize = True
        Me.lblFindComma.Location = New System.Drawing.Point(194, 24)
        Me.lblFindComma.Name = "lblFindComma"
        Me.lblFindComma.Size = New System.Drawing.Size(12, 17)
        Me.lblFindComma.TabIndex = 2
        Me.lblFindComma.Text = ","
        '
        'frmArrayGridDemo
        '
        Me.AcceptButton = Me.btnMakeChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 361)
        Me.Controls.Add(Me.grpFindValue)
        Me.Controls.Add(Me.grpChangeValue)
        Me.Controls.Add(Me.lblRow3Column3)
        Me.Controls.Add(Me.lblRow3Column2)
        Me.Controls.Add(Me.lblRow3Column1)
        Me.Controls.Add(Me.lblRow3Column0)
        Me.Controls.Add(Me.lblRow2Column3)
        Me.Controls.Add(Me.lblRow2Column2)
        Me.Controls.Add(Me.lblRow2Column1)
        Me.Controls.Add(Me.lblRow2Column0)
        Me.Controls.Add(Me.lblRow1Column3)
        Me.Controls.Add(Me.lblRow1Column2)
        Me.Controls.Add(Me.lblRow1Column1)
        Me.Controls.Add(Me.lblRow1Column0)
        Me.Controls.Add(Me.lblRow0Column3)
        Me.Controls.Add(Me.lblRow0Column2)
        Me.Controls.Add(Me.lblRow0Column1)
        Me.Controls.Add(Me.lblRow0Column0)
        Me.Controls.Add(Me.lblColumn3Prompt)
        Me.Controls.Add(Me.lblColumn2Prompt)
        Me.Controls.Add(Me.lblColumn1Prompt)
        Me.Controls.Add(Me.lblColumn0Prompt)
        Me.Controls.Add(Me.lblRow3Prompt)
        Me.Controls.Add(Me.lblRow2Prompt)
        Me.Controls.Add(Me.lblRow1Prompt)
        Me.Controls.Add(Me.lblRow0Prompt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArrayGridDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Array Grid Demo"
        CType(Me.nudChangeRowIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudChangeColumnIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChangeValue.ResumeLayout(False)
        Me.grpChangeValue.PerformLayout()
        Me.grpFindValue.ResumeLayout(False)
        Me.grpFindValue.PerformLayout()
        CType(Me.nudFindRowIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFindColumnIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRow0Prompt As Label
    Friend WithEvents lblRow1Prompt As Label
    Friend WithEvents lblRow2Prompt As Label
    Friend WithEvents lblRow3Prompt As Label
    Friend WithEvents lblColumn0Prompt As Label
    Friend WithEvents lblColumn1Prompt As Label
    Friend WithEvents lblColumn2Prompt As Label
    Friend WithEvents lblColumn3Prompt As Label
    Friend WithEvents lblRow0Column0 As Label
    Friend WithEvents lblRow0Column1 As Label
    Friend WithEvents lblRow0Column2 As Label
    Friend WithEvents lblRow0Column3 As Label
    Friend WithEvents lblRow1Column3 As Label
    Friend WithEvents lblRow1Column2 As Label
    Friend WithEvents lblRow1Column1 As Label
    Friend WithEvents lblRow1Column0 As Label
    Friend WithEvents lblRow2Column3 As Label
    Friend WithEvents lblRow2Column2 As Label
    Friend WithEvents lblRow2Column1 As Label
    Friend WithEvents lblRow2Column0 As Label
    Friend WithEvents lblRow3Column3 As Label
    Friend WithEvents lblRow3Column2 As Label
    Friend WithEvents lblRow3Column1 As Label
    Friend WithEvents lblRow3Column0 As Label
    Friend WithEvents lblChangeValuePrompt As Label
    Friend WithEvents nudChangeRowIndex As NumericUpDown
    Friend WithEvents nudChangeColumnIndex As NumericUpDown
    Friend WithEvents lblValuePrompt As Label
    Friend WithEvents txtValueInput As TextBox
    Friend WithEvents lblChangeComma As Label
    Friend WithEvents btnMakeChange As Button
    Friend WithEvents ttpArrayGridTips As ToolTip
    Friend WithEvents grpChangeValue As GroupBox
    Friend WithEvents grpFindValue As GroupBox
    Friend WithEvents btnFindValue As Button
    Friend WithEvents lblFindValuePrompt As Label
    Friend WithEvents nudFindRowIndex As NumericUpDown
    Friend WithEvents nudFindColumnIndex As NumericUpDown
    Friend WithEvents lblFindComma As Label
End Class
