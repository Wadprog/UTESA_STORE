using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UTESA_STORE.RJControls
{
    public class CTCircularPictureBox : PictureBox
    {
        /// <summary>
        /// This class inherits from the <see cref="PictureBox"/> class
        /// In this class you simply create a circular picturebox using its <see cref="this.Region"/> property
        /// and the <see cref="GraphicsPath"/> class to draw outlines of shapes, fill the interiors of shapes,
        /// and create clipping regions.
        /// </summary>
        /// 

        //-> Contructor
        public CTCircularPictureBox()
        {
            this.Size = new Size(100,100);
            this.SizeMode = PictureBoxSizeMode.StretchImage; //The image within the PictureBox is stretched or shrunk to fit the size of the PictureBox.
            this.SizeChanged += new EventHandler(PictureBox_SizeChanged);//Occurs when the size of the control changes
        }

        //-> Event Methods 
        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            //The size must be the same width and height (perfect square - perfect circle) to do this set the same width.
            this.Size = new Size(this.Size.Width, this.Size.Width);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);//Draw control normally

            using (GraphicsPath graphicsPath = new GraphicsPath())//Initializes a new instance of the GraphicsPath class
            {
                ///<summary>
                /// Initializes a new instance of the <see cref="Rectangle"/>  class with the specified location and size
                /// in this case, the following parameters set the following:
                /// <param name="int x">The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.</param>
                /// <param name="int y">The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.</param>
                /// <param name="int widht">The width of the bounding rectangle that defines the ellipse.</param>
                /// <param name="int height">The height of the bounding rectangle that defines the ellipse.</param>
                ///</summary>
                var rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);///Creates a rectangle the same size as the control to bound an ellipse(subtract the border size)
                graphicsPath.AddEllipse(rectangle); //Add an ellipse with the dimensions of the rectangle.
                this.Region = new Region(graphicsPath);//Set a new region to the control with the elliptical chart path - basically converts the shape of the control into the created circle.

                ///PaintEventArgs- draw the border of the control to have a good quality of the circular image box.
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;// Set the rendering quality 
                var pen = new Pen(new SolidBrush(this.BackColor), 1); //Create a pen of the same background color                
                e.Graphics.DrawEllipse(pen, rectangle);//Draw the ellipse as the border of the control.
            }
        }
    }
}
