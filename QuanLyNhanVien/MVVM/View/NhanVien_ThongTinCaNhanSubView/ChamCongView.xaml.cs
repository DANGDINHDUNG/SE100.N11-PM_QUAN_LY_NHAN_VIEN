using BUS;
using DTO;
using QuanLyNhanVien.MessageBox;
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

namespace QuanLyNhanVien.MVVM.View.NhanVien_ThongTinCaNhanSubView
{
    /// <summary>
    /// Interaction logic for ChamCongView.xaml
    /// </summary>
    public partial class ChamCongView : UserControl
    {
        BUS_LICHSUCHAMCONG busLichSuChamCong = new BUS_LICHSUCHAMCONG();
        BUS_NHANVIENHIENTAI busNhanVienHienTai = new BUS_NHANVIENHIENTAI();
        BUS_LICHSUVANGMAT busLichSuVangMat = new BUS_LICHSUVANGMAT();
        BUS_SOTHAISAN busSoThaiSan = new BUS_SOTHAISAN();
        string maNV;

        public ChamCongView()
        {
            InitializeComponent();
            maNV = busNhanVienHienTai.getNhanVienHienTai();
            thuTbx.Text = GetNgayTiengViet(DateTime.Now.DayOfWeek.ToString());
            if (busSoThaiSan.KiemTraTonTai(maNV) && (busSoThaiSan.TimNgayLamTroLai(maNV) > busLichSuChamCong.TimLanCuoiChamCongTheoMa(maNV)))
            {
                ngayChamCongGanNhatTbx.Text = busSoThaiSan.TimNgayLamTroLai(maNV).ToString("dd/MM/yyyy");
            }
            else
            {
                ngayChamCongGanNhatTbx.Text = busLichSuChamCong.TimLanCuoiChamCongTheoMa(maNV).ToString("dd/MM/yyyy");
            }
            
            thoiGianTbx.Text = DateTime.Today.ToString("dd/MM/yyyy");
            DataGridLoad();
        }

        public void DataGridLoad()
        {
            ngayNghiDtg.DataContext = busLichSuVangMat.getLichSuVangMat(maNV);

            
        }

        public string GetNgayTiengViet(string day)
        {
            string thu = string.Empty;
            switch (day)
            {
                case "Monday":
                    thu = "Hai";
                    break;
                case "Tuesday":
                    thu = "Ba";
                    break;
                case "Wednesday":
                    thu = "Tư";
                    break;
                case "Thursday":
                    thu = "Năm";
                    break;
                case "Friday":
                    thu = "Sáu";
                    break;
                case "Saturday":
                    thu = "Bảy";
                    break;
            }
            return thu;
        }

        private void chamCongBtn_Click(object sender, RoutedEventArgs e)
        {
            DTO_LICHSUCHAMCONG dtoLichSuChamCong = new DTO_LICHSUCHAMCONG();
            if (!busLichSuChamCong.KiemTraTonTai(maNV))
            {
                dtoLichSuChamCong.Manv = int.Parse(maNV);
                dtoLichSuChamCong.Ngaychamconggannhat = DateTime.Now;
                busLichSuChamCong.ThemLichSuChamCong(dtoLichSuChamCong);
            }
            else
            {
                //string ngayLamGanNhat = string.Empty;
                

                TimeSpan time = DateTime.Parse(thoiGianTbx.Text) - DateTime.Parse(ngayChamCongGanNhatTbx.Text);
                
                for (int i = 1; i < time.Days; i++)
                {
                    if (DateTime.Now.Date.AddDays(-i).DayOfWeek.ToString() == "Sunday")
                    {
                        continue;
                    }
                    else
                    {
                        DTO_LICHSUVANGMAT lichSuVangMat = new DTO_LICHSUVANGMAT();

                        lichSuVangMat.Manv = int.Parse(maNV);
                        lichSuVangMat.Ngaynghi = DateTime.Now.Date.AddDays(-i);

                        busLichSuVangMat.ThemLichSuVangMat(lichSuVangMat);
                        //bool? result = new MessageBoxCustom(DateTime.Now.Date.AddDays(-i).ToString(), MessageType.Success, MessageButtons.Ok).ShowDialog();

                    }
                }

                dtoLichSuChamCong.Manv = int.Parse(maNV);
                dtoLichSuChamCong.Ngaychamconggannhat = DateTime.Now;
                busLichSuChamCong.SuaLichSuChamCong(dtoLichSuChamCong);

                //else
                //{
                //    ngayLamGanNhat = (DateTime.Now.Date.AddDays(-1)).ToString("dd/MM/yyyy");
                //}
                //int homQua = DateTime.Now.Day - 1;
                //string ngayLamGanNhat = homQua.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                //if (busLichSuChamCong.KiemTraChamCong(maNV, ngayLamGanNhat))
                //{

                //}

            }

            DataGridLoad();
        }
    }
}
