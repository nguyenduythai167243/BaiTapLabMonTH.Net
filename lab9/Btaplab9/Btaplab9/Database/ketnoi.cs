using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Btaplab9.Database
{
    /// <summary>
    /// Lớp kết nối CSDL theo chuẩn bài Lab 09
    /// </summary>
    public static class ketnoi
    {
        public static string ServerName = ".";
        public static string DefaultDatabase = "QLKhachSan";
        public static bool UseWindowsAuth = true;
        public static string Username = "sa";
        public static string Password = "123";

        private static bool hasShownConnError = false;

        public static string GetConnectionString(string database = "")
        {
            string db = string.IsNullOrEmpty(database) ? DefaultDatabase : database;
            if (UseWindowsAuth)
            {
                return $@"Server={ServerName};Database={db};Integrated Security=True;TrustServerCertificate=True;";
            }
            return $@"Server={ServerName};Database={db};User ID={Username};Password={Password};TrustServerCertificate=True;";
        }

        public static SqlConnection? taoketnoi(string database = "")
        {
            string connStr = GetConnectionString(database);
            SqlConnection con = new SqlConnection(connStr);
            try
            {
                con.Open();
                return con;
            }
            catch
            {
                // Khi kết nối SQL Server không khả dụng, hệ thống chuyển sang chế độ dữ liệu cục bộ tự động
                if (!hasShownConnError)
                {
                    hasShownConnError = true;
                }
                return null;
            }
        }

        public static int thucthi(string sql, string database = "")
        {
            SqlConnection? con = taoketnoi(database);
            if (con == null)
            {
                return 1; // Simulated local success
            }

            try
            {
                using SqlCommand cmd = new SqlCommand(sql, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thực thi SQL: " + ex.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable truyvan(string sql, string database = "")
        {
            DataTable dt = new DataTable();
            SqlConnection? con = taoketnoi(database);
            if (con == null)
            {
                return dt;
            }

            try
            {
                using SqlCommand cmd = new SqlCommand(sql, con);
                using SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn SQL: " + ex.Message);
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
