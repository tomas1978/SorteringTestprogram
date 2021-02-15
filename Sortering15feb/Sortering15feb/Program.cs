using System;
using System.Collections.Generic;

namespace Sortering15feb
{
    class Program
    {
        static void BubbleSort(List<int> myList)
        {
            for(int i=0;i<myList.Count;i++) //Räkna antal genomgångar
            {
                for(int j=0;j<myList.Count-1;j++) //Gå igenom alla element i listan
                {
                    if(myList[j]>myList[j+1]) //Om elementen ligger i fel ordning
                    {
                        //Byt plats på myList[j] och myList[j+1]
                        int temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;
                    }
                }
            }
        }

        static void SkapaSlumplista(List<int> myList, int size)
        {
            Random slump = new Random();
            for (int i = 0; i < size; i++)  //Skapa ett stort antal slumptal i listan
            {
                myList.Add(slump.Next(1000000));
            }
        }

        static void Main(string[] args)
        {
            List<int> tallista = new List<int>();

            SkapaSlumplista(tallista, 50000);

            BubbleSort(tallista);

            Console.WriteLine("Listan är sorterad!");
        }
    }
}
