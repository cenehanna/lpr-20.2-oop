using System;
using System.Windows.Forms;

namespace lpr_20_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "a";
            textBox2.Text = "b";
        }

        private string SolveLinearEquation(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Рівняння має безліч розв'язків.";
                else
                    return "Рівняння не має розв’язків.";
            }

            double x = -b / a;
            return x.ToString();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!double.TryParse(textBox1.Text, out a))
            {
                ShowError("Некоректне значення коефіцієнта a. Введіть число.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out b))
            {
                ShowError("Некоректне значення коефіцієнта b. Введіть число.");
                return;
            }

            try
            {
                string result = SolveLinearEquation(a, b);
                textBox3.Text = result;
            }
            catch (Exception ex)
            {
                ShowError("Непередбачена помилка: " + ex.Message);
                textBox3.Clear();
            }
        }
    }
}
