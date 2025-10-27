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

        // Интеграл
        public static class integral
        {
            // Подинтегральная функция
            public static double integralF(double x)
            {
                return (2 * Math.Log(x) + x + 1);
            }

            // Метод левых прямоугольников
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

            // Метод правых прямоугольников
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

            // Метод трапеций
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

            // Метод парабол
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
        }


        // Нелинейное уравнение

        // f(x) = x^3 - 2x + sin(x) + 1
        double NonLinearF(double x)
        {
            return Math.Pow(x, 3) - 2 * x + Math.Sin(x) + 1;
        }

        // f'(x) = 3x^2 - 2 + cos(x)  — нужно для метода Ньютона
        double NonLinearDF(double x)
            {
                return 3 * x * x - 2 + Math.Cos(x);
            }

        double BisectionMethod(double a, double b, double eps, uint maxIter)
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

        double NewtonMethod(double x0, double eps, uint maxIter)
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

        double SecantMethod(double x0, double x1, double eps, uint maxIter)
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

        // φ(x) = (x^3 + sin(x) + 1) / 2
        double Phi(double x)
            {
                return (Math.Pow(x, 3) + Math.Sin(x) + 1) / 2.0;
            }

        double SimpleIterationMethod(double a, double b, double eps, uint maxIter)
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

        string calculateNotLinearEquation(string textA, string textB, string textN)
        {
            const double eps = 1e-8;
            uint maxIter = 100; // по умолчанию

            // Попытаемся прочитать n как макс. число итераций
            if (uint.TryParse(textN, out uint nFromInput) && nFromInput > 0)
                maxIter = nFromInput;

            try
            {
                double result;


                if (true) // BisectionMethod
                {
                    if (!double.TryParse(textA, out double a) || !double.TryParse(textB, out double b))
                        throw new ArgumentException("Введите a и b (границы интервала)");

                    double fa = NonLinearF(a);
                    double fb = NonLinearF(b);
                    if (fa * fb > 0)
                        throw new ArgumentException("f(a) и f(b) должны иметь разные знаки");
                        
                    result = BisectionMethod(a, b, eps, maxIter);
                }
                else if (true) //newton
                {
                    if (!double.TryParse(textA, out double x0))
                        throw new ArgumentException("Введите начальное приближение x0");

                    result = NewtonMethod(x0, eps, maxIter);
                }
                else if (true) //secant
                {
                    if (!double.TryParse(textA, out double x0) || !double.TryParse(textB, out double x1))
                        throw new ArgumentException("Введите два начальных приближения: x0 и x1");

                    result = SecantMethod(x0, x1, eps, maxIter);
                }
                else if (true) //simpleIteration
                {
                    if (!double.TryParse(textA, out double a) || !double.TryParse(textB, out double b))
                        throw new ArgumentException("Введите интервал [a, b]");

                    // Для метода простой итерации нужно привести уравнение к виду x = φ(x)
                    // Возьмём: φ(x) = (x^3 + sin(x) + 1) / 2  → из x^3 - 2x + sin(x) + 1 = 0 ⇒ 2x = x^3 + sin(x) + 1
                    result = SimpleIterationMethod(a, b, eps, maxIter);
                }
                else
                {
                    throw new ArgumentException("Не выбран метод решения");
                }

                return result.ToString("F10");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в вычислении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
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

            
            

            
            
            double flm = integral.integralF(lm);
            double frm = integral.integralF(rm);

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
            return AdaptiveSimpsonRecursive(a, b, eps, integral.integralF(a), integral.integralF((a + b) / 2), integral.integralF(b));
        }

        // Вспомогательные функции
        private void calculateIntegral(double a, double b, uint n)
        {
            // Начинаем считать
            if (методПрямоугольниковЛевыхЧастейToolStripMenuItem.Checked == true)
            {
                answerLabel.Text = integral.leftRectangleMethod(a, b, n).ToString();
            }
            else if (методПрямоугольниковПравыхЧастейToolStripMenuItem.Checked == true)
            {
                answerLabel.Text = integral.rightRectangleMethod(a, b, n).ToString();
            }
            else if (методТрапецийToolStripMenuItem.Checked == true)
            {
                answerLabel.Text = integral.trapezoidMethod(a, b, n).ToString();
            }
            else if (методПараболToolStripMenuItem.Checked == true)
            {
                answerLabel.Text = integral.parabolaMethod(a, b, n).ToString();
            }
            else
            {
                MessageBox.Show("ERROR METHOD!");
            }
        }



        private void calculateNotLinearEquations()
        {
            answerLabel.Text = calculateNotLinearEquation(textA.Text, textB.Text, textBoxN.Text);
        }
        private void calculateDifferentialEquations()
        {

        }
        private void calculateElementaryFunctions()
        {

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
                            if (ToolStripMenuItem1.Checked == true)
                            {
                                calculateIntegral(a, b, n);
                            }
                            else if (ToolStripMenuItem2.Checked == true)
                            {
                                calculateDifferentialEquations();
                            }
                            else if (ToolStripMenuItem2.Checked == true)
                            {
                                calculateNotLinearEquations();
                            }
                            else if (ToolStripMenuItem2.Checked == true)
                            {
                                calculateElementaryFunctions();
                            }
                            else
                            {
                                MessageBox.Show("ERROR TYPE TASK");
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

        // Вспомогательный метод для добавления пункта с Checked
        private ToolStripMenuItem AddCheckableItem(ToolStripItemCollection items, string text, string name, bool isChecked = false)
        {
            var item = new ToolStripMenuItem(text) { Name = name, Checked = isChecked };
            items.Add(item);
            return item;
        }

        // Вспомогательные методы
        private void SetupNumericalIntegrationMethods()
        {
            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            // Численные методы
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод прямоугольников левых частей", "методПрямоугольниковЛевыхЧастейToolStripMenuItem", true);
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод прямоугольников правых частей", "методПрямоугольниковПравыхЧастейToolStripMenuItem");
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод трапеций", "методТрапецийToolStripMenuItem");
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод парабол", "методПараболToolStripMenuItem");

            // Алгоритмы
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с постоянным шагом", "алгоритмСПостояннымШагомToolStripMenuItem", true);
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с переменным шагом", "сПеременнымШагомToolStripMenuItem");

            answerLabel.Text = "";
            primerLabel.Text = "∫(2 * ln(x) + x + 1)dx =";
        }

        private void SetupDifferentialEquationsMethods()
        {
            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод Эйлера", "эйлер", true);
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод Рунге-Кутта", "рк");
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "С фиксированным шагом", "фиксированныйШаг", true);

            primerLabel.Text = "y' + y^2 - cos(x) - 1 = ";
            answerLabel.Text = "";
        }

        private void SetupnotLinearEquationsMethods()
        {
            численныйМетодToolStripMenuItem.DropDownItems.Clear();
            алгоритмToolStripMenuItem.DropDownItems.Clear();

            // Численные методы для нелинейных уравнений
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод половинного деления", "bisection", true);
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод Ньютона (касательных)", "newton");
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод хорд", "secant");
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Метод простой итерации", "simpleIteration");

            // Для нелинейных уравнений обычно используется постоянный или адаптивный контроль сходимости,
            // но шаг N может не требоваться — поэтому скроем поле ввода N
            // (видимость будет управляться в обработчике клика по алгоритму)

            // Алгоритмы (можно оставить те же, или упростить)
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с постоянным шагом", "постоянныйШаг", true);
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с переменным шагом", "переменныйШаг");

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
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Разложение в ряд Тейлора", "taylor", true);
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Численное дифференцирование", "differentiation");
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Численное интегрирование", "integration"); // если нужно
            AddCheckableItem(численныйМетодToolStripMenuItem.DropDownItems, "Вычисление функции напрямую", "direct");

            // Алгоритмы — обычно требуется указать количество членов ряда или шаг
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с постоянным шагом", "постоянныйШаг", true);
            AddCheckableItem(алгоритмToolStripMenuItem.DropDownItems, "Алгоритм с переменным шагом", "переменныйШаг");

            primerLabel.Text = "e^x + x^2 - ln(x) + x = ";
            answerLabel.Text = "";
        }





        // Переключение Типов задач
        private void ТипЗадачиToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
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





            

            if (ToolStripMenuItem1.Checked == true)
            {
                textA.Visible = true;
                textB.Visible = true;
            }
            else
            {
                textA.Visible = false;
                textB.Visible = false;
            }

            if (ToolStripMenuItem2.Checked == true)
            {
                label1.Visible = false;
                textBoxN.Visible = false;
            }
            else
            {
                label1.Visible = true;
                textBoxN.Visible = true;
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
    }
}
