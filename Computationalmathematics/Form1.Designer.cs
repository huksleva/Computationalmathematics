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
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмСПостояннымШагомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сПеременнымШагомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameOftask_label = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
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
            this.типЗадачиToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.типЗадачиToolStripMenuItem.Text = "Тип задачи";
            this.типЗадачиToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ТипЗадачиToolStripMenuItem_DropDownItemClicked);
            this.типЗадачиToolStripMenuItem.Click += new System.EventHandler(this.численноеИнтегрированиеToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(314, 26);
            this.ToolStripMenuItem1.Text = "Численное интегрирование";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.численноеИнтегрированиеToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(314, 26);
            this.ToolStripMenuItem2.Text = "Дифференциальные уравнения";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(314, 26);
            this.ToolStripMenuItem3.Text = "Нелинейные уравнения";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.нелинейныеФункцииToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(314, 26);
            this.ToolStripMenuItem4.Text = "Элементарные функции";
            // 
            // численныйМетодToolStripMenuItem
            // 
            this.численныйМетодToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem,
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem,
            this.методТрапецийToolStripMenuItem,
            this.методПараболToolStripMenuItem});
            this.численныйМетодToolStripMenuItem.Name = "численныйМетодToolStripMenuItem";
            this.численныйМетодToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.численныйМетодToolStripMenuItem.Text = "Численный метод";
            this.численныйМетодToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ЧисленныйМетодToolStripMenuItem_DropDownItemClicked);
            // 
            // методПрямоугольниковЛевыхЧастейToolStripMenuItem
            // 
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Name = "методПрямоугольниковЛевыхЧастейToolStripMenuItem";
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Text = "Метод прямоугольников левых частей";
            this.методПрямоугольниковЛевыхЧастейToolStripMenuItem.Click += new System.EventHandler(this.методПрямоугольниковЛевыхЧастейToolStripMenuItem_Click);
            // 
            // методПрямоугольниковПравыхЧастейToolStripMenuItem
            // 
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Name = "методПрямоугольниковПравыхЧастейToolStripMenuItem";
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.методПрямоугольниковПравыхЧастейToolStripMenuItem.Text = "Метод прямоугольников правых частей";
            // 
            // методТрапецийToolStripMenuItem
            // 
            this.методТрапецийToolStripMenuItem.Name = "методТрапецийToolStripMenuItem";
            this.методТрапецийToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.методТрапецийToolStripMenuItem.Text = "Метод трапеций";
            // 
            // методПараболToolStripMenuItem
            // 
            this.методПараболToolStripMenuItem.Name = "методПараболToolStripMenuItem";
            this.методПараболToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.методПараболToolStripMenuItem.Text = "Метод парабол";
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгоритмСПостояннымШагомToolStripMenuItem,
            this.сПеременнымШагомToolStripMenuItem});
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            this.алгоритмToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.АлгоритмToolStripMenuItem_DropDownItemClicked);
            // 
            // алгоритмСПостояннымШагомToolStripMenuItem
            // 
            this.алгоритмСПостояннымШагомToolStripMenuItem.Name = "алгоритмСПостояннымШагомToolStripMenuItem";
            this.алгоритмСПостояннымШагомToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.алгоритмСПостояннымШагомToolStripMenuItem.Text = "С постоянным шагом";
            // 
            // сПеременнымШагомToolStripMenuItem
            // 
            this.сПеременнымШагомToolStripMenuItem.Name = "сПеременнымШагомToolStripMenuItem";
            this.сПеременнымШагомToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.сПеременнымШагомToolStripMenuItem.Text = "С переменным шагом";
            // 
            // nameOftask_label
            // 
            this.nameOftask_label.AutoSize = true;
            this.nameOftask_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOftask_label.Location = new System.Drawing.Point(370, 30);
            this.nameOftask_label.Name = "nameOftask_label";
            this.nameOftask_label.Size = new System.Drawing.Size(268, 20);
            this.nameOftask_label.TabIndex = 4;
            this.nameOftask_label.Text = "Численное интегрирование";
            this.nameOftask_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 457);
            this.Controls.Add(this.nameOftask_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ЛР_1_ВМ. Численное интегрирование. Тоц Л. А., ИВТ-2.";
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
    }
}

