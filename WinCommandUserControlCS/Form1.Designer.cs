namespace WinCommandUserControlCS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.commandButtons1 = new WinCommandUserControlCS.UserControls.CommandButtons();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 1;
            // 
            // commandButtons1
            // 
            this.commandButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commandButtons1.ESCEnabled = true;
            this.commandButtons1.ESCLabelText = "ESC";
            this.commandButtons1.ESCLabelVisible = true;
            this.commandButtons1.ESCText = "sss";
            this.commandButtons1.ESCVisible = true;
            this.commandButtons1.F10Enabled = false;
            this.commandButtons1.F10LabelText = "F10";
            this.commandButtons1.F10LabelVisible = false;
            this.commandButtons1.F10Text = "aaasa";
            this.commandButtons1.F10Visible = true;
            this.commandButtons1.F11Enabled = true;
            this.commandButtons1.F11LabelText = "F11";
            this.commandButtons1.F11LabelVisible = true;
            this.commandButtons1.F11Text = "";
            this.commandButtons1.F11Visible = true;
            this.commandButtons1.F12Enabled = true;
            this.commandButtons1.F12LabelText = "F12";
            this.commandButtons1.F12LabelVisible = true;
            this.commandButtons1.F12Text = "";
            this.commandButtons1.F12Visible = true;
            this.commandButtons1.F1Enabled = true;
            this.commandButtons1.F1LabelText = "F1aaa";
            this.commandButtons1.F1LabelVisible = true;
            this.commandButtons1.F1Text = "aaaa";
            this.commandButtons1.F1Visible = true;
            this.commandButtons1.F2Enabled = true;
            this.commandButtons1.F2LabelText = "F2";
            this.commandButtons1.F2LabelVisible = true;
            this.commandButtons1.F2Text = "";
            this.commandButtons1.F2Visible = true;
            this.commandButtons1.F3Enabled = true;
            this.commandButtons1.F3LabelText = "F3";
            this.commandButtons1.F3LabelVisible = true;
            this.commandButtons1.F3Text = "";
            this.commandButtons1.F3Visible = true;
            this.commandButtons1.F4Enabled = true;
            this.commandButtons1.F4LabelText = "F4";
            this.commandButtons1.F4LabelVisible = true;
            this.commandButtons1.F4Text = "";
            this.commandButtons1.F4Visible = true;
            this.commandButtons1.F5Enabled = true;
            this.commandButtons1.F5LabelText = "F5";
            this.commandButtons1.F5LabelVisible = true;
            this.commandButtons1.F5Text = "";
            this.commandButtons1.F5Visible = true;
            this.commandButtons1.F6Enabled = true;
            this.commandButtons1.F6LabelText = "F6";
            this.commandButtons1.F6LabelVisible = true;
            this.commandButtons1.F6Text = "";
            this.commandButtons1.F6Visible = true;
            this.commandButtons1.F7Enabled = true;
            this.commandButtons1.F7LabelText = "F7";
            this.commandButtons1.F7LabelVisible = true;
            this.commandButtons1.F7Text = "";
            this.commandButtons1.F7Visible = true;
            this.commandButtons1.F8Enabled = true;
            this.commandButtons1.F8LabelText = "F8";
            this.commandButtons1.F8LabelVisible = true;
            this.commandButtons1.F8Text = "";
            this.commandButtons1.F8Visible = true;
            this.commandButtons1.F9Enabled = true;
            this.commandButtons1.F9LabelText = "F9";
            this.commandButtons1.F9LabelVisible = true;
            this.commandButtons1.F9Text = "";
            this.commandButtons1.F9Visible = false;
            this.commandButtons1.Location = new System.Drawing.Point(0, 188);
            this.commandButtons1.Name = "commandButtons1";
            this.commandButtons1.Size = new System.Drawing.Size(926, 68);
            this.commandButtons1.TabIndex = 0;
            this.commandButtons1.CommandButtonClickEvent += new WinCommandUserControlCS.UserControls.CommandButtons.CommandButtonClickHandler(this.commandButtons1_CommandButtonClickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 256);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.commandButtons1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CommandButtons commandButtons1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

