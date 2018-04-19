Imports System.ComponentModel

Public Class CommandButtons

    ''' <summary>
    ''' ボタン種別
    ''' </summary>
    Public Enum Kinds As Integer
        NONE = -1
        ESC = 0
        F1
        F2
        F3
        F4
        F5
        F6
        F7
        F8
        F9
        F10
        F11
        F12
    End Enum

#Region "イベント"

    ''' <summary>
    ''' ボタンクリックイベント
    ''' </summary>
    ''' <param name="kind"></param>
    Public Event CommandButtonClickEvent(kind As Kinds)

    ''' <summary>
    ''' ボタンコントロールのクリック
    ''' </summary>
    ''' <param name="sender"></param>
    Public Sub ClickEvent(sender As CommandButton)

        Dim kind = Kinds.NONE
        Select Case sender.Name
            Case cbESC.Name
                kind = Kinds.ESC
            Case cbF1.Name
                kind = Kinds.F1
            Case cbF2.Name
                kind = Kinds.F2
            Case cbF3.Name
                kind = Kinds.F3
            Case cbF4.Name
                kind = Kinds.F4
            Case cbF5.Name
                kind = Kinds.F5
            Case cbF6.Name
                kind = Kinds.F6
            Case cbF7.Name
                kind = Kinds.F7
            Case cbF8.Name
                kind = Kinds.F8
            Case cbF9.Name
                kind = Kinds.F9
            Case cbF10.Name
                kind = Kinds.F10
            Case cbF11.Name
                kind = Kinds.F11
            Case cbF12.Name
                kind = Kinds.F12
        End Select

        ' ESC・F1～12の場合はクリックイベント発行
        If kind <> Kinds.NONE Then
            RaiseEvent CommandButtonClickEvent(kind)
        End If
    End Sub

    ''' <summary>
    ''' キー入力
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub CommandButtonKeyDown(sender As Object, e As KeyEventArgs)


        ' ESC・F1～12の場合はクリックメソッド呼び出し
        Select Case e.KeyCode
            Case Keys.Escape
                ClickEvent(cbESC)
                e.SuppressKeyPress = True
                Return
            Case Keys.F1
                ClickEvent(cbF1)
                e.SuppressKeyPress = True
                Return
            Case Keys.F2
                ClickEvent(cbF2)
                e.SuppressKeyPress = True
                Return
            Case Keys.F3
                ClickEvent(cbF3)
                e.SuppressKeyPress = True
                Return
            Case Keys.F4
                ClickEvent(cbF4)
                e.SuppressKeyPress = True
                Return
            Case Keys.F5
                ClickEvent(cbF5)
                e.SuppressKeyPress = True
                Return
            Case Keys.F6
                ClickEvent(cbF6)
                e.SuppressKeyPress = True
                Return
            Case Keys.F7
                ClickEvent(cbF7)
                e.SuppressKeyPress = True
                Return
            Case Keys.F8
                ClickEvent(cbF8)
                e.SuppressKeyPress = True
                Return
            Case Keys.F9
                ClickEvent(cbF9)
                e.SuppressKeyPress = True
                Return
            Case Keys.F10
                ClickEvent(cbF10)
                e.SuppressKeyPress = True
                Return
            Case Keys.F11
                ClickEvent(cbF11)
                e.SuppressKeyPress = True
                Return
            Case Keys.F12
                ClickEvent(cbF12)
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

        ' クリックイベント設定
        AddHandler cbESC.ClickEvent, AddressOf ClickEvent
        AddHandler cbF1.ClickEvent, AddressOf ClickEvent
        AddHandler cbF2.ClickEvent, AddressOf ClickEvent
        AddHandler cbF3.ClickEvent, AddressOf ClickEvent
        AddHandler cbF4.ClickEvent, AddressOf ClickEvent
        AddHandler cbF5.ClickEvent, AddressOf ClickEvent
        AddHandler cbF6.ClickEvent, AddressOf ClickEvent
        AddHandler cbF7.ClickEvent, AddressOf ClickEvent
        AddHandler cbF8.ClickEvent, AddressOf ClickEvent
        AddHandler cbF9.ClickEvent, AddressOf ClickEvent
        AddHandler cbF10.ClickEvent, AddressOf ClickEvent
        AddHandler cbF11.ClickEvent, AddressOf ClickEvent
        AddHandler cbF12.ClickEvent, AddressOf ClickEvent

        ' キー入力イベント設定
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
