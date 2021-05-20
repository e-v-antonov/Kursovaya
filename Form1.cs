using System;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        Game game;
        Button[,] customButtons;

        public Form1()
        {
            InitializeComponent();            
        }

        //подготовка игрового поля к игре
        private void PreparationForGame(int countCell)
        {
            game = new Game(countCell);

            tableLayoutPanel.ColumnCount = countCell;
            tableLayoutPanel.RowCount = countCell;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int tagButton = 0;
            customButtons = new Button[tableLayoutPanel.ColumnCount, tableLayoutPanel.RowCount];

            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    Button btn = new CustomButton("btn" + i.ToString() + j.ToString(), "-", tagButton);

                    customButtons[i, j] = ((ICreateCustomButton)btn).CreateCustomButton(tableLayoutPanel, i, j, ClickButton);
                    tagButton++;
                }
            }

            game.PreparationPlayingField();

            for (int i = 0; i < 100; i++)
            {
                game.ShufflePlayingField();
            }

            RefreshPlayingField();
        }

        //очищение поля
        private void ClearField()
        {
            tableLayoutPanel.Controls.Clear();
            customButtons = null;
            game = null;
        }

        private void miGameThree_Click(object sender, EventArgs e)
        {
            ClearField();
            PreparationForGame(3);
        }

        private void miGameFour_Click(object sender, EventArgs e)
        {
            ClearField();
            PreparationForGame(4);
        }

        private void miGameFive_Click(object sender, EventArgs e)
        {
            ClearField();
            PreparationForGame(5);
        }

        //клик по пятнашке
        private void ClickButton(object sender, EventArgs e)
        {
            int positionButton = Convert.ToInt32(((Button)sender).Tag);

            game.MoveButton(positionButton);                     

            RefreshPlayingField();

            if (game.SuccessfulGame())
            {
                MessageBox.Show("Ура! Вы выиграли эту игру!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
            }
        }

        //обновление игрового поля
        private void RefreshPlayingField()
        {
            int cell = 0;
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    Button btn = customButtons[i, j];
                    btn.Text = game.GetNumberOnButton(cell).ToString();
                    btn.Visible = (game.GetNumberOnButton(cell) > 0);
                    cell++;
                }
            }
        }
    }
}
