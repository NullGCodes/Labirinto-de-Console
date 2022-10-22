using System;

namespace Labirinto
{
    class Program
    {
        

        enum GState
        {
            Running,
            Still,
            Done
        }
        
        struct COORD
        {
            
            COORD(int x , int y)
            {
                X = x;
                Y = y;

            }
            public int X { get; set; }
            public int Y { get; set; }
        };
        
        static void Main(string[] args)

        {
            
            Jogador p = new Jogador();
            Maze mapa = new Maze();
            char[] brokenmaze = mapa.Fragmentar();
            COORD pos = new COORD();
            pos.X = 0;
            pos.Y = 1;
            Console.CursorVisible = false;
            GState GameState = GState.Running;
            
          
            while(GameState == GState.Running)
            {

                mapa.Imprimir();
                Console.WriteLine("\n"+pos.X + " " + pos.Y);
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.Write("O");


                if (Console.ReadKey().Key == ConsoleKey.RightArrow && brokenmaze[pos.X + pos.Y * 42 + 1].ToString() == " ")
                {
                    pos.X += 1;
                }

                
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow && pos.X > 0 && brokenmaze[pos.X + pos.Y * 42 - 1].ToString() == " ")
                {
                    pos.X -= 1;
                }
                
                if (Console.ReadKey().Key == ConsoleKey.UpArrow && pos.Y > 0 && brokenmaze[pos.X + pos.Y * 42 -42 ].ToString() == " ")
                {
                    pos.Y -= 1;
                }
                
                if (Console.ReadKey().Key == ConsoleKey.DownArrow && brokenmaze[pos.X + pos.Y * 42 +42].ToString() == " ")
                {
                    pos.Y += 1;
                }
                p.Mover(pos.X, pos.Y);
                

                if (pos.X == 0 && pos.Y == 21) GameState = GState.Done;

            }

            if(GameState == GState.Done)
            {
                Console.Clear();
                Console.WriteLine("Vitória!\nFim de Jogo!");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
