namespace PracticeOne.Second
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panelOne = new Panel();
            buttonRemoveEnd = new Button();
            buttonAddEnd = new Button();
            textBoxResultOne = new TextBox();
            buttonResultOne = new Button();
            buttonRemoveCount = new Button();
            buttonAddCount = new Button();
            labelInfoOne = new Label();
            textBoxInfoOne = new TextBox();
            panelThree = new Panel();
            labelStart = new Label();
            textBoxResultThree = new TextBox();
            buttonResultThree = new Button();
            textBoxLineOne = new TextBox();
            textBoxInfoThree = new TextBox();
            labelInfoThree = new Label();
            panelTwo = new Panel();
            textBoxInput = new TextBox();
            buttonBack = new Button();
            textBoxStepTwo = new TextBox();
            buttonStep = new Button();
            textBoxResultTwo = new TextBox();
            buttonResultTwo = new Button();
            labelInfoTwo = new Label();
            textBoxInfoTwo = new TextBox();
            panelOne.SuspendLayout();
            panelThree.SuspendLayout();
            panelTwo.SuspendLayout();
            SuspendLayout();
            // 
            // panelOne
            // 
            panelOne.Controls.Add(buttonRemoveEnd);
            panelOne.Controls.Add(buttonAddEnd);
            panelOne.Controls.Add(textBoxResultOne);
            panelOne.Controls.Add(buttonResultOne);
            panelOne.Controls.Add(buttonRemoveCount);
            panelOne.Controls.Add(buttonAddCount);
            panelOne.Controls.Add(labelInfoOne);
            panelOne.Controls.Add(textBoxInfoOne);
            panelOne.Dock = DockStyle.Left;
            panelOne.Location = new Point(0, 0);
            panelOne.Name = "panelOne";
            panelOne.Size = new Size(339, 450);
            panelOne.TabIndex = 0;
            // 
            // buttonRemoveEnd
            // 
            buttonRemoveEnd.Location = new Point(250, 158);
            buttonRemoveEnd.Name = "buttonRemoveEnd";
            buttonRemoveEnd.Size = new Size(83, 47);
            buttonRemoveEnd.TabIndex = 7;
            buttonRemoveEnd.Text = "Удалить с конца";
            buttonRemoveEnd.UseVisualStyleBackColor = true;
            buttonRemoveEnd.Click += buttonRemoveEnd_Click;
            // 
            // buttonAddEnd
            // 
            buttonAddEnd.Location = new Point(86, 158);
            buttonAddEnd.Name = "buttonAddEnd";
            buttonAddEnd.Size = new Size(72, 47);
            buttonAddEnd.TabIndex = 6;
            buttonAddEnd.Text = "Добавить в конец";
            buttonAddEnd.UseVisualStyleBackColor = true;
            buttonAddEnd.Click += buttonAddEnd_Click;
            // 
            // textBoxResultOne
            // 
            textBoxResultOne.Location = new Point(3, 258);
            textBoxResultOne.Multiline = true;
            textBoxResultOne.Name = "textBoxResultOne";
            textBoxResultOne.Size = new Size(333, 189);
            textBoxResultOne.TabIndex = 5;
            // 
            // buttonResultOne
            // 
            buttonResultOne.Location = new Point(6, 211);
            buttonResultOne.Name = "buttonResultOne";
            buttonResultOne.Size = new Size(327, 41);
            buttonResultOne.TabIndex = 4;
            buttonResultOne.Text = "Результат";
            buttonResultOne.UseVisualStyleBackColor = true;
            buttonResultOne.Click += buttonResultOne_Click;
            // 
            // buttonRemoveCount
            // 
            buttonRemoveCount.Location = new Point(164, 158);
            buttonRemoveCount.Name = "buttonRemoveCount";
            buttonRemoveCount.Size = new Size(80, 47);
            buttonRemoveCount.TabIndex = 3;
            buttonRemoveCount.Text = "Удалить число";
            buttonRemoveCount.UseVisualStyleBackColor = true;
            buttonRemoveCount.Click += buttonRemoveCount_Click;
            // 
            // buttonAddCount
            // 
            buttonAddCount.Location = new Point(6, 158);
            buttonAddCount.Name = "buttonAddCount";
            buttonAddCount.Size = new Size(74, 47);
            buttonAddCount.TabIndex = 2;
            buttonAddCount.Text = "Добавить число";
            buttonAddCount.UseVisualStyleBackColor = true;
            buttonAddCount.Click += buttonAddCount_Click;
            // 
            // labelInfoOne
            // 
            labelInfoOne.AutoSize = true;
            labelInfoOne.Location = new Point(98, 5);
            labelInfoOne.Name = "labelInfoOne";
            labelInfoOne.Size = new Size(123, 15);
            labelInfoOne.TabIndex = 1;
            labelInfoOne.Text = "Информация об АТД";
            // 
            // textBoxInfoOne
            // 
            textBoxInfoOne.Location = new Point(3, 23);
            textBoxInfoOne.Multiline = true;
            textBoxInfoOne.Name = "textBoxInfoOne";
            textBoxInfoOne.Size = new Size(333, 126);
            textBoxInfoOne.TabIndex = 0;
            textBoxInfoOne.Text = resources.GetString("textBoxInfoOne.Text");
            // 
            // panelThree
            // 
            panelThree.Controls.Add(labelStart);
            panelThree.Controls.Add(textBoxResultThree);
            panelThree.Controls.Add(buttonResultThree);
            panelThree.Controls.Add(textBoxLineOne);
            panelThree.Controls.Add(textBoxInfoThree);
            panelThree.Controls.Add(labelInfoThree);
            panelThree.Dock = DockStyle.Right;
            panelThree.Location = new Point(649, 0);
            panelThree.Name = "panelThree";
            panelThree.Size = new Size(316, 450);
            panelThree.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(19, 174);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(149, 15);
            labelStart.TabIndex = 6;
            labelStart.Text = "С какой вершины начать:";
            // 
            // textBoxResultThree
            // 
            textBoxResultThree.Location = new Point(6, 258);
            textBoxResultThree.Multiline = true;
            textBoxResultThree.Name = "textBoxResultThree";
            textBoxResultThree.Size = new Size(307, 189);
            textBoxResultThree.TabIndex = 5;
            // 
            // buttonResultThree
            // 
            buttonResultThree.Location = new Point(6, 211);
            buttonResultThree.Name = "buttonResultThree";
            buttonResultThree.Size = new Size(307, 41);
            buttonResultThree.TabIndex = 4;
            buttonResultThree.Text = "Результат";
            buttonResultThree.UseVisualStyleBackColor = true;
            buttonResultThree.Click += buttonResultThree_Click;
            // 
            // textBoxLineOne
            // 
            textBoxLineOne.Location = new Point(171, 171);
            textBoxLineOne.Name = "textBoxLineOne";
            textBoxLineOne.Size = new Size(142, 23);
            textBoxLineOne.TabIndex = 2;
            // 
            // textBoxInfoThree
            // 
            textBoxInfoThree.Location = new Point(3, 23);
            textBoxInfoThree.Multiline = true;
            textBoxInfoThree.Name = "textBoxInfoThree";
            textBoxInfoThree.Size = new Size(310, 126);
            textBoxInfoThree.TabIndex = 1;
            textBoxInfoThree.Text = "Обход в ширину - это метод обхода графа, начиная с заданной вершины (начальной точки), поочередно посещая все смежные вершины на текущем уровне перед тем, как переходить к вершинам следующего уровня.";
            // 
            // labelInfoThree
            // 
            labelInfoThree.AutoSize = true;
            labelInfoThree.Location = new Point(81, 5);
            labelInfoThree.Name = "labelInfoThree";
            labelInfoThree.Size = new Size(160, 15);
            labelInfoThree.TabIndex = 0;
            labelInfoThree.Text = "Информация об алгоритме";
            // 
            // panelTwo
            // 
            panelTwo.Controls.Add(textBoxInput);
            panelTwo.Controls.Add(buttonBack);
            panelTwo.Controls.Add(textBoxStepTwo);
            panelTwo.Controls.Add(buttonStep);
            panelTwo.Controls.Add(textBoxResultTwo);
            panelTwo.Controls.Add(buttonResultTwo);
            panelTwo.Controls.Add(labelInfoTwo);
            panelTwo.Controls.Add(textBoxInfoTwo);
            panelTwo.Dock = DockStyle.Fill;
            panelTwo.Location = new Point(339, 0);
            panelTwo.Name = "panelTwo";
            panelTwo.Size = new Size(310, 450);
            panelTwo.TabIndex = 2;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(6, 158);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(300, 23);
            textBoxInput.TabIndex = 8;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(158, 280);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(149, 40);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxStepTwo
            // 
            textBoxStepTwo.Location = new Point(6, 326);
            textBoxStepTwo.Multiline = true;
            textBoxStepTwo.Name = "textBoxStepTwo";
            textBoxStepTwo.Size = new Size(298, 60);
            textBoxStepTwo.TabIndex = 6;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(6, 280);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(149, 40);
            buttonStep.TabIndex = 5;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // textBoxResultTwo
            // 
            textBoxResultTwo.Location = new Point(6, 392);
            textBoxResultTwo.Multiline = true;
            textBoxResultTwo.Name = "textBoxResultTwo";
            textBoxResultTwo.Size = new Size(298, 55);
            textBoxResultTwo.TabIndex = 4;
            // 
            // buttonResultTwo
            // 
            buttonResultTwo.Location = new Point(6, 187);
            buttonResultTwo.Name = "buttonResultTwo";
            buttonResultTwo.Size = new Size(298, 41);
            buttonResultTwo.TabIndex = 3;
            buttonResultTwo.Text = "Сортировка";
            buttonResultTwo.UseVisualStyleBackColor = true;
            buttonResultTwo.Click += buttonResultTwo_Click;
            // 
            // labelInfoTwo
            // 
            labelInfoTwo.AutoSize = true;
            labelInfoTwo.Location = new Point(70, 5);
            labelInfoTwo.Name = "labelInfoTwo";
            labelInfoTwo.Size = new Size(158, 15);
            labelInfoTwo.TabIndex = 1;
            labelInfoTwo.Text = "Информация о сортировке";
            // 
            // textBoxInfoTwo
            // 
            textBoxInfoTwo.Location = new Point(3, 23);
            textBoxInfoTwo.Multiline = true;
            textBoxInfoTwo.Name = "textBoxInfoTwo";
            textBoxInfoTwo.Size = new Size(304, 126);
            textBoxInfoTwo.TabIndex = 0;
            textBoxInfoTwo.Text = resources.GetString("textBoxInfoTwo.Text");
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 450);
            Controls.Add(panelTwo);
            Controls.Add(panelThree);
            Controls.Add(panelOne);
            Name = "Form2";
            Text = "Практика 2";
            panelOne.ResumeLayout(false);
            panelOne.PerformLayout();
            panelThree.ResumeLayout(false);
            panelThree.PerformLayout();
            panelTwo.ResumeLayout(false);
            panelTwo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOne;
        private Panel panelThree;
        private Panel panelTwo;
        private Label labelInfoOne;
        private TextBox textBoxInfoOne;
        private Button buttonRemoveCount;
        private Button buttonAddCount;
        private Button buttonResultOne;
        private TextBox textBoxResultOne;
        private TextBox textBoxInfoTwo;
        private Label labelInfoTwo;
        private Button buttonResultTwo;
        private TextBox textBoxResultTwo;
        private Button buttonStep;
        private Label labelInfoThree;
        private TextBox textBoxInfoThree;
        private TextBox textBoxLineOne;
        private Button buttonResultThree;
        private TextBox textBoxResultThree;
        private Button buttonRemoveEnd;
        private Button buttonAddEnd;
        private Label labelStart;
        private TextBox textBoxStepTwo;
        private Button buttonBack;
        private TextBox textBoxInput;
    }
}