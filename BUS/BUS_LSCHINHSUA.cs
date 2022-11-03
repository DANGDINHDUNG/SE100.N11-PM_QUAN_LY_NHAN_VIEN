using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_LSCHINHSUA
    {
        DAL_LSCHINHSUA khenthuong = new DAL_LSCHINHSUA();

        public DataTable getLSChinhSua()
        {
            return khenthuong.getLSChinhSua();
        }

        public bool ThemLSChinhSua(DTO_LSCHINHSUA nv)
        {
            return khenthuong.ThemLSChinhSua(nv);
        }

        public bool SuaLSChinhSua(DTO_LSCHINHSUA nv)
        {
            return khenthuong.SuaLSChinhSua(nv);
        }

        public bool XoaLSChinhSua(int macs)
        {
            return khenthuong.XoaLSChinhSua(macs);
        }

    }
}
