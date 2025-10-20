using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computationalmathematics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Подинтегральная функция
        double F(double x)
        {
            return (2*Math.Log(x) + x + 1);
        }

        // Метод левых прямоугольников
        double leftRectangleMethod(double a, double b, uint n)
        {
            double h = (b - a) / n;
            double res = 0;
            for (uint i = 0; i < n; i++)
            {
                res += F(a + i * h);
            }
            return h * res;
        }

        // Метод правых прямоугольников
        double rightRectangleMethod(double a, double b, uint n)
        {
            double h = (b - a) / n;
            double res = 0;
            for (uint i = 1; i <= n; i++)
            {
                res += F(a + i * h);
            }
            return h * res;
        }

        // Метод трапеций
        double trapezoidMethod(double a, double b, uint n)
        {
            double h = (b - a) / n;
            double sum = F(a) + F(b); // концы
            for (uint i = 1; i < n; i++)
            {
                sum += 2 * F(a + i * h);
            }
            return h / 2 * sum;
        }

        // Метод парабол
        double parabolaMethod(double a, double b, uint n)
        {
            if (n % 2 != 0)
                throw new ArgumentException("Для метода парабол n должно быть чётным");

            double h = (b - a) / n;
            double sum = F(a) + F(b); // x0 и xn

            // Нечётные индексы: 1, 3, 5, ..., n-1 → коэффициент 4
            for (uint i = 1; i < n; i += 2)
            {
                sum += 4 * F(a + i * h);
            }

            // Чётные индексы: 2, 4, ..., n-2 → коэффициент 2
            for (uint i = 2; i < n; i += 2)
            {
                sum += 2 * F(a + i * h);
            }

            return sum * h / 3.0;
        }



        // Метод с переменным шагом

        // Вспомогательная рекурсивная функция
        // Передаём f(a), f(m), f(b), чтобы не вычислять их повторно
        double AdaptiveSimpsonRecursive(
            double a, double b, double eps,
            double fa, double fm, double fb)
        {
            double m = (a + b) / 2;
            double lm = (a + m) / 2; // середина левой половины
            double rm = (m + b) / 2; // середина правой половины

            double flm = F(lm);
            double frm = F(rm);

            // Формула Симпсона на всём отрезке [a, b]
            double S = (b - a) / 6 * (fa + 4 * fm + fb);

            // Сумма Симпсона по двум половинкам
            double S2 = (m - a) / 6 * (fa + 4 * flm + fm) +
                        (b - m) / 6 * (fm + 4 * frm + fb);

            // Оценка погрешности
            if (Math.Abs(S2 - S) <= 15 * eps)
            {
                // Формула Ричардсона: уточнённое значение
                return S2 + (S2 - S) / 15;
            }
            else
            {
                // Рекурсивно интегрируем левую и правую части
                double left = AdaptiveSimpsonRecursive(a, m, eps / 2, fa, flm, fm);
                double right = AdaptiveSimpsonRecursive(m, b, eps / 2, fm, frm, fb);
                return left + right;
            }
        }

        // Основная функция: вычисляет интеграл от a до b с точностью eps
        double AdaptiveSimpson(double a, double b, double eps)
        {
            return AdaptiveSimpsonRecursive(a, b, eps, F(a), F((a + b) / 2), F(b));
        }



        // Нажатие на кнопку - вычисление примера
        private void button1_Click(object sender, EventArgs e)
        {   
            // Проверка на то что a, b, n - числа
            if (double.TryParse(textA.Text, out double a))
            {
                if (double.TryParse(textB.Text, out double b))
                {
                    // Используем алгоритм с постоянным шагом
                    if (textBoxN.Visible == true && label1.Visible == true)
                    {
                        if (uint.TryParse(textBoxN.Text, out uint n))
                        {
                            // Начинаем считать
                            if (методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked == true)
                            {
                                answerLabel.Text = leftRectangleMethod(a, b, n).ToString();
                            }
                            else if (методПрямоугольниковПравыхЧастейToolStripMenuItem.Checked == true)
                            {
                                answerLabel.Text = rightRectangleMethod(a, b, n).ToString();
                            }
                            else if (методТрапецийToolStripMenuItem.Checked == true)
                            {
                                answerLabel.Text = trapezoidMethod(a, b, n).ToString();
                            }
                            else if (методПараболToolStripMenuItem.Checked == true)
                            {
                                answerLabel.Text = parabolaMethod(a, b, n).ToString();
                            }
                            else
                            {
                                MessageBox.Show("ERROR METHOD!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Кол-во разбиений (n) должно быть целым положительным числом, проверь!");
                        }
                    }
                    else
                    {
                        // Используем алгоритм с постоянным шагом
                        answerLabel.Text = AdaptiveSimpson(a, b, 0.000001).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Правая граница (b) должна быть числом, проверь!");
                }
            }
            else
            {
                MessageBox.Show("Левая граница (a) должна быть числом, проверь!");
            }

        }






        // При загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem1.Checked = true;
            методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked = true;
            алгоритмСПостояннымШагомToolStripMenuItem.Checked = true;
        }


        // Переключение Типов задач
        private void ТипЗадачиToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Сбросить Checked у всех пунктов
            foreach (ToolStripMenuItem item in типЗадачиToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }

            // Получить текущий (кликнутый) элемент
            if (e.ClickedItem is ToolStripMenuItem currentItem)
            {
                // Установить Checked = true именно для него
                currentItem.Checked = true;
            }



            // Меняем содержание всей формы
            // Меняем название
            nameOftask_label.Text = e.ClickedItem.Text;

            // Меняем остальное меню
            // Меняем численный метод и алгоритм

            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();
            if (e.ClickedItem.Name == "ToolStripMenuItem1")
            {
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников левых частей").Name = "методПрямоугольниковЛевыхЧастейToolStripMenuItem";
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников правых частей").Name = "методПрямоугольниковПравыхЧастейToolStripMenuItem";
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников правых частей").Name = "методТрапецийToolStripMenuItem";
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод парабол").Name = "методПараболToolStripMenuItem";
                методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked = true;
                answerLabel.Text = "";
                алгоритмToolStripMenuItem.DropDownItems.Add("Алгоритм с постоянным шагом").Name = "алгоритмСПостояннымШагомToolStripMenuItem";
                алгоритмToolStripMenuItem.DropDownItems.Add("Алгоритм с переменным шагом").Name = "сПеременнымШагомToolStripMenuItem";
                алгоритмСПостояннымШагомToolStripMenuItem.Checked = true;
            }
            else if (e.ClickedItem.Name == "ToolStripMenuItem2")
            {






            }
            else if (e.ClickedItem.Name == "ToolStripMenuItem3")
            {

            }
            else if (e.ClickedItem.Name == "ToolStripMenuItem4")
            {

            }
            else
            {
                MessageBox.Show("ERROR TYPE TASK");
            }






        }


        // Переключение Численного метода
        private void ЧисленныйМетодToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in численныйМетодToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }

            if (e.ClickedItem is ToolStripMenuItem currentItem)
            {
                currentItem.Checked = true;
            }
        }



        // Переключение Алгоритма
        private void АлгоритмToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in алгоритмToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }

            if (e.ClickedItem is ToolStripMenuItem currentItem)
            {
                currentItem.Checked = true;
            }

            // Переключаем доступность алгоритмов
            if (алгоритмСПостояннымШагомToolStripMenuItem.Checked == true)
            {
                label1.Visible = true;
                textBoxN.Visible = true;
            }
            else if (сПеременнымШагомToolStripMenuItem.Checked == true)
            {
                label1.Visible = false;
                textBoxN.Visible = false;
            }

        }



















        private void алгоритмToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void численноеИнтегрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void нелинейныеФункцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void численноеИнтегрированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void методПрямоугольниковЛевыхЧастейToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
