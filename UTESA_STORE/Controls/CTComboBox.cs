using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using UTESA_STORE.Settings;
using System.Drawing.Design;

namespace UTESA_STORE.RJControls
{
    [DefaultEvent("OnSelectedIndexChanged")] //Default event when double click on control in designer
    public class CTComboBox : UserControl
    {
        /// <summary>
        /// This class inherits the <see cref="UserControl"/>class.
        /// This control exposes most of the most used and essential properties and events of 
        /// a normal combobox, you can add the functionalities that you probably need and are missing here.
        /// On the other hand, you can change the style to solid or glass, also customize the dropdown 
        /// arrow icon and border color.
        /// </summary>

        #region -> Fields
        //Field
        private ControlStyle style;//Style (solid or glass)
        //Controls
        private ComboBox comboList;//Gets or sets the Combo Box (not visible, but can show drop down list)
        private IconButton dropdownArrowIcon;//Gets or sets the Drop down arrow icon (button to show dropdown list)
        private Label label;//Gets or sets the ComboBox Label (to display the text of the combo box, you can change it to TextBox if you want to type in it, or you can use the keystroke event)
        private Color backgroundColor;//Gets or sets the background color.
        private Color iconColor;// Gets or sets the icon color.
        private Color borderColor;// Gets or sets the border color.
        private bool customizable;//Gets or sets whether the control is customizable.

        ///<Note>:ICON BUTTON is provided by <see cref="FontAwesome.Sharp"/> library
        ///      Autor: mkoertgen
        ///      GitHub: https://github.com/awesome-inc/FontAwesome.Sharp
        ///      Nuget Package: https://www.nuget.org/packages/FontAwesome.Sharp </Note>
        #endregion

        #region -> Events

        [Category("RJ Code Advance")]
        public event EventHandler OnSelectedIndexChanged;//Main event of the combo box

        #endregion

        #region -> Constructor

        public CTComboBox()
        {
            InitializeItems();
        }
        private void InitializeItems()
        {
            comboList = new ComboBox();
            dropdownArrowIcon = new IconButton();
            label = new Label();
            style = ControlStyle.Glass;

            this.SuspendLayout();
            // 
            // ComboBox: Combo List
            // 
            comboList.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right)));//Set anchor property
            comboList.Font = new Font("Microsoft Sans Serif", 10F, //if you change the font size you also have to change the combo location
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            comboList.FormattingEnabled = true;
            comboList.Location = new Point(39, 7);
            comboList.Size = new Size(160, 24);
            comboList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Subscribe the control's SelectedIndexChanged event and attach to the previously defined OnSelectedIndexChanged event (see method definition).
            comboList.DropDownClosed += new EventHandler(ComboBox_DropDownClosed);//Subscribe DropDownClosed event

            // 
            // IconButton: Dropdown Arrow Icon
            // 
            dropdownArrowIcon.FlatStyle = FlatStyle.Flat;
            dropdownArrowIcon.FlatAppearance.BorderSize = 0;
            dropdownArrowIcon.Size = new Size(30, 30);
            dropdownArrowIcon.Dock = DockStyle.Right;
            dropdownArrowIcon.BackColor = Color.WhiteSmoke;
            dropdownArrowIcon.IconChar = IconChar.AngleDown;//Set dropdown arrow icon
            dropdownArrowIcon.IconColor = Color.MediumSlateBlue;
            dropdownArrowIcon.IconSize = 22;
            dropdownArrowIcon.Location = new Point(169, 1);
            dropdownArrowIcon.Cursor = Cursors.Hand;
            dropdownArrowIcon.Click += new EventHandler(DropdownArrowIcon_Click);//Subscribe dropdownArrowIcon.Click event (Show combobox dropdown list)
            // 
            // Label: ComboBox Label (Represents the visual part of the ComboBox, displays the text and FILL the user control.)
            // 
            label.BackColor = Color.WhiteSmoke;
            label.Dock = DockStyle.Fill;//Set Fill as Dock Style
            label.Location = new Point(1, 1);
            label.Padding = new Padding(8, 0, 0, 0);
            label.Size = new Size(168, 30);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Text = "";
            label.Font = new Font("Verdana", UIAppearance.TextSize, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));//Font

              // As the label represents the visual part of the ComboBox and occupies most of the RJComboBox user control.
              // We are going to attach the events that occur in the label to the events of the RJComboBox user control,
            label.Click += new EventHandler(RJComboBox_Click);/* That is, when the label is clicked, the click event method defined / created in the 												  form designer of the RJComboBox user control will also be executed.
                                                                 The same goes for the created OnSelectedIndexChanged event and the comboList.SelectedIndexChanged event.
													             see the definition of the event methods to understand better.*/
            label.KeyDown += new KeyEventHandler(RJComboBox_KeyDown);
            label.KeyPress += new KeyPressEventHandler(RJComboBox_KeyPress);
            label.KeyUp += new KeyEventHandler(RJComboBox_KeyUp);
            label.MouseEnter += new EventHandler(RJComboBox_MouseEnter);
            //You can attach the events you want, if it doesn't exist you can create it like you did with the OnSelectedIndexChanged event

            // 
            // User control: RJComboBox
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.MediumSlateBlue;
            this.Padding = new Padding(1);
            this.Size = new Size(200, 32);
            //Add controls
            this.Controls.Add(label);//Fill in the remaining space (display the text of the combobox)
            this.Controls.Add(dropdownArrowIcon);//It is docked on the right side (button to show dropdown list)
            this.Controls.Add(comboList);//It's in the background, behind the label (not visible, but can show drop down list).
            //this order is important, the last controls are added first (from bottom to top)  
            this.Load += new EventHandler(RJComboBox_Load);
            this.ResumeLayout(false);
        }

        #endregion

        #region -> Properties

        #region - Design Properties

        [Category("RJ Code Advance")]
        public ControlStyle Style
        {//Sets or gets the RJComboBox style (Glass or Solid)

            get { return style; }
            set
            {
                style = value;//Set value
                if (this.DesignMode) ApplyAppearanceSettings();//Refresh appearance settings-> preview changes in design mode.
            }
        }
        [Category("RJ Code Advance")]
        public bool Customizable
        {
            get { return customizable; }
            set { customizable = value; }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                label.BackColor = backgroundColor;
                dropdownArrowIcon.BackColor = backgroundColor;
            }
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
                //and the label and dropdown arrow icon button fill the user control.                
            }
        }
        [Category("RJ Code Advance")]      
        public Color IconColor
        {
            get { return dropdownArrowIcon.IconColor; }
            set
            {
                iconColor = value;
                dropdownArrowIcon.IconColor = iconColor;
            }
        }

        public new string Text
        {//Override the text property of the user control and set or get the text of the combo box label
            get { return label.Text; }
            set
            {
                label.Text = value;
            }
        }

        #endregion

        #region - ComboBox Specific Properties

        [Category("RJ Code Advance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items //Gets an object representing the collection of the items contained in this ComboBox.
        {
            get { return comboList.Items; }
            /*
             This property exposes all the functionality of the ITEMS property of the normal 
             combobox (ComboBox.ObjectCollection), such as adding a collection of strings 
             from the designer, using the Items.Add, Items.AddRange, Items.Remove, Items.Count method, etc. 
             In summary,This property enables you to obtain a reference to the list of items that are 
             currently stored in the ComboBox. With this reference, you can add items, remove items,
             and obtain a count of the items in the collection.
             More information:
             https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.items?view=net-5.0#System_Windows_Forms_ComboBox_Items
             */
        }

        [Category("RJ Code Advance")]
        [AttributeProvider(typeof(IListSource))]//List Source
        [DefaultValue("")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource
        {//Gets or sets the data source for this ComboBox.

            get { return comboList.DataSource; }
            set
            {
                comboList.DataSource = value;
            }
        }
        [Category("RJ Code Advance")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
        public string DisplayMember
        {//Gets or sets the property to display for this ListControl.(Inherited from ListControl)

            get { return comboList.DisplayMember; }
            set
            {
                comboList.DisplayMember = value;
            }
        }
        [Category("RJ Code Advance")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
        public string ValueMember
        {//Gets or sets the path of the property to use as the actual value for the items in the ListControl.(Inherited from ListControl)

            get { return comboList.ValueMember; }
            set
            {
                comboList.ValueMember = value;
            }
        }

        [Browsable(false)]//Property not visible in property box
        public int SelectedIndex
        {//Gets or sets the index specifying the currently selected item.

            get { return comboList.SelectedIndex; }
            set
            {
                if (value >= 0)
                {
                    comboList.SelectedIndex = value;
                }
            }
        }

        [Browsable(false)] //Property not visible in property box      
        public object SelectedValue
        {
            get { return this.comboList.SelectedValue; }
        }


        [Browsable(false)]//Property not visible in property box      
        public object SelectedItem
        {
            get { return this.comboList.SelectedItem; }
        }
        //You can add more properties from the normal combo box if you need
        #endregion

        #endregion

        #region -> Private methods

        private void ApplyAppearanceSettings()
        {//Apply Appearance Settings

            comboList.ForeColor = UIAppearance.TextColor;
            comboList.BackColor = UIAppearance.ItemBackgroundColor;

            if (customizable == false)
            {
                switch (style)
                {
                    case ControlStyle.Solid: //Solid Style
                        BorderColor = UIAppearance.StyleColor;
                        label.ForeColor = Color.White;
                        dropdownArrowIcon.IconColor = Color.White;
                        BackgroundColor = UIAppearance.StyleColor;
                        break;

                    case ControlStyle.Glass: //Glass Style

                        dropdownArrowIcon.IconColor = UIAppearance.StyleColor;
                        label.ForeColor = UIAppearance.PrimaryTextColor;
                        BackgroundColor = UIAppearance.BackgroundColor;

                        if (UIAppearance.Theme == UITheme.Dark)
                            BorderColor = Utils.ColorEditor.Darken(UIAppearance.TextColor, 10);
                        else BorderColor = UIAppearance.TextColor;
                        break;
                }
            }
            else
            {
                switch (style)
                {
                    case ControlStyle.Solid: //Solid Style                        
                        label.ForeColor = Color.White;
                        break;

                    case ControlStyle.Glass: //Glass Style                     
                        label.ForeColor = UIAppearance.PrimaryTextColor;
                        break;
                }
            }
        }
        #endregion

        #region -> Public methods

        public void Clear()
        {//Clear Control
            this.label.Text = "";
            this.comboList.Items.Clear();
        }
        #endregion

        #region -> Overrides

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //set the color of the container parent as the background of the combobox when the style is glass.
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

        private void RJComboBox_Load(object sender, EventArgs e)
        {//Load Event
            this.Visible = false;//hide control while applying appearance settings, this prevents flickering when displaying the form.
            ApplyAppearanceSettings(); //Apply UI Appearance Settings
            this.Visible = true;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {/*This event method is subscribed to the SelectedIndexChanged event of the
            ComboBox (comboList), therefore, the event happens when the selection index of the ComboBox 
             changes, then:*/
            //Raise/Invoke default event created to execute all events subscribed to this in the form code.
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(comboList, e);
				
            label.Text = comboList.Text;//When an item is selected from the drop-down list refresh the label text.
        }
        private void DropdownArrowIcon_Click(object sender, EventArgs e)
        {//when the drop down arrow icon button is clicked, the drop down combo box will be displayed

            comboList.Select();//As a precaution, the combobox must be focused before, sometimes some problems happen
            comboList.DroppedDown = true;//Set the DroppedDown property to true to show the dropdown list
            if (customizable)
            {
                switch (style)//Apply a highlight to the drop-down arrow icon button 
                {
                    case ControlStyle.Solid:
                        dropdownArrowIcon.BackColor = Utils.ColorEditor.Darken(backgroundColor, 10);
                        dropdownArrowIcon.IconColor = Color.White;
                        break;
                    case ControlStyle.Glass:
                        dropdownArrowIcon.BackColor = borderColor;
                        dropdownArrowIcon.IconColor = Color.White;
                        break;
                }
            }
            else
            {
                switch (style)//Apply a highlight to the drop-down arrow icon button 
                {
                    case ControlStyle.Solid:
                        dropdownArrowIcon.BackColor = Utils.ColorEditor.Darken(UIAppearance.StyleColor, 10);
                        dropdownArrowIcon.IconColor = Color.White;
                        break;
                    case ControlStyle.Glass:
                        dropdownArrowIcon.BackColor = UIAppearance.StyleColor;
                        dropdownArrowIcon.IconColor = Color.White;
                        BorderColor = UIAppearance.StyleColor;
                        break;
                }
            }
        }
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {//happens when drop down list is closed

            if (customizable)
            {//Disable the icon button highlighting.
                switch (style)
                {
                    case ControlStyle.Solid:
                        dropdownArrowIcon.BackColor = backgroundColor;
                        dropdownArrowIcon.IconColor = iconColor;
                        break;
                    case ControlStyle.Glass:
                        dropdownArrowIcon.BackColor = this.Parent.BackColor;
                        dropdownArrowIcon.IconColor = iconColor;
                        BorderColor = borderColor;
                        break;
                }
            }
            else
            {
                ApplyAppearanceSettings();//Refresh the style to Disable the icon button highlighting.
            }
            /*Property=attribute*/
        }
        private void RJComboBox_Click(object sender, EventArgs e)
        {//Attach user control click event to this event method

            /*This event method is subscribed to the click event of the label (remember that the label represents most
			of the RJComboBox user control), so when the label is clicked we will execute the click event methods 
			subscribed to the control RJComboBox.
            This scenario is the same as the default OnSelectedIndexChanged event created.*/

            this.OnClick(e);//Execute the click event of the RJComboBox user control when the label is clicked.
        }
        private void RJComboBox_MouseEnter(object sender, EventArgs e) //Attach the other events in the same way
        {
            this.OnMouseEnter(e);
        }
        private void RJComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        private void RJComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void RJComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
        //You can keep adding the events you need
        #endregion
    }
}
