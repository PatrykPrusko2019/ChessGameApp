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
    public class FirstWhitePlayer
    {
        public string Name { get; set; }
        public List<BasicFigure> ListOfWhiteFigures { get; set; }

        public FirstWhitePlayer(string name ,List<BasicFigure> listOfWhiteFigures)
        {
            Name = name;
            ListOfWhiteFigures = listOfWhiteFigures;
        }

    }
}
