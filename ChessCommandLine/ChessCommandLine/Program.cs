using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChessCommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tower tower = new Tower(Figur.Color.BLACK, 8, 'A');
            tower.MakeRandomMove();
        }
    }
}
