namespace FamilyBank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactionsList = new System.Windows.Forms.ListBox();
            this.unsafetyStart = new System.Windows.Forms.Button();
            this.safetyStart = new System.Windows.Forms.Button();
            this.threadCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.threadCount);
            this.panel1.Controls.Add(this.safetyStart);
            this.panel1.Controls.Add(this.unsafetyStart);
            this.panel1.Controls.Add(this.transactionsList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 741);
            this.panel1.TabIndex = 0;
            // 
            // transactionsList
            // 
            this.transactionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsList.FormattingEnabled = true;
            this.transactionsList.ItemHeight = 18;
            this.transactionsList.Location = new System.Drawing.Point(13, 14);
            this.transactionsList.Name = "transactionsList";
            this.transactionsList.Size = new System.Drawing.Size(360, 418);
            this.transactionsList.TabIndex = 0;
            // 
            // unsafetyStart
            // 
            this.unsafetyStart.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsafetyStart.Location = new System.Drawing.Point(94, 549);
            this.unsafetyStart.Name = "unsafetyStart";
            this.unsafetyStart.Size = new System.Drawing.Size(212, 61);
            this.unsafetyStart.TabIndex = 1;
            this.unsafetyStart.Text = "Unsafety start";
            this.unsafetyStart.UseVisualStyleBackColor = true;
            this.unsafetyStart.Click += new System.EventHandler(this.unsafetyStart_Click);
            // 
            // safetyStart
            // 
            this.safetyStart.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safetyStart.Location = new System.Drawing.Point(94, 465);
            this.safetyStart.Name = "safetyStart";
            this.safetyStart.Size = new System.Drawing.Size(212, 61);
            this.safetyStart.TabIndex = 2;
            this.safetyStart.Text = "Safety start";
            this.safetyStart.UseVisualStyleBackColor = true;
            this.safetyStart.Click += new System.EventHandler(this.safetyStart_Click);
            // 
            // threadCount
            // 
            this.threadCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threadCount.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadCount.Location = new System.Drawing.Point(164, 695);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(77, 34);
            this.threadCount.TabIndex = 3;
            this.threadCount.Text = "160";
            this.threadCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count of clients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 767);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FamilyBank";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox threadCount;
        private System.Windows.Forms.Button safetyStart;
        private System.Windows.Forms.Button unsafetyStart;
        private System.Windows.Forms.ListBox transactionsList;
    }
}

