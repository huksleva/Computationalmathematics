using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Вспомогательная штука
using static Computationalmathematics.Form1.help_to_ElementaryFun;

namespace Computationalmathematics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 form2;

        public class help_to_ElementaryFun
        {
            // Общие вспомогательные функции
            public static uint factorial(uint x)
            {
                uint res = 1;
                for (uint i = 1; i <= x; i++)
                {
                    res *= i;
                }
                return res;
            }
            // Вспомогательные функции для powerSeriesMaclorenaMethod
            public static double powerSeriesMaclorena_exp(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += Math.Pow(x, i) / factorial(i);
                }
                return res;
            }
            public static double powerSeriesMaclorena_sinx(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / factorial(2 * i + 1);
                }
                return res;
            }
            public static double powerSeriesMaclorena_cosx(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / factorial(2 * i + 1);
                }
                return res;
            }
            public static double powerSeriesMaclorena_shx(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += Math.Pow(x, 2 * i - 1) / factorial(2 * i - 1);
                }
                return res;
            }
            public static double powerSeriesMaclorena_chx(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += Math.Pow(x, 2 * i) / factorial(2 * i);
                }
                return res;
            }
            public static double powerSeriesMaclorena_lnx(double x, uint n)
            {
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += 1 / (2 * i - 1) * Math.Pow((1 - x) / (1 + x), 2 * i - 1);
                }
                return -2 * res;
            }

            public static double ChebishevFunction(double x, uint k)
            {
                if ((x < -1.0) || (x > 1.0))
                {
                    MessageBox.Show("INVALID VALUE. x must be: |x| <= 1");
                    return 0;
                }
                return (Math.Pow(x + Math.Sqrt(Math.Pow(x, 2) - 1), k) + Math.Pow(x - Math.Sqrt(Math.Pow(x, 2) - 1), k)) / 2;
            }

            public static double iterationNewton_sqrt_x_p(double x, uint n, uint p)
            {
                if (x < 0.0) 
                {
                    MessageBox.Show("ERROR! X < 0!");
                    return 0;
                }
                
                double res = (x < 1) ? 1.0 : x; // начальное значение можно выбрать любое больше 0
                for (uint i = 1; i <= n; i++)
                {
                    res = ((p-1)*res + x/Math.Pow(res, p-1)) / p;
                }
                return res;
            }
		}


        public static class Integral
        {
            private static double integralF(double x)
            {
                //return 2 * Math.Log(x) + x + 1;
                double r_Eath = 6377000;
                double R = 60.27 * r_Eath;
                double g = 9.81;
                return Math.Sqrt(x*R/(2*g*Math.Pow(r_Eath, 2)*(R-x)));
            }
            public static double leftRectangleMethod(double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return 0;
                }
                double h = (b - a) / n;
                double res = 0;
                for (uint i = 0; i < n; i++)
                {
                    res += integralF(a + i * h);
                }
                return h * res;
            }
            public static double rightRectangleMethod(double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return 0;
                }
                double h = (b - a) / n;
                double res = 0;
                for (uint i = 1; i <= n; i++)
                {
                    res += integralF(a + i * h);
                }
                return h * res;
            }
            public static double trapezoidMethod(double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return 0;
                }
                double h = (b - a) / n;
                double sum = integralF(a) + integralF(b); // концы
                for (uint i = 1; i < n; i++)
                {
                    sum += 2 * integralF(a + i * h);
                }
                return h / 2 * sum;
            }
            public static double parabolaMethod(double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return 0;
                }
                else if (n % 2 != 0)
                {
                    MessageBox.Show("Для метода парабол n должно быть чётным");
                    return 0;
                }
                    

                double h = (b - a) / n;
                double sum = integralF(a) + integralF(b); // x0 и xn

                // Нечётные индексы: 1, 3, 5, ..., n-1 → коэффициент 4
                for (uint i = 1; i < n; i += 2)
                {
                    sum += 4 * integralF(a + i * h);
                }

                // Чётные индексы: 2, 4, ..., n-2 → коэффициент 2
                for (uint i = 2; i < n; i += 2)
                {
                    sum += 2 * integralF(a + i * h);
                }

                return sum * h / 3.0;
            }
            private static double AdaptiveSimpsonRecursive(double a, double b, double eps, double fa, double fm, double fb)
            {
                double m = (a + b) / 2;
                double lm = (a + m) / 2; // середина левой половины
                double rm = (m + b) / 2; // середина правой половины


                double flm = integralF(lm);
                double frm = integralF(rm);

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
            public static double AdaptiveSimpson(double a, double b, double eps)
            {
                return AdaptiveSimpsonRecursive(a, b, eps, integralF(a), integralF((a + b) / 2), integralF(b));
            }
        }
        public static class DiffEqualation
        {
            private static double f(double x, double y)
            {
                //return Math.Pow(x, 2) + 4 * x + y;   //dy/dx = x² + 4x + y

               
                return (-0.003) * (y - 22);
            }
            private static uint factorial(uint x)
            {
                uint res = 1;
                for (uint i = 1; i <= x; i++)
                {
                    res *= i;
                }
                return res;
            }
            private static uint C(uint n, uint k)
            {
                if (k > n)
                {
                    MessageBox.Show("ERROR, k > n");
                    return 0;
                }
                return factorial(n) / (factorial(k) * factorial(n - k));
            }
            public static double[,] EilerMethod(double x0, double y0, double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return null;
                }
                double h = (b - a) / n; // шаг
                double[,] res = new double[n+1, 2];

                
                double x = x0, y = y0;
                for (int i = 0; i < n; i++)
                {
                    res[i, 0] = x;
                    res[i, 1] = y;

                    y = y + h * f(x, y);
                    x = x + h;
                }
                res[n, 0] = x;
                res[n, 1] = y;


                // Возвращет матрицу из двух строк: X и Y
                return res;
            }
            public static double[,] RungeKuttaMethod(double x0, double y0, double a, double b, uint n)
            {
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return null;
                }
                double h = (b - a) / n;
                double[,] res = new double[n+1, 2];


                double x = x0, y = y0;
                for (int i = 0; i < n; i++)
                {
                    res[i, 0] = x;
                    res[i, 1] = y;

                    // Вычисление коэффициентов K1–K4
                    double k1 = h * f(x, y);
                    double k2 = h * f(x + (h / 2), y + (k1 / 2));
                    double k3 = h * f(x + (h / 2), y + (k2 / 2));
                    double k4 = h * f(x + h, y + k3);
                    double F = (k1 + (2 * k2) + (2 * k3) + k4) / 6;

                    y = y + F;
                    x = x + h;
                }
                res[n, 0] = x;
                res[n, 1] = y;


                // Возвращет матрицу из двух строк: X и Y
                return res;
            }
            public static double[,] RungeKuttaMethod2(double x0, double y0, double a, double b, uint n)
            {
                // Неявный метод Рунге — Кутты второго порядка
                // Простейшим неявным методом Рунге — Кутты является модифицированный метод Эйлера «с пересчётом»\
                // Модифицированный метод Эйлера «с пересчётом» имеет второй порядок точности
                if (n == 0)
                {
                    MessageBox.Show("ERROR, на 0 делить нельзя");
                    return null;
                }
                double h = (b - a) / n;
                double[,] res = new double[n + 1, 2];


                double x = x0, y = y0;
                double y_prog, x_prog; // прогноз
                for (int i = 0; i < n; i++)
                {
                    res[i, 0] = x;
                    res[i, 1] = y;


                    // прогноз
                    y_prog = y + h * f(x, y);
                    x_prog = x + h;

                    // Коррекция
                    y = y + h * (f(x,y) + f(x_prog, y_prog)) / 2;
                    x = x + h;
                }
                res[n, 0] = x;
                res[n, 1] = y;


                // Возвращет матрицу из двух строк: X и Y
                return res;
            }
        }
        public static class NonLinearEqualation
        {
            private static double f(double x)
            {
                // f(x) = e^x + x^3 - ln(x)
                return Math.Exp(x) + Math.Pow(x, 3) - Math.Log(x);
            }
            private static double df(double x)
            {
                // f`(x) = e^x + 3x^2 - 1/x
                return Math.Exp(x) + (3 * Math.Pow(x, 2)) - (1 / x);
            }
            private static double ddf(double x)
            {
                // f``(x) = e^x + 6x + 1/(x^2)
                return Math.Exp(x) + (6 * x) - (1 / Math.Pow(x, 2));
            }
            
            private static double FindInitialGuess(double a, double b, double accuracy, int steps = 100)
            {
                /// <summary>
                /// Находит начальное приближение x0 для метода Ньютона на отрезке [a, b].
                /// </summary>
                /// <param name="f">Функция f(x)</param>
                /// <param name="ddf">Вторая производная f''(x)</param>
                /// <param name="d1">Первая производная f'(x)</param>
                /// <param name="a">Левая граница отрезка</param>
                /// <param name="b">Правая граница отрезка</param>
                /// <param name="steps">Число точек для проверки (по умолчанию 100)</param>
                /// <returns>Найденное x0, или NaN, если не найдено</returns>
                

                for (int i = 0; i <= steps; i++)
                {
                    double x = a + (b - a) * i / steps; // равномерная сетка
                    double fx = f(x);
                    double f2x = ddf(x);
                    double f1x = df(x);

                    // Проверяем: f'(x) не слишком мала и условие сходимости выполняется
                    if (Math.Abs(f1x) > accuracy && fx * f2x > 0)
                    {
                        return x;
                    }
                }

                // Если не нашли — пробуем центр отрезка как fallback (осторожно!)
                double mid = (a + b) / 2;
                if (Math.Abs(df(mid)) > accuracy)
                {
                    return mid;
                }

                // Если всё плохо — возвращаем NaN
                return double.NaN;
            }
            
            public static double NewtonMethod(double a, double b, double accuracy)
            {
                // Ищем начальное приближение (x0) при помощи левостороннего бинарного поиска
                double x = FindInitialGuess(a, b, accuracy);
                
                while (x > accuracy)
                {
                    x -= f(x) / df(x);
                }
                
                return x;
            }
            public static double dihotomiyaMethod(double a, double b, double accuracy)
            {








                return 0;
            }
            public static double chordMethod(double a, double b, double accuracy)
            {








                return 0;
            }
        }
        public static class ElementaryFun
        {
            public static double powerSeriesMaclorenaMethod(double x, uint n)
			{
                // return powerSeriesMaclorena_exp(x, n);
                if (n > 7)
                {
					MessageBox.Show("Так это пробный вариант метода Макларена, то не реализована функция вычисления коэффициентов.\nВместо этого заранее записаны коэф. для конкртной функции: exp(x).\nВобщем, должно быть n <= 7.");
					return 0.0;
				}

				double a0 = 0.9999998;
				double a1 = 1.0000000;
				double a2 = 0.5000063;
				double a3 = 0.1666674;
				double a4 = 0.0416350;
				double a5 = 0.0083298;
				double a6 = 0.0014393;
				double a7 = 0.0002040;

                double[] a = {a0, a1, a2, a3, a4, a5, a6, a7 };
                double res = 0;
                for (int k = 0; k <= n; k++)
                {
                    res += a[k] * Math.Pow(x, k);
                }
				return res;
			}
            public static double ChebushevMethod(double x, uint n, double a, double b)
            {
				if (x < a || x > b)
                {
                    MessageBox.Show(nameof(x), $"x must be in [{a}, {b}]");
                    return 0.0;
                }
                if (a >= b)
                { 
                    MessageBox.Show("a must be less than b", nameof(a));
                    return 0.0;
                }
                if (n > 5)
                {
                    MessageBox.Show("Так это пробный вариант метода Чебышёва, то не реализована функция вычисления коэффициентов.\nВместо этого заранее записаны коэф. для конкртной функции: sinx.\nВобщем, должно быть n<=5.");
                    return 0.0;
                }


				// Преобразуем x ∈ [a, b] → t ∈ [-1, 1]
				//double t = (2 * x - a - b) / (b - a);

				//double T0 = 1.0; // Первый элемент многочлена Чебышева
                //double T1 = t; // Второй элемент многочлена Чебышева

				double a1 = 1.000000002;
                double a2 = 0;
				double a3 = -0.166666589;
                double a4 = 0;
				double a5 = 0.008333075;
                double a6 = 0;
				double a7 = -0.000198107;
                double a8 = 0;
                double a9 = 0.000002608;

				double[] ck = { a1, a2, a3, a4, a5, a6, a7, a8, a9 };

                double res = 0.0;
				for (uint k = 0; k < n*2-1; k+=2)
				{
                    res += ck[k] * Math.Pow(x, k);
				}
				return res;
            }
			public static double iterationMethod(double x, uint n)
			{
				return iterationNewton_sqrt_x_p(x, n, 2);
			}
		}




        // Проверка на целое число
        public static uint CheckOnUIntNumber(string input)
        {
            if (uint.TryParse(input, out uint num))
            {
                return num;
            }
            else
            {
                MessageBox.Show(input + " - это не целое неотрицательное число");
                return 0;
                throw new ArgumentException("ERROR");
            }
        }
        // Проверка на число, оно может быть и дробным и отрицательным
        public static double CheckOnNumber(string input)
        {
            if (double.TryParse(input, out double num))
            {
                return num;
            }
            else
            {
                MessageBox.Show(input + " - это не число");
                return 0.0;
                throw new ArgumentException("ERROR");
            }
        }




        // Невидимость элементов и пунктов меню
        private void allMetodsInvisible()
        {
            foreach (ToolStripItem subitem in численныйМетодToolStripMenuItem.DropDownItems)
            {
                subitem.Visible = false;
            }
        }
        private void allAlgoritmsInvisible()
        {
            foreach (ToolStripItem subitem in алгоритмToolStripMenuItem.DropDownItems)
            {
                subitem.Visible = false;
            }
        }
        private void allElementInvisible()
        {
            foreach (Control control in Controls)
            {
                if (!((control == menuStrip1) || (control == primerLabel) || (control == answerLabel) || (control == button1) || control == nameOftask_label))
                {
                    control.Visible = false;
                }
            }
        }



        private void calculateIntegral()
        {
            double a = CheckOnNumber(textA.Text);
            double b = CheckOnNumber(textB.Text);
            uint n = CheckOnUIntNumber(textBoxN.Text);

            
            // Начинаем считать
            if (методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked)
            {
                answerLabel.Text = Integral.leftRectangleMethod(a, b, n).ToString();
            }
            else if (методПрямоугольниковПравыхЧастейToolStripMenuItem.Checked)
            {
                answerLabel.Text = Integral.rightRectangleMethod(a, b, n).ToString();
            }
            else if (методТрапецийToolStripMenuItem.Checked)
            {
                answerLabel.Text = Integral.trapezoidMethod(a, b, n).ToString();
            }
            else if (методПараболToolStripMenuItem.Checked)
            {
                answerLabel.Text = Integral.parabolaMethod(a, b, n).ToString();
            }
            else
            {
                MessageBox.Show("ERROR METHOD!");
            }
                        









        }
        private void calculateDifferentialEquation()
        {
            double x0 = CheckOnNumber(textBoxX0.Text);
            double y0 = CheckOnNumber(textBoxY0.Text);
            double a = CheckOnNumber(textBox_IntervalA.Text);
            double b = CheckOnNumber(textBox_IntervalB.Text);
            uint n = CheckOnUIntNumber(textBoxN.Text);
            double[,] res = new double[n,2];

            if (методЭйлераToolStripMenuItem.Checked)
            {
                res = DiffEqualation.EilerMethod(x0, y0, a, b, n);
            }
            else if (методРунгеКуттыToolStripMenuItem.Checked)
            {
                res = DiffEqualation.RungeKuttaMethod2(x0, y0, a, b, n);
            }
            else
            {
                MessageBox.Show("ERROR, нет такого метода");
                res = null;
            }



            // Если окно ещё не создано ИЛИ уже закрыто (и удалено)
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2(res);
                form2.FormClosed += (s, args) => form2 = null; // автоматически обнуляем при закрытии
                form2.Show();
            }
            else
            {
                // Окно уже открыто → просто обновляем данные
                form2.UpdateData(DiffEqualation.EilerMethod(x0, y0, a, b, n)); // ← нужно реализовать этот метод в Form2
                form2.BringToFront();      // поднимаем окно поверх других
            }

        }
        private void calculateNonLinearEqualation()
        {
            double accuracy = CheckOnNumber(textBox_accuracy.Text);
            double a = CheckOnNumber(textBox_IntervalA.Text);
            double b = CheckOnNumber(textBox_IntervalB.Text);

            if (методНьютонакасательныхToolStripMenuItem.Checked)
            {
                answerLabel.Text = "x = " + NonLinearEqualation.NewtonMethod(a, b, accuracy).ToString();
            }
            else if (дихотомииToolStripMenuItem.Checked)
            {
                answerLabel.Text = "x = " + NonLinearEqualation.dihotomiyaMethod(a, b, accuracy).ToString();
            }
            else if (хордToolStripMenuItem.Checked)
            {
                answerLabel.Text = "x = " + NonLinearEqualation.chordMethod(a, b, accuracy).ToString();
            }
            else
            {
                MessageBox.Show("ERROR, нет такого метода для вычисления нелинейных функций.");
            }
        }
        private void calculateElementaryFunctions()
        {
            uint n = CheckOnUIntNumber(textBoxN.Text);
            double x = CheckOnNumber(textBoxX0.Text);
            double a = CheckOnNumber(textBox_IntervalA.Text);
            double b = CheckOnNumber(textBox_IntervalB.Text);
            

			// Начинаем считать
			if (разложениеВСтепенныеРядыМаклоренаToolStripMenuItem.Checked)
			{
                answerLabel.Text = ElementaryFun.powerSeriesMaclorenaMethod(x, n).ToString();
			}
			else if (многочисленныхПриближенийЧебышеваToolStripMenuItem.Checked)
			{
				answerLabel.Text =  ElementaryFun.ChebushevMethod(x, n, a, b).ToString();
			}
			else if (итерацийToolStripMenuItem.Checked)
			{
				answerLabel.Text = ElementaryFun.iterationMethod(x, n).ToString();
			}
			else
			{
				MessageBox.Show("ERROR METHOD IN ELEMENTARY FUNCTION!");
			}
        }




		// Нажатие на кнопку - вычисление примера
		private void button1_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem1.Checked)
            {
                calculateIntegral();
            }
            else if (ToolStripMenuItem2.Checked)
            {
                calculateDifferentialEquation();
            }
            else if (ToolStripMenuItem3.Checked)
            {
                calculateNonLinearEqualation();
            }
            else if (ToolStripMenuItem4.Checked)
            {
                calculateElementaryFunctions();
            }
            else
            {
                MessageBox.Show("ERROR TYPE TASK");
            }
        }

        

        // При загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            allElementInvisible();
            allMetodsInvisible();
            allAlgoritmsInvisible();

            SetupnotLinearEquationsMethods();
            ToolStripMenuItem3.Checked = true;
        }

        
        // Вспомогательные методы
        private void SetupNumericalIntegrationMethods()
        {
            // Численные методы
            методПрямоугольниковЛевыхЧастейToolStripMenuItem.Visible = true;
            методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked = true; // checked=true
            методПрямоугольниковПравыхЧастейToolStripMenuItem.Visible = true;
            методПараболToolStripMenuItem.Visible = true;
            методТрапецийToolStripMenuItem.Visible = true;


            // Алгоритмы
            алгоритмСПостояннымШагомToolStripMenuItem.Visible = true;
            алгоритмСПостояннымШагомToolStripMenuItem.Checked = true; // checked=true
            сПеременнымШагомToolStripMenuItem.Visible = true;

            answerLabel.Text = "";
            primerLabel.Text = "∫(r*R / (2*g*r_Earth^2*(R-r)))dr =";

            textA.Visible = true;
            textB.Visible = true;
            label1.Visible = true;
            textBoxN.Visible = true;
        }
        private void SetupDifferentialEquationsMethods()
        {
            методЭйлераToolStripMenuItem.Visible = true;
            методЭйлераToolStripMenuItem.Checked = true; // checked=true
            методРунгеКуттыToolStripMenuItem.Visible = true;

            сФиксированнымШагомToolStripMenuItem.Visible = true;
            сФиксированнымШагомToolStripMenuItem.Checked = true; // checked=true

            primerLabel.Text = "dT/dt = -0.003 * (T - 22)";
            answerLabel.Text = "";

            textBoxX0.Visible = true;
            labelX0.Visible = true;
            labelY0.Visible = true;
            textBoxY0.Visible = true;
            label_Interval.Visible = true;
            textBox_IntervalA.Visible = true;
            textBox_IntervalB.Visible = true;
            label1.Visible = true;
            textBoxN.Visible = true;
        }
        private void SetupnotLinearEquationsMethods()
        {
            // Численные методы
            методНьютонакасательныхToolStripMenuItem.Visible = true;
            дихотомииToolStripMenuItem.Visible = true;
            хордToolStripMenuItem.Visible = true;

            методНьютонакасательныхToolStripMenuItem.Checked = true;

           
            
            label_Interval.Visible = true;
            textBox_IntervalA.Visible = true;
            textBox_IntervalB.Visible = true;
            label_accuracy.Visible = true;
            textBox_accuracy.Visible = true;


            primerLabel.Text = "f(x) = e^x + x^3 - ln(x) = 0";
            answerLabel.Text = "x = ";
        }
        private void SetupelementaryFunctionsMethod()
        {
			// Численные методы
			разложениеВСтепенныеРядыМаклоренаToolStripMenuItem.Visible = true;
			многочисленныхПриближенийЧебышеваToolStripMenuItem.Visible = true;
			итерацийToolStripMenuItem.Visible = true;

            многочисленныхПриближенийЧебышеваToolStripMenuItem.Checked = true;

            textBoxX0.Visible = true;
            labelX0.Visible = true;
            textBoxN.Visible = true;
            label1.Visible = true;
            label_Interval.Visible = true;
            textBox_IntervalA.Visible = true; 
            textBox_IntervalB.Visible = true;

            


			primerLabel.Text = "sin(x) = ";
            answerLabel.Text = "";
        }


        



        // Переключение Типов задач
        private void ТипЗадачиToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Сделать все элементы формы невидимыми
            allElementInvisible();
            // Сделать все пункты меню методов и алгоритмов невидимыми
            allMetodsInvisible();
            allAlgoritmsInvisible();

            // Сбросить Checked у всех пунктов
            foreach (ToolStripMenuItem item in типЗадачиToolStripMenuItem.DropDownItems)
                item.Checked = false;

            // Установить Checked для выбранного
            if (e.ClickedItem is ToolStripMenuItem currentItem)
                currentItem.Checked = true;

            // Обновить заголовок
            nameOftask_label.Text = e.ClickedItem.Text;

            // Выбрать конфигурацию подменю по имени
            switch (e.ClickedItem.Name)
            {
                case "ToolStripMenuItem1":
                    SetupNumericalIntegrationMethods();
                    break;
                case "ToolStripMenuItem2":
                    SetupDifferentialEquationsMethods();
                    break;
                case "ToolStripMenuItem3":
                    SetupnotLinearEquationsMethods();
                    break;
                case "ToolStripMenuItem4":
                    SetupelementaryFunctionsMethod();
                    break;
                default:
                    MessageBox.Show("Неизвестный тип задачи");
                    break;
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
            
            // Специальная настройка Элементарных функций, для метода Чебышёва, где нужен интервал
            if (многочисленныхПриближенийЧебышеваToolStripMenuItem.Checked == true)
            {
                textBox_IntervalA.Visible = true;
                textBox_IntervalB.Visible = true;
                label_Interval.Visible = true;
            }
            else
            {
				textBox_IntervalA.Visible = false;
				textBox_IntervalB.Visible = false;
				label_Interval.Visible = false;
			}
        }

        // Переключение Алгоритма
        private void АлгоритмToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in алгоритмToolStripMenuItem.DropDownItems)
                item.Checked = false;

            if (e.ClickedItem is ToolStripMenuItem currentItem)
                currentItem.Checked = true;

            // Используем Name, который вы задали при создании пунктов!
            if (e.ClickedItem.Name == "алгоритмСПостояннымШагомToolStripMenuItem")
            {
                label1.Visible = true;
                textBoxN.Visible = true;
            }
            else if (e.ClickedItem.Name == "сПеременнымШагомToolStripMenuItem")
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

        private void nameOftask_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void primerLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableForDIFF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void методНьютонакасательныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
