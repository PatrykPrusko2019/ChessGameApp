using ChessGameApp.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.Players
{
    public class SecondBlackPlayer
    {
        public string Name { get; set; }
        public List<BasicFigure> ListOfBlackFigures { get; set; }

        public SecondBlackPlayer(string name, List<BasicFigure> listOfWhiteFigures)
        {
            Name = name;
            ListOfBlackFigures = listOfWhiteFigures;
        }
    }
}
