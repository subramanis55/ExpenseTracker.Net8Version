using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public  enum MoveDirection
    {
        Left, Right,Middle,MiddleRight,None
    }
    public partial class LoginBackgorundMovingU : UserControl
    {
        Timer timer=new Timer();
        private MoveDirection direction= MoveDirection.None;
        public event EventHandler OnMoveEnd;
        
        public MoveDirection Direction
        {
            set
            {
                direction = value;
                move();
            }
            get
            {
                return this.direction;
            }
        }

        public LoginBackgorundMovingU()
        {
            InitializeComponent();
            this.Resize += LoginBackgorundMovingUResize;
            timer.Interval = 15;
            timer.Tick += moving;
            LoginBackgorundMovingUResize(this, EventArgs.Empty);
        }

        private void LoginBackgorundMovingUResize(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(Width / 2-20, Height-Padding.Bottom-Padding.Top);
            pictureBox.Location = new Point(pictureBox.Location.X,0);
        }
        public void moving(object sender, EventArgs e)
        {
            if(direction == MoveDirection.Left)
            {
                if (pictureBox.Location.X > 0)
                {
                    pictureBox.Location = new Point(pictureBox.Location.X-15, 0);

                }
                else
                {
                    timer.Stop();
                    pictureBox.Location= new Point(0, 0);
                    OnMoveEnd?.Invoke(this, new EventArgs());
                  
                }
               
            }
            else if(direction == MoveDirection.Right)
            {

                if (pictureBox.Location.X+ pictureBox.Width < Width)
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + 15, Padding.Top);
                    

                }
                else
                {
                    timer.Stop();
                    pictureBox.Location = new Point(Width - pictureBox.Width, Padding.Top);
                    OnMoveEnd?.Invoke(this, new EventArgs());
                   
                }
            }
            else if (direction == MoveDirection.Middle)
            {
                if (pictureBox.Location.X >Width/4)
                {
                    pictureBox.Location = new Point(pictureBox.Location.X - 15, Padding.Top);

                }
                else
                {
                    timer.Stop();
                    pictureBox.Location = new Point(Width / 4, 0);
                    OnMoveEnd?.Invoke(this, new EventArgs());
                  
                }
            }
            else if (direction == MoveDirection.MiddleRight)
            {

                if (pictureBox.Location.X + pictureBox.Width < Width)
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + 15, Padding.Top);


                }
                else
                {
                    timer.Stop();
                    pictureBox.Location = new Point(Width - pictureBox.Width, Padding.Top);
                    OnMoveEnd?.Invoke(this, new EventArgs());
                  
                }
            }

        }
        public void move()
        {
            if(direction == MoveDirection.Left)
            {
                pictureBox.Location = new Point(Width - pictureBox.Width, 0);
                timer.Start();
            }
            else if (direction == MoveDirection.Right)
            {
                pictureBox.Location = new Point(0, 0);
                timer.Start();
            }
            else if(direction==MoveDirection.Middle) 
            {
                pictureBox.Location = new Point(Width - pictureBox.Width, 0);
                timer.Start();
            }
            else if (direction == MoveDirection.MiddleRight)
            {
                pictureBox.Location = new Point(Width / 4, 0);
                timer.Start();
            }
        }
    }
}
