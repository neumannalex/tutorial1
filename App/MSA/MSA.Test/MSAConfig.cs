using System;
using System.Collections.Generic;
using System.Text;

namespace MSA.Test
{
    public class MSAConfig
    {
        public int Count { get; set; }
        public double Average { get; set; }
        public double StandardDeviation { get; set; }
        public double Cg { get; set; }
        public double Cgk { get; set; }

        public MSA MSA { get; set; }
    }
}
