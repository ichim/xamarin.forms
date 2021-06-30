using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swipe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int referee_col = 1;
        int referee_row = 1;
        int ball_col = 1;
        int ball_row = 0;
        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.ball);
            int row = Grid.GetRow(this.ball);
            switch(e.Direction)
            {
                case SwipeDirection.Left:
                    col--;
                    break;
                case SwipeDirection.Right:
                    col++;
                    break;
                case SwipeDirection.Up:
                    row--;
                    break;
                case SwipeDirection.Down:
                    row++;
                    break;
            }
            if(col !=referee_col|| row!=referee_row)
            {
                Grid.SetColumn(this.ball, col);
                Grid.SetRow(this.ball, row);
                ball_col = col;
                ball_row = row;
            }            
        }


        private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.referee);
            int row = Grid.GetRow(this.referee);
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    col--;
                    break;
                case SwipeDirection.Right:
                    col++;
                    break;
                case SwipeDirection.Up:
                    row--;
                    break;
                case SwipeDirection.Down:
                    row++;
                    break;
            }
            if(col!=ball_col|| row!=ball_row)
            {
                Grid.SetColumn(this.referee, col);
                Grid.SetRow(this.referee, row);
                referee_col = col;
                referee_row = row;
            }

        }
    }
}
