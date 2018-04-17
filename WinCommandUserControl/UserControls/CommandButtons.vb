Imports System.ComponentModel

Public Class CommandButtons

    Public Enum Kinds
        ESC
    End Enum

#Region "イベント"
    Public Event CommandButtonClickEvent(kind As Kinds)

    Public Sub ClickEvent(sender As CommandButton) Handles cbESC.ClickEvent

        ' TODO パラメータによってKindsを切り替える
        RaiseEvent CommandButtonClickEvent(Kinds.ESC)
    End Sub
#End Region

#Region "Command.ESC"
    <Category("Command.ESC"), Description("ボタンのテキストの取得・設定")>
    Public Property ESCText As String
        Set(value As String)
            cbESC.btnCommand.Text = value
        End Set
        Get
            Return cbESC.btnCommand.Text
        End Get
    End Property

    <Category("Command.ESC"), Description("ラベルのテキストの取得・設定")>
    Public Property ESCLabelText As String
        Set(value As String)
            cbESC.lblCommand.Text = value
        End Set
        Get
            Return cbESC.lblCommand.Text
        End Get
    End Property

    <Category("Command.ESC"), Description("ボタンの表示状態の取得・設定")>
    Public Property ESCVisible As Boolean
        Set(value As Boolean)
            cbESC.btnCommand.Visible = value
        End Set
        Get
            Return cbESC.btnCommand.Visible
        End Get
    End Property

    <Category("Command.ESC"), Description("ラベルの表示状態の取得・設定")>
    Public Property ESCLabelVisible As Boolean
        Set(value As Boolean)
            cbESC.lblCommand.Visible = value
        End Set
        Get
            Return cbESC.lblCommand.Visible
        End Get
    End Property

    <Category("Command.ESC"), Description("ボタンの無効状態の取得・設定")>
    Public Property ESCEnabled As Boolean
        Set(value As Boolean)
            cbESC.btnCommand.Enabled = value
        End Set
        Get
            Return cbESC.btnCommand.Enabled
        End Get
    End Property


#End Region

End Class
