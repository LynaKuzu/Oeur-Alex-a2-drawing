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



        ///setting coord variables for ball and mouse
        float BallX = 200;
        float BallY = 200;
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
            Draw.FillColor = Color.Black;
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
                    //moving in accordance to direction and distance
                    if (mX > BallX)
                    {
                        
                        BallX = BallX - (50 - (mX - BallX));
                    }
                    else
                    {
                        BallX = BallX + (50 + (mX - BallX));
                    }

                }
            }
        }
    }
}
