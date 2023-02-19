using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._23_dz
{
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);

    }
    interface IOutput
    {
        void Show();
        void Show(string info);

    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
