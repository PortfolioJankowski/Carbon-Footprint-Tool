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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            pieChartDataModelBindingSource = new BindingSource(components);
            SourceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lineChartDataModelBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)CalculationsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculationModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LocationChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieChartDataModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SourceChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineChartDataModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CalculationsGrid
            // 
            CalculationsGrid.AllowUserToAddRows = false;
            CalculationsGrid.AllowUserToDeleteRows = false;
            CalculationsGrid.AutoGenerateColumns = false;
            CalculationsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            CalculationsGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CalculationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CalculationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CalculationsGrid.Columns.AddRange(new DataGridViewColumn[] { sourceDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, resultDataGridViewTextBoxColumn, Location });
            CalculationsGrid.DataSource = calculationModelBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            CalculationsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            CalculationsGrid.EnableHeadersVisualStyles = false;
            CalculationsGrid.GridColor = Color.White;
            CalculationsGrid.Location = new Point(27, 83);
            CalculationsGrid.MultiSelect = false;
            CalculationsGrid.Name = "CalculationsGrid";
            CalculationsGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CalculationsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CalculationsGrid.RowHeadersWidth = 25;
            CalculationsGrid.RowTemplate.Height = 29;
            CalculationsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CalculationsGrid.Size = new Size(549, 157);
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
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(481, 427);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
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
            pictureBox2.Location = new Point(11, 67);
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
            label2.Location = new Point(123, 14);
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
            TotalLabel.Location = new Point(133, 34);
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
            panel2.Location = new Point(582, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 133);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(173, 88);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "t CO2e";
            // 
            // LocationChart
            // 
            LocationChart.BackColor = SystemColors.Control;
            LocationChart.BackgroundImageLayout = ImageLayout.Center;
            LocationChart.BorderlineColor = Color.Black;
            LocationChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            LocationChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            LocationChart.Legends.Add(legend3);
            LocationChart.Location = new Point(582, 222);
            LocationChart.Name = "LocationChart";
            LocationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "Location";
            series3.YValueMembers = "TotalResult";
            LocationChart.Series.Add(series3);
            LocationChart.Size = new Size(342, 199);
            LocationChart.TabIndex = 9;
            LocationChart.Text = "chart1";
            // 
            // pieChartDataModelBindingSource
            // 
            pieChartDataModelBindingSource.DataSource = typeof(Models.PieChartDataModel);
            // 
            // SourceChart
            // 
            SourceChart.BorderlineColor = Color.Black;
            SourceChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            SourceChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            SourceChart.Legends.Add(legend4);
            SourceChart.Location = new Point(26, 246);
            SourceChart.Name = "SourceChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "Source";
            series4.YValueMembers = "TotalResult";
            SourceChart.Series.Add(series4);
            SourceChart.Size = new Size(549, 175);
            SourceChart.TabIndex = 10;
            SourceChart.Text = "chart1";
            // 
            // lineChartDataModelBindingSource
            // 
            lineChartDataModelBindingSource.DataSource = typeof(Models.LineChartDataModel);
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(830, 427);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CalculationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 468);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)pieChartDataModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SourceChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineChartDataModelBindingSource).EndInit();
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
        private BindingSource lineChartDataModelBindingSource;
        private BindingSource pieChartDataModelBindingSource;
        private Button button1;
    }
}