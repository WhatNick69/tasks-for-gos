using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void FireEvent (int day, int building);
    public class TownWithEvents
    {
        string townName;
        public string TownName
        { get { return townName; } }
        int buildings;
        int days;
        double fireProbability;
        Random random = new Random();
        public event FireEvent fireEvent;
        public TownWithEvents(string name, int buildings,
            int days, double fireProbability)
        {
            townName = name;
            this.buildings = buildings;
            this.days = days;
            this.fireProbability = fireProbability;
        }

        void OnFire(int day, int buildings)
        {
            if (fireEvent != null)
                fireEvent(day, buildings);
        }

        public void TownLife()
        {
            const string OK =
                "В городе все спокойно! Пожаров не было.";
            bool wasFire = false;
            for (int day = 1; day < days; day++)
                for (int building = 1; building < buildings; building++)
                    if (random.NextDouble() < fireProbability)
                    {
                        OnFire(day, building);
                        wasFire = true;
                    }
            if (!wasFire)
                Console.WriteLine(OK);
        }

    }
    public class FireMen
    {
        /// <summary>
        /// Город, клиентом которого является класс FireMen
        /// </summary>
        private TownWithEvents MyNativeTown;
        public FireMen(TownWithEvents twe)
        {
            this.MyNativeTown = twe;
            MyNativeTown.fireEvent += new FireEvent(FireHandler);
        }
        /// <summary>
        /// Обработчик события "пожар в городе"
        /// </summary>
        /// <param name="day">день пожара</param>
        /// <param name="buildings">строение</param>
        private void FireHandler(int day, int buildings)
        {
            string message =
                "В городе {0} произошел пожар! " +
                "В день {1}, в доме № {2}" +
                "  Пожар потушен!";
            Console.WriteLine(string.Format(message, MyNativeTown.TownName,
               day, buildings));
        }
        public void GoOut()
        {
            MyNativeTown.fireEvent -= new FireEvent(FireHandler);
        }
    }//FireMan

}
