using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTESA_STORE.RJControls
{
    public class CTPanel : Panel
    {
        /// <summary>
        /// This control has no additional customization properties, 
        /// it simply sets the background color based on the theme set by the appearance settings.
        /// </summary>
        /// 

        private bool customizable;

        public bool Customizable
        {//Gets or sets whether the background color of the control is customizable, 
            //otherwise the background color is set by the appearance settings.
            get { return customizable; }
            set { customizable = value; }
        }

        public CTPanel()
        {
        
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ApplyAppearanceSettings();
        }
        private void ApplyAppearanceSettings()
        {//Apply Appearance Settings
            if (customizable == false)
            {
                this.BackColor = Settings.UIAppearance.ItemBackgroundColor;
            }
        }
    }
}
