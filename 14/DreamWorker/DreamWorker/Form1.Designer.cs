namespace DreamWorker
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
            this.buttonProg = new System.Windows.Forms.Button();
            this.buttonBuh = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCsharp = new System.Windows.Forms.CheckBox();
            this.checkBoxCpp = new System.Windows.Forms.CheckBox();
            this.checkBoxAsp = new System.Windows.Forms.CheckBox();
            this.checkBox1c = new System.Windows.Forms.CheckBox();
            this.checkBoxBuch = new System.Windows.Forms.CheckBox();
            this.checkBoxSmoke = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonProg
            // 
            this.buttonProg.Location = new System.Drawing.Point(40, 200);
            this.buttonProg.Name = "buttonProg";
            this.buttonProg.Size = new System.Drawing.Size(192, 44);
            this.buttonProg.TabIndex = 0;
            this.buttonProg.Text = "Отдел программистов";
            this.buttonProg.UseVisualStyleBackColor = true;
            this.buttonProg.Click += new System.EventHandler(this.buttonProg_Click);
            // 
            // buttonBuh
            // 
            this.buttonBuh.Location = new System.Drawing.Point(40, 272);
            this.buttonBuh.Name = "buttonBuh";
            this.buttonBuh.Size = new System.Drawing.Size(192, 44);
            this.buttonBuh.TabIndex = 1;
            this.buttonBuh.Text = "Отдел бухгалетеров";
            this.buttonBuh.UseVisualStyleBackColor = true;
            this.buttonBuh.Click += new System.EventHandler(this.buttonBuh_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(327, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 183);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вердикт";
            // 
            // checkBoxCsharp
            // 
            this.checkBoxCsharp.AutoSize = true;
            this.checkBoxCsharp.Location = new System.Drawing.Point(66, 18);
            this.checkBoxCsharp.Name = "checkBoxCsharp";
            this.checkBoxCsharp.Size = new System.Drawing.Size(91, 21);
            this.checkBoxCsharp.TabIndex = 5;
            this.checkBoxCsharp.Text = "Знает C#";
            this.checkBoxCsharp.UseVisualStyleBackColor = true;
            // 
            // checkBoxCpp
            // 
            this.checkBoxCpp.AutoSize = true;
            this.checkBoxCpp.Location = new System.Drawing.Point(66, 45);
            this.checkBoxCpp.Name = "checkBoxCpp";
            this.checkBoxCpp.Size = new System.Drawing.Size(99, 21);
            this.checkBoxCpp.TabIndex = 6;
            this.checkBoxCpp.Text = "Знает C++";
            this.checkBoxCpp.UseVisualStyleBackColor = true;
            // 
            // checkBoxAsp
            // 
            this.checkBoxAsp.AutoSize = true;
            this.checkBoxAsp.Location = new System.Drawing.Point(66, 72);
            this.checkBoxAsp.Name = "checkBoxAsp";
            this.checkBoxAsp.Size = new System.Drawing.Size(133, 21);
            this.checkBoxAsp.TabIndex = 7;
            this.checkBoxAsp.Text = "Знает ASP.NET";
            this.checkBoxAsp.UseVisualStyleBackColor = true;
            // 
            // checkBox1c
            // 
            this.checkBox1c.AutoSize = true;
            this.checkBox1c.Location = new System.Drawing.Point(66, 100);
            this.checkBox1c.Name = "checkBox1c";
            this.checkBox1c.Size = new System.Drawing.Size(91, 21);
            this.checkBox1c.TabIndex = 8;
            this.checkBox1c.Text = "Знает 1С";
            this.checkBox1c.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuch
            // 
            this.checkBoxBuch.AutoSize = true;
            this.checkBoxBuch.Location = new System.Drawing.Point(66, 134);
            this.checkBoxBuch.Name = "checkBoxBuch";
            this.checkBoxBuch.Size = new System.Drawing.Size(125, 21);
            this.checkBoxBuch.TabIndex = 9;
            this.checkBoxBuch.Text = "Знает бухучёт";
            this.checkBoxBuch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSmoke
            // 
            this.checkBoxSmoke.AutoSize = true;
            this.checkBoxSmoke.Location = new System.Drawing.Point(66, 164);
            this.checkBoxSmoke.Name = "checkBoxSmoke";
            this.checkBoxSmoke.Size = new System.Drawing.Size(89, 21);
            this.checkBoxSmoke.TabIndex = 10;
            this.checkBoxSmoke.Text = "Не курит";
            this.checkBoxSmoke.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 377);
            this.Controls.Add(this.checkBoxSmoke);
            this.Controls.Add(this.checkBoxBuch);
            this.Controls.Add(this.checkBox1c);
            this.Controls.Add(this.checkBoxAsp);
            this.Controls.Add(this.checkBoxCpp);
            this.Controls.Add(this.checkBoxCsharp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBuh);
            this.Controls.Add(this.buttonProg);
            this.Name = "Form1";
            this.Text = "Workers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProg;
        private System.Windows.Forms.Button buttonBuh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCsharp;
        private System.Windows.Forms.CheckBox checkBoxCpp;
        private System.Windows.Forms.CheckBox checkBoxAsp;
        private System.Windows.Forms.CheckBox checkBox1c;
        private System.Windows.Forms.CheckBox checkBoxBuch;
        private System.Windows.Forms.CheckBox checkBoxSmoke;
    }
}

