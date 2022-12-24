using BUS;
using DTO;
using QuanLyNhanVien.MessageBox;
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
    /// Interaction logic for TaiKhoanView.xaml
    /// </summary>
    public partial class TaiKhoanView : UserControl
    {
        public BUS_PHANLOAITK busPLTK = new BUS_PHANLOAITK();
        public BUS_TAIKHOAN busTaiKhoan = new BUS_TAIKHOAN();
        public DTO_TAIKHOAN dtoTaiKhoan = new DTO_TAIKHOAN();
        public TaiKhoanView()
        {
            InitializeComponent();
            DataGridLoad();
        }

        public void DataGridLoad()
        {
            taiKhoanDtg.DataContext = busTaiKhoan.getTaiKhoan();
        }

        private void taiKhoanDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (taiKhoanDtg.SelectedItems.Count == 0) return;
            DataRowView row = taiKhoanDtg.SelectedItem as DataRowView;

            if (row == null)
            {
                ClearBoxes();
                return;
            }

            dtoTaiKhoan._MATK = Convert.ToInt32(row[0].ToString());
            busTaiKhoan.LayMatKhau(dtoTaiKhoan);
            maNVCbx.Text = row[2].ToString();
            tenTaiKhoanTbx.Text = row[3].ToString();
            matKhauTbx.Text = dtoTaiKhoan._MATKHAU;
        }

        public void ClearBoxes()
        {
            maNVCbx.Text = tenTaiKhoanTbx.Text = xacNhanMKTbx.Text = matKhauTbx.Text = "";
        }

        private void nhapLaiBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxes();
        }

        private void themBtn_Click(object sender, RoutedEventArgs e)
        {
            dtoTaiKhoan._TENCHUTAIKHOAN = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._TENDANGNHAP = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._MATKHAU = matKhauTbx.Text;
            dtoTaiKhoan._MALOAITK = 3;
            busTaiKhoan.SuaTaiKhoan(dtoTaiKhoan);
            bool? show = new MessageBoxCustom("Thêm thành công!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            DataGridLoad();
            ClearBoxes();
        }

        private void suaBtn_Click(object sender, RoutedEventArgs e)
        {
            dtoTaiKhoan._TENCHUTAIKHOAN = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._TENDANGNHAP = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._MATKHAU = matKhauTbx.Text;
            busTaiKhoan.SuaTaiKhoan(dtoTaiKhoan);
            bool? show = new MessageBoxCustom("Sua thành công!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            DataGridLoad();
            ClearBoxes();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            dtoTaiKhoan._TENCHUTAIKHOAN = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._TENDANGNHAP = tenTaiKhoanTbx.Text;
            dtoTaiKhoan._MATKHAU = matKhauTbx.Text;
            dtoTaiKhoan._MALOAITK = 3;
            busTaiKhoan.XoaTaiKhoan(dtoTaiKhoan._MATK);
            bool? show = new MessageBoxCustom("Xóa thành công!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            DataGridLoad();
            ClearBoxes();
        }
    }
}
