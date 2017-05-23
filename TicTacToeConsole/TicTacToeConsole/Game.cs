using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class Game
    {
        char[] mark = { '0','1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public Game()
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe Game");
            Console.WriteLine("Player 1 (X)  -  Player 2 (O)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void board()
        {
            Console.WriteLine("                 " + mark[1] + "  |  " + mark[2] + "  |  " + mark[3]);
            Console.WriteLine("               _____|_____|_____");
            Console.WriteLine("                 " + mark[4] + "  |  " + mark[5] + "  |  " + mark[6]);
            Console.WriteLine("               _____|_____|_____");
            Console.WriteLine("                 " + mark[7] + "  |  " + mark[8] + "  |  " + mark[9]);
            Console.WriteLine("                    |     |     ");
        }

        public void turn()
        {

            Console.WriteLine("Enter Choice: ");
            Object inp = Console.ReadLine();
            int choice = Convert.ToInt32(inp);

            if (choice == 1 && mark[1] == '1')
                mark[1] = mark;
            else if (choice == 2 && mark[2] == '2')
                mark[2] = mark;
            else if (choice == 3 && mark[3] == '3')
                mark[3] = mark;
            else if (choice == 4 && mark[4] == '4')
                mark[4] = mark;
            else if (choice == 5 && mark[5] == '5')
                mark[5] = mark;
            else if (choice == 6 && mark[6] == '6')
                mark[6] = mark;
            else if (choice == 7 && mark[7] == '7')
                mark[7] = mark;
            else if (choice == 8 && mark[8] == '8')
                mark[8] = mark;
            else if (choice == 9 && mark[9] == '9')
                mark[9] = mark;
            else
                Console.WriteLine("Invalid Move");

        }

        public void checkwin()
        {
            int flag = 0;
        
            if (mark[1] == mark[2] && mark[2] == mark[3])
                flag = 1;
            else if (mark[4] == mark[5] && mark[5] == mark[6])
                flag = 1;
            else if (mark[7] == mark[8] && mark[8] == mark[9])
                flag = 1;
            else if (mark[1] == mark[4] && mark[4] == mark[7])
                flag = 1;
            else if (mark[2] == mark[5] && mark[5] == mark[8])
                flag = 1;
            else if (mark[3] == mark[6] && mark[6] == mark[9])
                flag = 1;
            else if (mark[1] == mark[5] && mark[5] == mark[9])
                flag = 1;
            else if (mark[3] == mark[5] && mark[5] == mark[7])
                flag = 1;
            else
                flag = 0;
        }

    }
}
