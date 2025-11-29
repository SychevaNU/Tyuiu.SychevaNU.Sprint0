using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SychevaNU.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SychevaNU.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {

            var name = "Анастасия";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет..., Анастасия", res);
        }
    }
}