using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace QuanLyNhanVien.MVVM.View.HeThongSubView
{
    /// <summary>
    /// Interaction logic for LichSuChinhSuaView.xaml
    /// </summary>
    public partial class LichSuChinhSuaView : UserControl
    {
        public BUS_LSCHINHSUA busLSChinhSua = new BUS_LSCHINHSUA();
        public BUS_PHONGBAN busPhongBan = new BUS_PHONGBAN();
        public BUS_BOPHAN busBoPhan = new BUS_BOPHAN();
        public DTO_LSCHINHSUA dtoLSChinhSua = new DTO_LSCHINHSUA();

        public LichSuChinhSuaView()
        {
            InitializeComponent();
            DataGridLoad();
            ComboBoxesLoad();
        }

        private void dsNhanVienDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lsChinhSuaDtg.SelectedItems.Count == 0) return;
            DataRowView row = lsChinhSuaDtg.SelectedItem as DataRowView;

            if (row == null)
            {
                ClearBoxes();
                return;
            }

            dtoLSChinhSua.Macs = int.Parse(row[0].ToString());
            dtoLSChinhSua.Lancs = int.Parse(row[2].ToString());
            dtoLSChinhSua.Hoten = row[1].ToString();
            boPhanCbx.SelectedItem = busBoPhan.TimKiemTheoMaBoPhan(busPhongBan.TimKiemBoPhanTheoPhong(row[3].ToString()));
            phongCbx.SelectedItem = busPhongBan.TimKiemTenPhongBanTheoMa(row[3].ToString());
            maNVTbx.Text = row[1].ToString();
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

        private void locBtn_Click(object sender, RoutedEventArgs e)
        {
            LocNhanVien();
        }

        private void lamMoiBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxes();
            DataGridLoad();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            busLSChinhSua.XoaLSChinhSua(dtoLSChinhSua.Macs);
            DataGridLoad();
            MessageBox.Show("Xóa lịch sử chỉnh sửa lần " + dtoLSChinhSua.Lancs.ToString() + " của nhân viên có mã nhân viên " + dtoLSChinhSua.Hoten + " thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearBoxes();
        }

        private void tenNVTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LocNhanVien();
            }
        }

        public void DataGridLoad()
        {
            lsChinhSuaDtg.DataContext = busLSChinhSua.getLSChinhSua();
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

        public void ClearBoxes()
        {
            phongCbx.Text = "";
            boPhanCbx.Text = "";
            maNVTbx.Text = "";
        }

        public void LocNhanVien()
        {
            if (phongCbx.Text == string.Empty && maNVTbx.Text == string.Empty)
            {
                DataGridLoad();
                return;
            }

            if (phongCbx.Text != string.Empty && maNVTbx.Text == string.Empty)
            {
                lsChinhSuaDtg.DataContext = busLSChinhSua.TongHopLSChinhSuaNhanVienTheoPhong(busPhongBan.TimKiemMaPhongBan(phongCbx.SelectedItem.ToString()), "");
            }

            if (phongCbx.Text == string.Empty && maNVTbx.Text != string.Empty)
            {
                lsChinhSuaDtg.DataContext = busLSChinhSua.TongHopLSChinhSuaNhanVienTheoPhong("", maNVTbx.Text);
            }

            if (phongCbx.Text != string.Empty && maNVTbx.Text != string.Empty)
            {
                lsChinhSuaDtg.DataContext = busLSChinhSua.TongHopLSChinhSuaNhanVienTheoPhong(busPhongBan.TimKiemMaPhongBan(phongCbx.SelectedItem.ToString()), maNVTbx.Text);
            }
        }

        
    }
}
