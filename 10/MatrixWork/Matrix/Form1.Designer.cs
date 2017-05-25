namespace Matrix
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 63);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Сложение";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(39, 160);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(112, 63);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "Вычитание";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(39, 260);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(112, 63);
            this.buttonMul.TabIndex = 2;
            this.buttonMul.Text = "Умножение";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(286, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 267);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(86, 339);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 5;
            this.textBoxN.Text = "3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 341);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Вывод матриц";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 380);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "MatrixOps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

