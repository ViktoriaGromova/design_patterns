
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
            Clear_button = new Button();
            HReflection_checkbox = new CheckBox();
            VReflection_checkbox = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 750);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(700, 893);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Continiuous";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(800, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dotted";
            tabPage2.UseVisualStyleBackColor = true;
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
            // Clear_button
            // 
            Clear_button.Location = new Point(550, 12);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(114, 33);
            Clear_button.TabIndex = 1;
            Clear_button.Text = "Clear Screen";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.MouseEnter += Button_MouseEnter;
            Clear_button.MouseLeave += Button_MouseLeave;
            Clear_button.Click += Clear_button_Click;
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
            Save_button.MouseEnter += Button_MouseEnter;
            Save_button.MouseLeave += Button_MouseLeave;
            Save_button.Click += Save_Button_Clicked;
            // 
            // panel1
            // 
            // int x = (ClientSize.Width - panel1.Width) / 2;
            // int y = (ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 600);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            Controls.Add(tabControl1);
            Controls.Add(VReflection_checkbox);
            Controls.Add(HReflection_checkbox);
            Controls.Add(Save_button);
            Controls.Add(Clear_button);
            Controls.Add(Generate_button);
            Name = "Drawing curves";
            Text = "Drawing curves";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        //  #endregion

        private Button Generate_button;
        private Button Save_button;
        private Button Clear_button;
        private CheckBox HReflection_checkbox;
        private CheckBox VReflection_checkbox;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
    }
}