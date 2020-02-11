' Author: Kyle Chapman
' Date: February 9, 2020
' Description:
'   This program is meant to show a "grid" made of labels and allow the user
'   to adjust their content by manipulating a set of NumericUpDown controls
'   along with a textbox. Specifying a "row" and "column" using the NUDs and
'   a value in the TextBox followed by clicking the button manipulates the
'   value in the labels.
'   Quotation marks have been used quite a bit in the description above because
'   actual grid-structured controls have been avoided in the interest of using
'   elements students have seen before.

Option Strict On

Public Class frmArrayGridDemo

    Dim labelArray As Label(,)

    ''' <summary>
    ''' When the form loads, assign all of the labels that appear as part of the "grid"'s content to an array
    ''' </summary>
    Private Sub frmArrayGridDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelArray = {
            {lblRow0Column0, lblRow0Column1, lblRow0Column2, lblRow0Column3},
            {lblRow1Column0, lblRow1Column1, lblRow1Column2, lblRow1Column3},
            {lblRow2Column0, lblRow2Column1, lblRow2Column2, lblRow2Column3},
            {lblRow3Column0, lblRow3Column1, lblRow3Column2, lblRow3Column3}}
    End Sub

    ''' <summary>
    ''' Based on the NUD values, set the Text property of the relevant Label equal to whatever is in the entry TextBox.
    ''' For the sake of demonstration, range validation on the array was omitted, allowing unhandled exceptions to be observed.
    ''' </summary>
    Private Sub btnMakeChange_Click(sender As Object, e As EventArgs) Handles btnMakeChange.Click

        ' Set row and column based on the NUD contents
        ' A hard cast (CInt) is used since these controls have been configured so they must be integers
        ' This is not strictly necessary; only being done make the array addressing clearer
        Dim row = CInt(nudChangeRowIndex.Value)
        Dim column = CInt(nudChangeColumnIndex.Value)

        ' Set the text property of the label at the entered row and column equal to the contents of the TextBox
        labelArray(row, column).Text = txtValueInput.Text

    End Sub

    ''' <summary>
    ''' Show a MessageBox that indicates the value based on the NUD values.
    ''' For the sake of demonstration, range validation on the array was omitted, allowing unhandled exceptions to be observed.
    ''' </summary>
    Private Sub btnFindValue_Click(sender As Object, e As EventArgs) Handles btnFindValue.Click

        ' Set row and column based on the NUD contents
        ' A hard cast (CInt) is used since these controls have been configured so they must be integers
        ' This is not strictly necessary; only being done make the array addressing clearer
        Dim row = CInt(nudFindRowIndex.Value)
        Dim column = CInt(nudFindColumnIndex.Value)

        ' Show a MessageBox showing the row and column and the value in the Label at those coordinates
        MessageBox.Show("The value at " & nudFindRowIndex.Value & "," & nudFindColumnIndex.Value & " is: " & labelArray(row, column).Text)

    End Sub

End Class
