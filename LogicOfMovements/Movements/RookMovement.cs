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
            ChessBoard = chessBoard;

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
            else if (!isMoveWhite && CheckIfCorrectMovementBlackFigure(actualClickFigure, false) && CheckIsThereAndRemoveWhiteFigure(actualClickFigure, listOfPlayers[0], chessBoard))
            {   // black and remove white figure
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
            else
            {
                return false;
            }
            return true;
        }


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
            { // letters

                if (currentLetterColumn == newPositionLetterColumn && currentNumberRow + newPositionNumberRow > currentNumberRow) // A == A && 1 + 4 > 1 -> down
                {
                    for (int i = currentNumberRow+1; i < newPositionNumberRow+1; i++) // 2 < 5
                    {
                        string tempNumberRow = newPositionLetterColumn +""+ i;
                        // check if the field is empty
                        string figure = ChessBoard.FirstOrDefault(x => tempNumberRow == x.Key).Value;
                        if (figure != "FREE_FIELD") return false;
                    }
                    result = true;
                }
                else if (currentLetterColumn == newPositionLetterColumn && currentNumberRow - newPositionNumberRow < currentNumberRow) // A == A && 4 - 1 < 4 -> up
                {
                    for (int i = currentNumberRow - 1; i > newPositionNumberRow-1; i--) // 3 > 0
                    {
                        string tempNumberRow = newPositionLetterColumn + "" + i;
                        // check if the field is empty
                        string figure = ChessBoard.FirstOrDefault(x => tempNumberRow == x.Key).Value;
                        if (figure != "FREE_FIELD") return false;
                    }
                    result = true;
                }
            }
            else // numbers
            { // no free field and possibility remove black figure
                if (currentNumberRow == newPositionNumberRow && currentLetterColumn + newPositionLetterColumn > currentNumberRow) // 4 == 4 && A + H > A -> right
                {
                    for (int c = currentLetterColumn + 1; c < newPositionLetterColumn + 1; c++) // B < I
                    {
                        string tempLetterColumn = c + "" + newPositionNumberRow;
                        // check if the field is empty
                        string figure = ChessBoard.FirstOrDefault(x => tempLetterColumn == x.Key).Value;
                        if (figure != "FREE_FIELD") return false;
                    }
                    result = true;

                }
                else if (currentNumberRow == newPositionNumberRow && currentLetterColumn - newPositionLetterColumn < currentNumberRow) // 4 == 4 && H - A < H -> left
                {
                     for (int c = currentLetterColumn-1; c > newPositionLetterColumn-1; c--) // G > A-1
                     {
                         string tempLetterColumn = c + "" + newPositionNumberRow;
                         // check if the field is empty
                         string figure = ChessBoard.FirstOrDefault(x => tempLetterColumn == x.Key).Value;
                         if (figure != "FREE_FIELD") return false;
                     }
                     result = true;
                }

            }

            return result;
        }


    }
}
