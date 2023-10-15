namespace Test
{
    partial class EmissionChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmissionChangeForm));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ChangeValueText = new TextBox();
            ChangeLocationText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SubmitButton = new Button();
            ChangeSourceText = new ComboBox();
            ChangeUnitText = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-22, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(31, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Change selected Emission";
            // 
            // ChangeValueText
            // 
            ChangeValueText.Location = new Point(133, 147);
            ChangeValueText.Name = "ChangeValueText";
            ChangeValueText.Size = new Size(143, 27);
            ChangeValueText.TabIndex = 3;
            // 
            // ChangeLocationText
            // 
            ChangeLocationText.Location = new Point(133, 180);
            ChangeLocationText.Name = "ChangeLocationText";
            ChangeLocationText.Size = new Size(143, 27);
            ChangeLocationText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Source";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 147);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 2;
            label4.Text = "Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 180);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 2;
            label5.Text = "Location";
            // 
            // SubmitButton
            // 
            SubmitButton.Cursor = Cursors.Hand;
            SubmitButton.DialogResult = DialogResult.OK;
            SubmitButton.Location = new Point(109, 232);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ChangeSourceText
            // 
            ChangeSourceText.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeSourceText.FormattingEnabled = true;
            ChangeSourceText.Items.AddRange(new object[] { "Petrol", "Diesel oil", "CNG", "LPG", "Purchased heat", "Purchased electricity", "Biogas", "Biopetrol" });
            ChangeSourceText.Location = new Point(133, 80);
            ChangeSourceText.Name = "ChangeSourceText";
            ChangeSourceText.Size = new Size(143, 28);
            ChangeSourceText.TabIndex = 6;
            // 
            // ChangeUnitText
            // 
            ChangeUnitText.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeUnitText.FormattingEnabled = true;
            ChangeUnitText.Items.AddRange(new object[] { "kWh", "GJ", "m3", "l", "t" });
            ChangeUnitText.Location = new Point(133, 113);
            ChangeUnitText.Name = "ChangeUnitText";
            ChangeUnitText.Size = new Size(143, 28);
            ChangeUnitText.TabIndex = 7;
            // 
            // EmissionChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 285);
            Controls.Add(ChangeUnitText);
            Controls.Add(ChangeSourceText);
            Controls.Add(SubmitButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ChangeLocationText);
            Controls.Add(ChangeValueText);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "EmissionChangeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox ChangeValueText;
        private TextBox ChangeLocationText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SubmitButton;
        private ComboBox ChangeSourceText;
        private ComboBox ChangeUnitText;
        private PictureBox pictureBox4;
    }
}