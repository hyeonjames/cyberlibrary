using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CyberLibrary2.Classes;
using System.IO;
namespace CyberLibrary2.Forms
{
    public partial class NetworkServerForm : Form
    {
        
        public NetworkServerForm()
        {
            InitializeComponent();
            Program.Server = new NetworkControler();
            NetworkGrade nGrade = new NetworkGrade();
            nGrade.icon = Resource_Files.MyResources.Heart1;
            nGrade.Name = "회원";
            nGrade.Read = nGrade.Write = true;
            nGrade.Operate = nGrade.DelModify = false;
            nGrade.Explain = "일반 회원";
            nGrade.MinLimitPoint = 0;
            Program.Server.serverForm = this;
            ComboReadLimit.Items.Add("회원");
            ComboWriteLimit.Items.Add("회원");
            Program.Server.info.Grades.Add(nGrade);
            PortNumber.Value = 3389;
            ReadLevels(Program.Server.info);
        }
        public int CommentWriteLimitTime
        {
            get
            {
                return Convert.ToInt32(NumericCommentWriteLimitTime.Value);
            }
        }
        public int ThreadSleepTime
        {
            get
            {
                return Convert.ToInt32(NumericThreadSleep.Value);
            }
        }
        public int WriteLimitTime
        {
            get
            {
                return Convert.ToInt32(NumericWriteLimitTime.Value);
            }
        }
        public bool Opened=false;
        public void ServerOpen()
        {
            if (Program.Server.Start(Convert.ToInt32(PortNumber.Value)))
            {
                MaxConnectSize.Enabled = false;
                BoardTree.Enabled = btIconChange.Enabled = LevelList.Enabled = false;

                txtServerName.Enabled = false;
                PortNumber.Enabled = false;
                txtLevelName.Enabled = txtBoardName.Enabled=chkAbleRead.Enabled = chkAbleWrite.Enabled = chkDelModify.Enabled = chkOperate.Enabled = txtLevelDescription.Enabled = btIconChange.Enabled = false;
                btXMLOpen.Enabled = false;

                EventList.Enabled = txtNotice.Enabled = UserMessageList.Enabled = btClearUserMessage.Enabled = btNoticeFloat.Enabled = true;
                btOpen.Enabled = false;
                Opened = true;
                Program.Server.info.Name = txtServerName.Text;
            }
            else
            {
                MessageBox.Show("서버를 여는중 오류가 발생하였습니다.\n포트번호를 확인하여 주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddEvent(string Text)
        {
            EventList.Items.Add(Text);
            
        }
        private void btOpenServer_Click(object sender, EventArgs e)
        {
            if (Opened)
            {
                ServerStop();
                btOpenServer.Text = "서버 열기";
            }
            else
            {
                ServerOpen();
                btOpenServer.Text = "서버 닫기";
            }
        }
        public void ServerStop()
        {
            Program.Server.OverallMesssage(ReceiveControler.MakePacket(ServerPacketType.Server_ShutDown));
            Program.Server.Stop();
            MaxConnectSize.Enabled = false;
            BoardTree.Enabled = btIconChange.Enabled = LevelList.Enabled = true;

            txtServerName.Enabled = true;
            PortNumber.Enabled = true;
            Opened = false;
            btOpen.Enabled = true;
            txtLevelName.Enabled = txtBoardName.Enabled = chkAbleRead.Enabled = chkAbleWrite.Enabled = chkDelModify.Enabled = chkOperate.Enabled = txtLevelDescription.Enabled = btIconChange.Enabled = true;
            btXMLOpen.Enabled = true;

            EventList.Enabled = txtNotice.Enabled = UserMessageList.Enabled = btClearUserMessage.Enabled = btNoticeFloat.Enabled = false;

        }
        public void LibLoad(Information info)
        {
            Program.Server.info = info;
            ReadInformation(info);
            ReadUser(info);
            ReadBoard(info);
            ReadLevels(info);
            ReadBan(info);
            txtJoinGuide.Text = info.JoinGuide;
            txtServerName.Text = info.Name;
            NumericCommentWriteLimitTime.Value = info.CommentWriteLimitTime;
            NumericThreadSleep.Value = info.ThreadSleep;
            NumericWriteLimitTime.Value = info.WriteLimitTime;
        }
        public void ReadInformation(Information info)
        {
            txtServerName.Text = info.Name;
        }
        public void ReadUser(Information info)
        {
            UserList.Items.Clear();
            foreach (User u in info.users)
            {
                if (u.nGrade == null)
                {
                    u.nGrade = info.Grades[Program.Server.GetGrade(u)];
                }
                UserList.Items.Add(new ListViewItem(new string[] { u.ID, u.State.ToString(), Program.Server.info.Grades[Program.Server.GetGrade(u)].Name }));
            }
            ResetUserCount();
        }
        public void BoardAdd(NetworkBookBoard b)
        {
            TreeNode trNode = new TreeNode(b.Name, 0, 0);
            BoardTree.Nodes.Add(trNode);
            foreach(NetworkBookGroup g in b.groups)
                GroupAdd(trNode, g);
        }
        public void GroupAdd(TreeNode trNode,NetworkBookGroup g)
        {
            trNode.Nodes.Add(new TreeNode(g.Name, 1, 1));
        }
        
        public void ReadBoard(Information info)
        {
            BoardTree.Nodes.Clear();
            foreach (NetworkBookBoard b in info.Boards)
            {
                BoardAdd(b);
            }
        }

        public void ReadLevels(Information info)
        {
            LevelList.Clear();
            ComboReadLimit.Items.Clear();
            ComboWriteLimit.Items.Clear();
            
            foreach (NetworkGrade ng in info.Grades)
            {
                ComboWriteLimit.Items.Add(ng.Name);
                ComboReadLimit.Items.Add(ng.Name);
                LevelIconImages.Images.Add(ng.icon);
                LevelList.Items.Add(new ListViewItem(ng.Name, LevelIconImages.Images.Count - 1));
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            Information info;
            FileStream fstream;
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Filter = "네트워크 라이브러리 파일(*.nlib)|*.nlib";
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                fstream = new FileStream(opDialog.FileName, FileMode.Open, FileAccess.Read);
                info = (Information)Component.LoadClass(fstream);
                if (info == null)
                {
                    MessageBox.Show("파일이 잘못됬습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LibLoad(info);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            
        }

        private void btUserAdd_Click(object sender, EventArgs e)
        {
            
        }


        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ReadUser(Program.Server.info);
        }
        public void BoardAble(bool b)
        {
            
            txtBoardDecription.Enabled = b;
            NumbericReadSubPoint.Enabled = b;
            NumbericWriteAddPoint.Enabled = b;
            ComboReadLimit.Enabled = b;
            ComboWriteLimit.Enabled = b;
            그룹추가ToolStripMenuItem.Enabled = b;
        }
        public void ModifyBoard(TreeNode trNode)
        {
            if (trNode == null) return;
            
            if (trNode.ImageIndex == 0)
            {
                if (txtBoardName.Text != "" && trNode.Text != txtBoardName.Text && Program.Server.GetBoard(txtBoardName.Text) != null)
                {
                    MessageBox.Show("이미 있는 게시판의 이름입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BoardTree.SelectedNode = trNode;
                    return;
                }
                trNode.Text = txtBoardName.Text;
                Program.Server.info.Boards[trNode.Index].Name = trNode.Text;
            }
            else if (trNode.ImageIndex == 1)
            {
                NetworkBookGroup Group = Program.Server.info.Boards[trNode.Parent.Index].groups[trNode.Index];
                if (txtBoardName.Text != "" && trNode.Text != txtBoardName.Text && Program.Server.GetGroup(Program.Server.info.Boards[trNode.Parent.Index], txtBoardName.Text) != null)
                {
                    MessageBox.Show("이미 있는 그룹의 이름입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BoardTree.SelectedNode = trNode;
                    return;
                }
                trNode.Text = txtBoardName.Text;
                Group.Name = txtBoardName.Text;
                Group.ReadDelPoint = (int)NumbericReadSubPoint.Value;
                Group.WriteAddPoint = (int)NumbericWriteAddPoint.Value;
                Group.Description = txtBoardDecription.Text;
                
                Group.ReadGrade = Program.Server.info.Grades[(int)Math.Max(0,ComboReadLimit.SelectedIndex)];
                Group.WriteGrade = Program.Server.info.Grades[(int)Math.Max(0,ComboReadLimit.SelectedIndex)];
            }
        }
        private void BoardTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int read,write;
            if (e.Node.ImageIndex == 0)
            {

                BoardAble(false);
                
                txtBoardName.Text = Program.Server.info.Boards[e.Node.Index].Name;

                그룹추가ToolStripMenuItem.Enabled = true;
                return;
            }
            else if (e.Node.ImageIndex == 1)
            {
                NetworkBookBoard ParentBoard = Program.Server.info.Boards[e.Node.Parent.Index];
                BoardAble(true);
                txtBoardName.Text = ParentBoard.groups[e.Node.Index].Name;
                txtBoardDecription.Text = ParentBoard.groups[e.Node.Index].Description;
                NumbericReadSubPoint.Value = ParentBoard.groups[e.Node.Index].ReadDelPoint;
                NumbericWriteAddPoint.Value = ParentBoard.groups[e.Node.Index].WriteAddPoint;
                NetworkBookGroup nGroup = ParentBoard.groups[e.Node.Index];
                if (ParentBoard.groups[e.Node.Index].ReadGrade == null) read = -1;
                else read = ComboReadLimit.FindString(ParentBoard.groups[e.Node.Index].ReadGrade.Name);
                if (read < 0)
                {
                    nGroup.ReadGrade = Program.Server.info.Grades[0];
                    ComboReadLimit.SelectedIndex = 0;
                }
                else
                    ComboReadLimit.SelectedIndex = read;
                if (nGroup.WriteGrade == NetworkGrade.Empty) write = -1;
                else write = ComboWriteLimit.FindString(nGroup.WriteGrade.Name);
                if (write < 0)
                {
                    nGroup.WriteGrade = Program.Server.info.Grades[0];
                    ComboWriteLimit.SelectedIndex = 0;
                }
                else
                    ComboWriteLimit.SelectedIndex = write;

            }
            그룹추가ToolStripMenuItem.Enabled = false;
        }

        private void BoardTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            ModifyBoard(BoardTree.SelectedNode);
        }

        private void btUpGroup_Click(object sender, EventArgs e)
        {
            TreeNode trNode = BoardTree.SelectedNode;
            NetworkBookBoard myBoard;
            int index = 0;
            if (trNode != null && trNode.ImageIndex == 1)
            {
                index = trNode.Index;
                if (index > 0)
                {
                    myBoard = Program.Server.info.Boards[trNode.Parent.Index];
                    trNode.Parent.Nodes.Insert(index - 1,new TreeNode(trNode.Text,1,1));
                    trNode.Parent.Nodes.RemoveAt(trNode.Index);
                    myBoard.groups.Reverse(index-1, 2);
                }
            }
        }

        private void btDownGroup_Click(object sender, EventArgs e)
        {
            TreeNode trNode = BoardTree.SelectedNode;
            NetworkBookBoard myBoard;
            int index = 0;
            if (trNode != null && trNode.ImageIndex == 1)
            {
                index = trNode.Index;
                myBoard = Program.Server.info.Boards[trNode.Parent.Index];
                if (index < myBoard.groups.Count - 1)
                {
                    trNode.Parent.Nodes.Insert(index+1,new TreeNode(trNode.Text,1,1));
                    trNode.Parent.Nodes.RemoveAt(index);
                    myBoard.groups.Reverse(index, 2);
                }
            }
        }
        int index=-1;
        public bool ModifyLevel(int index)
        {
            NetworkGrade grade = Program.Server.info.Grades[index];
            NetworkGrade grade2 = Program.Server.GetGrade(txtLevelName.Text);

            if (grade2 != null && grade2 != grade)
            {
                MessageBox.Show("이미 있는 등급의 이름입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            grade2 = Program.Server.GetGrade((int)NumbericLimitPoint.Value);
            if (grade2 != null && grade2 != grade)
            {
                MessageBox.Show("포인트를 다르게 해주세요", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            grade.Name = txtLevelName.Text;
            grade.Explain = txtLevelDescription.Text;
            grade.MinLimitPoint = (int)NumbericLimitPoint.Value;
            LevelList.Items[index].Text = txtLevelName.Text;
            grade.Read = chkAbleRead.Checked ? true : false;
            grade.Write = chkAbleWrite.Checked ? true : false;
            grade.DelModify = chkDelModify.Checked ? true : false;
            grade.Operate = chkOperate.Checked ? true : false;
            
            Program.Server.RefreshUsers();
            ReadUser(Program.Server.info);
            return true;
        }
        private void LevelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index >= 0 && LevelList.SelectedIndices.IndexOf(index) < 0)
            {
                if (!ModifyLevel(index))
                {
                    int prv = index;
                    index = -1;
                    LevelList.SelectedIndices.Clear();
                    LevelList.SelectedIndices.Add(prv);
                }
            }
            if (LevelList.SelectedIndices.Count > 0)
            {
                    
                index = LevelList.SelectedIndices[0];
                    
                chkAbleRead.Checked = Program.Server.info.Grades[index].Read;
                chkAbleWrite.Checked = Program.Server.info.Grades[index].Write;
                chkDelModify.Checked = Program.Server.info.Grades[index].DelModify;
                chkOperate.Checked = Program.Server.info.Grades[index].Operate;
                txtLevelName.Text = Program.Server.info.Grades[index].Name;
                txtLevelDescription.Text = Program.Server.info.Grades[index].Explain;
                NumbericLimitPoint.Value = Program.Server.info.Grades[index].MinLimitPoint;
            }
        }

        private void btIconChange_Click(object sender, EventArgs e)
        {
            if (LevelList.SelectedIndices.Count <= 0) return;
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Filter = "이미지 파일(*.gif;*.jpg;*.bmp;*.png)|*.gif;*.jpg;*.bmp;*.png";
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                NetworkGrade nGrade = Program.Server.info.Grades[LevelList.SelectedIndices[0]];
                Image img = Image.FromFile(opDialog.FileName);
                if (img != null)
                {
                    nGrade.icon = img;
                    LevelIconImages.Images[LevelList.SelectedIndices[0]] = img;
                }
            }
        }

        private void 게시판추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkBookBoard nbd = new NetworkBookBoard();
            nbd.groups = new List<NetworkBookGroup>();
            string name;
            for (int i = 1; ; i++)
            {
                name = "게시판" + i.ToString();
                if (Program.Server.GetBoard(name) == null)
                    break;
            }
            nbd.Name = name;
            BoardAdd(nbd);
            Program.Server.info.Boards.Add(nbd);
        }

        private void 그룹추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode trNode = BoardTree.SelectedNode;
            if (trNode == null) return;
            NetworkBookGroup bg = new NetworkBookGroup();
            bg.BookKeys = new List<long>();
            string name;
            bg.Description = "";
            if (trNode.ImageIndex == 0)
            {
                for (int i = 1; ; i++)
                {
                    name = "그룹" + i.ToString();
                    if (Program.Server.GetGroup(Program.Server.info.Boards[trNode.Index],name) == null)
                        break;
                }
                bg.ReadGrade = bg.WriteGrade = Program.Server.info.Grades[0];
                
                bg.Name = name;
                GroupAdd(trNode, bg);
                bg.Parent = Program.Server.info.Boards[trNode.Index];
                Program.Server.info.Boards[trNode.Index].groups.Add(bg);
            }
            else if (trNode.ImageIndex == 1)
            {
                for (int i = 1; ; i++)
                {
                    name = "그룹" + i.ToString();
                    if (Program.Server.GetGroup(Program.Server.info.Boards[trNode.Parent.Index], name) == null)
                        break;
                }
                bg.ReadGrade = bg.WriteGrade = Program.Server.info.Grades[0];
                bg.Name = name;
                GroupAdd(trNode.Parent, bg);
                bg.Parent = Program.Server.info.Boards[trNode.Parent.Index];
                Program.Server.info.Boards[trNode.Parent.Index].groups.Add(bg);
            }

        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode trNode = BoardTree.SelectedNode;
            if (trNode != null)
            {
                if (trNode.ImageIndex == 0)
                {
                    if (MessageBox.Show("'" + trNode.Text + "' 게시판을 삭제하시겠습니까?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
                    Program.Server.info.Boards.RemoveAt(trNode.Index);
                    trNode.Remove();
                }
                else if (trNode.ImageIndex == 1)
                {
                    if (MessageBox.Show("'" + trNode.Text + "' 그룹을 삭제하시겠습니까?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
                    Program.Server.info.Boards[trNode.Parent.Index].groups.RemoveAt(trNode.Index);
                }
            }
        }

        private void 등급추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkGrade grade = new NetworkGrade();
            string name;
            for (int i = 1; ; i++)
            {
                name = "등급" + i.ToString();
                if (Program.Server.GetGrade(name) == null)
                    break;
            }
            grade.Name = name;
            grade.MinLimitPoint = Program.Server.info.Grades[Program.Server.info.Grades.Count - 1].MinLimitPoint+1;
            grade.Read = grade.Write = true;
            grade.Operate = grade.DelModify = false;
            grade.icon = Resource_Files.MyResources.Heart1;
            Program.Server.info.Grades.Add(grade);
            LevelIconImages.Images.Add(grade.icon);
            LevelList.Items.Add(new ListViewItem(grade.Name, LevelIconImages.Images.Count-1));
        }

        private void 등급삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LevelList.SelectedIndices.Count == 0) return;
            if (LevelList.Items.Count == 1)
            {
                MessageBox.Show("어떻게든 1개 이상의 등급이 있어야합니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = LevelList.SelectedIndices[0];
            if (MessageBox.Show("'" + LevelList.Items[index].Text + "' 를 삭제하시겠습니까?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            UserList.Items.RemoveAt(index);
            Program.Server.info.Grades.RemoveAt(index);
            Program.Server.GradeRefresh();
            ReadUser(Program.Server.info);
        }

        private void UserList_SizeChanged(object sender, EventArgs e)
        {
            ColumnUserID.Width = UserList.Width - 231;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        
        private void UserList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (Program.Server.info.users[e.ItemIndex].State == UserState.Off)
            {
                btUserDel.Enabled = btModify.Enabled = true;
            }
            else
            {
                btUserDel.Enabled = btModify.Enabled = false;
            }
            if (Program.Server.info.users[e.ItemIndex].State == UserState.Lock)
            {
                btLock.Image = Resource_Files.MyResources._24_security_lock;
            }
            else
            {
                btLock.Image = Resource_Files.MyResources._24_security_lock_open;
            }
        }

        private void btServerRefresh_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FileStream fstream;
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "네트워크 라이브러리 파일(*.nlib)|*.nlib";
            if (svDialog.ShowDialog() == DialogResult.OK)
            {
                Program.Server.info.Name = txtServerName.Text;
                Program.Server.info.JoinGuide = txtJoinGuide.Text;
                Program.Server.info.Name = txtServerName.Text;
                Program.Server.info.CommentWriteLimitTime = (int)NumericCommentWriteLimitTime.Value;
                Program.Server.info.WriteLimitTime = (int)NumericWriteLimitTime.Value;
                Program.Server.info.ThreadSleep = (int)NumericThreadSleep.Value;
                fstream = new FileStream(svDialog.FileName, FileMode.Create, FileAccess.Write);
                Component.SaveClass(Program.Server.info, fstream);
                fstream.Close();
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FileStream fstream;
            OpenFileDialog svDialog = new OpenFileDialog();
            svDialog.Filter = "네트워크 라이브러리 파일(*.nlib)|*.nlib";
            if (svDialog.ShowDialog() == DialogResult.OK)
            {
                fstream = new FileStream(svDialog.FileName, FileMode.Open, FileAccess.Read);
                try
                {
                    LibLoad((Information)Component.LoadClass(fstream));
                }
                catch (Exception)
                {
                    MessageBox.Show("로드할수 없습니다. 파일이 손상되었나 확인해주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                } 
                fstream.Close();

            }
        }

        private void btUserAdd_Click_1(object sender, EventArgs e)
        {
            NetworkUserAddForm usForm = new NetworkUserAddForm(new User(),true);
        replay:
            if (usForm.ShowDialog() == DialogResult.OK)
            {
                if (Program.Server.FindUser(usForm.User.ID) != null)
                {
                    MessageBox.Show("이미 존재하는 아이디입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto replay;
                }
                UserList.Items.Add(new ListViewItem(new string[] { usForm.User.ID, usForm.User.State.ToString(), Program.Server.info.Grades[Program.Server.GetGrade(usForm.User)].Name }));
                Program.Server.info.users.Add(usForm.User);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (UserList.SelectedIndices.Count > 0)
            {
                int index = UserList.SelectedIndices[0];
                User us = Program.Server[index];
                if (MessageBox.Show("정말로 " + us.ID + " 유저를 삭제하시겠습니까?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    UserList.Items.RemoveAt(index);
                    Program.Server.info.users.Remove(us);
                }
            }
        }

        private void btModify_Click_1(object sender, EventArgs e)
        {
            NetworkUserAddForm usForm;
            if (UserList.SelectedIndices.Count > 0)
            {
                int index = UserList.SelectedIndices[0];
                User us = Program.Server[index];
                string bfname = us.ID;
                usForm = new NetworkUserAddForm(us,false);
            replaymodify:
                if (usForm.ShowDialog() == DialogResult.OK)
                {
                    if (Program.Server.FindUser(usForm.User.ID,usForm.User) != null)
                    {
                        MessageBox.Show("이미 존재하는 아이디입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto replaymodify;
                    }
                    us = usForm.User;
                    UserList.Items[index].SubItems[0].Text = us.ID;
                    UserList.Items[index].SubItems[1].Text = us.State.ToString();
                    UserList.Items[index].SubItems[2].Text = Program.Server.info.Grades[Program.Server.GetGrade(us)].Name;
                }
            }
        }

        private void LevelList_Click(object sender, EventArgs e)
        {
        }

        private void tabPage5_Validated(object sender, EventArgs e)
        {

        }

        private void tabPage5_Leave(object sender, EventArgs e)
        {
            LevelList.SelectedIndices.Clear();
            Program.Server.GradeRefresh();
            ReadLevels(Program.Server.info);
        }

        private void tabPage4_Leave(object sender, EventArgs e)
        {
            ModifyBoard(BoardTree.SelectedNode);
        }

        private void txtBoardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                ModifyBoard(BoardTree.SelectedNode);
            }
        }
        public void ResetUserCount()
        {
            this.Invoke(Component.SetText,labelAllUserCount,"총 유저 인원 : " + Program.Server.info.users.Count.ToString() + " 명");
            this.Invoke(Component.SetText, labelConnectedUserCount, "접속 쓰레드: " + Program.Server.Controlers.Count.ToString() + " 명");
            
        }
        private void NetworkServerForm_Load(object sender, EventArgs e)
        {

        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserList.SelectedIndices.Count > 0)
            {
                int index = UserList.SelectedIndices[0];
                if (Program.Server.info.users[index].State == UserState.Lock)
                {
                    btLock.Image = Resource_Files.MyResources._24_security_lock;
                }
                else
                {
                    btLock.Image = Resource_Files.MyResources._24_security_lock_open;
                }
            }
        }

        private void btLock_Click(object sender, EventArgs e)
        {
            if (UserList.SelectedIndices.Count > 0)
            {
                int index = UserList.SelectedIndices[0];
                if (Program.Server.info.users[index].State == UserState.Lock)
                {
                    Program.Server.info.users[index].State = UserState.Off;
                    btLock.Image = Resource_Files.MyResources._24_security_lock;
                    UserList.SelectedItems[0].SubItems[1].Text = "On";
                }
                else
                {
                    Program.Server.Lock(Program.Server.info.users[index]);
                    btLock.Image = Resource_Files.MyResources._24_security_lock_open;
                    UserList.SelectedItems[0].SubItems[1].Text = "Lock";
                }
            }
        }
        public void ReadBan(Information info)
        {
            IPBanList.Items.Clear();
            foreach(string at in info.Bans)
                IPBanList.Items.Add(at);
        }

        private void btIPBan_Click(object sender, EventArgs e)
        {
            if (IPBanList.FindString(IPBanCombo.Text) >= 0)
            {
                MessageBox.Show("밴리스트에 이미 존재하는 IP입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IPBanList.Items.Add(IPBanCombo.Text);
            Program.Server.info.Bans.Add(IPBanCombo.Text);
        }

        private void btBanOpen_Click(object sender, EventArgs e)
        {
            if (IPBanList.SelectedIndex >= 0)
            {
                Program.Server.info.Bans.RemoveAt(IPBanList.SelectedIndex);
                IPBanList.Items.RemoveAt(IPBanList.SelectedIndex);
            }
        }

        private void btClearUserMessage_Click(object sender, EventArgs e)
        {
            UserMessageList.Items.Clear();
        }

        private void btNoticeFloat_Click(object sender, EventArgs e)
        {
            Program.Server.Notice = txtNotice.Text;
        }

        private void chkOperate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOperate.Checked)
            {
                chkDelModify.Checked = true;
                chkDelModify.Enabled = false;
            }
            else
            {
                chkDelModify.Enabled = true;
            }
        }

        private void NetworkServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ServerStop();
            }
            catch(Exception)
            {
            }
        }
        private void SaveXMLUsers(User[] Users,string FileName)
        {
            DataSet dSet = new DataSet();
            dSet.Tables.Add("User");
            dSet.Tables[0].Columns.Add("ID",typeof(string));
            dSet.Tables[0].Columns.Add("PW",typeof(string));
            dSet.Tables[0].Columns.Add("LastBookWriteTime",typeof(long));
            dSet.Tables[0].Columns.Add("LastCommentWriteTime",typeof(long));
            dSet.Tables[0].Columns.Add("Point", typeof(uint));
            int i = 1;
            foreach (User us in Users)
            {
                dSet.Tables.Add(us.ID);
                dSet.Tables[i].Columns.Add("Key");
                foreach (long k in us.AlreadyReadKey)
                {
                    dSet.Tables[i].Rows.Add(k);
                }
                dSet.Tables[0].Rows.Add(us.ID, us.PW, us.LastBookWriteTime, us.LastCommentWrite, us.Point);
                i++;
            }
            dSet.WriteXml(FileName);
        }
        private void btXMLSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "XML파일(*.xml)|*.xml";
            if (svDialog.ShowDialog() == DialogResult.OK)
            {
                SaveXMLUsers(Program.Server.info.users.ToArray(), svDialog.FileName);
            }
        }
        private List<User> LoadXMLUsers(string FileName)
        {
            DataSet dSet = new DataSet();
            dSet.ReadXml(FileName);
            DataTable table = dSet.Tables["User"];
            List<User> users= new List<User>();
            foreach (DataRow dRow in table.Rows)
            {
                User us = new User();
                users.Add(us);
                us.ID = dRow.ItemArray[0].ToString();
                us.PW = dRow.ItemArray[1].ToString();
                us.LastBookWriteTime = Convert.ToInt64(dRow.ItemArray[3]);
                us.LastCommentWrite = Convert.ToInt64(dRow.ItemArray[4]);
                us.Point = Convert.ToUInt32(dRow.ItemArray[5]);
                DataTable ReadKeyTable = dSet.Tables[us.ID];
                if (ReadKeyTable == null)
                {
                    continue;
                }
                foreach (DataRow drow in ReadKeyTable.Rows)
                {
                    us.AlreadyReadKey.Add(Convert.ToInt64(drow.ItemArray[0]));
                }

            }
            return users;
        }
        private void btXMLOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Filter = "XML파일(*.xml)|*.xml";
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Program.Server.info.users = LoadXMLUsers(opDialog.FileName);
                    ReadUser(Program.Server.info);
                }
                catch (Exception)
                {
                    MessageBox.Show("XML을 로드하는 도중 에러가 발생하였습니다\n변질된 XML이 아닌지 확인해주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NumericThreadSleep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
