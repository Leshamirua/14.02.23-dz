using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._23_dz
{
    internal class Task_1
    {
        class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
        {
            int[] array = new int[10];
            public MyArray() { }
            public MyArray(int[] array)
            {
                this.array = array;
            }
            public int CountDistinct()
            {
                int countUnique = 0;
                int counter;
                foreach(int a in this.array)
                {
                     counter = 0;
                    foreach (int b in this.array)
                        if (a == b)
                            counter++;
                    if (counter == 1)
                    {
                        countUnique++;
                    }
                }
                return countUnique;
            }
            int EqualToValue(int valueToCompare)
            {
                int countUnique = 0;
                foreach (int a in this.array)
                {
                        if (a == valueToCompare)
                        countUnique++;
                }
                return countUnique;
            }
            public void ShowEven()
            {
                foreach(int a in this.array)
                {
                    if (a % 2 == 0)
                    {
                        Console.Write($"{a} ");
                    }
                }
                Console.WriteLine();
            }
            public void ShowOdd()
            {
                foreach (int a in this.array)
                {
                    if (a % 2 != 0)
                    {
                        Console.Write($"{a} ");
                    }
                }
                Console.WriteLine();
            }
            public int Less(int valueToCompare)
            {
                int counter = 0;
                foreach(int a in this.array)
                {
                    if (a < valueToCompare)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            public int Greater(int valueToCompare)
            {
                int counter = 0;
                foreach(int a in this.array)
                {
                    if (a > valueToCompare)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            public void SortAsc()
            {
                Array.Sort(array);
            }
            public void SortDesc()
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
            public void SortByParam(bool isAsc)
            {
                if (isAsc)
                {
                    SortAsc();
                }
                else
                {
                    SortDesc();
                }
            }
            public int Min()
            {
                int min = array[0];
                foreach (int i in array)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                return min;
            }
            public int Max()
            {
                int max = array[0];
                foreach (int i in array)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return max;
            }
            public float Avg()
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                return sum / array.Length;
            }
            public bool Search(int valueTosearch)
            {
                return array.Contains(valueTosearch);
            }
            public void Show()
            {
                foreach (int i in array)
                {
                    Console.Write(i);
                }
            }
            public void Show(string info)
            {
                foreach (int i in array)
                {
                    Console.Write(i);
                    Console.Write($" {info}");
                }
            }

        }
    }
}
