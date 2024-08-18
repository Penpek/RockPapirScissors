using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace  Program
{

    class MainClass
    {

        public static void Main()
        {
        PSN Bot = new PSN();
        Player player = new Player();
        PSN _user = new PSN(player.name, player.change);

        System.Console.WriteLine(Bot._args);
        System.Console.WriteLine(_user._args);

        whoWin.WhoWins(_user, Bot);
        }
    }
}
