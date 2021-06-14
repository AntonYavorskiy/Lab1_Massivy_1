using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Mas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа 1. Массивы 1:Вывести только отрицательные элементы.");
            int v = 33;
            Console.WriteLine("                      Порядковый номер по списку группы: 33");
            Console.WriteLine("                                " + ((v % 15) + 1) + " Вариант");

            Console.Write("Введите количество элементов:" );
            var len = int.Parse(0+ Console.ReadLine());
      


            var array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i+1 + " Элемент = ");
                array[i] = int.Parse(Console.ReadLine());
                

            }
            Console.Write("Отрицательные элменты массива:");
            for (int i = 0; i < array.Length; i++)


                if (array[i] < 0)
                


                    Console.Write(array[i] + "; ");

                
                else Console.Write("");
          
            
          

            Console.ReadKey();
        }
    }
}
