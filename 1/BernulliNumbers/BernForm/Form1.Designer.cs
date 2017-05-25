namespace BernForm
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
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonRow = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonRec
            // 
            this.buttonRec.Location = new System.Drawing.Point(66, 124);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(147, 69);
            this.buttonRec.TabIndex = 0;
            this.buttonRec.Text = "Реккурентная формула";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonRow
            // 
            this.buttonRow.Location = new System.Drawing.Point(66, 240);
            this.buttonRow.Name = "buttonRow";
            this.buttonRow.Size = new System.Drawing.Size(147, 69);
            this.buttonRow.TabIndex = 1;
            this.buttonRow.Text = "Сходящийся ряд";
            this.buttonRow.UseVisualStyleBackColor = true;
            this.buttonRow.Click += new System.EventHandler(this.buttonRow_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(67, 340);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(145, 22);
            this.textBoxN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "N";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(309, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 238);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 409);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonRow);
            this.Controls.Add(this.buttonRec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonRow;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

