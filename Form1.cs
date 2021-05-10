using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webhs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;  // столбец
        int m;  // строка
        int[,] mas = new int[500, 500];

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox3.Text);
            int sum = 0, sum2 = 0;
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            Random rand = new Random();

            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;

            for (int i = 0; i < n; i++) //вывод матрицы на доску
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next() % 10 - 5;
                    dataGridView1[i, j].Value = mas[i, j];
                    if (mas[i, j] >= c)
                        sum++;
                    if (i == 0 || j == 0 || i == n-1 || j == m - 1)
                        sum2 += mas[i, j];
                }

            }

            label2.Text = Convert.ToString(sum);
            label5.Text = Convert.ToString(sum2);
        }



        //  ограничение ввода
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;

            if (e.KeyChar == '.') e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;

            if (e.KeyChar == '.') e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;

            if (e.KeyChar == '.') e.KeyChar = ',';
            
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                return;
            }
            e.Handled = true;
        }
    }
}