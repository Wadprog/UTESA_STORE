using UTESA_STORE.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTESA_STORE.Settings
{
    public static class SettingsManager
    {
        //Save Appearance Settings
        public static void SaveAppearanceSettings(int theme,
                                                  int style,
                                                  int formBorderSize,
                                                  bool colorFormBorder,
                                                  bool childFormMarker,
                                                  bool formIconActiveMenuItem,
                                                  bool multiChildForms)
        {
            //Set values
            UIAppearanceSettings.Default.Theme = theme;
            UIAppearanceSettings.Default.Style = style;
            UIAppearanceSettings.Default.FormBorderSize = formBorderSize;
            UIAppearanceSettings.Default.ColorFormBorder = colorFormBorder;
            UIAppearanceSettings.Default.ChildFormMarker = childFormMarker;
            UIAppearanceSettings.Default.FormIconActiveMenuItem = formIconActiveMenuItem;
            UIAppearanceSettings.Default.MultiChildForms = multiChildForms;

            UIAppearanceSettings.Default.Save();//Save the current values to the application settings file.
        }
        //Load Apperance Settings
        public static void LoadApperanceSettings()
        {
            UIAppearance.Theme = (UITheme)UIAppearanceSettings.Default.Theme;//Set theme
            UIAppearance.Style = (UIStyle)UIAppearanceSettings.Default.Style;//Set style
            UIAppearance.FormBorderSize = UIAppearanceSettings.Default.FormBorderSize;//Set form border size            
            UIAppearance.ChildFormMarker = UIAppearanceSettings.Default.ChildFormMarker;//Set whether to show the marker of the current child form
            UIAppearance.FormIconActiveMenuItem = UIAppearanceSettings.Default.FormIconActiveMenuItem;//Set whether the active menu item icon is equal to the icon of its associated form.
            UIAppearance.MultiChildForms = UIAppearanceSettings.Default.MultiChildForms;//Set whether to open multiple child forms in the application

            //Set theme colors

            if (UIAppearance.Theme == UITheme.Light) //Light theme
            {
                UIAppearance.BackgroundColor = Colors.LightBackground;
                UIAppearance.ItemBackgroundColor = Colors.LightItemBackground;
                UIAppearance.ActiveBackgroundColor = Colors.LightActiveBackground;
                UIAppearance.PrimaryTextColor = ColorEditor.Darken(Colors.LightTextColor,15);
                UIAppearance.TextColor = Colors.LightTextColor;
            }
            else //Dark theme
            {
                UIAppearance.BackgroundColor = Colors.DarkBackground;
                UIAppearance.ItemBackgroundColor = Colors.DarkItemBackground;
                UIAppearance.ActiveBackgroundColor = Colors.DarkActiveBackground;
                UIAppearance.PrimaryTextColor = ColorEditor.Lighten(Colors.DarkTextColor, 25);
                UIAppearance.TextColor = Colors.DarkTextColor;
            }

            //Set style color
            switch (UIAppearance.Style)
            {
                case UIStyle.Axolotl:
                    UIAppearance.PrimaryStyleColor = Colors.Axolotl;
                    if (UIAppearance.Theme == UITheme.Dark) UIAppearance.StyleColor = ColorEditor.Darken(Colors.Axolotl, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Axolotl, 15);
                    break;

                case UIStyle.FireOpal:
                    UIAppearance.PrimaryStyleColor = Colors.FireOpal;
                    if (UIAppearance.Theme == UITheme.Dark) UIAppearance.StyleColor = ColorEditor.Darken(Colors.FireOpal, 12);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.FireOpal, 15);
                    break;

                case UIStyle.Forest:
                    UIAppearance.PrimaryStyleColor = Colors.Forest;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Forest, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Forest, 15);
                    break;

                case UIStyle.Lisianthus:
                    UIAppearance.PrimaryStyleColor = Colors.Lisianthus;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Lisianthus, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Lisianthus, 15);
                    break;

                case UIStyle.Neptune:
                    UIAppearance.PrimaryStyleColor = Colors.Neptune;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Neptune, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Neptune, 15);
                    break;

                case UIStyle.Petunia:
                    UIAppearance.PrimaryStyleColor = Colors.Petunia;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Petunia, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Petunia, 15);
                    break;

                case UIStyle.Ruby:
                    UIAppearance.PrimaryStyleColor = Colors.Ruby;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Ruby, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Ruby, 15);
                    break;

                case UIStyle.Sky:
                    UIAppearance.PrimaryStyleColor = Colors.Sky;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Sky, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Sky, 15);
                    break;

                case UIStyle.Spinel:
                    UIAppearance.PrimaryStyleColor = Colors.Spinel;
                    if (UIAppearance.Theme == UITheme.Dark)
                        UIAppearance.StyleColor = ColorEditor.Darken(Colors.Spinel, 10);
                    else UIAppearance.StyleColor = ColorEditor.Lighten(Colors.Spinel, 15);
                    break;

                case UIStyle.Supernova:
                    UIAppearance.StyleColor = Colors.Lisianthus;
                    UIAppearance.PrimaryStyleColor = Colors.FantasyColorScheme1;
                    break;
            }

            //Set the border color of the form
            if (UIAppearanceSettings.Default.ColorFormBorder == true)
                UIAppearance.FormBorderColor = UIAppearance.PrimaryStyleColor;
            else UIAppearance.FormBorderColor = Colors.DefaultFormBorderColor;

        }
    }
}
