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
    public class DAL_SOTHAISAN : KetNoi
    {

        public DataTable getSoThaiSan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SOTHAISAN", connection);
            DataTable dtSOTHAISAN = new DataTable();
            da.Fill(dtSOTHAISAN);
            return dtSOTHAISAN;
        }
        public bool ThemSoThaiSan(DTO_SOTHAISAN soThaiSan)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO SOTHAISAN VALUES ('{0}', '{1}','{2}','{3}','{4}',N'{5}')"
                , soThaiSan.Manv, soThaiSan.Ngayvesom,soThaiSan.Ngaynghisinh,soThaiSan.Ngaylamtrolai,soThaiSan.Trocapcty,soThaiSan.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MATS INT IDENTITY(1,1) PRIMARY KEY,
	MANV INT,
	NGAYVESOM DATETIME,
	NGAYNGHISINH DATETIME,
	NGAYLAMTROLAI DATETIME,
	TROCAPCTY MONEY,
	GHICHU NVARCHAR(70)
 */
        public bool SuaSOTHAISAN(DTO_SOTHAISAN soThaiSan)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE SOTHAISAN " +
                "SET MANV='{0}, NGAYVESOM='{1}',NGAYNGHISINH='{2}',NGAYLAMTROLAI='{3}'" +
               ",TROCAPCTY='{4}',GHICHU=N'{5}' " +"WHERE MATS = '{6}'", 
                soThaiSan.Manv, soThaiSan.Ngayvesom, soThaiSan.Ngaynghisinh,
                soThaiSan.Ngaylamtrolai,soThaiSan.Trocapcty,soThaiSan.Ghichu,soThaiSan.Mats);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaSOTHAISAN(int mats)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM SOTHAISAN WHERE MATS = '{0}')", mats);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}