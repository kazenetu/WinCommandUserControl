<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CommandButtons1 = New WinCommandUserControl.CommandButtons()
        Me.SuspendLayout()
        '
        'CommandButtons1
        '
        Me.CommandButtons1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CommandButtons1.ESCEnabled = True
        Me.CommandButtons1.ESCLabelText = "ESC"
        Me.CommandButtons1.ESCLabelVisible = True
        Me.CommandButtons1.ESCText = "文字列"
        Me.CommandButtons1.ESCVisible = True
        Me.CommandButtons1.F10Enabled = True
        Me.CommandButtons1.F10LabelText = "F10"
        Me.CommandButtons1.F10LabelVisible = True
        Me.CommandButtons1.F10Text = ""
        Me.CommandButtons1.F10Visible = True
        Me.CommandButtons1.F11Enabled = True
        Me.CommandButtons1.F11LabelText = "F11"
        Me.CommandButtons1.F11LabelVisible = True
        Me.CommandButtons1.F11Text = ""
        Me.CommandButtons1.F11Visible = True
        Me.CommandButtons1.F12Enabled = True
        Me.CommandButtons1.F12LabelText = "F12"
        Me.CommandButtons1.F12LabelVisible = True
        Me.CommandButtons1.F12Text = ""
        Me.CommandButtons1.F12Visible = True
        Me.CommandButtons1.F1Enabled = True
        Me.CommandButtons1.F1LabelText = "F1"
        Me.CommandButtons1.F1LabelVisible = True
        Me.CommandButtons1.F1Text = ""
        Me.CommandButtons1.F1Visible = True
        Me.CommandButtons1.F2Enabled = True
        Me.CommandButtons1.F2LabelText = "F2"
        Me.CommandButtons1.F2LabelVisible = True
        Me.CommandButtons1.F2Text = ""
        Me.CommandButtons1.F2Visible = True
        Me.CommandButtons1.F3Enabled = True
        Me.CommandButtons1.F3LabelText = "F3"
        Me.CommandButtons1.F3LabelVisible = True
        Me.CommandButtons1.F3Text = ""
        Me.CommandButtons1.F3Visible = True
        Me.CommandButtons1.F4Enabled = True
        Me.CommandButtons1.F4LabelText = "F4"
        Me.CommandButtons1.F4LabelVisible = True
        Me.CommandButtons1.F4Text = ""
        Me.CommandButtons1.F4Visible = True
        Me.CommandButtons1.F5Enabled = True
        Me.CommandButtons1.F5LabelText = "F5"
        Me.CommandButtons1.F5LabelVisible = True
        Me.CommandButtons1.F5Text = ""
        Me.CommandButtons1.F5Visible = True
        Me.CommandButtons1.F6Enabled = True
        Me.CommandButtons1.F6LabelText = "F6"
        Me.CommandButtons1.F6LabelVisible = True
        Me.CommandButtons1.F6Text = ""
        Me.CommandButtons1.F6Visible = True
        Me.CommandButtons1.F7Enabled = True
        Me.CommandButtons1.F7LabelText = "F7"
        Me.CommandButtons1.F7LabelVisible = True
        Me.CommandButtons1.F7Text = ""
        Me.CommandButtons1.F7Visible = True
        Me.CommandButtons1.F8Enabled = True
        Me.CommandButtons1.F8LabelText = "F8"
        Me.CommandButtons1.F8LabelVisible = True
        Me.CommandButtons1.F8Text = ""
        Me.CommandButtons1.F8Visible = True
        Me.CommandButtons1.F9Enabled = True
        Me.CommandButtons1.F9LabelText = "F9"
        Me.CommandButtons1.F9LabelVisible = True
        Me.CommandButtons1.F9Text = ""
        Me.CommandButtons1.F9Visible = True
        Me.CommandButtons1.Location = New System.Drawing.Point(0, 193)
        Me.CommandButtons1.Name = "CommandButtons1"
        Me.CommandButtons1.Size = New System.Drawing.Size(947, 68)
        Me.CommandButtons1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 261)
        Me.Controls.Add(Me.CommandButtons1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CommandButtons1 As CommandButtons
End Class
