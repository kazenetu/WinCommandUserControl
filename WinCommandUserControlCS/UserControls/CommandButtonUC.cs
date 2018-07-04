using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCommandUserControlCS.UserControls;

namespace WinCommandUserControlCS.UserControls
{
    /// <summary>
    /// コマンドボタン
    /// </summary>
    public partial class CommandButtonUC : UserControl
    {
        #region プロパティ

        /// <summary>
        /// コマンドボタン
        /// </summary>
        public Button CommandButton
        {
            get
            {
                return BtnCommand;
            }
        }

        /// <summary>
        /// ラベル
        /// </summary>
        public Label CommandLabel
        {
            get
            {
                return LblCommand;
            }
        }

        #endregion

        #region 発行イベント

        /// <summary>
        /// ボタンクリックイベント
        /// </summary>
        public event EventHandler ClickEvent;

        #endregion

        #region イベント

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CommandButtonUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCommand_Click(object sender, EventArgs e)
        {
            ClickEvent(this, new EventArgs());
        }

        #endregion

    }
}
