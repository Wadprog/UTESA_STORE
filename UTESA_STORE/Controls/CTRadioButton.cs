using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UTESA_STORE.Settings;

namespace UTESA_STORE.RJControls
{
    public class CTRadioButton : RadioButton
    {
        /// <summary>
        /// This class enherits from <see cref="RadioButton"/> class.
        /// this control completely overrides the paint event and a new radio button
        /// design is drawn with the colors assigned in the appearance settings. 
        /// 
        /// The drawings occur in the following order:
        ///     1.- The background of the control surface is drawn.
        ///     2.- The text is drawn.
        ///     3.- The border of the radio button is drawn.
        ///     4.- The background of the radio button is drawn.
        ///     5.- The radio button check mark is drawn.
        /// </summary>
        /// 

        #region -> Fields

        private Color borderColor;//Sets and gets the border color of the radio button
        private Color backgroundColor;//Sets and gets the background color of the radio button
        private Color checkedColor;//Sets and gets radio button check color
        #endregion

        #region -> Constructor

        public CTRadioButton()
        {
            this.Font = new Font("Verdana", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;
            this.CheckedChanged += new EventHandler(rbCheckedChanged);//Subscribe the CheckedChanged event
            this.TextChanged += new EventHandler(rbTextChanged);//Subscribe the TextChanged event
            this.Resize += new EventHandler(rbResize);//Subscribe the Resize event
            ApplyApperanceSettings();//Apply Appearance settings
        }
   
        #endregion

        #region -> Private methods

        private void ApplyApperanceSettings()
        {//Applu appearance settings

            checkedColor = UIAppearance.StyleColor;//Set Check color

            if (this.Checked)//Set border color and background color in the checked state
            {
                borderColor = UIAppearance.StyleColor;
                backgroundColor = UIAppearance.BackgroundColor;
            }
            else //Set border color and background color in the unchecked state
            {
                borderColor = Colors.Cancel;
                backgroundColor = UIAppearance.ItemBackgroundColor;
            }
        }
        #endregion

        #region -> Event Methods

        private void rbCheckedChanged(object sender, EventArgs e)
        {//When the value of the Checked property changes, load the appearance settings and redraw the control

            ApplyApperanceSettings();
            this.Invalidate();//Redraw the control
        }

        private void rbTextChanged(object sender, EventArgs e)
        {//When the value of the Text property changes 
            this.Invalidate();//Redraw the control
        }
        private void rbResize(object sender, EventArgs e)
        {//When the value of the Size property changes (Can be activated when text changes) adjust the height and width of the control.
           
            this.Width = 30 +/*Text width*/ (int)this.CreateGraphics().MeasureString(this.Text, this.Font).Width;
            /*Add + 30px for the width of the radio button and text padding (see graphics.DrawString..25F location X).
             You can do the same for the height of the control in case you increase the size of the radio button.
             */
        }
        
        #endregion

        #region -> Overriden Event Methods

        protected override void OnPaint(PaintEventArgs e)
        {//Completely override the paint event and draw a new radio button

            Graphics graphics = e.Graphics;//Set GDI
            Rectangle borderRectangle = new Rectangle(0, 0, 18, 18);//Create rectangle object with the location and size of the circular border of the radio button
            Rectangle backgroundRectangle = new Rectangle(1, 1, 16, 16);//Create rectangle object with the location and size of the radio button background
            Rectangle checkedRectangle = new Rectangle(4, 4, 10, 10);//Create rectangle object with the location and size of the radio button check

            graphics.SmoothingMode = SmoothingMode.AntiAlias;//Set Smoothing Mode
            graphics.Clear(this.Parent.BackColor);//Draw the background of the control surface with the same color as its container
            graphics.DrawString(this.Text, this.Font, (Brush)new SolidBrush(UIAppearance.TextColor), 25F, 1F);//Draw radio button text (35F is the location of the X-axis and 0.0F Y-axis, you can change according to your convenience)

            graphics.FillEllipse((Brush)new SolidBrush(borderColor), borderRectangle);//Draw the border of the radio button as a filled circle with the specified color, location, and size.
            graphics.FillEllipse((Brush)new SolidBrush(backgroundColor), backgroundRectangle);//Draw the radio button background as a filled circle with the specified color, location, and size.
            if (this.Checked) //Only when the control is checked
                graphics.FillEllipse((Brush)new SolidBrush(checkedColor), checkedRectangle);//Draw the radio button check mark as a filled circle with the specified color, location, and size.
        }
        #endregion

    }
}
