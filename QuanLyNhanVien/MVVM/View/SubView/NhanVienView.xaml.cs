using QuanLyNhanVien.WindowView;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using BUS;
using System.Data;

namespace QuanLyNhanVien.MVVM.View.SubView
{
    /// <summary>
    /// Interaction logic for NhanVienView.xaml
    /// </summary>
    public partial class NhanVienView : UserControl
    {
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public DTO_NHANVIEN dtoNhanVien = new DTO_NHANVIEN();
        public BUS_PHONGBAN busPhongBan = new BUS_PHONGBAN();
        public BUS_BOPHAN busBoPhan = new BUS_BOPHAN();

        public NhanVienView()
        {
            InitializeComponent();
            DataGridLoad();
            ComboBoxes_Loaded();
        }

        public void DataGridLoad()
        {
            dsNhanVienDtg.DataContext = busNhanVien.getNhanVien();
        }

        private void themBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.checkAdd = true;
            themNhanVienForm.ShowDialog();
            
            DataGridLoad();
        }

        private void suaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0) return;
            DTO_NHANVIEN suaNhanVien = new DTO_NHANVIEN();
            DataRowView row = dsNhanVienDtg.SelectedItem as DataRowView;
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.checkAdd = false;

            suaNhanVien.Manv = int.Parse(row[0].ToString());
            suaNhanVien.Maphong = row[1].ToString();
            suaNhanVien.Maluong = row[2].ToString();
            suaNhanVien.Hoten = row[3].ToString();
            suaNhanVien.Ngaysinh = DateTime.Parse(row[4].ToString());
            suaNhanVien.Gioitinh = row[5].ToString();
            suaNhanVien.Dantoc = row[6].ToString();
            suaNhanVien.Cmnd_cccd = row[7].ToString();
            suaNhanVien.Noicap = row[8].ToString();
            suaNhanVien.Chucvu = row[9].ToString();
            suaNhanVien.Maloainv = row[10].ToString();
            suaNhanVien.Loaihd = row[11].ToString();
            suaNhanVien.Thoigian = int.Parse(row[12].ToString());
            suaNhanVien.Ngaydangki = DateTime.Parse(row[13].ToString());
            suaNhanVien.Ngayhethan = DateTime.Parse(row[14].ToString());
            suaNhanVien.Sdt = row[15].ToString();
            suaNhanVien.Hocvan = row[16].ToString();
            suaNhanVien.Ghichu = row[17].ToString();

            themNhanVienForm.suaNhanVien = suaNhanVien;
            themNhanVienForm.ShowDialog();
            DataGridLoad();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            busNhanVien.XoaNhanVien(dtoNhanVien.Manv);
            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            DataGridLoad();
            tenNVTbx.Text = "";
        }

        private void dsNhanVienDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0) return;
            DataRowView row = dsNhanVienDtg.SelectedItem as DataRowView;
            if (row == null)
            {
                //ClearTextBoxes();
                return;
            }
            dtoNhanVien.Manv = int.Parse(row[0].ToString());
            boPhanCbx.SelectedItem = busBoPhan.TimKiemTheoMaBoPhan(busPhongBan.TimKiemBoPhanTheoPhong(row[1].ToString()));
            phongCbx.SelectedItem = busPhongBan.TimKiemTenPhongBanTheoMa(row[1].ToString());
            tenNVTbx.Text = row[3].ToString();
        }

        private void lamMoiBtn_Click(object sender, RoutedEventArgs e)
        {
            phongCbx.Text = "";
            boPhanCbx.Text = "";
            tenNVTbx.Text = "";
            DataGridLoad();
        }

        private void boPhanCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tenNVTbx.Text = "";
            if (boPhanCbx.SelectedItem == null)
            {
                DataGridLoad();
                return;
            }
            phongCbx.Items.Clear();
            foreach (var tenPhong in busPhongBan.TongHopPhongBan(busBoPhan.TimKiemTheoTenBoPhan(boPhanCbx.SelectedItem.ToString())))
            {
                phongCbx.Items.Add(tenPhong);
            }
        }

        public void ComboBoxes_Loaded()
        {
            tenNVTbx.Text = "";
            boPhanCbx.Text = "";
            phongCbx.Text = "";
            foreach (var tenPhong in busPhongBan.TongHopPhongBan(""))
            {
                phongCbx.Items.Add(tenPhong);
            }
            foreach (var tenBoPhan in busBoPhan.TongHopTenBoPhan())
            {
                boPhanCbx.Items.Add(tenBoPhan);
            }
        }

        private void phongCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tenNVTbx.Text = "";
            if (phongCbx.Items.Count == 0 || phongCbx.SelectedItem == null)
            {
                DataGridLoad();
                return;
            }
                
            dsNhanVienDtg.DataContext = busNhanVien.TongHopNhanVienTheoPhong(busPhongBan.TimKiemMaPhongBan(phongCbx.SelectedItem.ToString()));
        }

        private void chiTietBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0) return;
            DTO_NHANVIEN suaNhanVien = new DTO_NHANVIEN();
            DataRowView row = dsNhanVienDtg.SelectedItem as DataRowView;
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.checkAdd = false;

            suaNhanVien.Manv = int.Parse(row[0].ToString());
            suaNhanVien.Maphong = row[1].ToString();
            suaNhanVien.Maluong = row[2].ToString();
            suaNhanVien.Hoten = row[3].ToString();
            suaNhanVien.Ngaysinh = DateTime.Parse(row[4].ToString());
            suaNhanVien.Gioitinh = row[5].ToString();
            suaNhanVien.Dantoc = row[6].ToString();
            suaNhanVien.Cmnd_cccd = row[7].ToString();
            suaNhanVien.Noicap = row[8].ToString();
            suaNhanVien.Chucvu = row[9].ToString();
            suaNhanVien.Maloainv = row[10].ToString();
            suaNhanVien.Loaihd = row[11].ToString();
            suaNhanVien.Thoigian = int.Parse(row[12].ToString());
            suaNhanVien.Ngaydangki = DateTime.Parse(row[13].ToString());
            suaNhanVien.Ngayhethan = DateTime.Parse(row[14].ToString());
            suaNhanVien.Sdt = row[15].ToString();
            suaNhanVien.Hocvan = row[16].ToString();
            suaNhanVien.Ghichu = row[17].ToString();

            themNhanVienForm.suaNhanVien = suaNhanVien;
            themNhanVienForm.ShowDialog();
            DataGridLoad();
            tenNVTbx.Text = "";
        }
    }
}
