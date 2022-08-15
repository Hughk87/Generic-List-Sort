using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_List_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> _list_str = new List<string>();
            _list_str.Add("가");
            _list_str.Add("가가");
            _list_str.Add("나였다면");
            _list_str.Add("바람의윈드");
            _list_str.Add("라디오");
            _list_str.Add("가간");
            _list_str.Add("Hero");
            _list_str.Add("우연히");
            _list_str.Add("간가");
            _list_str.Add("똥쟁이");
            _list_str.Add("가갇");
            _list_str.Add("Name");

            _list_str.Sort(new Comparer_String());

            Console.WriteLine("문자열 List 출력");
            for (int i = 0; i < _list_str.Count; i++)
            {
                Console.WriteLine(_list_str[i]);
            }
            Console.WriteLine("------------------------------------");

            List<int> _list_value = new List<int>();

            _list_value.Add(123546);
            _list_value.Add(56431132);
            _list_value.Add(4567789);
            _list_value.Add(8645623);
            _list_value.Add(12315465);
            _list_value.Add(12356789);
            _list_value.Add(10321);
            _list_value.Add(3212301);
            _list_value.Add(890564);
            _list_value.Add(123065);

            _list_value.Sort(new Comparer_Int_descend());
            Console.WriteLine("정수형 List 출력");
            for (int i = 0; i < _list_value.Count; i++)
            {
                Console.WriteLine(_list_value[i]);
            }
        }
    }

    //문자열 정렬 (스펠링 순서) 영어 -> 한글
    public class Comparer_String : IComparer, IComparer<string>
    {
        public int Compare(object x, object y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
        public int Compare(string x1, string y1)
        {
            return x1.CompareTo(y1);
        }
    }
    //오름차순 정렬 - 작은것 -> 큰것
    public class Comparer_Int_ascend : IComparer, IComparer<int>
    {
        public int Compare(object x, object y)
        {
            int x1 = (int)x;
            int y1 = (int)y;

            if (x1 > y1)
                return 1;
            else if (x1 < y1)
                return -1;
            else
                return 0;
        }
        public int Compare(int x1, int y1)
        {
            if (x1 > y1)
                return 1;
            else if (x1 < y1)
                return -1;
            else
                return 0;
        }
    }
    //내림차순 정렬 - 큰것 -> 작은것
    public class Comparer_Int_descend : IComparer, IComparer<int>
    {
        public int Compare(object x, object y)
        {
            int x1 = (int)x;
            int y1 = (int)y;

            if (x1 > y1)
                return -1;
            else if (x1 < y1)
                return 1;
            else
                return 0;
        }
        public int Compare(int x1, int y1)
        {
            if (x1 > y1)
                return -1;
            else if (x1 < y1)
                return 1;
            else
                return 0;
        }
    }
}
