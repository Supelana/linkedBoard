using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBoard
{
    class BoardManager
    {
        public void CreateBoard()
        {
            Board board = new Board(9, 3);
            board.CreateFields();
            board.ConnectFields();
            //board.PrintFields();
            Field currentField = board.Fields[0];
            Field previousField;

            while (true)
            {
                previousField = currentField;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.RightArrow:
                        currentField = currentField.Right;
                        break;
                    case ConsoleKey.LeftArrow:
                        currentField = currentField.Left;
                        break;
                    case ConsoleKey.UpArrow:
                        currentField = currentField.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        currentField = currentField.Down;
                        break;
                }

                if (currentField == null)
                {
                    currentField = previousField;

                }
                Console.WriteLine(currentField.No);

            }
        }
    }
}