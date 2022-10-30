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
    public class DAL_THAYDOIBANGLUONG : KetNoi
    {

        public DataTable getSoThaiSan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THAYDOIBANGLUONG", connection);
            DataTable dtTHAYDOIBANGLUONG = new DataTable();
            da.Fill(dtTHAYDOIBANGLUONG);
            return dtTHAYDOIBANGLUONG;
        }
        public bool ThemSoThaiSan(DTO_THAYDOIBANGLUONG tdbl)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO THAYDOIBANGLUONG VALUES ('{0}', '{1}','{2}','{3}',N'{4}')"
                , tdbl.Manv, tdbl.Maluong, tdbl.Maluongmoi, tdbl.Ngaysua,tdbl.Lydo);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MANV INT,
	MALUONG VARCHAR(8),
	MALUONGMOI VARCHAR(8),
	PRIMARY KEY (MANV, MALUONG, MALUONGMOI),
	NGAYSUA DATETIME,
	LYDO NVARCHAR(70)
 */
        public bool SuaTHAYDOIBANGLUONG(DTO_THAYDOIBANGLUONG tdbl)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE THAYDOIBANGLUONG " +
                "SET NGAYSUA='{0}, LYDO=N'{1}'" + "WHERE MANV = '{2}' AND MALUONG='{3}' AND MALUONGMOI='{4}' ",
            tdbl.Ngaysua, tdbl.Lydo,tdbl.Manv, tdbl.Maluong, tdbl.Maluongmoi);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaTHAYDOIBANGLUONG(int manv,string maluong,string maluongmoi)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM THAYDOIBANGLUONG WHERE MANV = '{0}' AND MALUONG='{1}' AND MALUONGMOI='{2}')", manv,maluong,maluongmoi);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
