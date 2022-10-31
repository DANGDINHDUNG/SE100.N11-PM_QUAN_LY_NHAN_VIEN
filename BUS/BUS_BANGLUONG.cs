﻿using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_BANGLUONG
    {
        DAL_BANGLUONG bangluong = new DAL_BANGLUONG();

        public DataTable getBangLuong()
        {
            return bangluong.getBangLuong();
        }

        public bool ThemBangLuong(DTO_BANGLUONG luong)
        {
            return bangluong.ThemBangLuong(luong);
        }

        public bool SuaBangLuong(DTO_BANGLUONG luong)
        {
            return bangluong.SuaBangLuong(luong);
        }

        public bool XoaBangLuong(string maluong)
        {
            return bangluong.XoaBangLuong(maluong);
        }

    }
}
