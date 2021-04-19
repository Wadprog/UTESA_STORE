
namespace UTESA_STORE.Views
{
    partial class FormSalesMaintenace
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
            this.txtCant = new UTESA_STORE.RJControls.CTTextBox();
            this.CbProd = new System.Windows.Forms.ComboBox();
            this.CbClient = new System.Windows.Forms.ComboBox();
            this.ctLabel1 = new UTESA_STORE.RJControls.CTLabel();
            this.ctLabel2 = new UTESA_STORE.RJControls.CTLabel();
            this.ctLabel3 = new UTESA_STORE.RJControls.CTLabel();
            this.Btn_save = new UTESA_STORE.RJControls.CTButton();
            this.pnlClientArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.Btn_save);
            this.pnlClientArea.Controls.Add(this.ctLabel3);
            this.pnlClientArea.Controls.Add(this.ctLabel2);
            this.pnlClientArea.Controls.Add(this.ctLabel1);
            this.pnlClientArea.Controls.Add(this.CbClient);
            this.pnlClientArea.Controls.Add(this.CbProd);
            this.pnlClientArea.Controls.Add(this.txtCant);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(958, 408);
            // 
            // txtCant
            // 
            this.txtCant._Customizable = false;
            this.txtCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtCant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtCant.BorderColor = System.Drawing.Color.Empty;
            this.txtCant.BorderSize = 2;
            this.txtCant.Location = new System.Drawing.Point(67, 228);
            this.txtCant.MultiLine = false;
            this.txtCant.Name = "txtCant";
            this.txtCant.Padding = new System.Windows.Forms.Padding(2);
            this.txtCant.PasswordChar = false;
            this.txtCant.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCant.PlaceHolderText = null;
            this.txtCant.Size = new System.Drawing.Size(121, 33);
            this.txtCant.Style = UTESA_STORE.RJControls.TextBoxStyle.MatteBorder;
            this.txtCant.TabIndex = 1;
            this.txtCant.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // CbProd
            // 
            this.CbProd.FormattingEnabled = true;
            this.CbProd.Location = new System.Drawing.Point(67, 182);
            this.CbProd.Name = "CbProd";
            this.CbProd.Size = new System.Drawing.Size(121, 24);
            this.CbProd.TabIndex = 8;
            // 
            // CbClient
            // 
            this.CbClient.FormattingEnabled = true;
            this.CbClient.Location = new System.Drawing.Point(67, 125);
            this.CbClient.Name = "CbClient";
            this.CbClient.Size = new System.Drawing.Size(121, 24);
            this.CbClient.TabIndex = 9;
            // 
            // ctLabel1
            // 
            this.ctLabel1.AutoSize = true;
            this.ctLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ctLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.ctLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.ctLabel1.LinkLabel = false;
            this.ctLabel1.Location = new System.Drawing.Point(64, 95);
            this.ctLabel1.Name = "ctLabel1";
            this.ctLabel1.Size = new System.Drawing.Size(45, 16);
            this.ctLabel1.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.ctLabel1.TabIndex = 10;
            this.ctLabel1.Text = "Client";
            this.ctLabel1.Click += new System.EventHandler(this.ctLabel1_Click);
            // 
            // ctLabel2
            // 
            this.ctLabel2.AutoSize = true;
            this.ctLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ctLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.ctLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.ctLabel2.LinkLabel = false;
            this.ctLabel2.Location = new System.Drawing.Point(64, 163);
            this.ctLabel2.Name = "ctLabel2";
            this.ctLabel2.Size = new System.Drawing.Size(67, 16);
            this.ctLabel2.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.ctLabel2.TabIndex = 11;
            this.ctLabel2.Text = "Producto";
            // 
            // ctLabel3
            // 
            this.ctLabel3.AutoSize = true;
            this.ctLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ctLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.ctLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.ctLabel3.LinkLabel = false;
            this.ctLabel3.Location = new System.Drawing.Point(64, 209);
            this.ctLabel3.Name = "ctLabel3";
            this.ctLabel3.Size = new System.Drawing.Size(66, 16);
            this.ctLabel3.Style = UTESA_STORE.RJControls.LabelStyle.Normal;
            this.ctLabel3.TabIndex = 12;
            this.ctLabel3.Text = "Cantidad";
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.Btn_save.BorderRadius = 0;
            this.Btn_save.BorderSize = 1;
            this.Btn_save.Design = UTESA_STORE.RJControls.ButtonDesign.Normal;
            this.Btn_save.FlatAppearance.BorderSize = 0;
            this.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.Color.White;
            this.Btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_save.IconColor = System.Drawing.Color.White;
            this.Btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_save.IconSize = 24;
            this.Btn_save.Location = new System.Drawing.Point(67, 282);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(121, 40);
            this.Btn_save.Style = UTESA_STORE.RJControls.ControlStyle.Solid;
            this.Btn_save.TabIndex = 13;
            this.Btn_save.Text = "Guardar";
            this.Btn_save.UseVisualStyleBackColor = false;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // FormSalesMaintenace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "FormSalesMaintenace";
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Name = "FormSalesMaintenace";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FormSalesMaintenace";
            this.pnlClientArea.ResumeLayout(false);
            this.pnlClientArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJControls.CTTextBox txtCant;
        private RJControls.CTLabel ctLabel1;
        private System.Windows.Forms.ComboBox CbClient;
        private System.Windows.Forms.ComboBox CbProd;
        private RJControls.CTLabel ctLabel3;
        private RJControls.CTLabel ctLabel2;
        private RJControls.CTButton Btn_save;
    }
}