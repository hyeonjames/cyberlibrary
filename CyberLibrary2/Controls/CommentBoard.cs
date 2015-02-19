using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
namespace CyberLibrary2
{

    public delegate void SelectComment(object sender, EventArgs e);
    public partial class CommentBoard : UserControl
    {
        public Comments comts;
        public SelectComment SelectedCommentChanged;
        public Comment SelectedComment
        {
            get
            {
                if (CommentView.SelectedIndices.Count <= 0) return null;
                return comts.Datas[CommentView.SelectedIndices[0]];
            }
        }
        public CommentBoard()
        {
            InitializeComponent();
            comts = new Comments();
        }
        

        public void AddComment(string password,string nick, string context)
        {
            Comment c = new Comment();
            c.name = nick;
            c.pwd = password;
            c.context = context;
            c.myTime = DateTime.Now;
            comts.Datas.Add(c);
            CommentView.Items.Add(new ListViewItem(new string[] {  c.context,c.name, string.Format("0일전 {0:d2}:{1:d2}",c.myTime.Hour,c.myTime.Minute) }));
        }
        public bool DelComment(int index,string password)
        {
            if (comts[index].pwd == password)
            {
                comts.Datas.RemoveAt(index);
                CommentView.Items.RemoveAt(index);
                
                return true;
            }
            return false;
        }
        public void SetComment(Comments v)
        {
            CommentView.Items.Clear();
            foreach (Comment at in v.Datas)
            {
                TimeSpan bk = DateTime.Now - at.myTime;
                CommentView.Items.Add(new ListViewItem(new string[] { at.context, at.name, string.Format("{0}일전 {1:d2}:{2:d2}", (int)bk.Days, at.myTime.Hour, at.myTime.Minute) }));
            }
            comts = v;
        }
        private void CommentView_Resize(object sender, EventArgs e)
        {
            ColumnContext.Width = CommentView.Width - 255;
        }

        private void CommentView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedCommentChanged != null) SelectedCommentChanged(this,e);
        }
        public void CommentClear()
        {
            CommentView.Items.Clear();
        }
    }
    [Serializable]
    public class Comment
    {
        public string name,context,pwd;
        public DateTime myTime;
    }
    [Serializable]
    public class Comments
    {
        public List<Comment> Datas;
        
        public Comments()
        {
            Datas = new List<Comment>();
        }
        public Comment this[int index]
        {
            get
            {
                return Datas[index];
            }
            set
            {
                Datas[index] = value;
            }
        }
        
    }
}
