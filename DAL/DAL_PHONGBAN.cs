using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_PHONGBAN : KetNoi
    {

        public DataTable getPhongBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONGBAN", connection);
            DataTable dtPHONGBAN = new DataTable();
            da.Fill(dtPHONGBAN);
            return dtPHONGBAN;
        }
        public bool ThemPhongBan(DTO_PHONGBAN phongBan)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO PHONGBAN VALUES ('{0}', '{1}',N'{2}','{3}',N'{4}')"
                , phongBan.Maphong, phongBan.Mabp, phongBan.Tenphong, phongBan.Ngaythanhlap,phongBan.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MAPHONG VARCHAR(6) PRIMARY KEY,
	MABP VARCHAR(8),
	TENPHONG NVARCHAR(20),
	NGAYTHANHLAP DATETIME,
	GHICHU NVARCHAR(70)
 */
        public bool SuaPhongBan(DTO_PHONGBAN phongBan)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE PHONGBAN " +
                "SET MABP='{0}' ,TENPHONG=N'{1}, NGAYTHANHLAP='{2}',GHICHU=N'{3}'" + "WHERE MAPHONG = '{4}'",
            phongBan.Mabp,phongBan.Tenphong, phongBan.Ngaythanhlap, phongBan.Ghichu, phongBan.Maphong);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaPhongBan(string maphong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM PHONGBAN WHERE MAPHONG = '{0}'", maphong);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
