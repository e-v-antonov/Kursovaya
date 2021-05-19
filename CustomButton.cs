using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    class CustomButton : Button
    {
        public CustomButton(string name, string text, int tag)
        {
            Name = name;
            Text = text;
            Tag = tag;
        }

        //public CustomButton(TableLayoutPanel tableLayoutPanel, string name, string text, /*int xPosition, int yPostion,*/ int width, int height, int row, int column, int tag /*EventHandler eventHandler*/)
        //{
        //    Button btn = new Button();
        //    btn.Name = name;
        //    btn.Text = text;
        //    btn.Dock = DockStyle.Fill;
        //    btn.Margin = new Padding(10);
        //    btn.Tag = tag;
        //    //btn.Location = new Point(xPosition, yPostion);
        //    btn.Size = new Size(width, height);
        //    //btn.Click += eventHandler;

        //    tableLayoutPanel.Controls.Add(btn, row, column);
        //    //form.Controls.Add(btn);
        //}

        public CustomButton CreateCustomButton(TableLayoutPanel tableLayoutPanel, int row, int column)
        {
            Button btn = new Button();

            btn.Name = Name;
            btn.Text = Text;
            btn.Dock = DockStyle.Fill;
            btn.Margin = new Padding(10);
            btn.Tag = Tag;

            tableLayoutPanel.Controls.Add(btn, row, column);

            return btn;
        }


        //Button btn;
        new string Name { get; set; }
        new string Text { get; set; }
        new int Tag { get; set; }
        //int Width { get; set; }
        //int Height { get; set; }
        //int X { get; set; }
        //int Y { get; set; }
    }
}
