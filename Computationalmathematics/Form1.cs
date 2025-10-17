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

        // При загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem1.Checked = true;
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


    }
}
