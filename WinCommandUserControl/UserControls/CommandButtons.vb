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

#Region "コンストラクタ"

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' ラベルテキストの初期値設定
        For Each child As Control In pnlCommand.Controls
            If TypeOf child Is CommandButton Then
                Dim targetCommandButton = DirectCast(child, CommandButton)
                targetCommandButton.CommandLabel.Text = targetCommandButton.Name.Replace("cb", String.Empty)
            End If
        Next

        ' ボタンコントロールの位置設定
        Dim left = pnlCommand.Left + 5
        Dim top = cbESC.Top
        setButtonPosition(cbESC, left, top)
        setButtonPosition(cbF1, left, top)
        setButtonPosition(cbF2, left, top)
        setButtonPosition(cbF3, left, top)
        setButtonPosition(cbF4, left, top)
        setButtonPosition(cbF5, left, top)
        setButtonPosition(cbF6, left, top)
        setButtonPosition(cbF7, left, top)
        setButtonPosition(cbF8, left, top)
        setButtonPosition(cbF9, left, top)
        setButtonPosition(cbF10, left, top)
        setButtonPosition(cbF11, left, top)
        setButtonPosition(cbF12, left, top)

    End Sub

    ''' <summary>
    ''' コマンドボタンの位置設定
    ''' </summary>
    ''' <param name="targetButton">コマンドボタンインスタンス</param>
    ''' <param name="left">左位置</param>
    ''' <param name="top">上位置</param>
    Private Sub setButtonPosition(ByRef targetButton As CommandButton, ByRef left As Integer, ByVal top As Integer)

        ' コマンドボタンの位置設定
        targetButton.Left = left
        targetButton.Top = top

        ' leftの更新
        left += targetButton.Width + 5

    End Sub

#End Region

#Region "発行イベント"

    ''' <summary>
    ''' ボタンクリックイベント
    ''' </summary>
    ''' <param name="kind"></param>
    Public Event CommandButtonClickEvent(kind As Kinds)
#End Region

#Region "イベント"

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

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.ESC"), Description("ボタンのテキストの取得・設定")>
    Public Property ESCText As String
        Set(value As String)
            cbESC.btnCommand.Text = value
        End Set
        Get
            Return cbESC.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.ESC"), Description("ラベルのテキストの取得・設定")>
    Public Property ESCLabelText As String
        Set(value As String)
            cbESC.lblCommand.Text = value
        End Set
        Get
            Return cbESC.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.ESC"), Description("ボタンの表示状態の取得・設定")>
    Public Property ESCVisible As Boolean
        Set(value As Boolean)
            cbESC.btnCommand.Visible = value
        End Set
        Get
            Return cbESC.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.ESC"), Description("ラベルの表示状態の取得・設定")>
    Public Property ESCLabelVisible As Boolean
        Set(value As Boolean)
            cbESC.lblCommand.Visible = value
        End Set
        Get
            Return cbESC.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.ESC"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property ESCEnabled As Boolean
        Set(value As Boolean)
            cbESC.btnCommand.Enabled = value
        End Set
        Get
            Return cbESC.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F1"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F1"), Description("ボタンのテキストの取得・設定")>
    Public Property F1Text As String
        Set(value As String)
            cbF1.btnCommand.Text = value
        End Set
        Get
            Return cbF1.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F1"), Description("ラベルのテキストの取得・設定")>
    Public Property F1LabelText As String
        Set(value As String)
            cbF1.lblCommand.Text = value
        End Set
        Get
            Return cbF1.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F1"), Description("ボタンの表示状態の取得・設定")>
    Public Property F1Visible As Boolean
        Set(value As Boolean)
            cbF1.btnCommand.Visible = value
        End Set
        Get
            Return cbF1.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F1"), Description("ラベルの表示状態の取得・設定")>
    Public Property F1LabelVisible As Boolean
        Set(value As Boolean)
            cbF1.lblCommand.Visible = value
        End Set
        Get
            Return cbF1.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F1"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F1Enabled As Boolean
        Set(value As Boolean)
            cbF1.btnCommand.Enabled = value
        End Set
        Get
            Return cbF1.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F2"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F2"), Description("ボタンのテキストの取得・設定")>
    Public Property F2Text As String
        Set(value As String)
            cbF2.btnCommand.Text = value
        End Set
        Get
            Return cbF2.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F2"), Description("ラベルのテキストの取得・設定")>
    Public Property F2LabelText As String
        Set(value As String)
            cbF2.lblCommand.Text = value
        End Set
        Get
            Return cbF2.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F2"), Description("ボタンの表示状態の取得・設定")>
    Public Property F2Visible As Boolean
        Set(value As Boolean)
            cbF2.btnCommand.Visible = value
        End Set
        Get
            Return cbF2.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F2"), Description("ラベルの表示状態の取得・設定")>
    Public Property F2LabelVisible As Boolean
        Set(value As Boolean)
            cbF2.lblCommand.Visible = value
        End Set
        Get
            Return cbF2.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F2"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F2Enabled As Boolean
        Set(value As Boolean)
            cbF2.btnCommand.Enabled = value
        End Set
        Get
            Return cbF2.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F3"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F3"), Description("ボタンのテキストの取得・設定")>
    Public Property F3Text As String
        Set(value As String)
            cbF3.btnCommand.Text = value
        End Set
        Get
            Return cbF3.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F3"), Description("ラベルのテキストの取得・設定")>
    Public Property F3LabelText As String
        Set(value As String)
            cbF3.lblCommand.Text = value
        End Set
        Get
            Return cbF3.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F3"), Description("ボタンの表示状態の取得・設定")>
    Public Property F3Visible As Boolean
        Set(value As Boolean)
            cbF3.btnCommand.Visible = value
        End Set
        Get
            Return cbF3.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F3"), Description("ラベルの表示状態の取得・設定")>
    Public Property F3LabelVisible As Boolean
        Set(value As Boolean)
            cbF3.lblCommand.Visible = value
        End Set
        Get
            Return cbF3.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F3"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F3Enabled As Boolean
        Set(value As Boolean)
            cbF3.btnCommand.Enabled = value
        End Set
        Get
            Return cbF3.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F4"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F4"), Description("ボタンのテキストの取得・設定")>
    Public Property F4Text As String
        Set(value As String)
            cbF4.btnCommand.Text = value
        End Set
        Get
            Return cbF4.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F4"), Description("ラベルのテキストの取得・設定")>
    Public Property F4LabelText As String
        Set(value As String)
            cbF4.lblCommand.Text = value
        End Set
        Get
            Return cbF4.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F4"), Description("ボタンの表示状態の取得・設定")>
    Public Property F4Visible As Boolean
        Set(value As Boolean)
            cbF4.btnCommand.Visible = value
        End Set
        Get
            Return cbF4.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F4"), Description("ラベルの表示状態の取得・設定")>
    Public Property F4LabelVisible As Boolean
        Set(value As Boolean)
            cbF4.lblCommand.Visible = value
        End Set
        Get
            Return cbF4.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F4"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F4Enabled As Boolean
        Set(value As Boolean)
            cbF4.btnCommand.Enabled = value
        End Set
        Get
            Return cbF4.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F5"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F5"), Description("ボタンのテキストの取得・設定")>
    Public Property F5Text As String
        Set(value As String)
            cbF5.btnCommand.Text = value
        End Set
        Get
            Return cbF5.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F5"), Description("ラベルのテキストの取得・設定")>
    Public Property F5LabelText As String
        Set(value As String)
            cbF5.lblCommand.Text = value
        End Set
        Get
            Return cbF5.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F5"), Description("ボタンの表示状態の取得・設定")>
    Public Property F5Visible As Boolean
        Set(value As Boolean)
            cbF5.btnCommand.Visible = value
        End Set
        Get
            Return cbF5.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F5"), Description("ラベルの表示状態の取得・設定")>
    Public Property F5LabelVisible As Boolean
        Set(value As Boolean)
            cbF5.lblCommand.Visible = value
        End Set
        Get
            Return cbF5.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F5"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F5Enabled As Boolean
        Set(value As Boolean)
            cbF5.btnCommand.Enabled = value
        End Set
        Get
            Return cbF5.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F6"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F6"), Description("ボタンのテキストの取得・設定")>
    Public Property F6Text As String
        Set(value As String)
            cbF6.btnCommand.Text = value
        End Set
        Get
            Return cbF6.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F6"), Description("ラベルのテキストの取得・設定")>
    Public Property F6LabelText As String
        Set(value As String)
            cbF6.lblCommand.Text = value
        End Set
        Get
            Return cbF6.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F6"), Description("ボタンの表示状態の取得・設定")>
    Public Property F6Visible As Boolean
        Set(value As Boolean)
            cbF6.btnCommand.Visible = value
        End Set
        Get
            Return cbF6.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F6"), Description("ラベルの表示状態の取得・設定")>
    Public Property F6LabelVisible As Boolean
        Set(value As Boolean)
            cbF6.lblCommand.Visible = value
        End Set
        Get
            Return cbF6.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F6"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F6Enabled As Boolean
        Set(value As Boolean)
            cbF6.btnCommand.Enabled = value
        End Set
        Get
            Return cbF6.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F7"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F7"), Description("ボタンのテキストの取得・設定")>
    Public Property F7Text As String
        Set(value As String)
            cbF7.btnCommand.Text = value
        End Set
        Get
            Return cbF7.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F7"), Description("ラベルのテキストの取得・設定")>
    Public Property F7LabelText As String
        Set(value As String)
            cbF7.lblCommand.Text = value
        End Set
        Get
            Return cbF7.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F7"), Description("ボタンの表示状態の取得・設定")>
    Public Property F7Visible As Boolean
        Set(value As Boolean)
            cbF7.btnCommand.Visible = value
        End Set
        Get
            Return cbF7.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F7"), Description("ラベルの表示状態の取得・設定")>
    Public Property F7LabelVisible As Boolean
        Set(value As Boolean)
            cbF7.lblCommand.Visible = value
        End Set
        Get
            Return cbF7.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F7"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F7Enabled As Boolean
        Set(value As Boolean)
            cbF7.btnCommand.Enabled = value
        End Set
        Get
            Return cbF7.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F8"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F8"), Description("ボタンのテキストの取得・設定")>
    Public Property F8Text As String
        Set(value As String)
            cbF8.btnCommand.Text = value
        End Set
        Get
            Return cbF8.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F8"), Description("ラベルのテキストの取得・設定")>
    Public Property F8LabelText As String
        Set(value As String)
            cbF8.lblCommand.Text = value
        End Set
        Get
            Return cbF8.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F8"), Description("ボタンの表示状態の取得・設定")>
    Public Property F8Visible As Boolean
        Set(value As Boolean)
            cbF8.btnCommand.Visible = value
        End Set
        Get
            Return cbF8.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F8"), Description("ラベルの表示状態の取得・設定")>
    Public Property F8LabelVisible As Boolean
        Set(value As Boolean)
            cbF8.lblCommand.Visible = value
        End Set
        Get
            Return cbF8.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F8"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F8Enabled As Boolean
        Set(value As Boolean)
            cbF8.btnCommand.Enabled = value
        End Set
        Get
            Return cbF8.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F9"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F9"), Description("ボタンのテキストの取得・設定")>
    Public Property F9Text As String
        Set(value As String)
            cbF9.btnCommand.Text = value
        End Set
        Get
            Return cbF9.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F9"), Description("ラベルのテキストの取得・設定")>
    Public Property F9LabelText As String
        Set(value As String)
            cbF9.lblCommand.Text = value
        End Set
        Get
            Return cbF9.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F9"), Description("ボタンの表示状態の取得・設定")>
    Public Property F9Visible As Boolean
        Set(value As Boolean)
            cbF9.btnCommand.Visible = value
        End Set
        Get
            Return cbF9.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F9"), Description("ラベルの表示状態の取得・設定")>
    Public Property F9LabelVisible As Boolean
        Set(value As Boolean)
            cbF9.lblCommand.Visible = value
        End Set
        Get
            Return cbF9.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F9"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F9Enabled As Boolean
        Set(value As Boolean)
            cbF9.btnCommand.Enabled = value
        End Set
        Get
            Return cbF9.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F10"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F10"), Description("ボタンのテキストの取得・設定")>
    Public Property F10Text As String
        Set(value As String)
            cbF10.btnCommand.Text = value
        End Set
        Get
            Return cbF10.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F10"), Description("ラベルのテキストの取得・設定")>
    Public Property F10LabelText As String
        Set(value As String)
            cbF10.lblCommand.Text = value
        End Set
        Get
            Return cbF10.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F10"), Description("ボタンの表示状態の取得・設定")>
    Public Property F10Visible As Boolean
        Set(value As Boolean)
            cbF10.btnCommand.Visible = value
        End Set
        Get
            Return cbF10.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F10"), Description("ラベルの表示状態の取得・設定")>
    Public Property F10LabelVisible As Boolean
        Set(value As Boolean)
            cbF10.lblCommand.Visible = value
        End Set
        Get
            Return cbF10.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F10"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F10Enabled As Boolean
        Set(value As Boolean)
            cbF10.btnCommand.Enabled = value
        End Set
        Get
            Return cbF10.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F11"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F11"), Description("ボタンのテキストの取得・設定")>
    Public Property F11Text As String
        Set(value As String)
            cbF11.btnCommand.Text = value
        End Set
        Get
            Return cbF11.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F11"), Description("ラベルのテキストの取得・設定")>
    Public Property F11LabelText As String
        Set(value As String)
            cbF11.lblCommand.Text = value
        End Set
        Get
            Return cbF11.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F11"), Description("ボタンの表示状態の取得・設定")>
    Public Property F11Visible As Boolean
        Set(value As Boolean)
            cbF11.btnCommand.Visible = value
        End Set
        Get
            Return cbF11.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F11"), Description("ラベルの表示状態の取得・設定")>
    Public Property F11LabelVisible As Boolean
        Set(value As Boolean)
            cbF11.lblCommand.Visible = value
        End Set
        Get
            Return cbF11.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F11"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F11Enabled As Boolean
        Set(value As Boolean)
            cbF11.btnCommand.Enabled = value
        End Set
        Get
            Return cbF11.btnCommand.Enabled
        End Get
    End Property


#End Region

#Region "Command.F12"

    ''' <summary>
    ''' ボタンテキストの取得・設定
    ''' </summary>
    ''' <returns>ボタンテキスト</returns>
    <Category("Command.F12"), Description("ボタンのテキストの取得・設定")>
    Public Property F12Text As String
        Set(value As String)
            cbF12.btnCommand.Text = value
        End Set
        Get
            Return cbF12.btnCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ラベルテキストの取得・設定
    ''' </summary>
    ''' <returns>ラベルテキスト</returns>
    <Category("Command.F12"), Description("ラベルのテキストの取得・設定")>
    Public Property F12LabelText As String
        Set(value As String)
            cbF12.lblCommand.Text = value
        End Set
        Get
            Return cbF12.lblCommand.Text
        End Get
    End Property

    ''' <summary>
    ''' ボタン表示状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの表示状態</returns>
    <Category("Command.F12"), Description("ボタンの表示状態の取得・設定")>
    Public Property F12Visible As Boolean
        Set(value As Boolean)
            cbF12.btnCommand.Visible = value
        End Set
        Get
            Return cbF12.btnCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ラベル表示状態の取得・設定
    ''' </summary>
    ''' <returns>ラベルの表示状態</returns>
    <Category("Command.F12"), Description("ラベルの表示状態の取得・設定")>
    Public Property F12LabelVisible As Boolean
        Set(value As Boolean)
            cbF12.lblCommand.Visible = value
        End Set
        Get
            Return cbF12.lblCommand.Visible
        End Get
    End Property

    ''' <summary>
    ''' ボタン有効/無効状態の取得・設定
    ''' </summary>
    ''' <returns>ボタンの有効/無効状態</returns>
    <Category("Command.F12"), Description("ボタンの有効/無効状態の取得・設定")>
    Public Property F12Enabled As Boolean
        Set(value As Boolean)
            cbF12.btnCommand.Enabled = value
        End Set
        Get
            Return cbF12.btnCommand.Enabled
        End Get
    End Property


#End Region

#End Region

End Class
