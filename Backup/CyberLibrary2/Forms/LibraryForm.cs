using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

using CyberLibrary2.Classes;
namespace CyberLibrary2
{
    public partial class LibraryForm : Form
    {
        BookLibrary bokLibrary;
        CyberLibrary2.Controls.Book_Read book_Read;
        public LibraryForm()
        {
            InitializeComponent();
            bokLibrary = new BookLibrary();
            book_Read = new CyberLibrary2.Controls.Book_Read();
            book_Read.SetBounds(168, 27, 369, 265);
            book_Read.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            this.Controls.Add(book_Read);
            
            Abled(false);
        }
        public void SetBook(Book b)
        {
            book_Read.SetBook(b);
            CommentBoard.SetComment(b.Comments);
        }
        private void BookTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tr = BookTree.SelectedNode;

            if (tr != null)
            {
                if (tr.ImageIndex == 1) // Book
                {
                    Book b = bokLibrary.FindBook(tr.FullPath);
                    SetBook(b);
                    Abled(true);
                }
                else
                {
                    Abled(false);
                }
            }
        }

        private void CommentBoard_Load(object sender, EventArgs e)
        {

        }
        public bool AddGroup(TreeNode tr, BookGroup Data)
        {
            if (tr == null)
            {
                if (bokLibrary.MainGroups.FindGroup(Data.Name) == null)
                {
                    bokLibrary.MainGroups.AddGroup(Data);
                    BookTree.Nodes.Add(new TreeNode(Data.Name, 0, 0));
                    return true;
                }
                return false;
            }
            if (tr.ImageIndex == 0) // Group
            {
                BookGroup bgroup = bokLibrary.FindGroup(tr.FullPath);

                if (bgroup != null)
                {
                    if (bokLibrary.GroupinCheck(bgroup,Data) && bgroup.FindGroup(Data.Name) == null)
                    {
                        bgroup.AddGroup(Data);
                        tr.Nodes.Add(new TreeNode(Data.Name, 0, 0));
                        return true;
                    }
                    return false;
                }
            }
            else if (tr.ImageIndex == 1) // Book
            {
                if (tr.Parent == null)
                {
                    if (bokLibrary.MainGroups.FindGroup(Data.Name) == null)
                    {
                        bokLibrary.MainGroups.AddGroup(Data);
                        BookTree.Nodes.Add(new TreeNode(Data.Name, 0, 0));
                        return true;
                    }
                    return false;
                }
                else
                {
                    BookGroup bgroup = bokLibrary.FindGroup(tr.Parent.FullPath);
                    if (bgroup != null)
                    {

                        if (bokLibrary.GroupinCheck(bgroup,Data) && bgroup.FindGroup(Data.Name) == null)
                        {
                            bgroup.AddGroup(Data);
                            tr.Nodes.Add(new TreeNode(Data.Name, 0, 0));
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }
        public bool AddBook(TreeNode tr,Book Data)
        {
            if (tr == null)
            {
                if (bokLibrary.MainGroups.FindBook(Data.BookName) == null)
                {
                    bokLibrary.MainGroups.AddBook(Data);
                    BookTree.Nodes.Add(new TreeNode(Data.BookName, 1, 1));
                    return true;
                }
                return false;
            }
            if (tr.ImageIndex == 0) // Group
            {
                BookGroup bgroup = bokLibrary.FindGroup(tr.FullPath);
                if (bgroup != null)
                {

                    if (bgroup.FindBook(Data.BookName) == null)
                    {
                        bgroup.AddBook(Data);
                        tr.Nodes.Add(new TreeNode(Data.BookName, 1, 1));
                        return true;
                    }
                    return false;
                }
            }
            else if (tr.ImageIndex == 1) // Book
            {
                if (tr.Parent == null)
                {
                    if (bokLibrary.MainGroups.FindBook(Data.BookName) == null)
                    {
                        bokLibrary.MainGroups.AddBook(Data);
                        BookTree.Nodes.Add(new TreeNode(Data.BookName, 1, 1));
                        return true;
                    }
                    return false;
                }
                else
                {
                    BookGroup bgroup = bokLibrary.FindGroup(tr.Parent.FullPath);
                    if (bgroup != null)
                    {

                        if (bgroup.FindBook(Data.BookName) == null)
                        {
                            bgroup.AddBook(Data);
                            tr.Nodes.Add(new TreeNode(Data.BookName, 1, 1));
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }
        private void 북추가AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tr = BookTree.SelectedNode;
            Forms.WriterForm wForm = new CyberLibrary2.Forms.WriterForm();
            replay:
            if (wForm.ShowDialog() == DialogResult.OK)
            {
                if (!AddBook(tr, wForm.book))
                {
                    MessageBox.Show("이미 존재하는 이름의 책이 있습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto replay;
                }
            }
        }

        private void 북수정RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tr = BookTree.SelectedNode;
            Forms.WriterForm wForm = new CyberLibrary2.Forms.WriterForm();
            if(tr!=null && tr.ImageIndex == 1)
            {
                Book b = bokLibrary.FindBook(tr.FullPath);
                if (b != null)
                {
                    wForm.bookEditor1.LoadBook(b);
                modify_replay:
                    if (wForm.ShowDialog() == DialogResult.OK)
                    {
                        if (wForm.book.BookName != b.BookName && b.Parent.FindBook(wForm.book.BookName) != null)
                        {
                            MessageBox.Show("이미 존재하는 이름의 책이 있습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto modify_replay;
                        }
                        SetBook(b);
                    }
                }
            }
        }

        private void 그룹추가GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookGroup bg = new BookGroup();
        replaygroup:
            string input=Forms.InputBox.InputString("그룹 추가", "추가할 그룹의 이름을 적어주세요.",false);
            if (input != null)
            {
                bg.Name = input;
            
                if (!AddGroup(BookTree.SelectedNode, bg))
                {
                    MessageBox.Show("이미 존재하는 이름의 그룹이 있습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto replaygroup;
                }
            }
        }

        public void Delete(TreeNode trNode)
        {
            if (trNode.ImageIndex == 0)
            {
                BookGroup bg = bokLibrary.FindGroup(trNode.FullPath);
                if (bg != null)
                {
                    bg.Parent.RemoveGroup(bg.Name);
                    if (trNode.Parent == null)
                        BookTree.Nodes.Remove(trNode);
                    else
                        trNode.Parent.Nodes.Remove(trNode);
                }
            }
            else if (trNode.ImageIndex == 1)
            {
                Book b = bokLibrary.FindBook(trNode.FullPath);
                if (b != null)
                {
                    b.Parent.RemoveBook(b.BookName);
                    if (trNode.Parent == null)
                        BookTree.Nodes.Remove(trNode);
                    else
                        trNode.Parent.Nodes.Remove(trNode);
                }
            }
        }
        private void 삭제XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode trNode = BookTree.SelectedNode;
            if (MessageBox.Show("\'" + trNode.Text + "\'을 삭제하시겠습니까?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (trNode != null)
            {
                Delete(trNode);
                Abled(false);
            }
        }

        private void btLevel_Click(object sender, EventArgs e)
        {
            if (book_Read.myBook.PageCount == 0) return;
            replay_input:
            string input=Forms.InputBox.InputString("평점", "평점을 입력해주세요.",false);
            try
            {
                book_Read.myBook.BookLevel = (float)Convert.ToDouble(input);
                SetBook(book_Read.myBook);
            }
            catch (Exception)
            {
                MessageBox.Show("제대로된 값을 입력해주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto replay_input;
            }
        }
        public void Abled(bool tf)
        {
            btCommentAdd.Enabled = book_Read.Enabled=txtPassword.Enabled = txtContext.Enabled=CommentBoard.Enabled = tf;
            if (!tf) CommentBoard.CommentClear();
        }
        private void btCommentAdd_Click(object sender, EventArgs e)
        {
            }
        public string BeforeText="";
        private void BookTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.CancelEdit) return;
            TreeNode trNode = BookTree.SelectedNode;
            if (e.Label == null)
            {
                e.CancelEdit = true;
                return;
            }
            if (trNode.ImageIndex == 0)
            {
                BookGroup bg = bokLibrary.FindGroup(trNode.Text);
                if (trNode.Text != e.Label && bg.Parent.FindGroup(e.Label) != null)
                {
                    MessageBox.Show("이미 있는 그룹 이름입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.CancelEdit = true;
                    return;
                }
                bg.Name = e.Label;
            }
            else if(trNode.ImageIndex == 1)
            {
                Book b = bokLibrary.FindBook(trNode.Text);
                if (trNode.Text != e.Label && b.Parent.FindBook(e.Label) != null)
                {
                    MessageBox.Show("이미 있는 책 이름입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.CancelEdit = true;
                    return;
                }
                b.BookName = e.Label;
            }
        }

        private void BookTree_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            BeforeText = BookTree.SelectedNode.FullPath;
        }

        private void BookTree_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            
        }

        private void newLibraryNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("작업중이던 파일을 저장하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                SVDialog.FileName = "";
                if (SVDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(SVDialog.FileName);
                }
            }
            else if (question == DialogResult.Cancel)
            {
                return;
            }
            bokLibrary = new BookLibrary();
            BookTree.Nodes.Clear();
            Abled(false);
        }
        public void TreeAddBook(Book g, TreeNode trNode)
        {
            TreeNode me = new TreeNode(g.BookName, 1, 1);
            if (trNode == null)
            {
                BookTree.Nodes.Add(me);
            }
            else
            {
                if (trNode.ImageIndex == 0)
                    trNode.Nodes.Add(me);
                else
                    if (trNode.Parent == null) BookTree.Nodes.Add(me);
                    else trNode.Parent.Nodes.Add(me);
            }
        }
        public void TreeAddGroup(BookGroup g, TreeNode trNode)
        {
            TreeNode me = new TreeNode(g.Name, 0, 0);
            if (trNode == null)
            {
                BookTree.Nodes.Add(me);
            }
            else
            {
                if (trNode.ImageIndex == 0)
                    trNode.Nodes.Add(me);
                else
                    if (trNode.Parent == null) BookTree.Nodes.Add(me);
                    else trNode.Parent.Nodes.Add(me);
            }
            foreach (Book b in g.books)
                TreeAddBook(b, me);
            foreach (BookGroup bg in g.groups)
                TreeAddGroup(bg, me);
        }
        public void LoadFile(string file)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            bokLibrary = (BookLibrary)Component.LoadClass(fstream);
            Abled(false);
            BookTree.Nodes.Clear();
            foreach (BookGroup bGroup in bokLibrary.MainGroups.groups)
            {
                TreeAddGroup(bGroup, null);
            }
            foreach (Book bok in bokLibrary.MainGroups.books)
            {
                TreeAddBook(bok, null);
            }
            fstream.Close();
        }
        public void SaveFile(string file)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(file, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            Component.SaveClass(bokLibrary, fstream);
            fstream.Close();
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OEDialog.FileName = "";
            if (OEDialog.ShowDialog() == DialogResult.OK)
            {
                LoadFile(OEDialog.FileName);
            }
        }

        private void 라이브러리저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SVDialog.FileName = "";
            if (SVDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(SVDialog.FileName);
            }
        }

        private void txtContext_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void DisposeNode(TreeNode trNode)
        {
            if (trNode.Parent == null)
            {
                BookTree.Nodes.Remove(trNode);

            }
            else
            {
                trNode.Parent.Nodes.Remove(trNode);
            }
        }
        bool Moved;
        private void BookTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragDropEffects effect;
                TreeNode trNode = BookTree.GetNodeAt(new Point(e.X, e.Y));
                if (trNode != null)
                {
                    BookTree.SelectedNode = trNode;
                    if (trNode.ImageIndex == 0)
                    {
                        BookGroup g = bokLibrary.FindGroup(trNode.FullPath);
                        if (g == null) return;
                        effect = DoDragDrop(g, DragDropEffects.Move | DragDropEffects.Copy);

                        if (effect == DragDropEffects.Move && Moved)
                        {
                            
                            DisposeNode(trNode);
                        }
                    }
                    else
                    {
                        Book g = bokLibrary.FindBook(trNode.FullPath);
                        if (g == null) return;

                        effect = DoDragDrop(g, DragDropEffects.Move | DragDropEffects.Copy);
                        if (effect == DragDropEffects.Move && Moved)
                        {
                            
                            DisposeNode(trNode);
                        }
                    }

                }
            }
        }
        public bool PossibleGo(TreeNode trNode, string Name,bool Group)
        {
            BookGroup check = null;
            if (Group)
            {
                if (trNode == null) check = bokLibrary.MainGroups;
                else check = bokLibrary.FindGroup(trNode.FullPath);
                if (check.FindGroup(Name) != null || check.Name == Name)
                    return false;
            }
            else
            {
                if (trNode == null) check = bokLibrary.MainGroups;
                else check = bokLibrary.FindGroup(trNode.FullPath);
                if (check.FindGroup(Name) != null)
                    return false;
            }
            return true;
        }
        private void BookTree_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode selNode = BookTree.GetNodeAt(BookTree.PointToClient(new Point(e.X, e.Y)));
            Moved = false;
            if (e.Data.GetDataPresent(typeof(Book)))
            {
                Book p = (Book)e.Data.GetData(typeof(Book));
                if (!PossibleGo(selNode, p.BookName,false))
                    return;
                p.Parent.RemoveBook(p.BookName);
                AddBook(selNode, p);
                Moved = true;
            }
            else if (e.Data.GetDataPresent(typeof(BookGroup)))
            {
                BookGroup p;
                if (e.Effect == DragDropEffects.Move)
                    p = (BookGroup)e.Data.GetData(typeof(BookGroup));
                else
                    p = (BookGroup)e.Data.GetData(typeof(BookGroup));
                if (!PossibleGo(selNode, p.Name,true))
                    return;
                p.Parent.RemoveGroup(p.Name);
                AddGroup(selNode, p);
                Moved = true;
            }
        }

        private void BookTree_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode trNode = BookTree.GetNodeAt(e.X, e.Y);
            if (trNode != null)
            {
                BookTree.SelectedNode = trNode;
            }
        }

        private void BookTree_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.EscapePressed)
            {
                e.Action = DragAction.Cancel;
            }
        }

        private void BookTree_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(BookGroup)) || e.Data.GetDataPresent(typeof(Book)))
            {
                if ((e.KeyState & 8) != 0)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                }
            }
        }

        private void Scanbt_Click(object sender, EventArgs e)
        {
            string[] PathSplit;
            TreeNode trNode = null;
            TreeNode[] _Nodes;
            Forms.FindBookForm frmFind = new CyberLibrary2.Forms.FindBookForm(bokLibrary);
            if (frmFind.ShowDialog() == DialogResult.OK)
            {
                if (frmFind.sPath != "")
                {
                    PathSplit = frmFind.sPath.Split('\\');
                    _Nodes = BookTree.Nodes.Find(PathSplit[0], false);
                    foreach (TreeNode tNode in _Nodes)
                    {
                        if ((tNode.ImageIndex == 0 && PathSplit.Length >= 2))
                        {
                            trNode = tNode;
                            break;
                        }
                        else if ((tNode.ImageIndex == 1 && PathSplit.Length == 1))
                        {
                            BookTree.SelectedNode = tNode;
                            return;
                        }
                    }
                    for (int i = 1; i < PathSplit.Length - 1; i++)
                    {
                        _Nodes = trNode.Nodes.Find(PathSplit[i], false);
                        foreach (TreeNode tNode in _Nodes)
                        {
                            if (tNode.ImageIndex == 0)
                            {
                                trNode = tNode;
                                break;
                            }
                        }
                    }
                    if (trNode == null)
                    {
                        foreach (TreeNode tNode in BookTree.Nodes)
                        {
                            if (tNode.ImageIndex == 1 && tNode.Text == PathSplit[PathSplit.Length - 1])
                            {
                                BookTree.SelectedNode = tNode;
                                return;
                            }
                        }
                    }
                    _Nodes = trNode.Nodes.Find(PathSplit[PathSplit.Length - 1], false);
                    foreach (TreeNode tNode in _Nodes)
                    {
                        if (tNode.ImageIndex == 1)
                        {
                            BookTree.SelectedNode = tNode;
                            break;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string pwd;
            if (CommentBoard.CommentView.SelectedIndices.Count > 0)
            {
                pwd = Forms.InputBox.InputString("덧글 삭제", "비밀번호를 입력해주세요", true);
                if (pwd != null)
                {
                    if (!CommentBoard.DelComment(CommentBoard.CommentView.SelectedIndices[0], pwd))
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtContext.Text == "" || txtPassword.Text == "") return;
            CommentBoard.AddComment(txtPassword.Text, "admin", txtContext.Text);
            txtContext.Text = "";
        }

        private void 접속PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.IPForm ipform = new CyberLibrary2.Forms.IPForm();
            if (ipform.ShowDialog() == DialogResult.OK)
            {
                Program.Client = new CyberLibrary2.Classes.ClientControler();
                if (!Program.Client.Connect(ipform.IP, ipform.Port))
                {
                    MessageBox.Show("접속에 실패했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.LoginForm = new CyberLibrary2.Forms.LoginForm();
                Program.LoginForm.ShowDialog();
            }

        }

        private void 열기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.NetworkServerForm nserver = new CyberLibrary2.Forms.NetworkServerForm();
            nserver.ShowDialog();
        }

        private void LibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingData.SaveSettings();
            Environment.Exit(0);
        }

        private void 라이브러리설정SEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LibSettingForm.ShowDialog();
            book_Read.PageSet(book_Read.PageIndex);
        }

        private void LibraryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ProgramSettings.GetSKey("Find").CheckKeyEvent(e))
            {
                Scanbt_Click(sender, null);
            }
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void 제작자ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
