using ChessGameApp.Figure;
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
    public class PawnMovement
    {

        public void MovePawn(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            // check if the field is empty
            if ( chessBoard.TryGetValue(actualClickFigure.NewPosition, out string figure) )
            {
                switch (1)
                {
                    case 1:
                        bool correctMove = CheckIfCorrectMovement(actualClickFigure);
                        if (correctMove)
                        {
                            if (isMoveWhite)
                            { // white
                                CheckIfEmptyFieldOrRemoveBlackFigure(actualClickFigure, listOfPlayers, chessBoard);
                            } 
                            else
                            { // black
                                // CheckIfEmptyFieldOrRemoveWhiteFigure();
                            }
                            
                        }
                            
                        break;
                }
            }

            
        }

        private void CheckIfEmptyFieldOrRemoveBlackFigure(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard)
        {
           string fieldChessBoard = chessBoard.GetValueOrDefault(actualClickFigure.NewPosition);
           if ( fieldChessBoard.Equals(FreeField.FREE_FIELD.ToString()) )
            {

                BasicFigure currentFigure = listOfPlayers.ElementAt(0).ListOfFigures.FirstOrDefault(x => x == actualClickFigure);

                currentFigure.currentButton.Content = "";
                currentFigure.CurrentPosition = actualClickFigure.NewPosition;
                currentFigure.NewPosition = "";
                currentFigure.currentButton = actualClickFigure.NewButton;
                currentFigure.CreateFigure();

            } 
        }

        private bool CheckIfCorrectMovement(BasicFigure actualClickFigure)
        {

            bool result = false;     
            char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
            char currentLetterColumn = currentPosition[0];
            int currentNumberRow = int.Parse(currentPosition[1].ToString());

            char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
            int newPositionNumberRow = int.Parse(newPosition[1].ToString());
            char newPositionLetterColumn = newPosition[0];

            if (currentLetterColumn == newPositionLetterColumn || currentLetterColumn - 1 == newPositionLetterColumn || currentLetterColumn + 1 == newPositionLetterColumn)
            {
                if (currentNumberRow - 1 == newPositionNumberRow ||  (currentNumberRow - 2 == 5 && 5 == newPositionNumberRow) )
                {
                    result = true;
                }
            }


            return result;
            
        }
    }
}
