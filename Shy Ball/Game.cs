// Include code libraries you need below (use the namespace).
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
            Window.SetTitle("Shy Ball");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }



        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        //setting random

        ///setting coord variables for ball and mouse
        float BallX = 200;
        float BallY = 200;
        int[] jX = { 100, 350, 250, 50, 150 };
        int jT = 0;
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
            Window.ClearBackground(Color.OffWhite);
            //setting colour and drawing ball
            Draw.FillColor = new((int)Math.Round(mY), (int)Math.Round(mX), (int)Math.Round((dY + dX )/ 2));
            Draw.Circle(BallX, BallY, 10);
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
