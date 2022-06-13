using ChessGameApp.Figure;
using ChessGameApp.LogicOfMovements.Movements.BasicMovement;
using ChessGameApp.Names;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessGameApp.LogicOfMovements
{
    public class PawnMovement : Movement
    {

        public override bool MoveFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            // check if the field is empty
            string figure = chessBoard.FirstOrDefault(x => actualClickFigure.NewPosition == x.Key).Value;

            if (figure == "FREE_FIELD" && isMoveWhite && CheckIfCorrectMovementWhiteFigure(actualClickFigure, true))
            { //white
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[0], chessBoard);
            }
            else if (figure == "FREE_FIELD" && !isMoveWhite && CheckIfCorrectMovementBlackFigure(actualClickFigure, true))
            { //Black
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
            else if (isMoveWhite && CheckIfCorrectMovementWhiteFigure(actualClickFigure, false) && CheckIsThereAndRemoveBlackFigure(actualClickFigure, listOfPlayers[1], chessBoard))
            {   // white and remove black figure
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[0], chessBoard);
            }
            else if ( !isMoveWhite && CheckIfCorrectMovementBlackFigure(actualClickFigure, false) && CheckIsThereAndRemoveWhiteFigure(actualClickFigure, listOfPlayers[0], chessBoard))
            {   // black and remove white figure
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
            else
            {
                return false;
            }
            return true;

        }

        //private bool CheckIsThereAndRemoveWhiteFigure(BasicFigure actualClickFigure, Player whitePlayer, Dictionary<string, string> chessBoard)
        //{
        //    BasicFigure removeWhiteFigure = whitePlayer.ListOfFigures.FirstOrDefault(x => x.CurrentPosition == actualClickFigure.NewPosition);
        //    if (removeWhiteFigure == null) return false;
        //    //delete the black figure

        //    chessBoard[removeWhiteFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // delete black figure from chessboard
        //    whitePlayer.ListOfFigures.Remove(removeWhiteFigure); // delete black figure from list
        //    return true;
        //}

        //private bool CheckIsThereAndRemoveBlackFigure(BasicFigure actualClickFigure, Player blackPlayer, Dictionary<string, string> chessBoard)
        //{
        //    BasicFigure removeBlackFigure = blackPlayer.ListOfFigures.FirstOrDefault(x => x.CurrentPosition == actualClickFigure.NewPosition);
        //    if (removeBlackFigure == null) return false;
        //    //delete the black figure

        //    chessBoard[removeBlackFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // delete black figure from chessboard
        //    blackPlayer.ListOfFigures.Remove(removeBlackFigure); // delete black figure from list
        //    return true;
        //}

        //private void ChangePositionOfFigure(BasicFigure actualClickFigure, Player listOfPlayers, Dictionary<string, string> chessBoard)
        //{
        //    BasicFigure currentFigure = listOfPlayers.ListOfFigures.FirstOrDefault(x => x == actualClickFigure);

        //    chessBoard[actualClickFigure.CurrentPosition] = FreeField.FREE_FIELD.ToString(); // set actuall chessBoard 
        //    chessBoard[actualClickFigure.NewPosition] = actualClickFigure.Name;

        //    currentFigure.currentButton.Content = "";
        //    currentFigure.CurrentPosition = actualClickFigure.NewPosition;
        //    currentFigure.NewPosition = "";
        //    currentFigure.currentButton = actualClickFigure.NewButton;
        //    currentFigure.CreateFigure();
        //    currentFigure.Movement = 1;
        //}

        public override bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure, bool freeField)
        {
            bool result = false;
            char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
            char currentLetterColumn = currentPosition[0];
            int currentNumberRow = int.Parse(currentPosition[1].ToString());

            char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
            int newPositionNumberRow = int.Parse(newPosition[1].ToString());
            char newPositionLetterColumn = newPosition[0];

            if (freeField)
            {

                if (currentLetterColumn == newPositionLetterColumn)
                {
                    if (currentNumberRow - 1 == newPositionNumberRow || (currentNumberRow - 2 == 5 && 5 == newPositionNumberRow))
                    {
                        result = true;
                    }
                }
            }
            else
            { // no free field
                if (currentLetterColumn - 1 == newPositionLetterColumn || currentLetterColumn + 1 == newPositionLetterColumn)
                {
                    if (currentNumberRow - 1 == newPositionNumberRow)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }



        public override bool CheckIfCorrectMovementBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {

            bool result = false;
            char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
            char currentLetterColumn = currentPosition[0];
            int currentNumberRow = int.Parse(currentPosition[1].ToString());

            char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
            int newPositionNumberRow = int.Parse(newPosition[1].ToString());
            char newPositionLetterColumn = newPosition[0];


            if (freeField)
            {
                if (currentLetterColumn == newPositionLetterColumn)
                {
                    if (currentNumberRow + 1 == newPositionNumberRow || (currentNumberRow + 2 == newPositionNumberRow && newPositionNumberRow == 4)) // example if first start pawn -> B2 -> 4B
                    {
                        result = true;
                    }
                }
            }
            else
            { // no free field
                if (currentLetterColumn - 1 == newPositionLetterColumn || currentLetterColumn + 1 == newPositionLetterColumn)
                {
                    if (currentNumberRow + 1 == newPositionNumberRow) // example if first start pawn -> B2 -> A3 or C3
                    {
                        result = true;
                    }
                }
            }


            return result;

        }

        public override bool CheckIfCorrectMovementWhiteOrBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }
    }
}
