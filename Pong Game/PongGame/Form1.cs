using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{   
    public partial class Form1 : Form
    {
        #region variables
        private int _playerOne;
        private int _playerTwo;

        const int PlayerMovement = 2;
        const int ballSpeed = 4;

        bool ball_direction = true;

        int _playerOne_x = 50;
        int _playerTwo_x = 690;

        bool Ball_up_or_down = true;

        int playerlenth = 90, playerwith = 14;
        int scorePlayerOne = 0;
        int scoreplayerTwo = 0;
        int _scorePosition_x_Player2 = 440, _scorePosition_y_Players = 40, _scorePosition_x_Player1 = 300;

        const int numAway = -30;

        bool StopInvalidating = false;

        int ball_y = 100;
        int ball_x = 400;

        private positionPlayerOne _objPostionPlayerOne;
        private positionPlayerTwo _objPostionPlayerTwo;

         enum positionPlayerOne
        {
            up, down, stop
        }
        enum positionPlayerTwo
        {
            up, down, stop
        }
        #endregion variables

        public Form1()
        {
            InitializeComponent();

            _playerOne = 170;
            _playerTwo = 170;
            _objPostionPlayerOne = positionPlayerOne.stop;
            _objPostionPlayerTwo = positionPlayerTwo.stop;
        }     

        #region drawing objects
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Drawing the ball
            e.Graphics.FillRectangle(Brushes.White, ball_x, ball_y, 15, 15);
            
            // The players graphics
            e.Graphics.FillRectangle(Brushes.White, _playerTwo_x, _playerTwo, playerwith, playerlenth);
            e.Graphics.FillRectangle(Brushes.White, _playerOne_x, _playerOne, playerwith, playerlenth);
        }
        #endregion

        #region Movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Key directions
            directions(e);
        }

        private void directions(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _objPostionPlayerOne = positionPlayerOne.up;
                    break;
                case Keys.S:
                    _objPostionPlayerOne = positionPlayerOne.down;
                    break;
                case Keys.O:
                    _objPostionPlayerTwo = positionPlayerTwo.up;
                    break;
                case Keys.L:
                    _objPostionPlayerTwo = positionPlayerTwo.down;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Makes the players stop
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                _objPostionPlayerOne = positionPlayerOne.stop;
            }
            if (e.KeyCode == Keys.O || e.KeyCode == Keys.L)
            {
                _objPostionPlayerTwo = positionPlayerTwo.stop;
            }
        }
        #endregion

        #region update loop
        private void timer1_Tick(object sender, EventArgs e)
        {         
            // Player movement and movement restrictions
            if (_objPostionPlayerOne == positionPlayerOne.up)
            {
                if (_playerOne >= PlayerMovement)
                {
                    _playerOne -= PlayerMovement;
                }
            }  else if (_objPostionPlayerOne == positionPlayerOne.down)
            {
                if (_playerOne <= 356)
                {
                    _playerOne += PlayerMovement;
                }
            }

            if (_objPostionPlayerTwo == positionPlayerTwo.up)
            {
                if (_playerTwo >= PlayerMovement)
                {
                    _playerTwo -= PlayerMovement;
                }
            }   else if (_objPostionPlayerTwo == positionPlayerTwo.down)
            {
                if (_playerTwo <= 356)
                {
                    _playerTwo += PlayerMovement;
                }
            }

            // ball movement
            // Ball direction in x axes and colision with players
            var ballUp = true;
            
            for (int i = _playerOne; i <= _playerOne + playerlenth; i++)
            {
                if (ball_x == _playerOne_x + playerwith && ball_y == i)
                {
                    ball_direction = ballUp;
                }
            }

            for (int i = _playerTwo; i <= _playerTwo + playerlenth; i++)
            {
                if (ball_x == _playerTwo_x - playerwith && ball_y == i)
                {
                    ball_direction = !ballUp;
                }
            }

           if (ball_direction == true)
            {
                ball_x += ballSpeed;
            }
           else
            {
                ball_x -= ballSpeed;
            }

            //Ball bounce
            if (ball_y == 0)
            {
                Ball_up_or_down = false;
            }
            if (ball_y == 432)
            {
                Ball_up_or_down = true;
            }

            if (Ball_up_or_down == true)
            {
                ball_y -= ballSpeed;
            }
            if (Ball_up_or_down == false)
            {
                ball_y += ballSpeed;
            }
                       
            //Ball score ditermination.
            if (ball_x == 692)
            {
                scorePlayerOne++;
                ball_x = 400;
                ball_y = 100;
            }
            else if (ball_x == 48)
            {
                scoreplayerTwo++;
                ball_x = 400;
                ball_y = 100;
            }

            #region update score
            switch (scoreplayerTwo)
            {
                case 0:
                    pictureBox4.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway, numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox3.Location = new Point(numAway, numAway);
                    break;
                case 1:
                    pictureBox3.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway, numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 2:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer23.Location = new Point(numAway, numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 3:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway,numAway);
                    pongplayer23.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 4:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 5:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 6:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 7:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 8:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pongplayer29.Location = new Point(numAway, numAway);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;
                case 9:
                    pictureBox3.Location = new Point(numAway, numAway);
                    pongplayer22.Location = new Point(numAway, numAway);
                    pongplayer23.Location = new Point(numAway,numAway);
                    pongplayer24.Location = new Point(numAway, numAway);
                    pongplayer25.Location = new Point(numAway, numAway);
                    pongplayer26.Location = new Point(numAway, numAway);
                    pongplayer27.Location = new Point(numAway, numAway);
                    pongplayer28.Location = new Point(numAway, numAway);
                    pongplayer29.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                    pictureBox4.Location = new Point(numAway, numAway);
                    break;

            }
            
            
             // Point system for player one.
            switch (scorePlayerOne)
            {
                case 0:
                    pongplyer10.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplayer11.Location = new Point(numAway, numAway);
                    break;
                case 1:
                    pongplayer11.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 2:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 3:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 4:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 5:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 6:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 7:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 8:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplayer19.Location = new Point(numAway, numAway);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;
                case 9:
                    pongplayer11.Location = new Point(numAway, numAway);
                    pongplayer12.Location = new Point(numAway, numAway);
                    pongplayer13.Location = new Point(numAway, numAway);
                    pongplayer14.Location = new Point(numAway, numAway);
                    pongplayer15.Location = new Point(numAway, numAway);
                    pongplayer16.Location = new Point(numAway, numAway);
                    pongplayer17.Location = new Point(numAway, numAway);
                    pongplayer18.Location = new Point(numAway, numAway);
                    pongplayer19.Location = new Point(_scorePosition_x_Player1, _scorePosition_y_Players);
                    pongplyer10.Location = new Point(numAway, numAway);
                    break;

            
            }
            #endregion

            if (scorePlayerOne == 10)
            {
                scorePlayerOne = 0;
                scoreplayerTwo = 0;

                timer1.Stop();
                
                DialogResult dialogResult = MessageBox.Show("Player One Won! \n Rematch?","match", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                pictureBox4.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                pongplayer29.Location = new Point(numAway, numAway);
            }
            else if (scoreplayerTwo == 10)
            {
                scorePlayerOne = 0;
                scoreplayerTwo = 0;
                timer1.Stop();
                
                DialogResult dialogResult = MessageBox.Show("Player One Won! \n Rematch?", "match", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                pictureBox4.Location = new Point(_scorePosition_x_Player2, _scorePosition_y_Players);
                pongplayer29.Location = new Point(numAway, numAway);
            }
            if (StopInvalidating == false)
            {
                Invalidate();
            }            
        }
        #endregion
    }
}
