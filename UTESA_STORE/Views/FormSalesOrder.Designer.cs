﻿namespace UTESA_STORE.TestAndDemo
{
    partial class FormSalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrdersList = new UTESA_STORE.RJControls.CTDataGridView();
            this.rjTextBox1 = new UTESA_STORE.RJControls.CTTextBox();
            this.rjButton1 = new UTESA_STORE.RJControls.CTButton();
            this.cbPeriod = new UTESA_STORE.RJControls.CTComboBox();
            this.rjLabel1 = new UTESA_STORE.RJControls.CTLabel();
            this.rjLabel2 = new UTESA_STORE.RJControls.CTLabel();
            this.rjComboBox2 = new UTESA_STORE.RJControls.CTComboBox();
            this.rjLabel3 = new UTESA_STORE.RJControls.CTLabel();
            this.rjButton2 = new UTESA_STORE.RJControls.CTButton();
            this.pnlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.rjButton2);
            this.pnlClientArea.Controls.Add(this.rjLabel3);
            this.pnlClientArea.Controls.Add(this.rjLabel2);
            this.pnlClientArea.Controls.Add(this.rjComboBox2);
            this.pnlClientArea.Controls.Add(this.rjLabel1);
            this.pnlClientArea.Controls.Add(this.cbPeriod);
            this.pnlClientArea.Controls.Add(this.rjButton1);
            this.pnlClientArea.Controls.Add(this.rjTextBox1);
            this.pnlClientArea.Controls.Add(this.OrdersList);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(958, 518);
            // 
            // OrdersList
            // 
            this.OrdersList.AllowUserToResizeRows = false;
            this.OrdersList.AlternatingRowsColor = System.Drawing.Color.Empty;
            this.OrdersList.AlternatingRowsColorApply = false;
            this.OrdersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.OrdersList.BorderRadius = 13;
            this.OrdersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersList.ColumnHeaderColor = System.Drawing.Color.MediumPurple;
            this.OrdersList.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersList.ColumnHeaderHeight = 40;
            this.OrdersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersList.ColumnHeadersHeight = 40;
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrdersList.ColumnHeaderTextColor = System.Drawing.Color.White;
            this.OrdersList.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersList.Customizable = false;
            this.OrdersList.DgvBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.OrdersList.EnableHeadersVisualStyles = false;
            this.OrdersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrdersList.Location = new System.Drawing.Point(34, 85);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.ReadOnly = true;
            this.OrdersList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrdersList.RowHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.OrdersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersList.RowHeadersVisible = false;
            this.OrdersList.RowHeadersWidth = 30;
            this.OrdersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdersList.RowHeight = 40;
            this.OrdersList.RowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.OrdersList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersList.RowsTextColor = System.Drawing.Color.Gray;
            this.OrdersList.RowTemplate.Height = 40;
            this.OrdersList.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.OrdersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersList.SelectionTextColor = System.Drawing.Color.Gray;
            this.OrdersList.Size = new System.Drawing.Size(888, 368);
            this.OrdersList.TabIndex = 0;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1._Customizable = false;
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjTextBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Location = new System.Drawing.Point(446, 45);
            this.rjTextBox1.MultiLine = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceHolderText = "Search";
            this.rjTextBox1.Size = new System.Drawing.Size(429, 33);
            this.rjTextBox1.Style = UTESA_STORE.RJControls.TextBoxStyle.MatteBorder;
            this.rjTextBox1.TabIndex = 1;
            this.rjTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Design = UTESA_STORE.RJControls.ButtonDesign.IconButton;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(120)))), ((int)(((byte)(218)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.rjButton1.IconColor = System.Drawing.Color.White;
            this.rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rjButton1.IconSize = 24;
            this.rjButton1.Location = new System.Drawing.Point(873, 45);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(49, 34);
            this.rjButton1.Style = UTESA_STORE.RJControls.ControlStyle.Solid;
            this.rjButton1.TabIndex = 2;
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // cbPeriod
            // 
            this.cbPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cbPeriod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.cbPeriod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.cbPeriod.Customizable = false;
            this.cbPeriod.DataSource = null;
            this.cbPeriod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.cbPeriod.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "Last 7 Days",
            "This Month",
            "Last 30 Days",
            "This Year",
            "Custom"});
            this.cbPeriod.Location = new System.Drawing.Point(34, 45);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Padding = new System.Windows.Forms.Padding(1);
            this.cbPeriod.SelectedIndex = -1;
            this.cbPeriod.Size = new System.Drawing.Size(200, 33);
            this.cbPeriod.Style = UTESA_STORE.RJControls.ControlStyle.Glass;
            this.cbPeriod.TabIndex = 3;
            // 
            // rjLabel1
            // 
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(31, 26);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(54, 16);
            this.rjLabel1.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.rjLabel1.TabIndex = 4;
            this.rjLabel1.Text = "Period:";
            // 
            // rjLabel2
            // 
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(237, 26);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(74, 16);
            this.rjLabel2.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.rjLabel2.TabIndex = 6;
            this.rjLabel2.Text = "Category:";
            // 
            // rjComboBox2
            // 
            this.rjComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjComboBox2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.rjComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjComboBox2.Customizable = false;
            this.rjComboBox2.DataSource = null;
            this.rjComboBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.rjComboBox2.Location = new System.Drawing.Point(240, 45);
            this.rjComboBox2.Name = "rjComboBox2";
            this.rjComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox2.SelectedIndex = -1;
            this.rjComboBox2.Size = new System.Drawing.Size(200, 33);
            this.rjComboBox2.Style = UTESA_STORE.RJControls.ControlStyle.Glass;
            this.rjComboBox2.TabIndex = 5;
            // 
            // rjLabel3
            // 
            this.rjLabel3.AutoSize = true;
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(443, 26);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(266, 16);
            this.rjLabel3.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 7;
            this.rjLabel3.Text = "Search by product name or description";
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
            this.rjButton2.Location = new System.Drawing.Point(34, 459);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(170, 40);
            this.rjButton2.Style = UTESA_STORE.RJControls.ControlStyle.Solid;
            this.rjButton2.TabIndex = 11;
            this.rjButton2.Text = "Add";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // FormSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Sales List";
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.FormIcon = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.Name = "FormSalesOrder";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Sales List";
            this.Load += new System.EventHandler(this.FormSalesOrder_Load);
            this.ResizeEnd += new System.EventHandler(this.FormSalesOrder_ResizeEnd);
            this.Move += new System.EventHandler(this.FormSalesOrder_Move);
            this.Resize += new System.EventHandler(this.FormSalesOrder_Resize);
            this.pnlClientArea.ResumeLayout(false);
            this.pnlClientArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.CTDataGridView OrdersList;
        private RJControls.CTButton rjButton1;
        private RJControls.CTTextBox rjTextBox1;
        private RJControls.CTLabel rjLabel3;
        private RJControls.CTLabel rjLabel2;
        private RJControls.CTComboBox rjComboBox2;
        private RJControls.CTLabel rjLabel1;
        private RJControls.CTComboBox cbPeriod;
        private RJControls.CTButton rjButton2;
    }
}