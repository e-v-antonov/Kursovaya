using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class Game
    {
        public Game(int size)
        {
            sizeField = size;
            InitializtionPlayingField(); 
        }

        //public int Size { get; set; }  //размер игрового поля

        int sizeField;

        int[,] playingField;    //игровое поле

        private void InitializtionPlayingField()
        {
            playingField = new int[sizeField, sizeField];
        }

        //координаты пустой кнопки
        int emptyButtonX;
        int emptyButtonY;

        static Random rnd = new Random();

        //public Game(int size)
        //{
        //    if (size < 2) 
        //        size = 2;

        //    if (size > 5) 
        //        size = 5;

        //    this.size = size;

        //    map = new int[size, size];
        //}

        //возвращает номер кнопки по позиции
        private int ConvertCoordinateToPosition(int x, int y)
        {
            return y * sizeField + x;
        }

        //возвращает координаты в массиве по номеру кнопки
        private void ConvertPositionToCoordinate(int numberButton, out int x, out int y)
        {
            x = numberButton % sizeField;
            y = numberButton/ sizeField;
        }

        //заполняем игровкое поле (массив)
        public void PreparationPlayingField()//при начале игры присваеваем необходимые значения
        {
            for (int x = 0; x < sizeField; x++)
            {
                for (int y = 0; y < sizeField; y++)
                {
                    playingField[x, y] = ConvertCoordinateToPosition(x, y) + 1;
                }
            }                    

            emptyButtonX= sizeField - 1;
            emptyButtonY = sizeField - 1;
            
            //устанавливаем пустую кнопку
            playingField[emptyButtonX, emptyButtonY] = 0;
        }

        //возвращает число, которое написано на кнопке
        public int GetNumberOnButton(int numberButton)
        {
            int x, y;

            ConvertPositionToCoordinate(numberButton, out x, out y);

            //проверка от переполнения массива
            if (x < 0 || x >= sizeField)
            {
                return 0;
            }

            if (y < 0 || y >= sizeField)
            {
                return 0;
            }

            return playingField[x, y];
        }

        //public void shift(int position)//при нажатии на любую кнопку
        //{
        //    int x, y;

        //    position_to(position, out x, out y);

        //    if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
        //        return;

        //    map[space_x, space_y] = map[x, y];
        //    map[x, y] = 0;
        //    space_x = x;
        //    space_y = y;
        //}

        //public void shift_random()//нажимает рандомное количество раз на кнопки
        //{
        //    shift(rnd.Next(0, size * size));

        //}

        //public bool check_numbers()//проверка на место кнопок
        //{
        //    if (!(space_x == size - 1 &&
        //        space_y == size - 1))
        //        return false;

        //    for (int x = 0; x < size; x++)
        //        for (int y = 0; y < size; y++)
        //            if (!(x == size - 1 && y == size - 1))
        //                if (map[x, y] != to_position(x, y) + 1)
        //                    return false;

        //    return true;
        //}
    }
}
