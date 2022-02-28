using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            /*------------------------Visible---------------------------*/
            dataGridView1.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            /*----------------------------------------------------------*/

            /*--------------------Неправильный ввод---------------------*/
            try //try-catch
            {
                dataGridView1.RowCount = Int32.Parse(textBox1.Text);
                dataGridView1.ColumnCount = Int32.Parse(textBox2.Text);
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
            try //try-catch
            {
                /*------------------------Visible---------------------------*/
                label4.Visible = true;
                button2.Visible = false;
                dataGridView1.Visible = false;
                /*----------------------------------------------------------*/

                /*---------------------Создание dGV-------------------------*/
                double[,] array = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        array[j, i] = Convert.ToDouble(dataGridView1[j, i].Value);
                    }
                }
                /*----------------------------------------------------------*/

                /*---------------------Наим. сумма--------------------------*/
                double SumCollum = 0;
                double minSumCollums = 100000000;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        SumCollum = SumCollum + array[i, j];
                    }
                    if (SumCollum < minSumCollums)
                    {
                        minSumCollums = SumCollum;
                    }
                    SumCollum = 0;
                }
                label4.Text = "Наименьшая самма строки составляет " + minSumCollums.ToString();
                /*----------------------------------------------------------*/
            }
            catch //Неправильный ввод данных
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
        }
    }
}
