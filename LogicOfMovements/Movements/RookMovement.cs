using ChessGameApp.Figure;
using ChessGameApp.LogicOfMovements.Movements.BasicMovement;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.LogicOfMovements.Movements
{
    public class RookMovement : Movement
    {
        public override bool MoveFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            return false;
        }
    }
}
