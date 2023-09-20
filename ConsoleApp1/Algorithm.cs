using System;

namespace Algorithms
{
    public class Algorithm
    {
        public static int AntiCurseLineSearch(int[] mass, int element)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int AntiCurseFastLineSearch(int[] mass, int element)
        {
            if (mass[0] == element)
            {
                return 0;
            }
            if (mass[mass.Length - 1] == element)
            {
                return mass.Length - 1;
            }

            int startIndex = 0;
            int lastIndex = (mass.Length - 1);

            while ((startIndex <= lastIndex) && (element >= mass[startIndex]) && (element <= mass[lastIndex]))
            {
                int position = Math.Abs(startIndex + ((element - mass[startIndex]) * (lastIndex - startIndex) / (mass[lastIndex] - mass[startIndex])));
                if (mass[position] == element)
                {
                    return position;
                }
                if (mass[position] < element)
                {
                    startIndex = position + 1;
                }
                else
                {
                    lastIndex = position - 1;
                }
            }
            return -1;
        }
        public static int CurseFastLineSearch(int[] mass, int element)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > element)
                {
                    return -1;
                }
                else if (mass[i] == element)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int InterpolationSearch(int[] mass, int element) // Временная O(log log N); Пространственная O(1)
        {
            if (mass[0] == element)
            {
                return 0;
            }
            if (mass[mass.Length - 1] == element)
            {
                return mass.Length - 1;
            }

            int startIndex = 0;
            int lastIndex = (mass.Length - 1);

            while ((startIndex <= lastIndex) && (element >= mass[startIndex]) &&
                   (element <= mass[lastIndex]))
            {
                int position = Math.Abs(startIndex + ((element - mass[startIndex]) * (lastIndex - startIndex) /
                  (mass[lastIndex] - mass[startIndex])));

                if (mass[position] == element)
                {
                    return position;
                }

                if (mass[position] < element)
                {
                    startIndex = position + 1;
                }
                else
                {
                    lastIndex = position - 1;
                }
            }
            return -1;
        }
        public static int CurseJumpSearch(int[] mass, int element)
        {
            int step = (int)Math.Sqrt(mass.Length);
            int previousStep = 0;

            while (mass[Math.Min(step, mass.Length) - 1] < element)
            {
                previousStep = step;
                step += (int)Math.Sqrt(mass.Length);
                if (previousStep >= mass.Length)
                {
                    return -1;
                }

            }
            while (mass[previousStep] < element)
            {
                previousStep++;
                if (previousStep == Math.Min(step, mass.Length))
                {
                    return -1;
                }
            }

            if (mass[previousStep] == element)
            {
                return previousStep;
            }
            return -1;
        }
    }
}
