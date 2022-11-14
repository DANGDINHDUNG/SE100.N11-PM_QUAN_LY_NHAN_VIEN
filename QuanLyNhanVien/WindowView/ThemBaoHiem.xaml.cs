using System;
using DTO;
using BUS;
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
    /// Interaction logic for ThemBaoHiem.xaml
    /// </summary>
    public partial class ThemBaoHiem : Window
    {
        public BUS_SOBH busBaoHiem = new BUS_SOBH();
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public DTO_SOBH suaBaoHiem;
        
        public bool checkAdd;
        public ThemBaoHiem()
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

        private void btnThemSua_Click(object sender, RoutedEventArgs e)
        {
            if (ngayCapTbx.Text == String.Empty || noiCapTbx.Text == String.Empty)

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DTO_SOBH dtoSoBH = new DTO_SOBH();
            dtoSoBH.Manv = int.Parse(maNVCbx.SelectedValue.ToString());
            dtoSoBH.Ngaycapso = Convert.ToDateTime(ngayCapTbx.Text);
            dtoSoBH.Noicapso = noiCapTbx.Text;
            dtoSoBH.Ghichu = ghiChuTbx.Text;

            if (maBHTbx.Text == string.Empty)
            {
                busBaoHiem.ThemSoBH(dtoSoBH);
                MessageBox.Show("Thêm bảo hiểm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                dtoSoBH.Mabh = int.Parse(maBHTbx.Text);
                busBaoHiem.SuaSoBH(dtoSoBH);
                MessageBox.Show("Sửa bảo hiểm thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Close();
        }

        private void maBHTbx_Loaded(object sender, RoutedEventArgs e)
        {
            if (checkAdd)
                return;
            maBHTbx.Text = suaBaoHiem.Mabh.ToString();
            maNVCbx.Text = suaBaoHiem.Manv.ToString();
            ngayCapTbx.Text = suaBaoHiem.Ngaycapso.ToString();
            noiCapTbx.Text = suaBaoHiem.Noicapso.ToString();
            ghiChuTbx.Text = suaBaoHiem.Ghichu.ToString();
        }
    }
}
