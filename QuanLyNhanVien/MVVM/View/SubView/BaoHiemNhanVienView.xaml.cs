using QuanLyNhanVien.WindowView;
using BUS;
using DTO;
using System;
using System.Data;
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

namespace QuanLyNhanVien.MVVM.View.SubView
{
    /// <summary>
    /// Interaction logic for BaoHiemNhanVien.xaml
    /// </summary>
    public partial class BaoHiemNhanVienView : UserControl
    {
        public BUS_SOTHAISAN busSoThaiSan = new BUS_SOTHAISAN();
        public DTO_SOTHAISAN dtoSoThaiSan = new DTO_SOTHAISAN();
        public BaoHiemNhanVienView()
        {
            InitializeComponent();
            DataGridLoad();
        }

        private void btnThemBaoHiem_Click(object sender, RoutedEventArgs e)
        {
            ThemBaoHiem themBaoHiem = new ThemBaoHiem();
            themBaoHiem.ShowDialog();
        }

        private void btnThemThaiSan_Click(object sender, RoutedEventArgs e)
        {
            ThemThaiSan thaiSan = new ThemThaiSan();
            thaiSan.checkAdd = true;
            thaiSan.ShowDialog();
            DataGridLoad();
        }

        private void dsThaiSanDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void DataGridLoad()
        {
            dsThaiSanDtg.DataContext = busSoThaiSan.getSoThaiSan();
        }

        private void btnXoaThaiSan_Click(object sender, RoutedEventArgs e)
        {
            busSoThaiSan.XoaSoThaiSan(dtoSoThaiSan.Mats);
            DataGridLoad();
            MessageBox.Show("Xóa thai sản thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void btnSuaThaiSan_Click(object sender, RoutedEventArgs e)
        {
            if (dsThaiSanDtg.SelectedItems.Count == 0) return;

            DTO_SOTHAISAN suaSoThaiSan = new DTO_SOTHAISAN();
            DataRowView row = dsThaiSanDtg.SelectedItem as DataRowView;
            ThemThaiSan themThaiSan = new ThemThaiSan();
            themThaiSan.checkAdd = false;

            suaSoThaiSan.Mats = int.Parse(row[0].ToString());
            suaSoThaiSan.Manv = int.Parse(row[1].ToString());
            suaSoThaiSan.Ngayvesom = DateTime.Parse(row[2].ToString());
            suaSoThaiSan.Ngaynghisinh = DateTime.Parse(row[3].ToString());
            suaSoThaiSan.Ngaylamtrolai = DateTime.Parse(row[4].ToString());
            suaSoThaiSan.Trocapcty = double.Parse(row[5].ToString());
            suaSoThaiSan.Ghichu = row[6].ToString();

            themThaiSan.suaThaiSan = suaSoThaiSan;
            themThaiSan.ShowDialog();
            DataGridLoad();
        }

        private void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            if (dsThaiSanDtg.SelectedItems.Count == 0) return;

            DTO_SOTHAISAN ctSoThaiSan = new DTO_SOTHAISAN();
            DataRowView row = dsThaiSanDtg.SelectedItem as DataRowView;
            ChiTietThaiSan ctThaiSan = new ChiTietThaiSan();
            ctThaiSan.checkAdd = false;

            ctSoThaiSan.Mats = int.Parse(row[0].ToString());
            ctSoThaiSan.Manv = int.Parse(row[1].ToString());
            ctSoThaiSan.Ngayvesom = DateTime.Parse(row[2].ToString());
            ctSoThaiSan.Ngaynghisinh = DateTime.Parse(row[3].ToString());
            ctSoThaiSan.Ngaylamtrolai = DateTime.Parse(row[4].ToString());
            ctSoThaiSan.Trocapcty = double.Parse(row[5].ToString());
            ctSoThaiSan.Ghichu = row[6].ToString();

            ctThaiSan.ctThaiSan = ctSoThaiSan;
            ctThaiSan.ShowDialog();
            DataGridLoad();
        }
    }
}
