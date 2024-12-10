namespace Tyuiu.IgnatovA.Lab2.Review.V9.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int start, int end)
        {
            if (start > end)
                return new double[0];
            double[] results = new double[end - start + 1];
            int index = 0;
            for (int x = start; x <= end; x++)
            {
                double znamenatel = Math.Sin(x) + 1;
                if (Math.Abs(znamenatel) < 0.000001)
                {
                    results[index] = double.NaN;
                }
                else
                {
                    results[index] = ((Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(x, 2))) / znamenatel) - (Math.Sin(Math.Pow(x, 2)) - Math.Cos(x))/(15 + Math.Cos(x));
                    results[index] = Math.Round(results[index], 2);
                }
                index++;
            }
            return results;
        }
    }
}
