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
    public class DAL_KYLUAT : KetNoi
    {

        public DataTable getSoThaiSan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KYLUAT", connection);
            DataTable dtKYLUAT = new DataTable();
            da.Fill(dtKYLUAT);
            return dtKYLUAT;
        }
        public bool ThemSoThaiSan(DTO_KYLUAT kyLuat)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("INSERT INTO KYLUAT VALUES ('{0}', N'{1}')"
                , kyLuat.Tien, kyLuat.Lydo);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
        /*
	MAKL INT PRIMARY KEY,
	TIEN MONEY,
	LYDO NVARCHAR(50)
 */
        public bool SuaKYLUAT(DTO_KYLUAT kyLuat)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("UPDATE KYLUAT " +
                "SET TIEN='{0}, LYDO=N'{1}'" + "WHERE MAKL = '{4}'",
            kyLuat.Tien, kyLuat.Lydo, kyLuat.Makl);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }

        public bool XoaKYLUAT(int makl)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = string.Format("DELETE FROM KYLUAT WHERE MAKL = '{0}')", makl);
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else return false;
            connection.Close();
        }
    }
}
