using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTESA_STORE.RJForms;
using UTESA_STORE.Settings;
using UTESA_STORE.Utils;

namespace UTESA_STORE.RJForms
{
    public partial class SettingsForm : ChildForm
    {
        /// <summary>
        /// This class inherits from the <see cref="ChildForm"/>  class
        /// </summary>
        /// 

        #region -> Constructor

        public SettingsForm()
        {
            //This form was built by the designer.
            InitializeComponent();
        }
        #endregion

        #region -> Event Methods

        private void RJSettingsForm_Load(object sender, EventArgs e)
        {
            LoadAppearanceSettings(); //Load and display the current appearance settings on the form.
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            SaveAppearanceSettings(); //Save appearance settings
        }

        private void lblRestartApp_Click(object sender, EventArgs e)
        {//Restart application

            Application.Restart();
            Environment.Exit(0);
            /* Note: When executing the application from visual studio, the configuration file is saved 
              * in the folder RJCodeUI_M1.vshost.exe. And when restarting the application the configuration
              * file is obtained from the C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.exe folder, 
			  * since after restarting the application it
              * runs independently of visual studio, so it will not load the settings you established on the 
              * first restart since it will take the file of 
			  * C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.exe configuration. If you want to 
              * test and apply the settings established when you are developing the application, I recommend 
              * you close the application (or stop debugging) and rerun from visual studio or compile the project
              * and run the application directly from the project's bin folder.*/
        }
        #endregion

        #region -> Private methods

        private void LoadAppearanceSettings()
        {//Display the current appearance settings on the form.

            //Theme
            if (UIAppearance.Theme == UITheme.Dark)
                rbDarkTheme.Checked = true;
            else
                rbLightTheme.Checked = true;

            //Style
            cbStyles.DataSource = Enum.GetValues(typeof(UIStyle));
            cbStyles.SelectedIndex = (int)UIAppearance.Style;

            //Form Border Size
            tbmFormBorderSize.Value = UIAppearance.FormBorderSize;

            //Is Color Form Border
            tbColorFormBorder.Checked = UIAppearance.FormBorderColor == Colors.DefaultFormBorderColor ? false : true;

            //Child Form Marker
            tbChildFormMarker.Checked = UIAppearance.ChildFormMarker;

            //Form Icon in Activated Menu Item
            tbIconMenuItem.Checked = UIAppearance.FormIconActiveMenuItem;

            //MDI Desktop Panel
            tbMultiChildForms.Checked = UIAppearance.MultiChildForms;

            //Preview
            panelBorde.Padding = new Padding(UIAppearance.FormBorderSize);
            panelBorde.BackColor = UIAppearance.FormBorderColor;
            panelBackground.BackColor = UIAppearance.BackgroundColor;
            if (UIAppearance.Style == UIStyle.Supernova)
                panelTitleBar.BackColor = ColorEditor.Darken(UIAppearance.BackgroundColor, 9);
            else panelTitleBar.BackColor = UIAppearance.PrimaryStyleColor;

        }
        private void SaveAppearanceSettings()
        {
            //Save appearance settings
            Settings.SettingsManager.SaveAppearanceSettings(rbDarkTheme.Checked ? (int)UITheme.Dark : (int)UITheme.Light,/*Theme*/
                                                            (int)cbStyles.SelectedValue,/*Style*/
                                                            tbmFormBorderSize.Value,/*Form border size*/
                                                            tbColorFormBorder.Checked,/*Color form border*/
                                                            tbChildFormMarker.Checked,/*Child form marker*/
                                                            tbIconMenuItem.Checked,/*Form icon in activated menu item*/
                                                            tbMultiChildForms.Checked);/*Multiple child forms*/
            //Show restart message
            var result = RJMessageBox.Show("Please Restart the application to view changes\nRestart now?",
                                           "Message",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)//Restart application
            {
                Application.Restart();
                Environment.Exit(0);
                 /* Note: When executing the application from visual studio, the configuration file is saved 
              * in the folder RJCodeUI_M1.vshost.exe. And when restarting the application the configuration
              * file is obtained from the C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.exe folder, 
			  * since after restarting the application it
              * runs independently of visual studio, so it will not load the settings you established on the 
              * first restart since it will take the file of 
			  * C:\Users\YourUsername\AppData\Local\RJCodeUI_M1\RJCodeUI_M1.exe configuration. If you want to 
              * test and apply the settings established when you are developing the application, I recommend 
              * you close the application (or stop debugging) and rerun from visual studio or compile the project
              * and run the application directly from the project's bin folder.*/
            }
            else //Show restart message label in case you did not reboot from the message box.
            {
                lblRestartApp.Visible = true;
            }

        }
        #endregion

        #region -> Preview

        private void rbLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightTheme.Checked)
                panelBackground.BackColor = Colors.LightBackground;
            else panelBackground.BackColor = Colors.DarkBackground;

            if (cbStyles.SelectedIndex == (int)UIStyle.Supernova)
                panelTitleBar.BackColor = ColorEditor.Darken(panelBackground.BackColor, 9);
        }

        private void cbStyles_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UIStyle style = (UIStyle)cbStyles.SelectedIndex;
            switch (style)
            {
                case UIStyle.Axolotl:
                    panelTitleBar.BackColor = Colors.Axolotl;
                    break;
                case UIStyle.FireOpal:
                    panelTitleBar.BackColor = Colors.FireOpal;
                    break;
                case UIStyle.Forest:
                    panelTitleBar.BackColor = Colors.Forest;
                    break;
                case UIStyle.Lisianthus:
                    panelTitleBar.BackColor = Colors.Lisianthus;
                    break;
                case UIStyle.Neptune:
                    panelTitleBar.BackColor = Colors.Neptune;
                    break;
                case UIStyle.Petunia:
                    panelTitleBar.BackColor = Colors.Petunia;
                    break;
                case UIStyle.Ruby:
                    panelTitleBar.BackColor = Colors.Ruby;
                    break;
                case UIStyle.Sky:
                    panelTitleBar.BackColor = Colors.Sky;
                    break;
                case UIStyle.Spinel:
                    panelTitleBar.BackColor = Colors.Spinel;
                    break;
                case UIStyle.Supernova:
                    panelTitleBar.BackColor = ColorEditor.Darken(panelBackground.BackColor, 9);
                    break;
            }
            if (tbColorFormBorder.Checked)
            {
                if (cbStyles.SelectedIndex == (int)UIStyle.Supernova)
                    panelBorde.BackColor = Colors.FantasyColorScheme1;
                else panelBorde.BackColor = panelTitleBar.BackColor;
            }
            else panelBorde.BackColor = Colors.DefaultFormBorderColor;
        }

        private void tbmFormBorderSize_Scroll(object sender, EventArgs e)
        {
            panelBorde.Padding = new Padding(tbmFormBorderSize.Value);
        }

        private void tbColorFormBorder_CheckedChanged(object sender, EventArgs e)
        {
            if (tbColorFormBorder.Checked)
            {
                if (cbStyles.SelectedIndex == (int)UIStyle.Supernova)
                    panelBorde.BackColor = Colors.FantasyColorScheme1;
                else panelBorde.BackColor = panelTitleBar.BackColor;
            }
            else panelBorde.BackColor = Colors.DefaultFormBorderColor;
        }
        #endregion

    }
}
