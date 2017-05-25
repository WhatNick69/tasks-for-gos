namespace InterpretatorAndSolver
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.charBox = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultList = new System.Windows.Forms.ListBox();
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.solverButton = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.interfacePanel = new System.Windows.Forms.Panel();
            this.formulaList = new System.Windows.Forms.ComboBox();
            this.epsText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.charBox)).BeginInit();
            this.resultPanel.SuspendLayout();
            this.interfacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // charBox
            // 
            chartArea8.Name = "ChartArea1";
            this.charBox.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.charBox.Legends.Add(legend8);
            this.charBox.Location = new System.Drawing.Point(16, 20);
            this.charBox.Name = "charBox";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.charBox.Series.Add(series8);
            this.charBox.Size = new System.Drawing.Size(592, 404);
            this.charBox.TabIndex = 0;
            this.charBox.Text = "chart1";
            // 
            // resultList
            // 
            this.resultList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultList.FormattingEnabled = true;
            this.resultList.ItemHeight = 16;
            this.resultList.Location = new System.Drawing.Point(380, 17);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(228, 180);
            this.resultList.TabIndex = 1;
            // 
            // formulaBox
            // 
            this.formulaBox.AcceptsReturn = true;
            this.formulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaBox.Location = new System.Drawing.Point(16, 17);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.Size = new System.Drawing.Size(358, 31);
            this.formulaBox.TabIndex = 2;
            this.formulaBox.Text = "x*x*x-3*x*x+82*x-95";
            // 
            // solverButton
            // 
            this.solverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solverButton.Location = new System.Drawing.Point(240, 152);
            this.solverButton.Name = "solverButton";
            this.solverButton.Size = new System.Drawing.Size(134, 44);
            this.solverButton.TabIndex = 3;
            this.solverButton.Text = "Start";
            this.solverButton.UseVisualStyleBackColor = true;
            this.solverButton.Click += new System.EventHandler(this.solverButton_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.charBox);
            this.resultPanel.Location = new System.Drawing.Point(12, 229);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(619, 439);
            this.resultPanel.TabIndex = 4;
            // 
            // interfacePanel
            // 
            this.interfacePanel.Controls.Add(this.epsText);
            this.interfacePanel.Controls.Add(this.formulaList);
            this.interfacePanel.Controls.Add(this.formulaBox);
            this.interfacePanel.Controls.Add(this.resultList);
            this.interfacePanel.Controls.Add(this.solverButton);
            this.interfacePanel.Location = new System.Drawing.Point(12, 16);
            this.interfacePanel.Name = "interfacePanel";
            this.interfacePanel.Size = new System.Drawing.Size(619, 207);
            this.interfacePanel.TabIndex = 5;
            // 
            // formulaList
            // 
            this.formulaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaList.FormattingEnabled = true;
            this.formulaList.Items.AddRange(new object[] {
            "x*x*x - 3,5*x*x + 56/x + 42 - 5*3/18",
            "x*x-24",
            "x*x*93,5 - 48,064*x + 96.3/55,23*x + 1905,0649"});
            this.formulaList.Location = new System.Drawing.Point(16, 62);
            this.formulaList.Name = "formulaList";
            this.formulaList.Size = new System.Drawing.Size(358, 33);
            this.formulaList.TabIndex = 4;
            this.formulaList.SelectedValueChanged += new System.EventHandler(this.formulaList_SelectedValueChanged);
            // 
            // epsText
            // 
            this.epsText.AcceptsReturn = true;
            this.epsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epsText.Location = new System.Drawing.Point(16, 165);
            this.epsText.Name = "epsText";
            this.epsText.Size = new System.Drawing.Size(103, 31);
            this.epsText.TabIndex = 5;
            this.epsText.Text = "0.001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 680);
            this.Controls.Add(this.interfacePanel);
            this.Controls.Add(this.resultPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "InterpretatorAndSolver";
            ((System.ComponentModel.ISupportInitialize)(this.charBox)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.interfacePanel.ResumeLayout(false);
            this.interfacePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart charBox;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Button solverButton;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel interfacePanel;
        private System.Windows.Forms.ComboBox formulaList;
        private System.Windows.Forms.TextBox epsText;
    }
}

