using ChessGameApp.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.Players
{
    public abstract class Player
    {
        public string Name { get; set; }
        public List<BasicFigure> ListOfFigures { get; set; }

        public Player(string name, List<BasicFigure> listOfFigures) 
        {
            Name = name;
            ListOfFigures = listOfFigures;
        }
        
    }
}
