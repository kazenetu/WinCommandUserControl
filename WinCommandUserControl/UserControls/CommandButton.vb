Imports System.ComponentModel

''' <summary>
''' コマンドボタン
''' </summary>
Public Class CommandButton

#Region "プロパティ"

    <Category("コマンド情報")>
    <Description("ボタン")>
    Public ReadOnly Property CommandButton As Button
        Get
            Return btnCommand
        End Get
    End Property

    <Category("コマンド情報")>
    <Description("ラベル")>
    Public ReadOnly Property CommandLabel As Label
        Get
            Return lblCommand
        End Get
    End Property

#End Region

#Region "イベント"

    Public Event ClickEvent(sender As CommandButton)

#End Region

    ''' <summary>
    ''' ロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CommandButton_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' ラベルの位置合わせを行う
        lblCommand.Left = btnCommand.Left + (btnCommand.Width - lblCommand.Width) / 2

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnCommand.Click
        RaiseEvent ClickEvent(Me)
    End Sub
End Class
