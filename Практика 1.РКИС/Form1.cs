using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1.РКИС
{
    public partial class Form1 : Form
    {
        private Airplane airplane;
        private Helicopter helicopter;
        private HotAirBalloon balloon;

        public Form1()
        {
            InitializeComponent();
            // Создаем экземпляры транспортных средств
            airplane = new Airplane("Боинг 747");
            helicopter = new Helicopter("Ми-8");
            balloon = new HotAirBalloon("Волшебный шар");
            // Заполняем ComboBox названиями транспортных средств
            vehicleComboBox.Items.AddRange(new string[] { airplane.Name, helicopter.Name, balloon.Name });
        }
        private void flyButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрано ли транспортное средство
            if (vehicleComboBox.SelectedItem == null)
            {
                resultTextBox.Text = "Пожалуйста, выберите транспортное средство.";
                return;
            }

            // Получаем название выбранного транспортного средства
            string selectedVehicleName = vehicleComboBox.SelectedItem.ToString();

            // Запускаем полет и выводим результат в зависимости от выбора
            switch (selectedVehicleName)
            {
                case "Боинг 747":
                    resultTextBox.Text = airplane.Fly();
                    break;
                case "Ми-8":
                    resultTextBox.Text = helicopter.Fly();
                    break;
                case "Волшебный шар":
                    resultTextBox.Text = balloon.Fly();
                    break;
                default:
                    resultTextBox.Text = "Неизвестное транспортное средство.";
                    break;
            }
        }
    }
}
