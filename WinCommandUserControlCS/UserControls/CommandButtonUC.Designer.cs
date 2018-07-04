namespace WinCommandUserControlCS.UserControls
{
    partial class CommandButtonUC
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCommand = new System.Windows.Forms.Label();
            this.BtnCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCommand
            // 
            this.LblCommand.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblCommand.Location = new System.Drawing.Point(0, 3);
            this.LblCommand.Name = "LblCommand";
            this.LblCommand.Size = new System.Drawing.Size(65, 12);
            this.LblCommand.TabIndex = 3;
            this.LblCommand.Text = "Label1";
            this.LblCommand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnCommand
            // 
            this.BtnCommand.Location = new System.Drawing.Point(0, 18);
            this.BtnCommand.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCommand.Name = "BtnCommand";
            this.BtnCommand.Size = new System.Drawing.Size(65, 35);
            this.BtnCommand.TabIndex = 2;
            this.BtnCommand.UseVisualStyleBackColor = true;
            this.BtnCommand.Click += new System.EventHandler(this.BtnCommand_Click);
            // 
            // CommandButtonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblCommand);
            this.Controls.Add(this.BtnCommand);
            this.Name = "CommandButtonUC";
            this.Size = new System.Drawing.Size(65, 56);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LblCommand;
        internal System.Windows.Forms.Button BtnCommand;
    }
}
