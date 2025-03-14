using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__6._2
{
    internal class DrivingCar
    {
        public void TurnKey()
        {
            MessageBox.Show("Ключ зажигания повернут.");
        }
    }
    class Engine
    {
        private bool Running = false;
        public void Start()
        {
            if (!Running)
            {
             MessageBox.Show("Двигатель запущен.");
             Running = true;
            }
            else
            {
             MessageBox.Show("Двигатель уже работает.");
            }
        }
        public void Stop()
        {
            if (Running)
            {
             MessageBox.Show("Двигатель остановлен.");
             Running = false;
            }
            else
            {
             MessageBox.Show("Двигатель уже остановлен.");
            }
        }
        public bool IsRunning()
        {
         return Running;
        }
        class FuelSystem
        {
            public void PumpFuel(bool pump)
            {
                if (pump)
                {
                    MessageBox.Show("Подача топлива включена.");
                }
                else
                {
                    MessageBox.Show("Подача топлива прекращена.");
                }
            }
        }
        class Lights
        {
            public void TurnOnLights(bool on)
            {
                if (on)
                {
                    MessageBox.Show("Фары включены.");
                }
                else
                {
                    MessageBox.Show("Фары выключены.");
                }
            }
        }
        class Computer
        {
            public void RunDiagnostics()
            {
                Random rnd = new Random();
                int chance = rnd.Next(2);
                switch (chance) 
                {

                    case 0:
                        MessageBox.Show("Кажется какой то косяк с покрышками, может стоило зимнюю резину поставить???");
                        break;
                    case 1:
                        MessageBox.Show("Ну в общем и целом всё нормас.Ехала!");
                        break;
               
                }
            }
        }
    }
}