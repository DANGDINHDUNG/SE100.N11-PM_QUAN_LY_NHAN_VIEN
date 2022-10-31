using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_PHONGBAN
    {
        DAL_PHONGBAN phongban = new DAL_PHONGBAN();

        public DataTable getPhongBan()
        {
            return phongban.getPhongBan();
        }

        public bool ThemPhongBan(DTO_PHONGBAN phong)
        {
            return phongban.ThemPhongBan(phong);
        }

        public bool SuaPhongBan(DTO_PHONGBAN phong)
        {
            return phongban.SuaPhongBan(phong);
        }

        public bool XoaPhongBan(string maphong)
        {
            return phongban.XoaPhongBan(maphong);
        }

    }
}
