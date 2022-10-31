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
    public class DAL_BANGLUONG : KetNoi
    {

        public DataTable getBangLuong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BANGLUONG", connection);
            DataTable dtBANGLUONG = new DataTable();
            da.Fill(dtBANGLUONG);
            return dtBANGLUONG;
        }
        public bool ThemBangLuong(DTO_BANGLUONG bangLuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO BANGLUONG VALUES ('{0}', '{1}','{2}','{3}',N'{4}')"
                , bangLuong.Maluong, bangLuong.Lcb, bangLuong.Phucapphucvu, bangLuong.Phucapkhac,bangLuong.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
    MALUONG VARCHAR(8) PRIMARY KEY,
	LCB MONEY,
	PHUCAPCHUCVU MONEY,
	PHUCAPKHAC MONEY,
	GHICHU NVARCHAR(80)
 */
        public bool SuaBangLuong(DTO_BANGLUONG bangLuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE BANGLUONG " +
                "SET LCB='{0}',PHUCAPPHUCVU='{1}',PHUCAPKHAC='{2}',GHICHU=N'{3}'" + "WHERE MALUONG = '{4}'",
            bangLuong.Lcb, bangLuong.Phucapphucvu, bangLuong.Phucapkhac, bangLuong.Ghichu, bangLuong.Maluong);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaBangLuong(string maluong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM BANGLUONG WHERE MAUONG = '{0}')", maluong);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
