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
            CalculationsGrid = new DataGridView();
            emissionsSourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissionsValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calculationModelBindingSource = new BindingSource(components);
            CloseButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CalculationsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calculationModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // CalculationsGrid
            // 
            CalculationsGrid.AllowUserToAddRows = false;
            CalculationsGrid.AllowUserToDeleteRows = false;
            CalculationsGrid.AutoGenerateColumns = false;
            CalculationsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CalculationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CalculationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CalculationsGrid.Columns.AddRange(new DataGridViewColumn[] { emissionsSourceDataGridViewTextBoxColumn, emissionsValueDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, resultDataGridViewTextBoxColumn });
            CalculationsGrid.DataSource = calculationModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CalculationsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            CalculationsGrid.Location = new Point(39, 77);
            CalculationsGrid.Name = "CalculationsGrid";
            CalculationsGrid.ReadOnly = true;
            CalculationsGrid.RowHeadersWidth = 51;
            CalculationsGrid.RowTemplate.Height = 29;
            CalculationsGrid.Size = new Size(580, 198);
            CalculationsGrid.TabIndex = 0;
            // 
            // emissionsSourceDataGridViewTextBoxColumn
            // 
            emissionsSourceDataGridViewTextBoxColumn.DataPropertyName = "EmissionsSource";
            emissionsSourceDataGridViewTextBoxColumn.HeaderText = "EmissionsSource";
            emissionsSourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            emissionsSourceDataGridViewTextBoxColumn.Name = "emissionsSourceDataGridViewTextBoxColumn";
            emissionsSourceDataGridViewTextBoxColumn.ReadOnly = true;
            emissionsSourceDataGridViewTextBoxColumn.Width = 150;
            // 
            // emissionsValueDataGridViewTextBoxColumn
            // 
            emissionsValueDataGridViewTextBoxColumn.DataPropertyName = "EmissionsValue";
            emissionsValueDataGridViewTextBoxColumn.HeaderText = "EmissionsValue";
            emissionsValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            emissionsValueDataGridViewTextBoxColumn.Name = "emissionsValueDataGridViewTextBoxColumn";
            emissionsValueDataGridViewTextBoxColumn.ReadOnly = true;
            emissionsValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 125;
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
            // calculationModelBindingSource
            // 
            calculationModelBindingSource.DataSource = typeof(Models.CalculationModel);
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(462, 476);
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
            pictureBox2.Location = new Point(26, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(650, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // CalculationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 555);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(CloseButton);
            Controls.Add(CalculationsGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculationsForm";
            Text = "ha";
            ((System.ComponentModel.ISupportInitialize)CalculationsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)calculationModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private BindingSource calculationModelBindingSource;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}