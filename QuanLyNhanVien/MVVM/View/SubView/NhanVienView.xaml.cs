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

        public NhanVienView()
        {
            InitializeComponent();
            DataGridLoad();
        }

        public void DataGridLoad()
        {
            dsNhanVienDtg.DataContext = busNhanVien.getNhanVien();
        }

        private void btnThemNhanVien_Click(object sender, RoutedEventArgs e)
        {
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.ShowDialog();
        }

        private void btnSuaNhanSu_Click(object sender, RoutedEventArgs e)
        {
            ThemNhanVienForm themNhanVienForm = new ThemNhanVienForm();
            themNhanVienForm.ShowDialog();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            busNhanVien.XoaNhanVien(dtoNhanVien.Manv);
            DataGridLoad();
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
        }
    }
}
