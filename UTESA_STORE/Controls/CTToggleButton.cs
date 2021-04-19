using UTESA_STORE.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTESA_STORE.RJControls
{
    public class CTToggleButton : CheckBox
    {
        /// <summary>
        /// This class enherits from <see cref="CheckBox"/> class.
        /// This control completely overrides the paint event and a new ToggleButton control
        /// design is drawn with the colors assigned in the appearance settings, allows to
        /// change the style to solid or glass.
        /// 
        /// The drawings occur in the following order:
        ///     1.- The background of the control surface is drawn.       
        ///     2.- The border(glass style) or background (solid style) of the toggle button is drawn.
        ///     3.- The toggle button lever is drawn (ON or OFF).
        ///     4.- The text is drawn.
        ///     
        /// It exposes all the functionalities (properties, methods and events of the checkbox control)
        /// and new properties are added to customize the activation lever control.
        /// </summary>
        /// 

        #region -> Fields

        private ControlStyle style;//Gets or sets the CheckBox style (Glass or Solid)

        private Color onBackBorderColor;//Gets or sets the background or border color in the activated state.
        private Color onToggleColor;//Gets or sets the toggle color in the activated state.
        private Color onTextColor;//Gets or sets the text color in the activated state.
        private string onText;//Gets or sets the text in the activated state.

        private Color offBackBorderColor;//Gets or sets the background or border color in the deactivated state.
        private Color offToggleColor;//Gets or sets the toggle color in the deactivated state.
        private Color offTextColor;//Gets or sets the text color in the deactivated state.
        private string offText;//Gets or sets the text in the deactivated state. 

        private bool customizable;//Gets or sets if the control color is customizable or the colors are set according to the Appearance Settings.

        //Static Field       

        #endregion

        #region -> Constructor

        public CTToggleButton()
        {
            this.Appearance = Appearance.Button;//Set button appearance 
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.MinimumSize = new Size(45, 20);//Set minimun size
            this.UseVisualStyleBackColor = false;
            this.AutoSize = false;
            Activated = true;//Set inicial value
            onBackBorderColor = Color.MediumSlateBlue;
            onToggleColor = Color.White;
            onTextColor = Color.White;
            offBackBorderColor = Color.LightGray;
            offToggleColor = Color.Gray;
            offTextColor = Color.Gray;
        }
        #endregion

        #region -> Properties

        public override string Text
        {//Override text property
            get { return base.Text; }
            set { base.Text = "#"; }
        }

        [Category("RJ Code Advance")]
        public string ON_Text
        {//Gets or sets the text for the activated state
            get { return onText; }
            set
            {
               
                    onText = value;
                    if (this.DesignMode)//Preview changes in design mode
                        this.Invalidate();//Redraw control (See OnPaint(PaintEventArgs e) method)
                
            }
        }

        [Category("RJ Code Advance")]
        public string OFF_Text
        {//Gets or sets the text for the deactivated state
            get { return offText; }
            set
            {
               
                    offText = value;
                    if (this.DesignMode)//Preview changes in design mode
                        this.Invalidate();//Redraw control (See OnPaint(PaintEventArgs e) method)
                
            }
        }

        [Category("RJ Code Advance")]
        public ControlStyle Style
        { //Sets or gets the toggle button style (Glass or Solid)
            get { return style; }
            set
            {
                style = value;//Set value
                if (this.DesignMode)//Preview changes in design mode
                {
                    ApplyAppearanceSettings();//Refresh appearance settings.
                    this.Invalidate();//Redraw control (See OnPaint(PaintEventArgs e) method)
                }
            }
        }

        [Category("RJ Code Advance")]
        public bool Activated
        {//sets or gets whether the toggle button is ON or OFF.
            //this value is determined by the checked property of the checkbox
            //since they both have a single value: Checked or UnChecked - ON or OFF = true or false.
            get { return this.Checked; }
            set
            {
                this.Checked = value;
            }
        }

        #region - Customizable

        [Category("RJ Code Advance")]
        public bool Customizable
        {//Gets or sets if the control color is customizable or the colors are set by the appearance settings
            get { return customizable; }
            set { customizable = value; }
        }

        [Category("RJ Code Advance")]
        public Color ON_BackBorderColor
        {//Gets or sets the background or border color for the activated state.
            get { return onBackBorderColor; }
            set
            {
                onBackBorderColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }

        [Category("RJ Code Advance")]
        public Color ON_ToggleColor
        {//Gets or sets the toggle color for the activated state.
            get { return onToggleColor; }
            set
            {
                onToggleColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }

        [Category("RJ Code Advance")]
        public Color ON_TextColor
        {//Gets or sets the text color for the activated state.
            get { return onTextColor; }
            set
            {
                onTextColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }

        [Category("RJ Code Advance")]
        public Color OFF_BackBorderColor
        {//Gets or sets the background or border color for the deactivated state.
            get { return offBackBorderColor; }
            set
            {
                offBackBorderColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }

        [Category("RJ Code Advance")]
        public Color OFF_ToggleColor
        {//Gets or sets the toggle color for the deactivated state.
            get { return offToggleColor; }
            set
            {
                offToggleColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }

        [Category("RJ Code Advance")]
        public Color OFF_TextColor
        {//Gets or sets the text color for the deactivated state.
            get { return offTextColor; }
            set
            {
                offTextColor = value;
                if (this.DesignMode)//Preview changes in design mode
                    this.Invalidate();//(See OnPaint(PaintEventArgs e) method)
            }
        }
        #endregion

        #endregion

        #region -> Overrides

        protected override void OnHandleCreated(EventArgs e)
        {
            //Override OnHandleCreated event, occurs when a handle is created,
            //this event is the one that most closely resembles the load event

            base.OnHandleCreated(e);
            this.AutoSize = false;//Set as resizable control
            ApplyAppearanceSettings();//Apply appearance settings
        }
        protected override void OnCheckedChanged(EventArgs e)
        {//Occurs when the value of the Checked or Activated property changes
            base.OnCheckedChanged(e);
            this.Invalidate();//Redraw the control in the ON or OFF desing each time the state changes.(execute the Paint event)
            //(See OnPaint(PaintEventArgs e) method)
        }
        protected override void OnPaint(PaintEventArgs e)
        {//Completely override the paint event and draw a new design of the control

            int toggleSize = this.Height - 7;//Set toggle size

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;//Set Smoothing Mode (Antialiasing)
            e.Graphics.Clear(this.Parent.BackColor);//Draw the background of the control surface

            if (this.Checked)//Draw ON/Activated state design with specified colors
            {
                if (style == ControlStyle.Solid)//If the style is SOLID
                    e.Graphics.FillPath(new SolidBrush(onBackBorderColor), CreateBackgroundFigure());//Draw a filled toggle button background (FillPath)

                else //If the style is GLASS
                    e.Graphics.DrawPath(new Pen(onBackBorderColor, 2), CreateBackgroundFigure());//Draw only border on toggle button (DrawPath)

                //Draw the TOGGLE(lever activated) to the right side of the toggle button with the specified size
                e.Graphics.FillEllipse((Brush)new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 2, 3, toggleSize, toggleSize));

                if (onText != "") //If there is a status text activated
                {
                    //Draw the text as centered as possible
                    e.Graphics.DrawString(onText, this.Font, (Brush)new SolidBrush(onTextColor),
                        /*Location on X axis */(((float)this.Width - this.CreateGraphics().MeasureString(onText, this.Font).Width) / 2F) - (this.Height / 2) + 2,
                        /*Location on Y axis */((float)this.Height - this.CreateGraphics().MeasureString(onText, this.Font).Height) / 2);
                    //MeasureString returns the size of a specified text and font
                }
            }
            else //Draw OFF/Dectivated state design with specified colors
            {
                if (style == ControlStyle.Solid)//If the style is SOLID
                    e.Graphics.FillPath(new SolidBrush(offBackBorderColor), CreateBackgroundFigure());//Draw a filled toggle button background (FillPath)

                else //If the style is GLASS
                    e.Graphics.DrawPath(new Pen(offBackBorderColor, 2), CreateBackgroundFigure());//Draw only border on toggle button (DrawPath)

                //Draw the TOGGLE(lever deactivated) to the left side of the toggle button with the specified size
                e.Graphics.FillEllipse((Brush)new SolidBrush(offToggleColor), new Rectangle(3, 3, toggleSize, toggleSize));

                if (offText != "")//If there is a status text deactivated
                {
                    //Draw the text as centered as possible
                    e.Graphics.DrawString(offText, this.Font, (Brush)new SolidBrush(offTextColor),
                        /*Location on X axis */(((float)this.Width - this.CreateGraphics().MeasureString(offText, this.Font).Width) / 2F) + (this.Height / 2) - 4,
                        /*Location on Y axis */((float)this.Height - this.CreateGraphics().MeasureString(offText, this.Font).Height) / 2F);
                    //MeasureString returns the size of a specified text and font
                }
            }
        }
        #endregion

        #region -> Private methods

        private GraphicsPath CreateBackgroundFigure()
        {//Method to draw the background or only edge with rounded ends of the toggle button
            int arcSize = this.Height - 1;//Set Elliptical Arc Size (height control minus 1, because does not draw in the specified coordinates due to the width of the pen or brush.)
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);//Create a rectangle object for the left arc with the specified location(x,y) and size.
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);//Create a rectangle object for the right arc with the specified location(x,y) and size. (subtract 2px from the width of the control for the widht of brush or pen)
            GraphicsPath path = new GraphicsPath();//Create a Graphics Path object
            path.StartFigure();//Start figure
            path.AddArc(leftArc, 90, 180);//Add the left arc to the figure starting at 90 degrees with a range of 180 degrees.
            path.AddArc(rightArc, 270, 180);//Add the right arc to the figure starting at 270 degrees with a range of 180 degrees.
            path.CloseFigure();//Finish figure
            return path;//Return the background figure
        }
        private void ApplyAppearanceSettings()
        {//Apply appearance settings as long as it is not customizable

            if (customizable == false)
            {

                if (UIAppearance.Theme == UITheme.Light) //Set LIGHT theme colors
                {
                    if (style == ControlStyle.Solid)//Solid Style
                    {
                        onBackBorderColor = UIAppearance.StyleColor;
                        onToggleColor = Color.White;
                        onTextColor = Color.WhiteSmoke;

                        offBackBorderColor = Color.LightGray;
                        offToggleColor = Color.White;
                        offTextColor = Color.Gray;
                    }
                    else //Glass Style
                    {

                        onBackBorderColor = UIAppearance.StyleColor;
                        onToggleColor = UIAppearance.StyleColor;

                        onTextColor = UIAppearance.TextColor;

                        offBackBorderColor = Color.FromArgb(171, 171, 171);
                        offToggleColor = Color.FromArgb(171, 171, 171);
                        offTextColor = Color.Gray;
                    }

                }
                else //Set DARK theme colors
                {

                    onBackBorderColor = UIAppearance.StyleColor;

                    if (style == ControlStyle.Solid)
                    {
                        onToggleColor = Colors.DarkItemBackground;
                        onTextColor = Color.Gainsboro;
                    }
                    else
                    {
                        onToggleColor = UIAppearance.StyleColor;
                        onTextColor = Utils.ColorEditor.Lighten(UIAppearance.TextColor, 20);
                    }

                    offBackBorderColor = Colors.DarkActiveBackground;
                    offToggleColor = Color.FromArgb(110, 104, 153);
                    offTextColor = UIAppearance.TextColor;
                }
            }
        }
        #endregion

    }
}
