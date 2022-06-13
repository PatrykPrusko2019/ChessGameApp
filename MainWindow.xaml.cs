using ChessGameApp.Figure;
using ChessGameApp.Figure.ColorBlack;
using ChessGameApp.Figure.ColorWhite;
using ChessGameApp.LogicOfMovements;
using ChessGameApp.Names;
using ChessGameApp.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessGameApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isMoveWhite = true;

        public BasicFigure ActualClickFigure;

        public SearchMovement SearchMovement;

        public List<Player> ListOfPlayers;

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }


        public void NewGame()
        {
            //init black figures -> second player


            BlackRook firstBlackRook = new BlackRook(BlackFigureNames.FIRST_BLACK_ROOK.ToString(), "A1", "", A1);
            firstBlackRook.CreateFigure();
            BlackKnight firstBlackKnight = new BlackKnight(BlackFigureNames.FIRST_BLACK_KNIGHT.ToString(), "B1", "", B1);
            firstBlackKnight.CreateFigure();
            BlackBishop firstBlackBishop = new BlackBishop(BlackFigureNames.FIRST_BLACK_BISHOP.ToString(), "C1", "", C1);
            firstBlackBishop.CreateFigure();
            BlackQueen blackQueen = new BlackQueen(BlackFigureNames.BLACK_KING.ToString(), "D1", "", D1);
            blackQueen.CreateFigure();
            BlackKing blackKing = new BlackKing(BlackFigureNames.BLACK_QUEEN.ToString(), "E1", "", E1);
            blackKing.CreateFigure();
            BlackBishop secondBlackBishop = new BlackBishop(BlackFigureNames.SECOND_BLACK_BISHOP.ToString(), "F1", "", F1);
            secondBlackBishop.CreateFigure();
            BlackKnight secondBlackKnight = new BlackKnight(BlackFigureNames.SECOND_BLACK_KNIGHT.ToString(), "G1", "", G1);
            secondBlackKnight.CreateFigure();
            BlackRook secondBlackRook = new BlackRook(BlackFigureNames.SECOND_BLACK_ROCK.ToString(), "H1", "", H1);
            secondBlackRook.CreateFigure();

            BlackPawn firstBlackPawn = new BlackPawn(BlackFigureNames.FIRST_BLACK_PAWN.ToString(), "A2", "", A2);
            firstBlackPawn.CreateFigure();
            BlackPawn secondBlackPawn = new BlackPawn(BlackFigureNames.SECOND_BLACK_PAWN.ToString(), "B2", "", B2);
            secondBlackPawn.CreateFigure();
            BlackPawn thirdBlackPawn = new BlackPawn(BlackFigureNames.THIRD_BLACK_PAWN.ToString(), "C2", "", C2);
            thirdBlackPawn.CreateFigure();
            BlackPawn fourthBlackPawn = new BlackPawn(BlackFigureNames.FOURTH_BLACK_PAWN.ToString(), "D2", "", D2);
            fourthBlackPawn.CreateFigure();
            BlackPawn fifthBlackPawn = new BlackPawn(BlackFigureNames.FIFTH_BLACK_PAWN.ToString(), "E2", "", E2);
            fifthBlackPawn.CreateFigure();
            BlackPawn sixthBlackPawn = new BlackPawn(BlackFigureNames.SIXTH_BLACK_PAWN.ToString(), "F2", "", F2);
            sixthBlackPawn.CreateFigure();
            BlackPawn seventhBlackPawn = new BlackPawn(BlackFigureNames.SEVENTH_BLACK_PAWN.ToString(), "G2", "", G2);
            seventhBlackPawn.CreateFigure();
            BlackPawn eighthBlackPawn = new BlackPawn(BlackFigureNames.EIGHT_BLACK_PAWN.ToString(), "H2", "", H2);
            eighthBlackPawn.CreateFigure();


            //init white figures -> first player
            WhiteRook firstWhiteRook = new WhiteRook(WhiteFigureNames.FIRST_WHITE_ROOK.ToString(), "A8", "", A8);
            firstWhiteRook.CreateFigure();
            WhiteKnight firstWhiteKnight = new WhiteKnight(WhiteFigureNames.FIRST_WHITE_KNIGHT.ToString(), "B8", "", B8);
            firstWhiteKnight.CreateFigure();
            WhiteBishop firstWhiteBishop = new WhiteBishop(WhiteFigureNames.FIRST_WHITE_BISHOP.ToString(), "C8", "", C8);
            firstWhiteBishop.CreateFigure();
            WhiteQueen whiteQueen = new WhiteQueen(WhiteFigureNames.WHITE_KING.ToString(), "D8", "", D8);
            whiteQueen.CreateFigure();
            WhiteKing whiteKing = new WhiteKing(WhiteFigureNames.WHITE_QUEEN.ToString(), "E8", "", E8);
            whiteKing.CreateFigure();
            WhiteBishop secondWhiteBishop = new WhiteBishop(WhiteFigureNames.SECOND_WHITE_BISHOP.ToString(), "F8", "", F8);
            secondWhiteBishop.CreateFigure();
            WhiteKnight secondWhiteKnight = new WhiteKnight(WhiteFigureNames.SECOND_WHITE_KNIGHT.ToString(), "G8", "", G8);
            secondWhiteKnight.CreateFigure();
            WhiteRook secondWhiteRook = new WhiteRook(WhiteFigureNames.SECOND_WHITE_ROCK.ToString(), "H8", "", H8);
            secondWhiteRook.CreateFigure();

            WhitePawn firstWhitePawn = new WhitePawn(WhiteFigureNames.FIRST_WHITE_PAWN.ToString(), "A7", "", A7);
            firstWhitePawn.CreateFigure();
            WhitePawn secondWhitePawn = new WhitePawn(WhiteFigureNames.SECOND_WHITE_PAWN.ToString(), "B7", "", B7);
            secondWhitePawn.CreateFigure();
            WhitePawn thirdWhitePawn = new WhitePawn(WhiteFigureNames.THIRD_WHITE_PAWN.ToString(), "C7", "", C7);
            thirdWhitePawn.CreateFigure();
            WhitePawn fourthWhitePawn = new WhitePawn(WhiteFigureNames.FOURTH_WHITE_PAWN.ToString(), "D7", "", D7);
            fourthWhitePawn.CreateFigure();
            WhitePawn fifthWhitePawn = new WhitePawn(WhiteFigureNames.FIFTH_WHITE_PAWN.ToString(), "E7", "", E7);
            fifthWhitePawn.CreateFigure();
            WhitePawn sixthWhitePawn = new WhitePawn(WhiteFigureNames.SIXTH_WHITE_PAWN.ToString(), "F7", "", F7);
            sixthWhitePawn.CreateFigure();
            WhitePawn seventhWhitePawn = new WhitePawn(WhiteFigureNames.SEVENTH_WHITE_PAWN.ToString(), "G7", "", G7);
            seventhWhitePawn.CreateFigure();
            WhitePawn eighthWhitePawn = new WhitePawn(WhiteFigureNames.EIGHT_WHITE_PAWN.ToString(), "H7", "", H7);
            eighthWhitePawn.CreateFigure();


            //adds all the figures
            ListOfPlayers = new List<Player>();

            FirstWhitePlayer firstWhitePlayer = new FirstWhitePlayer("FirstWhitePlayer", new List<BasicFigure>());
            firstWhitePlayer.ListOfFigures.Add(firstWhiteRook);
            firstWhitePlayer.ListOfFigures.Add(firstWhiteKnight);
            firstWhitePlayer.ListOfFigures.Add(firstWhiteBishop);
            firstWhitePlayer.ListOfFigures.Add(whiteQueen);
            firstWhitePlayer.ListOfFigures.Add(whiteKing);
            firstWhitePlayer.ListOfFigures.Add(secondWhiteBishop);
            firstWhitePlayer.ListOfFigures.Add(secondWhiteKnight);
            firstWhitePlayer.ListOfFigures.Add(secondWhiteRook);

            firstWhitePlayer.ListOfFigures.Add(firstWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(secondWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(thirdWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(fourthWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(fifthWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(sixthWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(seventhWhitePawn);
            firstWhitePlayer.ListOfFigures.Add(eighthWhitePawn);

            ListOfPlayers.Add(firstWhitePlayer);

            SecondBlackPlayer secondBlackPlayer = new SecondBlackPlayer("SecondBlackPlayer", new List<BasicFigure>());
            secondBlackPlayer.ListOfFigures.Add(firstBlackRook);
            secondBlackPlayer.ListOfFigures.Add(firstBlackKnight);
            secondBlackPlayer.ListOfFigures.Add(firstBlackBishop);
            secondBlackPlayer.ListOfFigures.Add(blackQueen);
            secondBlackPlayer.ListOfFigures.Add(blackKing);
            secondBlackPlayer.ListOfFigures.Add(secondBlackBishop);
            secondBlackPlayer.ListOfFigures.Add(secondBlackKnight);
            secondBlackPlayer.ListOfFigures.Add(secondBlackRook);

            secondBlackPlayer.ListOfFigures.Add(firstBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(secondBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(thirdBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(fourthBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(fifthBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(sixthBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(seventhBlackPawn);
            secondBlackPlayer.ListOfFigures.Add(eighthBlackPawn);

            ListOfPlayers.Add(secondBlackPlayer);

            SearchMovement = new SearchMovement();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button currentFieldByPlayer = (Button)sender;

            if (ActualClickFigure == null)
            {
                if (!CheckIfCorrectPlayerMovement(currentFieldByPlayer)) { MessageBox.Show("Please choose good color of figure !!!"); return; }

            }

            if (isMoveWhite)
            {
                MoveWhite(currentFieldByPlayer);
            }
            else
            {
                MoveBlack(currentFieldByPlayer);
            }






            // tests change position figure 

            //BasicFigure firstBlackPawn = ListOfFigures.ElementAt(8);



            //if (currentFieldByPlayer.Name == firstBlackPawn.CurrentPosition) // A2
            //{
            //    firstBlackPawn.NumberOfClicks++;
            //    MessageBox.Show("Good choice !!!");

            //    MessageBox.Show("count = " + firstBlackPawn.NumberOfClicks);


            //}

            //if (firstBlackPawn.NumberOfClicks == 2)
            //{
            //    firstBlackPawn.CreateFigure();
            //    firstBlackPawn.ChangeFigure.Content = "";
            //    firstBlackPawn.ChangeFigure = currentFieldByPlayer;
            //    firstBlackPawn.CreateFigure();

            //}

        }

        private bool CheckIfCorrectPlayerMovement(Button currentFieldByPlayer)
        {
            if (isMoveWhite)
            {
                foreach (var item in ListOfPlayers.ElementAt(0).ListOfFigures) // white figures
                {
                    if (item.CurrentPosition == currentFieldByPlayer.Name)
                    {
                        ActualClickFigure = item;
                        MessageBox.Show("current position field white -> " + currentFieldByPlayer.Name + ", name of figure: " + item.Name);
                        return true;
                    }
                }
            }
            else
            {
                foreach (var item in ListOfPlayers.ElementAt(1).ListOfFigures)
                {
                    if (item.CurrentPosition == currentFieldByPlayer.Name)
                    {
                        ActualClickFigure = item;
                        MessageBox.Show("current position field black -> " + currentFieldByPlayer.Name + ", name of figure: " + item.Name);
                        return true;
                    }
                }
            }
            return false;
        }

        private void MoveWhite(Button currentFieldByPlayer)
        {
            if (ActualClickFigure != null && ActualClickFigure.CurrentPosition != currentFieldByPlayer.Name)
            {
                MessageBox.Show("new position field white -> " + currentFieldByPlayer.Name);
                ActualClickFigure.NewPosition = currentFieldByPlayer.Name;
                ActualClickFigure.NewButton = currentFieldByPlayer;
                SearchMovement.SearchByMove(ActualClickFigure, ListOfPlayers, isMoveWhite);

                if (ActualClickFigure.Movement == 1) { isMoveWhite = false; ActualClickFigure.Movement = 0; ActualClickFigure = null; }
                else { MessageBox.Show("wrong movement. Please choose new white figure !!!"); ActualClickFigure = null; }

            }

        }


        private void MoveBlack(Button currentFieldByPlayer)
        {
            if (ActualClickFigure != null && ActualClickFigure.CurrentPosition != currentFieldByPlayer.Name)
            {
                MessageBox.Show("new position field black -> " + currentFieldByPlayer.Name);
                ActualClickFigure.NewPosition = currentFieldByPlayer.Name;
                ActualClickFigure.NewButton = currentFieldByPlayer;
                SearchMovement.SearchByMove(ActualClickFigure, ListOfPlayers, isMoveWhite);

                if (ActualClickFigure.Movement == 1) { isMoveWhite = true; ActualClickFigure.Movement = 0; ActualClickFigure = null; }
                else { MessageBox.Show("wrong movement !!! Please choose new black figure !!!"); ActualClickFigure = null; }
            }

        }
    }
}
