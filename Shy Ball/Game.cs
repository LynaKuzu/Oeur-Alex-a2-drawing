// Include code libraries you need below (use the namespace).
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //setup
            Window.SetTitle("ShyeBall");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }
        //drawing eyeball function
        void SBall(float x, float y, int red, int green, int blue, int blink)
        {
            Draw.FillColor = new(200, 200, 200);
            Draw.Ellipse(x, y, 50, 25);
            Draw.FillColor = new((int)Math.Round(mY), (int)Math.Round(mX), clr[jT]);
            Draw.Circle(x, y, 10);
            Draw.FillColor = new(0, 0, 0);
            Draw.Ellipse(x, y - blink, 60, 25);
        }


        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        //setting random

        ///setting coord variables for ball and mouse
        int Bnk = 120;
        bool lid = true;
        float BallX = 200;
        float BallY = 200;
        int[] jX = { 100, 350, 250, 50, 150 };
        int jT = 0;
        int[] clr = { 155, 0, 50, 255, 100 };
        float dX = 0;
        float mX = 0;
        float mY = 0;
        float dY = 0;
        public void Update()
        {
            //setting variables for mouse
            mX = Input.GetMouseX();
            mY = Input.GetMouseY();
            //refreshing screen
            Window.ClearBackground(Color.Black);
            //setting colour and drawing ball
            SBall(BallX, BallY, (int)Math.Round(mY), (int)Math.Round(mX), clr[jT], Bnk);
            //distance variable for only X and Y seprately
            //(I do not feel like implementing a**2 + b**2 = c**2)
            dX = mX - BallX;
            dY = mY - BallY;
            //setting distances to absolute values
            if (dX < 0)
            {
                dX = dX * -1;
            }
            if (dY < 0)
            {
                dY = dY * -1;
            }
            // blinking values
            if (lid)
            {
                Bnk = Bnk - 1;
                if (Bnk < 1)
                {
                    lid = false;
                }
            }
            else
            {
                Bnk = Bnk + 1;
                if (Bnk >= 120) { 
                lid = true;
                    }
            }
            //tracking distance
            if (dX <= 50)
            {
                if (dY <= 50)
                {
                    //moving ball by random value and preset value
                    if (mX > BallX)
                    {

                        BallX = jX[jT];
                        BallY = Random.Float(100, 300);
                        if (jT <= 3)
                        {
                            jT = jT + 1;
                        }
                        else
                        {
                            jT = 0;
                        }
                    }
                }
            }
        }
    }
}
