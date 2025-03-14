using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__6._2
{
    internal class CarGame
    {
        List<string> car;
        List<string>order;
        double mileage;
        double money;
        string trip;
        bool buy;
       public CarGame(List<string> car, List<string> order, double mileage, double money, string trip, bool buy) 
        {
         this.car = car;
         this.order = order;
         this.mileage = mileage;
         this.money = money;
         this.trip = trip;
         this.buy = buy;
        }
        private const double KilometrePrice = 50;
        public double Mileage() 
        {
         double mileage =(double)new Random().Next(3, 26);
         return mileage;
        }
        public double Money(double count) 
        {
            money += Trip();
            return money;
        }
        public double Trip() 
        {
         double tripCost = Mileage() * KilometrePrice;
         return tripCost;
        }
        public void Order() 
        {
         Random rnd = new Random();
         int chance = rnd.Next(0,order.Count);
         MessageBox.Show("Новый заказ"+ order[chance]);
        }
    }
}
