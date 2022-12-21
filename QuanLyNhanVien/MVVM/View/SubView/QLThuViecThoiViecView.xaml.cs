using BUS;
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

namespace QuanLyNhanVien.MVVM.View.SubView
{
    /// <summary>
    /// Interaction logic for QLThuViecThoiViecView.xaml
    /// </summary>
    public partial class QLThuViecThoiViecView : UserControl
    {
        BUS_NVTHOIVIEC busNhanVienThoiViec = new BUS_NVTHOIVIEC();

        public QLThuViecThoiViecView()
        {
            InitializeComponent();
            DataGridLoad();
        }

        private void btnSuaNhanVien_Click(object sender, RoutedEventArgs e)
        {
            HoSoThuViec hoSoThuViec = new HoSoThuViec();
            hoSoThuViec.ShowDialog();
        }

        private void btnThemNhanVien_Click(object sender, RoutedEventArgs e)
        {
            HoSoThuViec hoSoThuViec = new HoSoThuViec();
            hoSoThuViec.ShowDialog();
        }

        public void DataGridLoad()
        {
            nvThoiViecDtg.DataContext = busNhanVienThoiViec.getNVThoiViec();
        }
    }
}
