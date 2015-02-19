using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;
namespace CyberLibrary2.Classes
{
    public static class SettingData
    {
        public static DataSet XMLDataSet;
        public static bool InitFile(string FileName)
        {
            XMLDataSet = new DataSet();
            try
            {
                XMLDataSet.ReadXml(FileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void InitSettings()
        {
            FileInfo finfo = new FileInfo(Application.StartupPath + @"\Settings.XML");
            if(!finfo.Exists)
            {
                ProgramSettings.Init();
                return;
            }
            try
            {
                XMLDataSet = new DataSet();
                XMLDataSet.ReadXml(Application.StartupPath + @"\Settings.XML");
                foreach (DataTable t in XMLDataSet.Tables)
                {
                    foreach (DataRow row in t.Rows)
                    {
                        SettingSet(row.ItemArray);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private static void SettingSet(object[] ItemArray)
        {
            string Name = ItemArray[0].ToString();
            switch (Name)
            {
                case "Memo":
                    ProgramSettings.Memo = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "MemoView":
                    ProgramSettings.MemoView = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "MemoBottomView":
                    ProgramSettings.MemoBottomView = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "MemoTopView":
                    ProgramSettings.MemoTopView = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "MemoMiddleView":
                    ProgramSettings.MemoMiddleView = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "BackgroundImage":
                    ProgramSettings.BackgroundImage = Convert.ToBoolean(ItemArray[1]);
                    break;
                case "MemoDefaultFont":
                    Font font = new Font(ItemArray[1].ToString(),(float)Convert.ToDouble(ItemArray[2]),(Convert.ToBoolean(ItemArray[3]) ? FontStyle.Bold : FontStyle.Regular) | (Convert.ToBoolean(ItemArray[4]) ? FontStyle.Italic : FontStyle.Regular) | (Convert.ToBoolean(ItemArray[5]) ? FontStyle.Strikeout : FontStyle.Regular) | (Convert.ToBoolean(ItemArray[6]) ? FontStyle.Underline : FontStyle.Regular));
                    ProgramSettings.MemoDefaultFont = font;
                    break;
                case "MemoDefaultFontColor":
                    ProgramSettings.MemoDefaultFontColor = Color.FromArgb(Convert.ToInt32(ItemArray[1]),Convert.ToInt32(ItemArray[2]), Convert.ToInt32(ItemArray[3]), Convert.ToInt32(ItemArray[4]));
                    break;
                case "MemoDefaultBackColor":
                    ProgramSettings.MemoDefaultBackColor = Color.FromArgb(Convert.ToInt32(ItemArray[1]), Convert.ToInt32(ItemArray[2]), Convert.ToInt32(ItemArray[3]), Convert.ToInt32(ItemArray[4]));
                    break;
                default:
                    ShortCutKey k = ProgramSettings.GetSKey(Name);
                    if (k != null)
                    {
                        k.Ctrl = Convert.ToBoolean(ItemArray[1]);
                        k.Alt = Convert.ToBoolean(ItemArray[2]);
                        k.Shift = Convert.ToBoolean(ItemArray[3]);
                        foreach (Keys at in Program.LibSettingForm.Key)
                        {
                            if (at.ToString() == ItemArray[4].ToString())
                            {
                                k.Key = at;
                                break;
                            }
                        }
                    }
                    break;
            }
        }
        public static void SaveSettings()
        {
            XMLDataSet = new DataSet();
            XMLDataSet.Tables.Add("HotKeySettings");
            DataTable t = XMLDataSet.Tables["HotKeySettings"];
            WriteColumn(t,"Name",typeof(string));
            WriteColumn(t, "Ctrl", typeof(bool));
            WriteColumn(t,"Alt", typeof(bool));
            WriteColumn(t,"Shift", typeof(bool));
            WriteColumn(t,"Key", typeof(Keys));
            foreach (ShortCutKey k in ProgramSettings.HotKeys)
            {
                WriteData(t, k.EKey,k.Ctrl, k.Alt, k.Shift, k.Key);
            }
            WriteTable("Settings");
            t = XMLDataSet.Tables["Settings"];
            WriteColumn(t,"Name",typeof(string));
            WriteColumn(t, "Checked", typeof(bool));
            WriteData(t,"Memo", ProgramSettings.Memo);
            WriteData(t, "BackgroundImage", ProgramSettings.BackgroundImage);
            WriteData(t,"MemoBottomView", ProgramSettings.MemoBottomView);
            WriteData(t, "MemoTopView", ProgramSettings.MemoTopView);
            WriteData(t, "MemoMiddleView", ProgramSettings.MemoMiddleView);
            WriteData(t, "MemoView", ProgramSettings.MemoView);
            WriteTable("FontSettings");
            t = XMLDataSet.Tables["FontSettings"];
            WriteColumn(t, "Name", typeof(string));
            WriteColumn(t, "FontName", typeof(string));
            WriteColumn(t, "FontSize", typeof(float));
            WriteColumn(t, "Bold", typeof(bool));
            WriteColumn(t, "Italic", typeof(bool));
            WriteColumn(t, "Strikeout", typeof(bool));
            WriteColumn(t, "Underline", typeof(bool));
            WriteData(t, "MemoDefaultFont", ProgramSettings.MemoDefaultFont.Name, ProgramSettings.MemoDefaultFont.Size, ProgramSettings.MemoDefaultFont.Bold, ProgramSettings.MemoDefaultFont.Italic, ProgramSettings.MemoDefaultFont.Strikeout, ProgramSettings.MemoDefaultFont.Underline);
            WriteTable("ColorSettings");
            t = XMLDataSet.Tables["ColorSettings"];
            WriteColumn(t, "Name", typeof(string));
            WriteColumn(t, "Alpha", typeof(byte));
            WriteColumn(t, "Red", typeof(byte));
            WriteColumn(t, "Green", typeof(byte));
            WriteColumn(t, "Blue", typeof(byte));
            WriteData(t, "MemoDefaultFontColor", ProgramSettings.MemoDefaultFontColor.A,ProgramSettings.MemoDefaultFontColor.R, ProgramSettings.MemoDefaultFontColor.G, ProgramSettings.MemoDefaultFontColor.B);
            WriteData(t, "MemoDefaultBackColor", ProgramSettings.MemoDefaultBackColor.A,ProgramSettings.MemoDefaultBackColor.R, ProgramSettings.MemoDefaultBackColor.G, ProgramSettings.MemoDefaultBackColor.B);
            SaveXML(Application.StartupPath + @"\Settings.xml");
        }
        /*
         Table Setting
         * Column Ctrl Alt Shift Key
         * 
         * 
         * /Table
         
         */
        public static void WriteTable(string Table)
        {
            XMLDataSet.Tables.Add(new DataTable(Table));
        }
        public static void WriteColumn(DataTable table, string Column,Type type)
        {
            DataColumn DColumn = new DataColumn(Column,type);
            table.Columns.Add(DColumn);
        }
        public static void WriteData(DataTable table,params object[] Data)
        {
            table.Rows.Add(Data);
        }
        public static void SaveXML(string FileName)
        {
            XMLDataSet.WriteXml(FileName);
        }
    }

    public static class ProgramSettings
    {
        //Varb
        private static Color RealDeafultBackColor, RealDefaultFontColor;
        //Option
        public static bool BackgroundImage
        {
            get
            {
                return Program.LibSettingForm.chkBackGroundImageView.Checked;
            }
            set
            {
                Program.LibSettingForm.chkBackGroundImageView.Checked = value;
            }
        }
        public static bool MemoBottomView
        {
            get
            {
                return Program.LibSettingForm.chkMemoBottomView.Checked;
            }
            set
            {
                Program.LibSettingForm.chkMemoBottomView.Checked = value;
            }
        }
        public static bool MemoMiddleView
        {
            get
            {
                return Program.LibSettingForm.chkMemoMiddleView.Checked;
            }
            set
            {
                Program.LibSettingForm.chkMemoMiddleView.Checked = value;
            }
        }
        public static bool MemoTopView
        {
            get
            {
                return Program.LibSettingForm.chkMemoTopView.Checked;
            }
            set
            {
                Program.LibSettingForm.chkMemoTopView.Checked = value;
            }
        }
        public static bool Memo
        {
            get
            {
                return Program.LibSettingForm.chkMemo.Checked;
            }
            set
            {
                Program.LibSettingForm.chkMemo.Checked = value;
            }
        }
        public static Color MemoDefaultBackColor
        {
            get
            {
                return RealDeafultBackColor;
            }
            set
            {
                RealDeafultBackColor = value;
                Program.LibSettingForm.BackColorDialog.Color = value;
                int index = Program.LibSettingForm.ComboMemoBackColor.FindString(value.ToString().Replace("Color [", "").Replace("]", ""));
                if (index >= 0) Program.LibSettingForm.ComboMemoBackColor.SelectedIndex = index;
                else if (value == Color.Empty || value.ToArgb() == 0) Program.LibSettingForm.ComboMemoBackColor.SelectedIndex = 1;
                else
                {
                    int i = 0;
                    foreach (Color at in Program.LibSettingForm.Colors)
                    {
                        if (at.ToArgb() == value.ToArgb()) break;
                        i++;
                    }
                    if (i >= Program.LibSettingForm.Colors.Length)
                    {
                        Program.LibSettingForm.ComboMemoBackColor.SelectedIndex = 0;
                    }
                    else
                    {
                        MemoDefaultBackColor = Program.LibSettingForm.Colors[i];
                    }
                }
            }
        }
        public static Color MemoDefaultFontColor
        {
            get
            {
                return RealDefaultFontColor;
            }
            set
            {
                RealDefaultFontColor = value;
                Program.LibSettingForm.FontColorDialog.Color = value;
                int index = Program.LibSettingForm.ComboMemoFontColor.FindString(value.ToString().Replace("Color [", "").Replace("]", ""));
                if (index >= 0) Program.LibSettingForm.ComboMemoFontColor.SelectedIndex = index;
                else if (value == Color.Empty || value.ToArgb() == 0) Program.LibSettingForm.ComboMemoFontColor.SelectedIndex = 1;
                else
                {
                    int i = 0;
                    foreach (Color at in Program.LibSettingForm.Colors)
                    {
                        if (at.ToArgb() == value.ToArgb()) break;
                        i++;
                    }
                    if (i >= Program.LibSettingForm.Colors.Length)
                    {
                        Program.LibSettingForm.ComboMemoFontColor.SelectedIndex = 0;
                    }
                    else
                    {
                        MemoDefaultFontColor = Program.LibSettingForm.Colors[i];
                    }
                }
            }
        }
        public static Font MemoDefaultFont
        {
            get
            {
                return Program.LibSettingForm.FontDialog.Font;
            }
            set
            {
                Program.LibSettingForm.FontDialog.Font = value;
                if (value == null)
                {
                    Program.LibSettingForm.ComboMemoFont.SelectedIndex = 0;
                }
                else
                {
                    int index = Program.LibSettingForm.ComboMemoFont.FindString(value.Name);
                    if (index >= 0) Program.LibSettingForm.ComboMemoFont.SelectedIndex = index;
                }
            }
        }
        public static bool MemoView
        {
            get
            {
                return Program.LibSettingForm.chkMemoView.Checked;
            }
            set
            {
                Program.LibSettingForm.chkMemoView.Checked = value;
            }
        }
        /*
         * 
        빠르게 가기
        색 설정(에디터)
        굵기 설정(에디터)
         */
        public static ShortCutKey[] HotKeys =
        {
            new ShortCutKey("NextPage",false,false,false,Keys.Right),
            new ShortCutKey("PrevPage",false,false,false,Keys.Left),
            new ShortCutKey("FullMode",true,true,false,Keys.F),
            new ShortCutKey("Find",true,false,false,Keys.F),
            new ShortCutKey("BookSetting",true,true,false,Keys.S),
            new ShortCutKey("TextMode",true,false,false,Keys.T),
            new ShortCutKey("ImageMode",true,false,false,Keys.I),
            new ShortCutKey("EllipseMode",true,false,false,Keys.E),
            new ShortCutKey("FillEllipseMode",true,false,true,Keys.E),
            new ShortCutKey("RectangleMode",true,false,false,Keys.R),
            new ShortCutKey("FillRectangleMode",true,false,true,Keys.R),
            new ShortCutKey("LineMode",true,false,false,Keys.L),
            new ShortCutKey("MemoMode",true,false,false,Keys.M),
            new ShortCutKey("EraserMode",false,false,true,Keys.E),
            new ShortCutKey("MouseMode",false,false,true,Keys.M),
            new ShortCutKey("Haste",true,false,false,Keys.H),
            new ShortCutKey("ColorSetting",true,true,false,Keys.C),
            new ShortCutKey("BoldSetting",true,true,false,Keys.B),
        };
        public static void Init()
        {
            BackgroundImage = Memo = true;
            MemoBottomView = MemoMiddleView = MemoTopView = MemoView = false;
            MemoDefaultFont = new Font("굴림", 9);
            MemoDefaultBackColor = Color.Empty;
            MemoDefaultFontColor = Color.Empty;
        }
        public static ShortCutKey GetSKey(string DKEY)
        {
            foreach (ShortCutKey k in HotKeys)
            {
                if (k.EKey == DKEY)
                    return k;
            }
            return null;
        }
        public static void SetSKey(string DKEY, ShortCutKey KEY)
        {
            int i = 0;
            for (i = 0; i < HotKeys.Length; i++)
            {
                if (HotKeys[i].EKey == DKEY)
                {
                    HotKeys[i] = KEY;
                }
            }
        }
    }
    public class ShortCutKey
    {
        public bool Ctrl, Alt, Shift, None;
        public Keys Key;
        public string EKey;
        public ShortCutKey(string KEY, bool ctrl, bool alt, bool shift, Keys key)
        {
            Ctrl = ctrl;
            Alt = alt;
            Shift = shift;
            Key = key;
            EKey = KEY;
            None = false;
        }
        public bool CheckKeyEvent(KeyEventArgs e)
        {
            if (!None && e.Control == Ctrl && e.Alt == Alt && e.Shift == Shift && e.KeyCode == Key) return true;
            else return false;
        }
        public string ToString()
        {
            string result = "";
            if (None) return result;
            if (Ctrl)
                result += "Ctrl+";
            if (Alt)
                result += "Alt+";
            if (Shift)
                result += "Shift+";
            result += Key.ToString();

            return result;
        }
    }
}
