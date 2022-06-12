using ChessGameApp.Figure;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.LogicOfMovements.Movements.BasicMovement
{
    public abstract class Movement
    {
        public Dictionary<string, string> ChessBoard { get; set; }

        public abstract bool MoveFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite);

        public abstract bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure, bool freeField);
    }
}
