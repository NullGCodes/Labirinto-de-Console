using System;
using System.Collections.Generic;
using System.Text;

namespace Labirinto
{
    class Maze
    {

        public string[] maze
        {
            get { return L; }
        }
        int y = 0;
        

        string[] L = {             "───────────────────┬────────────────────┐\n" +
                                   "                   │                    │\n"+
                                   "┌───────────────┐  │  ┌────────────┐    │\n"+
                                   "│               │  │  │                 │\n"+
                                   "│  ┌──┐  ┌───┐  │  │  │   ──────────────┤\n"+
                                   "│  │  │  │      │  │  │                 │\n"+
                                   "│  │  │  └──────┘  │  └──────────────┐  │\n"+
                                   "│     │            │                 │  │\n"+
                                   "│  │  └────────────┤  ┌──────   ┌────┘  │\n"+
                                   "│  │               │  │         │       │\n"+
                                   "│  └────────────┐  ┴  │     │   │    │  │\n"+
                                   "│               │     │     │   │    │  │\n"+
                                   "├───────────────┼─────┘     │   │    │  │\n"+
                                   "│               │           │   │    │  │\n"+
                                   "├─────    ──────┤  │   ┌────┘   │    │  │\n"+
                                   "│                  │   │        │    │  │\n"+
                                   "│───────────────┬──┴───┴──┬─┤   │    │  │\n"+
                                   "│               │         │     │    │  │\n"+
                                   "│  │    ────┐   │   ──┐   │   ├─┘    │  │\n"+
                                   "│  │        │   │     │   │          │  │\n"+
                                   "│  └─────┐  └───┴──   │   └──────────┘  │\n"+
                                   "         │            │                 │\n"+
                                   "─────────┴────────────┴─────────────────┘"};
        public char[] Fragmentar()
        {
            char[] c = String.Join(string.Empty, L).ToCharArray();
            return c;
        }
        
        public void Imprimir()
        {
            

            for (int i = 0; i < L.Length; i++)
            {

                Console.SetCursorPosition(0, i);
                string C = L[i];
                Console.Write(C);
                y=i;

            }

        }
        public double Y
        {
            get { return y; }
        }
        
        public Maze()
        {
        }
    }
}

