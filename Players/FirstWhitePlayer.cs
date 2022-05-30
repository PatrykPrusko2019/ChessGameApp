using ChessGameApp.Figure;
using ChessGameApp.Figure.ColorWhite;
using ChessGameApp.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.Players
{
    public class FirstWhitePlayer : Player
    {
        
        public FirstWhitePlayer(string name, List<BasicFigure> listOfWhiteFigures) : base(name, listOfWhiteFigures) { }
        

    }
}
