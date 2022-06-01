﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessGameApp.Figure.ColorBlack
{
    class BlackBishop : BasicFigure
    {
        public BlackBishop(string name, string currentPosition, string newPosition, Button changeFigure) : base(name, currentPosition, newPosition, changeFigure) { }

        public override void CreateFigure()
        {
            currentButton.Content = "♝"; //changed figure
            currentButton.FontSize = 40;
        }
    }
}
