using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {/// <summary>
     ///  Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
     /// </summary>
     /// <param name="args"></param>
     static int Input(string mes)
            
        {
            Console.WriteLine(mes);
            return int.Parse(Console.WriteLine());

        }
        static void Main(string[] args)
        {
            int day = Input("day=");

           

        }
        static string GetDay(int day)
        {
            switch (day)
            {
                case 1:return "понедельник";
                    case 2:return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";

                default: return "Ошибка";
            }
        }
    }
}
