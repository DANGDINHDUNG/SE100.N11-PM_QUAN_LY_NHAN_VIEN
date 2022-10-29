using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHANVIEN
    {
        private int manv;
        private string maphong;
        private string maluong;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string tthonnhan;
        private string cmnd_cccd;
        private string noicap;
        private string chucvu;
        private string maloainv;
        private string loaihd;
        private string thoigian;
        private DateTime ngaydangki;
        private DateTime ngayhethan;
        private string sdt;
        private string hocvan;
        private string ghichu;

        public DTO_NHANVIEN()
        {
        }

        public DTO_NHANVIEN(string thoigian, DateTime ngaydangki, DateTime ngayhethan, string sdt, string hocvan, string ghichu)
        {
            this.thoigian = thoigian;
            this.ngaydangki = ngaydangki;
            this.ngayhethan = ngayhethan;
            this.sdt = sdt;
            this.hocvan = hocvan;
            this.ghichu = ghichu;
        }

        public int Manv { get => manv; set => manv = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Maluong { get => maluong; set => maluong = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Tthonnhan { get => tthonnhan; set => tthonnhan = value; }
        public string Cmnd_cccd { get => cmnd_cccd; set => cmnd_cccd = value; }
        public string Noicap { get => noicap; set => noicap = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Maloainv { get => maloainv; set => maloainv = value; }
        public string Loaihd { get => loaihd; set => loaihd = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public DateTime Ngaydangki { get => ngaydangki; set => ngaydangki = value; }
        public DateTime Ngayhethan { get => ngayhethan; set => ngayhethan = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Hocvan { get => hocvan; set => hocvan = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
