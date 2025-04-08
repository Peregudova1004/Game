using Game.Controllers;
using Game.Models;
using System.Windows.Forms;

namespace Game.Views
{
    public partial class MainForm : Form
    {
        private readonly FarmController _controller;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация модели и контроллера
            var model = new FarmModel();
            _controller = new FarmController(model);

            UpdateUI();
            SetupBackground();
        }

            private void SetupBackground()
            {
            //Правильное обращение к ресурсам
                //this.BackgroundImage = global::Game.Properties.Resources.farm_bg;
                //this.BackgroundImageLayout = ImageLayout.Stretch;

            // Делаем элементы видимыми на фоне
            moneyLabel.BackColor = Color.Transparent;
                dayLabel.BackColor = Color.Transparent;
                plantWheatButton.FlatStyle = FlatStyle.Flat;
                plantWheatButton.BackColor = Color.FromArgb(150, 255, 255, 255);
            }

        private void UpdateUI()
        {
            moneyLabel.Text = $"Деньги: {_controller.GetMoney()}";
            dayLabel.Text = $"День: {_controller.GetDay()}";
        }

        private void plantWheatButton_Click(object sender, System.EventArgs e)
        {
            _controller.PlantCrop(Plant.PlantType.Wheat);
            UpdateUI();
        }

        private void nextDayButton_Click(object sender, System.EventArgs e)
        {
            _controller.NextDay();
            UpdateUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}