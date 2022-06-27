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
    public class KingMovement : Movement
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


            if ( CheckIfRookMovement(currentLetterColumn, currentNumberRow, newPositionNumberRow, newPositionLetterColumn, freeField) ||
                CheckIfBishopMovement(currentLetterColumn, currentNumberRow, newPositionNumberRow, newPositionLetterColumn, freeField))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckIfRookMovement(char currentLetterColumn, int currentNumberRow, int newPositionNumberRow, char newPositionLetterColumn, bool freeField)
        {
            bool result = false;

            // check 4 possibilities : 
            char firstLeftLetterColumn = (char)(currentLetterColumn - 1); 
            char secondRightLetterColumn = (char)(currentLetterColumn + 1);


            // left
            if (currentNumberRow == newPositionNumberRow && firstLeftLetterColumn == newPositionLetterColumn) // B5 -> A5 , letterColumn : change
            {
                result = true;
            }
            else if (currentNumberRow == newPositionNumberRow && secondRightLetterColumn == newPositionLetterColumn) // right -> B5 -> C5, letterColumn : change
            {
                result = true;
            }
            else if (currentNumberRow-1 == newPositionNumberRow && currentLetterColumn == newPositionLetterColumn) // up -> B5 -> B4 , numberRow : change
            {
                result = true;
            }
            else if (currentNumberRow+1 == newPositionNumberRow && currentLetterColumn == newPositionLetterColumn) // down -> B5 -> B6, numberRow : change
            {
                result = true;
            }

            return result;
        }

        private bool CheckIfBishopMovement(char currentLetterColumn, int currentNumberRow, int newPositionNumberRow, char newPositionLetterColumn, bool freeField)
        {
            bool result = false;
            // check 4 possibilities : north-west
            char firstWestLetterColumn = (char)(currentLetterColumn - 1); 
            char secondEastLetterColumn = (char)(currentLetterColumn + 1);


            // north-west -> north: numberRow, west: letterColumn
            if (currentNumberRow-1 == newPositionNumberRow && firstWestLetterColumn == newPositionLetterColumn) // B5 -> A4
            {
                result = true;
            }
            else if (currentNumberRow+1 == newPositionNumberRow && firstWestLetterColumn == newPositionLetterColumn) // south-west -> south: numberRow, west: letterColumn, B5 -> A6
            {
                result = true;
            }
            else if (currentNumberRow-1 == newPositionNumberRow && secondEastLetterColumn == newPositionLetterColumn) // north-east -> north: numberRow, east: letterColumn, B5 -> C4
            {
                result = true;
            }
            else if (currentNumberRow+1 == newPositionNumberRow && secondEastLetterColumn == newPositionLetterColumn) // south-east -> south: numberRow, east: letterColumn, B5 -> C6
            {
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
