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
            for (double i = a; i < b; i+=h)
            {
                res += F(i);
            }

            return h*res;
        }

        // Метод правых прямоугольников
        double rightRectangleMethod(double a, double b, uint n)
        {
            double h = (b - a) / n;
            double res = 0;
            for (double i = a + h; i <= b; i += h)
            {
                res += F(i);
            }

            return h * res;
        }

        // Метод трапеций
        double trapezoidMethod(double a, double b, uint n)
        {
            double res = 0;
            double h = (b - a) / n;



            return res;
        }



        // Нажатие на кнопку - вычисление примера
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на то что a, b, n - числа
            if (double.TryParse(textA.Text, out double a))
            {
                if (double.TryParse(textB.Text, out double b))
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



                        }
                        else if (методПараболToolStripMenuItem.Checked == true)
                        {

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
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников левых частей");
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников правых частей");
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод прямоугольников правых частей");
                численныйМетодToolStripMenuItem.DropDownItems.Add("Метод парабол");

                алгоритмToolStripMenuItem.DropDownItems.Add("Алгоритм с постоянным шагом");
                алгоритмToolStripMenuItem.DropDownItems.Add("Алгоритм с переменным шагом");
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
