using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace  Program
{

 public enum VARIANTS {
         stone, scrissors, paper
    }

        public class PSN
        {
            public static Random rmd = new Random();
            public string name;
            public VARIANTS _args;

            public PSN(){
                name = "Bot";
                _args = (VARIANTS)rmd.Next(0, 3);
            }
            public PSN(string name, VARIANTS arg) {
                this.name = name;
                _args = arg;
            }
        }

        public class whoWin{
            public static void WhoWins(PSN first, PSN second)
            {
                int rez = (3 + ((int)first._args + 1) - ((int)second._args + 1)) % 3;
                switch (rez)
                {
                    case 0: System.Console.WriteLine("Ничья!");
                    break;
                    case 1: System.Console.WriteLine("Победил: " + second.name);
                    break;
                    default: System.Console.WriteLine("Победил: " + first.name);
                    break;
                }
            }
        }
}
