namespace PracticeOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNumbers = new Panel();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            panelArray = new Panel();
            buttonTwoArray = new Button();
            buttonOneArray = new Button();
            textBoxArray = new TextBox();
            labelMax = new Label();
            labelMin = new Label();
            numericUpDownMax = new NumericUpDown();
            numericUpDownMin = new NumericUpDown();
            labelCols = new Label();
            labelRows = new Label();
            numericUpDownCols = new NumericUpDown();
            numericUpDownRow = new NumericUpDown();
            panelResult = new Panel();
            textBoxResult = new TextBox();
            buttonStart = new Button();
            textBoxInfo = new TextBox();
            panelNumbers.SuspendLayout();
            panelArray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRow).BeginInit();
            panelResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelNumbers
            // 
            panelNumbers.Controls.Add(buttonSix);
            panelNumbers.Controls.Add(buttonFive);
            panelNumbers.Controls.Add(buttonFour);
            panelNumbers.Controls.Add(buttonThree);
            panelNumbers.Controls.Add(buttonTwo);
            panelNumbers.Controls.Add(buttonOne);
            panelNumbers.Dock = DockStyle.Left;
            panelNumbers.Location = new Point(0, 0);
            panelNumbers.Name = "panelNumbers";
            panelNumbers.Size = new Size(196, 450);
            panelNumbers.TabIndex = 0;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(103, 166);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(75, 23);
            buttonSix.TabIndex = 5;
            buttonSix.Text = "Задание 6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(12, 166);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(75, 23);
            buttonFive.TabIndex = 4;
            buttonFive.Text = "Задание 5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(103, 121);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(75, 23);
            buttonFour.TabIndex = 3;
            buttonFour.Text = "Задание 4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(12, 121);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(75, 23);
            buttonThree.TabIndex = 2;
            buttonThree.Text = "Задание 3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(103, 78);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(75, 23);
            buttonTwo.TabIndex = 1;
            buttonTwo.Text = "Задание 2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(12, 78);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(75, 23);
            buttonOne.TabIndex = 0;
            buttonOne.Text = "Задание 1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // panelArray
            // 
            panelArray.Controls.Add(buttonTwoArray);
            panelArray.Controls.Add(buttonOneArray);
            panelArray.Controls.Add(textBoxArray);
            panelArray.Controls.Add(labelMax);
            panelArray.Controls.Add(labelMin);
            panelArray.Controls.Add(numericUpDownMax);
            panelArray.Controls.Add(numericUpDownMin);
            panelArray.Controls.Add(labelCols);
            panelArray.Controls.Add(labelRows);
            panelArray.Controls.Add(numericUpDownCols);
            panelArray.Controls.Add(numericUpDownRow);
            panelArray.Location = new Point(428, 0);
            panelArray.Name = "panelArray";
            panelArray.Size = new Size(371, 206);
            panelArray.TabIndex = 1;
            // 
            // buttonTwoArray
            // 
            buttonTwoArray.Location = new Point(265, 144);
            buttonTwoArray.Name = "buttonTwoArray";
            buttonTwoArray.Size = new Size(99, 45);
            buttonTwoArray.TabIndex = 10;
            buttonTwoArray.Text = "Двумерный массив";
            buttonTwoArray.UseVisualStyleBackColor = true;
            buttonTwoArray.Click += buttonTwoArray_Click;
            // 
            // buttonOneArray
            // 
            buttonOneArray.Location = new Point(265, 90);
            buttonOneArray.Name = "buttonOneArray";
            buttonOneArray.Size = new Size(99, 45);
            buttonOneArray.TabIndex = 9;
            buttonOneArray.Text = "Одномерный массив";
            buttonOneArray.UseVisualStyleBackColor = true;
            buttonOneArray.Click += buttonOneArray_Click;
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(18, 90);
            textBoxArray.Multiline = true;
            textBoxArray.Name = "textBoxArray";
            textBoxArray.ScrollBars = ScrollBars.Vertical;
            textBoxArray.Size = new Size(229, 99);
            textBoxArray.TabIndex = 8;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(203, 48);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(93, 15);
            labelMax.TabIndex = 7;
            labelMax.Text = "Макс. значение";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(18, 46);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(89, 15);
            labelMin.TabIndex = 6;
            labelMin.Text = "Мин. значение";
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Location = new Point(302, 46);
            numericUpDownMax.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(62, 23);
            numericUpDownMax.TabIndex = 5;
            numericUpDownMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMax.ValueChanged += numericUpDownMax_ValueChanged;
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Location = new Point(128, 46);
            numericUpDownMin.Maximum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownMin.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(62, 23);
            numericUpDownMin.TabIndex = 4;
            numericUpDownMin.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownMin.ValueChanged += numericUpDownMin_ValueChanged;
            // 
            // labelCols
            // 
            labelCols.AutoSize = true;
            labelCols.Location = new Point(18, 19);
            labelCols.Name = "labelCols";
            labelCols.Size = new Size(104, 15);
            labelCols.TabIndex = 3;
            labelCols.Text = "Кол-во столбцов:";
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(213, 19);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(83, 15);
            labelRows.TabIndex = 2;
            labelRows.Text = "Кол-во строк:";
            // 
            // numericUpDownCols
            // 
            numericUpDownCols.Location = new Point(128, 17);
            numericUpDownCols.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCols.Name = "numericUpDownCols";
            numericUpDownCols.Size = new Size(38, 23);
            numericUpDownCols.TabIndex = 1;
            numericUpDownCols.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCols.ValueChanged += numericUpDownCols_ValueChanged;
            // 
            // numericUpDownRow
            // 
            numericUpDownRow.Location = new Point(302, 17);
            numericUpDownRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRow.Name = "numericUpDownRow";
            numericUpDownRow.Size = new Size(38, 23);
            numericUpDownRow.TabIndex = 0;
            numericUpDownRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRow.ValueChanged += numericUpDownRow_ValueChanged;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(textBoxResult);
            panelResult.Controls.Add(buttonStart);
            panelResult.Controls.Add(textBoxInfo);
            panelResult.Dock = DockStyle.Bottom;
            panelResult.Location = new Point(196, 212);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(604, 238);
            panelResult.TabIndex = 2;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 136);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(586, 99);
            textBoxResult.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(212, 107);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Выполнить задание";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(10, 14);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ScrollBars = ScrollBars.Vertical;
            textBoxInfo.Size = new Size(586, 87);
            textBoxInfo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelResult);
            Controls.Add(panelArray);
            Controls.Add(panelNumbers);
            Name = "Form1";
            Text = "Практика 1";
            panelNumbers.ResumeLayout(false);
            panelArray.ResumeLayout(false);
            panelArray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCols).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRow).EndInit();
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNumbers;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Panel panelArray;
        private NumericUpDown numericUpDownCols;
        private NumericUpDown numericUpDownRow;
        private Label labelRows;
        private Label labelCols;
        private NumericUpDown numericUpDownMax;
        private NumericUpDown numericUpDownMin;
        private Label labelMin;
        private Label labelMax;
        private TextBox textBoxArray;
        private Button buttonTwoArray;
        private Button buttonOneArray;
        private Panel panelResult;
        private TextBox textBoxInfo;
        private Button buttonStart;
        private TextBox textBoxResult;
    }
}