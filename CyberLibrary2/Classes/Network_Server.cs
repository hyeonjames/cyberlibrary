using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Windows.Forms;
namespace CyberLibrary2.Classes
{
    public delegate void RecvFunction();
    public enum LogType
    {
        ReceiveMessage,
        SendMessage,
        InfoMessage,
        ErrorMessage
    }
    
    public enum UserState
    {
        Off,
        On,
        Error,
        Lock,
    }
    [Serializable]
    public class NetworkGrade
    {
        [NonSerialized]
        public static NetworkGrade Empty;
        public string Name,Explain;
        public int MinLimitPoint;
        public bool Read, Write,DelModify, Operate;
        public Image icon;
    }
    [Serializable]
    public class NetworkBookGroup
    {
        public NetworkBookBoard Parent;
        public string Name, Description;
        public int WriteAddPoint, ReadDelPoint;
        public NetworkGrade WriteGrade, ReadGrade;
        public List<long> BookKeys;
    }
    [Serializable]
    public class NetworkBookBoard
    {
        public List<NetworkBookGroup> groups;
        public string Name;
    }
    [Serializable]
    public class User
    {
        public long LastBookWriteTime,LastCommentWrite;
        public string ID,PW;
        private uint realPoint;
        public List<long> AlreadyReadKey;
        public User()
        {
            AlreadyReadKey = new List<long>();
        }
        public bool this[long Key]
        {
            get
            {
                if (AlreadyReadKey.IndexOf(Key) >= 0)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value && !this[Key])
                {
                    AlreadyReadKey.Add(Key);
                }
                else if(!value)
                {
                    AlreadyReadKey.Remove(Key);
                }
            }
        }
        public uint Point
        {
            get
            {
                return realPoint;
            }
            set
            {
                if (nGrade != null && nGrade.Operate)
                {
                    if (value <= 2100000000) realPoint = value;
                    else if (value < 0) realPoint = 0;
                    else realPoint = 2100000000;
                }
                else
                {
                    if (value < 1000000000) realPoint = value;
                    else if (value < 0) realPoint = 0;
                    else realPoint = 999999999;
                }
            }
        }
        [NonSerialized]
        public NetworkGrade nGrade;
        [NonSerialized]
        public UserState State;
        public bool Login;
        [NonSerialized]
        public ReceiveControler Stream;
    }
    [Serializable]
    public class ServerPacket
    {
        public ServerPacketType type;
        public object[] Data;
    }
    
    public class ReceiveControler
    {
        public User myUser;
        public ClientPacket LastRecvPacket;
        public long LastRecvTime;
        public TcpClient Socket;
        public bool Disposed=false;
        public NetworkStream nStream;
        public NetworkControler nControler;
        public Thread RecvThread;
        BinaryFormatter bf;
        
        public ReceiveControler(NetworkControler control,TcpClient client)
        {
            Socket = client;
            nControler = control;
            nStream = client.GetStream();
            bf = new BinaryFormatter();
            RecvThread = new Thread(Recv);
            RecvThread.Start();
        }
        public void Dispose()
        {

            nControler.Logout(this);
            nControler.Controlers.Remove(this); 
            nStream.Close();
            Socket.Close();
            Disposed = true;
        }
        public void SendGroup(NetworkBookGroup bGroup,int Start,int Count)
        {
            int i = 0;
            if (bGroup.BookKeys.Count > Start || Start == 0)
            {
                Book b;
                string[] Numbers = new string[Count];
                string[] Groups = new string[Count];
                string[] WriteTime = new string[Count];
                for (i = Start; i < Start + Count; i++)
                {
                    b = nControler[bGroup,i];
                    if (bGroup.BookKeys.Count > i)
                    {
                        Numbers[i - Start] = b.NetworkKey.ToString();
                        Groups[i - Start] = b.BookName;
                        WriteTime[i - Start] = b.WriteTime.ToShortDateString();
                    }
                }
                Write(ServerPacketType.Server_ShowGroup,Start,bGroup.Name,bGroup.Parent.Name,bGroup.Description,Groups,WriteTime,Numbers);
            }
        }
        public static bool CheckObject(string Format, params object[] args)
        {
            int i=0;
            Type type;
            if (args.Length != Format.Length) return false;
            foreach (object o in args)
            {
                switch (Format[i])
                {
                    case 'i': type = typeof(int);break;
                    case 'l': type = typeof(long); break;
                    case 'a': type = typeof(Array); break;
                    case 't': type = typeof(DateTime); break;
                    case 'm': type = typeof(Image); break;
                    case 's': type = typeof(string);break;
                    case 'k': type = typeof(Book);break;
                    case 'b': type = typeof(bool); break;
                    case 'o': type = typeof(Information);break;
                    case 'c': type = typeof(Color); break;
                    case 'e': type = typeof(Comment); break;
                    case 'f': type = typeof(Font); break;
                    case 'u': type = typeof(uint); break;
                    case 'g': type = typeof(NetworkGrade); break;
                    default:
                        return false;
                }
                if (o.GetType() != type)
                    return false;
                i++;

            }
            return true;
        }
        public void RefreshPoint()
        {
            myUser.nGrade = nControler.info.Grades[nControler.GetGrade(myUser)];
            Write(ServerPacketType.Server_InfoSet, myUser.ID, myUser.Point, nControler.GetGrade(myUser));
        }
        public static ServerPacket MakePacket(ServerPacketType p, params object[] args)
        {
            ServerPacket pack = new ServerPacket();
            pack.type = p;
            pack.Data = args;
            return pack;
        }
        public void SendUsers()
        {
            List<string> UserNames = new List<string>();
            List<int> GradeLevels = new List<int>();
            foreach (ReceiveControler con in nControler.Controlers)
            {
                if (con.myUser == null || con.myUser == myUser) continue;
                GradeLevels.Add(nControler.GetGrade(con.myUser));
                UserNames.Add(con.myUser.ID);
            }
            Write(ServerPacketType.Server_SetUserNames, UserNames.ToArray());
            Write(ServerPacketType.Server_SetUserGrades, GradeLevels.ToArray());
        }
        public void SendBoards()
        {
            string[] groups;
            int i=0;
            foreach(NetworkBookBoard bBoard in nControler.info.Boards)
            {
                groups = new string[bBoard.groups.Count];
                foreach(NetworkBookGroup bGroup in bBoard.groups)
                {
                    groups[i++] = bGroup.Name;
                }
                Write(ServerPacketType.Server_BoardAdd,bBoard.Name,groups);

            }
        }
       
        public void Recv()
        {
            ClientPacket mPacket;
            while (true)
            {
                try
                {
                    if (nStream.DataAvailable)
                    {
                        long SendTime = DateTime.Now.Ticks;
                        if (LastRecvTime > 0 && (LastRecvTime - SendTime) > 8000000.00) // 도배 가능성 체크
                        {
                            nControler.AddLog(LogType.SendMessage, string.Format("{1:S} 도배 위험. ({0:2f} 초) ", ((LastRecvTime - SendTime) / 10000000.00), myUser.ID));
                        }
                        mPacket = (ClientPacket)bf.Deserialize(nStream);

                        LastRecvPacket = mPacket;
                        LastRecvTime = SendTime;
                        
                        ServerPacketControler.Events[(int)mPacket.type](this, mPacket.Data);
                        Thread.Sleep(nControler.serverForm.ThreadSleepTime);
                    }
                    else
                    {

                        if (!Socket.Client.Connected)
                        {
                            this.Dispose();
                            return;
                        }
                    }
                }
                catch (Exception e)
                {
                    if (!Socket.Client.Connected)
                    {
                        this.Dispose();
                        return;
                    }
                    nControler.AddLog(LogType.ErrorMessage, e.ToString());
                }
            }
        }
        public int GetKey()
        {
            return nControler.Controlers.IndexOf(this);
        }
        
        public void Write(ServerPacketType ptype,params object[] args)
        {
            if (!nStream.CanWrite || !Socket.Connected)
                return;
            try
            {
                ServerPacket pack = new ServerPacket();
                pack.Data = args;
                pack.type = ptype;
                bf.Serialize(nStream, pack);
            }
            catch (Exception)
            {

            }
        }
    }
    [Serializable]
    public class Information
    {
        public List<User> users;
        public List<NetworkBookBoard> Boards;
        public List<NetworkGrade> Grades;
        public List<string> Bans;
        public List<Book> books;
        public string Name="", JoinGuide="";
        public long LastKey = 0;
        public int WriteLimitTime, CommentWriteLimitTime, ThreadSleep;
    }

    public class NetworkControler
    {
        public Information info;
        public TcpListener Server;
        public GFunc AddLogF;
        private string rNotice;
        public string Notice
        {
            get
            {
                return rNotice;
            }
            set
            {
                rNotice = value;
                OverallMesssage(ReceiveControler.MakePacket(ServerPacketType.Server_NoticeSet, value));

            }
        }
        public string ServerName
        {
            get
            {
                return serverForm.txtServerName.Text;
            }
            set
            {
                info.Name = value;
                serverForm.txtServerName.Text = value;
            }
        }
        public Forms.NetworkServerForm serverForm;
        public List<ReceiveControler> Controlers;
        public Thread AcceptThread;
        public int MaxUserSize
        {
            get
            {
                return (int)serverForm.MaxConnectSize.Value;
            }
        }
        public string JoinGuide
        {
            get
            {
                info.JoinGuide=serverForm.txtJoinGuide.Text;
                return serverForm.txtJoinGuide.Text;
            }
        }
        public NetworkControler()
        {
            Controlers = new List<ReceiveControler>();
            info = new Information();
            info.Boards = new List<NetworkBookBoard>();
            info.Grades = new List<NetworkGrade>();
            info.users = new List<User>();
            info.Bans = new List<string>();
            info.books = new List<Book>();
            AddLogF = new GFunc(WriteLog);
        }
        public void WriteLog(params object[] obj)
        {
            ListViewItem lviewItem = new ListViewItem();
            lviewItem.Text = "";
            switch ((LogType)obj[0])
            {
                case LogType.ErrorMessage:
                    lviewItem.Text += "[Error] ";
                    lviewItem.ImageIndex = 3;
                    break;
                case LogType.ReceiveMessage:
                    lviewItem.Text += "[Receive] ";
                    lviewItem.ImageIndex = 1;
                    break;
                case LogType.SendMessage:
                    lviewItem.Text += "[Send] ";
                    lviewItem.ImageIndex = 0;
                    break;
                case LogType.InfoMessage:
                    lviewItem.Text += "[Info] ";
                    lviewItem.ImageIndex = 2;
                    break;
            }
            lviewItem.Text += obj[1].ToString() + " " + string.Format("[Time {0:d2}:{1:d2}]", DateTime.Now.Hour, DateTime.Now.Minute);
            serverForm.EventList.Items.Add(lviewItem);

        }
        public void GradeRefresh()
        {
            info.Grades.Sort(new Comparison<NetworkGrade>(SortCompare));
        }
        public NetworkGrade GetGrade(string Name)
        {
            foreach (NetworkGrade ng in info.Grades)
            {
                if (ng.Name == Name)
                    return ng;
            }
            return NetworkGrade.Empty;
        }
        public void AddLog(LogType lType, string Context)
        {
            try
            {
                serverForm.Invoke(Component.Generater, AddLogF, new object[] { lType, Context });

            }
            catch (Exception)
            {
            }
        }
        public NetworkGrade GetGrade(int point)
        {
            foreach (NetworkGrade ng in info.Grades)
            {
                if (ng.MinLimitPoint == point)
                    return ng;
            }
            return null;
        }
        public NetworkBookBoard GetBoard(string Name)
        {
            foreach(NetworkBookBoard nbd in info.Boards)
            {
                if (nbd.Name == Name)
                    return nbd;
            }
            return null;
        }
        public void RefreshUsers()
        {
            int index;
            foreach (User us in info.users)
            {
                index = GetGrade(us);
                if (index < 0) continue;
                us.nGrade = info.Grades[index];
            }
        }
        public void Lock(User us)
        {
            if (us.State == UserState.On)
            {
                us.Stream.Dispose(); 
                us.State = UserState.Lock;
                
            }
            us.State = UserState.Lock;
        }
        public void SomeMessage(ServerPacket p, params User[] users)
        {
        }
        public void OverallMesssage(ServerPacket p, params User[] ExceptUsers)
        {
            bool Found = false;
            foreach (ReceiveControler rControler in Controlers)
            {
                Found = false;
                foreach (User us in ExceptUsers)
                {
                    if (us == rControler.myUser)
                    {
                        Found = true;
                        break;
                    }
                }
                if (!Found)
                {
                    rControler.Write(p.type, p.Data);
                }
            }
        }
        public NetworkBookGroup GetGroup(NetworkBookBoard Parent, string Name)
        {
            foreach (NetworkBookGroup nbd in Parent.groups)
            {
                if (nbd.Name == Name)
                    return nbd;
            }
            return null;
        }
        public int GetGrade(User us)
        {
            int index=0;
            foreach (NetworkGrade g in info.Grades)
            {
                if (g.MinLimitPoint <= us.Point)
                    return index;
                index++;
            }
            return index - 1;
        }
        private int SortCompare(NetworkGrade a, NetworkGrade b)
        {
            return a.MinLimitPoint - b.MinLimitPoint;
        }
        public void Login(ReceiveControler m)
        {
            if (m.myUser.State == UserState.On) return;
            
            m.myUser.State = UserState.On;
            if (m.myUser.nGrade == null)
            {
                m.myUser.nGrade = info.Grades[GetGrade(m.myUser)];
            }
            OverallMesssage(ReceiveControler.MakePacket(ServerPacketType.Server_ComeUser,m.myUser.ID,GetGrade(m.myUser)));

            
            AddLog(LogType.InfoMessage,m.myUser.ID + "(" + m.myUser.nGrade.Name + ") log in [IP:" + ((IPEndPoint)m.Socket.Client.RemoteEndPoint).Address.ToString() + "]");
            serverForm.ResetUserCount();
        }
        public void Logout(ReceiveControler m)
        {
            if (m.myUser == null) return;
            if (m.myUser.State == UserState.Off) return;
            m.myUser.State = UserState.Off;
            AddLog(LogType.InfoMessage, m.myUser.ID + "(" + m.myUser.nGrade.Name + ") log out [IP:" + ((IPEndPoint)m.Socket.Client.RemoteEndPoint).Address.ToString() + "]");
            OverallMesssage(ReceiveControler.MakePacket(ServerPacketType.Server_LeaveUser, m.myUser.ID), m.myUser);
            serverForm.ResetUserCount();
        }
        public bool Start(int port)
        {
            Server = new TcpListener(IPAddress.Any,port);
            if (Server == null) return false;
            Server.Start();
            AddLog(LogType.InfoMessage, "Opened Server " + port.ToString());
            
            AcceptThread = new Thread(Accept);
            AcceptThread.Start();
            return true;
        }
        public void CheckThread()
        {
            
        }
        public void Stop()
        {
            if (AcceptThread != null)
            {
                AcceptThread.Abort();
                Server.Stop();
                AddLog(LogType.InfoMessage, "Server Stoped.");
                
            }
            int i=0;
            for (i = 0; i < Controlers.Count;)
            {
                Controlers[i].Dispose();
            }
        }
        private void Accept()
        {
            TcpClient client;
            while (true)
            {
                client = Server.AcceptTcpClient();
                if (Controlers.Count >= MaxUserSize)
                    continue;
                if (client != null && info.Bans.IndexOf(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()) < 0)
                {
                    client.LingerState.Enabled = true;
                    client.LingerState.LingerTime = 4000;
                    ReceiveControler rcControler = new ReceiveControler(this, client);
                    Controlers.Add(rcControler);
                }
            }
        }
        public int GetBookIndex(long key)
        {
            int index=0;
            foreach (Book b in info.books)
            {
                if (b.NetworkKey == key)
                    return index;
                index++;
            }
            return -1;
        }
        public Book GetBook(long key)
        {
            foreach (Book b in info.books)
            {
                if (b.NetworkKey == key)
                    return b;
            }
            return null;
        }
        public User FindUser(string Name)
        {
            foreach (User us in info.users)
            {
                if (us.ID == Name)
                    return us;

            }
            return null;
        }
        public User FindUser(string Name,User except)
        {
            foreach (User us in info.users)
            {
                if (us == except) continue;
                if (us.ID == Name)
                    return us;

            }
            return null;
        }
        public Book this[NetworkBookGroup bGroup, int index]
        {
            get
            {
                if (index >= bGroup.BookKeys.Count) return null;
                return GetBook(bGroup.BookKeys[index]);
            }
        }
        public User this[int Key]
        {
            get
            {
                return info.users[Key];
            }
            set
            {
                info.users[Key] = value;
            }
        }
        
    }
}
