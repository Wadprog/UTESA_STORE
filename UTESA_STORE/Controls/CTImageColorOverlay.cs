using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UTESA_STORE.RJControls
{
    public class CTImageColorOverlay : Panel
    {
        /// <summary>
        /// This class enherits from the <see cref="Panel"/> class 
        /// This control incorporates the function of overlay color to images. This means that you cover 
        /// an image with a semi-transparent color box. This method is very popular on websites because
        /// it improves the appearance considerably and the elements on it are more readable, so I decided 
        /// to make one for windows forms.
        /// 
        /// the trick here is to draw a box with a semi-transparent color (you can set opacity) on the panel
        /// with an image background.To get a semi-transparent color, set the alpha color component.
        /// In Windows, the alpha component is a number between 0 (fully transparent) and 255 (fully opaque).
        /// </summary>
        /// 

        #region -> Fields

        private int opacity;//Sets or gets opacity (Percentage of transparency, 0=fully transparent and 100 fully opaque)
        private int alpha;//Sets or gets the value for the alpha parameter
        private Color overlayColor;//Sets or gets the overlay color
        private bool customizable;

        #endregion

        #region -> Constructor

        public CTImageColorOverlay()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | //Set control styles to avoid flickering
                              ControlStyles.UserPaint |
                              ControlStyles.OptimizedDoubleBuffer,
                              true);
            this.BackgroundImage = Properties.Resources.BackImage;//Set default image
            this.BackgroundImageLayout = ImageLayout.Stretch;//Set default image layout
            Opacity = 50;//Set a default opacity of 50%
            OverlayColor = Color.MediumSlateBlue;//Set default overlay color
            this.TabStop = false;
        }
        #endregion

        #region -> Properties

        [Category("RJ Code Advance")]
        public bool Customizable
        {
            get { return customizable; }
            set { customizable = value; }
        }

        [Category("RJ Code Advance")]
        public int Opacity
        {//Sets or gets opacity (Percentage of transparency, 0=fully transparent and 100 fully opaque)

            get
            {
                return opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    return;
                opacity = value;//Set value
                alpha = Convert.ToInt32(opacity / 100D * 255);//Convert the opacity value to a valid alpha value
                //Alpha= Opacity / 100% *255 (On Windows, the maximum alpha value is 255, which is completely opaque)
                //The suffix D is of double type that would be equal to 100.00 or (double)100.
                if (this.DesignMode) this.Invalidate(false);//Redraw the control to apply the changes (invokes the OnPaint event)-> preview in design mode
            }
        }

        [Category("RJ Code Advance")]
        public Color OverlayColor
        {//Sets or gets the overlay color

            get { return overlayColor; }
            set
            {
                overlayColor = value;//Set value
                if (this.DesignMode) this.Invalidate(false);//Redraw the control to apply the changes (invokes the OnPaint event)-> preview in design mode
            }
        }

        [Category("RJ Code Advance")]
        public Image Image
        {//Sets or gets Background Image
            get { return this.BackgroundImage; }
            set { this.BackgroundImage = value; }
        }

        [Category("RJ Code Advance")]
        public ImageLayout ImageMode
        {//Sets or gets Image Layout
            get { return this.BackgroundImageLayout; }
            set { this.BackgroundImageLayout = value; }
        }

        //Overriden Properties
        protected override Size DefaultSize
        {//Set default Size
            get { return new Size(320, 320); }
        }

        #endregion

        #region Methods Definition

        private void ApplyAppearanceSettings()
        {
            if (customizable == false)
            {
                overlayColor = Settings.UIAppearance.StyleColor;
            }
        }

        #endregion

        #region Overriden Event Methods

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyAppearanceSettings();
        }
        protected override void OnPaint(PaintEventArgs e)
        {//Occurs when the control is redrawn

            base.OnPaint(e);//Draw control normally

            //Create a solid color brush object from the overlay color parameter and the opacity set in the alpha parameter
            using (var brush = new SolidBrush(Color.FromArgb(alpha, overlayColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);//Fill the interior of the panel with the solid brush created
                //Basically draw a transparent colored rectangle (based on the alpha value defined by opacity) on the panel
            }
        }
        #endregion

    }
}