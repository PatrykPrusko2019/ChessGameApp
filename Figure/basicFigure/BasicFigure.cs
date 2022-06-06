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
<<<<<<< HEAD

        public int Movement { get; set; } // 0 -> no move, 1 -> ok move 
=======
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
        public BasicFigure(string name, string currentPosition, string newPosition, Button changeFigure)
        {
            Name = name;
            CurrentPosition = currentPosition;
            NewPosition = newPosition;
            currentButton = changeFigure;
<<<<<<< HEAD
            Movement = 0;
=======
>>>>>>> 924f59b94eb1cc707c679738aeca7f0dd53be9f1
            
        }

        public abstract void CreateFigure();
    }
}
