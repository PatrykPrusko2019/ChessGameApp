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

        public bool MovePawn(BasicFigure actualClickFigure, List<Player> listOfPlayers, Dictionary<string, string> chessBoard, bool isMoveWhite)
        {
            // check if the field is empty
           string figure = chessBoard.FirstOrDefault(x => actualClickFigure.NewPosition == x.Key).Value;
           
           if (figure == "FREE_FIELD" && isMoveWhite && CheckIfCorrectMovementWhiteFigure(actualClickFigure))
            { //white
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[0], chessBoard);
            }
           else if (figure == "FREE_FIELD" && !isMoveWhite && CheckIfCorrectMovementBlackFigure(actualClickFigure))
            { //Black
                ChangePositionOfFigure(actualClickFigure, listOfPlayers[1], chessBoard);
            }
           else
            {
<<<<<<< HEAD
                return false;
            }
            return true;
                            
        }
             
                       
            

        
        private void ChangePositionOfFigure(BasicFigure actualClickFigure, Player listOfPlayers, Dictionary<string, string> chessBoard)
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

        private bool CheckIfCorrectMovementWhiteFigure(BasicFigure actualClickFigure)
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
                if (currentNumberRow - 1 == newPositionNumberRow || (currentNumberRow - 2 == 5 && 5 == newPositionNumberRow && currentLetterColumn == newPositionLetterColumn) )
                {
                    result = true;
=======
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
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
                }
            }

            return result;
        }

<<<<<<< HEAD
        

        private bool CheckIfCorrectMovementBlackFigure(BasicFigure actualClickFigure)
        {

            bool result = false;
=======
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
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
            char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
            char currentLetterColumn = currentPosition[0];
            int currentNumberRow = int.Parse(currentPosition[1].ToString());

            char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
            int newPositionNumberRow = int.Parse(newPosition[1].ToString());
            char newPositionLetterColumn = newPosition[0];

            if (currentLetterColumn == newPositionLetterColumn || currentLetterColumn - 1 == newPositionLetterColumn || currentLetterColumn + 1 == newPositionLetterColumn)
            {
<<<<<<< HEAD
                if (currentNumberRow + 1 == newPositionNumberRow || (currentNumberRow + 2 == newPositionNumberRow && newPositionNumberRow == 4 && currentLetterColumn == newPositionLetterColumn)) // example if first start pawn -> B2 -> 4B
=======
                if (currentNumberRow - 1 == newPositionNumberRow ||  (currentNumberRow - 2 == 5 && 5 == newPositionNumberRow) )
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
                {
                    result = true;
                }
            }


            return result;
<<<<<<< HEAD

=======
            
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
        }
    }
}
