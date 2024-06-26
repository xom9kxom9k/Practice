using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeOne.Second
{
    public partial class Form2 : Form
    {
        Deck deck = new();
        int[] arr = new int[10];


        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAddCount_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            deck.AddFirst(rnd.Next(-100, 100));
        }

        private void buttonAddEnd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            deck.AddLast(rnd.Next(-100, 100));
        }

        private void buttonRemoveCount_Click(object sender, EventArgs e) => deck.RemoveFirst();

        private void buttonRemoveEnd_Click(object sender, EventArgs e) => deck.RemoveLast();

        private void buttonResultOne_Click(object sender, EventArgs e) => textBoxResultOne.Text = deck.Print();

        private void PrintArray()
        {
            string text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i] + " ";
            }
            textBoxResultTwo.Text = text + Environment.NewLine;

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxResultTwo.Clear();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
            PrintArray();
        }
        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    PrintArray(arr);
                }
            }
            Swap(arr, i + 1, high);
            PrintArray(arr);

            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        private void PrintArray(int[] arr)
        {
            textBoxResultTwo.AppendText(string.Join(" ", arr) + Environment.NewLine);
        }

        private void buttonResultTwo_Click(object sender, EventArgs e)
        {
            QuickSort(arr, 0, arr.Length - 1);
            textBoxResultTwo.Text = string.Join(" ", arr);
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }


        public void buttonResultThree_Click(object sender, EventArgs e)
        {
            textBoxResultThree.Clear();
            int count = int.Parse(textBoxLineOne.Text);
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    int hasEdge = random.Next(0, 2);
                    array[i, j] = hasEdge;
                    array[j, i] = hasEdge;
                }
            }
            Graph graph = new Graph(array);
            graph.BFS(count);
            StringBuilder sb = new StringBuilder();
            StringBuilder sd = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sb.Append(array[i, j].ToString() + " ");
                }
                sb.AppendLine();
            }

            for (int i = 0; i < graph.ints.GetLength(0); i++)
            {
                sd.Append(graph.ints[i].ToString() + " ");
            }
            textBoxResultThree.Text = sb.ToString() + Environment.NewLine + sd.ToString();
        }
    }
}
