using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class Game
    {
        int size { get; set; }

        int[,] map;

        int space_x, space_y;

        static Random rnd = new Random();

        public Game(int size)
        {
            if (size < 2) 
                size = 2;

            if (size > 5) 
                size = 5;

            this.size = size;

            map = new int[size, size];
        }

        private int to_position(int x, int y)//проверяет table по тому на каком месте находится объект
        {
            return y * size + x;
        }

        private void position_to(int position, out int x, out int y)
        {
            x = position % size;
            y = position / size;
        }

        public void start()//при начале игры присваеваем необходимые значения
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map[x, y] = to_position(x, y) + 1;

            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y] = 0;
        }

        public int get_number(int position)//позиция кноки
        {
            int x, y;

            position_to(position, out x, out y);

            if (x < 0 || x >= size) 
                return 0;

            if (y < 0 || y >= size) 
                return 0;

            return map[x, y];
        }

        public void shift(int position)//при нажатии на любую кнопку
        {
            int x, y;

            position_to(position, out x, out y);

            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
                return;

            map[space_x, space_y] = map[x, y];
            map[x, y] = 0;
            space_x = x;
            space_y = y;
        }

        public void shift_random()//нажимает рандомное количество раз на кнопки
        {
            shift(rnd.Next(0, size * size));

        }

        public bool check_numbers()//проверка на место кнопок
        {
            if (!(space_x == size - 1 &&
                space_y == size - 1))
                return false;

            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (map[x, y] != to_position(x, y) + 1)
                            return false;

            return true;
        }
    }
}
