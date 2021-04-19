using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UTESA_STORE.Settings;

namespace UTESA_STORE.RJControls
{
    [DefaultEvent("OnValueChanged")]//Default event when double click on control in designer
    public class CTDatePicker : UserControl
    {
        /// <summary>
        /// This class inherits the <see cref="UserControl"/>class.
        /// This control exposes most of the most used and essential properties and events of 
        /// a normal DateTimePicker, you can add the functionalities that you probably need and are missing here.
        /// On the other hand, you can change the style to solid or glass, also customize the dropdown 
        /// calendar icon, border color and border radius (rounded corners, only affect solid style).
        /// </summary>
        /// 

        #region -> Fields

        //Fields
        private int borderRadius;//Gets or sets the size of the border radius (rounded corners)
        private ControlStyle style;//Gets or sets the control style (Glass or Solid)
        //Controls
        private Label dateText;//DateTimePicker Label (to display the date text of the DateTimePicker)
        private IconButton dropdownCalendarIcon;//Drop down calendar icon (button to show the calendar)
        private DateTimePicker datePicker;//DateTimePicker (not visible, but can show drop down calendar)
        private Color backgroundColor;
        private Color borderColor;
        private Color iconColor;
        private bool customizable;

        ///<Note>:ICON BUTTON is provided by <see cref="FontAwesome.Sharp"/> library
        ///      Autor: mkoertgen
        ///      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
        ///      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
        #endregion

        #region -> Events

        [Category("RJ Code Advance")]
        public event EventHandler OnValueChanged;//Default event of the RJDatePicker
        #endregion

        #region -> Constructor

        public CTDatePicker()
        {
            InitializeItems();

        }
        private void InitializeItems()
        {
            dateText = new Label();
            datePicker = new DateTimePicker();
            dropdownCalendarIcon = new IconButton();
            this.SuspendLayout();
            // 
            // Label: Date Text (Represents the visual part of the DateTimePicker, displays the date text and FILL the user control)
            //           
            dateText.Dock = DockStyle.Fill;//Set Fill as Dock Style
            dateText.FlatStyle = FlatStyle.Flat;
            dateText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dateText.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dateText.ImageAlign = ContentAlignment.MiddleLeft;
            dateText.Location = new Point(1, 1);
            dateText.Name = "dateText";
            dateText.Padding = new Padding(8, 0, 0, 0);
            dateText.Size = new Size(188, 30);
            dateText.TextAlign = ContentAlignment.MiddleLeft;

            //As the dataText represents the visual part of the DateTimePicker and fills most of the RJDatePicker user control. We are going to attach the event 
            //that occurs in the label to the event of the RJDateTimePicker user control
            dateText.Click += new EventHandler(RJDatePicker_Click);/*that is, when the label is clicked, what is in the RJDatePicker user control 
                                                                    click event method implemented in the form designer will be executed.
                                                                    The same goes for the created OnValueChanged event and the
                                                                    datePicker.ValueChanged event*/
            dateText.KeyDown += new KeyEventHandler(RJDatePicker_KeyDown);
            dateText.KeyPress += new KeyPressEventHandler(RJDatePicker_KeyPress);
            dateText.KeyUp += new KeyEventHandler(RJDatePicker_KeyUp);
            dateText.MouseEnter += new EventHandler(RJDatePicker_MouseEnter);
            //You can attach the events you want, if it doesn't exist you can create it like you did with the OnValueChanged event

            // 
            // IconButton: Dropdown Calendar Icon
            //             
            dropdownCalendarIcon.Dock = DockStyle.Right;
            dropdownCalendarIcon.FlatAppearance.BorderSize = 0;
            dropdownCalendarIcon.FlatStyle = FlatStyle.Flat;
            dropdownCalendarIcon.Flip = FlipOrientation.Normal;
            dropdownCalendarIcon.IconChar = IconChar.CalendarAlt;//Set dropdown calendar icon
            dropdownCalendarIcon.IconColor = Color.White;
            dropdownCalendarIcon.IconSize = 22;
            dropdownCalendarIcon.Location = new Point(189, 1);
            dropdownCalendarIcon.Name = "dropdownArrowIcon";
            dropdownCalendarIcon.Rotation = 0D;
            dropdownCalendarIcon.Size = new Size(30, 30);
            dropdownCalendarIcon.UseVisualStyleBackColor = false;
            dropdownCalendarIcon.Cursor = Cursors.Hand;
            dropdownCalendarIcon.Click += new EventHandler(dropdownCalendarIcon_Click);//Subscribe Click event (Show Calendar)

            // 
            // DateTimePicker: Date Picker
            // 
            datePicker.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right)));//Set anchor property
            datePicker.Location = new Point(5, 9);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(178, 20);
            datePicker.CloseUp += new EventHandler(DatePicker_CloseUp);//Subscribe CloseUp event (the drop-down calendar is hidden)
            datePicker.ValueChanged += new EventHandler(DatePicker_ValueChanged);//Subscribe the control's ValueChanged event and attach to the previously defined OnValueChanged event (see method definition).

            // 
            // User control: RJDatePicker
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.MediumSlateBlue;
            this.MinimumSize = new Size(120, 25);
            this.Padding = new Padding(1);
            this.Size = new Size(260, 32);
            //Add controls
            this.Controls.Add(dateText);//Fill in the remaining space (display the text of the datePicker)
            this.Controls.Add(dropdownCalendarIcon);//It is docked on the right side (button to show dropdown calendar)
            this.Controls.Add(datePicker);//It's in the background, behind the dateText (not visible, but can show dropdown calendar).
            //this order is important, the last controls are added first (from bottom to top)

            this.Load += new EventHandler(DatePicker_Load);//Subscribe Load event
            Style = ControlStyle.Glass;
            this.ResumeLayout(false);
        }
        #endregion

        #region -> Properties

        #region - Design Properties

        [Category("RJ Code Advance")]
        public ControlStyle Style
        {//Sets or gets the style (Glass or Solid)

            get { return style; }
            set
            {
                style = value;//Set value              
                BorderRadius = borderRadius;//Refresh border radius
                if (this.DesignMode) ApplyAppearanceSettings();//refresh  appearance settings-> preview changes in design mode.
            }
        }

        [Category("RJ Code Advance")]
        public bool Customizable
        {
            get { return customizable; }
            set { customizable = value; }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {//Sets or sets the border color

            get { return this.BackColor; }
            set
            {
                borderColor = value;
                this.BackColor = borderColor;
                //the background of the user control acts as the border because of the fill property 
                //and the label and dropdown calendar icon button fill the user control. 
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                dateText.BackColor = backgroundColor;
                dropdownCalendarIcon.BackColor = backgroundColor;
            }
        }

        [Category("RJ Code Advance")]
        [DefaultValue(true)]
        public Color IconColor
        {//Sets or sets the icon color

            get { return dropdownCalendarIcon.IconColor; }
            set
            {
                iconColor = value;
                dropdownCalendarIcon.IconColor = iconColor;
            }
        }

        [Category("RJ Code Advance")]
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
        #endregion

        #region - DateTimePicker Specific Properties

        [Category("RJ Code Advance")]
        public DateTimePickerFormat Format
        {//Gets or sets the format of the date and time displayed in the control

            get { return datePicker.Format; }
            set
            {
                datePicker.Format = value;
                dateText.Text = datePicker.Text;//Refrest Date Text
            }
        }

        [Category("RJ Code Advance")]
        public string CustomFormat
        {//Gets or sets the custom date/time format string
            get { return datePicker.CustomFormat; }
            set
            {
                datePicker.CustomFormat = value;
                dateText.Text = datePicker.Text;//Refrest Date Text
            }

        }
        [Category("RJ Code Advance")]
        public DateTime Value
        {//Gets or sets the date/time value assigned to the control
            get { return datePicker.Value; }
            set
            {
                datePicker.Value = value;
                dateText.Text = datePicker.Text;//Refrest Date Text
            }
        }

        [Browsable(false)]//Property not visible in property box
        public override string Text//Override text property of user control
        {
            get { return datePicker.Text; }//Return Date Text

        }
        #endregion

        #endregion

        #region -> Private methods

        private void ApplyAppearanceSettings()
        {//Apply Appearance Settings
            if (customizable)
            {
                switch (style)
                {
                    case ControlStyle.Solid://Solid Style                     
                        dateText.ForeColor = Color.White;
                        break;
                    case ControlStyle.Glass://Glass Style                        
                        dateText.ForeColor = UIAppearance.PrimaryTextColor;
                        break;
                }
            }
            else
            {
                switch (style)
                {
                    case ControlStyle.Solid://Solid Style
                        BorderColor = UIAppearance.StyleColor;
                        //dateText.BackColor = UIAppearance.StyleColor;
                        dateText.ForeColor = Color.White;
                        dropdownCalendarIcon.IconColor = Color.White;
                        BackgroundColor = UIAppearance.StyleColor;
                        break;
                    case ControlStyle.Glass://Glass Style

                        dropdownCalendarIcon.IconColor = UIAppearance.StyleColor;
                        dateText.ForeColor = UIAppearance.PrimaryTextColor;
                        BackgroundColor = UIAppearance.BackgroundColor;
                        //dropdownCalendarIcon.BackColor = UIAppearance.BackgroundColor;

                        if (UIAppearance.Theme == UITheme.Dark)
                            BorderColor = Utils.ColorEditor.Darken(UIAppearance.TextColor, 10);
                        else BorderColor = UIAppearance.TextColor;


                        break;
                }
            }
        }
        #endregion

        #region -> Overrides

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //set the color of the container parent as the background of the datePicker when the style is glass.
            if (this.Parent != null)
            {
                if (customizable)
                {
                    if (style == ControlStyle.Glass)
                    {
                        BackgroundColor = this.Parent.BackColor;
                    }
                }
            }
            /*Note: I use this event because it runs before displaying the form.
             * The load event of the user control is executed before the load event 
             * of the form, so it does not work in this scenario.*/

        }
        #endregion

        #region -> Event Methods

        private void DatePicker_Load(object sender, EventArgs e)
        {//RJDatePicker Load Event  
            dateText.Text = datePicker.Text;//Refresh Date Text 

            this.Visible = false;//hide control while applying appearance settings, this prevents flickering when displaying the form.
            ApplyAppearanceSettings(); //Apply UI Appearance Settings
            this.Visible = true;
        }
        private void dropdownCalendarIcon_Click(object sender, EventArgs e)
        {//when the drop down arrow icon button is clicked, the dropdown calendar will be displayed

            this.datePicker.Select();//As a precaution, the datePicker must be focused before, sometimes some problems happen
            SendKeys.Send("%{DOWN}");//This control does not have the DroppedDown property to display the calendar
            //therefore we will use the shortcut keys of the OS to display the calendar: Alt key + down arrow is pressed
            //Alt Key=%
            //Down Arrow Key= DOWN
            //So we send keystrokes when calendar icon is clicked
            if (customizable)
            {
                switch (style)//Apply a highlight to the drop-down arrow icon button (Active icon button)
                {
                    case ControlStyle.Solid:
                        dropdownCalendarIcon.BackColor = Utils.ColorEditor.Darken(backgroundColor, 10);
                        dropdownCalendarIcon.IconColor = Color.White;
                        break;
                    case ControlStyle.Glass:
                        dropdownCalendarIcon.BackColor = borderColor;
                        dropdownCalendarIcon.IconColor = Color.White;
                        break;
                }
            }
            else
            {
                switch (style)//Apply a highlight to the drop-down arrow icon button (Active icon button)
                {
                    case ControlStyle.Solid:
                        dropdownCalendarIcon.BackColor = Utils.ColorEditor.Darken(UIAppearance.StyleColor, 10);
                        dropdownCalendarIcon.IconColor = Color.White;
                        break;
                    case ControlStyle.Glass:
                        dropdownCalendarIcon.BackColor = UIAppearance.StyleColor;
                        dropdownCalendarIcon.IconColor = Color.White;
                        BorderColor = UIAppearance.StyleColor;
                        break;
                }
            }
        }
        private void DatePicker_CloseUp(object sender, EventArgs e)
        {//Occurs when the drop-down calendar is hidden
            if (customizable)
            {
                switch (style)
                {
                    case ControlStyle.Solid:
                        dropdownCalendarIcon.BackColor = backgroundColor;
                        dropdownCalendarIcon.IconColor = iconColor;
                        break;
                    case ControlStyle.Glass:
                        dropdownCalendarIcon.BackColor = this.Parent.BackColor;
                        dropdownCalendarIcon.IconColor = iconColor;
                        break;
                }
            }
            else
            {
                ApplyAppearanceSettings();//Refresh appearance (Deactivate icon button)  
            }
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {/*This event method is subscribed to the ValueChanged event of the
            DateTimePicker (datePicker), therefore, The event occurs when the value of datepicker(datePicker) 
            changes (a date or time has been chosen), then:*/
            //Raise/Invoke default event created to execute all events subscribed to this in the form code.
            if (OnValueChanged != null)
                OnValueChanged.Invoke(datePicker, e);          

            dateText.Text = datePicker.Text;//When a date is selected from the drop-down calendar, refresh the label text.
        }
        private void RJDatePicker_Click(object sender, EventArgs e)
        { //Attach user control click event to this event method

            /*This event method is subscribed to the click event of the label (remember that the label represents most
           of the RJDatePicker user control), so when the label is clicked we will execute the click event methods 
           subscribed to the control RJDatePicker.
           This scenario is the same as the default OnValueChanged event created.*/

            this.OnClick(e);//Execute the click event of the RJDatePicker user control when the label is clicked.
        }
        private void RJDatePicker_MouseEnter(object sender, EventArgs e) //Attach the other events in the same way
        {
            this.OnMouseEnter(e);
        }
        private void RJDatePicker_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        private void RJDatePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void RJDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
        //You can keep adding the events you need
        #endregion


    }
}