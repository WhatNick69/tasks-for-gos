namespace ThiefsForm
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
            this.buttonPerebor = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPerebor
            // 
            this.buttonPerebor.Location = new System.Drawing.Point(57, 110);
            this.buttonPerebor.Name = "buttonPerebor";
            this.buttonPerebor.Size = new System.Drawing.Size(201, 52);
            this.buttonPerebor.TabIndex = 0;
            this.buttonPerebor.Text = "Перебор";
            this.buttonPerebor.UseVisualStyleBackColor = true;
            this.buttonPerebor.Click += new System.EventHandler(this.buttonPerebor_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(57, 194);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(201, 52);
            this.buttonRec.TabIndex = 1;
            this.buttonRec.Text = "Рекурсия";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(317, 110);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(328, 136);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число символов у 1 вора";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.buttonPerebor);
            this.Name = "Form1";
            this.Text = "Thiefs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPerebor;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

