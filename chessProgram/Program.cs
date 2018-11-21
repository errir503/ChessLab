﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.drawChessBoard();

            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());
            

            TestMovement(board, x1, y1, x2, y2);
            Console.ReadKey();
        }

        private static void TestMovement(Board myBoard, int x1, int y1, int x2, int y2)
        {
            Console.Clear();
            MovementResult myRes = myBoard.move(x1, y1, x2, y2);
            myBoard.drawChessBoard();
            Console.Write(myRes);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
