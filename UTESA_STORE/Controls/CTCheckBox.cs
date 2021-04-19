using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UTESA_STORE.Settings;

namespace UTESA_STORE.RJControls
{
    public class CTCheckBox : CheckBox
    {
        /// <summary>
        /// This class inherits from the <see cref="CheckBox"/> class
        /// You can change the button style to glassy or solid (<see cref="ControlStyle Style"/>).
        /// In addition to being able to customize the colors of the background, border, checked, icon, etc.
        /// as long as the customizable property is set to true.
        /// this control does not support having text since the appearance is a button.
        /// </summary>
        /// 

        #region -> Fields

        private bool customizable;//Gets or sets if the control is customizable
        private ControlStyle style;//Gets or sets the CheckBox style (Glass or Solid)
        private IconPictureBox CheckIcon;//Gets or sets checkbox icon checked

        ///<Note>:ICON PICTURE BOX is provided by <see cref="FontAwesome.Sharp"/> library
        ///      Autor: mkoertgen
        ///      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
        ///      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
        #endregion

        #region -> Constructor

        public CTCheckBox()
        {
            CheckIcon = new IconPictureBox();//Initialize check icon 
            CheckIcon.IconChar = IconChar.Check;//Set icon
            CheckIcon.IconSize = 19;
            CheckIcon.IconColor = Color.White;

            this.Appearance = Appearance.Button;//Set button appearance
            this.BackgroundImageLayout = ImageLayout.None;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize= 1;
            this.UseVisualStyleBackColor = false;
            this.Size = new Size(19, 19);
            this.Cursor = Cursors.Hand;
            this.Checked = true;//Set default checked
            this.Image = CheckIcon.Image;//Set check icon as image
            Style = ControlStyle.Solid;//Set Solid Style (Apply UI Appearance Settings )

            this.CheckedChanged += new EventHandler(CheckBox_CheckChanged);//Subscribe CheckedChanged Event
            this.Resize += new EventHandler(CheckBox_Resized);//Subscribe Resize Event

        }
        #endregion

        #region -> Properties

        [Category("RJ Code Advance")]
        public ControlStyle Style
        { //Sets or gets the CheckBox style (Glass or Solid)

            get { return style; }
            set
            {
                style = value;//Set value
                this.Image = null;//Remove check icon (when you change the style, the checkIcon image changes, then the image is obsolete, view codes of the following method)
                ApplyAppearanceSettings();//Refresh or apply  appearance settings.
            }
        }

        #region - Quick access to customize (has no additional functionality)

        [Category("RJ Code Advance")]
        public int BorderSize
        {//Gets or sets the Border Width

            get { return this.FlatAppearance.BorderSize; }
            set { this.FlatAppearance.BorderSize= value; }
        }      

        [Category("RJ Code Advance")]
        public bool Check
        {
            get { return this.Checked; }
            set { this.Checked = value; }
        }
        #endregion

        #region - Customizable properties

        [Category("RJ Code Advance")]
        public bool Customizable
        {//Gets or sets whether the control's appearance colors are customizable, 
            //otherwise the appearance color is set by the appearance settings.
            get { return customizable; }
            set
            {
                customizable = value;
            }
        }
        //The customizable property must be set to true in order to customize these properties, 
        //otherwise it will take appearance setting

        [Category("RJ Code Advance")]
        public override Color BackColor
        {//Gets or sets the background color.
            get { return base.BackColor; }
            set
            {
                if (customizable)
                    base.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {//Gets or sets the border color.
            get { return this.FlatAppearance.BorderColor; }
            set
            {
                if (customizable)
                    this.FlatAppearance.BorderColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color CheckedColor
        {//Gets or sets the background or border color when the button is checked.
            get { return this.FlatAppearance.CheckedBackColor; }
            set
            {
                if (customizable)
                    this.FlatAppearance.CheckedBackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color MouseOverColor
        {//Gets or sets the background color when the mouse passes over the control.

            get { return this.FlatAppearance.MouseOverBackColor; }
            set
            {
                if (customizable)
                    this.FlatAppearance.MouseOverBackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color MouseDownColor
        {//Gets or sets the background color when the control is clicked.
            get { return this.FlatAppearance.MouseDownBackColor; }
            set
            {
                if (customizable)
                    this.FlatAppearance.MouseDownBackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color IconColor
        {//Gets or sets the color of the check icon.
            get { return CheckIcon.IconColor; }
            set
            {
                if (customizable)
                {
                    CheckIcon.IconColor = value;
                    this.Image = CheckIcon.Image;
                }
            }
        }

        [Category("RJ Code Advance")]
        public int IconSize
        {//Gets or sets the size of the check icon.
            get { return CheckIcon.IconSize; }
            set
            {
                if (customizable)
                {
                    CheckIcon.IconSize = value;
                    this.Image = CheckIcon.Image;
                }
            }
        }
        #endregion

        [Browsable(false)]//Hide / disable the text property
        [ReadOnly(true)]
        public override string Text
        {//This control does not support having text since the appearance is a button.
            get { return base.Text; }
            set
            {
                base.Text = "";
            }
        }
        #endregion

        #region -> Private methods

        private void ApplyAppearanceSettings()
        {//Apply appearance settings as long as the customizable property is set to false

            if (customizable == false)
            {
                if (style == ControlStyle.Solid)//If the style is SOLID, apply the following properties
                {
                    this.BackColor = Color.Transparent;//BackColor
                    this.FlatAppearance.BorderColor = UIAppearance.StyleColor;//Border color
                    this.FlatAppearance.CheckedBackColor = UIAppearance.StyleColor;//Checked BackColor
                    this.FlatAppearance.MouseOverBackColor = Utils.ColorEditor.Darken(UIAppearance.StyleColor, 15);//Mouse Over BackColor
                    this.FlatAppearance.MouseDownBackColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 15);//Mouse Down BackColor
                    this.CheckIcon.IconColor = Color.White;//Change the Color of the Check Icon (Create another image, the previous one is deleted)
                    if (this.Checked)//If the checkbox is checked, refresh with the new image
                        this.Image = CheckIcon.Image;
                }
                else //If the style is GLASS, apply the following properties
                {
                    this.BackColor = Color.Transparent;//BackColor
                    this.FlatAppearance.BorderColor = UIAppearance.StyleColor;//Border color
                    this.FlatAppearance.CheckedBackColor = Color.Transparent;//Checked BackColor
                    this.FlatAppearance.MouseOverBackColor = Utils.ColorEditor.Darken(UIAppearance.BackgroundColor, 15);//Mouse Over BackColor
                    this.FlatAppearance.MouseDownBackColor = Utils.ColorEditor.Lighten(UIAppearance.BackgroundColor, 15);//Mouse Down BackColor
                    this.CheckIcon.IconColor = UIAppearance.StyleColor;//Change the Color of the Check Icon (Create another image, the previous one is deleted)
                    if (this.Checked)//If the checkbox is checked, refresh with the new image
                        this.Image = CheckIcon.Image;
                }
            }
            else
            {
                if (this.Checked)
                    this.Image = CheckIcon.Image;
            }
        }
        #endregion

        #region -> Event Methods 

        private void CheckBox_Resized(object sender, EventArgs e)
        {//happens when the checkbox is resized

            if (this.AutoSize == true)//If auto-sized, set the size to 19
                this.Size = new Size(19, 19);
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            if (this.Checked)//If the check box changes to checked state, set the check icon as image
                this.Image = CheckIcon.Image;
            else //If the check box changes to unchecked state, remove check icon
                this.Image = null;
        }
        #endregion

    }
}
