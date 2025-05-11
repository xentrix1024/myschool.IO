Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub ButtonGoInput_Click(sender As Object, e As EventArgs) Handles ButtonGoInput.Click
        Dim ExcelApp As Excel.Application
        Dim InputWorkbook As Excel.Workbook
        Dim InputSheet As Excel.Worksheet

        Dim BaseFolder As String = Path.GetDirectoryName(TextBoxInputFile.Text)
        Dim OutputPath As String

        Dim Teachers As New Collection
        Dim EKWorkbook As Excel.Workbook
        Try
            ToolStripStatusLabel1.Text = "Opening Excel"
            ExcelApp = New Excel.Application
            ' ExcelApp.Visible = True ' Uncomment to make Excel visible
            ToolStripStatusLabel1.Text = "Opening file " & TextBoxInputFile.Text
            InputWorkbook = ExcelApp.Workbooks.Open(TextBoxInputFile.Text)
            If TextBoxInputEK.Text <> "" Then EKWorkbook = ExcelApp.Workbooks.Open(TextBoxInputEK.Text)

            ' Iterate over each worksheet in the input workbook
            For Each InputSheet In InputWorkbook.Worksheets
                Dim newTeacher As String = InputSheet.Range(TextBoxTeachersRange.Text).Value
                If IsNothing(newTeacher) Then
                    If IsNothing(EKWorkbook) Then Continue For
                    Dim EKSheet As Excel.Worksheet
                    EKSheet = EKWorkbook.Worksheets(1)
                    With EKSheet.Range(TextBoxEKCourseCol.Text & ":" & TextBoxEKCourseCol.Text)
                        Dim EKCourse As Excel.Range = .Find(InputSheet.Range(TextBoxCourseRange.Text).Value)
                        Dim FirstAddress As String = EKCourse.Address
                        Do
                            If EKSheet.Range(TextBoxEKTmimaCol.Text & EKCourse.Row).Value = InputSheet.Range(TextBoxTmimaRange.Text).Value Then
                                Dim teacherName As String = EKSheet.Range(TextBoxEKTeachersCol.Text & EKCourse.Row).Value
                                If Len(newTeacher) > 0 Then
                                    newTeacher = newTeacher & ", " & teacherName
                                Else
                                    newTeacher = teacherName
                                End If
                            End If
                            EKCourse = .FindNext(EKCourse)
                        Loop While Not IsNothing(EKCourse) And EKCourse.Address <> FirstAddress
                        InputSheet.Range(TextBoxTeachersRange.Text).Value = newTeacher
                        InputSheet.Range(TextBoxTeachersRange.Text).RowHeight = InputSheet.Range(TextBoxTeachersRange.Text).RowHeight * 2
                    End With
                End If
                ToolStripStatusLabel1.Text = InputSheet.Name & ": " & newTeacher

                ' Create folder for the teacher if it doesn't exist
                If CheckBoxCreateFolders.Checked And (Not Directory.Exists(BaseFolder & "\" & newTeacher)) Then
                    Directory.CreateDirectory(BaseFolder & "\" & newTeacher)
                End If

                ' Handle the per-teacher option
                If RadioButtonPerTeacher.Checked Then
                    ' Populate Teachers collection with List of Strings
                    ' First List item contains Teacher's Name
                    ' Further List items contain Teacher's Sheets Names
                    If Not Teachers.Contains(newTeacher) Then
                        Teachers.Add(New List(Of String), newTeacher)
                        Teachers(newTeacher).Add(newTeacher)
                    End If
                    Teachers(newTeacher).Add(InputSheet.Name)
                End If

                ' Unlock Grades Cells
                Dim IDCol = InputSheet.Range(TextBoxIDRange.Text & ":" & TextBoxIDRange.Text).Column
                Dim GradeCol As Integer = InputSheet.Range(TextBoxGradeRange.Text).Column
                Dim GradeRow As Integer = InputSheet.Range(TextBoxGradeRange.Text).Row
                While Not IsNothing(InputSheet.Cells(GradeRow, IDCol).Value)
                    ToolStripStatusLabel2.Text = "Unlocking cell " & GradeCol & "," & GradeRow
                    InputSheet.Cells(GradeRow, GradeCol).MergeArea.Locked = False
                    ' InputSheet.Cells(GradeRow, GradeCol + 2).MergeArea.Locked = False ' Uncomment if needed
                    GradeRow += 1
                End While

                ' Password protect the sheet
                ToolStripStatusLabel2.Text = "Password protecting"
                InputSheet.Protect(TextBoxPassword.Text)
                ToolStripStatusLabel2.Text = ""

                ' Handle the per-course option
                If RadioButtonPerCourse.Checked Then
                    InputSheet.Copy()

                    ' Save file
                    If Not CheckBoxCreateFolders.Checked Then newTeacher = "Βαθμολόγια για συμπλήρωση"
                    If Not Directory.Exists(BaseFolder & "\" & newTeacher) Then Directory.CreateDirectory(BaseFolder & "\" & newTeacher)
                    OutputPath = BaseFolder & "\" & newTeacher & "\" & RemoveIllegalFileNameChars(InputSheet.Range(TextBoxTmimaRange.Text).Value & "-" & InputSheet.Range(TextBoxCourseRange.Text).Value) & ".xlsx"
                    ToolStripStatusLabel1.Text = "Saving " & OutputPath
                    ExcelApp.ActiveWorkbook.SaveAs(OutputPath)
                    ExcelApp.ActiveWorkbook.Close()
                End If
            Next

            ' Handle the per-teacher option
            If RadioButtonPerTeacher.Checked Then
                For i = 1 To Teachers.Count
                    ' Copy Teacher's Sheets to new Workbook
                    ToolStripStatusLabel1.Text = "Preparing output for " & Teachers(i)(0)
                    ToolStripStatusLabel2.Text = "Copying Sheets to new Workbook"
                    Dim SheetsToCopy(Teachers(i).Count - 2) As String
                    Array.Copy(Teachers(i).ToArray, 1, SheetsToCopy, 0, Teachers(i).Count - 1)
                    InputWorkbook.Worksheets(SheetsToCopy).Copy()

                    ' Populate Tmimata list and rename sheets
                    ToolStripStatusLabel2.Text = "Naming Sheets"
                    Dim Tmimata As New List(Of String)
                    For Each InputSheet In ExcelApp.ActiveWorkbook.Worksheets
                        Dim CurrentTmima As String = InputSheet.Range(TextBoxTmimaRange.Text).Value
                        If Not Tmimata.Contains(CurrentTmima) Then Tmimata.Add(CurrentTmima)
                        InputSheet.Name = CleanSheetName(CurrentTmima & " - " & InputSheet.Range(TextBoxCourseRange.Text).Value)
                    Next
                    ToolStripStatusLabel2.Text = ""

                    ' Save file
                    OutputPath = BaseFolder & "\" & Teachers(i)(0) & "\" & Teachers(i)(0) & " " & String.Join(",", Tmimata.ToArray) & ".xlsx"
                    ToolStripStatusLabel1.Text = "Saving " & OutputPath
                    ExcelApp.ActiveWorkbook.SaveAs(OutputPath)
                    ExcelApp.ActiveWorkbook.Close()
                Next
            End If

        Catch ex As Exception
            ' Handle any errors that occur
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        Finally
            ' Close workbooks and release COM objects
            ToolStripStatusLabel1.Text = "Closing Workbooks"
            InputWorkbook.Close(False)
            If Not IsNothing(EKWorkbook) Then EKWorkbook.Close(False)
            ToolStripStatusLabel1.Text = "Closing Excel"
            ExcelApp.Quit()
            ToolStripStatusLabel1.Text = "Done"
        End Try
    End Sub

    Private Sub ButtonGoOutput_Click(sender As Object, e As EventArgs) Handles ButtonGoOutput.Click
        Dim ExcelApp As New Excel.Application
        ' ExcelApp.Visible = True ' Uncomment to make Excel visible
        ToolStripStatusLabel1.Text = "Creating file " & TextBoxOutputFile.Text
        Dim OutputWorkbook As Excel.Workbook = ExcelApp.Workbooks.Add
        Dim OutputSheet As Excel.Worksheet = OutputWorkbook.ActiveSheet

        Try
            ' Iterate over each file in the ListViewFilesOutput
            For Each ListItem As ListViewItem In ListViewFilesOutput.Items
                Dim InputWorkbook As Excel.Workbook = ExcelApp.Workbooks.Open(ListItem.Tag.ToString())
                ToolStripStatusLabel1.Text = "Reading file " & InputWorkbook.Name

                ' Iterate over each worksheet in the input workbook
                For Each InputSheet As Excel.Worksheet In InputWorkbook.Worksheets
                    Dim IDCol As Integer = InputSheet.Range(TextBoxIDRange.Text & ":" & TextBoxIDRange.Text).Column
                    Dim GradeCol As Integer = InputSheet.Range(TextBoxGradeRange.Text).Column
                    Dim GradeRow As Integer = InputSheet.Range(TextBoxGradeRange.Text).Row
                    Dim CourseCol As Integer
                    Dim CourseName As String = InputSheet.Range(TextBoxCourseRange.Text).Value

                    ' Find or create Course column header
                    Dim CourseNameCell As Excel.Range = Nothing
                    CourseNameCell = OutputSheet.Range(OutputSheet.Cells(1, 2), OutputSheet.Cells(1, OutputSheet.UsedRange.Columns.Count)).Find(CourseName, , , Excel.XlLookAt.xlWhole)
                    If IsNothing(CourseNameCell) Then
                        CourseCol = OutputSheet.UsedRange.Columns.Count + 1
                        OutputSheet.Cells(1, CourseCol).Value = CourseName
                    Else
                        CourseCol = CourseNameCell.Column
                    End If

                    ' Copy Grades to Course column, ID row
                    While Not IsNothing(InputSheet.Cells(GradeRow, IDCol).Value)
                        Dim ID As Integer = InputSheet.Cells(GradeRow, IDCol).Value
                        OutputSheet.Cells(ID, 1).Value = ID
                        OutputSheet.Cells(ID, CourseCol).Value = InputSheet.Cells(GradeRow, GradeCol).Value
                        GradeRow += 1
                    End While
                Next
                InputWorkbook.Close()
                Marshal.ReleaseComObject(InputWorkbook)
            Next

            ' Save and close the output workbook
            ToolStripStatusLabel1.Text = "Saving Workbook"
            OutputWorkbook.SaveAs(TextBoxOutputFile.Text, Excel.XlFileFormat.xlAddIn8)
            ToolStripStatusLabel1.Text = "Closing Workbook"
            OutputWorkbook.Close(False)
            ToolStripStatusLabel1.Text = "Closing Excel"
            ExcelApp.Quit()
            ToolStripStatusLabel1.Text = "Done"
        Catch ex As Exception
            ' Handle any errors that occur
            ToolStripStatusLabel1.Text = "Error: " & ex.Message
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        Finally
            ' Release COM objects and perform garbage collection
            Marshal.ReleaseComObject(OutputSheet)
            Marshal.ReleaseComObject(OutputWorkbook)
            Marshal.ReleaseComObject(ExcelApp)
            OutputSheet = Nothing
            OutputWorkbook = Nothing
            ExcelApp = Nothing
            GC.Collect()
        End Try
    End Sub

    ' Removes illegal characters from file names
    Private Function RemoveIllegalFileNameChars(input As String, Optional replacement As String = "") As String
        Dim regexSearch = New String(Path.GetInvalidFileNameChars()) & New String(Path.GetInvalidPathChars())
        Dim r = New Regex(String.Format("[{0}]", Regex.Escape(regexSearch)))
        Return r.Replace(input, replacement)
    End Function

    ' Cleans the worksheet name to remove illegal characters
    Private Function CleanSheetName(OriginalName As String) As String
        CleanSheetName = Replace(OriginalName, "/", "-", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, "\", "-", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, "?", "-", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, "*", "-", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, ":", "-", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, "[", "(", , , CompareMethod.Text)
        CleanSheetName = Replace(CleanSheetName, "]", ")", , , CompareMethod.Text)
        If CleanSheetName.Length > 31 Then
            CleanSheetName = Strings.Left(CleanSheetName, 26) & ".." & Strings.Right(CleanSheetName, 3)
        End If
    End Function

    Private Sub ButtonBrowseInputFile_Click(sender As Object, e As EventArgs) Handles ButtonBrowseInputFile.Click
        OpenFileDialog1.ShowDialog()
        TextBoxInputFile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub ButtonBrowseEK_Click(sender As Object, e As EventArgs) Handles ButtonBrowseEK.Click
        OpenFileDialog1.ShowDialog()
        TextBoxInputEK.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub ButtonBrowseOutputFile_Click(sender As Object, e As EventArgs) Handles ButtonBrowseOutputFile.Click
        SaveFileDialog1.ShowDialog()
        TextBoxOutputFile.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub ListViewFilesOutput_DragDrop(sender As Object, e As DragEventArgs) Handles ListViewFilesOutput.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim strFiles() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each filePath As String In strFiles
                With ListViewFilesOutput.Items.Add(New ListViewItem(System.IO.Path.GetFileName(filePath)))
                    .Tag = filePath
                End With
            Next
        End If
    End Sub

    Private Sub ListViewFilesOutput_DragOver(sender As Object, e As DragEventArgs) Handles ListViewFilesOutput.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListViewFilesOutput.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCourseRange.Text = My.Settings.SettingCourseRange
        TextBoxIDRange.Text = My.Settings.SettingIDRange
        TextBoxGradeRange.Text = My.Settings.SettingGradeRange
        TextBoxTmimaRange.Text = My.Settings.SettingTmimaRange
        TextBoxClassRange.Text = My.Settings.SettingClassRange
        TextBoxTeachersRange.Text = My.Settings.SettingTeachersRange
        TextBoxEKTeachersCol.Text = My.Settings.SettingEKTeachersCol
        TextBoxEKTmimaCol.Text = My.Settings.SettingEKTmimaCol
        TextBoxEKCourseCol.Text = My.Settings.SettingEKCourseCol
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.SettingCourseRange = TextBoxCourseRange.Text
        My.Settings.SettingIDRange = TextBoxIDRange.Text
        My.Settings.SettingGradeRange = TextBoxGradeRange.Text
        My.Settings.SettingTmimaRange = TextBoxTmimaRange.Text
        My.Settings.SettingClassRange = TextBoxClassRange.Text
        My.Settings.SettingTeachersRange = TextBoxTeachersRange.Text
        My.Settings.SettingEKTeachersCol = TextBoxEKTeachersCol.Text
        My.Settings.SettingEKTmimaCol = TextBoxEKTmimaCol.Text
        My.Settings.SettingEKCourseCol = TextBoxEKCourseCol.Text
        My.Settings.Save()
    End Sub
End Class
