﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessGameApp.Figure.ColorWhite
{
    class WhiteBishop : BasicFigure
    {
        
        public WhiteBishop(string name, string currentPosition, string newPosition, Button changeFigure) : base(name, currentPosition, newPosition, changeFigure, 0) { }
        

        public override void CreateFigure()
        {
            ChangeFigure.Content = "♗"; //changed figure
            ChangeFigure.FontSize = 40;
        }
    }
}
