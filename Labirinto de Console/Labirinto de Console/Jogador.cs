using System;
using System.Collections.Generic;
using System.Text;

namespace Labirinto
{
    class Jogador
    {
        public void Mover(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");


            System.Threading.Thread.Sleep(50);
            Console.Clear();
            

        }
        public Jogador()
        { }
    }
}
