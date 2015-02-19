using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using CyberLibrary2.Controls;
using CyberLibrary2.Classes;
namespace CyberLibrary2.Forms
{
    public partial class NetworkLibForm : Form
    {
        public Color FontColor, ChatBackColor;
        public Book_Read BookRead;
        public BookEditor bookEdit;
        public bool FindMode;
        public string[] FindBookNames, FindBookNumbers, FindBookTimes;
        public NetworkLibForm()
        {
            InitializeComponent();
            BookRead = new Book_Read();
            bookEdit = new BookEditor();
            this.BookRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BookRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BookRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookRead.Location = new System.Drawing.Point(3, 33);
            this.BookRead.Name = "BookRead";
            this.BookRead.Size = new System.Drawing.Size(592, 246);
            this.BookRead.TabIndex = 0;
            this.bookEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bookEdit.Location = new System.Drawing.Point(0, 0);
            this.bookEdit.Name = "bookEdit";
            this.bookEdit.Size = new System.Drawing.Size(492, 306);
            this.bookEdit.TabIndex = 0;
            PanelShowBook.Controls.Add(BookRead);
            PanelWrite.Controls.Add(bookEdit);
            CommentBoard.SelectedCommentChanged += CommentBoard_SelectCommentChanged;
            ShowPanel(null);
            foreach (FontFamily family in FontFamily.Families)
            {
                comboFontNames.Items.Add(family.Name);
            }

            comboFontNames.SelectedIndex = comboFontNames.FindString("굴림");
            numericFontSize.Value = 9;
            ChatBackColor = richChatContext.BackColor;
            FontColor = Color.Black;
        }
        public int PageIndex
        {
            get
            {
                return RealPageIndex;
            }
            set
            {
                RealPageIndex = value;
                labelViewPage.Text = (value+1).ToString();
            }
        }
        public int BookIndex,RealPageIndex;
        public string NowBoard, NowGroup;
        public bool ModifyBook;
        public void UserCome(object[] data)
        {
            UserList.Items.Add(new ListViewItem(data[0].ToString(),(int)data[1]));
            this.Invoke(Component.SetOption, this, OptionType.ChatAdd, new object[]{data[0].ToString() + "님이 입장하셨습니다.",new Font("굴림",9), Color.BlueViolet,richChatContext.BackColor});
        }
        public void SetNotice(string Context)
        {
            labelServerNotice.Text = Context;
        }
        public void ShowPanel(Panel panel)
        {
            splitContainer2.Panel2.Controls.Clear();
            if (panel != null && panel is Panel)
            {
                splitContainer2.Panel2.Controls.Add(panel);
                
                panel.SetBounds(0, 0, splitContainer2.Panel2.Width, splitContainer2.Panel2.Height);
                panel.Show();
                panel.Invalidate();
            }
        }
        public void SetErrorMessage(string Context)
        {
            labelNotice.Text = Context;
        }
        

        private void txtSendMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSendMsg.Text == "") txtSendMsg.Focus();
            else
            {
                if (e.KeyChar == '\n' || e.KeyChar == '\r')
                {
                    FontStyle fStyle = (chkBold.Checked ? FontStyle.Bold : FontStyle.Regular) | (chkItalic.Checked ? FontStyle.Italic : FontStyle.Regular) | (chkUnderLine.Checked ? FontStyle.Underline : FontStyle.Regular) | (chkStrikeout.Checked ? FontStyle.Strikeout : FontStyle.Regular);
                    Font font = new Font(comboFontNames.Text, (float)numericFontSize.Value, fStyle);
                    if (font == null) return;
                    Program.Client.Write(ClientPacketType.Client_Chat, txtSendMsg.Text, font, FontColor, ChatBackColor);
            
                    ChatAdd(" > " + txtSendMsg.Text, font, FontColor, ChatBackColor);
                    txtSendMsg.Text = "";
                }
            }
        }
        public void ChatAdd(params object[] data)
        {
            richChatContext.SelectionFont = (Font)data[1];
            richChatContext.SelectionColor = (Color)data[2];
            richChatContext.SelectionBackColor = (Color)data[3];
            richChatContext.AppendText(data[0].ToString() + "\n");
            richChatContext.ScrollToCaret();
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            if (txtSendMsg.Text == "") txtSendMsg.Focus();
            FontStyle fStyle = (chkBold.Checked ? FontStyle.Bold : FontStyle.Regular) | (chkItalic.Checked ? FontStyle.Italic : FontStyle.Regular) | (chkUnderLine.Checked ? FontStyle.Underline : FontStyle.Regular) | (chkStrikeout.Checked ? FontStyle.Strikeout : FontStyle.Regular);
            Font font = new Font(comboFontNames.Name, (float)numericFontSize.Value,fStyle);
            if (font == null) return;
            

            Program.Client.Write(ClientPacketType.Client_Chat, txtSendMsg.Text,font,FontColor,ChatBackColor);
            ChatAdd(" > " + txtSendMsg.Text,font,FontColor,ChatBackColor);

            txtSendMsg.Text = "";
            
        }

        private void MenuBoard_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.ImageIndex == 2)
            {
                ShowPanel(PanelChatting);
            }
            else if (e.Node.ImageIndex == 1)
            {
                Program.Client.Write(ClientPacketType.Client_ShowGroup,e.Node.Parent.Text, e.Node.Text,0);
                NowBoard = e.Node.Parent.Text;
                NowGroup = e.Node.Text;
            }
        }

        private void NetworkLibForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Client.Logout();
            Program.LibraryForm.Show();
        }

        public void PageSet(int index)
        {
            if (index < 0)
            {
                PageIndex = 0;
                return;
            }
            PageIndex = index;
            if (FindMode)
            {
                BookBoard.SetGroup(index * 10,NowBoard,NowGroup,"찾기 결과 입니다.",FindBookNames,FindBookTimes,FindBookNumbers);
            }
            else
                Program.Client.Write(ClientPacketType.Client_ShowGroup, NowBoard, NowGroup,index);
        }
        private void btNextPage_Click(object sender, EventArgs e)
        {
            PageSet(++PageIndex);
        }

        private void btPrevPage_Click(object sender, EventArgs e)
        {
            PageSet(--PageIndex);
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            Program.Client.Write(ClientPacketType.Client_BookWriteCheck,NowBoard,NowGroup);
            bookEdit.mybook = new Book();
            bookEdit.PageSet(1);
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (!ModifyBook) Program.Client.Write(ClientPacketType.Client_BookWrite, NowBoard, NowGroup, bookEdit.myBook, PageIndex);
            else if (ModifyBook)
            {
                Program.Client.Write(ClientPacketType.Client_ModifyBook, bookEdit.myBook.NetworkKey, bookEdit.myBook);
                ModifyBook = false;
            }
        }


        private void btRemove_Click(object sender, EventArgs e)
        {
            Program.Client.Write(ClientPacketType.Client_ShowGroup, NowBoard, NowGroup,PageIndex);
        }

        private void btCommentAdd_Click(object sender, EventArgs e)
        {
            Program.Client.Write(ClientPacketType.Client_WriteComment,BookRead.myBook.NetworkKey, txtComment.Text);
            txtComment.Text = "";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (CommentBoard.SelectedComment != null && MessageBox.Show("정말로 삭제하시겠습니까?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.Client.Write(ClientPacketType.Client_DelComment, BookRead.myBook.NetworkKey,CommentBoard.SelectedComment.myTime);
            }
        }

        private void btSendToServer_Click(object sender, EventArgs e)
        {
            string input = InputBox.InputString("Write Letter", "서버에게 보낼 메세지를 입력해주세요!", false);
            if (input != null)
            {
                Program.Client.Write(ClientPacketType.Client_Letter, input);
            }
        }

        private void CommentBoard_SelectCommentChanged(object sender, EventArgs e)
        {
            if (CommentBoard.SelectedComment != null && CommentBoard.SelectedComment.name == Program.Client.myName)
            {
                btDel.Enabled = true;
            }
            else
            {
                btDel.Enabled = false;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            PageSet(PageIndex);
        }

        private void btDelBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.Client.Write(ClientPacketType.Client_DelBook, BookRead.myBook.NetworkKey);
                Program.Client.Write(ClientPacketType.Client_ShowGroup, NowBoard, NowGroup, BookIndex / 10);
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            Program.Client.Write(ClientPacketType.Client_ModifyBookCheck, BookRead.myBook.NetworkKey);
        }

        private void PanelNotice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CommentBoard_Load(object sender, EventArgs e)
        {

        }

        private void PanelChatting_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.Color = ChatBackColor;
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                ChatBackColor = cDialog.Color;
            }
        }

        private void btFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.Color = FontColor;
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                FontColor = cDialog.Color;
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (!chkFindName.Checked && !chkTransfer.Checked && !chkWriter.Checked) return;
            if (txtFind.Text == "") txtFind.Focus();
            Program.Client.Write(ClientPacketType.Client_FindBook, NowBoard,NowGroup,txtFind.Text, chkFindName.Checked, chkWriter.Checked, chkTransfer.Checked);
        }

        private void PanelShowBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelShowBook_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
