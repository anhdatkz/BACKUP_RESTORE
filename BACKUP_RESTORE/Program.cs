using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BACKUP_RESTORE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "DESKTOP-JLJ2TBG\\ANHDAT";
        public static String username;
        public static String password;
        public static String database = "LTM";
        public static String databasename = "";
        public static String defaultPath = "C:\\Program Files\\Microsoft SQL Server\\MSSQL14.ANHDAT\\MSSQL\\Backup\\";

        public static Form_DangNhap loginForm;
        public static Form_Main frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                        Program.username + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        //Truy vấn nhanh......Không cho sửa,Chỉ cho phép đi xuống.
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            conn.Close();
            SqlDataReader myreader = null;
            //Program.conn = new SqlConnection(connectionstring);
            //Cmommand để chạy câu truy vấn
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            //sqlcmd.Connection = Program.conn;
            //sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            //Thời gian chờ tối đa 10'
            sqlcmd.CommandTimeout = 600;
            // Kiểm tra trạng thái đóng hay mở
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
            myreader.Close();
        }

        //public static int ExecSqlNonQuery(String cmd, String connectionstring)
        //{
        //    conn = new SqlConnection(connectionstring);
        //    SqlCommand Sqlcmd = new SqlCommand();
        //    Sqlcmd.Connection = conn;
        //    Sqlcmd.CommandText = cmd;
        //    Sqlcmd.CommandType = CommandType.Text;
        //    Sqlcmd.CommandTimeout = 300;
        //    if (conn.State == ConnectionState.Closed) conn.Open();
        //    try
        //    {
        //        Sqlcmd.ExecuteNonQuery();
        //        conn.Close();
        //        return 1;
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        conn.Close();
        //        return 0;
        //    }
        //}

        public static int ExecSqlNonQuery(String strlenh, String connectionString, String errStr)
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(errStr + "\n" + ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new Form_DangNhap();
            Application.Run(loginForm);
        }
    }
}
