using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    class CustomButton
    {
        public CustomButton(TableLayoutPanel tableLayoutPanel, string name, string text, /*int xPosition, int yPostion,*/ int width, int height, int row, int column /*EventHandler eventHandler*/)
        {
            Button btn = new Button();
            btn.Name = name;
            btn.Text = text;
            //btn.Location = new Point(xPosition, yPostion);
            btn.Size = new Size(width, height);
            //btn.Click += eventHandler;

            tableLayoutPanel.Controls.Add(btn, row, column);
            //form.Controls.Add(btn);
        }

        //Button btn;
        //string Name { get; set; }
        //string Text { get; set; }
        //int Width { get; set; }
        //int Height { get; set; }
        //int X { get; set; }
        //int Y { get; set; }
    }
}
