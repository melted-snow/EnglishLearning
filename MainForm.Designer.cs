
namespace EnglishLearning
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.TestButton = new System.Windows.Forms.Button();
            this.WordListButton = new System.Windows.Forms.Button();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(145, 114);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "テスト";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // WordListButton
            // 
            this.WordListButton.Location = new System.Drawing.Point(145, 193);
            this.WordListButton.Name = "WordListButton";
            this.WordListButton.Size = new System.Drawing.Size(75, 23);
            this.WordListButton.TabIndex = 1;
            this.WordListButton.Text = "単語管理";
            this.WordListButton.UseVisualStyleBackColor = true;
            this.WordListButton.Click += new System.EventHandler(this.WordListButton_Click);
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(145, 271);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FileSelectButton.TabIndex = 2;
            this.FileSelectButton.Text = "ファイル変更";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.WordListButton);
            this.Controls.Add(this.TestButton);
            this.Name = "MainForm";
            this.Text = "メイン画面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button WordListButton;
        private System.Windows.Forms.Button FileSelectButton;
    }
}

