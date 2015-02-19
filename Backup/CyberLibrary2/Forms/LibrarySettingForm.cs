using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CyberLibrary2.Classes;
namespace CyberLibrary2.Forms
{
    public partial class LibrarySettingForm : Form
    {
        public Color[] Colors = 
        {
            Color.AliceBlue,Color.AntiqueWhite,Color.Aqua,Color.Aquamarine,
            Color.Azure,Color.Beige,Color.Bisque,Color.Black,Color.BlanchedAlmond,Color.Blue,
            Color.BlueViolet,Color.Brown,Color.BurlyWood,Color.CadetBlue,Color.Chartreuse,Color.Chocolate,
            Color.Coral,Color.CornflowerBlue,Color.Cornsilk,Color.Crimson,Color.Cyan,Color.DarkBlue,Color.DarkCyan,
            Color.DarkGoldenrod,Color.DarkGray,Color.DarkGreen,Color.DarkKhaki,Color.DarkMagenta,Color.DarkOliveGreen,Color.DarkOrange,
            Color.DarkOrchid,Color.DarkRed,Color.DarkSalmon,Color.DarkSeaGreen,Color.DarkSlateBlue,Color.DarkSlateGray,Color.DarkTurquoise,Color.DarkViolet,
            Color.DeepPink,Color.DeepSkyBlue,Color.DimGray,Color.DodgerBlue,Color.Firebrick,Color.FloralWhite,Color.ForestGreen,Color.Fuchsia,Color.Gainsboro,Color.GhostWhite,Color.Gold,
            Color.Goldenrod,Color.Gray,Color.Green,Color.GreenYellow,Color.Honeydew,Color.HotPink,Color.IndianRed,Color.Indigo,Color.Ivory,Color.Khaki,Color.Lavender,Color.LavenderBlush,Color.LawnGreen,Color.LemonChiffon,
            Color.LightBlue,Color.LightCoral,Color.LightCyan,Color.LightGoldenrodYellow,Color.LightGray,Color.LightGreen,Color.LightPink,Color.LightSalmon,Color.LightSeaGreen,Color.LightSkyBlue,Color.LightSlateGray,Color.LightSteelBlue,Color.LightYellow,Color.Lime,Color.LimeGreen,Color.Linen,Color.Magenta,
            Color.Maroon,Color.MediumAquamarine,Color.MediumBlue,Color.MediumOrchid,Color.MediumPurple,Color.MediumSeaGreen,Color.MediumSlateBlue,Color.MediumSpringGreen,Color.MediumTurquoise,Color.MediumVioletRed,Color.MidnightBlue,Color.MintCream,Color.MistyRose,Color.Moccasin,
            Color.NavajoWhite,Color.Navy,Color.OldLace,Color.Olive,Color.OliveDrab,Color.Orange,Color.OrangeRed,Color.Orchid,Color.PaleGoldenrod,
            Color.PaleGreen,Color.PaleTurquoise,Color.PaleVioletRed,Color.PapayaWhip,Color.PeachPuff,Color.Peru,Color.Pink,Color.Plum,Color.PowderBlue,Color.Purple,Color.Red,Color.RosyBrown,Color.RoyalBlue,Color.SaddleBrown,Color.Salmon,Color.SandyBrown,Color.SeaGreen,Color.SeaShell,Color.Sienna,Color.Silver,Color.SkyBlue,
            Color.SlateBlue,Color.SlateGray,Color.Snow,Color.SpringGreen,Color.SteelBlue,Color.Tan,Color.Teal,Color.Thistle,Color.Tomato,Color.Transparent,Color.Turquoise,Color.Violet,Color.Wheat,Color.White,Color.WhiteSmoke,Color.Yellow,Color.YellowGreen
        };
        public Keys[] Key =
        {
            Keys.A,Keys.B,Keys.C,Keys.D,Keys.E,Keys.F,Keys.G,Keys.H,
            Keys.I, Keys.J,Keys.K,Keys.M,Keys.N,Keys.L,Keys.O,Keys.P,Keys.Q,
            Keys.R,Keys.S,Keys.T,Keys.U,Keys.V,Keys.W,Keys.X,Keys.Y,Keys.Z,
            Keys.F1,Keys.F2,Keys.F3,Keys.F4,Keys.F5,Keys.F6,
            Keys.F7,Keys.F8,Keys.F9,Keys.F10,Keys.F11,Keys.F12,
            Keys.F13,Keys.F14,Keys.F15,Keys.F16,Keys.F17,Keys.F18,Keys.F19,
            Keys.F20,Keys.F21,Keys.F22,Keys.F23,Keys.F24,
            Keys.PageDown,Keys.PageUp,Keys.Insert,Keys.Delete,Keys.Left,Keys.Right,Keys.Up,Keys.Down
        };
        public LibrarySettingForm()
        {
            InitializeComponent();
            string at;
            chkNone.Enabled = false;
            SetNone(false);
            foreach (Keys k in Key)
            {
                ComboKeys.Items.Add(k.ToString());
            }
            foreach (Color c in Colors)
            {
                at = c.ToString().Replace("Color [", "");
                at = at.Replace("]", "");
                ComboMemoBackColor.Items.Add(at);
                ComboMemoFontColor.Items.Add(at);
            }
            foreach (FontFamily family in FontFamily.Families)
                ComboMemoFont.Items.Add(family.Name);
        }


        private void ComboMemoFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMemoFontColor.SelectedIndex < 0) ComboMemoFontColor.SelectedIndex = 1;
            else if (ComboMemoFontColor.SelectedIndex >= 2)
            {
                ProgramSettings.MemoDefaultFontColor = Colors[ComboMemoFontColor.SelectedIndex - 2];
            }
            else if (ComboMemoFontColor.SelectedIndex == 1)
            {
                ProgramSettings.MemoDefaultFontColor = Color.Empty;
            }
        }


        private void btBackColor_Click(object sender, EventArgs e)
        {
            Color BeforeColor = BackColorDialog.Color;
            if (BackColorDialog.ShowDialog() == DialogResult.OK)
            {
                ProgramSettings.MemoDefaultBackColor = BackColorDialog.Color;
            }
            else
            {
                BackColorDialog.Color = BeforeColor;
            }
        }

        private void ListMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListMenu.SelectedIndex >= 0) SetHotKey(ProgramSettings.HotKeys[ListMenu.SelectedIndex]);
            else
            {
                chkNone.Enabled = false;
                SetNone(false);
            }
        }
        private void SetHotKey(ShortCutKey key)
        {
            chkNone.Enabled = true;
            SetNone(true);
            chkControl.Checked = key.Ctrl;
            chkAlt.Checked = key.Alt;
            chkShift.Checked = key.Shift;
            int index = ComboKeys.FindString(key.Key.ToString());
            ComboKeys.SelectedIndex = index;
            chkNone.Checked = key.None;
        }

        private void ComboKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ComboKeys.SelectedIndex;
            if(index>=0) ProgramSettings.HotKeys[ListMenu.SelectedIndex].Key = Key[index];
        }


        private void ComboMemoBackColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMemoBackColor.SelectedIndex < 0) ComboMemoBackColor.SelectedIndex = 1;
            else if(ComboMemoBackColor.SelectedIndex >= 2)
            {
                ProgramSettings.MemoDefaultBackColor = Colors[ComboMemoBackColor.SelectedIndex - 2];
            }
            else if (ComboMemoBackColor.SelectedIndex == 1)
            {
                ProgramSettings.MemoDefaultBackColor = Color.Empty;
            }
        }

        private void ComboMemoFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMemoFont.SelectedIndex < 0) ComboMemoFont.SelectedIndex = 1;
            else if (ComboMemoFont.SelectedIndex == 0)
            {
                ProgramSettings.MemoDefaultFont = null;
            }
            else
            {
                ProgramSettings.MemoDefaultFont = new Font(ComboMemoFont.SelectedItem.ToString(), ProgramSettings.MemoDefaultFont.Size, ProgramSettings.MemoDefaultFont.Style);
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            Color BeforeColor = FontColorDialog.Color;
            if (FontColorDialog.ShowDialog() == DialogResult.OK)
            {
                ProgramSettings.MemoDefaultFontColor = FontColorDialog.Color;
            }
            else
            {
                FontColorDialog.Color = BeforeColor;
            }
        }

        private void btFontSet_Click(object sender, EventArgs e)
        {
            Font BeforeFont = FontDialog.Font;
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                ProgramSettings.MemoDefaultFont = FontDialog.Font;
            }
            else
            {
                ProgramSettings.MemoDefaultFont = BeforeFont;
            }
        }
        private void SetNone(bool tf)
        {
            ComboKeys.Enabled=chkAlt.Enabled = chkControl.Enabled = chkShift.Enabled = tf;
        }
        private void chkNone_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSettings.HotKeys[ListMenu.SelectedIndex].None = chkNone.Checked;
            SetNone(!chkNone.Checked);
        }

        private void chkControl_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSettings.HotKeys[ListMenu.SelectedIndex].Ctrl = chkControl.Checked;

        }

        private void chkAlt_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSettings.HotKeys[ListMenu.SelectedIndex].Alt = chkAlt.Checked;

        }

        private void chkShift_CheckedChanged(object sender, EventArgs e)
        {
            ProgramSettings.HotKeys[ListMenu.SelectedIndex].Shift = chkShift.Checked;

        }
    }
}
