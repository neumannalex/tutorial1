using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSA
{
    public class MSA
    {
        public List<double> Data { get; set; } = new List<double>();
        public Double ExpectedValue { get; set; }
        public Double LowerLimitValue { get; set; }
        public Double UpperLimitValue { get; set; }



        public int Count
        {
            get
            {
                if (Data is null)
                    return 0;

                return Data.Count();
            }
        }

        public double Average
        {
            get
            {
                if (Data is null)
                    throw new ArgumentNullException("Data list must not be null.");

                double sum = 0;
                foreach (var item in Data)
                    sum += item;

                int n = Count;
                if (n == 0)
                    throw new DivideByZeroException("Number of items in data list must be greater than zero.");

                var avg = sum / (double)n;

                return avg;
            }
        }

        public double StandardDeviation
        {
            get
            {
                if (Data is null)
                    throw new ArgumentNullException("Data list must not be null.");

                int n = Count;
                if (n < 1)
                    throw new DivideByZeroException("Number of items in data list must be greater than 1.");

                double xg = 0;
                try
                {
                    xg = Average;
                    double sum = 0;

                    foreach (var xi in Data)
                        sum += Math.Pow(xi - xg, 2);

                    double v = sum / (double)(n - 1);

                    if (v < 0)
                        throw new ArgumentOutOfRangeException("Cannot take square root of a negative value.");

                    double sigma = Math.Sqrt(v);
                    return sigma;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public double Cg
        {
            get
            {
                try
                {
                    double rf = UpperLimitValue - LowerLimitValue;
                    double sigma = StandardDeviation;

                    if (sigma == 0)
                        throw new DivideByZeroException();

                    double cg = 0.2 * rf / (6 * sigma);

                    return cg;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public double Cgk
        {
            get
            {
                try
                {
                    double rf = UpperLimitValue - LowerLimitValue;
                    double sigma = StandardDeviation;
                    double xg = Average;

                    if (sigma == 0)
                        throw new DivideByZeroException();

                    double cgk = (0.1 * rf - Math.Abs(ExpectedValue - xg)) / (3 * sigma);

                    return cgk;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public MSA()
        {

        }

        public MSA(double expectedValue, double upperLimitValue, double lowerLimitValue, List<double> data)
        {
            ExpectedValue = expectedValue;
            UpperLimitValue = upperLimitValue;
            LowerLimitValue = lowerLimitValue;
            Data = data;
        }
    }
}
