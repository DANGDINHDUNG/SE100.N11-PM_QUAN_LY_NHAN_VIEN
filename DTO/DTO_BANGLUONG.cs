using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BANGLUONG
    {
        private string maluong;
        private double lcb;
        private double phucapphucvu;
        private double phucapkhac;
        private string ghichu;

        public DTO_BANGLUONG()
        {
        }

        public DTO_BANGLUONG(string maluong, double lcb, double phucapphucvu, double phucapkhac, string ghichu)
        {
            this.maluong = maluong;
            this.lcb = lcb;
            this.phucapphucvu = phucapphucvu;
            this.phucapkhac = phucapkhac;
            this.ghichu = ghichu;
        }

        public string Maluong { get => maluong; set => maluong = value; }
        public double Lcb { get => lcb; set => lcb = value; }
        public double Phucapphucvu { get => phucapphucvu; set => phucapphucvu = value; }
        public double Phucapkhac { get => phucapkhac; set => phucapkhac = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
