using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UTESA_STORE.Settings;
using FontAwesome.Sharp;
using UTESA_STORE.Utils;

namespace UTESA_STORE.RJControls
{
    public class CTButton : IconButton
    {
        ///<summary>
        ///------This class inherits from the <see cref="IconButton"/> class of the <see cref="FontAwesome.Sharp"/> library
        ///      Autor: mkoertgen   
        ///      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp 
        ///      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp   
        /// This button implements 4 appearance properties:
        ///->You can change the button style to glass or solid (<see cref="ControlStyle Style"/>).
        ///->You can change the button design to Normal, Icon Button, Metro, Confirm, Cancel or Delete(<see cref="ButtonDesign Design"/>).
        ///->You can set rounded border, however it only affects the solid style (<see cref="int BorderRadius"/>)
        ///->You can change the button border size (Only for glass style)
        /// </summary>

        #region -> Fields

        private ControlStyle style;//Gets or sets the button style (Glass or Solid)
        private ButtonDesign design;//Gets or sets the button design (Normal, Icon Button, Metro, Confirm, Cancel or Delete)
        private Size tempSize;//Gets or sets the temporary size of the button
        private int borderRadius;//Gets or sets the size of the border radius (rounded corners)
        private int borderSize;//Gets or sets the size the size of the button border

        //Static Field
        private static readonly Color supernovaColor = UIAppearance.Style == UIStyle.Supernova ? Colors.GetSupernovaColor() : Color.CornflowerBlue;//Sets and Gets supernova color if the style is supernova
        #endregion

        #region -> Constructor

        public CTButton()
        {
            //Initialize properties
            this.BackColor = UIAppearance.StyleColor;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Flip = FlipOrientation.Normal;
            this.Font = new Font("Microsoft Sans Serif", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.White;
            this.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconSize = 24;
            this.IconColor = Color.White;
            this.Rotation = 0D;
            this.Size = new Size(170, 40);
            tempSize = new Size(170, 40);
            borderSize = 1;
            style = ControlStyle.Solid;//Solid as default
            this.HandleCreated += new EventHandler(Button_HandleCreated);//Associate with HandleCreated event
        }
        #endregion

        #region -> Properties

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.FlatAppearance.BorderSize = borderSize;

            }
        }

        [Category("RJ Code Advance")]
        [Description("Solid style only")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                if (style == ControlStyle.Solid)
                {//Apply rounded border if the style is solid
                    Utils.RoundedCorner.Apply(this, borderRadius);
                }

                else //Do not apply rounded edges if the style is glass
                {
                    //Restore normal region                  
                    Utils.RoundedCorner.Apply(this, 0);
                }
            }
        }

        [Category("RJ Code Advance")]
        public ControlStyle Style
        {
            get { return style; }
            set
            {
                style = value;

                if (this.DesignMode)
                {
                    /* if it is in design mode refresh the appearance. 
                     * This is only to preview the changes, hence the design mode only condition. 
                     * The HandleCreated event is responsible for applying the appearance
                     * settings at runtime.*/
                    ApplyAppearanceSettings();
                }
            }
        }

        [Category("RJ Code Advance")]
        public ButtonDesign Design
        {
            get { return design; }
            set
            {
                design = value;
                if (this.DesignMode)
                {
                    switch (design)
                    {
                        case ButtonDesign.Normal:

                            NormalButton();//Set properties of a normal button
                            this.IconChar = FontAwesome.Sharp.IconChar.None;//Remove icon


                            break;

                        case ButtonDesign.IconButton:

                            IconButton();//Set properties of a icon button                        

                            if (this.IconChar == FontAwesome.Sharp.IconChar.None ||//If it has no icon or the icon is to confirm, cancel or delete, set a default icon
                            this.IconChar == FontAwesome.Sharp.IconChar.Check ||
                            this.IconChar == FontAwesome.Sharp.IconChar.TrashAlt ||
                            this.IconChar == FontAwesome.Sharp.IconChar.TimesCircle)
                                this.IconChar = FontAwesome.Sharp.IconChar.Magento;
                            else
                            {
                                //Keep specified icon (the icon specified at runtime will also be kept)
                            }
                            break;

                        case ButtonDesign.Metro:

                            MetroButton();//Set properties of a Metro button                        

                            if (this.IconChar == FontAwesome.Sharp.IconChar.None ||//If it has no icon or the icon is to confirm, cancel or delete, set a default icon
                            this.IconChar == FontAwesome.Sharp.IconChar.Check ||
                            this.IconChar == FontAwesome.Sharp.IconChar.TrashAlt ||
                            this.IconChar == FontAwesome.Sharp.IconChar.TimesCircle)
                                this.IconChar = FontAwesome.Sharp.IconChar.Firefox;
                            else
                            {
                                //Keep specified icon (the icon specified at runtime will also be kept)
                            }
                            break;

                        case ButtonDesign.Confirm:

                            IconButton();//Set properties of a icon button
                            this.IconChar = FontAwesome.Sharp.IconChar.Check;//Set confirm icon
                            this.Text = "Confirm";//Set tex

                            break;

                        case ButtonDesign.Cancel:
                            IconButton();//Set properties of a icon button
                            this.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;//Set cancel icon
                            this.Text = "Cancel";//Set text

                            break;

                        case ButtonDesign.Delete:

                            IconButton();//Set properties of a icon button
                            this.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;//Set delete icon
                            this.Text = "Delete";//Set text

                            break;
                        case ButtonDesign.Custom:
                            //Do nothing, do not apply appearance settings
                            break;
                    }

                    ApplyAppearanceSettings();

                }
            }
        }
        #endregion

        #region -> Private methods

        private void NormalButton()
        {
            //This method sets the normal button design
            this.Size = tempSize;//Reset specified size
            this.IconSize = 24;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.TextImageRelation = TextImageRelation.Overlay;
        }
        private void IconButton()
        {
            //This method sets the icon button design
            this.Size = tempSize;//Reset specified size
            this.IconSize = 24;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.ImageAlign = ContentAlignment.MiddleCenter;
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        private void MetroButton()
        {
            //This method sets the metro button design
            tempSize = this.Size;//Save the size of previous designs
            this.Size = new Size(110, 110);//Set new size
            this.IconSize = 50;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.MiddleCenter;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
        }
        private void ApplyAppearanceSettings()
        {//Apply appearance settings

            BorderRadius = borderRadius;//Update border radius

            if (style == ControlStyle.Solid)//Solid Style
            {
                this.FlatAppearance.BorderSize = 0;
                if (design != ButtonDesign.Custom)
                {
                    this.ForeColor = Color.White;
                    this.IconColor = Color.White;
                }

                //Normal, IconButton and Metro button design
                if (design == ButtonDesign.Normal || design == ButtonDesign.IconButton || design == ButtonDesign.Metro)
                {
                    if (UIAppearance.Style == UIStyle.Supernova)
                    {
                        this.BackColor = supernovaColor;
                        this.FlatAppearance.BorderColor = supernovaColor;
                    }
                    else
                    {
                        this.BackColor = UIAppearance.StyleColor;
                        this.FlatAppearance.BorderColor = UIAppearance.StyleColor;
                    }
                }

                else if (design == ButtonDesign.Confirm)//Confirm button design
                {
                    this.BackColor = Colors.Confirm;
                    this.FlatAppearance.BorderColor = Colors.Confirm;
                }

                else if (design == ButtonDesign.Cancel)//Cancel button design
                {
                    this.BackColor = Colors.Cancel;
                    this.FlatAppearance.BorderColor = Colors.Cancel;
                }

                else if (design == ButtonDesign.Delete)//Delete button design
                {
                    this.BackColor = Colors.Delete;
                    this.FlatAppearance.BorderColor = Colors.Delete;
                }
                this.FlatAppearance.MouseDownBackColor = ColorEditor.Lighten(this.BackColor, 15);
            }

            else //Glass Style
            {
                BorderSize = borderSize;
                this.BackColor = Color.Empty;
                this.FlatAppearance.MouseDownBackColor = Color.Transparent;
                //Normal, IconButton and Metro button design
                if (design == ButtonDesign.Normal || design == ButtonDesign.IconButton || design == ButtonDesign.Metro)
                {
                    if (UIAppearance.Style == UIStyle.Supernova)
                    {
                        if (UIAppearance.Theme == UITheme.Light)
                        {
                            this.ForeColor = supernovaColor;
                            this.IconColor = supernovaColor;
                            this.FlatAppearance.BorderColor = supernovaColor;
                        }
                        else
                        {
                            this.ForeColor = ColorEditor.Lighten(supernovaColor, 15);
                            this.IconColor = this.ForeColor;
                            this.FlatAppearance.BorderColor = this.ForeColor;
                        }
                    }
                    else
                    {
                        this.IconColor = UIAppearance.StyleColor;
                        this.ForeColor = UIAppearance.StyleColor;
                        this.FlatAppearance.BorderColor = UIAppearance.StyleColor;
                    }
                }

                else if (design == ButtonDesign.Confirm) //Confirm button design
                {
                    this.IconColor = Colors.Confirm;
                    this.ForeColor = Colors.Confirm;
                    this.FlatAppearance.BorderColor = Colors.Confirm;
                }

                else if (design == ButtonDesign.Cancel) //Cancel button design
                {
                    this.IconColor = Colors.Cancel;
                    this.ForeColor = Colors.Cancel;
                    this.FlatAppearance.BorderColor = Colors.Cancel;
                }

                else if (design == ButtonDesign.Delete)//Delete button design
                {
                    this.IconColor = Colors.Delete;
                    this.ForeColor = Colors.Delete;
                    this.FlatAppearance.BorderColor = Colors.Delete;
                }

            }

        }
        #endregion

        #region -> Event Methods

        private void Button_HandleCreated(object sender, EventArgs e)
        {//Handle Created Event
            if (!this.DesignMode)//Apply appearance settings at runtime
            {
                ApplyAppearanceSettings();
            }
        }
        #endregion

    }
}

