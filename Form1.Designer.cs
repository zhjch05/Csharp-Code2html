namespace Code2Html
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_top = new System.Windows.Forms.TextBox();
            this.txt_bot = new System.Windows.Forms.TextBox();
            this.btn_to = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 12);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(115, 38);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_top
            // 
            this.txt_top.Location = new System.Drawing.Point(12, 56);
            this.txt_top.Multiline = true;
            this.txt_top.Name = "txt_top";
            this.txt_top.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_top.Size = new System.Drawing.Size(996, 248);
            this.txt_top.TabIndex = 1;
            // 
            // txt_bot
            // 
            this.txt_bot.Location = new System.Drawing.Point(12, 310);
            this.txt_bot.Multiline = true;
            this.txt_bot.Name = "txt_bot";
            this.txt_bot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_bot.Size = new System.Drawing.Size(996, 236);
            this.txt_bot.TabIndex = 2;
            // 
            // btn_to
            // 
            this.btn_to.Location = new System.Drawing.Point(133, 12);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(115, 38);
            this.btn_to.TabIndex = 3;
            this.btn_to.Text = "To html";
            this.btn_to.UseVisualStyleBackColor = true;
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(254, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 38);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.txt_bot);
            this.Controls.Add(this.txt_top);
            this.Controls.Add(this.btn_open);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code to Html trancriber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_top;
        private System.Windows.Forms.TextBox txt_bot;
        private System.Windows.Forms.Button btn_to;
        private System.Windows.Forms.Button btn_clear;
    }
}

