namespace UTESA_STORE.TestAndDemo
{
    partial class FormCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new UTESA_STORE.RJControls.CTButton();
            this.rjButton2 = new UTESA_STORE.RJControls.CTButton();
            this.rjLabel3 = new UTESA_STORE.RJControls.CTLabel();
            this.SearchBox = new UTESA_STORE.RJControls.CTTextBox();
            this.CustomersList = new UTESA_STORE.RJControls.CTDataGridView();
            this.SearchCategory = new UTESA_STORE.RJControls.CTComboBox();
            this.ctLabel1 = new UTESA_STORE.RJControls.CTLabel();
            this.pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.ctLabel1);
            this.pnlClientArea.Controls.Add(this.SearchCategory);
            this.pnlClientArea.Controls.Add(this.btnEdit);
            this.pnlClientArea.Controls.Add(this.rjButton2);
            this.pnlClientArea.Controls.Add(this.rjLabel3);
            this.pnlClientArea.Controls.Add(this.SearchBox);
            this.pnlClientArea.Controls.Add(this.CustomersList);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(958, 518);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.Design = UTESA_STORE.RJControls.ButtonDesign.IconButton;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 24;
            this.btnEdit.Location = new System.Drawing.Point(753, 456);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 40);
            this.btnEdit.Style = UTESA_STORE.RJControls.ControlStyle.Solid;
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.rjButton2.BorderRadius = 5;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.Design = UTESA_STORE.RJControls.ButtonDesign.Custom;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(159)))), ((int)(((byte)(113)))));
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(134)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.rjButton2.IconColor = System.Drawing.Color.White;
            this.rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton2.IconSize = 24;
            this.rjButton2.Location = new System.Drawing.Point(35, 456);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(170, 40);
            this.rjButton2.Style = UTESA_STORE.RJControls.ControlStyle.Solid;
            this.rjButton2.TabIndex = 18;
            this.rjButton2.Text = "Add";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rjLabel3
            // 
            this.rjLabel3.AutoSize = true;
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(241, 24);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(145, 16);
            this.rjLabel3.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 17;
            this.rjLabel3.Text = "Buscar por categoria";
            // 
            // SearchBox
            // 
            this.SearchBox._Customizable = false;
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.SearchBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.SearchBox.BorderSize = 1;
            this.SearchBox.Location = new System.Drawing.Point(244, 43);
            this.SearchBox.MultiLine = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Padding = new System.Windows.Forms.Padding(1);
            this.SearchBox.PasswordChar = false;
            this.SearchBox.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.SearchBox.PlaceHolderText = "Buscar...";
            this.SearchBox.Size = new System.Drawing.Size(429, 33);
            this.SearchBox.Style = UTESA_STORE.RJControls.TextBoxStyle.MatteBorder;
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.onTextChanged += new System.EventHandler(this.SearchBox_onTextChanged);
            // 
            // CustomersList
            // 
            this.CustomersList.AllowUserToResizeRows = false;
            this.CustomersList.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.CustomersList.AlternatingRowsColorApply = false;
            this.CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.CustomersList.BorderRadius = 13;
            this.CustomersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersList.ColumnHeaderColor = System.Drawing.Color.MediumPurple;
            this.CustomersList.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersList.ColumnHeaderHeight = 40;
            this.CustomersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomersList.ColumnHeadersHeight = 40;
            this.CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomersList.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.CustomersList.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersList.Customizable = false;
            this.CustomersList.DgvBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.CustomersList.EnableHeadersVisualStyles = false;
            this.CustomersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomersList.Location = new System.Drawing.Point(35, 82);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.ReadOnly = true;
            this.CustomersList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomersList.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.CustomersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomersList.RowHeadersVisible = false;
            this.CustomersList.RowHeadersWidth = 30;
            this.CustomersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomersList.RowHeight = 40;
            this.CustomersList.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            this.CustomersList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CustomersList.RowsTextColor = System.Drawing.Color.Gray;
            this.CustomersList.RowTemplate.Height = 40;
            this.CustomersList.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.CustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersList.SelectionTextColor = System.Drawing.Color.Gray;
            this.CustomersList.Size = new System.Drawing.Size(888, 368);
            this.CustomersList.TabIndex = 14;
            // 
            // SearchCategory
            // 
            this.SearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.SearchCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.SearchCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.SearchCategory.Customizable = false;
            this.SearchCategory.DataSource = null;
            this.SearchCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.SearchCategory.Location = new System.Drawing.Point(35, 43);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Padding = new System.Windows.Forms.Padding(1);
            this.SearchCategory.SelectedIndex = -1;
            this.SearchCategory.Size = new System.Drawing.Size(200, 32);
            this.SearchCategory.Style = UTESA_STORE.RJControls.ControlStyle.Glass;
            this.SearchCategory.TabIndex = 20;
            // 
            // ctLabel1
            // 
            this.ctLabel1.AutoSize = true;
            this.ctLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ctLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.ctLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.ctLabel1.LinkLabel = false;
            this.ctLabel1.Location = new System.Drawing.Point(36, 24);
            this.ctLabel1.Name = "ctLabel1";
            this.ctLabel1.Size = new System.Drawing.Size(71, 16);
            this.ctLabel1.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.ctLabel1.TabIndex = 21;
            this.ctLabel1.Text = "Categoria";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Lista de cliente";
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.FormIcon = FontAwesome.Sharp.IconChar.UserFriends;
            this.Name = "FormCustomer";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Lista de cliente";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.pnlClientArea.ResumeLayout(false);
            this.pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJControls.CTButton btnEdit;
        private RJControls.CTButton rjButton2;
        private RJControls.CTLabel rjLabel3;
        private RJControls.CTTextBox SearchBox;
        private RJControls.CTDataGridView CustomersList;
        private RJControls.CTLabel ctLabel1;
        private RJControls.CTComboBox SearchCategory;
    }
}