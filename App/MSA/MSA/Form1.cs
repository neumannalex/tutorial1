using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSA
{
    public partial class Form1 : Form
    {
        private MSA _msa;

        public Form1()
        {
            InitializeComponent();

            _msa = new MSA();
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();

            var rnd = new Random();
            var n = rnd.Next(10, 100);
            
            var mean = 10.0;
            var sigma = 0.5;

            if (!double.TryParse(txtRndMean.Text, out mean))
                mean = 10.0;

            if (!double.TryParse(txtRndStdDev.Text, out sigma))
                sigma = 0.5;

            var items = GetRandomNumbers(n, mean, sigma);

            foreach (var item in items)
                lstData.Items.Add(item);
        }

        private List<double> GetRandomNumbers(int length, double mean, double sigma)
        {
            var items = new List<double>();
            var rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                double r1 = 1.0 - rnd.NextDouble();
                double r2 = 1.0 - rnd.NextDouble();
                double s = Math.Sqrt(-2.0 * Math.Log(r1)) * Math.Sin(2.0 * Math.PI * r2);
                items.Add(mean + sigma * s);
            }

            return items;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double expectedValue;
            double lowerLimitValue;
            double upperLimitValue;
            List<double> data;

            if(!double.TryParse(txtErwartungswert.Text, out expectedValue))
            {
                ShowError("No expected value given.");
                return;
            }

            if (!double.TryParse(txtOSG.Text, out upperLimitValue))
            {
                ShowError("No upper limit value given.");
                return;
            }

            if (!double.TryParse(txtUSG.Text, out lowerLimitValue))
            {
                ShowError("No lower limit value given.");
                return;
            }

            try
            {
                data = lstData.Items.Cast<double>().ToList();
            }
            catch
            {
                ShowError("Invalid data given.");
                return;
            }

            var msa = new MSA(expectedValue, upperLimitValue, lowerLimitValue, data);

            propertyGrid1.SelectedObject = msa;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
