using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_SOTHAISAN
    {
        DAL_SOTHAISAN bophan = new DAL_SOTHAISAN();

        public DataTable getSoThaiSan()
        {
            return bophan.getSoThaiSan();
        }

        public bool ThemSoThaiSan(DTO_SOTHAISAN sts)
        {
            return bophan.ThemSoThaiSan(sts);
        }

        public bool SuaSoThaiSan(DTO_SOTHAISAN sts)
        {
            return bophan.SuaSoThaiSan(sts);
        }

        public bool XoaSoThaiSan(int masts)
        {
            return bophan.XoaSoThaiSan(masts);
        }

    }
}
