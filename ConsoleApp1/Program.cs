using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Algorithms;
using System.Threading.Tasks;

namespace Algoritms
{
    class Program
    {
        private static Stopwatch _sw = new Stopwatch();

        static void Main()
        {
            Random rand = new Random();
            int index;
            double timeWork;
            List<int> Length = new List<int> { 10000, 20000, 30000, 40000, 50000, 100000, 200000 };
            foreach (var currentLength in Length)
            {
                Console.WriteLine("Количество элементов в массиве - {0}\n", currentLength);

                int findelement = rand.Next(0, currentLength + 1);
                int[] coursemass = new int[currentLength];
                for (int i = 0; i < coursemass.Length; i++)
                    coursemass[i] = i + 1;
                int[] anticoursemass = new int[currentLength];
                for (int i = 0; i < anticoursemass.Length; i++)
                    anticoursemass[i] = rand.Next(0, anticoursemass.Length + 1);

                StartTest(Algorithm.AntiCurseLineSearch, anticoursemass, findelement, out timeWork, out index);
                Console.WriteLine("Индекс линейного поиска в неупорядоченном массиве - {0}", Algorithm.AntiCurseLineSearch(anticoursemass, findelement));
                Console.WriteLine("Время работы линейного алгоритма поиска: {0}", timeWork);

                StartTest(Algorithm.AntiCurseFastLineSearch, anticoursemass, findelement, out timeWork, out index);
                Console.WriteLine("Индекс быстрого линейного поиска в неупорядоченном массиве - {0}", Algorithm.AntiCurseFastLineSearch(anticoursemass, findelement));
                Console.WriteLine("Время работы быстрого линейного алгоритма поиска: {0}", timeWork);

                StartTest(Algorithm.CurseFastLineSearch, coursemass, findelement, out timeWork, out index);
                Console.WriteLine("Индекс быстрого линейного поиска в упорядоченном массиве - {0}", Algorithm.CurseFastLineSearch(coursemass, findelement));
                Console.WriteLine("Время работы быстрого линейного алгоритма поиска: {0}", timeWork);

                StartTest(Algorithm.InterpolationSearch, coursemass, findelement, out timeWork, out index);
                Console.WriteLine("Индекс интерполяционного поиска в упорядоченном массиве - {0}", Algorithm.InterpolationSearch(coursemass, findelement));
                Console.WriteLine("Время работы интерполяционного алгоритма поиска: {0}", timeWork);

                StartTest(Algorithm.CurseJumpSearch, coursemass, findelement, out timeWork, out index);
                Console.WriteLine("Индекс поиска прыжками в упорядоченном массиве - {0}", Algorithm.CurseJumpSearch(coursemass, findelement));
                Console.WriteLine("Время работы алгоритма поиска прыжками: {0}\n", timeWork);

            }
            Console.ReadLine();
        }
        private static void StartTest(Func<int[], int, int> func, int[] array, int valueToSearch, out double timeWork, out int index)
        {
            timeWork = 0;
            index = -1;

            for (int i = 1; i <= 10; i++)
            {
                _sw.Reset();

                _sw.Start();

                index = func(array, valueToSearch);

                _sw.Stop();

                timeWork += _sw.ElapsedTicks;
            }

            timeWork = timeWork / 10;
        }
    }
}
