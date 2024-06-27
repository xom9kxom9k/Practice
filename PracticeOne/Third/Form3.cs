using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOne.Third
{
    public partial class Form3 : Form
    {
        List<ObjectTable> objects = new();
        List<Figure> figures = new();
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectTable obj = new ObjectTable(double.Parse(textBoxHigh.Text), double.Parse(textBoxLength.Text), textBoxColor.Text, textBoxMaterial.Text);
                objects.Add(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            for (int i = 0; i < objects.Count; i++)
            {
                listBoxResult.Items.Add(objects[i].ToString());
            }
        }



        private void buttonCreateRectangle_Click(object sender, EventArgs e)
        {
            Rectangle figure = new Rectangle(double.Parse(textBoxL.Text), double.Parse(textBoxH.Text));
            figures.Add(figure);
            listBoxObjects.Items.Add(figure);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Cyrcle figure = new Cyrcle(double.Parse(textBoxL.Text), double.Parse(textBoxH.Text));
            figures.Add(figure);
            listBoxObjects.Items.Add(figure);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is Cyrcle fig)
            {
                fig.Draw(pictureBoxDraw, fig);
            }
            else if (listBoxObjects.SelectedItem is Rectangle rec)
            {
                rec.Draw(pictureBoxDraw, rec);
            }
        }



        private void buttonDiff_Click(object sender, EventArgs e)
        {
            
        }
    }
}
