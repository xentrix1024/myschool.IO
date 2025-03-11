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
        Me.TextBoxInputFile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonBrowseInputFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxTmimaRange = New System.Windows.Forms.TextBox()
        Me.TextBoxClassRange = New System.Windows.Forms.TextBox()
        Me.TextBoxCourseRange = New System.Windows.Forms.TextBox()
        Me.TextBoxTeachersRange = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCreateFolders = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxEKCourseCol = New System.Windows.Forms.TextBox()
        Me.TextBoxEKTeachersCol = New System.Windows.Forms.TextBox()
        Me.TextBoxEKTmimaCol = New System.Windows.Forms.TextBox()
        Me.TextBoxInputEK = New System.Windows.Forms.TextBox()
        Me.ButtonBrowseEK = New System.Windows.Forms.Button()
        Me.ButtonGoInput = New System.Windows.Forms.Button()
        Me.RadioButtonPerCourse = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPerTeacher = New System.Windows.Forms.RadioButton()
        Me.GroupBoxOutput = New System.Windows.Forms.GroupBox()
        Me.ListViewFilesOutput = New System.Windows.Forms.ListView()
        Me.ButtonGoOutput = New System.Windows.Forms.Button()
        Me.TextBoxOutputFile = New System.Windows.Forms.TextBox()
        Me.ButtonBrowseOutputFile = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBoxIDRange = New System.Windows.Forms.TextBox()
        Me.TextBoxGradeRange = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxInput.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxInputFile
        '
        Me.TextBoxInputFile.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxInputFile.Name = "TextBoxInputFile"
        Me.TextBoxInputFile.ReadOnly = True
        Me.TextBoxInputFile.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxInputFile.TabIndex = 10
        Me.TextBoxInputFile.TabStop = False
        '
        'ButtonBrowseInputFile
        '
        Me.ButtonBrowseInputFile.Location = New System.Drawing.Point(191, 17)
        Me.ButtonBrowseInputFile.Name = "ButtonBrowseInputFile"
        Me.ButtonBrowseInputFile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseInputFile.TabIndex = 0
        Me.ButtonBrowseInputFile.Text = "Browse"
        Me.ButtonBrowseInputFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Τμήμα:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Τάξη:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Μάθημα:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Διδάσκοντες Εκπαιδευτικοί:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Αρ. Μητρώου (στήλη):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Βαθμοί (1ο κελί):"
        '
        'TextBoxTmimaRange
        '
        Me.TextBoxTmimaRange.Location = New System.Drawing.Point(158, 48)
        Me.TextBoxTmimaRange.Name = "TextBoxTmimaRange"
        Me.TextBoxTmimaRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxTmimaRange.TabIndex = 1
        Me.TextBoxTmimaRange.Text = "F14"
        '
        'TextBoxClassRange
        '
        Me.TextBoxClassRange.Location = New System.Drawing.Point(158, 74)
        Me.TextBoxClassRange.Name = "TextBoxClassRange"
        Me.TextBoxClassRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxClassRange.TabIndex = 2
        Me.TextBoxClassRange.Text = "F15"
        '
        'TextBoxCourseRange
        '
        Me.TextBoxCourseRange.Location = New System.Drawing.Point(61, 12)
        Me.TextBoxCourseRange.Name = "TextBoxCourseRange"
        Me.TextBoxCourseRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxCourseRange.TabIndex = 0
        Me.TextBoxCourseRange.Text = "D16"
        '
        'TextBoxTeachersRange
        '
        Me.TextBoxTeachersRange.Location = New System.Drawing.Point(158, 100)
        Me.TextBoxTeachersRange.Name = "TextBoxTeachersRange"
        Me.TextBoxTeachersRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxTeachersRange.TabIndex = 3
        Me.TextBoxTeachersRange.Text = "D17"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(158, 126)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxPassword.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 401)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(574, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(279, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(279, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxInput
        '
        Me.GroupBoxInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxInput.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBoxInput.Controls.Add(Me.CheckBoxCreateFolders)
        Me.GroupBoxInput.Controls.Add(Me.GroupBox1)
        Me.GroupBoxInput.Controls.Add(Me.ButtonGoInput)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonPerCourse)
        Me.GroupBoxInput.Controls.Add(Me.RadioButtonPerTeacher)
        Me.GroupBoxInput.Controls.Add(Me.TextBoxInputFile)
        Me.GroupBoxInput.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxInput.Controls.Add(Me.ButtonBrowseInputFile)
        Me.GroupBoxInput.Controls.Add(Me.Label7)
        Me.GroupBoxInput.Controls.Add(Me.Label1)
        Me.GroupBoxInput.Controls.Add(Me.Label2)
        Me.GroupBoxInput.Controls.Add(Me.Label4)
        Me.GroupBoxInput.Controls.Add(Me.TextBoxTeachersRange)
        Me.GroupBoxInput.Controls.Add(Me.TextBoxTmimaRange)
        Me.GroupBoxInput.Controls.Add(Me.TextBoxClassRange)
        Me.GroupBoxInput.Location = New System.Drawing.Point(12, 38)
        Me.GroupBoxInput.Name = "GroupBoxInput"
        Me.GroupBoxInput.Size = New System.Drawing.Size(272, 360)
        Me.GroupBoxInput.TabIndex = 3
        Me.GroupBoxInput.TabStop = False
        Me.GroupBoxInput.Text = "Δημιουργία καταστάσεων βαθμολογίας"
        '
        'CheckBoxCreateFolders
        '
        Me.CheckBoxCreateFolders.AutoSize = True
        Me.CheckBoxCreateFolders.Location = New System.Drawing.Point(7, 179)
        Me.CheckBoxCreateFolders.Name = "CheckBoxCreateFolders"
        Me.CheckBoxCreateFolders.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxCreateFolders.TabIndex = 7
        Me.CheckBoxCreateFolders.Text = "Φάκελοι"
        Me.CheckBoxCreateFolders.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxEKCourseCol)
        Me.GroupBox1.Controls.Add(Me.TextBoxEKTeachersCol)
        Me.GroupBox1.Controls.Add(Me.TextBoxEKTmimaCol)
        Me.GroupBox1.Controls.Add(Me.TextBoxInputEK)
        Me.GroupBox1.Controls.Add(Me.ButtonBrowseEK)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 124)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Αναθέσεις ΕΚ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Διδάσκοντες (στήλη):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Τμήμα (στήλη):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Μάθημα (στήλη):"
        '
        'TextBoxEKCourseCol
        '
        Me.TextBoxEKCourseCol.Location = New System.Drawing.Point(147, 97)
        Me.TextBoxEKCourseCol.Name = "TextBoxEKCourseCol"
        Me.TextBoxEKCourseCol.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxEKCourseCol.TabIndex = 3
        Me.TextBoxEKCourseCol.Text = "C"
        '
        'TextBoxEKTeachersCol
        '
        Me.TextBoxEKTeachersCol.Location = New System.Drawing.Point(147, 45)
        Me.TextBoxEKTeachersCol.Name = "TextBoxEKTeachersCol"
        Me.TextBoxEKTeachersCol.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxEKTeachersCol.TabIndex = 1
        Me.TextBoxEKTeachersCol.Text = "A"
        '
        'TextBoxEKTmimaCol
        '
        Me.TextBoxEKTmimaCol.Location = New System.Drawing.Point(147, 71)
        Me.TextBoxEKTmimaCol.Name = "TextBoxEKTmimaCol"
        Me.TextBoxEKTmimaCol.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxEKTmimaCol.TabIndex = 2
        Me.TextBoxEKTmimaCol.Text = "B"
        '
        'TextBoxInputEK
        '
        Me.TextBoxInputEK.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxInputEK.Name = "TextBoxInputEK"
        Me.TextBoxInputEK.ReadOnly = True
        Me.TextBoxInputEK.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxInputEK.TabIndex = 4
        Me.TextBoxInputEK.TabStop = False
        '
        'ButtonBrowseEK
        '
        Me.ButtonBrowseEK.Location = New System.Drawing.Point(179, 17)
        Me.ButtonBrowseEK.Name = "ButtonBrowseEK"
        Me.ButtonBrowseEK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseEK.TabIndex = 0
        Me.ButtonBrowseEK.Text = "Browse"
        Me.ButtonBrowseEK.UseVisualStyleBackColor = True
        '
        'ButtonGoInput
        '
        Me.ButtonGoInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGoInput.Location = New System.Drawing.Point(158, 332)
        Me.ButtonGoInput.Name = "ButtonGoInput"
        Me.ButtonGoInput.Size = New System.Drawing.Size(108, 22)
        Me.ButtonGoInput.TabIndex = 9
        Me.ButtonGoInput.Text = "Εκκίνηση"
        Me.ButtonGoInput.UseVisualStyleBackColor = True
        '
        'RadioButtonPerCourse
        '
        Me.RadioButtonPerCourse.AutoSize = True
        Me.RadioButtonPerCourse.Checked = True
        Me.RadioButtonPerCourse.Location = New System.Drawing.Point(158, 155)
        Me.RadioButtonPerCourse.Name = "RadioButtonPerCourse"
        Me.RadioButtonPerCourse.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonPerCourse.TabIndex = 6
        Me.RadioButtonPerCourse.TabStop = True
        Me.RadioButtonPerCourse.Text = "Ανά μάθημα"
        Me.RadioButtonPerCourse.UseVisualStyleBackColor = True
        '
        'RadioButtonPerTeacher
        '
        Me.RadioButtonPerTeacher.AutoSize = True
        Me.RadioButtonPerTeacher.Location = New System.Drawing.Point(6, 155)
        Me.RadioButtonPerTeacher.Name = "RadioButtonPerTeacher"
        Me.RadioButtonPerTeacher.Size = New System.Drawing.Size(107, 17)
        Me.RadioButtonPerTeacher.TabIndex = 5
        Me.RadioButtonPerTeacher.Text = "Ανά διδάσκοντα"
        Me.RadioButtonPerTeacher.UseVisualStyleBackColor = True
        '
        'GroupBoxOutput
        '
        Me.GroupBoxOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBoxOutput.Controls.Add(Me.ListViewFilesOutput)
        Me.GroupBoxOutput.Controls.Add(Me.ButtonGoOutput)
        Me.GroupBoxOutput.Controls.Add(Me.TextBoxOutputFile)
        Me.GroupBoxOutput.Controls.Add(Me.ButtonBrowseOutputFile)
        Me.GroupBoxOutput.Location = New System.Drawing.Point(290, 38)
        Me.GroupBoxOutput.Name = "GroupBoxOutput"
        Me.GroupBoxOutput.Size = New System.Drawing.Size(272, 360)
        Me.GroupBoxOutput.TabIndex = 4
        Me.GroupBoxOutput.TabStop = False
        Me.GroupBoxOutput.Text = "Δημιουργία συγκεντρωτικής κατάστασης"
        '
        'ListViewFilesOutput
        '
        Me.ListViewFilesOutput.AllowDrop = True
        Me.ListViewFilesOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewFilesOutput.FullRowSelect = True
        Me.ListViewFilesOutput.Location = New System.Drawing.Point(7, 20)
        Me.ListViewFilesOutput.Name = "ListViewFilesOutput"
        Me.ListViewFilesOutput.Size = New System.Drawing.Size(259, 277)
        Me.ListViewFilesOutput.TabIndex = 2
        Me.ListViewFilesOutput.UseCompatibleStateImageBehavior = False
        Me.ListViewFilesOutput.View = System.Windows.Forms.View.List
        '
        'ButtonGoOutput
        '
        Me.ButtonGoOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGoOutput.Location = New System.Drawing.Point(158, 332)
        Me.ButtonGoOutput.Name = "ButtonGoOutput"
        Me.ButtonGoOutput.Size = New System.Drawing.Size(108, 22)
        Me.ButtonGoOutput.TabIndex = 1
        Me.ButtonGoOutput.Text = "Εκκίνηση"
        Me.ButtonGoOutput.UseVisualStyleBackColor = True
        '
        'TextBoxOutputFile
        '
        Me.TextBoxOutputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOutputFile.Location = New System.Drawing.Point(6, 306)
        Me.TextBoxOutputFile.Name = "TextBoxOutputFile"
        Me.TextBoxOutputFile.ReadOnly = True
        Me.TextBoxOutputFile.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxOutputFile.TabIndex = 3
        Me.TextBoxOutputFile.TabStop = False
        '
        'ButtonBrowseOutputFile
        '
        Me.ButtonBrowseOutputFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBrowseOutputFile.Location = New System.Drawing.Point(191, 303)
        Me.ButtonBrowseOutputFile.Name = "ButtonBrowseOutputFile"
        Me.ButtonBrowseOutputFile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseOutputFile.TabIndex = 0
        Me.ButtonBrowseOutputFile.Text = "Browse"
        Me.ButtonBrowseOutputFile.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "excel 97-2003|*.xls"
        '
        'TextBoxIDRange
        '
        Me.TextBoxIDRange.Location = New System.Drawing.Point(238, 12)
        Me.TextBoxIDRange.Name = "TextBoxIDRange"
        Me.TextBoxIDRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxIDRange.TabIndex = 1
        Me.TextBoxIDRange.Text = "B"
        '
        'TextBoxGradeRange
        '
        Me.TextBoxGradeRange.Location = New System.Drawing.Point(388, 12)
        Me.TextBoxGradeRange.Name = "TextBoxGradeRange"
        Me.TextBoxGradeRange.Size = New System.Drawing.Size(26, 20)
        Me.TextBoxGradeRange.TabIndex = 2
        Me.TextBoxGradeRange.Text = "N21"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 423)
        Me.Controls.Add(Me.TextBoxGradeRange)
        Me.Controls.Add(Me.GroupBoxOutput)
        Me.Controls.Add(Me.TextBoxIDRange)
        Me.Controls.Add(Me.GroupBoxInput)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCourseRange)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.MaximumSize = New System.Drawing.Size(1024, 461)
        Me.MinimumSize = New System.Drawing.Size(590, 461)
        Me.Name = "Form1"
        Me.Text = "myschool - I/O"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxInput.ResumeLayout(False)
        Me.GroupBoxInput.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxOutput.ResumeLayout(False)
        Me.GroupBoxOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxInputFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonBrowseInputFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTmimaRange As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClassRange As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCourseRange As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTeachersRange As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBoxInput As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxOutput As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowseOutputFile As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonGoOutput As System.Windows.Forms.Button
    Friend WithEvents ListViewFilesOutput As System.Windows.Forms.ListView
    Friend WithEvents RadioButtonPerCourse As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPerTeacher As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonGoInput As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEKCourseCol As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEKTeachersCol As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEKTmimaCol As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInputEK As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowseEK As System.Windows.Forms.Button
    Friend WithEvents CheckBoxCreateFolders As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxIDRange As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGradeRange As System.Windows.Forms.TextBox

End Class
