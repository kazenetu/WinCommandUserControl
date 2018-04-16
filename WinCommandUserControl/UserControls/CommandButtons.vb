Imports System.ComponentModel

Public Class CommandButtons

    Public Enum Kinds
        ESC
    End Enum

    Public Event CommandButtonClickEvent(kind As Kinds)

    Public Sub ClickEvent(sender As CommandButton) Handles cbESC.ClickEvent

        ' TODO パラメータによってKindsを切り替える
        RaiseEvent CommandButtonClickEvent(Kinds.ESC)
    End Sub


    <Category("Command.ESC")>
    Public Property ESCText As String
        Set(value As String)
            cbESC.btnCommand.Text = value
        End Set
        Get
            Return cbESC.btnCommand.Text
        End Get
    End Property

    <Category("Command.ESC")>
    Public Property ESCLabel As String
        Set(value As String)
            cbESC.lblCommand.Text = value
        End Set
        Get
            Return cbESC.lblCommand.Text
        End Get
    End Property

    <Category("Command.ESC")>
    Public Property ESCLabelVisible As Boolean
        Set(value As Boolean)
            cbESC.lblCommand.Visible = value
        End Set
        Get
            Return cbESC.lblCommand.Visible
        End Get
    End Property

    <Category("Command.ESC")>
    Public Property ESCVisible As Boolean
        Set(value As Boolean)
            cbESC.btnCommand.Visible = value
        End Set
        Get
            Return cbESC.btnCommand.Visible
        End Get
    End Property

End Class
