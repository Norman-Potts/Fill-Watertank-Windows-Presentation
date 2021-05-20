
/*
    Norman Potts
    Lab5a of Advanced Programming in .NET
    2017-04-07
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab5A
{

    /// <summary>
    /// Class for the form.
    /// </summary>
    public partial class Form1 : Form
    {

        private Graphics theGraphics;        //Encapsulates a GDI+ drawing surface
        private Pen thePen = new Pen(Color.FromArgb(255, 255, 255));
        private SolidBrush theBrush;
        private SolidBrush theBlackBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
        private Color theLiquidColor = Color.FromArgb(173, 216, 230);

        int depthOfTheLiquid = 0;
        int depthOfTheTank = 320;
        int widthOfTheTank = 200;
        int tapX = 100;
        int tapY = 193;
        int topLeftCornerX = 70;
        int topLeftCornerY = 230;
        int topRightCornerX, topRightCornerY, bottomLeftCornerX, bottomLeftCornerY, bottomRightCornerX, bottomRightCornerY, heightOfTheFallingLiquid;


        /// <summary>
        /// set parameters for tank and SolidBrush
        /// The constructor for the form registers the event handler that automatically repaints the screen.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            topRightCornerX = topLeftCornerX + widthOfTheTank;
            topRightCornerY = topLeftCornerY;
            bottomLeftCornerX = topLeftCornerX;
            bottomLeftCornerY = topLeftCornerY + depthOfTheTank;
            bottomRightCornerX = topLeftCornerX + widthOfTheTank;
            bottomRightCornerY = topLeftCornerY + depthOfTheTank;
            heightOfTheFallingLiquid = bottomRightCornerY - tapY;
            theBrush = new SolidBrush(theLiquidColor);

            this.Paint += new PaintEventHandler(frmMain_Paint);  //Registers the Paint event handler
        }

        /// <summary>
        /// Draw the water tank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            theGraphics = this.CreateGraphics();                          //Get the Graphics object from the PaintEventArgs

            theGraphics.DrawLine(thePen, topLeftCornerX, topLeftCornerY, bottomLeftCornerX, bottomLeftCornerY);
            theGraphics.DrawLine(thePen, bottomLeftCornerX, bottomLeftCornerY, bottomRightCornerX, bottomRightCornerY);
            theGraphics.DrawLine(thePen, bottomRightCornerX, bottomRightCornerY, topRightCornerX, topRightCornerY);
        }



        /// <summary>
        /// Save the colour choice user made to the solidbrush.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Color_Click(object sender, EventArgs e)
        {
            ///opens color diaglog box...
            colorDialog1.Color = theLiquidColor;       /// Display with the previous color already chosen
            colorDialog1.ShowDialog();                 /// Display the actual dialog box
            theLiquidColor = colorDialog1.Color;       /// Save the colour choice the user made
            theBrush = new SolidBrush(theLiquidColor);
        }

        /// <summary>
        /// Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Based on user selected speed and the status of the tank
        /// if the tank is full and the speed is not 0, empty it and continue to fill liquid
        /// if the tank is not full and the speed is not 0, fill liquid
        /// if the selected speed is 0, stop filling liquid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            theGraphics = this.CreateGraphics();               //Create a graphics object
            if (trackBar.Value != 0 && depthOfTheLiquid >= 310)
            {
                theGraphics.FillRectangle(theBlackBrush, topLeftCornerX + 1, topLeftCornerY, widthOfTheTank - 1, depthOfTheTank);
                depthOfTheLiquid = 0;
                heightOfTheFallingLiquid = bottomRightCornerY - tapY;
                SetInterval();
                theTimer.Start();
            }
            else if (trackBar.Value != 0 && depthOfTheLiquid < 310)
            {
                SetInterval();
                theTimer.Start();
            }
            else
            {
                theGraphics.FillRectangle(theBlackBrush, tapX, tapY + 1, 10, heightOfTheFallingLiquid - 1);
                theTimer.Stop();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
         
        }


        /// <summary>
        /// If the tank is full,stop filling liquid
        /// else, continue to fill liquid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void theTimer_Tick(object sender, EventArgs e)
        {
            if (depthOfTheLiquid >= 310)
                trackBar.Value = 0;
            else
            {
                heightOfTheFallingLiquid--;
                depthOfTheLiquid++;
                DrawLiquid(heightOfTheFallingLiquid, depthOfTheLiquid);
            }
        }

        /// <summary>
        /// Drawing liquid including falling liquid and filled liquid
        /// </summary>
        /// <param name="heightOfTheFallingLiquid"></param>
        /// <param name="depthOfTheLiquid"></param>
        private void DrawLiquid(int heightOfTheFallingLiquid, int depthOfTheLiquid)
        {
            theGraphics = this.CreateGraphics();               //Create a graphics object
            theGraphics.FillRectangle(theBrush, tapX, tapY + 1, 10, heightOfTheFallingLiquid);
            theGraphics.FillRectangle(theBrush, topLeftCornerX + 1, bottomRightCornerY - depthOfTheLiquid, widthOfTheTank - 1, 1);
        }

        /// <summary>
        /// Based user selected speed to set how frequent filling one unit liquid
        /// </summary>
        private void SetInterval()
        {
            switch (trackBar.Value)
            {
                case 1:
                    theTimer.Interval = 100;
                    break;
                case 2:
                    theTimer.Interval = 90;
                    break;
                case 3:
                    theTimer.Interval = 80;
                    break;
                case 4:
                    theTimer.Interval = 70;
                    break;
                case 5:
                    theTimer.Interval = 60;
                    break;
                case 6:
                    theTimer.Interval = 50;
                    break;
                case 7:
                    theTimer.Interval = 40;
                    break;
                case 8:
                    theTimer.Interval = 30;
                    break;
                case 9:
                    theTimer.Interval = 20;
                    break;
                case 10:
                    theTimer.Interval = 10;
                    break;
            }
        }

    }
}
