using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_NHANVIEN
    {
        DAL_NHANVIEN khenthuong = new DAL_NHANVIEN();

        public DataTable getNhanVien()
        {
            return khenthuong.getNhanVien();
        }

        public bool ThemNhanVien(DTO_NHANVIEN nv)
        {
            return khenthuong.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(DTO_NHANVIEN nv)
        {
            return khenthuong.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(int manv)
        {
            return khenthuong.XoaNhanVien(manv);
        }

    }
}
