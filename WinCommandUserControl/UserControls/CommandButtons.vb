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

    ''' <summary>
    ''' キー入力イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub CommandButtonKeyDown(sender As Object, e As KeyEventArgs)
        Dim targetKey = {Keys.Escape, Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12}

        ' TODO パラメータによってKindsを切り替える
        Select Case e.KeyCode
            Case Keys.Escape
                ClickEvent(cbESC)
                e.SuppressKeyPress = True
                Return
        End Select
    End Sub

    ''' <summary>
    ''' ページロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CommandButtons_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DesignMode Then
            Return
        End If

        If ParentForm IsNot Nothing Then
            AddHandler ParentForm.KeyDown, AddressOf CommandButtonKeyDown
        End If
    End Sub
#End Region

#Region "プロパティ"

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

#End Region

End Class
