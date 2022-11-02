using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_TextBox_Q3_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DateTime input;
                try
                {
                    input = DateReal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                string result = age(input);
                MessageBox.Show(result);
            }

        }

        private DateTime DateReal()
        {
            string input = textBox1.Text;
            bool isDate = DateTime.TryParse(input, out DateTime Day);

            if (isDate == false)
            {
                throw new Exception("格式錯誤");
            }
            return Day;
        }

        private string age(DateTime input)
        {
            string result;
            int NowYear = DateTime.Now.Year;
            int inputyear = input.Year;

            if (NowYear - inputyear >= 13)
            {
                result = "已滿13歲";
            }
            else
            {
                result = "未滿13歲";
            }
            return result;
        }
    }
}
