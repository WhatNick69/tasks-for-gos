namespace ThreadedInterface
{
    partial class MainForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.textBoxUpLimit = new System.Windows.Forms.TextBox();
            this.textBoxDownLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxText = new System.Windows.Forms.ListBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(530, 219);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 44);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Пуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(530, 350);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(163, 45);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(530, 414);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(163, 47);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 16;
            this.listBoxValues.Location = new System.Drawing.Point(12, 71);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(190, 324);
            this.listBoxValues.TabIndex = 4;
            // 
            // textBoxUpLimit
            // 
            this.textBoxUpLimit.Location = new System.Drawing.Point(610, 170);
            this.textBoxUpLimit.Name = "textBoxUpLimit";
            this.textBoxUpLimit.Size = new System.Drawing.Size(162, 22);
            this.textBoxUpLimit.TabIndex = 5;
            this.textBoxUpLimit.Text = "20";
            // 
            // textBoxDownLimit
            // 
            this.textBoxDownLimit.Location = new System.Drawing.Point(610, 128);
            this.textBoxDownLimit.Name = "textBoxDownLimit";
            this.textBoxDownLimit.Size = new System.Drawing.Size(162, 22);
            this.textBoxDownLimit.TabIndex = 6;
            this.textBoxDownLimit.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Нижний предел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Верхний предел";
            // 
            // listBoxText
            // 
            this.listBoxText.FormattingEnabled = true;
            this.listBoxText.ItemHeight = 16;
            this.listBoxText.Location = new System.Drawing.Point(260, 71);
            this.listBoxText.Name = "listBoxText";
            this.listBoxText.Size = new System.Drawing.Size(190, 324);
            this.listBoxText.TabIndex = 9;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(530, 285);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(163, 44);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 507);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.listBoxText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDownLimit);
            this.Controls.Add(this.textBoxUpLimit);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.TextBox textBoxUpLimit;
        private System.Windows.Forms.TextBox textBoxDownLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxText;
        private System.Windows.Forms.Button buttonChange;
    }
}

