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

namespace PracticeOne.Second
{
    public partial class Form2 : Form
    {
        Deck deck = new();
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
    }
}
