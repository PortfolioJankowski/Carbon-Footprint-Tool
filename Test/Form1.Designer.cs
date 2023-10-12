namespace Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SourceText = new TextBox();
            UnitText = new TextBox();
            ValueText = new TextBox();
            LocationText = new TextBox();
            AddButton = new Button();
            EmissionsGrid = new DataGridView();
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
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmissionsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SourceText
            // 
            SourceText.Location = new Point(26, 139);
            SourceText.Name = "SourceText";
            SourceText.Size = new Size(125, 27);
            SourceText.TabIndex = 1;
            // 
            // UnitText
            // 
            UnitText.Location = new Point(26, 201);
            UnitText.Name = "UnitText";
            UnitText.Size = new Size(125, 27);
            UnitText.TabIndex = 2;
            // 
            // ValueText
            // 
            ValueText.Location = new Point(26, 269);
            ValueText.Name = "ValueText";
            ValueText.Size = new Size(125, 27);
            ValueText.TabIndex = 3;
            // 
            // LocationText
            // 
            LocationText.Location = new Point(26, 327);
            LocationText.Name = "LocationText";
            LocationText.Size = new Size(125, 27);
            LocationText.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.ImageAlign = ContentAlignment.TopRight;
            AddButton.Location = new Point(44, 369);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EmissionsGrid
            // 
            EmissionsGrid.BackgroundColor = SystemColors.ActiveCaption;
            EmissionsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmissionsGrid.GridColor = SystemColors.ActiveCaptionText;
            EmissionsGrid.Location = new Point(181, 110);
            EmissionsGrid.Name = "EmissionsGrid";
            EmissionsGrid.RowHeadersWidth = 51;
            EmissionsGrid.RowTemplate.Height = 29;
            EmissionsGrid.Size = new Size(554, 299);
            EmissionsGrid.TabIndex = 2;
            EmissionsGrid.SelectionChanged += EmissionsGrid_SelectionChanged;
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
            SourceLabel.Location = new Point(22, 116);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(54, 20);
            SourceLabel.TabIndex = 3;
            SourceLabel.Text = "Source";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.ForeColor = Color.Black;
            UnitLabel.Location = new Point(26, 178);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(36, 20);
            UnitLabel.TabIndex = 3;
            UnitLabel.Text = "Unit";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.ForeColor = Color.Black;
            ValueLabel.Location = new Point(26, 246);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(45, 20);
            ValueLabel.TabIndex = 3;
            ValueLabel.Text = "Value";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.ForeColor = Color.Black;
            LocationLabel.Location = new Point(26, 304);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(66, 20);
            LocationLabel.TabIndex = 3;
            LocationLabel.Text = "Location";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(756, 253);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 59);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete record";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(756, 116);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(94, 59);
            ImportButton.TabIndex = 4;
            ImportButton.Text = "Import Excel Files";
            ImportButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            ChangeButton.Enabled = false;
            ChangeButton.Location = new Point(756, 185);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 59);
            ChangeButton.TabIndex = 4;
            ChangeButton.Text = "Change Record";
            ChangeButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(756, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CalculationsButton
            // 
            CalculationsButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CalculationsButton.Location = new Point(703, 13);
            CalculationsButton.Name = "CalculationsButton";
            CalculationsButton.Size = new Size(171, 62);
            CalculationsButton.TabIndex = 7;
            CalculationsButton.Text = "Calculations  ";
            CalculationsButton.TextAlign = ContentAlignment.MiddleRight;
            CalculationsButton.UseVisualStyleBackColor = true;
            // 
            // FactorsButton
            // 
            FactorsButton.BackColor = Color.FromArgb(224, 224, 224);
            FactorsButton.FlatStyle = FlatStyle.Popup;
            FactorsButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            FactorsButton.Location = new Point(536, 13);
            FactorsButton.Name = "FactorsButton";
            FactorsButton.Size = new Size(146, 62);
            FactorsButton.TabIndex = 7;
            FactorsButton.Text = "Factors  ";
            FactorsButton.TextAlign = ContentAlignment.MiddleRight;
            FactorsButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(FactorsButton);
            panel1.Controls.Add(CalculationsButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-17, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 86);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(552, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(720, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(358, 31);
            label1.TabIndex = 3;
            label1.Text = "Calculate Your Carbon Footprint";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(869, 431);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(ImportButton);
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
            Controls.Add(UnitText);
            Controls.Add(SourceText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carbon Footprint Tool";
            ((System.ComponentModel.ISupportInitialize)EmissionsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceText;
        private TextBox UnitText;
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
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}