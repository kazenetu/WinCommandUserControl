Imports WinCommandUserControl.CommandButtons

Public Class Form1

    ''' <summary>
    ''' コマンドボタンクリック
    ''' </summary>
    ''' <param name="kind"></param>
    Private Sub CommandButtons_Click(kind As Kinds) Handles CommandButtons1.CommandButtonClickEvent
        MessageBox.Show(kind.ToString())
    End Sub
End Class
