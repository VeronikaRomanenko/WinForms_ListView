using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_ListView
{
    public partial class Form1 : Form
    {
        ImageList large_gellary = null;
        ImageList small_gellary = null;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            listView1.DoubleClick += ListView1_DoubleClick;
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            ListView table = sender as ListView;
            table.Items.Remove(table.SelectedItems[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            ListViewItem linus = new ListViewItem("Torvald Linus");
            listView1.Items.Add(linus);
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[0].SubItems.Add("52");
            listView1.Items[0].SubItems.Add("Linux OC");
            listView1.Items[0].SubItems.Add("250000000");
            ListViewItem steve = new ListViewItem("Steve Voznyak");
            listView1.Items.Add(steve);
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[1].SubItems.Add("65");
            listView1.Items[1].SubItems.Add("Apple 2 Computer");
            listView1.Items[1].SubItems.Add("830000000");
            ListViewItem jobs = new ListViewItem("Steve Jobs");
            listView1.Items.Add(jobs);
            listView1.Items[2].ImageIndex = 2;
            listView1.Items[2].SubItems.Add("60");
            listView1.Items[2].SubItems.Add("Next OS");
            listView1.Items[2].SubItems.Add("1830000000");
            ListViewItem mark = new ListViewItem("Mark Zukerberg");
            listView1.Items.Add(mark);
            listView1.Items[3].ImageIndex = 3;
            listView1.Items[3].SubItems.Add("37");
            listView1.Items[3].SubItems.Add("The Facebook");
            listView1.Items[3].SubItems.Add("52000000000");
            ListViewItem ilon = new ListViewItem("Ilon Mask (best)");
            listView1.Items.Add(ilon);
            listView1.Items[4].ImageIndex = 4;
            listView1.Items[4].SubItems.Add("47");
            listView1.Items[4].SubItems.Add("Rebranding TM Tesla");
            listView1.Items[4].SubItems.Add("78000000000");
            //ToolStripMenuItem detail = new ToolStripMenuItem("Detail");
            //contextMenuStrip1.Items.Add(detail);
            contextMenuStrip1.Items.Add("Detail");
            contextMenuStrip1.Items.Add("Tile");
            contextMenuStrip1.Items.Add("LargeIcon");
            contextMenuStrip1.Items.Add("SmallIcon");
            contextMenuStrip1.Items.Add("List");
            foreach (var item in contextMenuStrip1.Items)
            {
                (item as ToolStripMenuItem).Click += Form1_Click;
            }
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Columns.Add("Name");
            listView1.Columns[0].Width = 300;
            listView1.Columns.Add("Age");
            listView1.Columns[0].Width = 300;
            listView1.Columns.Add("Работа");
            listView1.Columns[0].Width = 300;
            listView1.Columns.Add("Состояние (Forbs)");
            listView1.Columns[0].Width = 300;
            large_gellary = new ImageList();
            small_gellary = new ImageList();
            Bitmap linusImg = new Bitmap("1.bmp");
            Bitmap steveImg = new Bitmap("2.bmp");
            Bitmap jobsImg = new Bitmap("3.bmp");
            Bitmap markImg = new Bitmap("4.bmp");
            Bitmap ilonImg = new Bitmap("5.bmp");
            large_gellary.Images.Add(linusImg);
            large_gellary.Images.Add(steveImg);
            large_gellary.Images.Add(jobsImg);
            large_gellary.Images.Add(markImg);
            large_gellary.Images.Add(ilonImg);
            small_gellary.Images.Add(linusImg);
            small_gellary.Images.Add(steveImg);
            small_gellary.Images.Add(jobsImg);
            small_gellary.Images.Add(markImg);
            small_gellary.Images.Add(ilonImg);
            large_gellary.ImageSize = new Size(100, 100);
            small_gellary.ImageSize = new Size(50, 50);
            listView1.LargeImageList = large_gellary;
            listView1.SmallImageList = small_gellary;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Detail":
                    listView1.View = View.Details;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                case "LargeIcon":
                    listView1.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                default:
                    break;
            }
        }
    }
}
