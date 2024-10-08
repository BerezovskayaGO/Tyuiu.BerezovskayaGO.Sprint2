﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x + 630 != y;
            res[2] = x < y;
            res[3] = x + 631 > y;
            res[4] = x + 631 <= y;
            res[5] = x >= y;

            return res;
        }
    }
}