using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double conversionAnswer;
        private void convertButton_Click(object sender, EventArgs e)
        {
            int conversionChoice = Convert.ToInt32(choiceBox.Text);

            int conversionValue = Convert.ToInt32(conversionBox.Text);

            

            

            if (conversionChoice == 1)
            {
                InchesToCm(conversionValue);

                convertLabel.Text = $"{conversionValue} Inches to {conversionAnswer} Centimetres";
            }
            else if (conversionChoice == 2)
            {
                FeetToCm(conversionValue);

                convertLabel.Text = $"{conversionValue} Feet to {conversionAnswer} Centimetres";
            }
            else if (conversionChoice == 3)
            {
                YardsToMetres(conversionValue);

                convertLabel.Text = $"{conversionValue} Yards to {conversionAnswer} Metres";
            }
            else if (conversionChoice == 4)
            {
                MilesToKm(conversionValue);

                convertLabel.Text = $"{conversionValue} Miles to {conversionAnswer} Kilometres";
            }
            
        }
        public double InchesToCm(int conversionValue)
        {
            conversionAnswer = conversionValue * 2.54;

            return conversionAnswer;
        }
        public double FeetToCm(int conversionValue)
        {
            conversionAnswer = conversionValue * 30.48;

            return conversionAnswer;
        }
        public double YardsToMetres(int conversionValue)
        {
            conversionAnswer = conversionValue * 0.91;

            return conversionAnswer;
        }
        public double MilesToKm(int conversionValue)
        {
            conversionAnswer = conversionValue * 1.6;

            return conversionAnswer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
