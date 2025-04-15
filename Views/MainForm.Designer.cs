namespace Game.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            moneyLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            plantWheatButton = new System.Windows.Forms.Button();
            nextDayButton = new System.Windows.Forms.Button();
            inventoryListBox = new System.Windows.Forms.ListBox();
            shopListBox = new System.Windows.Forms.ListBox();
            buyButton = new System.Windows.Forms.Button();
            sellButton = new System.Windows.Forms.Button();
            gardenBed1 = new System.Windows.Forms.PictureBox();
            gardenBed2 = new System.Windows.Forms.PictureBox();
            gardenBed3 = new System.Windows.Forms.PictureBox();
            gardenBed4 = new System.Windows.Forms.PictureBox();
            SuspendLayout();
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new System.Drawing.Point(12, 9);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new System.Drawing.Size(70, 15);
            moneyLabel.TabIndex = 0;
            moneyLabel.Text = "Деньги: 100";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(12, 32);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(46, 15);
            dayLabel.TabIndex = 1;
            dayLabel.Text = "День: 1";
            // 
            // plantWheatButton
            // 
            plantWheatButton.Location = new System.Drawing.Point(15, 60);
            plantWheatButton.Name = "plantWheatButton";
            plantWheatButton.Size = new System.Drawing.Size(120, 30);
            plantWheatButton.TabIndex = 2;
            plantWheatButton.Text = "Посадить";
            plantWheatButton.Click += new System.EventHandler(this.plantWheatButton_Click);
            // 
            // nextDayButton
            // 
            nextDayButton.Location = new System.Drawing.Point(15, 100);
            nextDayButton.Name = "nextDayButton";
            nextDayButton.Size = new System.Drawing.Size(120, 30);
            nextDayButton.TabIndex = 3;
            nextDayButton.Text = "Следующий день";
            nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new System.Drawing.Point(15, 150);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new System.Drawing.Size(150, 124);
            inventoryListBox.TabIndex = 4;
            // 
            // shopListBox
            // 
            shopListBox.FormattingEnabled = true;
            shopListBox.ItemHeight = 15;
            shopListBox.Location = new System.Drawing.Point(200, 150);
            shopListBox.Name = "shopListBox";
            shopListBox.Size = new System.Drawing.Size(150, 124);
            shopListBox.TabIndex = 5;
            // 
            // buyButton
            // 
            buyButton.Location = new System.Drawing.Point(200, 290);
            buyButton.Name = "buyButton";
            buyButton.Size = new System.Drawing.Size(75, 23);
            buyButton.TabIndex = 6;
            buyButton.Text = "Купить";
            buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            sellButton.Location = new System.Drawing.Point(15, 290);
            sellButton.Name = "sellButton";
            sellButton.Size = new System.Drawing.Size(75, 23);
            sellButton.TabIndex = 7;
            sellButton.Text = "Продать";
            sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // gardenBed1
            // 
            gardenBed1.Location = new System.Drawing.Point(400, 50);
            gardenBed1.Size = new System.Drawing.Size(100, 100);
            gardenBed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gardenBed1.Name = "gardenBed1";
            // 
            // gardenBed2
            // 
            gardenBed2.Location = new System.Drawing.Point(520, 50);
            gardenBed2.Size = new System.Drawing.Size(100, 100);
            gardenBed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gardenBed2.Name = "gardenBed2";
            // 
            // gardenBed3
            // 
            gardenBed3.Location = new System.Drawing.Point(400, 170);
            gardenBed3.Size = new System.Drawing.Size(100, 100);
            gardenBed3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gardenBed3.Name = "gardenBed3";
            // 
            // gardenBed4
            // 
            gardenBed4.Location = new System.Drawing.Point(520, 170);
            gardenBed4.Size = new System.Drawing.Size(100, 100);
            gardenBed4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            gardenBed4.Name = "gardenBed4";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 400);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(shopListBox);
            Controls.Add(inventoryListBox);
            Controls.Add(nextDayButton);
            Controls.Add(plantWheatButton);
            Controls.Add(dayLabel);
            Controls.Add(moneyLabel);
            Controls.Add(gardenBed1);
            Controls.Add(gardenBed2);
            Controls.Add(gardenBed3);
            Controls.Add(gardenBed4);
            Name = "MainForm";
            Text = "Ферма";
            Load += new System.EventHandler(this.MainForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button plantWheatButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.ListBox shopListBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.PictureBox gardenBed1;
        private System.Windows.Forms.PictureBox gardenBed2;
        private System.Windows.Forms.PictureBox gardenBed3;
        private System.Windows.Forms.PictureBox gardenBed4;
    }
}
