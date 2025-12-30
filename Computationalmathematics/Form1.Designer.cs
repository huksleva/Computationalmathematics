namespace Computationalmathematics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.численныйМетодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методТрапецийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПараболToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЭйлераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методРунгеКуттыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разложениеВСтепенныеРядыМаклоренаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.многочисленныхПриближенийЧебышеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.итерацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методНьютонакасательныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дихотомииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмСПостояннымШагомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПеременнымШагомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сФиксированнымШагомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameOftask_label = new System.Windows.Forms.Label();
            this.primerLabel = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.textA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelY0 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.label_Interval = new System.Windows.Forms.Label();
            this.textBox_IntervalA = new System.Windows.Forms.TextBox();
            this.textBox_IntervalB = new System.Windows.Forms.TextBox();
            this.label_accuracy = new System.Windows.Forms.Label();
            this.textBox_accuracy = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типЗадачиToolStripMenuItem,
            this.численныйМетодToolStripMenuItem,
            this.алгоритмToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // типЗадачиToolStripMenuItem
            // 
            this.типЗадачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4});
            this.типЗадачиToolStripMenuItem.Name = "типЗадачиToolStripMenuItem";
            this.типЗадачиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.типЗадачиToolStripMenuItem.Text = "Тип задачи";
            this.типЗадачиToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ТипЗадачиToolStripMenuItem_DropDownItemClicked);
            this.типЗадачиToolStripMenuItem.Click += new System.EventHandler(this.численноеИнтегрированиеToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.ToolStripMenuItem1.Text = "Численное интегрирование";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.численноеИнтегрированиеToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(249, 22);
            this.ToolStripMenuItem2.Text = "Дифференциальные уравнения";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(249, 22);
            this.ToolStripMenuItem3.Text = "Нелинейные уравнения";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.нелинейныеФункцииToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(249, 22);
            this.ToolStripMenuItem4.Text = "Элементарные функции";
            // 
            // численныйМетодToolStripMenuItem
            // 
            this.численныйМетодToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem,
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem,
            this.методТрапецийToolStripMenuItem,
            this.методПараболToolStripMenuItem,
            this.методЭйлераToolStripMenuItem,
            this.методРунгеКуттыToolStripMenuItem,
            this.разложениеВСтепенныеРядыМаклоренаToolStripMenuItem,
            this.многочисленныхПриближенийЧебышеваToolStripMenuItem,
            this.итерацийToolStripMenuItem,
            this.методНьютонакасательныхToolStripMenuItem,
            this.дихотомииToolStripMenuItem,
            this.хордToolStripMenuItem});
            this.численныйМетодToolStripMenuItem.Name = "численныйМетодToolStripMenuItem";
            this.численныйМетодToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.численныйМетодToolStripMenuItem.Text = "Численный метод";
            this.численныйМетодToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ЧисленныйМетодToolStripMenuItem_DropDownItemClicked);
            // 
            // методПрямоугольниковЛевыхЧастейToolStripMenuItem
            // 
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Name = "методПрямоугольниковЛевыхЧастейToolStripMenuItem";
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Text = "Метод прямоугольников левых частей";
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Click += new System.EventHandler(this.методПрямоугольниковЛевыхЧастейToolStripMenuItem_Click);
            // 
            // методПрямоугольниковПравыхЧастейToolStripMenuItem
            // 
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Name = "методПрямоугольниковПравыхЧастейToolStripMenuItem";
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Text = "Метод прямоугольников правых частей";
            // 
            // методТрапецийToolStripMenuItem
            // 
            this.методТрапецийToolStripMenuItem.Name = "методТрапецийToolStripMenuItem";
            this.методТрапецийToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методТрапецийToolStripMenuItem.Text = "Метод трапеций";
            // 
            // методПараболToolStripMenuItem
            // 
            this.методПараболToolStripMenuItem.Name = "методПараболToolStripMenuItem";
            this.методПараболToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методПараболToolStripMenuItem.Text = "Метод парабол";
            // 
            // методЭйлераToolStripMenuItem
            // 
            this.методЭйлераToolStripMenuItem.Name = "методЭйлераToolStripMenuItem";
            this.методЭйлераToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методЭйлераToolStripMenuItem.Text = "Метод Эйлера";
            // 
            // методРунгеКуттыToolStripMenuItem
            // 
            this.методРунгеКуттыToolStripMenuItem.Name = "методРунгеКуттыToolStripMenuItem";
            this.методРунгеКуттыToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методРунгеКуттыToolStripMenuItem.Text = "Метод Рунге-Кутты";
            // 
            // разложениеВСтепенныеРядыМаклоренаToolStripMenuItem
            // 
            this.разложениеВСтепенныеРядыМаклоренаToolStripMenuItem.Name = "разложениеВСтепенныеРядыМаклоренаToolStripMenuItem";
            this.разложениеВСтепенныеРядыМаклоренаToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.разложениеВСтепенныеРядыМаклоренаToolStripMenuItem.Text = "Разложение в степенные ряды Маклорена";
            // 
            // многочисленныхПриближенийЧебышеваToolStripMenuItem
            // 
            this.многочисленныхПриближенийЧебышеваToolStripMenuItem.Name = "многочисленныхПриближенийЧебышеваToolStripMenuItem";
            this.многочисленныхПриближенийЧебышеваToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.многочисленныхПриближенийЧебышеваToolStripMenuItem.Text = "Многочисленных приближений Чебышёва";
            // 
            // итерацийToolStripMenuItem
            // 
            this.итерацийToolStripMenuItem.Name = "итерацийToolStripMenuItem";
            this.итерацийToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.итерацийToolStripMenuItem.Text = "Итераций";
            // 
            // методНьютонакасательныхToolStripMenuItem
            // 
            this.методНьютонакасательныхToolStripMenuItem.Name = "методНьютонакасательныхToolStripMenuItem";
            this.методНьютонакасательныхToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.методНьютонакасательныхToolStripMenuItem.Text = "Ньютона (касательных)";
            this.методНьютонакасательныхToolStripMenuItem.Click += new System.EventHandler(this.методНьютонакасательныхToolStripMenuItem_Click);
            // 
            // дихотомииToolStripMenuItem
            // 
            this.дихотомииToolStripMenuItem.Name = "дихотомииToolStripMenuItem";
            this.дихотомииToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.дихотомииToolStripMenuItem.Text = "Дихотомии (деления пополам)";
            // 
            // хордToolStripMenuItem
            // 
            this.хордToolStripMenuItem.Name = "хордToolStripMenuItem";
            this.хордToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.хордToolStripMenuItem.Text = "Хорд";
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгоритмСПостояннымШагомToolStripMenuItem,
            this.сПеременнымШагомToolStripMenuItem,
            this.сФиксированнымШагомToolStripMenuItem});
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            this.алгоритмToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.АлгоритмToolStripMenuItem_DropDownItemClicked);
            // 
            // алгоритмСПостояннымШагомToolStripMenuItem
            // 
            this.алгоритмСПостояннымШагомToolStripMenuItem.Name = "алгоритмСПостояннымШагомToolStripMenuItem";
            this.алгоритмСПостояннымШагомToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.алгоритмСПостояннымШагомToolStripMenuItem.Text = "С постоянным шагом";
            // 
            // сПеременнымШагомToolStripMenuItem
            // 
            this.сПеременнымШагомToolStripMenuItem.Name = "сПеременнымШагомToolStripMenuItem";
            this.сПеременнымШагомToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.сПеременнымШагомToolStripMenuItem.Text = "С переменным шагом";
            // 
            // сФиксированнымШагомToolStripMenuItem
            // 
            this.сФиксированнымШагомToolStripMenuItem.Name = "сФиксированнымШагомToolStripMenuItem";
            this.сФиксированнымШагомToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.сФиксированнымШагомToolStripMenuItem.Text = "С фиксированным шагом";
            // 
            // nameOftask_label
            // 
            this.nameOftask_label.AutoSize = true;
            this.nameOftask_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOftask_label.Location = new System.Drawing.Point(279, 40);
            this.nameOftask_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameOftask_label.Name = "nameOftask_label";
            this.nameOftask_label.Size = new System.Drawing.Size(188, 17);
            this.nameOftask_label.TabIndex = 4;
            this.nameOftask_label.Text = "Элементарные функции";
            this.nameOftask_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameOftask_label.Click += new System.EventHandler(this.nameOftask_label_Click);
            // 
            // primerLabel
            // 
            this.primerLabel.AutoSize = true;
            this.primerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primerLabel.Location = new System.Drawing.Point(-2, 111);
            this.primerLabel.Name = "primerLabel";
            this.primerLabel.Size = new System.Drawing.Size(567, 63);
            this.primerLabel.TabIndex = 5;
            this.primerLabel.Text = "∫(2 * ln(x) + x + 1)dx =";
            this.primerLabel.Click += new System.EventHandler(this.primerLabel_Click);
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textB.Location = new System.Drawing.Point(12, 97);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(68, 23);
            this.textB.TabIndex = 6;
            this.textB.Text = "5";
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textA.Location = new System.Drawing.Point(12, 177);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(68, 23);
            this.textA.TabIndex = 7;
            this.textA.Text = "1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(383, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(188, 252);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(81, 23);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.Text = "33";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "n (кол-во разбиений) =";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(616, 111);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 63);
            this.answerLabel.TabIndex = 11;
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(7, 288);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(23, 13);
            this.labelX0.TabIndex = 12;
            this.labelX0.Text = "X =";
            this.labelX0.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelY0
            // 
            this.labelY0.AutoSize = true;
            this.labelY0.Location = new System.Drawing.Point(6, 312);
            this.labelY0.Name = "labelY0";
            this.labelY0.Size = new System.Drawing.Size(23, 13);
            this.labelY0.TabIndex = 13;
            this.labelY0.Text = "Y =";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(35, 286);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(85, 20);
            this.textBoxX0.TabIndex = 14;
            this.textBoxX0.Text = "0";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(35, 312);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(85, 20);
            this.textBoxY0.TabIndex = 15;
            this.textBoxY0.Text = "83";
            // 
            // label_Interval
            // 
            this.label_Interval.AutoSize = true;
            this.label_Interval.Location = new System.Drawing.Point(0, 345);
            this.label_Interval.Name = "label_Interval";
            this.label_Interval.Size = new System.Drawing.Size(217, 13);
            this.label_Interval.TabIndex = 16;
            this.label_Interval.Text = "На интервале от                                      до";
            // 
            // textBox_IntervalA
            // 
            this.textBox_IntervalA.Location = new System.Drawing.Point(93, 342);
            this.textBox_IntervalA.Name = "textBox_IntervalA";
            this.textBox_IntervalA.Size = new System.Drawing.Size(101, 20);
            this.textBox_IntervalA.TabIndex = 17;
            this.textBox_IntervalA.Text = "0";
            // 
            // textBox_IntervalB
            // 
            this.textBox_IntervalB.Location = new System.Drawing.Point(223, 342);
            this.textBox_IntervalB.Name = "textBox_IntervalB";
            this.textBox_IntervalB.Size = new System.Drawing.Size(101, 20);
            this.textBox_IntervalB.TabIndex = 18;
            this.textBox_IntervalB.Text = "5";
            // 
            // label_accuracy
            // 
            this.label_accuracy.AutoSize = true;
            this.label_accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_accuracy.Location = new System.Drawing.Point(380, 343);
            this.label_accuracy.Name = "label_accuracy";
            this.label_accuracy.Size = new System.Drawing.Size(79, 16);
            this.label_accuracy.TabIndex = 19;
            this.label_accuracy.Text = "точность:";
            // 
            // textBox_accuracy
            // 
            this.textBox_accuracy.Location = new System.Drawing.Point(465, 342);
            this.textBox_accuracy.Name = "textBox_accuracy";
            this.textBox_accuracy.Size = new System.Drawing.Size(100, 20);
            this.textBox_accuracy.TabIndex = 20;
            this.textBox_accuracy.Text = "0,0000001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(891, 373);
            this.Controls.Add(this.textBox_accuracy);
            this.Controls.Add(this.label_accuracy);
            this.Controls.Add(this.textBox_IntervalB);
            this.Controls.Add(this.textBox_IntervalA);
            this.Controls.Add(this.label_Interval);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.labelY0);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.primerLabel);
            this.Controls.Add(this.nameOftask_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Тоц Л. А. ИВТ-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem численныйМетодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмToolStripMenuItem;
        private System.Windows.Forms.Label nameOftask_label;
        private System.Windows.Forms.ToolStripMenuItem методПрямоугольниковЛевыхЧастейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методПрямоугольниковПравыхЧастейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методТрапецийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методПараболToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмСПостояннымШагомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сПеременнымШагомToolStripMenuItem;
        private System.Windows.Forms.Label primerLabel;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelY0;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.Label label_Interval;
        private System.Windows.Forms.TextBox textBox_IntervalA;
        private System.Windows.Forms.TextBox textBox_IntervalB;
        private System.Windows.Forms.ToolStripMenuItem методЭйлераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сФиксированнымШагомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методРунгеКуттыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разложениеВСтепенныеРядыМаклоренаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem многочисленныхПриближенийЧебышеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem итерацийToolStripMenuItem;
        private System.Windows.Forms.Label label_accuracy;
        private System.Windows.Forms.TextBox textBox_accuracy;
        private System.Windows.Forms.ToolStripMenuItem методНьютонакасательныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дихотомииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хордToolStripMenuItem;
    }
}

