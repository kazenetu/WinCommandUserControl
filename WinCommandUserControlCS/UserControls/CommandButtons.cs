using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinCommandUserControlCS.UserControls.CommandButtons;

namespace WinCommandUserControlCS.UserControls
{
    public partial class CommandButtons : UserControl
    {
        #region 列挙型

        /// <summary>
        /// ボタン種別
        /// </summary>
        public enum Kind
        {
            NONE = -1,
            ESC = 0,
            F1,
            F2,
            F3,
            F4,
            F5,
            F6,
            F7,
            F8,
            F9,
            F10,
            F11,
            F12
        }

        #endregion

        #region プロパティ
        #endregion

        #region 発行イベント

        /// <summary>
        /// ボタンクリックハンドラー
        /// </summary>
        /// <param name="sender">本ユーザーコントロール</param>
        /// <param name="e">ボタンコントロールとボタン種別</param>
        public delegate void CommandButtonClickHandler(object sender, CommandUCArgs e);

        /// <summary>
        /// ボタンコントロールクリックイベント
        /// </summary>
        public event CommandButtonClickHandler CommandButtonClickEvent;

        #endregion

        #region イベント

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CommandButtons()
        {
            InitializeComponent();

            // ボタンの位置調整
            var left = PnlCommand.Left + 5;
            var top = CbESC.Top;
            left = SetButtonPosition(CbESC, left, top);
            left = SetButtonPosition(CbF1, left, top);
            left = SetButtonPosition(CbF2, left, top);
            left = SetButtonPosition(CbF3, left, top);
            left = SetButtonPosition(CbF4, left, top);
            left = SetButtonPosition(CbF5, left, top);
            left = SetButtonPosition(CbF6, left, top);
            left = SetButtonPosition(CbF7, left, top);
            left = SetButtonPosition(CbF8, left, top);
            left = SetButtonPosition(CbF9, left, top);
            left = SetButtonPosition(CbF10, left, top);
            left = SetButtonPosition(CbF11, left, top);
            left = SetButtonPosition(CbF12, left, top);
        }

        /// <summary>
        /// ボタンコントロールのクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickEvent(object sender,EventArgs e)
        {
            if(!(sender is CommandButtonUC))
            {
                return;
            }

            if(CommandButtonClickEvent == null)
            {
                return;
            }

            var button = sender as CommandButtonUC;
            var kindName = button.Name.Replace("Cb", string.Empty);
            var kind = Kind.NONE;
            if(Enum.TryParse<Kind>(kindName, out kind))
            {
                CommandButtonClickEvent(this, new CommandUCArgs(button, kind));
            }
        }

        /// <summary>
        /// 親フォームのキーダウンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CommandButtonKeyDown(object sender, KeyEventArgs e)
        {
            var keyCommandButtonUCMapping = new Dictionary<Keys, CommandButtonUC>()
            {
                {Keys.Escape,CbESC },
                {Keys.F1,CbF1 },
                {Keys.F2,CbF2 },
                {Keys.F3,CbF3 },
                {Keys.F4,CbF4 },
                {Keys.F5,CbF5 },
                {Keys.F6,CbF6 },
                {Keys.F7,CbF7 },
                {Keys.F8,CbF8 },
                {Keys.F9,CbF9 },
                {Keys.F10,CbF10 },
                {Keys.F11,CbF11 },
                {Keys.F12,CbF12 }
            };

            if (!keyCommandButtonUCMapping.Keys.Contains(e.KeyCode))
            {
                return;
            }
            e.SuppressKeyPress = true;
            ClickEvent(keyCommandButtonUCMapping[e.KeyCode],new EventArgs());
        }

        /// <summary>
        /// コマンドボタンの位置設定
        /// </summary>
        /// <param name="targetButton">コマンドボタンインスタンス</param>
        /// <param name="left">X位置</param>
        /// <param name="top">Y位置</param>
        /// <returns></returns>
        private int SetButtonPosition(CommandButtonUC targetButton,int left,int top)
        {
            // ボタンの位置調整
            targetButton.Left = left;
            targetButton.Top = top;

            // ラベルを設定
            targetButton.LblCommand.Text = targetButton.Name.Replace("Cb", string.Empty);

            // 新しいX位置を返す
            return left + targetButton.Width + 5;
        }

        /// <summary>
        /// ページロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommandButtons_Load(object sender, EventArgs e)
        {
            // デザインモード時はそのまま終了
            if (DesignMode)
            {
                return;
            }

            // クリックイベント設定
            foreach(var control in PnlCommand.Controls)
            {
                var button = control as CommandButtonUC;
                if (button != null)
                {
                    button.ClickEvent += ClickEvent;
                }
            }

            // キーダウンイベント設定
            if(ParentForm  != null)
            {
                ParentForm.KeyDown += CommandButtonKeyDown;
            }
        }

        #endregion

        /// <summary>
        /// ボタンコントロールを含めたイベントデータ
        /// </summary>
        public class CommandUCArgs : EventArgs
        {
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="target">ボタンコントロール</param>
            /// <param name="targetKind">ボタン種別</param>
            public CommandUCArgs(CommandButtonUC target, Kind targetKind)
            {
                Target = target;
                TargetKind = targetKind;
            }

            /// <summary>
            /// ボタンコントロール
            /// </summary>
            public CommandButtonUC Target { get; }

            /// <summary>
            /// ボタン種別
            /// </summary>
            public Kind TargetKind { get; }
        }
    }
}
