namespace Merge
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(266, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(234, 152);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.ReadOnly = true;
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 1;
            this.textBoxLength.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина всей последовательности";
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Location = new System.Drawing.Point(412, 152);
            this.textBoxBefore.Multiline = true;
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBefore.Size = new System.Drawing.Size(143, 210);
            this.textBoxBefore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "До";
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Location = new System.Drawing.Point(636, 152);
            this.textBoxAfter.Multiline = true;
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAfter.Size = new System.Drawing.Size(128, 209);
            this.textBoxAfter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "После";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пока что используется фиксированное число длины последовательности\r\n и заданный в" +
    "нутри программы массив";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxTime.Location = new System.Drawing.Point(68, 299);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(265, 22);
            this.textBoxTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}

