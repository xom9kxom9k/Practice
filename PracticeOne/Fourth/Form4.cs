using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOne.Fourth
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDownCount.Value;
            int maxCount = 15000;
            double yearUp = 0.05;
            double twoYearDown = 0.06;

            for (int i = 1; maxCount - count > 0 ; i++)
            {
                dataGridView1.Rows.Add(i, count, " ", " ", " ");
                double plus = count * yearUp;
                dataGridView1.Rows.Add(i, " ", plus, " ", " ");
                count += (int)plus;
                dataGridView1.Rows.Add(i, " ", " ", " ", maxCount - count);

                if (i % 2 == 0)
                {
                    double minus = count * twoYearDown;
                    count -= (int)minus;
                    dataGridView1.Rows.Add(i, " ", " " , minus, " ");
                    dataGridView1.Rows.Add(i, " ", " ", " ", maxCount - count);
                }
                
            }

        }
    }
}
