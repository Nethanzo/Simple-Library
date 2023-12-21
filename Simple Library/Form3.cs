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
            
            DeleteEntryInTable("books", "id", id_to_remove_box.Text.ToString());


        }

        private void DeleteEntryInTable(string tableName, string pKeyName, string pKeyValue)
        {
            //آغاز ارتباط با پایگاه داده
            string connectionString = "Data Source=simlib.db;Version=3;"; //تعیین نام فایل پایگاه داده و نسخه آن
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand cmd_1 = connection.CreateCommand();
            cmd_1.CommandText = $"DELETE FROM {tableName} WHERE {pKeyName} = @pKeyValue";
            cmd_1.Parameters.AddWithValue("@pKeyValue", pKeyValue);
            System.Diagnostics.Debug.WriteLine(cmd_1.CommandText);
            try
            {
                int rows = cmd_1.ExecuteNonQuery();
                remove_status.Text = rows.ToString() + " Row Deleted!";
                cancel_remove.Text = "Close";
            }
            catch (Exception ex)
            {
                remove_status.Text = ex.ToString();
            }
            connection.Close();
        }


    }

}