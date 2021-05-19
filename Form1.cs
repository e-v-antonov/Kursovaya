using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            game = new Game(3);
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { 
            //CustomButton customButton = new CustomButton(tableLayoutPanel, "btn1", "-", 179, 117);

            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int tagButton = 0;
            customButtons = new CustomButton[tableLayoutPanel.ColumnCount, tableLayoutPanel.RowCount];
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    //Button btn = new CustomButton(tableLayoutPanel, "btn" + i.ToString() + j.ToString(), "-", 179, 117, i, j, tagButton);
                    Button btn = new CustomButton("btn" + i.ToString() + j.ToString(), "-", tagButton);

                    customButtons[i, j] = btn.CreateCustomButton(tableLayoutPanel, i, j);
                    //tagButton++;
                }
            }

            game.PreparationPlayingField();
            RefreshPlayingField();
        }

        private void RefreshPlayingField()
        {
            //TODO: заменить цифру на переменную в которую передается значение (колво клеток) в зависимости от уровня
            //for (int cell = 0; cell < 9; cell++)
            //{
            //    //испольуем полиморфизм
            //    Button btn = customButtons[cell];
            //    btn.Text = game.GetNumberOnButton(cell).ToString();
            //    btn.Visible = (game.GetNumberOnButton(cell) > 0);
            //}
            int p = 0;
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    Button btn = customButtons[i, j];
                    btn.Text = game.GetNumberOnButton(p).ToString();
                    btn.Visible = (game.GetNumberOnButton(p) > 0);
                    p++;
                }
            }
        }
    }
}
