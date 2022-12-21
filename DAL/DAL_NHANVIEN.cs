using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_NHANVIEN : KetNoi
    {

        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANV, MAPHONG, MALUONG, HOTEN, FORMAT(NGAYSINH, 'dd/MM/yyyy') 'NGAYSINH', GIOITINH, DANTOC, CMND_CCCD, NOICAP, CHUCVU, MALOAINV, LOAIHD, THOIGIAN, FORMAT(NGAYKY, 'dd/MM/yyyy') 'NGAYKY',  FORMAT(NGAYHETHAN, 'dd/MM/yyyy') 'NGAYHETHAN', SDT, HOCVAN, GHICHU FROM NHANVIEN", connection);
            DataTable dtNHANVIEN = new DataTable();
            da.Fill(dtNHANVIEN);
            return dtNHANVIEN;
        }

        public bool ThemNhanVien(DTO_NHANVIEN nhanVien)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO NHANVIEN VALUES ('{0}', '{1}',N'{2}'" +
                ",'{3}',N'{4}',N'{5}','{6}'," +
                "N'{7}',N'{8}','{9}',N'{10}','{11}','{12}','{13}','{14}',N'{15}',N'{16}')"
                , nhanVien.Maphong, nhanVien.Maluong, nhanVien.Hoten, nhanVien.Ngaysinh,
                nhanVien.Gioitinh,nhanVien.Dantoc,nhanVien.Cmnd_cccd,nhanVien.Noicap,nhanVien.Chucvu,nhanVien.Maloainv,
                nhanVien.Loaihd,nhanVien.Thoigian,nhanVien.Ngaydangki,nhanVien.Ngayhethan,nhanVien.Sdt,nhanVien.Hocvan,nhanVien.Ghichu);
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
        public bool SuaNhanVien(DTO_NHANVIEN nhanVien)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE NHANVIEN " +
                "SET MAPHONG='{0}', MALUONG='{1}',HOTEN=N'{2}',NGAYSINH='{3}',GIOITINH=N'{4}',DANTOC=N'{5}',CMND_CCCD='{6}', " +
                "NOICAP=N'{7}',CHUCVU=N'{8}',MALOAINV='{9}',LOAIHD=N'{10}',THOIGIAN='{11}',NGAYKY='{12}',NGAYHETHAN='{13}', " +
                "SDT='{14}',HOCVAN=N'{15}',GHICHU=N'{16}'" + "WHERE MANV = '{17}'",
                nhanVien.Maphong, nhanVien.Maluong, nhanVien.Hoten, nhanVien.Ngaysinh,
                nhanVien.Gioitinh, nhanVien.Dantoc, nhanVien.Cmnd_cccd, nhanVien.Noicap, nhanVien.Chucvu, nhanVien.Maloainv,
                nhanVien.Loaihd, nhanVien.Thoigian, nhanVien.Ngaydangki, nhanVien.Ngayhethan, nhanVien.Sdt, nhanVien.Hocvan, nhanVien.Ghichu, nhanVien.Manv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaNhanVien(int manv)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM NHANVIEN WHERE MANV = '{0}'", manv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public DataTable TongHopNhanVienTheoPhong(string maPhong, string ten)
        {
            DataTable dtNHANVIEN = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            if (maPhong == "")
            {
                da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE dbo.fChuyenCoDauThanhKhongDau(HOTEN) LIKE N'%" + ten + "%'", connection);
            }

            if (ten == "")
            {
                da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MAPHONG = N'" + maPhong + "'", connection);
            }

            if (ten != "" && maPhong != "")
            {
                da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MAPHONG = N'" + maPhong + "' and dbo.fChuyenCoDauThanhKhongDau(HOTEN) LIKE N'%" + ten + "%'", connection);
                
            }

            da.Fill(dtNHANVIEN);
            return dtNHANVIEN;
        }
        public List<string> TongHopMaNhanVien()
        {
            List<string> listMaNhanVien = new List<string>();
            CheckConnection();
            string sql = string.Format("SELECT MANV FROM NHANVIEN");

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                listMaNhanVien.Add(sdr[0].ToString());
            }
            connection.Close();
            return listMaNhanVien;
        }

        public string TimTenNVTheoMa(string maNV)
        {
            string tenNV = string.Empty;
            CheckConnection();
            string sql = string.Format("SELECT HOTEN FROM NHANVIEN WHERE MANV = '{0}'", maNV);

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                tenNV = sdr["HOTEN"].ToString();
            }
            connection.Close();
            return tenNV;
        }

        public int TimMaNVTheoTen(string tenNV)
        {
            int maNV = 0;
            CheckConnection();
            string sql = string.Format("SELECT MANV FROM NHANVIEN WHERE HOTEN = N'{0}'", tenNV);

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                maNV = int.Parse(sdr["MANV"].ToString());
            }
            connection.Close();
            return maNV;
        }

        public string GetMaLuong(string maNV)
        {
            string maLuong = string.Empty;
            CheckConnection();
            string sql = string.Format("SELECT MALUONG FROM NHANVIEN WHERE MANV = N'{0}'", maNV);

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                maLuong = sdr["MALUONG"].ToString();
            }
            connection.Close();
            return maLuong;
        }

        public bool SuaMaLuongNhanVien(string maNV, string maLuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE NHANVIEN SET MALUONG = '{0}' WHERE MANV = '{1}'", maLuong, maNV);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
