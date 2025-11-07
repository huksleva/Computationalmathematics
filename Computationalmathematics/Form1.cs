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


        public static class Integral
        {
            public static double integralF(double x)
            {
                return 2 * Math.Log(x) + x + 1;
            }
            public static double leftRectangleMethod(double a, double b, uint n)
            {
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
                if (n % 2 != 0)
                    throw new ArgumentException("Для метода парабол n должно быть чётным");

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
            public static double AdaptiveSimpsonRecursive(double a, double b, double eps, double fa, double fm, double fb)
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
            public static double EilerMethod(double x0, double y0, double a, double b, uint n)
            {
                double res = 0;


                return res;
            }
            public static double RungeKuttaMethod(double x0, double y0, double a, double b, uint n)
            {
                double res = 0;


                return res;
            }
        }
        public static class NonLinearEqualation
        {
            public static double Phi(double x)
            {
                return (Math.Pow(x, 3) + Math.Sin(x) + 1) / 2.0;
            }
            public static double NonLinearF(double x)
            {
                return Math.Pow(x, 3) - 2 * x + Math.Sin(x) + 1;
            }
            public static double NonLinearDF(double x)
            {
                return 3 * x * x - 2 + Math.Cos(x);
            }
            public static double BisectionMethod(double a, double b, double eps, uint maxIter)
            {
                double fa = NonLinearF(a);
                double fb = NonLinearF(b);

                if (fa * fb > 0)
                    throw new ArgumentException("Нет корня на интервале [a, b]");

                for (uint i = 0; i < maxIter; i++)
                {
                    double c = (a + b) / 2;
                    double fc = NonLinearF(c);

                    if (Math.Abs(fc) < eps || (b - a) / 2 < eps)
                        return c;

                    if (fa * fc < 0)
                        b = c;
                    else
                        a = c;
                }

                return (a + b) / 2;
            }
            public static double NewtonMethod(double x0, double eps, uint maxIter)
            {
                double x = x0;

                for (uint i = 0; i < maxIter; i++)
                {
                    double fx = NonLinearF(x);
                    double dfx = NonLinearDF(x);

                    if (Math.Abs(dfx) < 1e-12)
                        throw new InvalidOperationException("Производная близка к нулю. Метод Ньютона не применим.");

                    double xNew = x - fx / dfx;

                    if (Math.Abs(xNew - x) < eps)
                        return xNew;

                    x = xNew;
                }

                return x;
            }
            public static double SecantMethod(double x0, double x1, double eps, uint maxIter)
            {
                double f0 = NonLinearF(x0);
                double f1 = NonLinearF(x1);

                for (uint i = 0; i < maxIter; i++)
                {
                    if (Math.Abs(f1 - f0) < 1e-12)
                        throw new InvalidOperationException("Разность функций слишком мала. Метод хорд не сходится.");

                    double x2 = x1 - f1 * (x1 - x0) / (f1 - f0);
                    double f2 = NonLinearF(x2);

                    if (Math.Abs(x2 - x1) < eps)
                        return x2;

                    x0 = x1; f0 = f1;
                    x1 = x2; f1 = f2;
                }

                return x1;
            }
            public static double SimpleIterationMethod(double a, double b, double eps, uint maxIter)
            {
                // Начальное приближение — середина интервала
                double x = (a + b) / 2;

                for (uint i = 0; i < maxIter; i++)
                {
                    double xNew = Phi(x);

                    // Проверка выхода за пределы интервала (опционально)
                    if (xNew < a || xNew > b)
                    {
                        // Можно продолжить, но лучше предупредить
                        // Или просто игнорировать — зависит от задачи
                    }

                    if (Math.Abs(xNew - x) < eps)
                        return xNew;

                    x = xNew;
                }

                return x;
            }
            public static void calculateNotLinearEquation(string A, string B, string N, Label label)
            {
                const double eps = 1e-8;
                uint maxIter = 100; // по умолчанию

                // Попытаемся прочитать n как макс. число итераций
                if (uint.TryParse(N, out uint nFromInput) && nFromInput > 0)
                    maxIter = nFromInput;

                try
                {
                    double result;


                    if (true) // BisectionMethod
                    {
                        if (!double.TryParse(A, out double a) || !double.TryParse(B, out double b))
                            throw new ArgumentException("Введите a и b (границы интервала)");

                        double fa = NonLinearF(a);
                        double fb = NonLinearF(b);
                        if (fa * fb > 0)
                            throw new ArgumentException("f(a) и f(b) должны иметь разные знаки");
                        
                        result = BisectionMethod(a, b, eps, maxIter);
                    }
                    else if (true) //newton
                    {
                        if (!double.TryParse(A, out double x0))
                            throw new ArgumentException("Введите начальное приближение x0");

                        result = NewtonMethod(x0, eps, maxIter);
                    }
                    else if (true) //secant
                    {
                        if (!double.TryParse(A, out double x0) || !double.TryParse(B, out double x1))
                            throw new ArgumentException("Введите два начальных приближения: x0 и x1");

                        result = SecantMethod(x0, x1, eps, maxIter);
                    }
                    else if (true) //simpleIteration
                    {
                        if (!double.TryParse(A, out double a) || !double.TryParse(B, out double b))
                            throw new ArgumentException("Введите интервал [a, b]");

                        // Для метода простой итерации нужно привести уравнение к виду x = φ(x)
                        // Возьмём: φ(x) = (x^3 + sin(x) + 1) / 2  → из x^3 - 2x + sin(x) + 1 = 0 ⇒ 2x = x^3 + sin(x) + 1
                        result = SimpleIterationMethod(a, b, eps, maxIter);
                    }
                    else
                    {
                        throw new ArgumentException("Не выбран метод решения");
                    }

                    label.Text = result.ToString("F10");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка в вычислении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static class ElementaryFun
        {

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
                throw new ArgumentException();
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
                throw new ArgumentException();
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

            if (методЭйлераToolStripMenuItem.Checked)
            {

            }
            else if (методРунгеКуттыToolStripMenuItem.Checked)
            {

            }
        }
        private void calculateNonLinearEqualation()
        {

        }
        private void calculateElementaryFunctions()
        {

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
            SetupNumericalIntegrationMethods();

            ToolStripMenuItem1.Checked = true;
            методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked = true;
            алгоритмСПостояннымШагомToolStripMenuItem.Checked = true;
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
            primerLabel.Text = "∫(2 * ln(x) + x + 1)dx =";

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

            primerLabel.Text = "y + 4y'' + cos(x) - 3x' = 0";
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
            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            // Численные методы для нелинейных уравнений
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод половинного деления", "bisection", true);
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод Ньютона (касательных)", "newton");
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод хорд", "secant");
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод простой итерации", "simpleIteration");

            // Для нелинейных уравнений обычно используется постоянный или адаптивный контроль сходимости,
            // но шаг N может не требоваться — поэтому скроем поле ввода N
            // (видимость будет управляться в обработчике клика по алгоритму)

            // Алгоритмы (можно оставить те же, или упростить)
            //AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с постоянным шагом", "постоянныйШаг", true);
            //AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с переменным шагом", "переменныйШаг");

            primerLabel.Text = "f(x) = e^x + x^3 - ln(x)";
            answerLabel.Text = "";
        }
        private void SetupelementaryFunctionsMethod()
        {
            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            // Методы для работы с элементарными функциями
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Разложение в ряд Тейлора", "taylor", true);
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Численное дифференцирование", "differentiation");
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Численное интегрирование", "integration"); // если нужно
            //AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Вычисление функции напрямую", "direct");

            // Алгоритмы — обычно требуется указать количество членов ряда или шаг
            //AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с постоянным шагом", "постоянныйШаг", true);
            //AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с переменным шагом", "переменныйШаг");

            primerLabel.Text = "e^x + x^2 - ln(x) + x = ";
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
    }
}
