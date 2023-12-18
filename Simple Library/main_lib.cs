using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Library
{
    public partial class main_lib : Form
    {
        public main_lib()
        {
            InitializeComponent();

            //تنظیم لیست
            book_list_table.View = View.Details;
            book_list_table.Columns.Add("#", 150, HorizontalAlignment.Left);
            book_list_table.Columns.Add("Book Name", 150, HorizontalAlignment.Left);
            book_list_table.Columns.Add("Author", 150, HorizontalAlignment.Left);
            book_list_table.Columns.Add("ISBN", 150, HorizontalAlignment.Left);
            book_list_table.Columns.Add("Publisher", 150, HorizontalAlignment.Left);
            book_list_table.Columns.Add("Pub. Year", 150, HorizontalAlignment.Left);


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about_splash = new About();
            about_splash.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void main_lib_Load(object sender, EventArgs e)
        {
            update_db();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manual_add_book addmanual = new manual_add_book();
            addmanual.ShowDialog();
            this.update_db();
            
        }
        private void update_db()
        {
            //آغاز ارتباط با پایگاه داده
            string connectionString = "Data Source=simlib.db;Version=3;"; //تعیین نام فایل پایگاه داده و نسخه آن
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            //ایجاد فایل پایگاه داده و اضافه کردن کاربر


            //دستورات ایجاد جدول و درج اطلاعات در جدول
            string createTableSql = "CREATE TABLE IF NOT EXISTS books (id INTEGER PRIMARY KEY, bookname TEXT, author TEXT, publisher TEXT, isbn TEXT, pubyear INT, UNIQUE(isbn))";
            //string insertSql = "INSERT OR IGNORE INTO books (bookname, author, publisher, isbn, pubyear) VALUES (@bookname, @author, @publisher, @isbn, @pubyear) ";

            //ارسال دستور ایجاد جدول به پایگاه داده
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
            //ارسال دستور افزودن اطلاعات به پایگاه داده
            //SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);



            try
            {

                //آغاز ارتباط 
                connection.Open();
                //اجرای دستور ایجاد جدول
                createTableCommand.ExecuteNonQuery();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM books", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //آزمایش درستی پایگاه داده
                mainlib_status.Text = "Database Connection Successful!";
                
                book_list_table.Items.Clear();
                book_list_table.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = row["id"].ToString();
                    item.SubItems.Add(row["bookname"].ToString());
                    item.SubItems.Add(row["author"].ToString());
                    item.SubItems.Add(row["isbn"].ToString());
                    item.SubItems.Add(row["publisher"].ToString());
                    item.SubItems.Add(row["pubyear"].ToString());
                    book_list_table.Items.Add(item);
                }
                this.book_list_table.EndUpdate();

                connection.Close();






            }
            catch (Exception ex)

            {
                mainlib_status.Text = $"Error: {ex.Message}";
            }
            finally
            {

                connection.Close();



            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_dialog removebook = new delete_dialog();
            removebook.ShowDialog();
            this.update_db();
        }
    }
}
