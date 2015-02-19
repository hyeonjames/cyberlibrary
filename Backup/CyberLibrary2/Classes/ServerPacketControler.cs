using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Net;
namespace CyberLibrary2.Classes
{
    public enum ClientPacketType : ushort
    {
        Client_Letter = 0,
        Client_Login = 1,
        Client_Logout = 2,
        Client_Chat = 3,
        Client_ShowBook = 4,
        Client_BookWrite = 5,
        Client_ShowGroup = 6,
        Client_Join = 7,
        Client_GetGuide = 8,
        Client_BookWriteCheck = 9,
        Client_WriteComment = 10,
        Client_DelComment = 11,
        Client_DelBook = 12,
        Client_ModifyBookCheck = 13,
        Client_ModifyBook = 14,
        Client_FindBook = 15,
        Client_FindPassword = 16,
    }

    public delegate void ServerControlerFunction(ReceiveControler rcv,object[] Data);
    public static class ServerPacketControler
    {
        public static ServerControlerFunction[] Events =
        {
            Letter,
            Login,
            Logout,
            Chat,
            ShowBook,
            BookWrite,
            ShowGroup,
            Join,
            GetGuide,
            BookWriteCheck,
            WriteComment,
            DelComment,
            DelBook,
            ModifyBookCheck,
            ModifyBook,
            FindBook,
        };
        
        private static string FindContext;
        private static void FindBook(ReceiveControler rcv, object[] Data)
        {
            int i = 0,j=0;
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("sssbbb", Data)) return;
            if ((bool)Data[3] == (bool)Data[4] == (bool)Data[5] == false) return;
            NetworkBookGroup bGroup = rcv.nControler.GetGroup(rcv.nControler.GetBoard(Data[0].ToString()), Data[1].ToString());
            if (bGroup != null)
            {
                FindContext = Data[2].ToString();
                List<Book> ableBooks = new List<Book>();
                List<Book> books = new List<Book>();;
                for (i = 0; i < bGroup.BookKeys.Count; i++)
                {
                    books.Add(rcv.nControler[bGroup,i]);
                }
                if ((bool)Data[3])
                {
                    i = 0;
                    while (i >= 0 && i < books.Count)
                    {
                        j = i;
                        i = books.FindIndex(i, FindBookName);
                        if (i >= 0)
                        {
                            ableBooks.Add(books[i]);
                            books.RemoveAt(i);
                        }
                        else break;
                    }
                }
                if ((bool)Data[4])
                {
                    i = 0;
                    while (i >= 0 && i < books.Count)
                    {
                        j = i;
                        i = books.FindIndex(i, FindWriterName);
                        if (i >= 0)
                        {
                            ableBooks.Add(books[i]);
                            books.RemoveAt(i);
                        }
                        else break;
                    }
                }
                if ((bool)Data[5])
                {
                    i = 0;
                    while (i >= 0 && i < books.Count)
                    {
                        j = i;
                        i = books.FindIndex(i, FindTransferName);
                        if (i >= 0)
                        {
                            ableBooks.Add(books[i]);
                            books.RemoveAt(i);
                        }
                        else break;
                    }
                }
                string[] BookNames, BookWriteTime, BookKeys;
                BookNames = new string[ableBooks.Count];
                BookWriteTime = new string[ableBooks.Count];
                BookKeys = new string[ableBooks.Count];
                foreach(Book k in ableBooks)
                {
                    BookNames[i] = k.BookName;
                    BookWriteTime[i] = k.WriteTime.ToShortDateString();
                    BookKeys[i] = k.NetworkKey.ToString();
                }
                rcv.Write(ServerPacketType.Server_Found, BookKeys, BookNames, BookWriteTime);
            }
        }
        private static bool FindTransferName(Book k)
        {
            if (k.TransferName.IndexOf(FindContext) >= 0) return true;
            else return false;
        }
        private static bool FindWriterName(Book k)
        {
            if (k.WriterName.IndexOf(FindContext) >= 0) return true;
            else return false;
        }
        private static bool FindBookName(Book k)
        {
            if (k.BookName.IndexOf(FindContext) >= 0) return true;
            else return false;
        }
        private static DateTime FindCommentTime;
        private static void ModifyBookCheck(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("l", Data)) return;
            Book b = rcv.nControler.GetBook((long)Data[0]);
            if (b.NetworkParent.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                return;
            }
            if (b.TransferName == rcv.myUser.ID || rcv.myUser.nGrade.DelModify)
            {
                rcv.Write(ServerPacketType.Server_ModifyBookAgree);
            }
            else
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "권한이 없습니다.");
            }
        }
        private static void ModifyBook(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("lk", Data)) return;
            int bindex = rcv.nControler.GetBookIndex((long)Data[0]);
            if (bindex < 0) return;
            if (rcv.nControler.info.books[bindex] == null || rcv.nControler.info.books[bindex].NetworkKey != ((Book)Data[1]).NetworkKey) return;
            if (rcv.nControler.info.books[bindex].NetworkParent.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                return;
            }
            if (rcv.nControler.info.books[bindex].TransferName == rcv.myUser.ID || rcv.myUser.nGrade.DelModify)
            {
                Book bkData = (Book)Data[1];
                bkData.WriterName = rcv.myUser.ID;
                bkData.WriteTime = DateTime.Now;
                rcv.nControler.info.books[bindex] = bkData;
                rcv.Write(ServerPacketType.Server_ShowBook, rcv.nControler.info.books[bindex]);
            }
            else
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "권한이 없습니다.");
            }
        }
        private static void DelBook(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("l", Data)) return;
            Book b = rcv.nControler.GetBook((long)Data[0]);
            if (b == null) return;
            if (b.NetworkParent.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                return;
            }
            if (b.TransferName == rcv.myUser.ID || rcv.myUser.nGrade.DelModify)
            {
                rcv.nControler.AddLog(LogType.InfoMessage, string.Format("글 삭제 - {0:S} -> {1:S} -> {2:S} : {3:S}",b.NetworkParent.Parent.Name,b.NetworkParent.Name,b.BookName,rcv.myUser.ID));
                b.NetworkParent.BookKeys.Remove(b.NetworkKey);
                b.NetworkParent = null;
                b.NetworkKey = 0;
                rcv.nControler.info.books.Remove(b);
            }
            else
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "권한이 없습니다.");
            }
        }
        private static void DelComment(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("lt", Data)) return;
            Book b = rcv.nControler.GetBook((long)Data[0]);
            if (b == null) return;
            if (b.NetworkParent.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                return;
            }
            FindCommentTime = (DateTime)Data[1];
            Comment cmt = b.Comments.Datas.Find(new Predicate<Comment>(CheckCommentDate));
            if (cmt == null) return;
            if (rcv.myUser.nGrade.DelModify || rcv.myUser.ID == cmt.name)
            {
                b.Comments.Datas.Remove(cmt);
                rcv.Write(ServerPacketType.Server_RefreshComment,b.Comments);
            }
            else
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "삭제할 권한이 없습니다.");
            }
        }
        private static bool CheckCommentDate(Comment b)
        {
            if (b.myTime.Ticks == FindCommentTime.Ticks)
                return true;
            else
                return false;
        }
        private static void ShowBook(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("ssi", Data)) return;
            NetworkBookGroup bGroup = rcv.nControler.GetGroup(rcv.nControler.GetBoard(Data[0].ToString()), Data[1].ToString());
            if (bGroup != null)
            {
                if (bGroup.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
                {
                    rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                    return;
                }
                if (bGroup.BookKeys.IndexOf((int)Data[2]) >= 0)
                {
                    if (!rcv.myUser[(int)Data[2]] && rcv.myUser.Point < (uint)(bGroup.ReadDelPoint))
                    {
                        rcv.Write(ServerPacketType.Server_NoticeMessage, "포인트가 부족합니다.");
                        return;
                    }
                    rcv.Write(ServerPacketType.Server_ShowBook, rcv.nControler.GetBook((int)Data[2]), (int)Data[2]);
                    if (!rcv.myUser[(int)Data[2]] && !rcv.myUser.nGrade.Operate)
                    {
                        rcv.myUser[(int)Data[2]] = true;
                        rcv.myUser.Point -= (uint)(bGroup.ReadDelPoint);
                    }
                    rcv.RefreshPoint();
                }
            }
        }
        private static void Logout(ReceiveControler rcv, object[] Data)
        {
            rcv.Dispose();
        }
        private static void Chat(ReceiveControler rcv, object[] Data)
        {
            if (!ReceiveControler.CheckObject("sfcc", Data) || rcv.myUser == null) return;
            string context = Data[0].ToString();
            
            rcv.nControler.OverallMesssage(ReceiveControler.MakePacket(ServerPacketType.Server_ChatMessage, rcv.myUser.ID + " : " + context,Data[1],Data[2],Data[3]), rcv.myUser);
        }
        private static void ShowGroup(ReceiveControler rcv, object[] Data)
        {
            if (!ReceiveControler.CheckObject("ssi", Data) || rcv.myUser == null) return;
            NetworkBookGroup bGroup = rcv.nControler.GetGroup(rcv.nControler.GetBoard(Data[0].ToString()), Data[1].ToString());
            if (bGroup.ReadGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                return;
            }
            if ((int)Data[2] < 0 || (int)Data[2] > bGroup.BookKeys.Count / 10) return;
            if (bGroup != null)
                rcv.SendGroup(bGroup, (int)Math.Max(((int)Data[2]), 0) * 10, 10);
                                
        }
        private static void WriteComment(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("ls", Data)) return;
            if (((DateTime.Now.Ticks - rcv.myUser.LastCommentWrite) / 10000000) < rcv.nControler.serverForm.CommentWriteLimitTime)
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "덧글은 " + rcv.nControler.serverForm.CommentWriteLimitTime.ToString() + "초에 한번씩만 쓰실수 있습니다.");
                return;
            }
            Book bk = rcv.nControler.GetBook((long)Data[0]);
            if (bk == null) return;
            if (bk.NetworkParent != null)
            {
                if (bk.NetworkParent.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
                {
                    rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                    return;
                }
                Comment comts = new Comment();
                comts.context = Data[1].ToString();
                comts.myTime = DateTime.Now;
                comts.name = rcv.myUser.ID;
                bk.Comments.Datas.Add(comts);
                rcv.myUser.LastCommentWrite = DateTime.Now.Ticks;
                rcv.Write(ServerPacketType.Server_RefreshComment, bk.Comments);
            }
        }
        private static void Join(ReceiveControler rcv, object[] Data)
        {
            if (!ReceiveControler.CheckObject("sss", Data) || rcv.myUser != null) return;
            if (rcv.nControler.FindUser(Data[0].ToString()) != null)
            {
                rcv.Write(ServerPacketType.Server_ErrorMessage, "이미 존재하는 아이디입니다.");
            }
            else
            {
                User us = new User();
                us.ID = Data[0].ToString();
                us.PW = Component.MD5Encrypt(Data[1].ToString());
                us.State = UserState.Off;
                us.Point = 0;
                us.nGrade = rcv.nControler.info.Grades[rcv.nControler.GetGrade(us)];
                rcv.nControler.info.users.Add(us);
                rcv.nControler.AddLog(LogType.InfoMessage, "Join User " + us.ID + " [IP:" + ((IPEndPoint)rcv.Socket.Client.RemoteEndPoint).Address.ToString() + "]");
                rcv.Write(ServerPacketType.Server_JoinSuccess);
            }
        }
        private static void GetGuide(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser != null) return;
            rcv.Write(ServerPacketType.Server_SetGuide, rcv.nControler.JoinGuide);
        }
        private static void Letter(ReceiveControler rcv, object[] Data)
        {
            if (!ReceiveControler.CheckObject("s", Data) || rcv.myUser == null) return;
            rcv.nControler.serverForm.UserMessageList.Items.Add(new ListViewItem(new string[] { Data[0].ToString(), rcv.myUser.ID, string.Format("{0:d2}:{1:d2}", DateTime.Now.Hour, DateTime.Now.Minute) }));
        }
        private static void BookWrite(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser == null || !ReceiveControler.CheckObject("sski", Data)) return;
            if (((DateTime.Now.Ticks - rcv.myUser.LastBookWriteTime) / 10000000) < rcv.nControler.serverForm.WriteLimitTime)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "글은 " + rcv.nControler.serverForm.WriteLimitTime.ToString() + "초 에 한번씩만 쓰실수 있습니다.");
                return;
            }
            NetworkBookGroup bGroup = rcv.nControler.GetGroup(rcv.nControler.GetBoard(Data[0].ToString()), Data[1].ToString());
            if (bGroup != null)
            {
                if (bGroup.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
                {
                    rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
                    return;
                }
                rcv.myUser.LastBookWriteTime = DateTime.Now.Ticks;
                Book bkData = (Book)Data[2];
                bkData.WriteTime = DateTime.Now;
                bkData.TransferName = rcv.myUser.ID;

                rcv.nControler.AddLog(LogType.ReceiveMessage, Data[0].ToString() + "->" + Data[1].ToString() + " 게시판 쓰기 [ " + bkData.BookName + " ] 쓴사람 [ " + rcv.myUser.ID + " ]");
                bkData.NetworkKey = rcv.nControler.info.LastKey++;
                bkData.NetworkParent = bGroup;
                rcv.nControler.info.books.Add(bkData);
                bGroup.BookKeys.Insert(0,rcv.nControler.info.LastKey - 1);
                rcv.myUser.AlreadyReadKey.Add(rcv.nControler.info.LastKey - 1);
                rcv.myUser.Point += (uint)bGroup.WriteAddPoint;
                rcv.RefreshPoint();
                rcv.SendGroup(bGroup, ((int)Data[3]) * 10, 10);
            }
        }
        private static void BookWriteCheck(ReceiveControler rcv, object[] Data)
        {
            if (((DateTime.Now.Ticks - rcv.myUser.LastBookWriteTime) / 10000000) < rcv.nControler.serverForm.WriteLimitTime)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "글은 " + rcv.nControler.serverForm.WriteLimitTime.ToString() + "초 에 한번씩만 쓰실수 있습니다.");
                return;
            }
            if (rcv.myUser == null) return;
            if (!ReceiveControler.CheckObject("ss", Data)) return;
            NetworkBookGroup bGroup = rcv.nControler.GetGroup(rcv.nControler.GetBoard(Data[0].ToString()), Data[1].ToString());
            if (bGroup == null) return;
            if (bGroup.WriteGrade.MinLimitPoint > rcv.myUser.nGrade.MinLimitPoint)
            {
                rcv.Write(ServerPacketType.Server_NoticeMessage, "등급이 부족합니다.");
            }
            else
            {
                rcv.Write(ServerPacketType.Server_BookWriteAgree, Data);
            }
        }
        private static void Login(ReceiveControler rcv, object[] Data)
        {
            if (rcv.myUser != null) return;
            if (ReceiveControler.CheckObject("ss", Data))
            {
                User us = rcv.nControler.FindUser(Data[0].ToString());
                if (us == null)
                {
                    rcv.Write(ServerPacketType.Server_ErrorMessage, "아이디가 알맞지 않습니다..");

                }
                else if (Component.MD5Encrypt(us.PW) == Data[1].ToString())
                {
                    //Login Success
                    rcv.myUser = us;
                    if (rcv.myUser.State == UserState.Lock)
                    {
                        rcv.Write(ServerPacketType.Server_ErrorMessage, "이 아이디는 관리자에 의해 정지되었습니다.");
                        return;
                    }
                    rcv.nControler.Login(rcv);
                    
                    rcv.myUser = us;
                    us.Stream = rcv;
                    rcv.Write(ServerPacketType.Server_LoginSuccess);
                    rcv.Write(ServerPacketType.Server_InitGrade, rcv.nControler.info.Grades.ToArray());
                    rcv.Write(ServerPacketType.Server_InfoSet, us.ID, us.Point, rcv.nControler.GetGrade(rcv.myUser),rcv.nControler.ServerName);
                    rcv.SendUsers();
                    rcv.SendBoards();
                    rcv.Write(ServerPacketType.Server_NoticeSet, rcv.nControler.Notice);
                }
                else
                {
                    rcv.Write(ServerPacketType.Server_ErrorMessage, "비밀번호가 알맞지 않습니다.");
                }
            }

        }
    }
}
