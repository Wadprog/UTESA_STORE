using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UTESA_STORE.Utils
{
    public static class RoundedCorner
    {
        /// <summary>
        /// The <CreateRoundRectRgn/> extern method creates a rectangular region with rounded corners
        /// This method is an external function of the gdi.32 library, 
        /// for this it is necessary to import the gdi.32 library of unmanaged code through
        /// Interop services <see cref="using System.Runtime.InteropServices;"/>
        /// <see cref="DllImportAttribute"/>([DllImport("dll name")]), Indicates that the attributed  
        /// method is exposed by an unmanaged dynamic-link library (DLL) as a static entry point
        /// </summary>
        /// <param name="nLeftRect">Specifies the x-coordinate of the upper-left corner of the rectangular region</param>
        /// <param name="nTopRect">Specifies the y-coordinate of the upper-left corner of the rectangular region</param>
        /// <param name="nRightRect">Specifies the x-coordinate of the lower-right corner of the rectangular region</param>
        /// <param name="nBottomRect">Specifies the y-coordinate of the lower-right corner of the rectangular region</param>
        /// <param name="nWidthEllipse">Specifies the width of the ellipse used to create the rounded corners in the rectangular region</param>
        /// <param name="nHeightEllipse">Specifies the height of the ellipse used to create the rounded corners in the rectangular region</param>
        /// <returns> handle to the region</returns>
        /// 

        #region -> Extern Methods

        [DllImport("Gdi32.dll")]// Import the gdi.32 library (unmanaged code)
        private static extern IntPtr CreateRoundRectRgn(//Declare the external method
                              int nLeftRect,
                              int nTopRect,
                              int nRightRect,
                              int nBottomRect,
                              int nWidthEllipse,
                              int nHeightEllipse);
        #endregion

        #region -> Public methods

        public static void Apply(Control control, int radius)
        {//Apply rounded corners to a control

            if (radius >= 1)
            {
                control.Region =//control region
                      Region.FromHrgn(//new region with rounded corners
                          CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));//call external method and send parameters
                control.Resize += (s, e) =>//if the control is resized reapply a new region with rounded corners
                {
                    control.Region =
                    Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
                };
            }
            else Reset(control);
        }
        public static void Apply(Form form, int radius)
        {//Apply rounded corners to a Form

            if (radius >= 1)
            {
                form.Region =
                    Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius));
                form.Resize += (s, e) =>
                {
                    form.Region =
                    Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius));
                };
            }
            else Reset(form);
        }
        #endregion

        #region -> Private methods

        private static void Reset(Control control)
        { //Remove the rounded corners by setting a new region with its default values.

            control.Region = new Region(new Rectangle(0, 0, control.Width, control.Height));
            control.Resize += (s, e) =>//if the control is resized, reapply a new region to update it.
            {
                control.Region = new Region(new Rectangle(0, 0, control.Width, control.Height));
            };
        }

        private static void Reset(Form form)
        { //Remove the rounded corners by setting a new region with its default values.

            form.Region = new Region(new Rectangle(0, 0, form.Width, form.Height));
            form.Resize += (s, e) =>//if the control is resized, reapply a new region to update it.
            {
                form.Region = new Region(new Rectangle(0, 0, form.Width, form.Height));
            };
        }
        #endregion
    }
}
