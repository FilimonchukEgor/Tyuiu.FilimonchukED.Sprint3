﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilimonchukED.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                p *= i / Math.Pow(Math.Sin(1),-10);
            }
            return Math.Round(p,3);
        }
    }   
}
