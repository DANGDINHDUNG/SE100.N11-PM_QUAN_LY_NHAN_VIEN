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
    public partial class XuatDSNhanVienView : UserControl
    {
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();

        public XuatDSNhanVienView()
        {
            InitializeComponent();
        }

        public void DataGridLoad()
        {
            dsNhanVienDtg.DataContext = busNhanVien.getNhanVien();
        }
    }
}
