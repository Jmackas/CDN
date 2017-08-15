using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintEstimator
{

    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolveValues_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaration of top two input fields
                int paintArea, paintPrice;

                // Declaration of output variables;
                int paintRequired, laborHours, paintCost, laborCost, overallCost;

                // Input values of inputPaintArea assigned to paintArea
                paintArea = int.Parse(inputPaintArea.Text);

                // Input values of inputPaintPrice assigned to paintPrice
                paintPrice = int.Parse(inputPaintPrice.Text);

                // Preliminary data validation

                    // Ensuring that a number is positive
                    if (!(paintArea > 0 && paintPrice > 0))
                    {
                        MessageBox.Show("You can't have a negative amount");
                    }

                    


                // Algorithm for 'Paint Required for the Job'

                // Formula
                paintRequired = paintArea * paintPrice;
                    
                    // Output
                    outputPaintRequired.Text = paintRequired.ToString();


                // Algorithm for 'The hours of labor required'
                    // Formula
                        laborHours = paintArea + paintPrice;

                    // Output
                    outputLaborHours.Text = laborHours.ToString();


                // Algorithm for 'The cost of the paint'
                    // Formula
                    paintCost = paintArea - paintPrice;

                    // Output
                    outputPaintCost.Text = paintCost.ToString();

                // Algorithm for 'The labor charges'
                    // Formula
                    laborCost = paintArea / paintPrice;

                    // Output
                    outputLaborCost.Text = laborCost.ToString();


                // Algorithm for 'The labor charges'
                    // Formula
                    overallCost = paintArea % paintPrice;

                    // Output
                    outputOverallCost.Text = overallCost.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an Error");
            }

        }
    }
}
