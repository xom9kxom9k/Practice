using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PracticeOne.Fifth
{
    public partial class Form5 : Form
    {
        private readonly ILogger _logger;
        public Form5(ILogger<Form5> logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Вычисление S");
                double x = double.Parse(textBoxInput.Text);
                textBoxY.Text = (  0.5 - (Math.PI/4 * Math.Abs(Math.Sin(x)))   ).ToString();
                _logger.LogInformation("Y вычислилось");
                double result = 0;
                for (double i = 1; i <= 50; i++)
                {
                    result += (Math.Cos(x * i * 2)) / (Math.Pow(i * 2, 2) - 1);
                    _logger.LogInformation("Новый результат : " + result);
                }
                _logger.LogInformation("Ответ : " + result);
                textBoxX.Text = result.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
