Imports System.ComponentModel

''' <summary>
''' コマンドボタン
''' </summary>
Public Class CommandButton

#Region "プロパティ"

    ''' <summary>
    ''' コマンドボタン
    ''' </summary>
    ''' <returns>ボタンインスタンス</returns>
    <Category("コマンド情報")>
    <Description("ボタン")>
    Public ReadOnly Property CommandButton As Button
        Get
            Return btnCommand
        End Get
    End Property

    ''' <summary>
    ''' ラベル
    ''' </summary>
    ''' <returns>ラベルインスタンス</returns>
    <Category("コマンド情報")>
    <Description("ラベル")>
    Public ReadOnly Property CommandLabel As Label
        Get
            Return lblCommand
        End Get
    End Property

#End Region

#Region "発行イベント"

    ''' <summary>
    ''' ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender">ボタンインスタンス</param>
    Public Event ClickEvent(sender As CommandButton)

#End Region

#Region "イベント"

    ''' <summary>
    ''' ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnCommand.Click
        RaiseEvent ClickEvent(Me)
    End Sub

#End Region

End Class
