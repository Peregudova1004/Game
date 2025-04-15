using Game.Controllers;
using Game.Models;
using System;
using System.Drawing;
using System.IO;
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
            SetupGardenBeds();
        }

        private void SetupBackground()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resourses", "background.png");
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Фоновое изображение не найдено!");
            }
        }

        private void SetupGardenBeds()
        {
            string gardenImagePath = Path.Combine(Application.StartupPath, "Resourses", "garden.jpg");
            if (File.Exists(gardenImagePath))
            {
                Image gardenImage = Image.FromFile(gardenImagePath);
                gardenBed1.Image = gardenImage;
                gardenBed2.Image = gardenImage;
                gardenBed3.Image = gardenImage;
                gardenBed4.Image = gardenImage;
            }
            else
            {
                MessageBox.Show("Изображение грядки не найдено!");
            }
        }

        private void UpdateUI()
        {
            moneyLabel.Text = $"Деньги: {_controller.GetMoney()}";
            dayLabel.Text = $"День: {_controller.GetDay()}";
            UpdateInventoryUI();
            UpdateShopUI();
        }

        private void UpdateInventoryUI()
        {
            inventoryListBox.Items.Clear();
            foreach (var item in _controller.GetInventoryItems())
            {
                inventoryListBox.Items.Add($"{item.Key}: {item.Value}");
            }
        }

        private void UpdateShopUI()
        {
            shopListBox.Items.Clear();
            foreach (var item in _controller.GetShopItems())
            {
                shopListBox.Items.Add($"{item.Key}: {item.Value} монет");
            }
        }

        private void plantWheatButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItem != null)
            {
                string selectedItem = inventoryListBox.SelectedItem.ToString().Split(':')[0];
                if (selectedItem.EndsWith("Seed"))
                {
                    if (_controller.PlantCrop(selectedItem))
                    {
                        MessageBox.Show($"{selectedItem} посажен!");
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно семян для посадки!");
                    }
                    UpdateUI();
                }
                else
                {
                    MessageBox.Show("Выберите семена для посадки!");
                }
            }
            else
            {
                MessageBox.Show("Выберите предмет из инвентаря!");
            }
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            _controller.NextDay();
            MessageBox.Show("Наступил следующий день!");
            UpdateUI();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (shopListBox.SelectedItem != null)
            {
                string selectedItem = shopListBox.SelectedItem.ToString().Split(':')[0];
                if (_controller.BuyItem(selectedItem, 1))
                {
                    MessageBox.Show("Покупка успешна!");
                }
                else
                {
                    MessageBox.Show("Недостаточно денег для покупки!");
                }
                UpdateUI();
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItem != null)
            {
                string selectedItem = inventoryListBox.SelectedItem.ToString().Split(':')[0];
                if (_controller.SellItem(selectedItem, 1))
                {
                    MessageBox.Show("Продажа успешна!");
                }
                else
                {
                    MessageBox.Show("Недостаточно предметов для продажи!");
                }
                UpdateUI();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
