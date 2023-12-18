using System;
using System.Windows.Forms;

//به عنوان یک پایگاه داده ساده 
//SQLite
//را انتخاب کردم
//لازم است کتابخانه 
//System.Data.SQLite
//به عنوان رفرنس اضافه شود
//روش بهتر استفاده از ابزار ناگت از منوی تولز است

namespace Simple_Library
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {







            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
