using System;
using DAL;
using DTO;
using System.Data;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN nhanvien = new DAL_NHANVIEN();

        public DataTable getNhanVien()
        {
            return nhanvien.getNhanVien();
        }

        public bool ThemNhanVien(DTO_NHANVIEN nv)
        {
            return nhanvien.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(DTO_NHANVIEN nv)
        {
            return nhanvien.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(int manv)
        {
            return nhanvien.XoaNhanVien(manv);
        }

        public DataTable TongHopNhanVienTheoPhong(string maPhong, string ten)
        {
            return nhanvien.TongHopNhanVienTheoPhong(maPhong, ten);
        }

        public List<string> TongHopMaNhanVien()
        {
            return nhanvien.TongHopMaNhanVien();
        }

    }
}
