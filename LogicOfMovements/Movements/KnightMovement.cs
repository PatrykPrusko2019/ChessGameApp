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
    class KnightMovement : Movement
    {
        public override bool MoveFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            ChessBoard = chessBoard;

            // check if the field is empty
            string figure = chessBoard.FirstOrDefault(x => actualClickFigure.NewPosition == x.Key).Value;

            if (figure == "FREE_FIELD" && isMoveWhite && CheckIfCorrectMovementWhiteOrBlackFigure(actualClickFigure, true))
            { //white
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[0], chessBoard);
            }
            else if (figure == "FREE_FIELD" && !isMoveWhite && CheckIfCorrectMovementWhiteOrBlackFigure(actualClickFigure, true))
            { //Black
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
            else if (isMoveWhite && CheckIfCorrectMovementWhiteOrBlackFigure(actualClickFigure, false) && CheckIsThereAndRemoveBlackFigure(actualClickFigure, listOfPlayers[1], chessBoard))
            {   // white and remove black figure
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[0], chessBoard);
            }
            else if (!isMoveWhite && CheckIfCorrectMovementWhiteOrBlackFigure(actualClickFigure, false) && CheckIsThereAndRemoveWhiteFigure(actualClickFigure, listOfPlayers[0], chessBoard))
            {   // black and remove white figure
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
            else
            {
                return false;
            }
            return true;
        }

        public override bool CheckIfCorrectMovementWhiteOrBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {
            char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
            char currentLetterColumn = currentPosition[0];
            int currentNumberRow = int.Parse(currentPosition[1].ToString());

            char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
            int newPositionNumberRow = int.Parse(newPosition[1].ToString());
            char newPositionLetterColumn = newPosition[0];

            return CheckIfLetterOrNumber(currentLetterColumn, currentNumberRow, newPositionNumberRow, newPositionLetterColumn);
        }

        
        private bool CheckIfLetterOrNumber(char currentLetterColumn, int currentNumberRow, int newPositionNumberRow, char newPositionLetterColumn)
        {
            bool result = false;


            char rightSecondTemporaryLetterColumn = (char)(currentLetterColumn + 2);
            char rightFirstTemporaryLetterColumn = (char)(currentLetterColumn + 1);
            char leftSecondTemporaryLetterColumn = (char)(currentLetterColumn - 2);
            char leftFirstTemporaryLetterColumn = (char)(currentLetterColumn - 1);
            // check 8 possibilities
            if (currentNumberRow - 1 == newPositionNumberRow && rightSecondTemporaryLetterColumn == newPositionLetterColumn) // change numberRow up -> 1, change letterColumn right -> 2  example -> C3 -> E2 || change letterColumn right -> 2, change numberRow up -> 1 example C3 -> E2
            {
                result = true;
            }
            else if (currentNumberRow - 2 == newPositionNumberRow && rightFirstTemporaryLetterColumn == newPositionLetterColumn) // change numberRow up -> 2, change letterColumn right -> 1 // change letterColumn right -> 1, change numberRow up -> 2 example C3 -> D1
            {
                result = true;
            }
            else if (currentNumberRow - 1 == newPositionNumberRow && leftSecondTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn left -> 2, change numberRow up -> 1 // change numberRow up -> 1, change letterColumn left -> 2  example C3 -> A2
            {
                result = true;
            }
            else if (currentNumberRow - 2 == newPositionNumberRow && leftFirstTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn left -> 1, change numberRow up -> 2 // change numberRow up -> 2, change letterColumn left -> 1  example C3 -> B1
            {
                result = true;
            }
            else if (currentNumberRow + 1 == newPositionNumberRow && leftSecondTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn left -> 2, change numberRow down -> 1 // change numberRow down -> 1, change letterColumn left -> 2  example C3 -> A4
            {
                result = true;
            }
            else if (currentNumberRow + 2 == newPositionNumberRow && leftFirstTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn left -> 1, change numberRow down -> 2 // change numberRow down -> 2, change letterColumn left -> 1  example C3 -> B5
            {
                result = true;
            }
            else if (currentNumberRow + 2 == newPositionNumberRow && rightFirstTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn right -> 1, change numberRow down -> 2 // change numberRow down -> 2, change letterColumn right -> 1  example C3 -> D5
            {
                result = true;
            }
            else if (currentNumberRow + 1 == newPositionNumberRow && rightSecondTemporaryLetterColumn == newPositionLetterColumn) // change letterColumn right -> 2, change numberRow down -> 1 // change numberRow down -> 1, change letterColumn right -> 2  example C3 -> E4
            {
                result = true;
            }


            return result;
        }

        public override bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }

        public override bool CheckIfCorrectMovementBlackFigure(BasicFigure actualClickFigure, bool freeField)
        {
            throw new NotImplementedException();
        }
    }
}
