using ChessGameApp.Figure;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.LogicOfMovements.Movements.BasicMovement
{
    public class BishopMovement : Movement
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

            return CheckIfLetterOrNumber(currentLetterColumn, currentNumberRow, newPositionNumberRow, newPositionLetterColumn, freeField);
        }

        private bool CheckIfLetterOrNumber(char currentLetterColumn, int currentNumberRow, int newPositionNumberRow, char newPositionLetterColumn, bool freeField)
        {
            bool result = false;
            string newPosition = newPositionLetterColumn + "" + newPositionNumberRow;

            // check 4 possibilities : north-west
            char firstWestLetterColumn = (char)(currentLetterColumn - 1); // check  char firstNorthWestOrSouthWestLetterColumn = currentLetterColumn - 1;
            char secondEastLetterColumn = (char)(currentLetterColumn + 1);
            

            // north-west -> north: numberRow, west: letterColumn
            if (currentNumberRow > newPositionNumberRow && currentLetterColumn > newPositionLetterColumn) // D4 -> A1
            {
                for (currentNumberRow = currentNumberRow - 1; (firstWestLetterColumn > (char)(newPositionLetterColumn - 1) ) && (currentNumberRow > newPositionNumberRow - 1) ; currentNumberRow--)
                {
                    string tempNextNewPosition = firstWestLetterColumn + "" + currentNumberRow;
                    if (!CheckIfFieldIsEmpty(tempNextNewPosition))
                    {
                        if (tempNextNewPosition == newPosition && !freeField) return true;  // remove figure white or black
                        else return false;
                    }
                    firstWestLetterColumn--;
                }
                result = true;
            }
            else if (currentNumberRow < newPositionNumberRow && currentLetterColumn > newPositionLetterColumn) // south-west -> south: numberRow, west: letterColumn, D4 -> A7
            {
                for (currentNumberRow = currentNumberRow + 1; (firstWestLetterColumn > (char)(newPositionLetterColumn - 1)) && (currentNumberRow < newPositionNumberRow + 1); currentNumberRow++)
                {
                    string tempNextNewPosition = firstWestLetterColumn + "" + currentNumberRow;
                    if (!CheckIfFieldIsEmpty(tempNextNewPosition))
                    {
                        if (tempNextNewPosition == newPosition && !freeField) return true;  // remove figure white or black
                        else return false;
                    }
                    firstWestLetterColumn--;
                }
                result = true;
            }
            else if (currentNumberRow > newPositionNumberRow && currentLetterColumn < newPositionLetterColumn) // north-east -> north: numberRow, east: letterColumn, D4 -> G7
            {
                for (currentNumberRow = currentNumberRow - 1; (secondEastLetterColumn < (char)(newPositionLetterColumn + 1)) && (currentNumberRow > newPositionNumberRow - 1); currentNumberRow--)
                {
                    string tempNextNewPosition = secondEastLetterColumn + "" + currentNumberRow;
                    if (!CheckIfFieldIsEmpty(tempNextNewPosition))
                    {
                        if (tempNextNewPosition == newPosition && !freeField) return true;  // remove figure white or black
                        else return false;
                    }
                    secondEastLetterColumn++;
                }
                result = true;
            }
            else if (currentNumberRow < newPositionNumberRow && currentLetterColumn < newPositionLetterColumn) // south-east -> south: numberRow, east: letterColumn, D4 -> H8
            {
                for (currentNumberRow = currentNumberRow + 1; (secondEastLetterColumn < (char)(newPositionLetterColumn + 1)) && (currentNumberRow < newPositionNumberRow + 1); currentNumberRow++)
                {
                    string tempNextNewPosition = secondEastLetterColumn + "" + currentNumberRow;
                    if (!CheckIfFieldIsEmpty(tempNextNewPosition))
                    {
                        if (tempNextNewPosition == newPosition && !freeField) return true;  // remove figure white or black
                        else return false;
                    }
                    secondEastLetterColumn++;
                }
                result = true;
            }


            return result;
        }

        public bool CheckIfFieldIsEmpty(string tempLetterColumnAndNumberRow)
        {
            // check if the field is empty
            string figure = ChessBoard.FirstOrDefault(x => tempLetterColumnAndNumberRow == x.Key).Value;
            if (figure != "FREE_FIELD") return false;
            else return true;
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
