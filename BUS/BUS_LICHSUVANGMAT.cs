﻿using System;
using DAL;
using DTO;
using System.Data;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_LICHSUVANGMAT
    {
        DAL_LICHSUVANGMAT lichsuvangmat = new DAL_LICHSUVANGMAT();

        public DataTable getLichSuVangMat()
        {
            return lichsuvangmat.getLichSuVangMat();
        }

        public bool ThemLichSuVangMat(DTO_LICHSUVANGMAT bp)
        {
            return lichsuvangmat.ThemLichSuVangMat(bp);
        }

        public bool SuaLichSuVangMat(DTO_LICHSUVANGMAT bp)
        {
            return lichsuvangmat.SuaLichSuVangMat(bp);
        }

        public bool XoaLichSuVangMat(int manv)
        {
            return lichsuvangmat.XoaLichSuVangMat(manv);
        }
    }
}
