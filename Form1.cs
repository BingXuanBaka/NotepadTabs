using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;

namespace Notepad_Tabs
{
    
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        public static IntPtr hwnd;

        //新建用于记录文件信息的数组
        public ArrayList filepath = new ArrayList();
        public ArrayList saved = new ArrayList();

        public bool saveDialogResult;
        public bool openDialogResult;

        //用于记录配置的全局变量
        public bool wordWrap;
        public Font font ;
        public Encoding encoding;


        string[] args = null;

        public Form1(string[] args)
        {
            InitializeComponent();
            this.args = args;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            font = new Font("宋体", 12);
            wordWrap = false;
            if (args.Length == 0)
            {
                
                addpage("无标题");//添加页面
                

            }
            else
            {
                foreach (var item in args)
                {
                    addpage(System.IO.Path.GetFileName(item));
                    tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    tabControl1.SelectedTab.Controls[0].Text = open(item);
                    saved[tabControl1.SelectedIndex] = true;
                    filepath[tabControl1.SelectedIndex] = item;
                    
                    //更改标题
                    if (tabControl1.SelectedTab.Text.Substring(tabControl1.SelectedTab.Text.Length - 1, 1) == "*")
                    {
                        tabControl1.SelectedTab.Text = tabControl1.SelectedTab.Text.Substring(0, tabControl1.SelectedTab.Text.Length - 1);
                    }

                }
            }
            updateTitle();//更新窗口标题



        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            hwnd = GetForegroundWindow();//获取当前窗口句柄
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTitle();//更新窗口标题
            
        }


        private void TextChanged(object sender, EventArgs e)
        {            
            //将保存状态设为否
            int selectindex = tabControl1.SelectedIndex;
            saved[selectindex] = false;
            
            //在标题后添加星号表示未保存
            if (tabControl1.SelectedTab.Text.Substring(tabControl1.SelectedTab.Text.Length - 1, 1) != "*")
            {tabControl1.SelectedTab.Text = tabControl1.SelectedTab.Text + "*"; }

            //更新标题
            updateTitle();
        }
        public void addpage(string name)
        {
            //新增标签
            TabPage tabPage = new TabPage(name);
            tabControl1.TabPages.Add(tabPage);

            //新增textbox
            TextBox newtextbox = new TextBox();

            //更改textbox的属性
            tabPage.Controls.Add(newtextbox);
            newtextbox.Dock = DockStyle.Fill;
            newtextbox.AcceptsTab = true;
            newtextbox.Multiline = true;
            newtextbox.ScrollBars = ScrollBars.Both;
            newtextbox.WordWrap = wordWrap;
            newtextbox.TextChanged += TextChanged;
            newtextbox.Font = font;

            //将文件的属性添加到集合中
            saved.Add(true);
            filepath.Add("");
        }
        public void closetab(TabPage selectedtab,int selectIndex)
        {
            //检测文件是否保存
            if (Convert.ToBoolean(saved[selectIndex]) == false)
            //未保存
            {
                //显示对话框，询问是否保存
                DialogResult dialogResult = MessageBox.Show("是否更改保存到“"+selectedtab.Text+"”", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)

                //是
                {
                    if (filepath[selectIndex].ToString() == "")
                    {
                        //另存为
                        Saveas(selectedtab);

                        //如果保存时直接关闭保存对话框,则不关闭标签
                        if (saveDialogResult == true)
                        {
                            //移除arraylist中项
                            saved.RemoveAt(selectIndex);
                            filepath.RemoveAt(selectIndex);
                                
                             //遍历已选中标签的控件并移除
                            foreach (Control textbox in selectedtab.Controls)
                            {
                                this.Controls.Remove(textbox);
                                textbox.Dispose();
                            }

                            //移除标签本身
                            tabControl1.TabPages.Remove(selectedtab);
                            selectedtab.Dispose();
                        }
                    }
                    else
                    {
                        //保存
                        Save(filepath[selectIndex].ToString(), selectedtab.Controls[0].Text);

                        //移除arraylist中项
                        saved.RemoveAt(selectIndex);
                        filepath.RemoveAt(selectIndex);

                        //遍历已选中标签的控件并移除
                        foreach (Control textbox in selectedtab.Controls)
                        {
                            this.Controls.Remove(textbox);
                            textbox.Dispose();
                        }

                        //移除标签本身
                        tabControl1.TabPages.Remove(selectedtab);
                        selectedtab.Dispose();
                    }
                }

                //否
                else if (dialogResult == DialogResult.No)
                {
                    //移除arraylist中项
                    saved.RemoveAt(selectIndex);
                    filepath.RemoveAt(selectIndex);

                    //遍历已选中标签的控件并移除
                    foreach (Control textbox in selectedtab.Controls)
                    {
                        this.Controls.Remove(textbox);
                        textbox.Dispose();
                    }

                    //移除标签本身
                    tabControl1.TabPages.Remove(selectedtab);
                    selectedtab.Dispose();
                }

                //取消
                else
                {
                    return;
                }

            }

            //已保存
            else
            {
                //移除arraylist中项
                saved.RemoveAt(selectIndex);
                filepath.RemoveAt(selectIndex);

                //遍历已选中标签的控件并移除
                foreach (Control textbox in selectedtab.Controls)
                {
                    this.Controls.Remove(textbox);
                    textbox.Dispose();
                }

                //移除标签本身
                tabControl1.TabPages.Remove(selectedtab);
                selectedtab.Dispose();
            }


        }
        public string open(string newFilePath)
        {
            //使用streamreader读取文件
            StreamReader streamReader = new StreamReader(newFilePath);
            String text = streamReader.ReadToEnd();
            streamReader.Close();

            //更改arraylist中文件属性
            filepath.Add(newFilePath);
            saved.Add(true);

            //输出读取的文本
            return(text);
        }
        public void Saveas(TabPage tabPage)
        {
            //显示savefiledialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);//创建新的streamwriter类
                streamWriter.WriteLine(tabPage.Controls[0].Text);//向选定目录写入文本
                streamWriter.Close();//关闭实例
                filepath[tabControl1.TabPages.IndexOf(tabPage)] = saveFileDialog1.FileName;//更新目录
                tabPage.Text = System.IO.Path.GetFileName(saveFileDialog1.FileName);//将标签标题设为保存的文件名
                saveDialogResult = true;
            }
            else
            {
                saveDialogResult = false;
                return;
            }
        }
        public void Save(String Filename,string text)
        {
            StreamWriter streamWriter = new StreamWriter(Filename);//创建新的streamwriter类
            streamWriter.WriteLine(text);//向已知目录写入文本
            streamWriter.Close();//关闭实例

        }


        public void closeall()
        {
            ArrayList tablist = new ArrayList();
            //遍历所有打开的标签，存储到arraylist中
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tablist.Add(tab);
            }
            foreach(TabPage tab in tablist)
            {
                closetab(tab,tabControl1.TabPages.IndexOf(tab));
            }
        }

        private void updateTitle()
        {
            //更新窗口标题
            if (tabControl1.TabCount > 0)
            {
                this.Text = "Notepad Tabs - " + tabControl1.SelectedTab.Text;
            }
            else
            {
                this.Text = "Notepad Tabs";
            }
        }

        private void new_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpage("无标题");//新建页面
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;//切换到新建的页面
            this.Text = "Notepad Tabs - " + tabControl1.SelectedTab.Text;//更新标题
        }

        private void save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //读取当前选中标签文档文件名
            int selectindex = tabControl1.SelectedIndex;
            string selectedfile = filepath[selectindex].ToString();

            //如果文件名为空，则调用子程序"saveas"，反之则调用子程序"save"
            if (selectedfile == "")
            {
                Saveas(tabControl1.SelectedTab);
            }
            else
            {
                Save(selectedfile, tabControl1.SelectedTab.Controls[0].Text);
            }

            if(saveDialogResult == true || filepath[selectindex].ToString() != "")
            {
                //更改标题
                if (tabControl1.SelectedTab.Text.Substring(tabControl1.SelectedTab.Text.Length - 1, 1) == "*")
                {
                    tabControl1.SelectedTab.Text = tabControl1.SelectedTab.Text.Substring(0, tabControl1.SelectedTab.Text.Length - 1);
                }

                //更改保存状态
                saved[tabControl1.SelectedIndex] = true;

                //更新窗口标题
                updateTitle();
            }
        }

        private void open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //如果当前页面有内容，则新建页面并在新建的页面上读取文档
            if (tabControl1.SelectedTab.Controls[0].Text != "" && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addpage("无标题");//新建页面
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;//切换到选中的页面
                tabControl1.SelectedTab.Controls[0].Text = open(openFileDialog1.FileName);//打开选中的文件
                tabControl1.SelectedTab.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);//将标签标题设为打开的文件名
                saved[tabControl1.SelectedIndex] = true;//将保存状态设为真
                filepath[tabControl1.SelectedIndex] = openFileDialog1.FileName;
            }

            //如果当前页面无内容，则直接在当前页面上读取文档
            else if (tabControl1.SelectedTab.Controls[0].Text == "" && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedTab.Controls[0].Text = open(openFileDialog1.FileName);//打开选中的文件
                tabControl1.SelectedTab.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);//将标签标题设为打开的文件名
                saved[tabControl1.SelectedIndex] = true;//将保存状态设为真
                filepath[tabControl1.SelectedIndex] = openFileDialog1.FileName;
            }

            //更新窗口标题
            updateTitle();
        }
        private void closeTab_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closetab(tabControl1.SelectedTab,tabControl1.SelectedIndex);
        }

        private void about_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutBox = new AboutBox1();
            AboutBox.ShowDialog();
        }
        public void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeall();

            //检测是否标签全部关闭，如果是则退出程序
            if (tabControl1.TabCount < 1)
            {
                this.Close();
            }
        }

        private void undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)tabControl1.SelectedTab.Controls[0];
            textBox.Undo();
        }

        private void copy_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)tabControl1.SelectedTab.Controls[0];
            textBox.Copy();
        }

        private void paste_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)tabControl1.SelectedTab.Controls[0];
            textBox.Paste();
        }

        private void cut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)tabControl1.SelectedTab.Controls[0];
            textBox.Cut();
        }

        private void selectAll_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)tabControl1.SelectedTab.Controls[0];
            textBox.SelectAll();
        }

        private void wordWrap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //切换选择状态和变量自动换行属性的状态为 真 或 假
            switch (wordWrap_ToolStripMenuItem.Checked.ToString())
            {
                case "False":
                    wordWrap_ToolStripMenuItem.Checked = true;
                    wordWrap = true;
                    break;
                case "True":
                    wordWrap_ToolStripMenuItem.Checked = false;
                    wordWrap = false;
                    break;
                default:
                    break;
            }
   
            //遍历已存在的所有标签页中的Textbox，并更改其自动换行属性
            foreach (TabPage tab in tabControl1.TabPages)
            {
                TextBox textBox = (TextBox)tab.Controls[0];
                textBox.WordWrap = wordWrap;
            }

        }

        private void font_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将fontdialog中选中的字体更改为当前使用的字体
            fontDialog1.Font = font;
            
            //显示fontdialog，将选择的字体写入到全局变量中，并用遍历更改所有已打开的文档的字体
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
                foreach (TabPage tabPage in tabControl1.TabPages )
                {
                    TextBox textBox = (TextBox)tabPage.Controls[0];
                    textBox.Font = font;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeall();

            //检测是否标签全部关闭，如果是则退出程序
            if (tabControl1.TabCount >= 1)
            {
                e.Cancel = true;
            }
        }

        private void find_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            TabControl tabControl = tabControl1;
            Form find = new Find(tabControl);
            find.Show();

        }

        private void replace_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl tabControl = tabControl1;
            Form replace = new Replace(tabControl);
            replace.Show();
        }

        private void saveAs_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saveas(tabControl1.SelectedTab);
        }

        private void tabControl1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tabControl1_DragDrop(object sender, DragEventArgs e)
        {
            String[] file = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach(var item in file)
            {

                //如果当前页面有内容，则新建页面并在新建的页面上读取文档
                if (tabControl1.SelectedTab.Controls[0].Text != "" )
                {
                    addpage("无标题");//新建页面
                    tabControl1.SelectedIndex = tabControl1.TabCount - 1;//切换到选中的页面
                    tabControl1.SelectedTab.Controls[0].Text = open(item);//打开选中的文件
                    tabControl1.SelectedTab.Text = System.IO.Path.GetFileName(item);//将标签标题设为打开的文件名
                    saved[tabControl1.SelectedIndex] = true;//将保存状态设为真
                    filepath[tabControl1.SelectedIndex] = openFileDialog1.FileName;
                }

                //如果当前页面无内容，则直接在当前页面上读取文档
                else if (tabControl1.SelectedTab.Controls[0].Text == "")
                {
                    tabControl1.SelectedTab.Controls[0].Text = open(item);//打开选中的文件
                    tabControl1.SelectedTab.Text = System.IO.Path.GetFileName(item);//将标签标题设为打开的文件名
                    saved[tabControl1.SelectedIndex] = true;//将保存状态设为真
                    filepath[tabControl1.SelectedIndex] = item;
                }

                //更新窗口标题
                updateTitle();
            }
        }
    }
}
