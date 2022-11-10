using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO;
using BUS;
using System.Data;
using QuanLyNhanVien.MVVM.View.SubView;

namespace QuanLyNhanVien.WindowView
{
    /// <summary>
    /// Interaction logic for ThemNhanVienForm.xaml
    /// </summary>
    public partial class ThemNhanVienForm : Window
    {
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public BUS_PHONGBAN busPhongBan = new BUS_PHONGBAN();
        public BUS_LOAINHANVIEN busLoaiNV = new BUS_LOAINHANVIEN();
        public BUS_BANGLUONG busBangLuong = new BUS_BANGLUONG();
        public DTO_NHANVIEN suaNhanVien;
        public bool checkAdd;

        public ThemNhanVienForm()
        {
            InitializeComponent();
            ComboBoxes_Loaded();
        }

        private void huyBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void themSuaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (phongCbx.Text == String.Empty || tenTbx.Text == String.Empty || ngaySinhTbx.Text == String.Empty
                || gioiTinhTbx.Text == String.Empty || cccdTbx.Text == String.Empty || noiCapTbx.Text == String.Empty
                || maLuongCbx.Text == String.Empty || loaiNVCbx.Text == String.Empty || chucVuTbx.Text == String.Empty
                || loaiHopDongTbx.Text == String.Empty || thoiGianTbx.Text == String.Empty || ngayKyTbx.Text == String.Empty
                || ngayHetHanTbx.Text == String.Empty || soDienThoaiTbx.Text == String.Empty || hocVanTbx.Text == String.Empty || danTocCbx.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DTO_NHANVIEN dtoNhanVien = new DTO_NHANVIEN();
            dtoNhanVien.Maphong = busPhongBan.TimKiemMaPhongBan(phongCbx.Text);
            dtoNhanVien.Hoten = tenTbx.Text;
            dtoNhanVien.Ngaysinh = DateTime.Parse(ngaySinhTbx.Text);
            dtoNhanVien.Gioitinh = gioiTinhTbx.Text;
            dtoNhanVien.Cmnd_cccd = cccdTbx.Text;
            dtoNhanVien.Noicap = noiCapTbx.Text;
            dtoNhanVien.Maluong = maLuongCbx.Text;
            dtoNhanVien.Maloainv = busLoaiNV.TimKiemTheoLoaiNhanVien(loaiNVCbx.Text);
            dtoNhanVien.Chucvu = chucVuTbx.Text;
            dtoNhanVien.Loaihd = loaiHopDongTbx.Text;
            dtoNhanVien.Thoigian = int.Parse(thoiGianTbx.Text);
            dtoNhanVien.Ngaydangki = DateTime.Parse(ngayKyTbx.Text);
            dtoNhanVien.Ngayhethan = DateTime.Parse(ngayHetHanTbx.Text);
            dtoNhanVien.Sdt = soDienThoaiTbx.Text;
            dtoNhanVien.Hocvan = hocVanTbx.Text;
            dtoNhanVien.Ghichu = ghiChuTbx.Text;
            dtoNhanVien.Dantoc = danTocCbx.Text;

            if (maNVTbx.Text == string.Empty)
            {
                busNhanVien.ThemNhanVien(dtoNhanVien);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dtoNhanVien.Manv = int.Parse(maNVTbx.Text);
                busNhanVien.SuaNhanVien(dtoNhanVien);
                MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Close();

        }

        public void ComboBoxes_Loaded()
        {
            foreach (var tenPhong in busPhongBan.TongHopPhongBan(""))
            {
                phongCbx.Items.Add(tenPhong);
            }

            foreach (var loaiNV in busLoaiNV.TongHopLoaiNhanVien())
            {
                loaiNVCbx.Items.Add(loaiNV);
            }

            foreach (var maLuong in busBangLuong.TongHopMaLuong())
            {
                maLuongCbx.Items.Add(maLuong);
            }

            string[] listDanToc = new string[] { "Kinh", "Tày", "Thái", "Mường", "Khmer", "Hoa", "Nùng", "H'Mông", "Dao", "Gia Rai",
                                            "Ê Đê", "Ba Na", "Sán Chay", "Chăm", "Kơ Ho", "Xơ Đăng", "Sán Dìu", "Hrê", "Ra Glai",
                                            "Mnông", "Thổ", "Stiêng", "Khơ mú", "Bru - Vân Kiều", "Cơ Tu", "Giáy", "Tà Ôi", "Mạ",
                                            "Giẻ-Triêng", "Co", "Chơ Ro", "Xinh Mun", "Hà Nhì", "Chu Ru", "Lào", "La Chí", "Kháng",
                                            "Phù Lá", "La Hủ", "La Ha", "Pà Thẻn", "Lự", "Ngái", "Chứt", "Lô Lô", "Mảng", "Cơ Lao",
                                            "Bố Y", "Cống", "Si La", "Pu Péo", "Rơ Măm", "Brâu", "Ơ Đu" };

            foreach (string danToc in listDanToc)
            {
                danTocCbx.Items.Add(danToc);
            }
        }

        private void maNVTbx_Loaded(object sender, RoutedEventArgs e)
        {
            if (checkAdd)
                return;
            maNVTbx.Text = suaNhanVien.Manv.ToString();
            tenTbx.Text = suaNhanVien.Hoten.ToString();
            ngaySinhTbx.Text = suaNhanVien.Ngaysinh.ToString();
            gioiTinhTbx.Text = suaNhanVien.Gioitinh.ToString();
            cccdTbx.Text = suaNhanVien.Cmnd_cccd.ToString();
            noiCapTbx.Text = suaNhanVien.Noicap.ToString();
            chucVuTbx.Text = suaNhanVien.Chucvu.ToString();
            loaiHopDongTbx.Text = suaNhanVien.Loaihd.ToString();
            thoiGianTbx.Text = suaNhanVien.Thoigian.ToString();
            ngayKyTbx.Text = suaNhanVien.Ngaydangki.ToString();
            ngayHetHanTbx.Text = suaNhanVien.Ngayhethan.ToString();
            soDienThoaiTbx.Text = suaNhanVien.Sdt.ToString();
            hocVanTbx.Text = suaNhanVien.Hocvan.ToString();
            ghiChuTbx.Text = suaNhanVien.Ghichu.ToString();

            danTocCbx.SelectedItem = suaNhanVien.Dantoc.ToString();
            loaiNVCbx.SelectedItem = busLoaiNV.TimKiemTheoMaLoaiNhanVien(suaNhanVien.Maloainv.ToString());
            phongCbx.SelectedItem = busPhongBan.TimKiemTenPhongBanTheoMa(suaNhanVien.Maphong.ToString());
            maLuongCbx.SelectedItem = suaNhanVien.Maluong.ToString();
        }
    }
}
