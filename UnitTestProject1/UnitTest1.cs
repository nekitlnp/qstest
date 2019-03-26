using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test3()
        {
            var array = new int[] { 1, 2, 3 };
            FastQuick.QuickSort(array);
            Shield(array);
        }

        [TestMethod]
        public void Test100()
        {
            var rnd = new Random(42);
            var array = new int[100];
            for (var i = 0; i < array.Length - 1; i++)
                array[i] = rnd.Next(-100, 100);
            FastQuick.QuickSort(array);
            Shield(array);
        }

        [TestMethod]
        public void Test1000()
        {
            var rnd = new Random(42);
            var array = new int[1000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            FastQuick.QuickSort(array);
            for (var i = 0; i < 10; i++)
            {
                var j = rnd.Next(0, array.Length - 2);
                var k = rnd.Next(0, array.Length - 1);
                if (k >= j)
                    NUnit.Framework.Assert.GreaterOrEqual(array[k], array[j]);
                else
                    NUnit.Framework.Assert.GreaterOrEqual(array[j], array[k]);
            }
            Shield(array);
        }

        [TestMethod]
        public void Test0()
        {
            FastQuick.QuickSort(new int[0]);
        }

        [TestMethod]
        public void Test300M()
        {
            var rnd = new Random(42);
            var array = new int[300000000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(int.MinValue, int.MaxValue);
            FastQuick.QuickSort(array);
            Shield(array);
        }

        public void Shield(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                NUnit.Framework.Assert.GreaterOrEqual(arr[i + 1], arr[i]);
            }
        }
    }
}