using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_NVTHOIVIEC
    {
        DAL_NVTHOIVIEC bophan = new DAL_NVTHOIVIEC();

        public DataTable getNVThoiViec()
        {
            return bophan.getNVThoiViec();
        }

        public bool ThemNVThoiViec(DTO_NVTHOIVIEC nvtv)
        {
            return bophan.ThemNVThoiViec(nvtv);
        }

        public bool SuaNVThoiViec(DTO_NVTHOIVIEC nvtv)
        {
            return bophan.SuaNVThoiViec(nvtv);
        }

        public bool XoaNVThoiViec(int manv)
        {
            return bophan.XoaNVThoiViec(manv);
        }

    }
}
