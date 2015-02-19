using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Windows.Forms;
using CyberLibrary2.Forms;
using System.Net.Sockets;
namespace CyberLibrary2.Classes
{
    [Serializable]
    public class ClientPacket
    {
        public ClientPacketType type;
        public object[] Data;
    }
    public class ClientControler
    {
        private string realName;
        public string myName
        {
            get
            {
                return realName;
            }
            set
            {
                if (Program.libForm.UserList.Items.Count == 0)
                {
                    foreach(NetworkGrade nGrade in Grades)
                        if (nGrade == myGrade)
                        {
                            Program.libForm.UserList.Items.Add(nGrade.Name);
                            break;
                        }
                }
                else
                {
                    Program.libForm.UserList.Items[0].Text = value;
                }
                Program.libForm.Invoke(Component.SetText,Program.libForm.labelName, value + " 님 안녕하세요!");
                realName = value;
            }
        }
        private NetworkGrade realGrade;
        public NetworkGrade myGrade
        {
            get
            {
                return realGrade;
            }
            set
            {
                Program.libForm.Invoke(Component.SetText,Program.libForm.labelGrade,"회원님의 현재 등급은 " + value.Name + " 입니다 ( 보유 포인트 : " + myPoint + " )");
                Program.libForm.Invoke(Component.SetOption,Program.libForm.GradeIcon,1,value.icon);
               
                realGrade = value;
            }
        }
        private NetworkGrade[] RealGrade;
        public NetworkGrade[] Grades
        {
            get
            {
                return RealGrade;
            }
            set
            {
                Program.libForm.GradeImageList.Images.Clear();
                foreach (NetworkGrade grade in value)
                {
                    Program.libForm.GradeImageList.Images.Add(grade.icon);
                }
                RealGrade = value;
            }
        }
        private uint realPoint;
        public uint myPoint
        {
            get
            {
                return realPoint;
            }
            set
            {
                Program.libForm.Invoke(Component.SetText,Program.libForm.labelGrade,"회원님의 현재 등급은 " + myGrade.Name + " 입니다 ( 보유 포인트 : " + value + " )");
                realPoint = value;
            }
        }
        public TcpClient Client;
        public NetworkStream nStream;
        public Thread ReadThread;
        public ClientControler()
        {
            Client = new TcpClient();
        }
        private void Recv()
        {
            ServerPacket p;
            while (true)
            {
                try
                {
                        p = (ServerPacket)Component.LoadClass(nStream);
                    if (p == null) continue;
                    
                    if(Program.libForm.Visible) Program.libForm.Invoke(ClientPacketControler.Events[(int)p.type],this,p.Data);
                    else if (Program.LoginForm.Visible) Program.LoginForm.Invoke(ClientPacketControler.Events[(int)p.type], this, p.Data);
                }
                catch (Exception)
                {
                    if (!Client.Client.Connected)
                    {
                        this.Dispose();
                        return;
                    }
                }
            }
        }
        public void Dispose()
        {
            if (nStream != null) this.nStream.Close();
            if (Client != null) this.Client.Close();
            if (ReadThread != null) this.ReadThread.Abort();
        }

        public bool Write(ClientPacketType p, params object[] args)
        {
            ClientPacket pack = new ClientPacket();
            try
            {
                pack.Data = args;
                pack.type = p;
                Component.SaveClass(pack, nStream);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Logout()
        {
            Write(ClientPacketType.Client_Logout);
            this.Dispose();
        }
        ~ClientControler()
        {
            if(ReadThread != null) this.ReadThread.Abort();
            if (nStream != null) this.nStream.Close();
            if (Client != null) this.Client.Close();
        }
        public bool Connect(string IP, int Port)
        {
            try
            {
                Client.Connect(IP, Port);
                if (Client.Connected)
                {
                    nStream = Client.GetStream();
                    ReadThread = new Thread(Recv);
                    ReadThread.Start();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
