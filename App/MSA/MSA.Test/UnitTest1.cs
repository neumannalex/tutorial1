using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MSA.Test
{
    public class Tests
    {
        private double _epsilon = 1e-12;

        private MSAConfig GenerateMSAConfig()
        {
            var config = new MSAConfig
            {
                MSA = new MSA
                {
                    Data = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    ExpectedValue = 5,
                    UpperLimitValue = 6,
                    LowerLimitValue = 4
                },
                Count = 10,
                Average = 5.5,
                StandardDeviation = 3.0276503540974900000000,
                Cg = 0.022019275302527213,
                Cgk = -0.033028912953790818
            };

            return config;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCount()
        {
            var config = GenerateMSAConfig();

            var count = config.MSA.Count;
            Assert.IsTrue(count == config.Count);
        }

        [Test]
        public void TestCountWithNull()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = null;

            var count = config.MSA.Count;
            Assert.IsTrue(count == 0);
        }

        [Test]
        public void TestCountWithZeroDataLength()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = new List<double>();

            var count = config.MSA.Count;
            Assert.IsTrue(count == 0);
        }

        [Test]
        public void TestAverage()
        {
            var config = GenerateMSAConfig();

            var avg = config.MSA.Average;
            Assert.IsTrue(avg == config.Average);
        }

        [Test]
        public void TestAverageWithNull()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                var avg = config.MSA.Average;
            });
        }

        [Test]
        public void TestAverageWithZeroLengthData()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = new List<double>();

            Assert.Throws<DivideByZeroException>(() =>
            {
                var avg = config.MSA.Average;
            });
        }

        [Test]
        public void TestStdDeviation()
        {
            var config = GenerateMSAConfig();

            var stdDev = config.MSA.StandardDeviation;

            var delta = Math.Abs(stdDev - config.StandardDeviation);
            Assert.IsTrue(delta <= _epsilon);
        }

        [Test]
        public void TestStdDeviationWithNull()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                var stdDev = config.MSA.StandardDeviation;
            });
        }

        [Test]
        public void TestStdDeviationWithZeroLengthData()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = new List<double>();

            Assert.Throws<DivideByZeroException>(() =>
            {
                var stdDev = config.MSA.StandardDeviation;
            });
        }

        [Test]
        public void TestCg()
        {
            var config = GenerateMSAConfig();

            var cg = config.MSA.Cg;

            var delta = Math.Abs(cg - config.Cg);
            Assert.IsTrue(delta <= _epsilon);
        }

        [Test]
        public void TestCgWithNull()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                var cg = config.MSA.Cg;
            });
        }

        [Test]
        public void TestCgWithZeroLengthData()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = new List<double>();

            Assert.Throws<DivideByZeroException>(() =>
            {
                var cg = config.MSA.Cg;
            });
        }

        [Test]
        public void TestCgk()
        {
            var config = GenerateMSAConfig();

            var cgk = config.MSA.Cgk;

            var delta = Math.Abs(cgk - config.MSA.Cgk);
            Assert.IsTrue(delta <= _epsilon);
        }

        [Test]
        public void TestCgkWithNull()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                var cgk = config.MSA.Cgk;
            });
        }

        [Test]
        public void TestCgkWithZeroLengthData()
        {
            var config = GenerateMSAConfig();
            config.MSA.Data = new List<double>();

            Assert.Throws<DivideByZeroException>(() =>
            {
                var cgk = config.MSA.Cgk;
            });
        }
    }
}