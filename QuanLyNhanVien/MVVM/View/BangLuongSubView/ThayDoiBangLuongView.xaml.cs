﻿using BUS;
using DTO;
using QuanLyNhanVien.MessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace QuanLyNhanVien.MVVM.View.BangLuongSubView
{
    /// <summary>
    /// Interaction logic for ThayDoiBangLuongView.xaml
    /// </summary>
    public partial class ThayDoiBangLuongView : UserControl
    {
        public DTO_THAYDOIBANGLUONG dtoThayDoiBangLuong = new DTO_THAYDOIBANGLUONG();
        public BUS_THAYDOIBANGLUONG busThayDoiBangLuong = new BUS_THAYDOIBANGLUONG();
        public BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public BUS_BANGLUONG busBangLuong = new BUS_BANGLUONG();

        public ThayDoiBangLuongView()
        {
            InitializeComponent();
            DataGridLoad();
        }

        public void DataGridLoad()
        {
            thayDoiBangLuongDtg.DataContext = busThayDoiBangLuong.getThayDoiBangLuong();
        }

        private void thayDoiBangLuongDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (thayDoiBangLuongDtg.SelectedItems.Count == 0) return;
            DataRowView row = thayDoiBangLuongDtg.SelectedItem as DataRowView;

            if (row == null)
            {
                ClearBoxes();
                return;
            }

            maNVCbx.Text = row[0].ToString();
            tenNVTbx.Text = busNhanVien.TimTenNVTheoMa(row[0].ToString());
            maLuongCbx.Text = row[1].ToString();
            maLuongMoiCbx.Text = row[2].ToString();
            ngaySuaDpk.Text = row[3].ToString();
            lyDoTbx.Text = row[4].ToString();
        }

        public void ClearBoxes()
        {
            maNVCbx.Text = "";
            maNVCbx.SelectedIndex = -1;
            tenNVTbx.Text = "";
            maLuongCbx.Text = "";
            maLuongMoiCbx.Text = "";
            ngaySuaDpk.Text = DateTime.Now.ToString();
            lyDoTbx.Text = "";
        }

        private void Comboboxes_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var maNV in busNhanVien.TongHopMaNhanVien())
            {
                maNVCbx.Items.Add(maNV);
            }

            foreach (var maLuong in busBangLuong.TongHopMaLuong())
            {
                maLuongCbx.Items.Add(maLuong);
            }

            foreach (var maLuong in busBangLuong.TongHopMaLuong())
            {
                maLuongMoiCbx.Items.Add(maLuong);
            }

            ngaySuaDpk.Text = DateTime.Today.ToString();
        }

        private void lamMoiBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxes();
            thayDoiBangLuongDtg.SelectedItems.Clear();
        }

        private void maNVCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (maNVCbx.SelectedIndex == -1)
            {
                return;
            }
            tenNVTbx.Text = busNhanVien.TimTenNVTheoMa(maNVCbx.SelectedValue.ToString());
            maLuongCbx.Text = busNhanVien.GetMaLuong(maNVCbx.SelectedValue.ToString());
        }

        private void thayDoiBtn_Click(object sender, RoutedEventArgs e)
        {
            bool? Result;
            if (maNVCbx.Text == String.Empty || maLuongCbx.Text == String.Empty || maLuongMoiCbx.Text == String.Empty || ngaySuaDpk.Text == String.Empty)
            {
                Result = new MessageBoxCustom("Vui lòng điền đầy đủ thông tin!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            dtoThayDoiBangLuong.Manv = int.Parse(maNVCbx.Text);
            dtoThayDoiBangLuong.Maluong = maLuongCbx.Text;
            dtoThayDoiBangLuong.Maluongmoi = maLuongMoiCbx.Text;
            dtoThayDoiBangLuong.Ngaysua = DateTime.Today;
            dtoThayDoiBangLuong.Lydo = lyDoTbx.Text;

            if (busThayDoiBangLuong.KiemTraTonTaiThayDoiBangLuong(dtoThayDoiBangLuong.Manv.ToString(), dtoThayDoiBangLuong.Maluong, dtoThayDoiBangLuong.Maluongmoi))
            {
                busThayDoiBangLuong.SuaThayDoiBangLuong(dtoThayDoiBangLuong);
            }
            else
            {
                busThayDoiBangLuong.ThemThayDoiBangLuong(dtoThayDoiBangLuong);
            }

            busNhanVien.SuaMaLuongNhanVien(maNVCbx.Text, maLuongMoiCbx.Text);
            DataGridLoad();
            Result = new MessageBoxCustom("Sửa bảng lương thành công!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            ClearBoxes();
        }

        private void xoaBtn_Click(object sender, RoutedEventArgs e)
        {
            bool? Result;
            if (thayDoiBangLuongDtg.SelectedItems.Count == 0)
            {
                Result = new MessageBoxCustom("Vui lòng chọn thay đổi cần xóa!", MessageType.Warning, MessageButtons.Ok).ShowDialog();
                return;
            }

            busThayDoiBangLuong.XoaThayDoiBangLuong(int.Parse(maNVCbx.Text), maLuongCbx.Text, maLuongMoiCbx.Text);
            DataGridLoad();
            Result = new MessageBoxCustom("Xóa thay đổi thành công!", MessageType.Success, MessageButtons.Ok).ShowDialog();
            ClearBoxes();
        }
    }
}
