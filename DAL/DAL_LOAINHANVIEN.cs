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
    public class DAL_LOAINHANVIEN : KetNoi
    {

        public DataTable getLoaiNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAINHANVIEN", connection);
            DataTable dtLOAINHANVIEN = new DataTable();
            da.Fill(dtLOAINHANVIEN);
            return dtLOAINHANVIEN;
        }
        public bool ThemLoaiNhanVien(DTO_LOAINHANVIEN loaiNhanVien)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO LOAINHANVIEN VALUES ('{0}', N'{1}','{2}'"
                , loaiNhanVien.Maloainv, loaiNhanVien.Tenloainv, loaiNhanVien.Mucluongcoban);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MALOAINV VARCHAR(10) PRIMARY KEY,
	TENLOAINV NVARCHAR(30),
	MUCLUONGCOBAN MONEY,
 */
        public bool SuaLoaiNhanVien(DTO_LOAINHANVIEN loaiNhanVien)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE LOAINHANVIEN " +
                "SET TENLOAINV=N'{0}, MUCLUONGCOBAN='{1}'" + "WHERE MALOAINV = '{2}'",
            loaiNhanVien.Tenloainv, loaiNhanVien.Mucluongcoban, loaiNhanVien.Maloainv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaLoaiNhanVien(string maloainv)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM LOAINHANVIEN WHERE MALOAINV = '{0}'", maloainv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
