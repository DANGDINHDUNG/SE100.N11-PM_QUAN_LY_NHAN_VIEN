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
    public class DAL_BANGCHAMCONG : KetNoi
    {

        public DataTable getBangChamCong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BANGCHAMCONG", connection);
            DataTable dtBANGCHAMCONG = new DataTable();
            da.Fill(dtBANGCHAMCONG);
            return dtBANGCHAMCONG;
        }
        public bool ThemBangChamCong(DTO_BANGCHAMCONG bangChamCong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO BANGCHAMCONG VALUES " +
                "('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',N'{9}')"
                , bangChamCong.Manv, bangChamCong.Thang, bangChamCong.Nam, 
                bangChamCong.Maluong, bangChamCong.Makt, bangChamCong.Makl,
                bangChamCong.Songaycong,bangChamCong.Songaynghi,bangChamCong.Sogiolamthem,bangChamCong.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MANV INT,
	THANG INT,
	NAM INT,
	PRIMARY KEY (MANV, THANG, NAM),
	MALUONG VARCHAR(8),
	MAKT INT,
	MAKL INT,
	SONGAYCONG INT,
	SONGAYNGHI INT,
	SOGIOLAMTHEM INT,
	GHICHU NVARCHAR(60)
 */
        public bool SuaBangChamCong(DTO_BANGCHAMCONG bangChamCong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE BANGCHAMCONG " +
                "SET MALUONG='{0}, MAKT='{1}',MAKL='{2}',SONGAYCONG='{3}'" +
               ",SONGAYNGHI='{4}',SOGIOLAMTHEM='{5}',GHICHU=N'{6}' " + "WHERE MANV = '{7}' AND THANG ='{8}' AND NAM ='{9}'",
               bangChamCong.Maluong, bangChamCong.Makt, bangChamCong.Makl,
                bangChamCong.Songaycong, bangChamCong.Songaynghi, bangChamCong.Sogiolamthem, bangChamCong.Ghichu, bangChamCong.Manv, bangChamCong.Thang, bangChamCong.Nam);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaBangChamCong(int manv,int thang,int nam)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM BANGCHAMCONG WHERE MANV = '{0}' AND THANG ='{1}' AND NAM ='{2}'", manv,thang,nam);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
