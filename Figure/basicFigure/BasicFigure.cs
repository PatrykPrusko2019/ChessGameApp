using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessGameApp.Figure
{
    public abstract class BasicFigure
    {
        public string Name { get; set; }
        public string CurrentPosition { get; set; }
        public string NewPosition { get; set; }
        public Button currentButton { get; set; }
        public Button NewButton { get; set; }
        public BasicFigure(string name, string currentPosition, string newPosition, Button changeFigure)
        {
            Name = name;
            CurrentPosition = currentPosition;
            NewPosition = newPosition;
            currentButton = changeFigure;
            
        }

        public abstract void CreateFigure();
    }
}
