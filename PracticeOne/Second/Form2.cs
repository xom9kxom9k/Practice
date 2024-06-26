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
        private int[] array1D;
        private List<int[]> quickSteps = new List<int[]>();
        private int currentStep = -1;

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


        private void QuickSort(int[] arr, int low, int high, Form2 mainInstance)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, mainInstance);

                QuickSort(arr, low, pi - 1, mainInstance);
                QuickSort(arr, pi + 1, high, mainInstance);
            }
        }

        private int Partition(int[] arr, int low, int high, Form2 mainInstance)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    mainInstance.quickSteps.Add(arr.ToArray());
                }
            }
            Swap(arr, i + 1, high);
            mainInstance.quickSteps.Add(arr.ToArray());
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        private void buttonResultTwo_Click(object sender, EventArgs e)
        {
            string[] massive = textBoxInput.Text.Split();
            array1D = new int[massive.Length];

            if (massive.Length > 0)
            {
                for (int i = 0; i < massive.Length; i++)
                {
                    array1D[i] = Int32.Parse(massive[i]);
                }
            }

            quickSteps.Clear();
            currentStep = -1;
            QuickSort(array1D, 0, array1D.Length - 1, this);

            textBoxResultTwo.Text = string.Join(", ", array1D);
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (currentStep < quickSteps.Count - 1)
            {
                currentStep++;
                ShowCurrentStep();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentStep > -1)
            {
                currentStep--;
                ShowCurrentStep();
            }
        }
        private void ShowCurrentStep()
        {
            if (currentStep >= 0 && currentStep < quickSteps.Count)
            {
                textBoxStepTwo.Text = string.Join(" ", quickSteps[currentStep]);
            }
            else
            {
                textBoxStepTwo.Text = string.Join(" ", array1D);
            }
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
