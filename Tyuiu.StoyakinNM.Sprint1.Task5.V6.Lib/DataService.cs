﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StoyakinNM.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int res = 1+(k-1)%7;
            return res;
        }
    }
}
