using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTambah()
        {
            MainWindow hitung = new MainWindow();
            int angka1 = 1;
            int angka2 = 1;
            double expect = 2;
            double actual = hitung.tambah(angka1, angka2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodKurang()
        {
            MainWindow hitung = new MainWindow();
            int angka1 = 1;
            int angka2 = 1;
            double expect = 0;
            double actual = hitung.kurang(angka1, angka2);

            Assert.AreEqual(expect, actual, "true");

        }
        [TestMethod]
        public void TestMethodKali()
        {
            MainWindow hitung = new MainWindow();
            int angka1 = 2;
            int angka2 = 1;
            double expect = 2;
            double actual = hitung.kali(angka1, angka2);

            Assert.AreEqual(expect, actual, "true");
        }
        [TestMethod]
        public void TestMethodBagi()
        {
            MainWindow hitung = new MainWindow();
            int angka1 = 4;
            int angka2 = 2;
            double expect = 2;
            double actual = hitung.bagi(angka1, angka2);

            Assert.AreEqual(expect, actual, "true");
        }


    }
}
