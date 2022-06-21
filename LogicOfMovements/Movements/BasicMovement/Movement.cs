using ChessGameApp.Figure;
using ChessGameApp.Names;
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

        public abstract bool CheckIfCorrectMovementWhiteOrBlackFigure(BasicFigure actualClickFigure, bool freeField);
        public abstract bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure, bool freeField);
        public abstract bool CheckIfCorrectMovementBlackFigure(BasicFigure actualClickFigure, bool freeField);


        public void ChangePositionOfFigure(BasicFigure actualClickFigure, Player listOfPlayers, Dictionary<string, string> chessBoard)
        {
            BasicFigure currentFigure = listOfPlayers.ListOfFigures.FirstOrDefault(x => x == actualClickFigure);

            chessBoard[actualClickFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // set actuall chessBoard 
            chessBoard[actualClickFigure.NewPosition] = actualClickFigure.Name;

            currentFigure.currentButton.Content = "";
            currentFigure.CurrentPosition = actualClickFigure.NewPosition;
            currentFigure.NewPosition = "";
            currentFigure.currentButton = actualClickFigure.NewButton;
            currentFigure.CreateFigure();
            currentFigure.Movement = 1;
        }

        public bool CheckIsThereAndRemoveBlackFigure(BasicFigure actualClickFigure, Player blackPlayer, Dictionary<string, string> chessBoard)
        {
            BasicFigure removeBlackFigure = blackPlayer.ListOfFigures.FirstOrDefault(x => x.CurrentPosition == actualClickFigure.NewPosition);
            if (removeBlackFigure == null) return false;
            //delete the black figure

            chessBoard[removeBlackFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // delete black figure from chessboard
            blackPlayer.ListOfFigures.Remove(removeBlackFigure); // delete black figure from list
            return true;
        }

        public bool CheckIsThereAndRemoveWhiteFigure(BasicFigure actualClickFigure, Player whitePlayer, Dictionary<string, string> chessBoard)
        {
            BasicFigure removeWhiteFigure = whitePlayer.ListOfFigures.FirstOrDefault(x => x.CurrentPosition == actualClickFigure.NewPosition);
            if (removeWhiteFigure == null) return false;
            //delete the black figure

            chessBoard[removeWhiteFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // delete black figure from chessboard
            whitePlayer.ListOfFigures.Remove(removeWhiteFigure); // delete black figure from list
            return true;
        }

    }
}