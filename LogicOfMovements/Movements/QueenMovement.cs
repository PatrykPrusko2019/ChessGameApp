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
    public class QueenMovement : Movement
    {
        private RookMovement rookMovement = new RookMovement();
        private BishopMovement bishopMovement = new BishopMovement();
        public override bool MoveFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            bool isRookMovement = rookMovement.MoveFigure(actualClickFigure, listOfPlayers, chessBoard, isMoveWhite);
            if (isRookMovement) return true;

            bool isBishopMovement = bishopMovement.MoveFigure(actualClickFigure, listOfPlayers, chessBoard, isMoveWhite);
            if (isBishopMovement) return true;

            return false;
        }



        public override bool CheckIfCorrectMovementWhiteOrBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }


        public override bool CheckIfCorrectMovementBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }

        public override bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
