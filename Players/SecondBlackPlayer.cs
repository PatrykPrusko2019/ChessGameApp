using ChessGameApp.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.Players
{
    public class SecondBlackPlayer : Player
    {
        public SecondBlackPlayer(string name, List<BasicFigure> listOfBlackFigures) : base(name, listOfBlackFigures) { }
        
    }
}
