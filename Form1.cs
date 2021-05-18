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
        public Form1()
        {
            InitializeComponent();
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { 
            //CustomButton customButton = new CustomButton(tableLayoutPanel, "btn1", "-", 179, 117);

            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 3;


            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    CustomButton customButton = new CustomButton(tableLayoutPanel, "btn" + i.ToString() + j.ToString(), "-", 179, 117, i, j);
                }
            }
        }
    }
}
