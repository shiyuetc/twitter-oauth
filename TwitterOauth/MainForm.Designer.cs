namespace TwitterOauth
{
    partial class MainForm
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
            this.FirstGroupBox = new System.Windows.Forms.GroupBox();
            this.KeysComboBox = new System.Windows.Forms.ComboBox();
            this.FromTextRadioButton = new System.Windows.Forms.RadioButton();
            this.FromRegisteredKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.ConsumerSecretTextBox = new System.Windows.Forms.TextBox();
            this.ConsumerKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenAuthenticateButton = new System.Windows.Forms.Button();
            this.SecondGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthenticateButton = new System.Windows.Forms.Button();
            this.PINCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DevelopersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FirstGroupBox.SuspendLayout();
            this.SecondGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstGroupBox
            // 
            this.FirstGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstGroupBox.Controls.Add(this.KeysComboBox);
            this.FirstGroupBox.Controls.Add(this.FromTextRadioButton);
            this.FirstGroupBox.Controls.Add(this.FromRegisteredKeyRadioButton);
            this.FirstGroupBox.Controls.Add(this.ConsumerSecretTextBox);
            this.FirstGroupBox.Controls.Add(this.ConsumerKeyTextBox);
            this.FirstGroupBox.Controls.Add(this.label2);
            this.FirstGroupBox.Controls.Add(this.label1);
            this.FirstGroupBox.Controls.Add(this.OpenAuthenticateButton);
            this.FirstGroupBox.Location = new System.Drawing.Point(12, 24);
            this.FirstGroupBox.Name = "FirstGroupBox";
            this.FirstGroupBox.Size = new System.Drawing.Size(289, 223);
            this.FirstGroupBox.TabIndex = 0;
            this.FirstGroupBox.TabStop = false;
            this.FirstGroupBox.Text = "1. 使用するアプリケーションキーを選択";
            // 
            // KeysComboBox
            // 
            this.KeysComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeysComboBox.FormattingEnabled = true;
            this.KeysComboBox.Location = new System.Drawing.Point(33, 46);
            this.KeysComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KeysComboBox.Name = "KeysComboBox";
            this.KeysComboBox.Size = new System.Drawing.Size(222, 20);
            this.KeysComboBox.TabIndex = 6;
            // 
            // FromTextRadioButton
            // 
            this.FromTextRadioButton.AutoSize = true;
            this.FromTextRadioButton.Location = new System.Drawing.Point(22, 79);
            this.FromTextRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromTextRadioButton.Name = "FromTextRadioButton";
            this.FromTextRadioButton.Size = new System.Drawing.Size(151, 16);
            this.FromTextRadioButton.TabIndex = 5;
            this.FromTextRadioButton.Text = "テキストからキーを読み込む";
            this.FromTextRadioButton.UseVisualStyleBackColor = true;
            this.FromTextRadioButton.CheckedChanged += new System.EventHandler(this.FromRadioButton_CheckedChanged);
            // 
            // FromRegisteredKeyRadioButton
            // 
            this.FromRegisteredKeyRadioButton.AutoSize = true;
            this.FromRegisteredKeyRadioButton.Checked = true;
            this.FromRegisteredKeyRadioButton.Location = new System.Drawing.Point(22, 26);
            this.FromRegisteredKeyRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromRegisteredKeyRadioButton.Name = "FromRegisteredKeyRadioButton";
            this.FromRegisteredKeyRadioButton.Size = new System.Drawing.Size(133, 16);
            this.FromRegisteredKeyRadioButton.TabIndex = 4;
            this.FromRegisteredKeyRadioButton.TabStop = true;
            this.FromRegisteredKeyRadioButton.Text = "登録済みのキーを使用";
            this.FromRegisteredKeyRadioButton.UseVisualStyleBackColor = true;
            this.FromRegisteredKeyRadioButton.CheckedChanged += new System.EventHandler(this.FromRadioButton_CheckedChanged);
            // 
            // ConsumerSecretTextBox
            // 
            this.ConsumerSecretTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerSecretTextBox.Enabled = false;
            this.ConsumerSecretTextBox.Location = new System.Drawing.Point(33, 150);
            this.ConsumerSecretTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsumerSecretTextBox.MaxLength = 999;
            this.ConsumerSecretTextBox.Name = "ConsumerSecretTextBox";
            this.ConsumerSecretTextBox.Size = new System.Drawing.Size(222, 19);
            this.ConsumerSecretTextBox.TabIndex = 3;
            // 
            // ConsumerKeyTextBox
            // 
            this.ConsumerKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerKeyTextBox.Enabled = false;
            this.ConsumerKeyTextBox.Location = new System.Drawing.Point(33, 113);
            this.ConsumerKeyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsumerKeyTextBox.MaxLength = 999;
            this.ConsumerKeyTextBox.Name = "ConsumerKeyTextBox";
            this.ConsumerKeyTextBox.Size = new System.Drawing.Size(222, 19);
            this.ConsumerKeyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "APIシークレットキー";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "APIキー";
            // 
            // OpenAuthenticateButton
            // 
            this.OpenAuthenticateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenAuthenticateButton.Location = new System.Drawing.Point(33, 180);
            this.OpenAuthenticateButton.Name = "OpenAuthenticateButton";
            this.OpenAuthenticateButton.Size = new System.Drawing.Size(222, 23);
            this.OpenAuthenticateButton.TabIndex = 0;
            this.OpenAuthenticateButton.Text = "認証ページを開く";
            this.OpenAuthenticateButton.UseVisualStyleBackColor = true;
            this.OpenAuthenticateButton.Click += new System.EventHandler(this.OpenAuthenticateButton_Click);
            // 
            // SecondGroupBox
            // 
            this.SecondGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondGroupBox.Controls.Add(this.AuthenticateButton);
            this.SecondGroupBox.Controls.Add(this.PINCodeTextBox);
            this.SecondGroupBox.Controls.Add(this.label3);
            this.SecondGroupBox.Enabled = false;
            this.SecondGroupBox.Location = new System.Drawing.Point(12, 253);
            this.SecondGroupBox.Name = "SecondGroupBox";
            this.SecondGroupBox.Size = new System.Drawing.Size(289, 83);
            this.SecondGroupBox.TabIndex = 1;
            this.SecondGroupBox.TabStop = false;
            this.SecondGroupBox.Text = "2. 認証(トークンの発行)";
            // 
            // AuthenticateButton
            // 
            this.AuthenticateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticateButton.Location = new System.Drawing.Point(180, 40);
            this.AuthenticateButton.Name = "AuthenticateButton";
            this.AuthenticateButton.Size = new System.Drawing.Size(75, 23);
            this.AuthenticateButton.TabIndex = 4;
            this.AuthenticateButton.Text = "認証";
            this.AuthenticateButton.UseVisualStyleBackColor = true;
            this.AuthenticateButton.Click += new System.EventHandler(this.AuthenticateButton_Click);
            // 
            // PINCodeTextBox
            // 
            this.PINCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PINCodeTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PINCodeTextBox.Location = new System.Drawing.Point(33, 40);
            this.PINCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PINCodeTextBox.MaxLength = 7;
            this.PINCodeTextBox.Name = "PINCodeTextBox";
            this.PINCodeTextBox.Size = new System.Drawing.Size(141, 23);
            this.PINCodeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "PINコード";
            // 
            // DevelopersLinkLabel
            // 
            this.DevelopersLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DevelopersLinkLabel.AutoSize = true;
            this.DevelopersLinkLabel.Location = new System.Drawing.Point(199, 9);
            this.DevelopersLinkLabel.Name = "DevelopersLinkLabel";
            this.DevelopersLinkLabel.Size = new System.Drawing.Size(102, 12);
            this.DevelopersLinkLabel.TabIndex = 2;
            this.DevelopersLinkLabel.TabStop = true;
            this.DevelopersLinkLabel.Text = "Twitter Developers";
            this.DevelopersLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DevelopersLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 346);
            this.Controls.Add(this.DevelopersLinkLabel);
            this.Controls.Add(this.SecondGroupBox);
            this.Controls.Add(this.FirstGroupBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TwitterOauth";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FirstGroupBox.ResumeLayout(false);
            this.FirstGroupBox.PerformLayout();
            this.SecondGroupBox.ResumeLayout(false);
            this.SecondGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FirstGroupBox;
        private System.Windows.Forms.ComboBox KeysComboBox;
        private System.Windows.Forms.RadioButton FromTextRadioButton;
        private System.Windows.Forms.RadioButton FromRegisteredKeyRadioButton;
        private System.Windows.Forms.TextBox ConsumerSecretTextBox;
        private System.Windows.Forms.TextBox ConsumerKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenAuthenticateButton;
        private System.Windows.Forms.GroupBox SecondGroupBox;
        private System.Windows.Forms.Button AuthenticateButton;
        private System.Windows.Forms.TextBox PINCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel DevelopersLinkLabel;
    }
}

