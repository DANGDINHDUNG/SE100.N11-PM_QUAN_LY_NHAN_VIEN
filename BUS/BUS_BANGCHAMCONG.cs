using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_BANGCHAMCONG
    {
        DAL_BANGCHAMCONG bangchamcong = new DAL_BANGCHAMCONG();

        public DataTable getBangChamCong()
        {
            return bangchamcong.getBangChamCong();
        }

        public bool ThemBangChamCong(DTO_BANGCHAMCONG bcc)
        {
            return bangchamcong.ThemBangChamCong(bcc);
        }

        public bool SuaBangChamCong(DTO_BANGCHAMCONG bcc)
        {
            return bangchamcong.SuaBangChamCong(bcc);
        }

        public bool XoaBangChamCong(int manvtv, int thang, int nam)
        {
            return bangchamcong.XoaBangChamCong(manvtv, thang, nam);
        }

        public DTO_BANGCHAMCONG getBangChamCongTheoNhanVien(string maNV, int thang, int nam)
        {
            return bangchamcong.getBangChamCongTheoNhanVien(maNV, thang, nam);
        }
    }
}
