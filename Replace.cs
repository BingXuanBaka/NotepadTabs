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
    public partial class Replace : Form
    {
        public static int index;
        public TabControl tabControl;
        public Replace(TabControl tabControl)
        {
            InitializeComponent();
            this.tabControl = tabControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetForegroundWindow(Form1.hwnd);
            if (index != -1 && index <= ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length) index = tabControl.SelectedTab.Controls[0].Text.IndexOf(textBox1.Text, index);//从索引位置向后查找
            //当未查找到最后一个或查找不到时选中查找到的字符串并增加索引位置的值
            if (index != -1 && index <= ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length)
            {
                ((TextBox)tabControl.SelectedTab.Controls[0]).Select(index, textBox1.Text.Length);
                index++;
            }
            if (index == -1 && index > ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length)
            {
                //查找到最后一个或查找不到，则提示未查找到
                MessageBox.Show("找不到“" + textBox1.Text + "”", "查找", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            index = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetForegroundWindow(Form1.hwnd);
            Replacestr(textBox2.Text);
        }
        public void Replacestr(string str)
        {
            //如果选中的字符不等于要替换的字符，则重新查找要替换的字符
            if (((TextBox)tabControl.SelectedTab.Controls[0]).SelectedText != textBox1.Text)
            {
                if(index != -1 && index <= ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length)index = tabControl.SelectedTab.Controls[0].Text.IndexOf(textBox1.Text, index);//从索引位置向后查找
                //当未查找到最后一个或查找不到时选中查找到的字符串并替换为需要替换的文字，最后增加索引位置的值
                if (index != -1)
                {
                    ((TextBox)tabControl.SelectedTab.Controls[0]).Select(index, textBox1.Text.Length);
                    ((TextBox)tabControl.SelectedTab.Controls[0]).SelectedText = textBox2.Text;
                    index  = index + textBox2.Text.Length;
                    Console.Out.WriteLine(index.ToString());
                }
            }
            else
            {
                //替换文本，并将索引位置设为当前指针所在位置
                index = ((TextBox)tabControl.SelectedTab.Controls[0]).SelectionStart;
                ((TextBox)tabControl.SelectedTab.Controls[0]).SelectedText = str;
                index += textBox2.Text.Length;

                //继续向后查找
                index = tabControl.SelectedTab.Controls[0].Text.IndexOf(textBox1.Text, index);                                                                                                                                                            //当未查找到最后一个或查找不到时选中查找到的字符串并增加索引位置的值
                if (index != -1 && index <= ((TextBox)tabControl.SelectedTab.Controls[0]).Text.Length)
                {
                    ((TextBox)tabControl.SelectedTab.Controls[0]).Select(index, textBox1.Text.Length);
                    index += textBox2.Text.Length;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
            SetForegroundWindow(Form1.hwnd);
            //一直查找字符，直到查找不到或到最后一个为止
            while (index != -1)
            {
                //MessageBox.Show(index.ToString());//Debug
                Replacestr(textBox2.Text);
            }

            index = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            index = 0;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr SetForegroundWindow(IntPtr hwnd);
    }
}
