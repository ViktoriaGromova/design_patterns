
namespace WF
{

    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Generate_button = new Button();
            Save_button = new Button();
            HReflection_checkbox = new CheckBox();
            VReflection_checkbox = new CheckBox();
            panel1 = new Panel();
            SuspendLayout();

            // 
            // Generate_button
            // 
            Generate_button.Location = new Point(12, 12);
            Generate_button.Name = "Generate_button";
            Generate_button.Size = new Size(114, 33);
            Generate_button.TabIndex = 0;
            Generate_button.Text = "Generate Curves";
            Generate_button.UseVisualStyleBackColor = true;
            Generate_button.MouseEnter += Button_MouseEnter;
            Generate_button.MouseLeave += Button_MouseLeave;
            Generate_button.Click += Generate_button_Click;
            // 
            // Save_button
            // 
            void Button_MouseEnter(object sender, EventArgs e)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(255, 130, 0);
                    button.ForeColor = Color.FromArgb(255, 255, 255);// Изменение цвета при наведении мыши
                    button.FlatAppearance.BorderColor = Color.Black;
                    button.FlatAppearance.BorderSize = 2;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 0);
                }
            }

            void Button_MouseLeave(object sender, EventArgs e)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(230, 230, 230);
                    button.ForeColor = Color.FromArgb(0, 0, 0); // Возвращение исходного цвета при уходе мыши
                    button.FlatAppearance.BorderColor = Color.Black;
                    button.FlatAppearance.BorderSize = 2;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 0);
                }
            }


            Save_button.Location = new Point(132, 12);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(114, 33);
            Save_button.TabIndex = 1;
            Save_button.Text = "Save as SVG";
            //Save_button.BackColor = Color.FromArgb(255, 0, 0);
            Save_button.MouseEnter += Button_MouseEnter;
            Save_button.MouseLeave += Button_MouseLeave;
            Save_button.Click += Save_Button_Clicked;
            // 
            // panel1
            // 
            int x = (ClientSize.Width - panel1.Width) / 2;
            int y = (ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
            //panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 0;
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Paint += panel1_Paint;
            // 
            // HReflection_checkbox
            // 
            HReflection_checkbox.AutoSize = true;
            HReflection_checkbox.Location = new Point(270, 20);
            HReflection_checkbox.Name = "HReflection_checkbox";
            HReflection_checkbox.Size = new Size(129, 19);
            HReflection_checkbox.TabIndex = 2;
            HReflection_checkbox.Text = "Reflect Horizontally";
            HReflection_checkbox.UseVisualStyleBackColor = true;
            HReflection_checkbox.CheckedChanged += HReflection_checkbox_CheckedChanged;
            // 
            // VReflection_checkbox
            // 
            VReflection_checkbox.AutoSize = true;
            VReflection_checkbox.Location = new Point(420, 20);
            VReflection_checkbox.Name = "VReflection_checkbox";
            VReflection_checkbox.Size = new Size(112, 19);
            VReflection_checkbox.TabIndex = 3;
            VReflection_checkbox.Text = "Reflect Vertically";
            VReflection_checkbox.UseVisualStyleBackColor = true;
            VReflection_checkbox.CheckedChanged += VReflection_checkbox_CheckedChanged;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 807);
            Controls.Add(VReflection_checkbox);
            Controls.Add(HReflection_checkbox);
            Controls.Add(Save_button);
            Controls.Add(Generate_button);
            Controls.Add(panel1);
            Name = "Drawing curves";
            Text = "Drawing curves";
            ResumeLayout(false);
            PerformLayout();
        }
        //  #endregion

        private Button Generate_button;
        private Button Save_button;
        private CheckBox HReflection_checkbox;
        private CheckBox VReflection_checkbox;
        private Panel panel1;
    }
}