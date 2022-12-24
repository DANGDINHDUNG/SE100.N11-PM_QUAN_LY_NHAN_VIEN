using System;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_THAYDOIBANGLUONG
    {
        DAL_THAYDOIBANGLUONG tdbangluong = new DAL_THAYDOIBANGLUONG();

        public DataTable getThayDoiBangLuong()
        {
            return tdbangluong.getThayDoiBangLuong();
        }

        public bool ThemThayDoiBangLuong(DTO_THAYDOIBANGLUONG bp)
        {
            return tdbangluong.ThemThayDoiBangLuong(bp);
        }

        public bool SuaThayDoiBangLuong(DTO_THAYDOIBANGLUONG bp)
        {
            return tdbangluong.SuaThayDoiBangLuong(bp);
        }

        public bool XoaThayDoiBangLuong(int manv,string maluong,string maluongmoi)
        {
            return tdbangluong.XoaThayDoiBangLuong(manv,maluong,maluongmoi);
        }

        public bool KiemTraTonTaiThayDoiBangLuong(DTO_THAYDOIBANGLUONG tdbl)
        {
            return tdbangluong.KiemTraTonTaiThayDoiBangLuong(tdbl);
        }
    }
}
