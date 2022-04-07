namespace Notepad_Tabs
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTab_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.find_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replace_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAll_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.options_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem,
            this.edit_ToolStripMenuItem,
            this.options_ToolStripMenuItem,
            this.help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_ToolStripMenuItem,
            this.open_ToolStripMenuItem,
            this.save_ToolStripMenuItem,
            this.saveAs_ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeTab_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.file_ToolStripMenuItem.Text = "文件(&F)";
            // 
            // new_ToolStripMenuItem
            // 
            this.new_ToolStripMenuItem.Name = "new_ToolStripMenuItem";
            this.new_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.new_ToolStripMenuItem.Text = "新建(&N)";
            this.new_ToolStripMenuItem.Click += new System.EventHandler(this.new_ToolStripMenuItem_Click);
            // 
            // open_ToolStripMenuItem
            // 
            this.open_ToolStripMenuItem.Name = "open_ToolStripMenuItem";
            this.open_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.open_ToolStripMenuItem.Text = "打开(&O)";
            this.open_ToolStripMenuItem.Click += new System.EventHandler(this.open_ToolStripMenuItem_Click);
            // 
            // save_ToolStripMenuItem
            // 
            this.save_ToolStripMenuItem.Name = "save_ToolStripMenuItem";
            this.save_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.save_ToolStripMenuItem.Text = "保存(&S)";
            this.save_ToolStripMenuItem.Click += new System.EventHandler(this.save_ToolStripMenuItem_Click);
            // 
            // saveAs_ToolStripMenuItem
            // 
            this.saveAs_ToolStripMenuItem.Name = "saveAs_ToolStripMenuItem";
            this.saveAs_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAs_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveAs_ToolStripMenuItem.Text = "另存为(&A)";
            this.saveAs_ToolStripMenuItem.Click += new System.EventHandler(this.saveAs_ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(246, 6);
            // 
            // closeTab_ToolStripMenuItem
            // 
            this.closeTab_ToolStripMenuItem.Name = "closeTab_ToolStripMenuItem";
            this.closeTab_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeTab_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.closeTab_ToolStripMenuItem.Text = "关闭标签(&W)";
            this.closeTab_ToolStripMenuItem.Click += new System.EventHandler(this.closeTab_ToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.exit_ToolStripMenuItem.Text = "退出(&X)";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // edit_ToolStripMenuItem
            // 
            this.edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo_ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copy_ToolStripMenuItem,
            this.paste_ToolStripMenuItem,
            this.cut_ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.find_ToolStripMenuItem,
            this.replace_ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selectAll_ToolStripMenuItem1});
            this.edit_ToolStripMenuItem.Name = "edit_ToolStripMenuItem";
            this.edit_ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.edit_ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // undo_ToolStripMenuItem
            // 
            this.undo_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.undo_ToolStripMenuItem.Name = "undo_ToolStripMenuItem";
            this.undo_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.undo_ToolStripMenuItem.Text = "撤销(&U)";
            this.undo_ToolStripMenuItem.Click += new System.EventHandler(this.undo_ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // copy_ToolStripMenuItem
            // 
            this.copy_ToolStripMenuItem.Name = "copy_ToolStripMenuItem";
            this.copy_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.copy_ToolStripMenuItem.Text = "复制(&C)";
            this.copy_ToolStripMenuItem.Click += new System.EventHandler(this.copy_ToolStripMenuItem_Click);
            // 
            // paste_ToolStripMenuItem
            // 
            this.paste_ToolStripMenuItem.Name = "paste_ToolStripMenuItem";
            this.paste_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.paste_ToolStripMenuItem.Text = "粘贴(&V)";
            this.paste_ToolStripMenuItem.Click += new System.EventHandler(this.paste_ToolStripMenuItem_Click);
            // 
            // cut_ToolStripMenuItem
            // 
            this.cut_ToolStripMenuItem.Name = "cut_ToolStripMenuItem";
            this.cut_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cut_ToolStripMenuItem.Text = "剪切(&T)";
            this.cut_ToolStripMenuItem.Click += new System.EventHandler(this.cut_ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // find_ToolStripMenuItem
            // 
            this.find_ToolStripMenuItem.Name = "find_ToolStripMenuItem";
            this.find_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.find_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.find_ToolStripMenuItem.Text = "查找(&F)";
            this.find_ToolStripMenuItem.Click += new System.EventHandler(this.find_ToolStripMenuItem_Click);
            // 
            // replace_ToolStripMenuItem
            // 
            this.replace_ToolStripMenuItem.Name = "replace_ToolStripMenuItem";
            this.replace_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replace_ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.replace_ToolStripMenuItem.Text = "替换(&R)";
            this.replace_ToolStripMenuItem.Click += new System.EventHandler(this.replace_ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 6);
            // 
            // selectAll_ToolStripMenuItem1
            // 
            this.selectAll_ToolStripMenuItem1.Name = "selectAll_ToolStripMenuItem1";
            this.selectAll_ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAll_ToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.selectAll_ToolStripMenuItem1.Text = "全选(&A)";
            this.selectAll_ToolStripMenuItem1.Click += new System.EventHandler(this.selectAll_ToolStripMenuItem1_Click);
            // 
            // options_ToolStripMenuItem
            // 
            this.options_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrap_ToolStripMenuItem,
            this.font_ToolStripMenuItem});
            this.options_ToolStripMenuItem.Name = "options_ToolStripMenuItem";
            this.options_ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.options_ToolStripMenuItem.Text = "格式(&O)";
            // 
            // wordWrap_ToolStripMenuItem
            // 
            this.wordWrap_ToolStripMenuItem.Name = "wordWrap_ToolStripMenuItem";
            this.wordWrap_ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.wordWrap_ToolStripMenuItem.Text = "自动换行(&W)";
            this.wordWrap_ToolStripMenuItem.Click += new System.EventHandler(this.wordWrap_ToolStripMenuItem_Click);
            // 
            // font_ToolStripMenuItem
            // 
            this.font_ToolStripMenuItem.Name = "font_ToolStripMenuItem";
            this.font_ToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.font_ToolStripMenuItem.Text = "字体(&F)";
            this.font_ToolStripMenuItem.Click += new System.EventHandler(this.font_ToolStripMenuItem_Click);
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_ToolStripMenuItem});
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.help_ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // about_ToolStripMenuItem
            // 
            this.about_ToolStripMenuItem.Name = "about_ToolStripMenuItem";
            this.about_ToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.about_ToolStripMenuItem.Text = "关于(&A)";
            this.about_ToolStripMenuItem.Click += new System.EventHandler(this.about_ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 534);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragDrop);
            this.tabControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TXT文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TXT文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(635, 112);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(12, 12);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(920, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Notepad Tabs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAs_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTab_ToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copy_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paste_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cut_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem options_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrap_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem font_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectAll_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem find_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replace_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

