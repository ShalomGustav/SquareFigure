using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareFigure.Interfaces;
using SquareFigure.Models;
using SquareFigure.Services;
using System;

namespace UnitTestSquareFigure
{
    /// <summary>
    /// класс тестирования вычислений площади окружности и треугольника
    /// </summary>
    [TestClass]
    public class ShapeCalculatorTest
    {
        private readonly IShapeCalculator _service = new ShapeСalculator();

        /// <summary>
        /// Тест вычисления площади треугольника
        /// </summary>
        [TestMethod]
        public void TestCalculateTriangle()
        {
            //arrange - настройка
            var triangle = new Triangle { Type = "Triangle", SideA = 5, SideB = 4, SideC = 3 };//обьект класса Triangle
            var expectedResult = 6;//ожидание(написал 6, в качестве примера со строкой 39)
            
            //action - действие
            var actualResult = _service.AreaCalculate(triangle);//актуальный результат из класса
            
            //assert - сравнение
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Тест вычисления площади окружности
        /// </summary>
        [TestMethod]
        public void TestCalculateCircle()
        {
            //arrange - настройка
            var circle = new Circle { Type = "Circle", Radius = 5 };//обьект класса Circle
            var expectedResult = Math.PI * circle.Radius * circle.Radius;//ожидание

            //action - действие
            var actualResult = _service.AreaCalculate(circle);//актуальный результат из класса
            
            //assert - сравнение
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
