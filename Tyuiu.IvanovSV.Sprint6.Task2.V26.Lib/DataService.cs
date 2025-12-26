using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovSV.Sprint6.Task2.V26.Lib
{
    public class DataService : ISprint6Task2V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                values[index] = Math.Round(Math.Sin(i) + Math.Cos(2 * i) / 2 - 1.5 * i, 2);
                index++;
            }
            return values;
        }

    }
}
