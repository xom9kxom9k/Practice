using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeOne
{
    public partial class Form1 : Form
    {
        private int colsCount = 1;
        private int rowsCount = 1;
        private int minValue = -1;
        private int maxValue = 1;
        private int[] arrayOne;
        private int[,] arrayTwo;
        private int currentTask = 0;
        public Form1()
        {
            InitializeComponent();
            arrayOne = new int[colsCount];
            arrayTwo = new int[rowsCount, colsCount];
        }
        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            colsCount = (int)numericUpDownCols.Value;
            arrayOne = new int[colsCount];
            arrayTwo = new int[rowsCount, colsCount];
        }
        private void numericUpDownRow_ValueChanged(object sender, EventArgs e)
        {
            rowsCount = (int)numericUpDownRow.Value;
            arrayTwo = new int[rowsCount, colsCount];
        }
        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            minValue = (int)numericUpDownMin.Value;
        }
        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            maxValue = (int)numericUpDownMax.Value;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный одномерный массив размера N. Серия – это\r\nпоследовательность элементов массива, идущих друг за другом.\r\nКаждый элемент серии больше предыдущего. Серия должна содержать\r\nминимум 2 элемента. Длина серии – количество элементов в серии.\r\nНайти все серии. Вывести информацию с указанием длины для каждой\r\nсерий исходного массива.";
            currentTask = 1;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = true;
            buttonTwoArray.Enabled = false;
            numericUpDownRow.Enabled = false;
            textBoxResult.Clear();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный одномерный массив размера N. Переставить в\r\nобратном порядке элементы массива, расположенные между первым\r\nотрицательным и последним положительным";
            currentTask = 2;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = true;
            buttonTwoArray.Enabled = false;
            numericUpDownRow.Enabled = false;
            textBoxResult.Clear();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный одномерный массив размера N. Вставить 3 после\r\nкаждого нечетного элемента массива (нечетный по значению, а не по\r\nпорядковому номеру).";
            currentTask = 3;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = true;
            buttonTwoArray.Enabled = false;
            numericUpDownRow.Enabled = false;
            textBoxResult.Clear();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный одномерный массив размера N. Удалить из массива\r\nвсе нечетные элементы (нечетный по значению, а не по порядковому\r\nномеру).\r\n";
            currentTask = 4;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = true;
            buttonTwoArray.Enabled = false;
            numericUpDownRow.Enabled = false;
            textBoxResult.Clear();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный двумерный массив размера N*N. Добавить в массив\r\nстроку 0 после каждой строки, в которой есть хотя бы один элемент,\r\nменьший по модулю среднего арифметического элементов массива.\r\n";
            currentTask = 5;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = false;
            buttonTwoArray.Enabled = true;
            numericUpDownRow.Enabled = true;
            textBoxResult.Clear();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Дан целочисленный двумерный массив размера N*N. Упорядочить\r\nэлементы в матрице по возрастанию (справа налево, снизу-вверх)\r\nПример\r\n1 3 6\r\n4 9 7\r\n0 5 3\r\nпосле сортировки:\r\n9 7 6\r\n5 4 3\r\n3 1 0";
            currentTask = 6;
            panelArray.Enabled = true;
            buttonOneArray.Enabled = false;
            buttonTwoArray.Enabled = true;
            numericUpDownRow.Enabled = true;
            textBoxResult.Clear();
        }

        private void buttonOneArray_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (currentTask == 3)
            {
                arrayOne = new int[colsCount * 2];
            }

            for (int i = 0; i < colsCount; i++)
            {
                arrayOne[i] = random.Next(minValue, maxValue);
            }

            textBoxArray.Text = string.Join(", ", arrayOne);

            buttonStart.Enabled = true;
        }

        private void buttonTwoArray_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (currentTask == 5)
            {
                arrayTwo = new int[rowsCount * 2, colsCount];

                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < colsCount; j++)
                    {
                        arrayTwo[i, j] = rand.Next(minValue, maxValue);
                    }
                }
            }
            else
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < colsCount; j++)
                    {
                        arrayTwo[i, j] = rand.Next(minValue, maxValue);
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    sb.Append(arrayTwo[i, j].ToString() + ", ");
                }
                sb.AppendLine();
            }
            textBoxArray.Text = sb.ToString();

            buttonStart.Enabled = true;
        }
        private void buttonAddOneArray_Click(object sender, EventArgs e)
        {
            textBoxArray.Clear();
            string input = textBoxInput.Text;
            string[] numbers = input.Split(' ');
            colsCount = numbers.Length;
            if (currentTask == 3)
            { 
                arrayOne = new int[colsCount * 2];
            }
            else
            {
                arrayOne = new int[colsCount];
            }
            for (int i = 0; i < colsCount; i++)
            {
                if (int.TryParse(numbers[i], out int number))
                {
                    arrayOne[i] = number;
                }
                else
                {
                    MessageBox.Show("Ошибка ввода чисел!");
                    return;
                }
            }
            textBoxArray.Text = string.Join(", ", arrayOne);
        }

        private void buttonAddTwoArray_Click(object sender, EventArgs e)
        {
            textBoxArray.Clear();
            string input = textBoxInput.Text;
            string[] rows = input.Split(';');
            rowsCount = rows.Length;
            colsCount = rows[0].Split(' ').Length;
            if (currentTask == 5)
            {
                arrayTwo = new int[rowsCount * 2, colsCount];
            }
            else
            {
                arrayTwo = new int[rowsCount, colsCount];   
            }
            for (int i = 0; i < rowsCount; i++)
            {
                string[] numbers = rows[i].Split(' ');

                for (int j = 0; j < colsCount; j++)
                {
                    if (int.TryParse(numbers[j], out int number))
                    {
                        arrayTwo[i, j] = number;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка ввода чисел!");
                        return;
                    }
                }
            }
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    textBoxArray.Text += arrayTwo[i, j].ToString() + " ";
                }
                textBoxArray.Text += Environment.NewLine;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch (currentTask)
            {
                case 1:
                    int maxLength = 0;
                    int maxStartIndex = -1;
                    int currentStartIndex = 0;
                    int currentLength = 1;

                    for (int i = 1; i < arrayOne.Length; i++)
                    {
                        if (arrayOne[i] > arrayOne[i - 1])
                        {
                            currentLength++;
                        }
                        else
                        {
                            if (currentLength > maxLength)
                            {
                                maxLength = currentLength;
                                maxStartIndex = currentStartIndex;
                            }
                            currentStartIndex = i;
                            currentLength = 1;
                        }
                    }

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }

                    if (maxLength < 2)
                    {
                        textBoxResult.Text = "!Серий не найдено!";
                    }
                    else
                    {
                        textBoxResult.Text = "Серия начинается с позиции: " + maxStartIndex.ToString() + " \n\n\rЕе длина: " + maxLength.ToString();
                    }

                    break;
                case 2:
                    if (arrayOne.Length < 2)
                    {
                        textBoxResult.Text = "!Размер слишком маленький!";
                        break;
                    }

                    int negIndex = -1;
                    int posIndex = -1;

                    for (int i = 0; i < arrayOne.Length; i++)
                    {
                        if (arrayOne[i] > 0) posIndex = arrayOne[i];
                    }
                    for (int i = arrayOne.Length - 1; i >= 0; i--)
                    {
                        if (arrayOne[i] < 0) negIndex = arrayOne[i];
                    }

                    if (negIndex > posIndex)
                    {
                        int temp = negIndex;
                        negIndex = posIndex;
                        posIndex = temp;
                    }

                    while (negIndex < posIndex)
                    {
                        int temp = arrayOne[negIndex + 1];
                        arrayOne[negIndex + 1] = arrayOne[posIndex - 1];
                        arrayOne[posIndex - 1] = temp;
                        negIndex++;
                        posIndex--;
                    }

                    textBoxResult.Text = string.Join(", ", arrayOne);

                    break;
                case 3:
                    int n = arrayOne.Length;

                    for (int i = n - 1; i >= 0; i--)
                    {
                        if (arrayOne[i] % 2 != 0 && arrayOne[i] != 0)
                        {
                            for (int j = arrayOne.Length - 1; j > i + 1; j--)
                            {
                                arrayOne[j] = arrayOne[j - 1];
                            }

                            if (i + 1 < n)
                            {
                                arrayOne[i + 1] = 3;
                            }
                        }
                    }

                    textBoxResult.Text = string.Join(", ", arrayOne);

                    break;
                case 4:
                    n = arrayOne.Length;
                    int newLength = n;

                    for (int i = 0; i < newLength; i++)
                    {
                        if (arrayOne[i] % 2 != 0)
                        {
                            for (int j = i; j < newLength - 1; j++)
                            {
                                arrayOne[j] = arrayOne[j + 1];
                            }
                            newLength--;
                            i--;
                        }
                    }

                    textBoxResult.Clear();
                    for (int i = 0; i < newLength; i++)
                    {
                        textBoxResult.Text += arrayOne[i].ToString() + ", ";
                    }

                    break;
                case 5:
                    n = rowsCount;
                    int m = colsCount;
                    int count = 0;
                    int SrArifm = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            SrArifm += arrayTwo[i, j];
                            count++;
                        }
                    }

                    SrArifm = SrArifm / count;

                    for (int i = 0; i < n; i++)
                    {
                        count = 0;
                        for (int j = 0; j < m; j++)
                        {
                            if (arrayTwo[i, j] != 0)
                            {
                                if (Math.Abs(arrayTwo[i, j]) < SrArifm)
                                {
                                    count++;
                                }
                            }
                        }
                        if (count > 0)
                        {
                            for (int k = n; k > i + 1; k--)
                            {
                                for (int l = 0; l < m; l++)
                                {
                                    arrayTwo[k, l] = arrayTwo[k - 1, l];
                                }
                            }
                            for (int l = 0; l < m; l++)
                            {
                                arrayTwo[i + 1, l] = 1;
                            }
                            n++;
                            i++;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            textBoxResult.Text += arrayTwo[i, j].ToString() + " ";
                        }
                        textBoxResult.Text += Environment.NewLine;
                    } 
                    break;
                case 6:
                    for (int i = 0; i < arrayTwo.GetLength(0); i++)
                    {
                        for (int j = 0; j < arrayTwo.GetLength(1); j++)
                        {
                            for (int x = 0; x < arrayTwo.GetLength(0); x++)
                            {
                                for (int y = 0; y < arrayTwo.GetLength(1); y++)
                                {
                                    if (arrayTwo[i, j] > arrayTwo[x, y])
                                    {
                                        int zam = arrayTwo[i, j];
                                        arrayTwo[i, j] = arrayTwo[x, y];
                                        arrayTwo[x, y] = zam;
                                    }   
                                }
                            }
                        }
                    }
                    n = rowsCount;
                    m = colsCount;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            textBoxResult.Text += arrayTwo[i, j].ToString() + " ";
                        }
                        textBoxResult.Text += Environment.NewLine;
                    }
                    break;
            }
        }
    }
}