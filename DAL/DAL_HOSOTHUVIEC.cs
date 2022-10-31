﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_HOSOTHUVIEC : KetNoi
    {

        public DataTable getHoSoThuViec()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOSOTHUVIEC", connection);
            DataTable dtHOSOTHUVIEC = new DataTable();
            da.Fill(dtHOSOTHUVIEC);
            return dtHOSOTHUVIEC;
        }
        public bool ThemHoSoThuViec(DTO_HOSOTHUVIEC hoSoThuViec)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO HOSOTHUVIEC VALUES (N'{0}', '{1}',N'{2}','{3}',N'{4}'" +
                ",N'{5}','{6}','{7}','{8}',N'{9}',N'{10}')"
                , hoSoThuViec.Hoten, hoSoThuViec.Ngaysinh, hoSoThuViec.Gioitinh, hoSoThuViec.Cmnd_cccd, 
                hoSoThuViec.Noicap, hoSoThuViec.Vitrithuviec,hoSoThuViec.Ngaytv,hoSoThuViec.Sothangtv,hoSoThuViec.Sdt
                ,hoSoThuViec.Hocvan,hoSoThuViec.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
MANVTV INT IDENTITY(1,1) PRIMARY KEY,
	HOTEN NVARCHAR(70),
	NGAYSINH DATETIME,
	GIOITINH NVARCHAR(3),
	CMND_CCCD VARCHAR(12),
	NOICAP NVARCHAR(20),
	VITRITHUVIEC NVARCHAR(25),
	NGAYTV DATETIME,
	SOTHANGTV INT,
	SDT VARCHAR(10),
	HOCVAN NVARCHAR(20),
	GHICHU NVARCHAR(60)
 */
        public bool SuaHoSoThuViec(DTO_HOSOTHUVIEC hoSoThuViec)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE HOSOTHUVIEC " +
                "SET HOTEN=N'{0}, NGAYSINH='{1}',GIOITINH=N'{2}',CMND_CCCD='{3}'" +
               ",NOICAP=N'{4}',VITRITHUVIEC=N'{5},NGAYTV='{6}',SOTHANGTV='{7}'," +
               "SDT='{8}',HOCVAN='{9}',GHICHU='{10}' " + "WHERE MANVTV = '{11}'",
              hoSoThuViec.Hoten, hoSoThuViec.Ngaysinh, hoSoThuViec.Gioitinh, hoSoThuViec.Cmnd_cccd,
                hoSoThuViec.Noicap, hoSoThuViec.Vitrithuviec, hoSoThuViec.Ngaytv, 
                hoSoThuViec.Sothangtv, hoSoThuViec.Sdt
                , hoSoThuViec.Hocvan, hoSoThuViec.Ghichu, hoSoThuViec.Manvtv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaHoSoThuViec(int manvtv)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM HOSOTHUVIEC WHERE MANVTV = '{0}')", manvtv);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}