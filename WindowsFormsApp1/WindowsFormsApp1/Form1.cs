using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int FirstValue, TwoValue;
        double Result;


        private void button1_Click(object sender, EventArgs e)
        {
            /*------------------------Visible---------------------------*/
            label4.Visible = true;
            /*----------------------------------------------------------*/

            /*--------------------Вывод ответа--------------------------*/
            try //try-catch
            {
                FirstValue = Int32.Parse(textBox1.Text);
                TwoValue = Int32.Parse(textBox2.Text);
                Result = Convert.ToDouble(FirstValue+TwoValue);
                textBox3.Text = Result.ToString();
                label4.Text = button1.Text;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы неправильноо ввели данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            /*----------------------------------------------------------*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*------------------------Visible---------------------------*/
            label4.Visible = true;
            /*----------------------------------------------------------*/

            /*--------------------Вывод ответа--------------------------*/
            try //try-catch
            {
                FirstValue = Int32.Parse(textBox1.Text);
                TwoValue = Int32.Parse(textBox2.Text);
                Result = Convert.ToDouble(FirstValue - TwoValue);
                textBox3.Text = Result.ToString();
                label4.Text = button2.Text;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы неправильноо ввели данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            /*----------------------------------------------------------*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*------------------------Visible---------------------------*/
            label4.Visible = true;
            /*----------------------------------------------------------*/

            /*--------------------Вывод ответа--------------------------*/
            try //try-catch
            {
                FirstValue = Int32.Parse(textBox1.Text);
                TwoValue = Int32.Parse(textBox2.Text);
                Result = Convert.ToDouble(FirstValue * TwoValue);
                textBox3.Text = Result.ToString();
                label4.Text = button3.Text;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы неправильноо ввели данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            /*----------------------------------------------------------*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*------------------------Visible---------------------------*/
            label4.Visible = true;
            /*----------------------------------------------------------*/

            /*--------------------Вывод ответа--------------------------*/
            try //try-catch
            {
                FirstValue = Int32.Parse(textBox1.Text);
                TwoValue = Int32.Parse(textBox2.Text);
                Result = Convert.ToDouble(FirstValue / TwoValue);
                textBox3.Text = Result.ToString();
                label4.Text = button4.Text;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы неправильноо ввели данные",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            /*----------------------------------------------------------*/
        }
    }
}
