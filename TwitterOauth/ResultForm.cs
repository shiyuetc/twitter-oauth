using CoreTweet;
using System;
using System.Windows.Forms;

namespace TwitterOauth
{
    /// <summary>
    /// 認証結果を表示するフォーム
    /// </summary>
    public partial class ResultForm : Form
    {
        /// <summary>
        /// 認証情報
        /// </summary>
        private Tokens Token { get; }

        /// <summary>
        /// フォームのコンストラクタ
        /// </summary>
        /// <param name="token">認証情報</param>
        public ResultForm(Tokens token)
        {
            this.Token = token;
            InitializeComponent();
        }

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - @" + this.Token.ScreenName + "(" + this.Token.UserId + ")";
            this.ConsumerKeyTextBox.Text = this.Token.ConsumerKey;
            this.ConsumerSecretTextBox.Text = this.Token.ConsumerSecret;
            this.AccessTokenTextBox.Text = this.Token.AccessToken;
            this.AccessTokenSecretTextBox.Text = this.Token.AccessTokenSecret;
        }

        /// <summary>
        /// ConsumerKeyのコピーボタンのクリックイベント
        /// </summary>
        private void CopyCKButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.ConsumerKeyTextBox.Text);
        }

        /// <summary>
        /// ConsumerSecretのコピーボタンのクリックイベント
        /// </summary>
        private void CopyCSButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.ConsumerSecretTextBox.Text);
        }

        /// <summary>
        /// AccessTokenのコピーボタンのクリックイベント
        /// </summary>
        private void CopyATButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.AccessTokenTextBox.Text);
        }

        /// <summary>
        /// AccessTokenSecretのコピーボタンのクリックイベント
        /// </summary>
        private void CopyATSButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.AccessTokenSecretTextBox.Text);
        }
    }
}
