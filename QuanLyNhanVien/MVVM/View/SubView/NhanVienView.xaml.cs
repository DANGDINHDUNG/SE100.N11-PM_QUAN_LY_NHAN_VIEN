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
            ComboBoxesLoad();
        }

        private void themBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.checkAdd = true;
            themNhanVienForm.ShowDialog();
            
            DataGridLoad();
            ClearBoxes();
        }

        private void suaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

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
            ClearBoxes();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                return;

            busNhanVien.XoaNhanVien(dtoNhanVien.Manv);
            DataGridLoad();
            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearBoxes();
        }

        private void dsNhanVienDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0) return;
            DataRowView row = dsNhanVienDtg.SelectedItem as DataRowView;

            if (row == null)
            {
                ClearBoxes();
                return;
            }

            dtoNhanVien.Manv = int.Parse(row[0].ToString());
            boPhanCbx.SelectedItem = busBoPhan.TimKiemTheoMaBoPhan(busPhongBan.TimKiemBoPhanTheoPhong(row[1].ToString()));
            phongCbx.SelectedItem = busPhongBan.TimKiemTenPhongBanTheoMa(row[1].ToString());
            tenNVTbx.Text = row[3].ToString();
        }

        private void lamMoiBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxes();
            DataGridLoad();
        }

        private void boPhanCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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

        private void chiTietBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xem!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            XemChiTiet();
        }

        private void locBtn_Click(object sender, RoutedEventArgs e)
        {
            LocNhanVien();
        }

        private void tenNVTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LocNhanVien();
            }
        }

        private void dsNhanVienDtg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dsNhanVienDtg.SelectedItems.Count == 0)
            {
                return;
            }
            XemChiTiet();
        }

        public void DataGridLoad()
        {
            dsNhanVienDtg.DataContext = busNhanVien.getNhanVien();
        }

        public void ClearBoxes()
        {
            phongCbx.Text = "";
            boPhanCbx.Text = "";
            tenNVTbx.Text = "";
        }

        public void ComboBoxesLoad()
        {
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

        public void LocNhanVien()
        {
            if (phongCbx.Text == string.Empty && tenNVTbx.Text == string.Empty)
            {
                DataGridLoad();
                return;
            }

            if (phongCbx.Text != string.Empty && tenNVTbx.Text == string.Empty)
            {
                dsNhanVienDtg.DataContext = busNhanVien.TongHopNhanVienTheoPhong(busPhongBan.TimKiemMaPhongBan(phongCbx.SelectedItem.ToString()), "");
            }

            if (phongCbx.Text == string.Empty && tenNVTbx.Text != string.Empty)
            {
                dsNhanVienDtg.DataContext = busNhanVien.TongHopNhanVienTheoPhong("", tenNVTbx.Text);
            }

            if (phongCbx.Text != string.Empty && tenNVTbx.Text != string.Empty)
            {
                dsNhanVienDtg.DataContext = busNhanVien.TongHopNhanVienTheoPhong(busPhongBan.TimKiemMaPhongBan(phongCbx.SelectedItem.ToString()), tenNVTbx.Text);
            }
        }

        public void XemChiTiet()
        {
            DTO_NHANVIEN ctNhanVien = new DTO_NHANVIEN();
            DataRowView row = dsNhanVienDtg.SelectedItem as DataRowView;
            ChiTietNhanVienForm chiTietNhanVienForm = new ChiTietNhanVienForm();

            ctNhanVien.Manv = int.Parse(row[0].ToString());
            ctNhanVien.Maphong = row[1].ToString();
            ctNhanVien.Maluong = row[2].ToString();
            ctNhanVien.Hoten = row[3].ToString();
            ctNhanVien.Ngaysinh = DateTime.Parse(row[4].ToString());
            ctNhanVien.Gioitinh = row[5].ToString();
            ctNhanVien.Dantoc = row[6].ToString();
            ctNhanVien.Cmnd_cccd = row[7].ToString();
            ctNhanVien.Noicap = row[8].ToString();
            ctNhanVien.Chucvu = row[9].ToString();
            ctNhanVien.Maloainv = row[10].ToString();
            ctNhanVien.Loaihd = row[11].ToString();
            ctNhanVien.Thoigian = int.Parse(row[12].ToString());
            ctNhanVien.Ngaydangki = DateTime.Parse(row[13].ToString());
            ctNhanVien.Ngayhethan = DateTime.Parse(row[14].ToString());
            ctNhanVien.Sdt = row[15].ToString();
            ctNhanVien.Hocvan = row[16].ToString();
            ctNhanVien.Ghichu = row[17].ToString();

            chiTietNhanVienForm.ctNhanVien = ctNhanVien;
            chiTietNhanVienForm.ShowDialog();
            DataGridLoad();
        }

    }
}
