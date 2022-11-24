namespace Web_Browser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_window = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_setings = new System.Windows.Forms.Button();
            this.btn_favorite = new System.Windows.Forms.Button();
            this.btn_search1 = new System.Windows.Forms.Button();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_forword = new System.Windows.Forms.Button();
            this.btn_refrash = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.browser_comboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_historyHide = new System.Windows.Forms.Button();
            this.btn_historyClear = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_favoriteHide = new System.Windows.Forms.Button();
            this.btn_favorite_Clear = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_source = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_source);
            this.panel1.Controls.Add(this.new_window);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_setings);
            this.panel1.Controls.Add(this.btn_favorite);
            this.panel1.Controls.Add(this.btn_search1);
            this.panel1.Controls.Add(this.btn_search2);
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_forword);
            this.panel1.Controls.Add(this.btn_refrash);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.browser_comboBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 100);
            this.panel1.TabIndex = 0;
            // 
            // new_window
            // 
            this.new_window.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_window.ForeColor = System.Drawing.Color.Silver;
            this.new_window.Image = ((System.Drawing.Image)(resources.GetObject("new_window.Image")));
            this.new_window.Location = new System.Drawing.Point(868, 7);
            this.new_window.Name = "new_window";
            this.new_window.Size = new System.Drawing.Size(30, 30);
            this.new_window.TabIndex = 14;
            this.new_window.UseVisualStyleBackColor = true;
            this.new_window.Click += new System.EventHandler(this.new_window_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(910, 10);
            this.progressBar1.TabIndex = 13;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.Silver;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(117, 50);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(30, 30);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_setings
            // 
            this.btn_setings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setings.ForeColor = System.Drawing.Color.Silver;
            this.btn_setings.Image = ((System.Drawing.Image)(resources.GetObject("btn_setings.Image")));
            this.btn_setings.Location = new System.Drawing.Point(832, 60);
            this.btn_setings.Name = "btn_setings";
            this.btn_setings.Size = new System.Drawing.Size(30, 30);
            this.btn_setings.TabIndex = 11;
            this.btn_setings.UseVisualStyleBackColor = true;
            this.btn_setings.Click += new System.EventHandler(this.btn_setings_Click);
            // 
            // btn_favorite
            // 
            this.btn_favorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favorite.ForeColor = System.Drawing.Color.Silver;
            this.btn_favorite.Image = ((System.Drawing.Image)(resources.GetObject("btn_favorite.Image")));
            this.btn_favorite.Location = new System.Drawing.Point(796, 60);
            this.btn_favorite.Name = "btn_favorite";
            this.btn_favorite.Size = new System.Drawing.Size(30, 30);
            this.btn_favorite.TabIndex = 10;
            this.btn_favorite.UseVisualStyleBackColor = true;
            this.btn_favorite.Click += new System.EventHandler(this.btn_favorite_Click);
            // 
            // btn_search1
            // 
            this.btn_search1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search1.ForeColor = System.Drawing.Color.Silver;
            this.btn_search1.Image = ((System.Drawing.Image)(resources.GetObject("btn_search1.Image")));
            this.btn_search1.Location = new System.Drawing.Point(754, 7);
            this.btn_search1.Name = "btn_search1";
            this.btn_search1.Size = new System.Drawing.Size(30, 30);
            this.btn_search1.TabIndex = 9;
            this.btn_search1.UseVisualStyleBackColor = true;
            this.btn_search1.Click += new System.EventHandler(this.btn_search1_Click);
            // 
            // btn_search2
            // 
            this.btn_search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search2.ForeColor = System.Drawing.Color.Silver;
            this.btn_search2.Image = ((System.Drawing.Image)(resources.GetObject("btn_search2.Image")));
            this.btn_search2.Location = new System.Drawing.Point(673, 53);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(30, 30);
            this.btn_search2.TabIndex = 8;
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textBox.Location = new System.Drawing.Point(153, 53);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(514, 31);
            this.search_textBox.TabIndex = 7;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.Silver;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(36, 50);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(30, 30);
            this.btn_home.TabIndex = 5;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_forword
            // 
            this.btn_forword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_forword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_forword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forword.ForeColor = System.Drawing.Color.Silver;
            this.btn_forword.Image = ((System.Drawing.Image)(resources.GetObject("btn_forword.Image")));
            this.btn_forword.Location = new System.Drawing.Point(63, 50);
            this.btn_forword.Name = "btn_forword";
            this.btn_forword.Size = new System.Drawing.Size(30, 30);
            this.btn_forword.TabIndex = 4;
            this.btn_forword.UseVisualStyleBackColor = true;
            this.btn_forword.Click += new System.EventHandler(this.btn_forword_Click);
            // 
            // btn_refrash
            // 
            this.btn_refrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrash.ForeColor = System.Drawing.Color.Silver;
            this.btn_refrash.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrash.Image")));
            this.btn_refrash.Location = new System.Drawing.Point(90, 50);
            this.btn_refrash.Name = "btn_refrash";
            this.btn_refrash.Size = new System.Drawing.Size(30, 30);
            this.btn_refrash.TabIndex = 3;
            this.btn_refrash.UseVisualStyleBackColor = true;
            this.btn_refrash.Click += new System.EventHandler(this.btn_refrash_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Silver;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(11, 50);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // browser_comboBox
            // 
            this.browser_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.browser_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browser_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browser_comboBox.FormattingEnabled = true;
            this.browser_comboBox.Location = new System.Drawing.Point(11, 11);
            this.browser_comboBox.Name = "browser_comboBox";
            this.browser_comboBox.Size = new System.Drawing.Size(737, 24);
            this.browser_comboBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(685, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 321);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_historyHide);
            this.tabPage1.Controls.Add(this.btn_historyClear);
            this.tabPage1.Controls.Add(this.History);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_historyHide
            // 
            this.btn_historyHide.Location = new System.Drawing.Point(118, 257);
            this.btn_historyHide.Name = "btn_historyHide";
            this.btn_historyHide.Size = new System.Drawing.Size(48, 23);
            this.btn_historyHide.TabIndex = 2;
            this.btn_historyHide.Text = "Hide";
            this.btn_historyHide.UseVisualStyleBackColor = true;
            this.btn_historyHide.Click += new System.EventHandler(this.btn_historyHide_Click);
            // 
            // btn_historyClear
            // 
            this.btn_historyClear.Location = new System.Drawing.Point(23, 257);
            this.btn_historyClear.Name = "btn_historyClear";
            this.btn_historyClear.Size = new System.Drawing.Size(48, 23);
            this.btn_historyClear.TabIndex = 1;
            this.btn_historyClear.Text = "Clear";
            this.btn_historyClear.UseVisualStyleBackColor = true;
            this.btn_historyClear.Click += new System.EventHandler(this.btn_historyClear_Click);
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(0, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(189, 251);
            this.History.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_favoriteHide);
            this.tabPage2.Controls.Add(this.btn_favorite_Clear);
            this.tabPage2.Controls.Add(this.Favorite);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorite";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_favoriteHide
            // 
            this.btn_favoriteHide.Location = new System.Drawing.Point(118, 257);
            this.btn_favoriteHide.Name = "btn_favoriteHide";
            this.btn_favoriteHide.Size = new System.Drawing.Size(48, 23);
            this.btn_favoriteHide.TabIndex = 4;
            this.btn_favoriteHide.Text = "Hide";
            this.btn_favoriteHide.UseVisualStyleBackColor = true;
            this.btn_favoriteHide.Click += new System.EventHandler(this.btn_favoriteHide_Click);
            // 
            // btn_favorite_Clear
            // 
            this.btn_favorite_Clear.Location = new System.Drawing.Point(23, 257);
            this.btn_favorite_Clear.Name = "btn_favorite_Clear";
            this.btn_favorite_Clear.Size = new System.Drawing.Size(48, 23);
            this.btn_favorite_Clear.TabIndex = 3;
            this.btn_favorite_Clear.Text = "Clear";
            this.btn_favorite_Clear.UseVisualStyleBackColor = true;
            this.btn_favorite_Clear.Click += new System.EventHandler(this.btn_favorite_Clear_Click);
            // 
            // Favorite
            // 
            this.Favorite.FormattingEnabled = true;
            this.Favorite.Location = new System.Drawing.Point(0, 0);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(189, 251);
            this.Favorite.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(916, 507);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(916, 611);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 3;
            // 
            // btn_source
            // 
            this.btn_source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_source.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_source.ForeColor = System.Drawing.Color.Silver;
            this.btn_source.Image = ((System.Drawing.Image)(resources.GetObject("btn_source.Image")));
            this.btn_source.Location = new System.Drawing.Point(868, 60);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(30, 30);
            this.btn_source.TabIndex = 15;
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = " Web Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_setings;
        private System.Windows.Forms.Button btn_favorite;
        private System.Windows.Forms.Button btn_search1;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_forword;
        private System.Windows.Forms.Button btn_refrash;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox browser_comboBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox Favorite;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_historyHide;
        private System.Windows.Forms.Button btn_historyClear;
        private System.Windows.Forms.Button btn_favoriteHide;
        private System.Windows.Forms.Button btn_favorite_Clear;
        private System.Windows.Forms.Button new_window;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_source;
    }

}

