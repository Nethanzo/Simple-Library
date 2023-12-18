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
using System.Xml.Linq;

namespace Simple_Library
{
    public partial class delete_dialog : Form
    {
        public delete_dialog()
        {
            InitializeComponent();
        }

        private void cancel_remove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_to_remove_Click(object sender, EventArgs e)
        {
            /*
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
                SQLiteCommand removerowCommand = new SQLiteCommand("DELETE FROM books WHERE id='" + id_to_remove_box.ToString() + "'", connection);
               
              
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
    
   

*/
        }
        }

    }