using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Controllers.Tests
{
    [TestClass()]
    public class CalculatorControllerTests
    {
        [TestMethod()]
        public void GetMultipleNumbersTest()
        {
            // Disponer
            CalculatorController controller = new CalculatorController();

            // Actuar
            String result = controller.GetMultipleNumbers(10);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("0,1,2,C,4,E,C,7,8,C,E", result);
        }

        [TestMethod()]
        public void GetOddNumbersTest()
        {
            // Disponer
            CalculatorController controller = new CalculatorController();

            // Actuar
            String result = controller.GetOddNumbers(10);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("1,3,5,7,9", result);
        }

        [TestMethod()]
        public void GetAllNumbersTest()
        {
            // Disponer
            CalculatorController controller = new CalculatorController();

            // Actuar
            String result = controller.GetAllNumbers(10);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("0,1,2,3,4,5,6,7,8,9,10", result);
        }

        [TestMethod()]
        public void GetEvenNumbersTest()
        {
            // Disponer
            CalculatorController controller = new CalculatorController();

            // Actuar
            String result = controller.GetEvenNumbers(10);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("0,2,4,6,8,10", result);
        }

        [TestMethod()]
        public void GetFibonacchiNumbersTest()
        {
            // Disponer
            CalculatorController controller = new CalculatorController();

            // Actuar
            String result = controller.GetFibonacchiNumbers(10);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("0,1,1,2,3,5,8,13,21,34,55", result);
        }
    }
}