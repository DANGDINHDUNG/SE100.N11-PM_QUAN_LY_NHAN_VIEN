using System;
using System.Data;
using BUS;
using DTO;
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

namespace QuanLyNhanVien.WindowView
{
    /// <summary>
    /// Interaction logic for ThemThaiSan.xaml
    /// </summary>
    public partial class ThemThaiSan : Window
    {
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public BUS_SOTHAISAN busSoThaiSan = new BUS_SOTHAISAN();
        public DTO_SOTHAISAN suaThaiSan;
        public DTO_NHANVIEN suaNhanVien;
        public DTO_LSCHINHSUA dtoLSChinhSua = new DTO_LSCHINHSUA();
        public bool checkAdd;
        public ThemThaiSan()
        {
            InitializeComponent();
            ComboBoxes_Loaded();
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ComboBoxes_Loaded()
        {
            foreach (var maNV in busNhanVien.TongHopMaNhanVien())
            {
                maNVCbx.Items.Add(maNV);
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (ngayNghiSinhTbx.Text == String.Empty || ngayVeSomTbx.Text == String.Empty || ngayLamTLTbx.Text == String.Empty
                || troCapTbx.Text == String.Empty)

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DTO_SOTHAISAN dtoSoThaiSan=new DTO_SOTHAISAN();
            dtoSoThaiSan.Manv = int.Parse(maNVCbx.SelectedValue.ToString());
            dtoSoThaiSan.Ngaynghisinh = Convert.ToDateTime(ngayNghiSinhTbx.Text);
            dtoSoThaiSan.Ngayvesom = Convert.ToDateTime(ngayVeSomTbx.Text);
            dtoSoThaiSan.Ngaylamtrolai = Convert.ToDateTime(ngayLamTLTbx.Text);
            dtoSoThaiSan.Trocapcty = int.Parse(troCapTbx.Text);
            dtoSoThaiSan.Ghichu = ghiChuTbx.Text;

            if (maTSTbx.Text == string.Empty)
            {
                busSoThaiSan.ThemSoThaiSan(dtoSoThaiSan);
                MessageBox.Show("Thêm thai sản thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dtoSoThaiSan.Mats = int.Parse(maTSTbx.Text);
                busSoThaiSan.SuaSoThaiSan(dtoSoThaiSan);
                MessageBox.Show("Sửa thai sản thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Close();
        }
        private void maTSTbx_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void maTSTbx_Loaded_1(object sender, RoutedEventArgs e)
        {
            if (checkAdd)
                return;
            maTSTbx.Text = suaThaiSan.Mats.ToString();
            maNVCbx.Text = suaThaiSan.Manv.ToString();

            ngayNghiSinhTbx.Text = suaThaiSan.Ngaynghisinh.ToString();
            ngayVeSomTbx.Text = suaThaiSan.Ngayvesom.ToString();
            ngayLamTLTbx.Text = suaThaiSan.Ngaylamtrolai.ToString();
            troCapTbx.Text = suaThaiSan.Trocapcty.ToString();
            ghiChuTbx.Text = suaThaiSan.Ghichu.ToString();
        }
    }
}
