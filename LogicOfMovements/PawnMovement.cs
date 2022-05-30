using ChessGameApp.Figure;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        CheckIfCorrectMovement(actualClickFigure);

                        break;
                }
            }

            
        }

        private bool CheckIfCorrectMovement(BasicFigure actualClickFigure)
        {

           bool result = false;     
           char[] currentPosition = actualClickFigure.CurrentPosition.ToCharArray();
           
           if (actualClickFigure.CurrentPosition == "A7" || actualClickFigure.CurrentPosition == "H7")
            {
                char[] newPosition = actualClickFigure.NewPosition.ToCharArray();
                int numberRow = int.Parse(newPosition[1].ToString());
                char letter = newPosition[0];
                // 3 moves available
                switch (numberRow)
                {
                    case 1:
                        if (numberRow - 1 == 6 && letter == 'A') result = true;
                        break;
                    case 2:
                        if (numberRow - 2 == 5 && letter == 'A') result = true;
                        break;
                    case 3:
                        if (numberRow - 1 == 6 && letter + 1 == 'B') result = true;
                        break;
                }
                //to do
            } else if ()
        }
    }
}
