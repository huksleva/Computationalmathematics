using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computationalmathematics
{
    public partial class Form2 : Form
    {
        public Form2(double[,] matrix)
        {
            InitializeComponent();
            UpdateData(matrix);
        }

        // Обновление данных таблицы
        public void UpdateData(double[,] matrix)
        {
            // Очищаем старые строки таблицы
            dataGridDIFF.Rows.Clear();

            // Заполняем таблицу
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridDIFF.Rows.Add(matrix[i, 0], matrix[i, 1]);
            }

            // Настраиваем график
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "t";
            chart1.ChartAreas[0].AxisY.Title = "T";
            
            
            // Создаём серию
            var series = new Series
            {
                Name = "T(t)",
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                BorderWidth = 2
            };

            // Рисуем график
            // Добавляем точки
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Защита от бесконечностей (y² может взорваться!)
                if (double.IsNaN(matrix[i, 1]) || double.IsInfinity(matrix[i, 1]) || Math.Abs(matrix[i, 1]) > 1e6)
                {
                    break;
                }
                    
                series.Points.AddXY(matrix[i, 0], matrix[i, 1]);
            }

            chart1.Series.Add(series);
        }


    }
}
