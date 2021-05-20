using System;
using System.Windows.Forms;

namespace Kursovaya
{
    class CustomButton : Button, ICreateCustomButton
    {
        public CustomButton(string name, string text, int tag)
        {
            Name = name;
            Text = text;
            Tag = tag;
        }

        //создание кнопки-пятнашки
        public Button CreateCustomButton(TableLayoutPanel tableLayoutPanel, int row, int column, EventHandler eventHandler)
        {
            Button btn = new Button();

            btn.Name = Name;
            btn.Text = Text;
            btn.Dock = DockStyle.Fill;
            btn.Margin = new Padding(10);
            btn.Tag = Tag;
            btn.TabStop = false;
            btn.Click += eventHandler;

            tableLayoutPanel.Controls.Add(btn, row, column);

            return btn;
        }

        new string Name { get; set; }
        new string Text { get; set; }
        new int Tag { get; set; }
    }
}
