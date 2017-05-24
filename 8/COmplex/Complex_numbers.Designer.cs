namespace COmplex
{
    partial class Complex_numbers
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSloz = new System.Windows.Forms.Button();
            this.buttonWyz = new System.Windows.Forms.Button();
            this.buttonUmn = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxRe_1 = new System.Windows.Forms.TextBox();
            this.textBoxIm_1 = new System.Windows.Forms.TextBox();
            this.textBoxRe_2 = new System.Windows.Forms.TextBox();
            this.textBoxIm_2 = new System.Windows.Forms.TextBox();
            this.textBoxRes_Re = new System.Windows.Forms.TextBox();
            this.textBoxRes_Im = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonPow = new System.Windows.Forms.Button();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonClearPanel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDrawMandelbrot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSloz
            // 
            this.buttonSloz.Location = new System.Drawing.Point(6, 213);
            this.buttonSloz.Name = "buttonSloz";
            this.buttonSloz.Size = new System.Drawing.Size(93, 36);
            this.buttonSloz.TabIndex = 0;
            this.buttonSloz.Text = "Сложение";
            this.buttonSloz.UseVisualStyleBackColor = true;
            this.buttonSloz.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWyz
            // 
            this.buttonWyz.Location = new System.Drawing.Point(110, 213);
            this.buttonWyz.Name = "buttonWyz";
            this.buttonWyz.Size = new System.Drawing.Size(109, 36);
            this.buttonWyz.TabIndex = 1;
            this.buttonWyz.Text = "Вычитание";
            this.buttonWyz.UseVisualStyleBackColor = true;
            this.buttonWyz.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUmn
            // 
            this.buttonUmn.Location = new System.Drawing.Point(247, 213);
            this.buttonUmn.Name = "buttonUmn";
            this.buttonUmn.Size = new System.Drawing.Size(114, 36);
            this.buttonUmn.TabIndex = 2;
            this.buttonUmn.Text = "Умножение";
            this.buttonUmn.UseVisualStyleBackColor = true;
            this.buttonUmn.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(381, 213);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(115, 36);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Деление";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxRe_1
            // 
            this.textBoxRe_1.Location = new System.Drawing.Point(29, 33);
            this.textBoxRe_1.Name = "textBoxRe_1";
            this.textBoxRe_1.Size = new System.Drawing.Size(132, 22);
            this.textBoxRe_1.TabIndex = 4;
            // 
            // textBoxIm_1
            // 
            this.textBoxIm_1.Location = new System.Drawing.Point(30, 76);
            this.textBoxIm_1.Name = "textBoxIm_1";
            this.textBoxIm_1.Size = new System.Drawing.Size(130, 22);
            this.textBoxIm_1.TabIndex = 5;
            // 
            // textBoxRe_2
            // 
            this.textBoxRe_2.Location = new System.Drawing.Point(17, 33);
            this.textBoxRe_2.Name = "textBoxRe_2";
            this.textBoxRe_2.Size = new System.Drawing.Size(141, 22);
            this.textBoxRe_2.TabIndex = 6;
            // 
            // textBoxIm_2
            // 
            this.textBoxIm_2.Location = new System.Drawing.Point(17, 76);
            this.textBoxIm_2.Name = "textBoxIm_2";
            this.textBoxIm_2.Size = new System.Drawing.Size(141, 22);
            this.textBoxIm_2.TabIndex = 7;
            // 
            // textBoxRes_Re
            // 
            this.textBoxRes_Re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxRes_Re.Location = new System.Drawing.Point(18, 33);
            this.textBoxRes_Re.Name = "textBoxRes_Re";
            this.textBoxRes_Re.ReadOnly = true;
            this.textBoxRes_Re.Size = new System.Drawing.Size(134, 22);
            this.textBoxRes_Re.TabIndex = 8;
            // 
            // textBoxRes_Im
            // 
            this.textBoxRes_Im.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxRes_Im.Location = new System.Drawing.Point(18, 76);
            this.textBoxRes_Im.Name = "textBoxRes_Im";
            this.textBoxRes_Im.ReadOnly = true;
            this.textBoxRes_Im.Size = new System.Drawing.Size(134, 22);
            this.textBoxRes_Im.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIm_1);
            this.groupBox1.Controls.Add(this.textBoxRe_1);
            this.groupBox1.Location = new System.Drawing.Point(48, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первое число";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIm_2);
            this.groupBox2.Controls.Add(this.textBoxRe_2);
            this.groupBox2.Location = new System.Drawing.Point(247, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Второе число";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRes_Im);
            this.groupBox3.Controls.Add(this.textBoxRes_Re);
            this.groupBox3.Location = new System.Drawing.Point(429, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // buttonPow
            // 
            this.buttonPow.Location = new System.Drawing.Point(141, 312);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(148, 50);
            this.buttonPow.TabIndex = 13;
            this.buttonPow.Text = "Степень (для 1 числа)";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(6, 326);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(120, 22);
            this.textBoxStep.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Степень числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Re";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Im";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(359, 323);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(137, 39);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClear);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxStep);
            this.groupBox4.Controls.Add(this.buttonPow);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.buttonDel);
            this.groupBox4.Controls.Add(this.buttonUmn);
            this.groupBox4.Controls.Add(this.buttonWyz);
            this.groupBox4.Controls.Add(this.buttonSloz);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 397);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вычисление комплексных чисел";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClearPanel);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.buttonDrawMandelbrot);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(648, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 458);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Множество Мандельброта";
            // 
            // buttonClearPanel
            // 
            this.buttonClearPanel.Location = new System.Drawing.Point(8, 300);
            this.buttonClearPanel.Name = "buttonClearPanel";
            this.buttonClearPanel.Size = new System.Drawing.Size(153, 55);
            this.buttonClearPanel.TabIndex = 9;
            this.buttonClearPanel.Text = "Очистить";
            this.buttonClearPanel.UseVisualStyleBackColor = true;
            this.buttonClearPanel.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Итераций";
            // 
            // buttonDrawMandelbrot
            // 
            this.buttonDrawMandelbrot.Location = new System.Drawing.Point(8, 217);
            this.buttonDrawMandelbrot.Name = "buttonDrawMandelbrot";
            this.buttonDrawMandelbrot.Size = new System.Drawing.Size(153, 59);
            this.buttonDrawMandelbrot.TabIndex = 1;
            this.buttonDrawMandelbrot.Text = "Нарисовать множество Мандельброта";
            this.buttonDrawMandelbrot.UseVisualStyleBackColor = true;
            this.buttonDrawMandelbrot.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(177, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // Complex_numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 488);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Complex_numbers";
            this.Text = "Комплексные числа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSloz;
        private System.Windows.Forms.Button buttonWyz;
        private System.Windows.Forms.Button buttonUmn;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxRe_1;
        private System.Windows.Forms.TextBox textBoxIm_1;
        private System.Windows.Forms.TextBox textBoxRe_2;
        private System.Windows.Forms.TextBox textBoxIm_2;
        private System.Windows.Forms.TextBox textBoxRes_Re;
        private System.Windows.Forms.TextBox textBoxRes_Im;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDrawMandelbrot;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClearPanel;
    }
}

