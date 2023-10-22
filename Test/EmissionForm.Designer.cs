namespace Test
{
    partial class EmissionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmissionForm));
            ValueText = new TextBox();
            LocationText = new TextBox();
            AddButton = new Button();
            EmissionsGrid = new DataGridView();
            sourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissionModelBindingSource = new BindingSource(components);
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            SourceLabel = new Label();
            UnitLabel = new Label();
            ValueLabel = new Label();
            LocationLabel = new Label();
            DeleteButton = new Button();
            ImportButton = new Button();
            ChangeButton = new Button();
            pictureBox1 = new PictureBox();
            CalculationsButton = new Button();
            FactorsButton = new Button();
            SourceText = new ComboBox();
            UnitText = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            instructionToolStripMenuItem = new ToolStripMenuItem();
            fileManualToolStripMenuItem = new ToolStripMenuItem();
            methodologyToolStripMenuItem = new ToolStripMenuItem();
            aboutAuthorToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)EmissionsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emissionModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ValueText
            // 
            ValueText.Location = new Point(12, 277);
            ValueText.Name = "ValueText";
            ValueText.Size = new Size(125, 27);
            ValueText.TabIndex = 3;
            // 
            // LocationText
            // 
            LocationText.Location = new Point(12, 348);
            LocationText.Name = "LocationText";
            LocationText.Size = new Size(125, 27);
            LocationText.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.ImageAlign = ContentAlignment.TopRight;
            AddButton.Location = new Point(29, 394);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EmissionsGrid
            // 
            EmissionsGrid.AllowUserToAddRows = false;
            EmissionsGrid.AllowUserToDeleteRows = false;
            EmissionsGrid.AllowUserToResizeColumns = false;
            EmissionsGrid.AllowUserToResizeRows = false;
            EmissionsGrid.AutoGenerateColumns = false;
            EmissionsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmissionsGrid.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmissionsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmissionsGrid.ColumnHeadersHeight = 40;
            EmissionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmissionsGrid.Columns.AddRange(new DataGridViewColumn[] { sourceDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            EmissionsGrid.Cursor = Cursors.Hand;
            EmissionsGrid.DataSource = emissionModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EmissionsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            EmissionsGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            EmissionsGrid.EnableHeadersVisualStyles = false;
            EmissionsGrid.GridColor = Color.White;
            EmissionsGrid.Location = new Point(163, 107);
            EmissionsGrid.MultiSelect = false;
            EmissionsGrid.Name = "EmissionsGrid";
            EmissionsGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            EmissionsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            EmissionsGrid.RowHeadersWidth = 10;
            EmissionsGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            EmissionsGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            EmissionsGrid.RowTemplate.Height = 29;
            EmissionsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmissionsGrid.ShowCellErrors = false;
            EmissionsGrid.Size = new Size(635, 347);
            EmissionsGrid.TabIndex = 6;
            EmissionsGrid.SelectionChanged += EmissionsGrid_SelectionChanged;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            dataGridViewCellStyle2.BackColor = Color.White;
            sourceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emissionModelBindingSource
            // 
            emissionModelBindingSource.DataSource = typeof(Models.EmissionModel);
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // SourceLabel
            // 
            SourceLabel.AutoSize = true;
            SourceLabel.ForeColor = Color.Black;
            SourceLabel.Location = new Point(12, 119);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(54, 20);
            SourceLabel.TabIndex = 3;
            SourceLabel.Text = "Source";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.ForeColor = Color.Black;
            UnitLabel.Location = new Point(12, 188);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(36, 20);
            UnitLabel.TabIndex = 3;
            UnitLabel.Text = "Unit";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.ForeColor = Color.Black;
            ValueLabel.Location = new Point(18, 254);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(45, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Value";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.ForeColor = Color.Black;
            LocationLabel.Location = new Point(12, 326);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(66, 20);
            LocationLabel.TabIndex = 3;
            LocationLabel.Text = "Location";
            // 
            // DeleteButton
            // 
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Enabled = false;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(818, 266);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(101, 59);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete record";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ImportButton
            // 
            ImportButton.Cursor = Cursors.Hand;
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.Location = new Point(818, 111);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(101, 64);
            ImportButton.TabIndex = 8;
            ImportButton.Text = "Import Excel Files";
            ImportButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            ChangeButton.Cursor = Cursors.Hand;
            ChangeButton.Enabled = false;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Location = new Point(818, 193);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(101, 59);
            ChangeButton.TabIndex = 9;
            ChangeButton.Text = "Change Record";
            ChangeButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(804, 344);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CalculationsButton
            // 
            CalculationsButton.BackColor = Color.White;
            CalculationsButton.Cursor = Cursors.Hand;
            CalculationsButton.FlatStyle = FlatStyle.Flat;
            CalculationsButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CalculationsButton.ImageAlign = ContentAlignment.MiddleLeft;
            CalculationsButton.Location = new Point(800, 17);
            CalculationsButton.Name = "CalculationsButton";
            CalculationsButton.Size = new Size(132, 47);
            CalculationsButton.TabIndex = 7;
            CalculationsButton.Text = "Calculations ";
            CalculationsButton.UseVisualStyleBackColor = false;
            // 
            // FactorsButton
            // 
            FactorsButton.BackColor = Color.White;
            FactorsButton.Cursor = Cursors.Hand;
            FactorsButton.FlatStyle = FlatStyle.Flat;
            FactorsButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            FactorsButton.ImageAlign = ContentAlignment.MiddleLeft;
            FactorsButton.Location = new Point(659, 18);
            FactorsButton.Name = "FactorsButton";
            FactorsButton.Size = new Size(135, 47);
            FactorsButton.TabIndex = 7;
            FactorsButton.Text = "Factors ";
            FactorsButton.UseVisualStyleBackColor = false;
            // 
            // SourceText
            // 
            SourceText.DropDownStyle = ComboBoxStyle.DropDownList;
            SourceText.FormattingEnabled = true;
            SourceText.Items.AddRange(new object[] { "Butane", "CNG", "LPG", "Petrol", "Electricity" });
            SourceText.Location = new Point(12, 142);
            SourceText.Name = "SourceText";
            SourceText.Size = new Size(125, 28);
            SourceText.TabIndex = 11;
            // 
            // UnitText
            // 
            UnitText.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitText.FormattingEnabled = true;
            UnitText.Items.AddRange(new object[] { "l", "t", "kWh" });
            UnitText.Location = new Point(12, 211);
            UnitText.Name = "UnitText";
            UnitText.Size = new Size(125, 28);
            UnitText.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(FactorsButton);
            panel1.Controls.Add(CalculationsButton);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 68);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(78, 18);
            label1.Name = "label1";
            label1.Size = new Size(430, 38);
            label1.TabIndex = 10;
            label1.Text = "Calculate your carbon footprint";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(936, 30);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { instructionToolStripMenuItem, aboutAuthorToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = Color.White;
            optionsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // instructionToolStripMenuItem
            // 
            instructionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileManualToolStripMenuItem, methodologyToolStripMenuItem });
            instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            instructionToolStripMenuItem.Size = new Size(180, 26);
            instructionToolStripMenuItem.Text = "Instruction";
            // 
            // fileManualToolStripMenuItem
            // 
            fileManualToolStripMenuItem.Name = "fileManualToolStripMenuItem";
            fileManualToolStripMenuItem.Size = new Size(182, 26);
            fileManualToolStripMenuItem.Text = "File manual";
            // 
            // methodologyToolStripMenuItem
            // 
            methodologyToolStripMenuItem.Name = "methodologyToolStripMenuItem";
            methodologyToolStripMenuItem.Size = new Size(182, 26);
            methodologyToolStripMenuItem.Text = "Methodology";
            methodologyToolStripMenuItem.Click += methodologyToolStripMenuItem_Click;
            // 
            // aboutAuthorToolStripMenuItem
            // 
            aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            aboutAuthorToolStripMenuItem.Size = new Size(180, 26);
            aboutAuthorToolStripMenuItem.Text = "About author";
            aboutAuthorToolStripMenuItem.Click += aboutAuthorToolStripMenuItem_Click;
            // 
            // EmissionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 468);
            Controls.Add(UnitText);
            Controls.Add(SourceText);
            Controls.Add(ImportButton);
            Controls.Add(pictureBox1);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(LocationLabel);
            Controls.Add(ValueLabel);
            Controls.Add(UnitLabel);
            Controls.Add(SourceLabel);
            Controls.Add(EmissionsGrid);
            Controls.Add(AddButton);
            Controls.Add(LocationText);
            Controls.Add(ValueText);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "EmissionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carbon Footprint Tool";
            ((System.ComponentModel.ISupportInitialize)EmissionsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)emissionModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ValueText;
        private TextBox LocationText;
        private Button AddButton;
        private DataGridView EmissionsGrid;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label SourceLabel;
        private Label UnitLabel;
        private Label ValueLabel;
        private Label LocationLabel;
        private Button DeleteButton;
        private Button ImportButton;
        private Button ChangeButton;
        private PictureBox pictureBox1;
        private Button CalculationsButton;
        private Button FactorsButton;
        private ComboBox SourceText;
        private ComboBox UnitText;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem instructionToolStripMenuItem;
        private ToolStripMenuItem fileManualToolStripMenuItem;
        private ToolStripMenuItem methodologyToolStripMenuItem;
        private ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private PictureBox pictureBox4;
        private Label label1;
        private BindingSource emissionModelBindingSource;
        private DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}