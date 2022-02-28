
namespace _24._02._22
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.StyleBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(23, 148);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(66, 17);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleText.Location = new System.Drawing.Point(57, 191);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(218, 48);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "25",
            "26",
            "28",
            "30",
            "32"});
            this.FontBox.Location = new System.Drawing.Point(12, 46);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(136, 24);
            this.FontBox.TabIndex = 3;
            this.FontBox.Text = "Размер шрифта";
            this.FontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // StyleBox
            // 
            this.StyleBox.FormattingEnabled = true;
            this.StyleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив ",
            "полужирный ",
            "линия по середине",
            "подчеркивание"});
            this.StyleBox.Location = new System.Drawing.Point(173, 46);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(121, 24);
            this.StyleBox.TabIndex = 4;
            this.StyleBox.Text = "Шрифт";
            this.StyleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StyleBox);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.ComboBox StyleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}