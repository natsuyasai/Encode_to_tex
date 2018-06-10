namespace Encode_to_tex
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reftButton1 = new System.Windows.Forms.RadioButton();
            this.centerButton2 = new System.Windows.Forms.RadioButton();
            this.rightButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 295);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // reftButton1
            // 
            this.reftButton1.AutoSize = true;
            this.reftButton1.Location = new System.Drawing.Point(13, 29);
            this.reftButton1.Name = "reftButton1";
            this.reftButton1.Size = new System.Drawing.Size(57, 16);
            this.reftButton1.TabIndex = 2;
            this.reftButton1.TabStop = true;
            this.reftButton1.Text = "左寄せ";
            this.reftButton1.UseVisualStyleBackColor = true;
            // 
            // centerButton2
            // 
            this.centerButton2.AutoSize = true;
            this.centerButton2.Location = new System.Drawing.Point(76, 29);
            this.centerButton2.Name = "centerButton2";
            this.centerButton2.Size = new System.Drawing.Size(57, 16);
            this.centerButton2.TabIndex = 3;
            this.centerButton2.TabStop = true;
            this.centerButton2.Text = "中寄せ";
            this.centerButton2.UseVisualStyleBackColor = true;
            // 
            // rightButton3
            // 
            this.rightButton3.AutoSize = true;
            this.rightButton3.Location = new System.Drawing.Point(139, 29);
            this.rightButton3.Name = "rightButton3";
            this.rightButton3.Size = new System.Drawing.Size(57, 16);
            this.rightButton3.TabIndex = 4;
            this.rightButton3.TabStop = true;
            this.rightButton3.Text = "右寄せ";
            this.rightButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(289, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rightButton3);
            this.Controls.Add(this.centerButton2);
            this.Controls.Add(this.reftButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Encode_to_tex.Properties.Settings.Default, "MyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Encode_to_tex.Properties.Settings.Default.MyLocation;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "csv→textable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton reftButton1;
        private System.Windows.Forms.RadioButton centerButton2;
        private System.Windows.Forms.RadioButton rightButton3;
        private System.Windows.Forms.Button button1;
    }
}

