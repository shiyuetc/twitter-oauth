using CoreTweet;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using static CoreTweet.OAuth;

namespace TwitterOauth
{
    /// <summary>
    /// メインのフォーム
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 読み込むJSONファイルのパス
        /// </summary>
        const string KEY_PATH = "System/Keys.json";

        /// <summary>
        /// 認証用のセッション
        /// </summary>
        private OAuthSession Session { get; set; }

        /// <summary>
        /// 読み込んだアプリケーションキーの配列
        /// </summary>
        private Key[] Keys { get; set; }

        /// <summary>
        /// フォームのコンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 読み込みファイルが存在していれば読み込む
            if (File.Exists(KEY_PATH))
            {
                try
                {
                    this.Keys = Key.LoadJson(KEY_PATH);
                    foreach (Key key in this.Keys)
                    {
                        this.KeysComboBox.Items.Add(key.AppName);
                    }
                }
                catch
                {
                    MessageBox.Show(KEY_PATH + "の読み込みに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.KeysComboBox.Items.Count > 0)
            {
                this.KeysComboBox.SelectedIndex = 0;
            }
            else
            {
                this.FromTextRadioButton.Checked = true;
            }
        }

        /// <summary>
        /// デベロッパーリンクラベルのクリックイベント
        /// </summary>
        private void DevelopersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developer.twitter.com/en/apps");
        }

        /// <summary>
        /// ラジオボタンのチェック変更イベント
        /// </summary>
        private void FromRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.KeysComboBox.Enabled = this.FromRegisteredKeyRadioButton.Checked;
            this.ConsumerKeyTextBox.Enabled = this.FromTextRadioButton.Checked;
            this.ConsumerSecretTextBox.Enabled = this.FromTextRadioButton.Checked;
        }

        /// <summary>
        /// 認証ページを開くボタンのクリックイベント
        /// </summary>
        private void OpenAuthenticateButton_Click(object sender, EventArgs e)
        {
            // アプリケーションキーを代入
            string consumerKey = "", consumerSecret = "";
            if (this.FromRegisteredKeyRadioButton.Checked)
            {
                if (this.KeysComboBox.Items.Count > 0)
                {
                    consumerKey = this.Keys[this.KeysComboBox.SelectedIndex].ConsumerKey;
                    consumerSecret = this.Keys[this.KeysComboBox.SelectedIndex].ConsumerSecret;
                }
            }
            else
            {
                consumerKey = this.ConsumerKeyTextBox.Text.Trim();
                consumerSecret = this.ConsumerSecretTextBox.Text.Trim();
            }

            // 入力チェック
            if (consumerKey.Length == 0 || consumerSecret.Length == 0)
            {
                MessageBox.Show("APIキーまたはAPIシークレットキーが定義されていません。。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 認証ページを開く
            try
            {
                this.Session = Authorize(consumerKey, consumerSecret);
                System.Diagnostics.Process.Start(this.Session.AuthorizeUri.AbsoluteUri);
                this.SecondGroupBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 認証ボタンのクリックイベント
        /// </summary>
        private void AuthenticateButton_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (PINCodeTextBox.Text.Length == 0)
            {
                MessageBox.Show("PINコードが未入力です。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 認証
            try
            {
                this.SecondGroupBox.Enabled = false;
                Tokens token = OAuth.GetTokens(this.Session, this.PINCodeTextBox.Text);
                ResultForm f = new ResultForm(token);
                f.Left = this.Left + (this.Width - f.Width) / 2;
                f.Top = this.Top + (this.Height - f.Height) / 2;
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
