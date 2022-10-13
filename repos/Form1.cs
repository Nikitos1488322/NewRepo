using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
            private void button1_Click(object sender, EventArgs e)
            {
                double Nalog = 0, Vichet = 0, Deti = 0, D = 0, Dsumm = 0, r = 0;
                try
                {
                    D = Convert.ToDouble(textBox1.Text);
                    Dsumm = Convert.ToDouble(textBox2.Text);
                }
                catch (Exception ex)
                {
                    r++;
                    MessageBox.Show(ex.ToString(), "Ошибка! Некорректный ввод данных в поле доходов физ. лица за 1 месяц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    Dsumm = Convert.ToDouble(textBox2.Text);
                }
                catch (Exception ex)
                {
                    r++;
                    MessageBox.Show(ex.ToString(), "Ошибка! Некорректный ввод данных в поле доходов физ. лица с начала года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    Deti = Convert.ToDouble(textBox3.Text);
                }
                catch (Exception ex)
                {
                    r++;
                    MessageBox.Show(ex.ToString(), "Ошибка! Некорректный ввод данных в поле доходов физ. лица с начала года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          
                if (Dsumm < 40000)
                {
                    if (checkBox1.Checked == true && Deti > 0)
                        Vichet = 600 + 600 * Deti;
                    else if (checkBox1.Checked == false && Deti > 0)
                        Vichet = 600 + 1200 * Deti;
                    Nalog = 0.13 * (D - Vichet);
                }
                else if (Dsumm >= 40000)
                    Nalog = 0.13 * D;
                if (r == 0)
                {
                    textBox4.Text = "Налоги составили: " + Convert.ToString(Nalog) + Environment.NewLine;
                    textBox4.Text += "Чистый доход за месяц: " + Convert.ToString(D - Nalog);
                }

            }

            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 44)
                {
                    e.Handled = true;
                }
            }

            private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 44)
                {
                    e.Handled = true;
                }
            }

            private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 44)
                {
                    e.Handled = true;
                }
            }
        }

    }

