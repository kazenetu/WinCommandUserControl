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
        Me.CommandButtons1.ESCLabelVisible = True
        Me.CommandButtons1.ESCText = "aaaa"
        Me.CommandButtons1.ESCVisible = True
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CommandButtons1 As CommandButtons
End Class
