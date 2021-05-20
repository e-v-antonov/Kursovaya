using System;

namespace Kursovaya
{
    class Game
    {
        public Game(int size)
        {
            sizeField = size;
            InitializtionPlayingField(); 
        }

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

        //возвращает номер кнопки по позиции
        private int ConvertCoordinateToPosition(int x, int y)
        {
            if (x < 0)
            {
                x = 0;
            }

            if (x > sizeField - 1)
            {
                x = sizeField - 1;
            }

            if (y < 0)
            {
                y = 0;
            }

            if (y > sizeField - 1)
            {
                y = sizeField - 1;
            }

            return y * sizeField + x;
        }

        //возвращает координаты в массиве по номеру кнопки
        private void ConvertPositionToCoordinate(int numberButton, out int x, out int y)
        {
            if (numberButton < 0)
            {
                numberButton = 0;
            }

            if (numberButton > sizeField * sizeField - 1)
            {
                numberButton = sizeField * sizeField - 1;
            }

            y = numberButton % sizeField;
            x = numberButton / sizeField;
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

            emptyButtonX = sizeField - 1;
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

        public void MoveButton(int numberButton)
        {
            int x, y;

            ConvertPositionToCoordinate(numberButton, out x, out y);

            //проверка на доступность клетки для перемещения кнопки
            if (Math.Abs(emptyButtonX - x) + Math.Abs(emptyButtonY - y) != 1)
            {
                return;
            }

            playingField[emptyButtonX, emptyButtonY] = playingField[x, y];
            playingField[x, y] = 0;

            emptyButtonX = x;
            emptyButtonY = y;
        }

        //перемешивание кнопок перед игрой
        public void ShufflePlayingField()
        {
            int abilityToMove = rnd.Next(0, 4);
            int x = emptyButtonX;
            int y = emptyButtonY;

            switch (abilityToMove)
            {
                case 0:
                    x--;
                    break;

                case 1:
                    x++;
                    break;

                case 2:
                    y--;
                    break;

                case 3:
                    y++;
                    break;
            }

            MoveButton(ConvertCoordinateToPosition(x, y));
        }

        public bool SuccessfulGame()
        {
            if (!(emptyButtonX == sizeField - 1 && emptyButtonY == sizeField - 1))
            {
                return false;
            }

            for (int x = 0; x < sizeField; x++)
            {
                for (int y = 0; y < sizeField; y++)
                {
                    if (!(x == sizeField - 1 && y == sizeField - 1))
                    {
                        if (playingField[x, y] != ConvertCoordinateToPosition(x, y) + 1)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
