using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UTESA_STORE.Settings;

namespace UTESA_STORE.RJControls
{
    public class CTDataGridView : DataGridView
    {
        #region -> Fields

        private bool customizable;//Gets or sets if the control is customizable
        private bool isAlternatingRowsColor;//Gets or sets if apply a background color to odd-numbered  rows.
        private int borderRadius;//Gets or sets the size of the border radius (rounded corners)
        DataGridViewCellStyle ColumnHeaderStyle;//Sets or gets the style of Column Headers
        DataGridViewCellStyle RowHeaderStyle;//Sets or gets the style of Row Headers
        DataGridViewCellStyle RowStyle;//Sets or gets the Rows style
        #endregion

        #region -> Constructor

        public CTDataGridView()
        {
            InitializeItems();
        }
        private void InitializeItems()
        {
            //Initialize Data Grid View Cell Style Objects
            ColumnHeaderStyle = new DataGridViewCellStyle();
            RowHeaderStyle = new DataGridViewCellStyle();
            RowStyle = new DataGridViewCellStyle();

            //General adjustments
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = RJColors.LightItemBackground;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReadOnly = true;
            this.RightToLeft = RightToLeft.No;
            this.Size = new System.Drawing.Size(450, 250);

            //Set appearance styles in column headers
            ColumnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnHeaderStyle.BackColor = Color.MediumPurple;
            ColumnHeaderStyle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ColumnHeaderStyle.ForeColor = Color.White;
            ColumnHeaderStyle.WrapMode = DataGridViewTriState.True;
            ColumnHeaderStyle.Padding = new Padding(15, 0, 0, 0);
            this.ColumnHeadersDefaultCellStyle = ColumnHeaderStyle;//Set ColumnHeaderStyle
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersHeight = 40;//Set height (for some reason it doesn't work when adding the control to the form, I put a solution on the resize event.)

            //Set appearance styles in Row headers
            RowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RowHeaderStyle.BackColor = Color.WhiteSmoke;
            RowHeaderStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RowHeaderStyle.ForeColor = Color.White;
            RowHeaderStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            RowHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
            RowHeaderStyle.WrapMode = DataGridViewTriState.False;
            this.RowHeadersDefaultCellStyle = RowHeaderStyle;//Set RowHeaderStyle
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RowHeadersWidth = 30;//Set widht 
            this.RowHeadersVisible = false;//Hide Row Header

            //Set appearance styles on rows
            RowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RowStyle.BackColor = RJColors.LightItemBackground;
            RowStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RowStyle.ForeColor = Color.Gray;
            RowStyle.Padding = new Padding(15, 0, 0, 0);
            RowStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            RowStyle.SelectionForeColor = Color.Gray;
            this.RowsDefaultCellStyle = RowStyle;//Set RowStyle
            this.RowTemplate.Height = 40;//Set height  
            BorderRadius = 13;

            this.Resize += new EventHandler(DGV_Resize);//subscribe resize event to apply the appearance configuration (For some reason the HandleCreated event stopped working, you can change if it works for you)

        }

        #endregion

        #region -> Properties

        [Category("RJ Code Advance")]
        public int ColumnHeaderHeight
        {//Sets or gets the height of the column header
            get { return this.ColumnHeadersHeight; }
            set
            {
                this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                if (value < 40)//Minimun Height
                    this.ColumnHeadersHeight = 40;
                else
                    this.ColumnHeadersHeight = value;
            }
        }

        [Category("RJ Code Advance")]
        public DataGridViewAutoSizeColumnsMode ColumnsMode
        {//Sets or gets the autosize columns mode of the DataGrid view
            get { return this.AutoSizeColumnsMode; }
            set
            {
                this.AutoSizeColumnsMode = value;
            }
        }


        [Category("RJ Code Advance")]
        public bool Customizable
        {//Sets or gets if control is customizable or design will be set by appearance settings
            get { return customizable; }
            set
            {
                customizable = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color ColumnHeaderColor
        {//Sets or gets the background color of the column header
            get { return this.ColumnHeadersDefaultCellStyle.BackColor; }
            set
            {
                this.ColumnHeadersDefaultCellStyle.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color ColumnHeaderTextColor
        {//Sets or gets the column header text color
            get { return this.ColumnHeadersDefaultCellStyle.ForeColor; }
            set
            {
                this.ColumnHeadersDefaultCellStyle.ForeColor = value;

            }
        }

        [Category("RJ Code Advance")]
        public Font ColumnHeaderFont
        {//Sets or gets the font of the column header
            get { return this.ColumnHeadersDefaultCellStyle.Font; }
            set
            {
                this.ColumnHeadersDefaultCellStyle.Font = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color RowHeaderColor
        {//Sets or gets the background color of the row header
            get { return this.RowHeadersDefaultCellStyle.BackColor; }
            set
            {
                this.RowHeadersDefaultCellStyle.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color SelectionBackColor
        {//Sets or gets the background color of the selection
            get { return this.RowHeadersDefaultCellStyle.SelectionBackColor; }
            set
            {
                this.RowHeadersDefaultCellStyle.SelectionBackColor = value;
                this.RowsDefaultCellStyle.SelectionBackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color RowsColor
        {//Sets or gets rows color
            get { return this.RowsDefaultCellStyle.BackColor; }
            set
            {
                this.RowsDefaultCellStyle.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public bool AlternatingRowsColorApply
        {//Gets or sets if apply a background color to odd-numbered  rows.

            get { return isAlternatingRowsColor; }
            set
            {
                isAlternatingRowsColor = value;
                if (value == false)//if the value is false restore the default color (Color.Empty)
                {
                    this.AlternatingRowsDefaultCellStyle.BackColor = Color.Empty;
                }
            }
        }

        [Category("RJ Code Advance")]
        public Color AlternatingRowsColor
        {//Sets or gets Alternating Rows color
            get { return this.AlternatingRowsDefaultCellStyle.BackColor; }
            set
            {
                if (isAlternatingRowsColor)
                    this.AlternatingRowsDefaultCellStyle.BackColor = value;
            }
            //Warning:This property can cause a performance impact when getting this property for many rows.
        }

        [Category("RJ Code Advance")]
        public Color RowsTextColor
        {//Sets or gets the text color of the rows
            get { return this.RowsDefaultCellStyle.ForeColor; }
            set
            {
                this.RowsDefaultCellStyle.ForeColor = value;
            }
        }
        [Category("RJ Code Advance")]
        public Color SelectionTextColor
        {
            get { return this.RowsDefaultCellStyle.SelectionForeColor; }
            set { this.RowsDefaultCellStyle.SelectionForeColor = value; }
        }

        [Category("RJ Code Advance")]
        public int RowHeight
        {//Sets or gets the height of the rows
            get { return this.RowTemplate.Height; }
            set
            {
                this.RowTemplate.Height = value;
            }
        }

        [Category("RJ Code Advance")]
        public Color DgvBackColor
        {//Sets or gets the DataGridView BackColor
            get
            {
                return this.BackgroundColor;
            }
            set
            {
                this.BackgroundColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {//Gets or sets border radius
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Utils.RoundedCorner.Apply(this, borderRadius);//Apply rounded border
            }
        }
        #endregion

        #region -> Private methods

        private void ApplyAppearanceSettings()
        {
            if (customizable == false)//if it is not customizable apply the theme
            {
                if (UIAppearance.Theme == UITheme.Dark)//If the theme es Dark, set the following properties
                {
                    DgvBackColor = RJColors.DarkItemBackground; //BackColor
                    RowsColor = RJColors.DarkItemBackground;//Rows color 
                    ColumnHeaderColor = RJColors.DarkActiveBackground;//Column headers color
                    ColumnHeaderTextColor = Color.Gainsboro;
                    RowsTextColor = UIAppearance.PrimaryTextColor;//Rows text color
                    this.GridColor = UIAppearance.BackgroundColor;//Grid color

                    if (isAlternatingRowsColor)//if it is Alternate Rows Color, set a color for the alternate rows color
                    {

                        AlternatingRowsColor = Utils.ColorEditor.Lighten(RJColors.DarkActiveBackground, 5);//Alternate rows back color
                        SelectionBackColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 30);//Selection back color
                        SelectionTextColor = Color.White;//Selection text color
                    }
                    else //Normal rows color
                    {
                        SelectionBackColor = Utils.ColorEditor.Lighten(RJColors.DarkActiveBackground, 5);//Selection back color
                        SelectionTextColor = UIAppearance.PrimaryTextColor;//Selection text color
                    }

                }

                else //If the theme es Light, set the following properties
                {
                    DgvBackColor = RJColors.LightItemBackground;//BackColor
                    RowsColor = RJColors.LightItemBackground;//Rows color   
                    ColumnHeaderColor = UIAppearance.StyleColor;//Column headers color
                    ColumnHeaderTextColor = Color.WhiteSmoke;
                    RowsTextColor = UIAppearance.TextColor;//Rows text color
                    this.GridColor = Color.Gainsboro;//Grid color

                    if (isAlternatingRowsColor)//if it is Alternate Rows Color, set a color for the alternate rows color
                    {
                        AlternatingRowsColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 80);//Alternate rows back color
                        SelectionBackColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 40);//Selection back color
                        SelectionTextColor = Color.White;//Selection text color
                    }
                    else //Normal rows color
                    {
                        SelectionBackColor = Utils.ColorEditor.Lighten(UIAppearance.StyleColor, 80);//Selection back color
                        SelectionTextColor = UIAppearance.TextColor;//Selection text color
                    }
                }
            }
        }
        #endregion

        #region -> Event Methods

        private void DGV_Resize(object sender, EventArgs e)
        {//It is responsible for applying the appearance settings at runtime 
            //and validate the minimum height of the column header.
            if (!this.DesignMode)
                ApplyAppearanceSettings();//Apply UI Appearance Settings

            if (this.ColumnHeadersHeight < 40)//Set Minimun Height
            {
                ColumnHeaderHeight = 40;
            }
        }
        #endregion

    }
}
