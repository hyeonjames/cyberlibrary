using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace CyberLibrary2.Classes
{
    public enum ServerPacketType : ushort
    {
        Server_BookWriteAgree = 0,
        Server_JoinSuccess = 1,
        Server_LeaveUser = 2,
        Server_SetUserNames = 3,
        Server_SetUserGrades = 4,
        Server_InfoSet = 5,
        Server_BoardAdd = 6,
        Server_NoticeMessage = 7,
        Server_NoticeSet = 8,
        Server_LoginSuccess = 9,
        Server_ErrorMessage = 10,
        Server_ChatMessage = 11,
        Server_ShowBook = 12,
        Server_ShowGroup = 13,
        Server_ComeUser = 14,
        Server_InitGrade = 15,
        Server_SetGuide = 16,
        Server_RefreshComment = 17,
        Server_ModifyBookAgree = 18,
        Server_ShutDown = 19,
        Server_Found = 20,
    }
    public delegate void ClientControlFunction(ClientControler cli,object[] Data);
    public static class ClientPacketControler
    {
        public static ClientControlFunction[] Events =
        {
            BookWriteAgree,
            JoinSuccess,
            LeaveUser,
            UserNames,
            UserGrades,
            InfoSet,
            BoardAdd,
            NoticeMessage,
            NoticeSet,
            LoginSuccess,
            ErrorMessage,
            ChatMessage,
            ShowBook,
            ShowGroup,
            ComeUser,
            InitGrade,
            SetGuide,
            RefreshComment,
            ModifyAgree,
            Shutdown,
            Found,
        };

        private static void Found(ClientControler cli, object[] Data)
        {
            Program.libForm.FindMode = true;
            Program.libForm.FindBookNames = (string[])Data[1];
            Program.libForm.FindBookTimes = (string[])Data[2];
            Program.libForm.FindBookNumbers = (string[])Data[0];
            Program.libForm.PageSet(0);
        }
        private static void Shutdown(ClientControler cli,object[] Data)
        {
            MessageBox.Show("서버가 종료되었습니다.", "Infor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Program.libForm.Visible) Program.libForm.Close();
            if (Program.joinForm.Visible) Program.joinForm.Close();
            if (Program.LoginForm.Visible) Program.LoginForm.Close();
            cli.Dispose();
            return;
        }
        public static void ModifyAgree(ClientControler cli, object[] Data)
        {
            Program.libForm.ShowPanel(Program.libForm.PanelWrite);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm, OptionType.ShowPanel, Program.libForm.PanelWrite);
            Program.libForm.bookEdit.LoadBook(Program.libForm.BookRead.myBook);
            //Program.libForm.Invoke(Component.SetOption,Program.libForm.bookEdit,OptionType.ReadBook,Program.libForm.BookRead.myBook);
            Program.libForm.ModifyBook = true;
        }
        public static void NoticeSet(ClientControler cli, object[] Data)
        {
            //Program.libForm.Invoke(Component.SetText, Program.libForm.labelServerNotice,"** 공지 사항 :" +  Data[0].ToString());
            Program.libForm.labelServerNotice.Text = "** 공지 사항 :" + Data[0].ToString();
        }
        public static void RefreshComment(ClientControler cli, object[] Data)
        {
            Program.libForm.CommentBoard.SetComment((Comments)Data[0]);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.CommentBoard, OptionType.SetComment, ((Comments)Data[0]));
        }
        public static void LoginSuccess(ClientControler cli, object[] Data)
        {
            Program.libForm = new CyberLibrary2.Forms.NetworkLibForm();
            Program.libForm.Show();
            Program.LibraryForm.Hide();
            Program.LoginForm.Close();
            //Program.LibraryForm.Invoke(Component.shForm, Program.libForm, false);
            //Program.LibraryForm.Invoke(Component.dsForm, Program.LibraryForm, false);
            //Program.LoginForm.Invoke(Component.dsForm, Program.LoginForm, true);
        }
        public static void BookWriteAgree(ClientControler cli, object[] Data)
        {
            Program.libForm.bookEdit.ResetBook();
            Program.libForm.ShowPanel(Program.libForm.PanelWrite);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.bookEdit, OptionType.ResetBook,null);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm, OptionType.ShowPanel, Program.libForm.PanelWrite);
        }
        public static void InitGrade(ClientControler cli, object[] Data)
        {
            cli.Grades = (NetworkGrade[])Data;
        }
        public static void BoardAdd(ClientControler cli, object[] Data)
        {
            TreeNode trNode = new TreeNode(Data[0].ToString(), 0, 0);
            foreach (string at in (string[])Data[1])
            {
                trNode.Nodes.Add(new TreeNode(at,1,1));
            }
            Program.libForm.MenuBoard.Nodes.Add(trNode);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.MenuBoard, OptionType.TreeView_NodeAdd, trNode);
        }

        public static void UserGrades(ClientControler cli, object[] Data)
        {
            int i = 0;
            int[] Grades = (int[])Data[0];
            foreach (ListViewItem at in Program.libForm.UserList.Items)
            {
                if (at.Text == Program.Client.myName) continue;
                at.ImageIndex = Grades[i++];
                //Program.libForm.Invoke(Component.SetOption, at, OptionType.ItemImageIndexChange, Grades[i++]);
            }               
        }
        public static void UserNames(ClientControler cli, object[] Data)
        {
            foreach (object at in Data)
                Program.libForm.UserList.Items.Add(at.ToString());
        }
        public static void ComeUser(ClientControler cli, object[] Data)
        {
            Program.libForm.UserCome(Data);
        }
        public static void ShowBook(ClientControler cli, object[] Data)
        {
            Program.libForm.ShowPanel(Program.libForm.PanelShowBook);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm, OptionType.ShowPanel, Program.libForm.PanelShowBook);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.BookRead, OptionType.ReadBook, Data[0]);
            Program.libForm.BookRead.SetBook((Book)Data[0]);
            Program.libForm.BookIndex = (int)Data[1];
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.CommentBoard, OptionType.SetComment, ((Book)Data[0]).Comments);
            Program.libForm.CommentBoard.SetComment(((Book)Data[0]).Comments);
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.btModify.Enabled, OptionType.SetBool, false);
            Program.libForm.btModify.Enabled = Program.libForm.btDelBook.Enabled = false;
            //Program.libForm.Invoke(Component.SetOption, Program.libForm.btDelBook.Enabled, OptionType.SetBool, false);
        }
        public static void ShowGroup(ClientControler cli, object[] Data)
        {
            //Program.libForm.Invoke(Component.SetOption, Program.libForm, OptionType.ShowPanel, Program.libForm.PanelGroup);
            Program.libForm.ShowPanel(Program.libForm.PanelGroup);
            Program.libForm.BookBoard.SetGroup((int)Data[0],Data[2].ToString(),Data[1].ToString(), Data[3].ToString(), (string[])Data[4], (string[])Data[5],(string[])Data[6]);
            Program.libForm.NowGroup = Data[1].ToString();
            Program.libForm.NowBoard = Data[2].ToString();
            Program.libForm.FindMode = false;
            Program.libForm.PageIndex = ((((int)Data[0]) / 10));
        }
        public static void LeaveUser(ClientControler cli, object[] Data)
        {
            Program.libForm.UserList.Items.Remove(Program.libForm.UserList.FindItemWithText(Data[0].ToString()));
            Program.libForm.ChatAdd(Data[0].ToString() + "님이 나가셨습니다.", new Font("굴림", 9), Color.BlueViolet, Color.White);
        
        }
        public static void JoinSuccess(ClientControler cli, object[] Data)
        {
            MessageBox.Show("회원가입에 성공하였습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.joinForm.Close();
        }
        public static void InfoSet(ClientControler cli, object[] Data)
        {
            cli.myGrade = cli.Grades[(int)Data[2]];
            cli.myName = Data[0].ToString();
            cli.myPoint = (uint)Data[1];
            Program.libForm.Text = "[" + Data[3].ToString() + "] Library";
        }
        public static void SetGuide(ClientControler cli, object[] Data)
        {
            //Program.joinForm.Invoke(Component.SetText, Program.joinForm.txtGuide, Data[0].ToString());
            Program.joinForm.txtGuide.Text = Data[0].ToString();              
        }  
        public static void ErrorMessage(ClientControler cli, object[] Data)
        {
            MessageBox.Show(Data[0].ToString(), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
        }
        public static void NoticeMessage(ClientControler cli, object[] Data)
        {
            //Program.libForm.Invoke(Component.SetOption, Program.libForm, OptionType.ShowPanel, Program.libForm.PanelNotice);
            //Program.libForm.Invoke(Component.SetText, Program.libForm.labelNotice, Data[0].ToString());
            Program.libForm.ShowPanel(Program.libForm.PanelNotice);
            Program.libForm.labelNotice.Text = Data[0].ToString(); 
        }
        public static void ChatMessage(ClientControler cli, object[] Data)
        {
            //Program.libForm.Invoke(Component.SetOption,Program.libForm,OptionType.ChatAdd,Data);
            Program.libForm.ChatAdd(Data);    
        }
        
    }
}
