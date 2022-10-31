using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_HOSOTHUVIEC
    {
        DAL_HOSOTHUVIEC hosothuviec = new DAL_HOSOTHUVIEC();

        public DataTable getHoSoThuViec()
        {
            return hosothuviec.getHoSoThuViec();
        }

        public bool ThemHoSoThuViec(DTO_HOSOTHUVIEC hstv)
        {
            return hosothuviec.ThemHoSoThuViec(hstv);
        }

        public bool SuaHoSoThuViec(DTO_HOSOTHUVIEC hstv)
        {
            return hosothuviec.SuaHoSoThuViec(hstv);
        }

        public bool XoaHoSoThuViec(int manvtv)
        {
            return hosothuviec.XoaHoSoThuViec(manvtv);
        }

    }
}
