using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    public class Player
    {

        public string name;
        public VARIANTS change;
        public Player()
        {
            Console.Write("Введите имя игрока: ");
            name = Console.ReadLine();
        do{
                Console.Write("Введите значение stone, paper или scrissors: ");
            try
            {
            change = (VARIANTS)Enum.Parse(typeof(VARIANTS), Console.ReadLine());
            break;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Не правильный ввод!!!");
            }
        } while(true);
        }
    }
}
