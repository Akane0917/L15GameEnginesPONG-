/* PONG!
 * Example of implementing a game engine
 * December 5 2025
 */

using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace L15GameEnginesPONG_
{
    public partial class Form1 : Form

    {

        //These rectangles with initial x,y,width and height 
        // Player 1 on left of screen, player 2 on right
        Rectangle player1 = new Rectangle(10, 100, 10, 60);
        Rectangle player2 = new Rectangle(10, 200, 10, 60);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        //initial position of ball
        int x = 200;
        int y = 200;
        //size of ball
        int height = 40;
        int width = 40;

        //pixel distance of each ball movement
        int stepSize = 30;
        //is ball moving left or right/down or up
        Boolean directionX = true;
        Boolean directionY = true;


        int player1Score = 0;
        int player2Score = 0;
        //The speeds will be the pixel step size each time the player or ball moves
        int playerSpeed = 4;
        int ballXSpeed = -6;
        int ballYSpeed = 6;
        //These booleans  are required for keypress methods
        bool wDown = false;//player 1
        bool sDown = false;//player 1
        bool upArrowDown = false;//player 2
        bool downArrowDown = false; //player2


        //players are blue and ball is white
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);



        int player1Turn = 1;

        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;

        Pen drawPen = new Pen(Color.Red, 10);
        SolidBrush drawBrush = new SolidBrush(Color.Red);

        private void ballMovement()
        {
            x = x + stepSize;
            y = y + stepSize;

            // direction
            if (directionX)
                x = x + stepSize;
            else x = x - stepSize;
            if (x > ClientSize.Width - width || x < 0)
                directionX = !directionX;
            if (directionY)
                y = y + stepSize;
            else y = y - stepSize;
            if (y > ClientSize.Height - height || y < 0)
                directionY = !directionY;

        }


        public Form1()
        {
            InitializeComponent();
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 20;        // 20 ms
            gameTimer.Enabled = true;       // start immediately
            gameTimer.Tick += GameTimer_Tick;

        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // This runs every 20 ms

            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed;
            }
            if(dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += playerSpeed;
            }

            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed;
            }
            if(leftDown == true && player2.X > 0)
            {
                player2.X -= playerSpeed; 
            }
            if(rightDown == true && player2.X <this.Width - player2.Width)
            {
                player2.X += playerSpeed;
            }
            //move ball 
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;

            //check  if  ball  hit  top  or  bottom  wall  and  change  direction  if  it  does 
            if (ball.Y < 0 || ball.Y > this.Height - ball.Height)
            {
                ballYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }

            else if ( ball.X >= ClientSize.Width - ball.Width)
            {
                ballXSpeed *= -1;
            }

            //check  if  ball  hits  either  player. If  it  does  change  the  direction 
            //and  place  the  ball   in  front  of  the  player hit 
            if (ballXSpeed < 0)
            {
                if (player1Turn == 1 && player1.IntersectsWith(ball))
                {
                    ballXSpeed = Math.Abs(ballXSpeed);
                    ball.X = player1.X + player1.Width;
                    player1Turn = 2;
                }
                else if (player1Turn == 2 && player2.IntersectsWith(ball))
                {
                    ballXSpeed = Math.Abs(ballXSpeed);
                    ball.X = player2.X + player2.Width;
                    player1Turn = 1;
                }


            }

            //check  if   a  player  missed  the  ball  and  if  true  add  1  to  score  of  other  player  

            if (ball.X < 0)
            {
                if (player1Turn == 1)
                {
                    player2Score++;
                  
                }
                else 
                {

                    player1Score++;
                  

                }
                p1ScoreLabel.Text = player1Score.ToString();
                p2ScoreLabel.Text = player2Score.ToString();

                ball.X = 295;
                    ball.Y = 195;

                    player1.Y = 100;
                    player2.Y = 200;
                
            }


            // check  score  and  stop  game  if  either  player  is  at  3 
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";

               
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";

               
            }
            ballMovement();
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
        
            g.FillRectangle(redBrush, player1);
            g.FillRectangle(blueBrush, player2);
            g.FillRectangle(whiteBrush, ball);






        }

        private void Form1_Click(object sender, EventArgs e)
        {

            gameTimer.Enabled = true;

        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
