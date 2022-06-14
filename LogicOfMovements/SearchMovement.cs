using ChessGameApp.Figure;
using ChessGameApp.LogicOfMovements.Movements;
using ChessGameApp.LogicOfMovements.Movements.BasicMovement;
using ChessGameApp.Names;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameApp.LogicOfMovements
{
    public class SearchMovement
    {
        public Dictionary<string, string> ChessBoard { get; set; }

        public FirstWhitePlayer FirstWhitePlayer { get; set; }
        public SecondBlackPlayer SecondBlackPlayer { get; set; }
        public List<Movement> Movement { get; set; }
        public SearchMovement()
        {
            Movement = new List<Movement>();
            Movement.Add(new PawnMovement()); // 0 -> pawn movement
            Movement.Add(new RookMovement()); // 1 -> rook movement

            ChessBoard = new Dictionary<string, string>();

            //todo
            ChessBoard.Add("A1", BlackFigureNames.FIRST_BLACK_ROOK.ToString());
            ChessBoard.Add("B1", BlackFigureNames.FIRST_BLACK_KNIGHT.ToString());
            ChessBoard.Add("C1", BlackFigureNames.FIRST_BLACK_BISHOP.ToString());
            ChessBoard.Add("D1", BlackFigureNames.BLACK_KING.ToString());
            ChessBoard.Add("E1", BlackFigureNames.BLACK_QUEEN.ToString());
            ChessBoard.Add("F1", BlackFigureNames.SECOND_BLACK_BISHOP.ToString());
            ChessBoard.Add("G1", BlackFigureNames.SECOND_BLACK_KNIGHT.ToString());
            ChessBoard.Add("H1", BlackFigureNames.SECOND_BLACK_ROCK.ToString());

            ChessBoard.Add("A2", BlackFigureNames.FIRST_BLACK_PAWN.ToString());
            ChessBoard.Add("B2", BlackFigureNames.SECOND_BLACK_ROCK.ToString());
            ChessBoard.Add("C2", BlackFigureNames.THIRD_BLACK_PAWN.ToString());
            ChessBoard.Add("D2", BlackFigureNames.FOURTH_BLACK_PAWN.ToString());
            ChessBoard.Add("E2", BlackFigureNames.FIFTH_BLACK_PAWN.ToString());
            ChessBoard.Add("F2", BlackFigureNames.SIXTH_BLACK_PAWN.ToString());
            ChessBoard.Add("G2", BlackFigureNames.SEVENTH_BLACK_PAWN.ToString());
            ChessBoard.Add("H2", BlackFigureNames.EIGHT_BLACK_PAWN.ToString());

            for (int i = 3; i < 7; i++)
            {
                for (char a = 'A'; a < 'I'; a++)
                {
                    ChessBoard.Add(a + "" + i, FreeField.FREE_FIELD.ToString());
                }
            }

            ChessBoard.Add("A7", WhiteFigureNames.FIRST_WHITE_PAWN.ToString());
            ChessBoard.Add("B7", WhiteFigureNames.SECOND_WHITE_PAWN.ToString());
            ChessBoard.Add("C7", WhiteFigureNames.THIRD_WHITE_PAWN.ToString());
            ChessBoard.Add("D7", WhiteFigureNames.FOURTH_WHITE_PAWN.ToString());
            ChessBoard.Add("E7", WhiteFigureNames.FIFTH_WHITE_PAWN.ToString());
            ChessBoard.Add("F7", WhiteFigureNames.SIXTH_WHITE_PAWN.ToString());
            ChessBoard.Add("G7", WhiteFigureNames.SEVENTH_WHITE_PAWN.ToString());
            ChessBoard.Add("H7", WhiteFigureNames.EIGHT_WHITE_PAWN.ToString());

            ChessBoard.Add("A8", WhiteFigureNames.FIRST_WHITE_ROOK.ToString());
            ChessBoard.Add("B8", WhiteFigureNames.FIRST_WHITE_KNIGHT.ToString());
            ChessBoard.Add("C8", WhiteFigureNames.FIRST_WHITE_BISHOP.ToString());
            ChessBoard.Add("D8", WhiteFigureNames.WHITE_KING.ToString());
            ChessBoard.Add("E8", WhiteFigureNames.WHITE_QUEEN.ToString());
            ChessBoard.Add("F8", WhiteFigureNames.SECOND_WHITE_BISHOP.ToString());
            ChessBoard.Add("G8", WhiteFigureNames.SECOND_WHITE_KNIGHT.ToString());
            ChessBoard.Add("H8", WhiteFigureNames.SECOND_WHITE_ROCK.ToString());




        }

        public void SearchByMove(BasicFigure actualClickFigure, List<Player> listOfPlayers, bool isMoveWhite)
        {
            if (isMoveWhite)
            {
                CheckWhiteFigures(actualClickFigure, listOfPlayers, isMoveWhite);
            }
            else
            {
                CheckBlackFigures(actualClickFigure, listOfPlayers, isMoveWhite);
            }
        }


        

        private void CheckWhiteFigures(BasicFigure actualClickFigure, List<Player> listOfPlayers, bool isMoveWhite)
        {
            
            switch (actualClickFigure.Name)
            {
                case "FIRST_WHITE_ROOK":

                    break;

                case "FIRST_WHITE_KNIGHT":

                    break;

                case "FIRST_WHITE_BISHOP":

                    break;

                case "WHITE_KING":

                    break;

                case "WHITE_QUEEN":

                    break;

                case "SECOND_WHITE_BISHOP":

                    break;

                case "SECOND_WHITE_KNIGHT":

                    break;

                case "SECOND_WHITE_ROCK":

                    break;

                case "FIRST_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SECOND_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "THIRD_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "FOURTH_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "FIFTH_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SIXTH_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SEVENTH_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "EIGHT_WHITE_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                
            }



        }

        private void CheckBlackFigures(BasicFigure actualClickFigure, List<Player> listOfPlayers, bool isMoveWhite)
        {
            switch (actualClickFigure.Name)
            {
                case "FIRST_BLACK_ROOK":

                    break;

                case "FIRST_BLACK_KNIGHT":

                    break;

                case "FIRST_BLACK_BISHOP":

                    break;

                case "BLACK_KING":

                    break;

                case "BLACK_QUEEN":

                    break;

                case "SECOND_BLACK_BISHOP":

                    break;

                case "SECOND_BLACK_KNIGHT":

                    break;

                case "SECOND_BLACK_ROCK":

                    break;

                case "FIRST_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SECOND_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "THIRD_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "FOURTH_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "FIFTH_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SIXTH_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "SEVENTH_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

                case "EIGHT_BLACK_PAWN":
                    Movement.ElementAt(0).MoveFigure(actualClickFigure, listOfPlayers, ChessBoard, isMoveWhite);
                    break;

            }
        }
    }
}
