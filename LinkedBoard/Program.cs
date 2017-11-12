using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(4,2);
            board.CreateFields();
            board.ConnectFields();  
            board.PrintFields();
        }
    }
}
