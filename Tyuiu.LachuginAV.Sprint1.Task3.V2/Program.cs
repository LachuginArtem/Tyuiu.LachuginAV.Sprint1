using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint1.Task3.V2.Lib;

namespace Tyuiu.LachuginAV.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Лачугин А.В | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Лачугин Артём Викторович | АСОиУБ-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double priceNotebook;
            Console.WriteLine("*Введите значение стоимости тетради:                                      *");
            priceNotebook = Convert.ToDouble(Console.ReadLine());
            int amountNotebook;
            Console.WriteLine("*Введите значение количества тетрадей:                                    *");
            amountNotebook = Convert.ToInt32(Console.ReadLine());
            double pricePencil;
            Console.WriteLine("*Введите значение стоимости карандаша:                                    *");
            pricePencil = Convert.ToDouble(Console.ReadLine());
            int amountPencil;
            Console.WriteLine("*Введите значение количества карандашей:                                  *");
            amountPencil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Общая стоимость покупки = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            Console.ReadLine();
        }
    }
}
