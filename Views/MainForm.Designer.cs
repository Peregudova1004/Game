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
            moneyLabel = new Label();
            dayLabel = new Label();
            plantWheatButton = new Button();
            nextDayButton = new Button();
            SuspendLayout();
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new Point(12, 9);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(70, 15);
            moneyLabel.TabIndex = 0;
            moneyLabel.Text = "Деньги: 100";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(12, 32);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(46, 15);
            dayLabel.TabIndex = 1;
            dayLabel.Text = "День: 1";
            // 
            // plantWheatButton
            // 
            plantWheatButton.Location = new Point(15, 60);
            plantWheatButton.Name = "plantWheatButton";
            plantWheatButton.Size = new Size(120, 30);
            plantWheatButton.TabIndex = 2;
            plantWheatButton.Text = "Посадить пшеницу";
            plantWheatButton.Click += plantWheatButton_Click;
            // 
            // nextDayButton
            // 
            nextDayButton.Location = new Point(15, 100);
            nextDayButton.Name = "nextDayButton";
            nextDayButton.Size = new Size(120, 30);
            nextDayButton.TabIndex = 3;
            nextDayButton.Text = "Следующий день";
            nextDayButton.Click += nextDayButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(300, 200);
            Controls.Add(nextDayButton);
            Controls.Add(plantWheatButton);
            Controls.Add(dayLabel);
            Controls.Add(moneyLabel);
            Name = "MainForm";
            Text = "Ферма";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button plantWheatButton;
        private System.Windows.Forms.Button nextDayButton;
    }
}