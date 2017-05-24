using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = "Энск";
            int buildings = 1000;
            int days = 30;
            double fireProbability = 1e-3;
            TownWithEvents town = new
                TownWithEvents(townName, buildings, days, fireProbability);
            FireMen fireMen = new FireMen(town);
            Console.WriteLine("События в городе " + townName);
            town.TownLife();

        }
    }
}
