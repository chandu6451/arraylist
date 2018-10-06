using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(15);
            arrList.Add(45.89);
            arrList.Add(false);
            arrList.Add("Capgemini");
            arrList.Add('D');
            arrList.Add(Math.PI);
            arrList.Add(true);
            arrList.Add(1234567);
            arrList.Add(".NET Batch");

            Console.WriteLine("Count : " + arrList.Count);
            Console.WriteLine("Capacity : " + arrList.Capacity);

            Console.WriteLine("\n ArrayList Elements are : ");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.Write(arrList[i] + "\t");
            }

            object[] objArr = new object[15];

            //CopyTo(Array) - All the elements of Arraylist are copied to the array from index 0
            //arrList.CopyTo(objArr);

            //CopyTo(Array, position) - All the elements of Arraylist are copied to the array from index provided by position
            //arrList.CopyTo(objArr, 4);

            //CopyTo(ArrayListIndex, Array, ArrayIndex, NumberofElementsfromArrayList)-
            arrList.CopyTo(3, objArr, 5, 2);

            Console.WriteLine("\n\nArray Elements : ");
            for (int i = 0; i < objArr.Length; i++)
            {
                if (objArr[i] != null)
                    Console.Write(objArr[i] + "\t");
                else
                    Console.Write("Empty\t");
            }

            Console.ReadKey();
        }
    }
}
