using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace CyberLibrary2
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        public static Forms.NetworkLibForm libForm;
        public static Forms.LoginForm LoginForm;
        public static Forms.JoinForm joinForm;
        public static Classes.ClientControler Client;
        public static Classes.NetworkControler Server;
        public static Forms.LibrarySettingForm LibSettingForm;
        public static LibraryForm LibraryForm;
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LibSettingForm = new CyberLibrary2.Forms.LibrarySettingForm();
            LibraryForm = new LibraryForm();
            joinForm = new CyberLibrary2.Forms.JoinForm();
            Component.init();
            Server = new CyberLibrary2.Classes.NetworkControler();
            Client = new CyberLibrary2.Classes.ClientControler();
            libForm = new CyberLibrary2.Forms.NetworkLibForm();
            Classes.SettingData.InitSettings();
            Application.Run(new Forms.CyberLibraryInformation());
            Application.Run(LibraryForm);
            Classes.SettingData.SaveSettings();
        }
    }
}
