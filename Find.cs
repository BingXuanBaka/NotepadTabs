using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Tabs
{
    
    public partial class Find : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetForegroundWindow(IntPtr hwnd);



        public static int index;
        public TabControl tabControl;
        public Find(TabControl tabControl)
        {
            InitializeComponent();
            this.tabControl = tabControl;
        }

        private void Find_Load(object sender, EventArgs e)
        {
            index = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(radioButton2.Checked)
            {
                //选中“向下”时
                case true:
                    FindNext(textBox1.Text);
                    break;

                //选中“向上”时
                case false:
                    FindPrevious(textBox1.Text);
                    break;
            }

            SetForegroundWindow(Form1.hwnd);//切换回主窗口
        }
        public void FindNext(string text)
        {
            if (index < 0) index = 0;
            if (index > ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length || tabControl.SelectedTab.Controls[0].Text.IndexOf(text, index) == -1 )
            {
                
                MessageBox.Show("找不到“" + text + "”", "查找", MessageBoxButtons.OK, MessageBoxIcon.Information);//如果查找到最后一个或查找不到，则取消查找，并提示
                return;
            }
            else
            {
                index = tabControl.SelectedTab.Controls[0].Text.IndexOf(text, index);//将此时的索引位置设置为查找到的字符串位置
                ((TextBox)tabControl.SelectedTab.Controls[0]).Select(index, text.Length);//选中查找到的字符串
                index++;//增加索引位置的值
            }

        }
        public void FindPrevious(string text)
        {
            if (index > ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length) index = ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length;
            if (index < 0)
            {
               
                MessageBox.Show("找不到“" + text + "”", "查找", MessageBoxButtons.OK, MessageBoxIcon.Information); //如果查找到第一个或查找不到，则取消查找，并提示
                return;
            }
            else
            {
                index = tabControl.SelectedTab.Controls[0].Text.LastIndexOf(text, index);//将此时的索引位置设置为查找到的字符串位置
                ((TextBox)tabControl.SelectedTab.Controls[0]).Select(index, text.Length);//选中查找到的字符串
                index--;//当索引位置大于0时减少索引位置的值
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                index = 0;
            }
            else
            {
                index = tabControl.SelectedTab.Controls[0].Text.LastIndexOf(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
