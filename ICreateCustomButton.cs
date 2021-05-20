using System;
using System.Windows.Forms;

namespace Kursovaya
{
    interface ICreateCustomButton
    {
        Button CreateCustomButton(TableLayoutPanel tableLayoutPanel, int row, int column, EventHandler eventHandler);
    }
}
