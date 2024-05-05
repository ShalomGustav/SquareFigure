using SquareFigure.Models;

namespace SquareFigure.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса
    /// </summary>
    public interface IShapeCalculator
    {
        double AreaCalculate(Shape shape);
        bool IsRightTriangle(Triangle triangle);
    }
}
