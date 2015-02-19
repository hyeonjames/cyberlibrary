using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
namespace CyberLibrary2.Controls
{
    public partial class NetworkBoard : UserControl
    {
        public List<string[]> Groups;
        public Label[] BookNumber, BookName, BookTime;
        public string GName,BName;
        public NetworkBoard()
        {
            InitializeComponent();
        }

        private void NetworkBoard_Load(object sender, EventArgs e)
        {

            BookNumber = new Label[TableBook.RowCount];
            BookName = new Label[TableBook.RowCount];
            BookTime = new Label[TableBook.RowCount];
            int i = 0;
            for (i = 0; i < TableBook.RowCount; i++)
            {

                BookNumber[i] = new Label();
                BookName[i] = new Label();
                BookTime[i] = new Label();
                if (i == 0)
                {
                    BookNumber[i].Text = "책 번호";
                    BookName[i].Text = "책 이름";
                    BookTime[i].Text = "쓴 날짜";
                }
                BookNumber[i].AutoSize = BookName[i].AutoSize = BookTime[i].AutoSize = true;
                if (i > 0)
                {
                    BookName[i].Click += View;
                    BookName[i].Cursor = Cursors.Hand;
                }
                TableBook.Controls.Add(BookNumber[i]);
                TableBook.Controls.Add(BookName[i]);

                TableBook.Controls.Add(BookTime[i]);
                TableBook.SetRow(BookNumber[i], i);
                TableBook.SetRow(BookName[i], i);
                TableBook.SetRow(BookTime[i], i);
                TableBook.SetColumn(BookNumber[i], 0);
                TableBook.SetColumn(BookName[i], 1);
                TableBook.SetColumn(BookTime[i], 2);
            }
        }
        public void SetGroup(int Start,string BoardName,string GroupName,string Description,string[] Names,string[] Times,string[] Numbers)
        {
            int i = 0;
            this.Invoke(Component.SetText,labelDescription,Description);

            BName = BoardName;
            GName = GroupName; 
            for (i = 1; i < BookNumber.Length; i++)
            {
                this.Invoke(Component.SetText, BookNumber[i], Numbers[i-1]);
                this.Invoke(Component.SetText, BookName[i], Names[i-1]);
                this.Invoke(Component.SetText, BookTime[i], Times[i-1]);
            }
        }
        public void View(object sender, EventArgs e)
        {
            int index = Array.IndexOf(BookName, sender);
            if (index <= 0) return;
            if (BookName[index].Text != "")
            {
                Program.Client.Write(CyberLibrary2.Classes.ClientPacketType.Client_ShowBook, BName, GName, Convert.ToInt32(BookNumber[index].Text));
            }
        }
        public void SetGroup(int index, Book[] books)
        {
            int i = 0;
            this.Invoke(Component.SetText, labelDescription, "책 찾기 결과-");
            for (i = 1; i < TableBook.RowCount; i++)
            {
                if (books.Length <= index + i - 1)
                {
                    this.Invoke(Component.SetText, BookName[i], "");
                    this.Invoke(Component.SetText, BookNumber[i], "");
                    this.Invoke(Component.SetText, BookTime[i], "");
                }
                else
                {
                    this.Invoke(Component.SetText, BookName[i], books[i + index - 1].BookName);
                    this.Invoke(Component.SetText, BookNumber[i], books[i + index - 1].NetworkKey.ToString());
                    this.Invoke(Component.SetText, BookTime[i], books[i + index - 1].WriteTime.ToShortDateString());
                }
            }
        }
        
    }
}
