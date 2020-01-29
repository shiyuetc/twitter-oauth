namespace TwitterOauth
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.ConsumerSecretTextBox = new System.Windows.Forms.TextBox();
            this.ConsumerKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessTokenSecretTextBox = new System.Windows.Forms.TextBox();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CopyATSButton = new System.Windows.Forms.Button();
            this.CopyATButton = new System.Windows.Forms.Button();
            this.CopyCSButton = new System.Windows.Forms.Button();
            this.CopyCKButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsumerSecretTextBox
            // 
            this.ConsumerSecretTextBox.Enabled = false;
            this.ConsumerSecretTextBox.Location = new System.Drawing.Point(33, 77);
            this.ConsumerSecretTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsumerSecretTextBox.MaxLength = 999;
            this.ConsumerSecretTextBox.Name = "ConsumerSecretTextBox";
            this.ConsumerSecretTextBox.ReadOnly = true;
            this.ConsumerSecretTextBox.Size = new System.Drawing.Size(198, 19);
            this.ConsumerSecretTextBox.TabIndex = 7;
            // 
            // ConsumerKeyTextBox
            // 
            this.ConsumerKeyTextBox.Enabled = false;
            this.ConsumerKeyTextBox.Location = new System.Drawing.Point(33, 40);
            this.ConsumerKeyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsumerKeyTextBox.MaxLength = 999;
            this.ConsumerKeyTextBox.Name = "ConsumerKeyTextBox";
            this.ConsumerKeyTextBox.ReadOnly = true;
            this.ConsumerKeyTextBox.Size = new System.Drawing.Size(198, 19);
            this.ConsumerKeyTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "APIシークレットキー";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "APIキー";
            // 
            // AccessTokenSecretTextBox
            // 
            this.AccessTokenSecretTextBox.Enabled = false;
            this.AccessTokenSecretTextBox.Location = new System.Drawing.Point(33, 151);
            this.AccessTokenSecretTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccessTokenSecretTextBox.MaxLength = 999;
            this.AccessTokenSecretTextBox.Name = "AccessTokenSecretTextBox";
            this.AccessTokenSecretTextBox.ReadOnly = true;
            this.AccessTokenSecretTextBox.Size = new System.Drawing.Size(198, 19);
            this.AccessTokenSecretTextBox.TabIndex = 11;
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Enabled = false;
            this.AccessTokenTextBox.Location = new System.Drawing.Point(33, 114);
            this.AccessTokenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccessTokenTextBox.MaxLength = 999;
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.ReadOnly = true;
            this.AccessTokenTextBox.Size = new System.Drawing.Size(198, 19);
            this.AccessTokenTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "アクセストークンシークレット";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "アクセストークン";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CopyATSButton);
            this.groupBox2.Controls.Add(this.CopyATButton);
            this.groupBox2.Controls.Add(this.CopyCSButton);
            this.groupBox2.Controls.Add(this.CopyCKButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AccessTokenSecretTextBox);
            this.groupBox2.Controls.Add(this.ConsumerKeyTextBox);
            this.groupBox2.Controls.Add(this.AccessTokenTextBox);
            this.groupBox2.Controls.Add(this.ConsumerSecretTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 191);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "認証情報";
            // 
            // CopyATSButton
            // 
            this.CopyATSButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyATSButton.Image")));
            this.CopyATSButton.Location = new System.Drawing.Point(232, 149);
            this.CopyATSButton.Name = "CopyATSButton";
            this.CopyATSButton.Size = new System.Drawing.Size(23, 23);
            this.CopyATSButton.TabIndex = 15;
            this.CopyATSButton.UseVisualStyleBackColor = true;
            this.CopyATSButton.Click += new System.EventHandler(this.CopyATSButton_Click);
            // 
            // CopyATButton
            // 
            this.CopyATButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyATButton.Image")));
            this.CopyATButton.Location = new System.Drawing.Point(232, 112);
            this.CopyATButton.Name = "CopyATButton";
            this.CopyATButton.Size = new System.Drawing.Size(23, 23);
            this.CopyATButton.TabIndex = 14;
            this.CopyATButton.UseVisualStyleBackColor = true;
            this.CopyATButton.Click += new System.EventHandler(this.CopyATButton_Click);
            // 
            // CopyCSButton
            // 
            this.CopyCSButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyCSButton.Image")));
            this.CopyCSButton.Location = new System.Drawing.Point(232, 75);
            this.CopyCSButton.Name = "CopyCSButton";
            this.CopyCSButton.Size = new System.Drawing.Size(23, 23);
            this.CopyCSButton.TabIndex = 13;
            this.CopyCSButton.UseVisualStyleBackColor = true;
            this.CopyCSButton.Click += new System.EventHandler(this.CopyCSButton_Click);
            // 
            // CopyCKButton
            // 
            this.CopyCKButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyCKButton.Image")));
            this.CopyCKButton.Location = new System.Drawing.Point(232, 38);
            this.CopyCKButton.Name = "CopyCKButton";
            this.CopyCKButton.Size = new System.Drawing.Size(23, 23);
            this.CopyCKButton.TabIndex = 12;
            this.CopyCKButton.UseVisualStyleBackColor = true;
            this.CopyCKButton.Click += new System.EventHandler(this.CopyCKButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 216);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "認証成功";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ConsumerSecretTextBox;
        private System.Windows.Forms.TextBox ConsumerKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccessTokenSecretTextBox;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CopyATSButton;
        private System.Windows.Forms.Button CopyATButton;
        private System.Windows.Forms.Button CopyCSButton;
        private System.Windows.Forms.Button CopyCKButton;
    }
}