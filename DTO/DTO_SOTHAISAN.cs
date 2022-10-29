using System;

namespace DTO
{
    public class DTO_SOTHAISAN
    {
        private int mats;
        private int manv;
        private DateTime ngayvesom;
        private DateTime ngaylamtrolai;
        private double trocapcty;
        private string ghichu;
        private string quyenhan;

        //Getter-Setter

        public int Mats { get => mats; set => mats = value; }
        public int Mats1 { get => mats; set => mats = value; }
        public int Manv { get => manv; set => manv = value; }
        public DateTime Ngayvesom { get => ngayvesom; set => ngayvesom = value; }
        public DateTime Ngaylamtrolai { get => ngaylamtrolai; set => ngaylamtrolai = value; }
        public double Trocapcty { get => trocapcty; set => trocapcty = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Quyenhan { get => quyenhan; set => quyenhan = value; }

        //Constructor

        public DTO_SOTHAISAN()
        {
        }

        public DTO_SOTHAISAN(int mats, int manv, DateTime ngayvesom, DateTime ngaylamtrolai, double trocapcty, string ghichu, string quyenhan)
        {
            this.mats = mats;
            this.manv = manv;
            this.ngayvesom = ngayvesom;
            this.ngaylamtrolai = ngaylamtrolai;
            this.trocapcty = trocapcty;
            this.ghichu = ghichu;
            this.quyenhan = quyenhan;
        }


    }
}
