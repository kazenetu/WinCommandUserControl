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

        #region Command.ESC

        /// <summary>
        /// ESCボタンテキスト設定・取得
        /// </summary>
        [Category("Command.ESC"), Description("ボタンのテキストの取得・設定")]
        public string ESCText
        {
            set
            {
                GetButton(CbESC).Text = value;
            }
            get
            {
                return GetButton(CbESC).Text;
            }
        }

        /// <summary>
        /// ESCラベルテキストの取得・設定
        /// </summary>
        [Category("Command.ESC"), Description("ラベルのテキストの取得・設定")]
        public string ESCLabelText
        {
            set
            {
                GeLabel(CbESC).Text = value;
            }
            get
            {
                return GeLabel(CbESC).Text;
            }
        }

        /// <summary>
        /// ESCボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.ESC"), Description("ボタンの表示状態の取得・設定")]
        public bool ESCVisible
        {
            set
            {
                GetButton(CbESC).Visible = value;
            }
            get
            {
                return GetButton(CbESC).Visible;
            }
        }

        /// <summary>
        /// ESCラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.ESC"), Description("ラベルの表示状態の取得・設定")]
        public bool ESCLabelVisible
        {
            set
            {
                GeLabel(CbESC).Visible = value;
            }
            get
            {
                return GeLabel(CbESC).Visible;
            }
        }

        /// <summary>
        /// ESCボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.ESC"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool ESCEnabled
        {
            set
            {
                GetButton(CbESC).Enabled = value;
            }
            get
            {
                return GetButton(CbESC).Enabled;
            }
        }

        #endregion

        #region Command.F1

        /// <summary>
        /// F1ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F1"), Description("ボタンのテキストの取得・設定")]
        public string F1Text
        {
            set
            {
                GetButton(CbF1).Text = value;
            }
            get
            {
                return GetButton(CbF1).Text;
            }
        }

        /// <summary>
        /// F1ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F1"), Description("ラベルのテキストの取得・設定")]
        public string F1LabelText
        {
            set
            {
                GeLabel(CbF1).Text = value;
            }
            get
            {
                return GeLabel(CbF1).Text;
            }
        }

        /// <summary>
        /// F1ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F1"), Description("ボタンの表示状態の取得・設定")]
        public bool F1Visible
        {
            set
            {
                GetButton(CbF1).Visible = value;
            }
            get
            {
                return GetButton(CbF1).Visible;
            }
        }

        /// <summary>
        /// F1ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F1"), Description("ラベルの表示状態の取得・設定")]
        public bool F1LabelVisible
        {
            set
            {
                GeLabel(CbF1).Visible = value;
            }
            get
            {
                return GeLabel(CbF1).Visible;
            }
        }

        /// <summary>
        /// F1ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F1"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F1Enabled
        {
            set
            {
                GetButton(CbF1).Enabled = value;
            }
            get
            {
                return GetButton(CbF1).Enabled;
            }
        }

        #endregion

        #region Command.F2

        /// <summary>
        /// F2ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F2"), Description("ボタンのテキストの取得・設定")]
        public string F2Text
        {
            set
            {
                GetButton(CbF2).Text = value;
            }
            get
            {
                return GetButton(CbF2).Text;
            }
        }

        /// <summary>
        /// F2ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F2"), Description("ラベルのテキストの取得・設定")]
        public string F2LabelText
        {
            set
            {
                GeLabel(CbF2).Text = value;
            }
            get
            {
                return GeLabel(CbF2).Text;
            }
        }

        /// <summary>
        /// F2ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F2"), Description("ボタンの表示状態の取得・設定")]
        public bool F2Visible
        {
            set
            {
                GetButton(CbF2).Visible = value;
            }
            get
            {
                return GetButton(CbF2).Visible;
            }
        }

        /// <summary>
        /// F2ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F2"), Description("ラベルの表示状態の取得・設定")]
        public bool F2LabelVisible
        {
            set
            {
                GeLabel(CbF2).Visible = value;
            }
            get
            {
                return GeLabel(CbF2).Visible;
            }
        }

        /// <summary>
        /// F2ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F2"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F2Enabled
        {
            set
            {
                GetButton(CbF2).Enabled = value;
            }
            get
            {
                return GetButton(CbF2).Enabled;
            }
        }

        #endregion

        #region Command.F3

        /// <summary>
        /// F3ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F3"), Description("ボタンのテキストの取得・設定")]
        public string F3Text
        {
            set
            {
                GetButton(CbF3).Text = value;
            }
            get
            {
                return GetButton(CbF3).Text;
            }
        }

        /// <summary>
        /// F3ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F3"), Description("ラベルのテキストの取得・設定")]
        public string F3LabelText
        {
            set
            {
                GeLabel(CbF3).Text = value;
            }
            get
            {
                return GeLabel(CbF3).Text;
            }
        }

        /// <summary>
        /// F3ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F3"), Description("ボタンの表示状態の取得・設定")]
        public bool F3Visible
        {
            set
            {
                GetButton(CbF3).Visible = value;
            }
            get
            {
                return GetButton(CbF3).Visible;
            }
        }

        /// <summary>
        /// F3ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F3"), Description("ラベルの表示状態の取得・設定")]
        public bool F3LabelVisible
        {
            set
            {
                GeLabel(CbF3).Visible = value;
            }
            get
            {
                return GeLabel(CbF3).Visible;
            }
        }

        /// <summary>
        /// F3ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F3"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F3Enabled
        {
            set
            {
                GetButton(CbF3).Enabled = value;
            }
            get
            {
                return GetButton(CbF3).Enabled;
            }
        }

        #endregion

        #region Command.F4

        /// <summary>
        /// F4ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F4"), Description("ボタンのテキストの取得・設定")]
        public string F4Text
        {
            set
            {
                GetButton(CbF4).Text = value;
            }
            get
            {
                return GetButton(CbF4).Text;
            }
        }

        /// <summary>
        /// F4ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F4"), Description("ラベルのテキストの取得・設定")]
        public string F4LabelText
        {
            set
            {
                GeLabel(CbF4).Text = value;
            }
            get
            {
                return GeLabel(CbF4).Text;
            }
        }

        /// <summary>
        /// F4ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F4"), Description("ボタンの表示状態の取得・設定")]
        public bool F4Visible
        {
            set
            {
                GetButton(CbF4).Visible = value;
            }
            get
            {
                return GetButton(CbF4).Visible;
            }
        }

        /// <summary>
        /// F4ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F4"), Description("ラベルの表示状態の取得・設定")]
        public bool F4LabelVisible
        {
            set
            {
                GeLabel(CbF4).Visible = value;
            }
            get
            {
                return GeLabel(CbF4).Visible;
            }
        }

        /// <summary>
        /// F4ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F4"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F4Enabled
        {
            set
            {
                GetButton(CbF4).Enabled = value;
            }
            get
            {
                return GetButton(CbF4).Enabled;
            }
        }

        #endregion

        #region Command.F5

        /// <summary>
        /// F5ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F5"), Description("ボタンのテキストの取得・設定")]
        public string F5Text
        {
            set
            {
                GetButton(CbF5).Text = value;
            }
            get
            {
                return GetButton(CbF5).Text;
            }
        }

        /// <summary>
        /// F5ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F5"), Description("ラベルのテキストの取得・設定")]
        public string F5LabelText
        {
            set
            {
                GeLabel(CbF5).Text = value;
            }
            get
            {
                return GeLabel(CbF5).Text;
            }
        }

        /// <summary>
        /// F5ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F5"), Description("ボタンの表示状態の取得・設定")]
        public bool F5Visible
        {
            set
            {
                GetButton(CbF5).Visible = value;
            }
            get
            {
                return GetButton(CbF5).Visible;
            }
        }

        /// <summary>
        /// F5ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F5"), Description("ラベルの表示状態の取得・設定")]
        public bool F5LabelVisible
        {
            set
            {
                GeLabel(CbF5).Visible = value;
            }
            get
            {
                return GeLabel(CbF5).Visible;
            }
        }

        /// <summary>
        /// F5ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F5"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F5Enabled
        {
            set
            {
                GetButton(CbF5).Enabled = value;
            }
            get
            {
                return GetButton(CbF5).Enabled;
            }
        }

        #endregion

        #region Command.F6

        /// <summary>
        /// F6ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F6"), Description("ボタンのテキストの取得・設定")]
        public string F6Text
        {
            set
            {
                GetButton(CbF6).Text = value;
            }
            get
            {
                return GetButton(CbF6).Text;
            }
        }

        /// <summary>
        /// F6ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F6"), Description("ラベルのテキストの取得・設定")]
        public string F6LabelText
        {
            set
            {
                GeLabel(CbF6).Text = value;
            }
            get
            {
                return GeLabel(CbF6).Text;
            }
        }

        /// <summary>
        /// F6ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F6"), Description("ボタンの表示状態の取得・設定")]
        public bool F6Visible
        {
            set
            {
                GetButton(CbF6).Visible = value;
            }
            get
            {
                return GetButton(CbF6).Visible;
            }
        }

        /// <summary>
        /// F6ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F6"), Description("ラベルの表示状態の取得・設定")]
        public bool F6LabelVisible
        {
            set
            {
                GeLabel(CbF6).Visible = value;
            }
            get
            {
                return GeLabel(CbF6).Visible;
            }
        }

        /// <summary>
        /// F6ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F6"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F6Enabled
        {
            set
            {
                GetButton(CbF6).Enabled = value;
            }
            get
            {
                return GetButton(CbF6).Enabled;
            }
        }

        #endregion

        #region Command.F7

        /// <summary>
        /// F7ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F7"), Description("ボタンのテキストの取得・設定")]
        public string F7Text
        {
            set
            {
                GetButton(CbF7).Text = value;
            }
            get
            {
                return GetButton(CbF7).Text;
            }
        }

        /// <summary>
        /// F7ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F7"), Description("ラベルのテキストの取得・設定")]
        public string F7LabelText
        {
            set
            {
                GeLabel(CbF7).Text = value;
            }
            get
            {
                return GeLabel(CbF7).Text;
            }
        }

        /// <summary>
        /// F7ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F7"), Description("ボタンの表示状態の取得・設定")]
        public bool F7Visible
        {
            set
            {
                GetButton(CbF7).Visible = value;
            }
            get
            {
                return GetButton(CbF7).Visible;
            }
        }

        /// <summary>
        /// F7ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F7"), Description("ラベルの表示状態の取得・設定")]
        public bool F7LabelVisible
        {
            set
            {
                GeLabel(CbF7).Visible = value;
            }
            get
            {
                return GeLabel(CbF7).Visible;
            }
        }

        /// <summary>
        /// F7ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F7"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F7Enabled
        {
            set
            {
                GetButton(CbF7).Enabled = value;
            }
            get
            {
                return GetButton(CbF7).Enabled;
            }
        }

        #endregion

        #region Command.F8

        /// <summary>
        /// F8ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F8"), Description("ボタンのテキストの取得・設定")]
        public string F8Text
        {
            set
            {
                GetButton(CbF8).Text = value;
            }
            get
            {
                return GetButton(CbF8).Text;
            }
        }

        /// <summary>
        /// F8ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F8"), Description("ラベルのテキストの取得・設定")]
        public string F8LabelText
        {
            set
            {
                GeLabel(CbF8).Text = value;
            }
            get
            {
                return GeLabel(CbF8).Text;
            }
        }

        /// <summary>
        /// F8ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F8"), Description("ボタンの表示状態の取得・設定")]
        public bool F8Visible
        {
            set
            {
                GetButton(CbF8).Visible = value;
            }
            get
            {
                return GetButton(CbF8).Visible;
            }
        }

        /// <summary>
        /// F8ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F8"), Description("ラベルの表示状態の取得・設定")]
        public bool F8LabelVisible
        {
            set
            {
                GeLabel(CbF8).Visible = value;
            }
            get
            {
                return GeLabel(CbF8).Visible;
            }
        }

        /// <summary>
        /// F8ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F8"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F8Enabled
        {
            set
            {
                GetButton(CbF8).Enabled = value;
            }
            get
            {
                return GetButton(CbF8).Enabled;
            }
        }

        #endregion

        #region Command.F9

        /// <summary>
        /// F9ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F9"), Description("ボタンのテキストの取得・設定")]
        public string F9Text
        {
            set
            {
                GetButton(CbF9).Text = value;
            }
            get
            {
                return GetButton(CbF9).Text;
            }
        }

        /// <summary>
        /// F9ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F9"), Description("ラベルのテキストの取得・設定")]
        public string F9LabelText
        {
            set
            {
                GeLabel(CbF9).Text = value;
            }
            get
            {
                return GeLabel(CbF9).Text;
            }
        }

        /// <summary>
        /// F9ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F9"), Description("ボタンの表示状態の取得・設定")]
        public bool F9Visible
        {
            set
            {
                GetButton(CbF9).Visible = value;
            }
            get
            {
                return GetButton(CbF9).Visible;
            }
        }

        /// <summary>
        /// F9ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F9"), Description("ラベルの表示状態の取得・設定")]
        public bool F9LabelVisible
        {
            set
            {
                GeLabel(CbF9).Visible = value;
            }
            get
            {
                return GeLabel(CbF9).Visible;
            }
        }

        /// <summary>
        /// F9ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F9"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F9Enabled
        {
            set
            {
                GetButton(CbF9).Enabled = value;
            }
            get
            {
                return GetButton(CbF9).Enabled;
            }
        }

        #endregion

        #region Command.F10

        /// <summary>
        /// F10ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F10"), Description("ボタンのテキストの取得・設定")]
        public string F10Text
        {
            set
            {
                GetButton(CbF10).Text = value;
            }
            get
            {
                return GetButton(CbF10).Text;
            }
        }

        /// <summary>
        /// F10ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F10"), Description("ラベルのテキストの取得・設定")]
        public string F10LabelText
        {
            set
            {
                GeLabel(CbF10).Text = value;
            }
            get
            {
                return GeLabel(CbF10).Text;
            }
        }

        /// <summary>
        /// F10ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F10"), Description("ボタンの表示状態の取得・設定")]
        public bool F10Visible
        {
            set
            {
                GetButton(CbF10).Visible = value;
            }
            get
            {
                return GetButton(CbF10).Visible;
            }
        }

        /// <summary>
        /// F10ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F10"), Description("ラベルの表示状態の取得・設定")]
        public bool F10LabelVisible
        {
            set
            {
                GeLabel(CbF10).Visible = value;
            }
            get
            {
                return GeLabel(CbF10).Visible;
            }
        }

        /// <summary>
        /// F10ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F10"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F10Enabled
        {
            set
            {
                GetButton(CbF10).Enabled = value;
            }
            get
            {
                return GetButton(CbF10).Enabled;
            }
        }

        #endregion

        #region Command.F11

        /// <summary>
        /// F11ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F11"), Description("ボタンのテキストの取得・設定")]
        public string F11Text
        {
            set
            {
                GetButton(CbF11).Text = value;
            }
            get
            {
                return GetButton(CbF11).Text;
            }
        }

        /// <summary>
        /// F11ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F11"), Description("ラベルのテキストの取得・設定")]
        public string F11LabelText
        {
            set
            {
                GeLabel(CbF11).Text = value;
            }
            get
            {
                return GeLabel(CbF11).Text;
            }
        }

        /// <summary>
        /// F11ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F11"), Description("ボタンの表示状態の取得・設定")]
        public bool F11Visible
        {
            set
            {
                GetButton(CbF11).Visible = value;
            }
            get
            {
                return GetButton(CbF11).Visible;
            }
        }

        /// <summary>
        /// F11ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F11"), Description("ラベルの表示状態の取得・設定")]
        public bool F11LabelVisible
        {
            set
            {
                GeLabel(CbF11).Visible = value;
            }
            get
            {
                return GeLabel(CbF11).Visible;
            }
        }

        /// <summary>
        /// F11ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F11"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F11Enabled
        {
            set
            {
                GetButton(CbF11).Enabled = value;
            }
            get
            {
                return GetButton(CbF11).Enabled;
            }
        }

        #endregion

        #region Command.F12

        /// <summary>
        /// F12ボタンテキスト設定・取得
        /// </summary>
        [Category("Command.F12"), Description("ボタンのテキストの取得・設定")]
        public string F12Text
        {
            set
            {
                GetButton(CbF12).Text = value;
            }
            get
            {
                return GetButton(CbF12).Text;
            }
        }

        /// <summary>
        /// F12ラベルテキストの取得・設定
        /// </summary>
        [Category("Command.F12"), Description("ラベルのテキストの取得・設定")]
        public string F12LabelText
        {
            set
            {
                GeLabel(CbF12).Text = value;
            }
            get
            {
                return GeLabel(CbF12).Text;
            }
        }

        /// <summary>
        /// F12ボタン表示状態の取得・設定
        /// </summary>
        [Category("Command.F12"), Description("ボタンの表示状態の取得・設定")]
        public bool F12Visible
        {
            set
            {
                GetButton(CbF12).Visible = value;
            }
            get
            {
                return GetButton(CbF12).Visible;
            }
        }

        /// <summary>
        /// F12ラベル表示状態の取得・設定
        /// </summary>
        [Category("Command.F12"), Description("ラベルの表示状態の取得・設定")]
        public bool F12LabelVisible
        {
            set
            {
                GeLabel(CbF12).Visible = value;
            }
            get
            {
                return GeLabel(CbF12).Visible;
            }
        }

        /// <summary>
        /// F12ボタン有効/無効状態の取得・設定
        /// </summary>
        [Category("Command.F12"), Description("ボタンの有効/無効状態の取得・設定")]
        public bool F12Enabled
        {
            set
            {
                GetButton(CbF12).Enabled = value;
            }
            get
            {
                return GetButton(CbF12).Enabled;
            }
        }

        #endregion

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

            // ボタンが有効か確認
            var button = keyCommandButtonUCMapping[e.KeyCode];
            if (!button.CommandButton.Visible || !button.CommandButton.Enabled)
            {
                return;
            }

            e.SuppressKeyPress = true;
            ClickEvent(button, new EventArgs());
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

        #region インスタンスメソッド

        /// <summary>
        /// ボタン取得
        /// </summary>
        /// <param name="target">対象のボタンコントロール</param>
        private Button GetButton(CommandButtonUC target)
        {
            return target.CommandButton;
        }

        /// <summary>
        /// ラベル取得
        /// </summary>
        /// <param name="target"></param>
        /// <param name="target">対象のボタンコントロール</param>
        private Label GeLabel(CommandButtonUC target)
        {
            return target.CommandLabel;
        }

        #endregion

        #region 関連クラス

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
        
        #endregion

    }
}
