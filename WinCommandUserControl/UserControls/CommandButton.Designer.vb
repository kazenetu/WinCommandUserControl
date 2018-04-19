<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandButton
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.btnCommand = New System.Windows.Forms.Button()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCommand
        '
        Me.btnCommand.Location = New System.Drawing.Point(0, 19)
        Me.btnCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCommand.Name = "btnCommand"
        Me.btnCommand.Size = New System.Drawing.Size(65, 35)
        Me.btnCommand.TabIndex = 0
        Me.btnCommand.UseVisualStyleBackColor = True
        '
        'lblCommand
        '
        Me.lblCommand.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblCommand.Location = New System.Drawing.Point(0, 4)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(65, 12)
        Me.lblCommand.TabIndex = 1
        Me.lblCommand.Text = "Label1"
        Me.lblCommand.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CommandButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.btnCommand)
        Me.Name = "CommandButton"
        Me.Size = New System.Drawing.Size(65, 56)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCommand As Button
    Friend WithEvents lblCommand As Label
End Class
