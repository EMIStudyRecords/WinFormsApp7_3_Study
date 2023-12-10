namespace WinFormsApp7_3
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
            label1 = new Label();
            areaBox = new ComboBox();
            weatherIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)weatherIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 125);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "都道府県を選択";
            // 
            // areaBox
            // 
            areaBox.FormattingEnabled = true;
            areaBox.Location = new Point(90, 148);
            areaBox.Name = "areaBox";
            areaBox.Size = new Size(167, 28);
            areaBox.TabIndex = 1;
            areaBox.SelectedIndexChanged += CitySelected;
            // 
            // weatherIcon
            // 
            weatherIcon.Location = new Point(313, 148);
            weatherIcon.Name = "weatherIcon";
            weatherIcon.Size = new Size(209, 184);
            weatherIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            weatherIcon.TabIndex = 2;
            weatherIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 394);
            Controls.Add(weatherIcon);
            Controls.Add(areaBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)weatherIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox areaBox;
        private PictureBox weatherIcon;
    }
}