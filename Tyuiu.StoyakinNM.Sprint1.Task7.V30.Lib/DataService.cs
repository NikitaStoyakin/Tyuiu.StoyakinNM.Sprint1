using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StoyakinNM.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double e = 2.6267;

            double part1 = x + Math.Pow(e, x);
            double part2 = Math.Sin(Math.Pow(x, 5)) + (Math.Pow(x, 3)) / (Math.Pow(3, x));
            double part3 = Math.Pow(y, 5) / Math.Pow(5, y);
            double res = part1 + part2 + part3;
            res = Math.Round(res, 3);
            
            return res;
        }
    }
}
