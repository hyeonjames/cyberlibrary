using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class HasteForm : Form
    {
        public string name;
        Book bk;
        public HasteForm(Book bok,string now)
        {
            bk = bok;
            InitializeComponent();
            foreach (Group p in bok.MainGroup.Groups)
                AddGroup(StructureTree, p);
            foreach (Page p in bok.MainGroup.Pages)
                AddPage(StructureTree, p);
            TreeNode tr=FindTreePage(StructureTree.Nodes,now);
            if (tr != null) StructureTree.SelectedNode = tr;
        }
        public TreeNode FindTreePage(TreeNodeCollection nodes,string Name)
        {
            TreeNode f;
            foreach (TreeNode n in nodes)
            {
                if (n.Text == Name && n.ImageIndex == 1)
                    return n;
                f = FindTreePage(n.Nodes, Name);
                if (f != null)
                    return f;
            }
            return null;
        }
        public void AddGroup(TreeNode Parent, Group g)
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

        private void btOK_Click(object sender, EventArgs e)
        {
            if (StructureTree.SelectedNode == null || StructureTree.SelectedNode.ImageIndex == 0)
            {
                MessageBox.Show("페이지를 선택해주십시오", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            name = StructureTree.SelectedNode.FullPath;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void StructureTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

    }
}
