using SquareFigure.Interfaces;
using SquareFigure.Models;
using System;

namespace SquareFigure.Services
{
    /// <summary>
    /// Класс высчислений площадей
    /// </summary>
    public class ShapeСalculator : IShapeCalculator
    {
        /// <summary>
        /// Метод вычисления площади для фигур
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public virtual double AreaCalculate(Shape shape)
        {
            switch (shape.Type)
            {
                case "Circle":
                    return CalculateCircle((Circle)shape);
                case "Triangle":
                    return CalculateTriangle((Triangle)shape);
            }
            return default;
        }

        /// <summary>
        /// Метод определяющий , является ли треугольник прямоугольный
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public virtual bool IsRightTriangle(Triangle triangle)
        {
            double[] sides = { triangle.SideA, triangle.SideB, triangle.SideC };
            Array.Sort(sides);
            var result = sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
            return result;
        }

        /// <summary>
        /// Защищенные методы нахождения площади треугольника и окружности
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        #region Protected Block
        protected virtual double CalculateTriangle(Triangle triangle)
        {
            var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            var formulaOfGeron = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
            return formulaOfGeron;
        }

        protected virtual double CalculateCircle(Circle circle)
        {
            var radius = circle.Radius;
            return Math.PI * radius * radius;
        }
        #endregion
    }
}
