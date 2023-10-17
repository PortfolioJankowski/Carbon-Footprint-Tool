namespace Test
{
    partial class FactorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            FactorsGrid = new DataGridView();
            factorModelBindingSource = new BindingSource(components);
            CloseButton = new Button();
            sourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publicationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FactorsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)factorModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 72);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 28);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "Emission Factors";
            // 
            // FactorsGrid
            // 
            FactorsGrid.AllowUserToAddRows = false;
            FactorsGrid.AllowUserToDeleteRows = false;
            FactorsGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FactorsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FactorsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FactorsGrid.Columns.AddRange(new DataGridViewColumn[] { sourceDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, publicationDataGridViewTextBoxColumn });
            FactorsGrid.DataSource = factorModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            FactorsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            FactorsGrid.Location = new Point(21, 84);
            FactorsGrid.Name = "FactorsGrid";
            FactorsGrid.ReadOnly = true;
            FactorsGrid.RowHeadersWidth = 51;
            FactorsGrid.RowTemplate.Height = 29;
            FactorsGrid.Size = new Size(738, 278);
            FactorsGrid.TabIndex = 2;
            // 
            // factorModelBindingSource
            // 
            factorModelBindingSource.DataSource = typeof(Models.FactorModel);
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(356, 368);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            sourceDataGridViewTextBoxColumn.HeaderText = "Emission Source";
            sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            sourceDataGridViewTextBoxColumn.ReadOnly = true;
            sourceDataGridViewTextBoxColumn.Width = 175;
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
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            valueDataGridViewTextBoxColumn.ReadOnly = true;
            valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            publicationDataGridViewTextBoxColumn.DataPropertyName = "Publication";
            publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            publicationDataGridViewTextBoxColumn.MinimumWidth = 6;
            publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
            publicationDataGridViewTextBoxColumn.ReadOnly = true;
            publicationDataGridViewTextBoxColumn.Width = 125;
            // 
            // FactorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 407);
            Controls.Add(CloseButton);
            Controls.Add(FactorsGrid);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FactorsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Emission Factors";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FactorsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)factorModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView FactorsGrid;
        private Button CloseButton;
        private BindingSource factorModelBindingSource;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
    }
}