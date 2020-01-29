using Newtonsoft.Json;
using System.IO;

namespace TwitterOauth
{
    /// <summary>
    /// アクセスキーを定義するクラス
    /// </summary>
    public class Key
    {
        /// <summary>
        /// アプリケーション名
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName { get; set; }

        /// <summary>
        /// コンシューマーキー
        /// </summary>
        [JsonProperty("ConsumerKey")]
        public string ConsumerKey { get; set; }

        /// <summary>
        /// コンシューマーシークレット
        /// </summary>
        [JsonProperty("ConsumerSecret")]
        public string ConsumerSecret { get; set; }

        /// <summary>
        /// キーのクラスを初期化
        /// </summary>
        /// <param name="appName">アプリケーション名</param>
        /// <param name="consumerKey">コンシューマーキー</param>
        /// <param name="consumerSecret">コンシューマーシークレット</param>
        public Key(string appName, string consumerKey, string consumerSecret)
        {
            this.AppName = appName;
            this.ConsumerKey = consumerKey.Trim();
            this.ConsumerSecret = consumerSecret.Trim();
        }

        public static Key[] LoadJson(string path)
        {
            StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("Shift_JIS"));
            Key[] keys = JsonConvert.DeserializeObject<Key[]>(sr.ReadToEnd());
            sr.Close();
            return keys;
        }
    }
}
