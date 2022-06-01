using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessGameApp.Figure.ColorWhite
{
    class WhiteKnight : BasicFigure
    {
        
        public WhiteKnight(string name, string currentPosition, string newPosition, Button changeFigure) :  base(name, currentPosition, newPosition, changeFigure) { }
        

        public override void CreateFigure()
        {
            currentButton.Content = "♘"; //change figure
            currentButton.FontSize = 40;
        }
    }
}
