namespace PracticeOne.Fourth
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            labelInfo = new Label();
            label1 = new Label();
            buttonStart = new Button();
            numericUpDownCount = new NumericUpDown();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(197, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(583, 435);
            dataGridView1.TabIndex = 0;
            // 
            // labelInfo
            // 
            labelInfo.Location = new Point(0, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(100, 23);
            labelInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Количество:";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 66);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(179, 23);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Рассчитать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(12, 37);
            numericUpDownCount.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDownCount.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(179, 23);
            numericUpDownCount.TabIndex = 4;
            numericUpDownCount.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // Column6
            // 
            Column6.HeaderText = "Год";
            Column6.Name = "Column6";
            // 
            // Column2
            // 
            Column2.HeaderText = "Количество арестантов";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Прибавка за год";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Убыль за 2 года";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Осталось места";
            Column5.Name = "Column5";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownCount);
            Controls.Add(buttonStart);
            Controls.Add(label1);
            Controls.Add(labelInfo);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Практика 4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelInfo;
        private Label label1;
        private Button buttonStart;
        private NumericUpDown numericUpDownCount;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}