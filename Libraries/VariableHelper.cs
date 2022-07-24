using System;
using System.Collections.Generic;
using System.Text;

namespace Libreries
{
    public class VariableHelper
    {
        public static int ConvertHoursToMinutes(int hours)
        {
            return hours * 60;
        }

        public static int SolveTheTask(int a, int b)
        {
            return (5 * a + b * b) / (b - a);
        }

        public static (int, int) SwapTheContents(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (int, int) DividingWithRemainder(int a, int b)
        {
            int result = a / b;
            int division_Remainder = a % b;

            return (result, division_Remainder);
        }

        public static float SolveTheEquation(float a, float b, float c)
        {
            float x = (float)Math.Round((c - b) / a, 2);

            return x;
        }

        public static (float, float) SolveTheEquationOfStraightLine(float x1, float x2, float y1, float y2)
        {
            float b = (y1 - y2) / (x1 - x2);
            float a = y2 - b * x2;

            return (a, b);
        }

        public static int CalculateSumOfDigits(int n)
        {
            return n / 10 + n % 10;
        }
    }
}
