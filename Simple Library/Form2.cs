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

namespace Simple_Library
{
    public partial class manual_add_book : Form
    {
        public manual_add_book()
        {
            InitializeComponent();
        }

        private void cancel_adding_button_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void add_book_button_Click(object sender, EventArgs e)
        {
            //آغاز ارتباط با پایگاه داده
            string connectionString = "Data Source=simlib.db;Version=3;"; //تعیین نام فایل پایگاه داده و نسخه آن
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            //ایجاد فایل پایگاه داده و اضافه کردن کاربر


            //دستورات ایجاد جدول و درج اطلاعات در جدول
            string createTableSql = "CREATE TABLE IF NOT EXISTS books (id INTEGER PRIMARY KEY, bookname TEXT, author TEXT, publisher TEXT, isbn TEXT, pubyear INT, UNIQUE(isbn))";
            string insertSql = "INSERT OR IGNORE INTO books (bookname, author, publisher, isbn, pubyear) VALUES (@bookname, @author, @publisher, @isbn, @pubyear) ";

            //ارسال دستور ایجاد جدول به پایگاه داده
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
            //ارسال دستور افزودن اطلاعات به پایگاه داده
            SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

            insertCommand.Parameters.AddWithValue("@bookname", enter_title_txtbx.Text);
            insertCommand.Parameters.AddWithValue("@author", enter_author_txtbx.Text);
            insertCommand.Parameters.AddWithValue("@publisher", enter_pub_txtbx.Text);
            insertCommand.Parameters.AddWithValue("@isbn", enter_isbn_txtbx.Text);
            insertCommand.Parameters.AddWithValue("@pubyear", enter_pubdate_txtbx.Text);

            try
            {

                //آغاز ارتباط 
                connection.Open();
                //اجرای دستور ایجاد جدول
                createTableCommand.ExecuteNonQuery();
                insertCommand.ExecuteNonQuery();
                //آزمایش درستی پایگاه داده
                add_book_status_label.Text = "Success!";
                cancel_adding_button.Text = "Close";




            }
            catch (Exception ex)

            {
                add_book_status_label.Text = $"Error: {ex.Message}";
            }
            finally
            {

                connection.Close();



            }
        }
    }
}
