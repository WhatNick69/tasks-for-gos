namespace WorkWithDLL
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
            this.minusButtonStart = new System.Windows.Forms.Button();
            this.nPoints = new System.Windows.Forms.Label();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plusButtonStart = new System.Windows.Forms.Button();
            this.dll2Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pointY = new System.Windows.Forms.TextBox();
            this.pointX = new System.Windows.Forms.TextBox();
            this.tempBox = new System.Windows.Forms.TextBox();
            this.refreshButtotn = new System.Windows.Forms.Button();
            this.yList = new System.Windows.Forms.ListBox();
            this.xList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.dll2Result = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.dll2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minusButtonStart
            // 
            this.minusButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButtonStart.Location = new System.Drawing.Point(4, 32);
            this.minusButtonStart.Name = "minusButtonStart";
            this.minusButtonStart.Size = new System.Drawing.Size(42, 99);
            this.minusButtonStart.TabIndex = 0;
            this.minusButtonStart.Text = "-";
            this.minusButtonStart.UseVisualStyleBackColor = true;
            this.minusButtonStart.Click += new System.EventHandler(this.minusButtonStart_click);
            // 
            // nPoints
            // 
            this.nPoints.AutoSize = true;
            this.nPoints.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPoints.Location = new System.Drawing.Point(49, 65);
            this.nPoints.MaximumSize = new System.Drawing.Size(50, 32);
            this.nPoints.MinimumSize = new System.Drawing.Size(50, 32);
            this.nPoints.Name = "nPoints";
            this.nPoints.Size = new System.Drawing.Size(50, 32);
            this.nPoints.TabIndex = 2;
            this.nPoints.Text = "4";
            this.nPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nPoints.UseCompatibleTextRendering = true;
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drawPanel.Location = new System.Drawing.Point(15, 187);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drawPanel.Size = new System.Drawing.Size(573, 363);
            this.drawPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.plusButtonStart);
            this.panel2.Controls.Add(this.minusButtonStart);
            this.panel2.Controls.Add(this.nPoints);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 160);
            this.panel2.TabIndex = 4;
            // 
            // plusButtonStart
            // 
            this.plusButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButtonStart.Location = new System.Drawing.Point(105, 32);
            this.plusButtonStart.Name = "plusButtonStart";
            this.plusButtonStart.Size = new System.Drawing.Size(42, 99);
            this.plusButtonStart.TabIndex = 40;
            this.plusButtonStart.Text = "+";
            this.plusButtonStart.UseVisualStyleBackColor = true;
            this.plusButtonStart.Click += new System.EventHandler(this.plusButtonStart_Click);
            // 
            // dll2Panel
            // 
            this.dll2Panel.Controls.Add(this.label5);
            this.dll2Panel.Controls.Add(this.label4);
            this.dll2Panel.Controls.Add(this.pointY);
            this.dll2Panel.Controls.Add(this.pointX);
            this.dll2Panel.Controls.Add(this.tempBox);
            this.dll2Panel.Controls.Add(this.refreshButtotn);
            this.dll2Panel.Controls.Add(this.yList);
            this.dll2Panel.Controls.Add(this.xList);
            this.dll2Panel.Controls.Add(this.label3);
            this.dll2Panel.Controls.Add(this.label2);
            this.dll2Panel.Controls.Add(this.drawButton);
            this.dll2Panel.Controls.Add(this.dll2Result);
            this.dll2Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.dll2Panel.Location = new System.Drawing.Point(169, 21);
            this.dll2Panel.Name = "dll2Panel";
            this.dll2Panel.Size = new System.Drawing.Size(416, 160);
            this.dll2Panel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "PointY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "PointX";
            // 
            // pointY
            // 
            this.pointY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointY.Location = new System.Drawing.Point(314, 47);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(90, 34);
            this.pointY.TabIndex = 50;
            this.pointY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointX
            // 
            this.pointX.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointX.Location = new System.Drawing.Point(314, 7);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(90, 34);
            this.pointX.TabIndex = 49;
            this.pointX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempBox
            // 
            this.tempBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBox.Location = new System.Drawing.Point(88, 85);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(103, 34);
            this.tempBox.TabIndex = 48;
            this.tempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refreshButtotn
            // 
            this.refreshButtotn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshButtotn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButtotn.Location = new System.Drawing.Point(247, 84);
            this.refreshButtotn.Name = "refreshButtotn";
            this.refreshButtotn.Size = new System.Drawing.Size(157, 34);
            this.refreshButtotn.TabIndex = 47;
            this.refreshButtotn.Text = "Обновить поинты";
            this.refreshButtotn.UseVisualStyleBackColor = true;
            this.refreshButtotn.Click += new System.EventHandler(this.refreshButtotn_Click);
            // 
            // yList
            // 
            this.yList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yList.FormattingEnabled = true;
            this.yList.ItemHeight = 16;
            this.yList.Items.AddRange(new object[] {
            "50\t",
            "50",
            "200",
            "200"});
            this.yList.Location = new System.Drawing.Point(165, 10);
            this.yList.Name = "yList";
            this.yList.Size = new System.Drawing.Size(71, 68);
            this.yList.TabIndex = 46;
            this.yList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeValueYBySelectedItem);
            // 
            // xList
            // 
            this.xList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xList.FormattingEnabled = true;
            this.xList.ItemHeight = 16;
            this.xList.Items.AddRange(new object[] {
            "50",
            "200",
            "200",
            "50"});
            this.xList.Location = new System.Drawing.Point(42, 10);
            this.xList.Name = "xList";
            this.xList.Size = new System.Drawing.Size(70, 68);
            this.xList.TabIndex = 45;
            this.xList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChangeValueXBySelectedItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Y = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "X = ";
            // 
            // drawButton
            // 
            this.drawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawButton.Location = new System.Drawing.Point(247, 122);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(157, 34);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Рисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // dll2Result
            // 
            this.dll2Result.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dll2Result.Location = new System.Drawing.Point(42, 123);
            this.dll2Result.Name = "dll2Result";
            this.dll2Result.Size = new System.Drawing.Size(194, 34);
            this.dll2Result.TabIndex = 17;
            this.dll2Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 562);
            this.Controls.Add(this.dll2Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.drawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DLLForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dll2Panel.ResumeLayout(false);
            this.dll2Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minusButtonStart;
        private System.Windows.Forms.Label nPoints;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dll2Panel;
        private System.Windows.Forms.TextBox dll2Result;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox xList;
        private System.Windows.Forms.ListBox yList;
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.Button refreshButtotn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pointY;
        private System.Windows.Forms.TextBox pointX;
        private System.Windows.Forms.Button plusButtonStart;
    }
}

