namespace PolinomForm
{
    partial class Form1
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
            this.buttonZnach = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreatePolinom = new System.Windows.Forms.Button();
            this.buttonPolinomDel = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZnach
            // 
            this.buttonZnach.Location = new System.Drawing.Point(21, 130);
            this.buttonZnach.Name = "buttonZnach";
            this.buttonZnach.Size = new System.Drawing.Size(201, 78);
            this.buttonZnach.TabIndex = 0;
            this.buttonZnach.Text = "Вычислить значение полинома в заданной точке, если заданы коэффициенты";
            this.buttonZnach.UseVisualStyleBackColor = true;
            this.buttonZnach.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(398, 44);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(437, 468);
            this.textBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(432, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вывод информации";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(239, 186);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(153, 22);
            this.textBoxX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // buttonCreatePolinom
            // 
            this.buttonCreatePolinom.Location = new System.Drawing.Point(21, 19);
            this.buttonCreatePolinom.Name = "buttonCreatePolinom";
            this.buttonCreatePolinom.Size = new System.Drawing.Size(201, 37);
            this.buttonCreatePolinom.TabIndex = 5;
            this.buttonCreatePolinom.Text = "Создать полином";
            this.buttonCreatePolinom.UseVisualStyleBackColor = true;
            this.buttonCreatePolinom.Click += new System.EventHandler(this.buttonCreatePolinom_Click);
            // 
            // buttonPolinomDel
            // 
            this.buttonPolinomDel.Location = new System.Drawing.Point(21, 75);
            this.buttonPolinomDel.Name = "buttonPolinomDel";
            this.buttonPolinomDel.Size = new System.Drawing.Size(201, 32);
            this.buttonPolinomDel.TabIndex = 6;
            this.buttonPolinomDel.Text = "Удалить полином";
            this.buttonPolinomDel.UseVisualStyleBackColor = true;
            this.buttonPolinomDel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(24, 224);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(197, 58);
            this.buttonPlus.TabIndex = 7;
            this.buttonPlus.Text = "Сложение двух полиномов";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычитание двух полиномов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPolinomDel);
            this.Controls.Add(this.buttonCreatePolinom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonZnach);
            this.Name = "Form1";
            this.Text = "Полиномы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZnach;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreatePolinom;
        private System.Windows.Forms.Button buttonPolinomDel;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button1;
    }
}

