using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Wlcm_text_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //آغاز ارتباط با پایگاه داده
            string connectionString = "Data Source=simlib.db;Version=3;"; //تعیین نام فایل پایگاه داده و نسخه آن
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            //ایجاد فایل پایگاه داده و اضافه کردن کاربر


            //دستورات ایجاد جدول و درج اطلاعات در جدول
            string createTableSql = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, name TEXT, pass TEXT, UNIQUE (id, name, pass))";
            string insertSql = "INSERT OR IGNORE INTO users (name, pass) VALUES (@name, @pass) ";

            //ارسال دستور ایجاد جدول به پایگاه داده
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
            //ارسال دستور افزودن اطلاعات به پایگاه داده
            SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

            insertCommand.Parameters.AddWithValue("@name", "admin");
            insertCommand.Parameters.AddWithValue("@pass", "admin");


            try
            {

                //آغاز ارتباط 
                connection.Open();
                //اجرای دستور ایجاد جدول
                createTableCommand.ExecuteNonQuery();
                //اجرای دستور افزودن کاربر
                insertCommand.ExecuteNonQuery();
                //آزمایش درستی پایگاه داده
                login_status.Text = "Database Connection Successful!";
                
                


            }
            catch (Exception ex)

            {
                login_status.Text = $"Error: {ex.Message}";
            }
            finally
            {
                
                connection.Close();
                


            }
            
            

            //آغاز ارتباط با پایگاه داده
        }

        private async void login_button_Click(object sender, EventArgs e)
        {
            login_status.Text = "";

            //آغاز ارتباط با پایگاه داده
            string connectionString = "Data Source=simlib.db;Version=3;"; //تعیین نام فایل پایگاه داده و نسخه آن
            SQLiteConnection connection = new SQLiteConnection(connectionString);


            SQLiteCommand sqCommand = (SQLiteCommand)connection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM users LIMIT 1";

            connection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();

            sqReader.Read();
            object[] creds = new object[3];
            int quant = sqReader.GetValues(creds);

            if (username_box.Text != string.Empty || pass_box.Text != string.Empty)
            {
                if (username_box.Text == creds[1].ToString() && pass_box.Text == creds[2].ToString())
                {
                    login_status.Text = "Login Successfull!";
                    sqReader.Close();   
                    await Task.Delay(2000);
                    this.Hide();
                    main_lib home = new main_lib();
                    home.Show();
                }
                else
                {
                    //اگر اطلاعات ورود درست نباشد صفحه را بلرزاند
                    Shake(this);
                    sqReader.Close();
                    login_status.Text = "Username or Password Incrrect!";
                }
            }
            else
            {
                sqReader.Close();
                login_status.Text = "Empty Values Are Not Accepted!";
            }
            
            //login_status.Text = creds[1].ToString();
                
            //تابع ایجاد لزرش در فرم با جابجایی از محل اصلی 
            void Shake(Form form)
            {
                var original = form.Location;
                var rnd = new Random(1337);
                const int shake_amp = 10;
                for (int i = 0; i < shake_amp; i++)
                {
                    form.Location = new Point(original.X + rnd.Next(-shake_amp, shake_amp), original.Y + rnd.Next(-shake_amp, shake_amp));
                    System.Threading.Thread.Sleep(20);
                }
                form.Location = original;

            }
            





        }
    }
}
