namespace Test
{
    partial class CalculationsForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            CalculationsGrid = new DataGridView();
            sourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            calculationModelBindingSource = new BindingSource(components);
            CloseButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            TotalLabel = new Label();
            panel2 = new Panel();
            label3 = new Label();
            LocationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            SourceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)CalculationsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculationModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LocationChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SourceChart).BeginInit();
            SuspendLayout();
            // 
            // CalculationsGrid
            // 
            CalculationsGrid.AllowUserToAddRows = false;
            CalculationsGrid.AllowUserToDeleteRows = false;
            CalculationsGrid.AutoGenerateColumns = false;
            CalculationsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            CalculationsGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CalculationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CalculationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CalculationsGrid.Columns.AddRange(new DataGridViewColumn[] { sourceDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, resultDataGridViewTextBoxColumn, Location });
            CalculationsGrid.DataSource = calculationModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CalculationsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            CalculationsGrid.Location = new Point(27, 82);
            CalculationsGrid.Name = "CalculationsGrid";
            CalculationsGrid.ReadOnly = true;
            CalculationsGrid.RowHeadersWidth = 51;
            CalculationsGrid.RowTemplate.Height = 29;
            CalculationsGrid.Size = new Size(554, 158);
            CalculationsGrid.TabIndex = 0;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            sourceDataGridViewTextBoxColumn.ReadOnly = true;
            sourceDataGridViewTextBoxColumn.Width = 75;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 50;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            valueDataGridViewTextBoxColumn.ReadOnly = true;
            valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            resultDataGridViewTextBoxColumn.HeaderText = "Result";
            resultDataGridViewTextBoxColumn.MinimumWidth = 6;
            resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            resultDataGridViewTextBoxColumn.ReadOnly = true;
            resultDataGridViewTextBoxColumn.Width = 125;
            // 
            // Location
            // 
            Location.DataPropertyName = "Location";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Width = 125;
            // 
            // calculationModelBindingSource
            // 
            calculationModelBindingSource.DataSource = typeof(Models.CalculationModel);
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(401, 395);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-139, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 73);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 33);
            label1.Name = "label1";
            label1.Size = new Size(299, 25);
            label1.TabIndex = 0;
            label1.Text = "Calculations and Data visualisation";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 16);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 5;
            label2.Text = "Total Carbon Footprint";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.ForeColor = Color.Red;
            TotalLabel.Location = new Point(101, 47);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(141, 54);
            TotalLabel.TabIndex = 6;
            TotalLabel.Text = "label3";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(TotalLabel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(587, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 133);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "t CO2e";
            // 
            // LocationChart
            // 
            LocationChart.BackColor = SystemColors.Control;
            LocationChart.BackgroundImageLayout = ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            LocationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            LocationChart.Legends.Add(legend1);
            LocationChart.Location = new Point(587, 221);
            LocationChart.Name = "LocationChart";
            LocationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            LocationChart.Series.Add(series1);
            LocationChart.Size = new Size(311, 203);
            LocationChart.TabIndex = 9;
            LocationChart.Text = "chart1";
            // 
            // SourceChart
            // 
            chartArea2.Name = "ChartArea1";
            SourceChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            SourceChart.Legends.Add(legend2);
            SourceChart.Location = new Point(27, 246);
            SourceChart.Name = "SourceChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            SourceChart.Series.Add(series2);
            SourceChart.Size = new Size(539, 155);
            SourceChart.TabIndex = 10;
            SourceChart.Text = "chart1";
            // 
            // CalculationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(903, 428);
            Controls.Add(CloseButton);
            Controls.Add(SourceChart);
            Controls.Add(LocationChart);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(CalculationsGrid);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)CalculationsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculationModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LocationChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)SourceChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CalculationsGrid;
        private Button CloseButton;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn emissionsSourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emissionsValueDataGridViewTextBoxColumn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label label2;
        private Label TotalLabel;
        private Panel panel2;
        private Label label3;
        private BindingSource calculationModelBindingSource;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataVisualization.Charting.Chart LocationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SourceChart;
    }
}