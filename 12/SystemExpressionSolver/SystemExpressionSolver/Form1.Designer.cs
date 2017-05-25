namespace SystemExpressionSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slauButton = new System.Windows.Forms.Button();
            this.timeSeqSLAU = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.determinantButton = new System.Windows.Forms.Button();
            this.reverseMatrixButton = new System.Windows.Forms.Button();
            this.timeParallelSLAU = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.determinant = new System.Windows.Forms.TextBox();
            this.listSLAU = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reversing = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slauButton
            // 
            this.slauButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slauButton.Location = new System.Drawing.Point(157, 467);
            this.slauButton.Name = "slauButton";
            this.slauButton.Size = new System.Drawing.Size(196, 50);
            this.slauButton.TabIndex = 0;
            this.slauButton.Text = "Linear solver";
            this.slauButton.UseVisualStyleBackColor = true;
            this.slauButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeSeqSLAU
            // 
            this.timeSeqSLAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSeqSLAU.Location = new System.Drawing.Point(166, 263);
            this.timeSeqSLAU.Name = "timeSeqSLAU";
            this.timeSeqSLAU.Size = new System.Drawing.Size(150, 31);
            this.timeSeqSLAU.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.reversing);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.listSLAU);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.determinant);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.timeParallelSLAU);
            this.mainPanel.Controls.Add(this.timeSeqSLAU);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(341, 363);
            this.mainPanel.TabIndex = 2;
            // 
            // determinantButton
            // 
            this.determinantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determinantButton.Location = new System.Drawing.Point(157, 390);
            this.determinantButton.Name = "determinantButton";
            this.determinantButton.Size = new System.Drawing.Size(196, 50);
            this.determinantButton.TabIndex = 3;
            this.determinantButton.Text = "Find determinant";
            this.determinantButton.UseVisualStyleBackColor = true;
            this.determinantButton.Click += new System.EventHandler(this.determinantButton_Click);
            // 
            // reverseMatrixButton
            // 
            this.reverseMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseMatrixButton.Location = new System.Drawing.Point(157, 544);
            this.reverseMatrixButton.Name = "reverseMatrixButton";
            this.reverseMatrixButton.Size = new System.Drawing.Size(196, 50);
            this.reverseMatrixButton.TabIndex = 4;
            this.reverseMatrixButton.Text = "Reverse matrix";
            this.reverseMatrixButton.UseVisualStyleBackColor = true;
            this.reverseMatrixButton.Click += new System.EventHandler(this.reverseMatrixButton_Click);
            // 
            // timeParallelSLAU
            // 
            this.timeParallelSLAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeParallelSLAU.Location = new System.Drawing.Point(166, 311);
            this.timeParallelSLAU.Name = "timeParallelSLAU";
            this.timeParallelSLAU.Size = new System.Drawing.Size(150, 31);
            this.timeParallelSLAU.TabIndex = 5;
            // 
            // yTextBox
            // 
            this.yTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yTextBox.Location = new System.Drawing.Point(51, 435);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(89, 31);
            this.yTextBox.TabIndex = 6;
            this.yTextBox.Visible = false;
            // 
            // xTextBox
            // 
            this.xTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTextBox.Location = new System.Drawing.Point(51, 391);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(89, 31);
            this.xTextBox.TabIndex = 7;
            this.xTextBox.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parallel time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seq. time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Determinant:";
            // 
            // determinant
            // 
            this.determinant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.determinant.Location = new System.Drawing.Point(166, 172);
            this.determinant.Name = "determinant";
            this.determinant.Size = new System.Drawing.Size(150, 31);
            this.determinant.TabIndex = 12;
            // 
            // listSLAU
            // 
            this.listSLAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSLAU.FormattingEnabled = true;
            this.listSLAU.ItemHeight = 24;
            this.listSLAU.Items.AddRange(new object[] {
            "Roots will ",
            "be here..."});
            this.listSLAU.Location = new System.Drawing.Point(166, 20);
            this.listSLAU.Name = "listSLAU";
            this.listSLAU.Size = new System.Drawing.Size(150, 124);
            this.listSLAU.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Root`s:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Reverse matrix:";
            // 
            // reversing
            // 
            this.reversing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversing.Location = new System.Drawing.Point(166, 217);
            this.reversing.Name = "reversing";
            this.reversing.Size = new System.Drawing.Size(150, 31);
            this.reversing.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 609);
            this.Controls.Add(this.reverseMatrixButton);
            this.Controls.Add(this.determinantButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slauButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Work with Matrix";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button slauButton;
        private System.Windows.Forms.TextBox timeSeqSLAU;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button determinantButton;
        private System.Windows.Forms.Button reverseMatrixButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listSLAU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox determinant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeParallelSLAU;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reversing;
    }
}

