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
            SourceText = new TextBox();
            UnitText = new TextBox();
            ValueText = new TextBox();
            LocationText = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // SourceText
            // 
            SourceText.Location = new Point(26, 35);
            SourceText.Name = "SourceText";
            SourceText.Size = new Size(125, 27);
            SourceText.TabIndex = 0;
            // 
            // UnitText
            // 
            UnitText.Location = new Point(26, 83);
            UnitText.Name = "UnitText";
            UnitText.Size = new Size(125, 27);
            UnitText.TabIndex = 0;
            // 
            // ValueText
            // 
            ValueText.Location = new Point(26, 132);
            ValueText.Name = "ValueText";
            ValueText.Size = new Size(125, 27);
            ValueText.TabIndex = 0;
            // 
            // LocationText
            // 
            LocationText.Location = new Point(26, 180);
            LocationText.Name = "LocationText";
            LocationText.Size = new Size(125, 27);
            LocationText.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.ImageAlign = ContentAlignment.TopRight;
            AddButton.Location = new Point(40, 225);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(LocationText);
            Controls.Add(ValueText);
            Controls.Add(UnitText);
            Controls.Add(SourceText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceText;
        private TextBox UnitText;
        private TextBox ValueText;
        private TextBox LocationText;
        private Button AddButton;
    }
}