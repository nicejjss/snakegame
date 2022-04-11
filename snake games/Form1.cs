using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_games
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle Food=new Circle();

        int MaxWidth;
        int MaxHeight;
        int score;
        int hightscore;

        Random rand = new Random();

        bool goleft, godown, goup, goright;

        public Form1()
        {
            InitializeComponent();
            new Runninggame();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }


        //change the direction of the snake
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Left && Runninggame.Directions != "right")
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right && Runninggame.Directions != "left")
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up && Runninggame.Directions != "down")
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down && Runninggame.Directions != "up")
            {
                godown = true;
            }



        }

        // In the same direction of the snake
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Set directions
            if (godown)
            {
                Runninggame.Directions = "down";
            }
            if (goup)
            {
                Runninggame.Directions = "up";
            }
            if (goleft)
            {
                Runninggame.Directions = "left";
            }
            if (goright)
            {
                Runninggame.Directions = "right";
            }

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Head direction
                if (i == 0)
                {
                    switch (Runninggame.Directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }
                    if (Snake[i].X > MaxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y > MaxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = MaxWidth;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = MaxHeight;
                    }
                  for(int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[0].X==Snake[j].X && Snake[0].Y == Snake[j].Y)
                        {
                            Gameover();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
               
            }
            if (Snake[0].X == Food.X && Snake[0].Y==Food.Y)
            {
                Eatfood();
            }
            pictureBox1.Invalidate();

        }


        private void StartGame()
        {
            RestartGame();

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Paint Snake
            Graphics canvas = e.Graphics;
            Brush snakecolor;
            for(int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakecolor = Brushes.Red;
                }
                else
                {
                    snakecolor = Brushes.Green;
                }
                canvas.FillEllipse(snakecolor, new Rectangle(
                    Snake[i].X * Runninggame.Width,
                    Snake[i].Y * Runninggame.Height,
                    Runninggame.Width,
                    Runninggame.Height
                    )) ;
            }
            //paint Food
            canvas.FillEllipse(Brushes.Purple, new Rectangle(
                     Food.X * Runninggame.Width,
                     Food.Y * Runninggame.Height,
                     Runninggame.Width,
                     Runninggame.Height
                     ));

        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Gameover()
        {
            timer1.Stop();

            btnrestart.Enabled = true;
            if (score > hightscore)
            {
                hightscore = score;
                highscorelb.Text = "Hight Score: " + hightscore;
            }

        }
        private void Eatfood()
        {
            score++;
            scorelb.Text = "Score: " + score;
            Circle body = new Circle {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
            };
            Snake.Add(body);
            Food = new Circle { X = rand.Next(2, MaxWidth), Y = rand.Next(2, MaxHeight) };
            for (int i = 0; i < Snake.Count; i++)
            {
                if(Food.X==Snake[i].X && Food.Y == Snake[i].Y)
                {
                    Food = new Circle { X = rand.Next(2, MaxWidth), Y = rand.Next(2, MaxHeight) };
                }
            }
        }

        private void RestartGame()
        {
           // MaxHeight = pictureBox1.Height / Runninggame.Height;
           // MaxWidth = pictureBox1.Width / Runninggame.Width;
            Snake.Clear();
            btnrestart.Enabled = false;
            score = 0;
            scorelb.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };//
            Snake.Add(head); //Having a head of the snake;

            for(int i = 0; i < 4; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            Food = new Circle {X= rand.Next(2,MaxWidth),Y= rand.Next(2,MaxHeight)};

            timer1.Start();
        }
    }
}
