Imports WinCommandUserControl.CommandButtons

Public Class Form1
    Private Sub CommandButtons_Click(kind As Kinds) Handles CommandButtons1.CommandButtonClickEvent
        MessageBox.Show(kind.ToString())
    End Sub
End Class
