namespace Computationalmathematics
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.dataGridDIFF = new System.Windows.Forms.DataGridView();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridDIFF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridDIFF
			// 
			this.dataGridDIFF.AllowUserToAddRows = false;
			this.dataGridDIFF.AllowUserToDeleteRows = false;
			this.dataGridDIFF.AllowUserToResizeColumns = false;
			this.dataGridDIFF.AllowUserToResizeRows = false;
			this.dataGridDIFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridDIFF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridDIFF.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridDIFF.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridDIFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridDIFF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
			this.dataGridDIFF.GridColor = System.Drawing.SystemColors.WindowText;
			this.dataGridDIFF.Location = new System.Drawing.Point(0, 0);
			this.dataGridDIFF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridDIFF.Name = "dataGridDIFF";
			this.dataGridDIFF.ReadOnly = true;
			this.dataGridDIFF.RowHeadersWidth = 51;
			this.dataGridDIFF.Size = new System.Drawing.Size(465, 556);
			this.dataGridDIFF.TabIndex = 0;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(473, 0);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(595, 556);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// X
			// 
			this.X.HeaderText = "t";
			this.X.MinimumWidth = 6;
			this.X.Name = "X";
			this.X.ReadOnly = true;
			this.X.Width = 39;
			// 
			// Y
			// 
			this.Y.HeaderText = "T";
			this.Y.MinimumWidth = 6;
			this.Y.Name = "Y";
			this.Y.ReadOnly = true;
			this.Y.Width = 45;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.dataGridDIFF);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form2";
			this.Text = "table";
			((System.ComponentModel.ISupportInitialize)(this.dataGridDIFF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDIFF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}