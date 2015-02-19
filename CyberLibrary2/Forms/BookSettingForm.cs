using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class BookSettingForm : Form
    {
        public Book itsSetting;
        public BookEditor myEditor;
        public bool Moved=false;
        public BookSettingForm()
        {
            InitializeComponent();
        }
        public BookSettingForm(Book bSetting,BookEditor edit)
        {
            InitializeComponent();
            itsSetting = bSetting;
            myEditor = edit;
        }
        
        private void BookSettingForm_Load(object sender, EventArgs e)
        {
            if (itsSetting == null)
            {
                itsSetting = new Book();
            }
            else
            {
                foreach (Group p in itsSetting.MainGroup.Groups)
                    AddGroup(StructureTree, p);
                foreach (Page p in itsSetting.MainGroup.Pages)
                    AddPage(StructureTree, p);
                txtExplain.Text = itsSetting.BookExplain;
                txtBookName.Text = itsSetting.BookName;
                txtWriter.Text = itsSetting.WriterName;
                txtTransferName.Text = itsSetting.TransferName;
            }
        }
        public void AddGroup(TreeNode Parent,Group g)
        {
            TreeNode me = new TreeNode(g.Name, 0, 0);
            Parent.Nodes.Add(me);
            foreach (Group p in g.Groups)
                AddGroup(me, p);
            foreach (Page p in g.Pages)
                AddPage(me, p);
        }
        public void AddGroup(TreeView Parent, Group g)
        {
            TreeNode me = new TreeNode(g.Name, 0, 0);
            Parent.Nodes.Add(me);
            foreach (Group p in g.Groups)
                AddGroup(me, p);
            foreach (Page p in g.Pages)
                AddPage(me, p);
        }
        public void AddPage(TreeNode Parent, Page p)
        {
            Parent.Nodes.Add(new TreeNode(p.Name, 1, 1));
        }
        public void AddPage(TreeView Parent, Page p)
        {
            Parent.Nodes.Add(new TreeNode(p.Name, 1, 1));
        }
        
        

        private void StructureTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode trNode = StructureTree.SelectedNode;
            if (trNode != null)
            {
                if (trNode.ImageIndex == 0)
                {
                    Group g = itsSetting.FindGroup(trNode.FullPath);
                    if (g == null)
                    {
                    }
                    else
                    {
                        txtExplainStructure.Enabled = txtStructureName.Enabled = true;

                        txtStructureName.Text = g.Name;
                        txtExplainStructure.Text = g.Explain;
                        txtPageIndex.Enabled = false;
                        btBackgroundImage.Enabled = false;

                    }
                    //그룹
                }
                else if (trNode.ImageIndex == 1)
                {
                    Page p = itsSetting.FindPage(trNode.FullPath);
                    if (p == null)
                    {

                    }
                    else
                    {
                        txtExplainStructure.Enabled = txtStructureName.Enabled = txtPageIndex.Enabled = true;
                        txtStructureName.Text = p.Name;
                        txtExplainStructure.Text = p.Explain;
                        txtPageIndex.Text = p.PageIndex.ToString();
                        btBackgroundImage.Enabled = true;


                    }
                }
            }
            else
            {
                txtPageIndex.Enabled = txtExplainStructure.Enabled = txtStructureName.Enabled = btBackgroundImage.Enabled = false;
            }
        }

        private void BookSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StructureTree.SelectedNode != null)
            {
                Modify(StructureTree.SelectedNode);
            }
            itsSetting.TransferName = txtTransferName.Text;
            itsSetting.WriterName = txtWriter.Text;
            itsSetting.BookName = txtBookName.Text;
            itsSetting.BookExplain = txtExplain.Text;
            
        }

        private void 그룹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group p = new Group();
            int i = 0;
            string name;
            for (i = 1; ; i++)
            {
                name = "그룹" + i.ToString();
                if (itsSetting.TreeToGroup(itsSetting.MainGroup,name) == null)
                {
                    break;
                }
            }
            p.Name = name;
            p.Groups = new List<Group>();
            p.Pages = new List<Page>();
            p.Explain = "";
            if (StructureTree.SelectedNode != null)
            {
                if (StructureTree.SelectedNode.ImageIndex == 0)
                {
                    TreeNode tr = StructureTree.SelectedNode;
                    Group ptr = itsSetting.FindGroup(tr.FullPath);
                    ptr.Groups.Add(p);
                    AddGroup(tr, p);
                    p.Parent = ptr;
                }
                else
                {
                    if (StructureTree.SelectedNode.Parent != null)
                    {
                        TreeNode tr = StructureTree.SelectedNode.Parent;

                        Group ptr = itsSetting.FindGroup(tr.FullPath);
                        ptr.Groups.Add(p);
                        AddGroup(tr, p);
                        p.Parent = ptr;
                    }
                    else
                    {
                        itsSetting.MainGroup.Groups.Add(p);

                        p.Parent = itsSetting.MainGroup;

                        AddGroup(StructureTree, p);
                    }
                }
            }
            else
            {
                itsSetting.MainGroup.Groups.Add(p);
                p.Parent = itsSetting.MainGroup;

                AddGroup(StructureTree, p);
            }
        }

        private void 페이지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Page p = new Page();
            int i = 0;
            string name;
            for (i = 1; ; i++)
            {
                name = "페이지" + i.ToString();
                if (itsSetting.TreeToPage(itsSetting.MainGroup,name) == null)
                {
                    break;
                }
            }
            p.Name = name;
            p.myBook = itsSetting;
            p.PageIndex = ++itsSetting.PageCount;
            p.Explain = "";
            if (StructureTree.SelectedNode != null)
            {
                if (StructureTree.SelectedNode.ImageIndex == 0)
                {
                    TreeNode tr = StructureTree.SelectedNode;
                    Group ptr = itsSetting.FindGroup(tr.FullPath);
                    ptr.Pages.Add(p);
                    AddPage(tr, p);
                    p.Parent = ptr;
                }
                else
                {
                    if (StructureTree.SelectedNode.Parent != null)
                    {
                        TreeNode tr = StructureTree.SelectedNode.Parent;
                        Group ptr = itsSetting.FindGroup(tr.FullPath);
                        ptr.Pages.Add(p);
                        AddPage(tr, p);
                        p.Parent = ptr;
                    }
                    else
                    {
                        itsSetting.MainGroup.Pages.Add(p);
                        AddPage(StructureTree, p);
                        p.Parent = itsSetting.MainGroup;

                    }
                }
            }
            else
            {
                itsSetting.MainGroup.Pages.Add(p);
                AddPage(StructureTree, p);
                p.Parent = itsSetting.MainGroup;

            }
        }
        private void Modify(TreeNode trNode)
        {
            if (txtStructureName.Text.IndexOf('\\') >= 0)
            {
                MessageBox.Show("페이지(그룹) 이름에 \\가 들어있으면 안됩니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StructureTree.SelectedNode = trNode;
                return;
            }
            if (trNode.ImageIndex == 0)
            {
                Group g = itsSetting.FindGroup(trNode.FullPath);
                if (g == null) return;

                if ((g.Name != txtStructureName.Text && itsSetting.FindGroup((trNode.Parent == null ? "" : (trNode.Parent.FullPath + "\\")) + txtStructureName.Text) != null) || txtStructureName.Text == "")
                {
                    MessageBox.Show("이름이 잘못 되었습니다.\n이미 있는 이름의 그룹입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StructureTree.SelectedNode = trNode;
                    return;
                }
                
                g.Explain = txtExplainStructure.Text;
                g.Name = txtStructureName.Text;
                //그룹
            }
            if (trNode.ImageIndex == 1)
            {
                Page p = itsSetting.FindPage(trNode.FullPath);
                if (p == null) return;

                p.myBook = itsSetting;
                int index;
                try
                {
                    index = Convert.ToInt32(txtPageIndex.Text);
                    if (p.PageIndex != index && itsSetting.TreeToPage(itsSetting.MainGroup, index) != null)
                    {
                        MessageBox.Show("인덱스가 잘못 되었습니다.\n이미 있는 인덱스의 페이지입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StructureTree.SelectedNode = trNode;
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("올바른 인덱스를 입력해주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StructureTree.SelectedNode = trNode;
                    return;
                }
                if (p.Name != txtStructureName.Text && itsSetting.FindPage((trNode.Parent == null ? "" : (trNode.Parent.FullPath + "\\")) + txtStructureName.Text) != null)
                {
                    MessageBox.Show("이름이 잘못 되었습니다.\n이미 있는 이름의 페이지입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StructureTree.SelectedNode = trNode;
                    return;
                }

                p.Explain = txtExplainStructure.Text;
                p.Name = txtStructureName.Text;
                p.PageIndex = index;
                //페이지 
            }
            trNode.Text = txtStructureName.Text;
        }
        private void StructureTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

            if (StructureTree.SelectedNode != null)
                Modify(StructureTree.SelectedNode);
        }

        private void DisposeNode(TreeNode trNode)
        {
            if (trNode.Parent == null)
            {
                StructureTree.Nodes.Remove(trNode);

            }
            else
            {
                trNode.Parent.Nodes.Remove(trNode);
            }
        }
        bool NotDelete = false;
        private void StructureTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !NotDelete)
            {
                DragDropEffects effect;
                TreeNode trNode = StructureTree.GetNodeAt(new Point(e.X,e.Y));
                if (trNode != null)
                {
                    StructureTree.SelectedNode = trNode;
                    if (trNode.ImageIndex == 0)
                    {
                        Group g = itsSetting.FindGroup(trNode.FullPath);
                        if (g == null) return;
                        effect = DoDragDrop(g, DragDropEffects.Move | DragDropEffects.Copy);
                        
                        if (effect == DragDropEffects.Move && Moved)
                        {
                            NotDelete = true;
                            itsSetting.DeleteGroup(trNode.FullPath);
                            NotDelete = false;
                            DisposeNode(trNode);
                            
                        }
                    }
                    else
                    {
                        Page g = itsSetting.FindPage(trNode.FullPath);
                        if (g == null) return;

                        effect = DoDragDrop(g, DragDropEffects.Move | DragDropEffects.Copy);
                        if (effect == DragDropEffects.Move && Moved)
                        {
                            NotDelete = true;
                            itsSetting.DeletePage(trNode.FullPath);
                            NotDelete = false;
                            DisposeNode(trNode);
                        }
                    }

                }
            }
        }

        private void StructureTree_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.EscapePressed)
            {
                
                e.Action = DragAction.Cancel;
            }
        }

        private void StructureTree_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Page)))
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
            else if (e.Data.GetDataPresent(typeof(Group)))
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
        public bool PossibleGo(TreeNode trNode, string Name,bool Group)
        {
            Group check=null;
            if (Group)
            {
                if (trNode == null) check = itsSetting.MainGroup;
                else check = itsSetting.FindGroup(trNode.FullPath);
                if (itsSetting.GoGroup(check, Name) != null || check.Name == Name)
                    return false;
            }
            else
            {
                if (trNode == null) check = itsSetting.MainGroup;
                else check = itsSetting.FindGroup(trNode.FullPath);
                if (itsSetting.GoPage(check, Name) != null)
                    return false;
            }
            return true;
        }
        private void StructureTree_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode selNode = StructureTree.GetNodeAt(StructureTree.PointToClient(new Point(e.X,e.Y)));
            Moved = false;
            if (selNode != null)
            {
                
                if (e.Data.GetDataPresent(typeof(Page)))
                {
                    
                    Page p = new Page((Page)e.Data.GetData(typeof(Page)));
                    if (!PossibleGo(selNode, p.Name,false))
                        return;
                    if (e.Effect == DragDropEffects.Copy)
                        p.PageIndex = itsSetting.GetVoidIndex();
                    if (selNode.ImageIndex == 0)
                    {
                        p.Parent = itsSetting.FindGroup(selNode.FullPath);
                        
                        AddPage(selNode, p);
                        Moved = true;
                    }
                    else
                    {
                        if (selNode.Parent == null)
                        {
                            p.Parent = itsSetting.MainGroup;
                            AddPage(StructureTree, p);
                            Moved = true;
                        }
                        else
                        {
                            p.Parent = itsSetting.FindGroup(selNode.Parent.FullPath);

                            AddPage(selNode.Parent, p);
                            Moved = true;
                        }
                    }
                    if (Moved)
                    {
                        p.Parent.Pages.Add(p);

                    }
                }
                else if (e.Data.GetDataPresent(typeof(Group)))
                {
                    Group p;
                    if (e.Effect == DragDropEffects.Move)
                        p = (Group)e.Data.GetData(typeof(Group));
                    else
                        p = new Group((Group)e.Data.GetData(typeof(Group)));
                    if (!PossibleGo(selNode, p.Name,true))
                        return;
                    if (selNode.ImageIndex == 0)
                    {
                        Group g = itsSetting.FindGroup(selNode.FullPath);
                        if (Book.GroupinCheck(p, g))
                        {
                            Moved = false;
                            return;
                        }
                        
                        p.Parent = g;

                        Moved = true;
                        AddGroup(selNode, p);
                    }
                    else
                    {
                        if (selNode.Parent == null)
                        {
                            p.Parent = itsSetting.MainGroup;
                            AddGroup(StructureTree, p);
                            Moved = true;
                        }
                        else
                        {
                            Group g = itsSetting.FindGroup(selNode.Parent.FullPath);
                        
                            if (Book.GroupinCheck(p, g))
                            {
                                Moved = false;
                                return;
                            }
                            p.Parent = g;
                            AddGroup(selNode.Parent, p);
                            Moved = true;
                        }
                    }

                    if (Moved)
                    {
                        p.Parent.Groups.Add(p);

                    }
                }
            }
            else
            {
                if (e.Data.GetDataPresent(typeof(Page)))
                
                {
                    Page p = (Page)e.Data.GetData(typeof(Page));
                    if (!PossibleGo(selNode, p.Name,false))
                        return;
                    p.Parent = itsSetting.MainGroup;
                    p.Parent.Pages.Add(p);
                    AddPage(StructureTree, p);
                    Moved = true;
                }
                else if (e.Data.GetDataPresent(typeof(Group)))
                {
                    Group p = (Group)e.Data.GetData(typeof(Group));
                    if (!PossibleGo(selNode, p.Name,true))
                        return;
                    p.Parent = itsSetting.MainGroup;
                    p.Parent.Groups.Add(p);
                    AddGroup(StructureTree,p);
                    Moved = true;
                }
                
            }
        }
        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StructureTree.SelectedNode != null)
            {
                
                TreeNode trNode = StructureTree.SelectedNode;
                

                if (trNode.ImageIndex == 0)
                {
                    itsSetting.DeleteGroup(trNode.FullPath);
                    DisposeNode(trNode);
                }
                else
                {
                    if (itsSetting.PageCount == 1)
                    {
                        MessageBox.Show("페이지가 적어도 한개 있어야 합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    itsSetting.DeletePage(trNode.FullPath);
                    DisposeNode(trNode);
                }
            }
        }

        private void StructureTree_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode trNode = StructureTree.GetNodeAt(e.X,e.Y);
            if (trNode != null)
            {
                StructureTree.SelectedNode = trNode;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Page p = itsSetting.FindPage(StructureTree.SelectedNode.FullPath);
            ImageDialog imgD = new ImageDialog(p.BackgroundImage);
            imgD.ShowDialog();
            if (imgD.ok)
            {
                p.BackgroundImage = imgD.img;
            }
        }


        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

            if (txtBookName.Text.IndexOf('\\') >= 0)
            {
                MessageBox.Show("책이름에 \\가 들어가선 안됩니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Text = itsSetting.BookName;
            }
        }

        private void txtStructureName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (StructureTree.SelectedNode != null)
                    Modify(StructureTree.SelectedNode);
            }
        }

        private void btStructureToHyperGroup_Click(object sender, EventArgs e)
        {
        replay:
            string input = Forms.InputBox.InputString("이름 입력", "추가하실 즐겨찾기 이름을 입력해 주십시오.", false);
            if (input == null) return;
            if (input.IndexOf(@"\") >= 0)
            {
                MessageBox.Show("\\ 는 이름에 들어갈수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto replay;
            }
            HyperStructureAdd(itsSetting,input);
        }
        public DataTable GroupToTable(Group g,string Path,DataSet dSet)
        {
            DataTable t = new DataTable(Path + @"\" + g.Name);
            t.Columns.Add("Group", typeof(bool));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("PageIndex", typeof(int));
            t.Columns.Add("Description", typeof(string));
            dSet.Tables.Add(t);
            foreach (Group q in g.Groups)
            {
                t.Rows.Add(true, q.Name, 0, q.Explain);
                GroupToTable(q,Path + @"\" + g.Name,dSet);
            }
            foreach (Page p in g.Pages)
            {
                t.Rows.Add(false, p.Name, p.PageIndex, p.Explain);
            }
            return t;
        }
        public void HyperStructureAdd(Book bok,string TName)
        {
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(Application.StartupPath + @"\HyperStructures");
                if (!dinfo.Exists) Directory.CreateDirectory(dinfo.FullName);
                Group g = new Group(bok.MainGroup);
                g.Name = TName; 
                DataSet dSet = new DataSet(TName);
                GroupToTable(g, "", dSet);
                myEditor.HyperGroups.Add(g);
                myEditor.HyperStructure_MenuAdd(TName);
                dSet.WriteXml(dinfo.FullName + @"\" + TName + ".xml");
            }
            catch (Exception e)
            {
                MessageBox.Show("에러가 발생하였습니다\n" + e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
