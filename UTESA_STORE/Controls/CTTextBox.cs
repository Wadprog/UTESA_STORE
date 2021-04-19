using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UTESA_STORE.Settings;

namespace UTESA_STORE.RJControls
{
    [DefaultEvent("onTextChanged")]//Default event when double click on control in designer
    public class CTTextBox : UserControl
    {
        /// <summary>
        /// This class inherits from the <see cref="UserControl"/> class
        /// This custom text box allows you to change 2 main styles, with a 
        /// border around it or single border at the bottom (underlined).
        /// It also allows adding a watermark (Place Holder) and setting if
        /// it is a password field. In addition to customizing the border color 
        /// and size, background color, text color, and placeholder text color, 
        /// among others.
        /// </summary>
        /// 

        #region -> Fields
        //Fields
        private TextBoxStyle style;//Gets or sets the textbox style ( MatteBorder, FlaringBorder, MatteLine or FlaringLine)
        private Color textColor;//Gets or sets the text color
        private Color placeHolderColor;//Gets or sets the placeholder text color
        private Color backgroundColor;
        private Color borderColor;
        private string placeHolderText;//Gets or sets the placeholder text
        private int borderSize;//Gets or sets the Border Width
        private int maxLength = 32767;//Gets or sets the maximum number of characters in the text box.
        private bool isPlaceHolder;//Gets or sets whether the text box is in placeholder state
        private bool isPasswordChar;//Gets or sets if it is a password character or password field
        private bool customizable; //Gets or sets whether the colors of the control is customizable or is assigned by the appearance settings

        //Controls
        private Panel backBox;//Sets or gets the background of the control
        private TextBox textBox;//Sets or gets the text box
        #endregion

        #region -> Events

        [Category("RJ Code Advance")]
        public event EventHandler onTextChanged;//Default event of the RJTextBox

        #endregion

        #region -> Constructor

        public CTTextBox()
        {
            this.DoubleBuffered = true;
            InitializeItems();
        }

        private void InitializeItems()
        {
            //Initialize objects
            backBox = new Panel();
            textBox = new TextBox();
            backBox.SuspendLayout();
            this.SuspendLayout();

            //
            // Panel:  Control Background
            //
            backBox.BackColor = Colors.LightBackground;
            backBox.Controls.Add(textBox);//Add text box
            backBox.Dock = DockStyle.Fill;//Fill user control
            backBox.Location = new System.Drawing.Point(2, 2);
            backBox.Size = new System.Drawing.Size(246, 29);
            backBox.Padding = new Padding(5, 7, 2, 5);//Set padding
            backBox.Click += new EventHandler(RJTextBox_Click);//Attach to click event method

            //
            // TextBox: (Occupies most of the user control of the RJTextBox)
            //
            textBox.Dock = DockStyle.Fill;//FILL the backBox control
            textBox.BackColor = Colors.LightBackground;
            textBox.BorderStyle = BorderStyle.None;//Remove border
            textBox.Font = new Font("Verdana", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox.ForeColor = UIAppearance.TextColor;
            textBox.Location = new System.Drawing.Point(7, 6);
            textBox.Size = new System.Drawing.Size(245, 28);
            textBox.Enter += new EventHandler(TextBox_Enter);//Subscribe the TextBox enter event, to highlight and remove the placeholder if it is the case.
            textBox.Leave += new EventHandler(TextBox_Leave);//subscribe the TextBox leave event, to unhighlight and re-set the placeholder if it is the case.
            textBox.TextChanged += new EventHandler(TextBox_TextChanged);//Subscribe the control's TextChanged event and attach it to the previously defined default OnTextChanged event (see method definition).

            //As the textBox occupies most of the user control of the RJTextBox. We are going to attach 
            //the event that occurs in the textBox to the event of the RJTextBox user control:
            textBox.Click += new EventHandler(RJTextBox_Click);/*that is, when the textBox is clicked, what is in the RJTextBox user control
                                                                 click event method implemented in the form designer will be executed.
                                                                 The same goes for the default created onTextChanged event and the textBox.TextChanged event */
            textBox.KeyDown += new KeyEventHandler(RJTextBox_KeyDown);
            textBox.KeyPress += new KeyPressEventHandler(RJTextBox_KeyPress);
            textBox.KeyUp += new KeyEventHandler(RJTextBox_KeyUp);
            textBox.MouseEnter += new EventHandler(RJTextBox_MouseEnter);
            //You can attach the events you want, if it doesn't exist you can create it like you did with the OnValueChanged event

            //
            // UserControl: RJTextBox
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = UIAppearance.StyleColor;
            this.Controls.Add(backBox);//Add the backBox control
            this.Size = new System.Drawing.Size(250, 32);
            this.backBox.ResumeLayout(false);
            this.backBox.PerformLayout();
            this.Resize += new EventHandler(TextBox_Resize);
            this.Load += new EventHandler(RJTextBox_Load);
            style = TextBoxStyle.MatteBorder;//Set a default style
            TextColor = Color.FromArgb(64, 64, 64);
            BorderSize = 2;//Set a default Border Width
            this.ResumeLayout(false);
        }
        #endregion

        #region -> Properties

        [Category("RJ Code Advance")]
        public string PlaceHolderText
        {//Gets or sets the placeholder text

            get { return placeHolderText; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {   //if the value is null, empty or consists of only white space characters, 
                    //Set that the text box is not a placeholder and return.
                    isPlaceHolder = false;
                    return;
                }

                textBox.Text = "";//Set blank text in the text box
                placeHolderText = value;//Set the value to the placeholder field.
                SetPlaceholder();//Set the placeholder to the text box.
            }
        }

        public new string Text
        {//Gets or sets the text from the text box
            get
            {
                if (isPlaceHolder)//if text box is a placeholder
                    return "";    //return an empty string
                else           //otherwise return the text
                    return textBox.Text;
            }
            set
            {
                if (placeHolderText != "")
                    RemovePlaceHolder();//Remove the placeholder before assigning the value.

                textBox.Text = value; //Set value.
               
                if (placeHolderText != "")
                {
                    SetPlaceholder();//Set placeholder
                }
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {//Gets or sets the back color

            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                this.backBox.BackColor = backgroundColor;//Set background BackColor
                this.textBox.BackColor = backgroundColor;//Set text box BackColor
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {//Gets or sets the border color

            get { return borderColor; }
            set
            {
                borderColor = value;
                this.BackColor = borderColor;
                //The border color is determined by the BackColor and Padding property of the user control
            }
        }

        [Category("RJ Code Advance")]
        public int BorderSize
        {//Gets or sets the Border Width

            get { return borderSize; }
            set
            {
                if (value == borderSize ||
                    value == 0 || value > 5)//If the value is 0 or greater than 5 do not apply Border Width
                    return;
                borderSize = value;//Set value
                if (this.DesignMode) ApplyAppearanceSettings();//Preview changes at design mode
                /*In the same way as the border color, the Border Width is determined by the
                 * padding property of the user control. See ApplyAppearanceSettings method */
            }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {//Gets or sets the text color
            get { return textColor; }
            set
            {
                textColor = value;
                textBox.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public TextBoxStyle Style
        {//Gets or sets the text style

            get { return style; }
            set
            {
                style = value;
                if (this.DesignMode) ApplyAppearanceSettings();//Preview changes at design mode
            }
        }

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {//Gets or sets if it is a password character or password field

            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
            }
        }

        [Category("RJ Code Advance")]
        public bool MultiLine
        {//Gets or sets whether it is multiline

            get { return this.textBox.Multiline; }
            set
            {
                this.textBox.Multiline = value;
                this.Size = new Size(this.Size.Width, this.textBox.Height + 17);//update height of user control
            }
        }

        [Category("RJ Code Advance")]
        public bool _Customizable
        {//Gets or sets whether the colors of the control is customizable or is assigned depending on the appearance settings

            get { return customizable; }
            set { customizable = value; }
        }

        [Category("RJ Code Advance")]
        public Color PlaceHolderColor
        {//Gets or sets the placeholder text color

            get { return placeHolderColor; }
            set { placeHolderColor = value; }
        }

        [Category("RJ Code Advance")]
        [DefaultValue(32767)]
        public int MaxLength
        {//Gets or sets the maximum number of characters in the text box.

            get { return maxLength; }
            set
            {
                maxLength = value;
                textBox.MaxLength = maxLength;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {//Gets or sets the font

            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox.Font = value;
                this.Size = new Size(this.Size.Width, this.textBox.Height + 17);//update height of user control              

            }
        }

        [Browsable(false)]//Hide the backcolor property
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        #endregion

        #region -> Private methods

        private void SetPlaceholder()
        {//Set placeholder in text box as long as the text box is empty or is null.

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                isPlaceHolder = true;//Sets the text box to placeholder state
                textBox.Text = placeHolderText;//Set placeholder text as text box text
                textBox.ForeColor = placeHolderColor;//Set Placeholder text color
                if (isPasswordChar)//If it is a password field remove the password character to display the placeholder text
                    textBox.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceHolder()
        {
            isPlaceHolder = false;//remove placeholder state from text box
            textBox.Text = "";//Empty text
            if (customizable)//If customizable set specified text color
                textBox.ForeColor = textColor;
            else textBox.ForeColor = UIAppearance.PrimaryTextColor;//Otherwise set the text color specified in the appearance settings                

            if (isPasswordChar)//If it is a password field re-set the password character to mask the characters
                textBox.UseSystemPasswordChar = true;
        }
        private void ApplyAppearanceSettings()
        {
            if (customizable) //If the control is customizable, only apply the border styles
            {
                if (style == TextBoxStyle.MatteLine || style == TextBoxStyle.FlaringLine)
                {
                    backBox.Padding = new Padding(5, 8, 2, 5);
                    this.Padding = new Padding(0, 0, 0, BorderSize);
                }
                else
                {
                    backBox.Padding = new Padding(5, 7, 2, 5);
                    this.Padding = new Padding(BorderSize);
                }
                BorderColor = borderColor;
                BackgroundColor = backgroundColor;

                if (isPlaceHolder)//Set initial text color
                    textBox.ForeColor = placeHolderColor;
                else textBox.ForeColor = textColor;
            }

            else  //Apply Appearance Settings as long as they are not customizable
            {
                //Set placeholder color
                if (UIAppearance.Theme == UITheme.Dark)
                    placeHolderColor = Utils.ColorEditor.Darken(UIAppearance.TextColor, 5);
                else placeHolderColor = Color.DarkGray;

                switch (style)//Set style designs and border
                {
                    case TextBoxStyle.MatteBorder: //The text box has a gray border around it

                        if (UIAppearance.Theme == UITheme.Dark)
                            this.BackColor = Utils.ColorEditor.Darken(UIAppearance.TextColor, 10);//Set border color
                        else this.BackColor = UIAppearance.TextColor;
                        backBox.Padding = new Padding(5, 7, 2, 5);//Set the padding to the background to center the text box
                        this.Padding = new Padding(BorderSize);//Set the border around the entire outline
                        /*the border is determined by the padding property of the user control */
                        break;

                    case TextBoxStyle.FlaringBorder://The text box has a colored border around it

                        BorderColor = UIAppearance.StyleColor;
                        backBox.Padding = new Padding(5, 7, 2, 5);
                        this.Padding = new Padding(BorderSize);
                        break;

                    case TextBoxStyle.MatteLine://The text box only has a gray border at the bottom (underlined)

                        if (UIAppearance.Theme == UITheme.Dark)
                            BorderColor = Utils.ColorEditor.Darken(UIAppearance.TextColor, 10);//Set border color
                        else BorderColor = UIAppearance.TextColor;
                        backBox.Padding = new Padding(5, 8, 2, 5);//Set the padding to the background to center the text box
                        this.Padding = new Padding(0, 0, 0, BorderSize);//Set border only at bottom
                        /*the border is determined by the padding property of the user control */
                        break;

                    case TextBoxStyle.FlaringLine://The text box only has a colored border at the bottom (underlined)

                        BorderColor = UIAppearance.StyleColor;
                        backBox.Padding = new Padding(5, 8, 2, 5);
                        this.Padding = new Padding(0, 0, 0, BorderSize);
                        break;

                }
                BackgroundColor = UIAppearance.BackgroundColor;
                if (isPlaceHolder)//Set initial text color
                    textBox.ForeColor = placeHolderColor;
                else textBox.ForeColor = UIAppearance.PrimaryTextColor;
            }


        }
        #endregion

        #region -> Public methods

        public void Clear()
        {
            Text = string.Empty;
        }
        #endregion

        #region -> Event Methods

        private void RJTextBox_Load(object sender, EventArgs e)
        {//Load Event
            this.Visible = false;//hide control while applying appearance settings, this prevents flickering when displaying the form.
            ApplyAppearanceSettings(); //Apply UI Appearance Settings
            this.Visible = true;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            //when it is entered in the text box remove the placeholder if it is the case 
            //and highlight the border if it is not customizable
            if (isPlaceHolder)
                RemovePlaceHolder();
            if (!customizable)
                BorderColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 15);
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            //when laaves the text box, re-set the placeholder if it is the case and re-set the border color
            if (placeHolderText != "")
                SetPlaceholder();
            if (!customizable)
                ApplyAppearanceSettings();
        }
        private void TextBox_Resize(object sender, EventArgs e)
        {//It happens when the size of the text box is changed

            if (MultiLine == false)//If multiline is disabled, only allow to change width
            {
                this.Size = new Size(this.Size.Width, this.textBox.Height + 17);//The height is kept according to the height of the text box
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {/*This event method is subscribed to the TextChanged event of the
            TextBox, therefore, The event occurs when the value of textbox 
            changes (characters are entered), then:*/
            //Raise/Invoke default event created to execute all events subscribed to this in the form code.
            if (onTextChanged != null)
                onTextChanged.Invoke(sender, e);
        }
        private void RJTextBox_Click(object sender, EventArgs e)
        {//Attach user control click event to this event method

            /* This event method is subscribed to the textBox and backBox click event (remember that these 
             * controls occupy most of the user control), so when the textBox or backBox is clicked,
             * therefore the click events subscribed to the RJTextBox user control will be executed.
              * This scenario is the same as the default event created onTextChanged. */

            this.OnClick(e);//Execute the click event of the RJTextBox user control when the backBox or textBox control is clicked. 
            this.textBox.Focus();//In addition to focusing the text box
        }
        private void RJTextBox_MouseEnter(object sender, EventArgs e) //Attach the other events in the same way
        {
            this.OnMouseEnter(e);
        }
        private void RJTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        private void RJTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void RJTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
        //You can keep adding the events you need
        #endregion

    }
}
