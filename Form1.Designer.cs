
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            // this.tabPage1 = new  System.Windows.Forms.TabPage();
            // this.button1 = new System.Windows.Forms.Button();
            // this.button2 = new System.Windows.Forms.Button();
            // this.panel1 = new System.Windows.Forms.Panel();
            // this.panel2 = new System.Windows.Forms.Panel();
            // this.button3 = new System.Windows.Forms.Button();
            Generate_button = new Button();
            Save_button = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            //checkBox1 = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            Generate_button.Click += Main_Form_Generate_Button_Clicked;
            // 
            // Save_button
            // 
            Save_button.Location = new Point(132, 12);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(114, 33);
            Save_button.TabIndex = 1;
            Save_button.Text = "Save as SVG";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_Button_Clicked;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1043, 596);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1035, 568);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 562);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1035, 568);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(6, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 562);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // checkBox1
            // 
            // checkBox1.AutoSize = true;
            // checkBox1.Location = new Point(270, 20);
            // checkBox1.Name = "checkBox1";
            // checkBox1.Size = new Size(83, 19);
            // checkBox1.TabIndex = 3;
            // checkBox1.Text = "checkBox1";
            // checkBox1.UseVisualStyleBackColor = true;
            // checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 697);
           // Controls.Add(checkBox1);
            Controls.Add(tabControl1);
            Controls.Add(Save_button);
            Controls.Add(Generate_button);
            Name = "Main_Form";
            Text = "Main_Form";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();



            //this.SuspendLayout();


            // 
            // button1
            // 
        //     this.button1.Location = new System.Drawing.Point(893, 589);
        //     this.button1.Name = "button1";
        //     this.button1.Size = new System.Drawing.Size(112, 55);
        //     this.button1.TabIndex = 0;
        //     this.button1.Text = "continuous";
        //     this.button1.UseVisualStyleBackColor = true;
        //     this.button1.Click += new System.EventHandler(this.button1_Click_1);
        //     // 
        //     // button2
        //     // 
        //     this.button2.Location = new System.Drawing.Point(189, 589);
        //     this.button2.Name = "button2";
        //     this.button2.Size = new System.Drawing.Size(112, 55);
        //     this.button2.TabIndex = 1;
        //     this.button2.Text = "dotted";
        //     this.button2.UseVisualStyleBackColor = true;
        //     this.button2.Click += new System.EventHandler(this.button2_Click_1);
        //     // 
        //     // panel1
            
        //     this.panel1.Location = new System.Drawing.Point(27, 29);
        //     this.panel1.Name = "panel1";
        //     this.panel1.Size = new System.Drawing.Size(519, 533);
        //     this.panel1.TabIndex = 2;

        //     // tabPage1.Controls.Add(panel1);
        //     // tabPage1.Location = new Point(4, 24);
        //     // tabPage1.Name = "tabPage1";
        //     // tabPage1.Padding = new Padding(3);
        //     // tabPage1.Size = new Size(1035, 568);
        //     // tabPage1.TabIndex = 0;
        //     // tabPage1.Text = "tabPage1";
        //     // tabPage1.UseVisualStyleBackColor = true;



        //     panel1.Location = new Point(27, 29);
        //     panel1.Name = "panel1";
        //     panel1.Size = new Size(519, 533);
        //     panel1.TabIndex = 2;
        //     //panel1.Paint += new PaintEventHandler(panel1_Paint);
        //     // 
        //     // panel2
        //     // 
        //     this.panel2.Location = new System.Drawing.Point(645, 29);
        //     this.panel2.Name = "panel2";
        //     this.panel2.Size = new System.Drawing.Size(519, 533);
        //     this.panel2.TabIndex = 3;
        //     // 
        //     // button3
        //     // 
        //     this.button3.Location = new System.Drawing.Point(538, 693);
        //     this.button3.Name = "button3";
        //     this.button3.Size = new System.Drawing.Size(112, 55);
        //     this.button3.TabIndex = 4;
        //     this.button3.Text = "save";
        //     this.button3.UseVisualStyleBackColor = true;
        //     this.button3.Click += new System.EventHandler(this.button3_Click);
        //     // 
        //     // Form1
        //     // 
        //     this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        //     this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //     this.ClientSize = new System.Drawing.Size(1216, 774);
        //     this.Controls.Add(this.button3);
        //     this.Controls.Add(this.panel2);
        //     this.Controls.Add(this.panel1);
        //     this.Controls.Add(this.button2);
        //     this.Controls.Add(this.button1);
        //     this.Name = "Form1";
        //     this.Text = "Form1";
        //     this.Load += new System.EventHandler(this.Form1_Load);
        //     this.ResumeLayout(false);

        }


        #endregion

        // private System.Windows.Forms.Button button1;
        // private System.Windows.Forms.Button button2;
        // private System.Windows.Forms.Panel panel1;
        // private System.Windows.Forms.Panel panel2;

        // private TabPage tabPage1;
        // private System.Windows.Forms.Button button3;
        private Button Generate_button;
        private Button Save_button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TabPage tabPage2;
        private Panel panel2;
        //private CheckBox checkBox1;
    }
}