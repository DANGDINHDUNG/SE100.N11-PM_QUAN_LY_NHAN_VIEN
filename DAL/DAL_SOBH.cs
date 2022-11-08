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
    public class DAL_SOBH : KetNoi
    {

        public DataTable getSoBH()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SOBH", connection);
            DataTable dtSOBH = new DataTable();
            da.Fill(dtSOBH);
            return dtSOBH;
        }
        public bool ThemSoBH(DTO_SOBH soBH)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO SOBH VALUES ('{0}', '{1}','{2}',N'{3}')"
                , soBH.Manv, soBH.Ngaycapso, soBH.Noicapso, soBH.Ghichu);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MABH INT IDENTITY(1,1) PRIMARY KEY,
	MANV INT,
	NGAYCAPSO DATETIME,
	NOICAPSO NVARCHAR(20),
	GHICHU NVARCHAR(70),
 */
        public bool SuaSoBH(DTO_SOBH soBH)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE SOBH " +
                "SET MANV='{0}, NGAYCAPSO='{1}',NOICAPSO='{2}',GHICHU=N'{3}'"  + "WHERE MABH = '{4}'",
            soBH.Manv, soBH.Ngaycapso, soBH.Noicapso, soBH.Ghichu, soBH.Mabh);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaSoBH(int mabh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM SOBH WHERE MABH = '{0}'", mabh);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
