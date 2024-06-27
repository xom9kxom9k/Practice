namespace PracticeOne.Third
{
    partial class Form3
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
            tabControlTasks = new TabControl();
            tabPage1 = new TabPage();
            listBoxResult = new ListBox();
            buttonView = new Button();
            labelNote = new Label();
            buttonCreate = new Button();
            labelMaterial = new Label();
            labelColor = new Label();
            labelLength = new Label();
            labelInfoHigh = new Label();
            textBoxMaterial = new TextBox();
            textBoxColor = new TextBox();
            textBoxLength = new TextBox();
            textBoxHigh = new TextBox();
            labelInfo = new Label();
            tabPage2 = new TabPage();
            pictureBoxDraw = new PictureBox();
            buttonDraw = new Button();
            buttonCircle = new Button();
            buttonCreateRectangle = new Button();
            listBoxObjects = new ListBox();
            label2 = new Label();
            label1 = new Label();
            textBoxH = new TextBox();
            textBoxL = new TextBox();
            tabPage3 = new TabPage();
            textBoxOne = new TextBox();
            textBoxTwo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxResultThree = new TextBox();
            buttonDiff = new Button();
            tabControlTasks.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlTasks
            // 
            tabControlTasks.Controls.Add(tabPage1);
            tabControlTasks.Controls.Add(tabPage2);
            tabControlTasks.Controls.Add(tabPage3);
            tabControlTasks.Dock = DockStyle.Fill;
            tabControlTasks.Location = new Point(0, 0);
            tabControlTasks.Name = "tabControlTasks";
            tabControlTasks.SelectedIndex = 0;
            tabControlTasks.Size = new Size(800, 450);
            tabControlTasks.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxResult);
            tabPage1.Controls.Add(buttonView);
            tabPage1.Controls.Add(labelNote);
            tabPage1.Controls.Add(buttonCreate);
            tabPage1.Controls.Add(labelMaterial);
            tabPage1.Controls.Add(labelColor);
            tabPage1.Controls.Add(labelLength);
            tabPage1.Controls.Add(labelInfoHigh);
            tabPage1.Controls.Add(textBoxMaterial);
            tabPage1.Controls.Add(textBoxColor);
            tabPage1.Controls.Add(textBoxLength);
            tabPage1.Controls.Add(textBoxHigh);
            tabPage1.Controls.Add(labelInfo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(285, 80);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(485, 184);
            listBoxResult.TabIndex = 14;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(285, 276);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(485, 23);
            buttonView.TabIndex = 13;
            buttonView.Text = "Показать все предметы";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(285, 58);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(113, 15);
            labelNote.TabIndex = 12;
            labelNote.Text = "Список предметов:";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(8, 345);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(187, 41);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Создать объект";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(8, 270);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(65, 15);
            labelMaterial.TabIndex = 9;
            labelMaterial.Text = "Материал:";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(8, 204);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(36, 15);
            labelColor.TabIndex = 8;
            labelColor.Text = "Цвет:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(8, 133);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(45, 15);
            labelLength.TabIndex = 7;
            labelLength.Text = "Длина:";
            // 
            // labelInfoHigh
            // 
            labelInfoHigh.AutoSize = true;
            labelInfoHigh.Location = new Point(8, 58);
            labelInfoHigh.Name = "labelInfoHigh";
            labelInfoHigh.Size = new Size(50, 15);
            labelInfoHigh.TabIndex = 6;
            labelInfoHigh.Text = "Высота:";
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(8, 288);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(187, 23);
            textBoxMaterial.TabIndex = 5;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(8, 222);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(187, 23);
            textBoxColor.TabIndex = 4;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(8, 151);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(187, 23);
            textBoxLength.TabIndex = 3;
            // 
            // textBoxHigh
            // 
            textBoxHigh.Location = new Point(8, 76);
            textBoxHigh.Name = "textBoxHigh";
            textBoxHigh.Size = new Size(187, 23);
            textBoxHigh.TabIndex = 2;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(8, 16);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(120, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Описание предмета:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBoxDraw);
            tabPage2.Controls.Add(buttonDraw);
            tabPage2.Controls.Add(buttonCircle);
            tabPage2.Controls.Add(buttonCreateRectangle);
            tabPage2.Controls.Add(listBoxObjects);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBoxH);
            tabPage2.Controls.Add(textBoxL);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDraw
            // 
            pictureBoxDraw.Location = new Point(352, 6);
            pictureBoxDraw.Name = "pictureBoxDraw";
            pictureBoxDraw.Size = new Size(434, 408);
            pictureBoxDraw.TabIndex = 8;
            pictureBoxDraw.TabStop = false;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(20, 238);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(326, 23);
            buttonDraw.TabIndex = 7;
            buttonDraw.Text = "Отрисовать";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(20, 182);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(128, 36);
            buttonCircle.TabIndex = 6;
            buttonCircle.Text = "Создать круг";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonCreateRectangle
            // 
            buttonCreateRectangle.Location = new Point(20, 132);
            buttonCreateRectangle.Name = "buttonCreateRectangle";
            buttonCreateRectangle.Size = new Size(128, 39);
            buttonCreateRectangle.TabIndex = 5;
            buttonCreateRectangle.Text = "Создать прямоугольник";
            buttonCreateRectangle.UseVisualStyleBackColor = true;
            buttonCreateRectangle.Click += buttonCreateRectangle_Click;
            // 
            // listBoxObjects
            // 
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 15;
            listBoxObjects.Location = new Point(169, 6);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(177, 214);
            listBoxObjects.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Ширина:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Длина:";
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(20, 91);
            textBoxH.Name = "textBoxH";
            textBoxH.Size = new Size(128, 23);
            textBoxH.TabIndex = 1;
            // 
            // textBoxL
            // 
            textBoxL.Location = new Point(20, 32);
            textBoxL.Name = "textBoxL";
            textBoxL.Size = new Size(128, 23);
            textBoxL.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonDiff);
            tabPage3.Controls.Add(textBoxResultThree);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(textBoxTwo);
            tabPage3.Controls.Add(textBoxOne);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxOne
            // 
            textBoxOne.Location = new Point(18, 25);
            textBoxOne.Name = "textBoxOne";
            textBoxOne.Size = new Size(100, 23);
            textBoxOne.TabIndex = 0;
            // 
            // textBoxTwo
            // 
            textBoxTwo.Location = new Point(18, 75);
            textBoxTwo.Name = "textBoxTwo";
            textBoxTwo.Size = new Size(100, 23);
            textBoxTwo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 7);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Делимое";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 57);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Делитель";
            // 
            // textBoxResultThree
            // 
            textBoxResultThree.Location = new Point(18, 154);
            textBoxResultThree.Name = "textBoxResultThree";
            textBoxResultThree.Size = new Size(100, 23);
            textBoxResultThree.TabIndex = 4;
            // 
            // buttonDiff
            // 
            buttonDiff.Location = new Point(18, 114);
            buttonDiff.Name = "buttonDiff";
            buttonDiff.Size = new Size(100, 23);
            buttonDiff.TabIndex = 5;
            buttonDiff.Text = "Разность";
            buttonDiff.UseVisualStyleBackColor = true;
            buttonDiff.Click += buttonDiff_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlTasks);
            Name = "Form3";
            Text = "Практика 3";
            tabControlTasks.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDraw).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTasks;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBoxMaterial;
        private TextBox textBoxColor;
        private TextBox textBoxLength;
        private TextBox textBoxHigh;
        private Label labelInfo;
        private Label labelMaterial;
        private Label labelColor;
        private Label labelLength;
        private Label labelInfoHigh;
        private Button buttonCreate;
        private Label labelNote;
        private Button buttonView;
        private ListBox listBoxResult;
        private Button buttonCircle;
        private Button buttonCreateRectangle;
        private ListBox listBoxObjects;
        private Label label2;
        private Label label1;
        private TextBox textBoxH;
        private TextBox textBoxL;
        private Button buttonDraw;
        private PictureBox pictureBoxDraw;
        private TextBox textBoxTwo;
        private TextBox textBoxOne;
        private Button buttonDiff;
        private TextBox textBoxResultThree;
        private Label label4;
        private Label label3;
    }
}