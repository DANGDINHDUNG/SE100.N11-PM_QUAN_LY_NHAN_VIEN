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
    public class DAL_LSCHINHSUA : KetNoi
    {

        public DataTable getLSChinhSua()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LSCHINHSUA", connection);
            DataTable dtLSCHINHSUA = new DataTable();
            da.Fill(dtLSCHINHSUA);
            return dtLSCHINHSUA;
        }
        public bool ThemLSChinhSua(DTO_LSCHINHSUA ls)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO LSCHINHSUA VALUES ('{0}','{1}', '{2}',N'{3}'" +
                ",'{4}',N'{5}',N'{6}','{7}'," +
                "N'{8}',N'{9}','{10}',N'{11}','{12}','{13}','{14}','{15}',N'{16}',N'{17}','{18}')"
                ,ls.Manv, ls.Maphong, ls.Maluong, ls.Hoten, ls.Ngaysinh,
                ls.Gioitinh, ls.Dantoc, ls.Cmnd_cccd, ls.Noicap, ls.Chucvu, ls.Maloainv,
                ls.Loaihd, ls.Thoigian, ls.Ngaydangki, ls.Ngayhethan, ls.Sdt, ls.Hocvan, ls.Ghichu,ls.Ngaychinhsua);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
    MANV INT IDENTITY(1,1) PRIMARY KEY,
	MAPHONG VARCHAR(6),
	MALUONG VARCHAR(8),
	HOTEN NVARCHAR(70),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(3),
	DANTOC NVARCHAR(12),
	CMND_CCCD VARCHAR(12),
	NOICAP NVARCHAR(20),
	CHUCVU NVARCHAR(25),
	MALOAINV VARCHAR(10),
	LOAIHD NVARCHAR(20),
	THOIGIAN INT,
	NGAYKY DATETIME,
	NGAYHETHAN DATETIME,
	SDT VARCHAR(10),
	HOCVAN NVARCHAR(20),
	GHICHU NVARCHAR(60)
 */
        public bool SuaLSChinhSua(DTO_LSCHINHSUA ls)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE LSCHINHSUA " +
                "SET MAPHONG='{0}, MALUONG='{1}',HOTEN=N'{2}',NGAYSINH='{3}',GIOITINH=N'{4}',DANTOC='{5}',CMND_CCCD='{6}'" +
                "NOICAP=N'{7}',CHUCVU=N'{8}',MALOAINV='{9}',LOAIHD=N'{10}',THOIGIAN='{11}','NGAYKY='{12}',NGAYHETHAN='{13}'" +
                "SDT='{14}',HOCVAN=N'{15}',GHICHU='{16}',NGAYCHINHSUA='{17}'" + "WHERE MANV = '{18}' AND MACS='{19}'",
            ls.Maphong, ls.Maluong, ls.Hoten, ls.Ngaysinh,
                ls.Gioitinh, ls.Dantoc, ls.Cmnd_cccd, ls.Noicap, ls.Chucvu, ls.Maloainv,
                ls.Loaihd, ls.Thoigian, ls.Ngaydangki, ls.Ngayhethan, ls.Sdt, ls.Hocvan, ls.Ghichu,ls.Ngaychinhsua, ls.Manv,ls.Macs);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaLSChinhSua(int macs)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM LSCHINHSUA WHERE MACS = '{0}'", macs);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaLSChinhSuaNhanVien(int macs)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM LSCHINHSUA WHERE MANV = '{0}'", macs);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
