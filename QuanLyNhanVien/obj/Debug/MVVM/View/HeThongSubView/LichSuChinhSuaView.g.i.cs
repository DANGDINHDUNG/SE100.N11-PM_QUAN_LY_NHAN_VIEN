﻿#pragma checksum "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A7AAF6B7A49E50CC52242C381B3A2C2E87A940BA15AC60D7EFFBAB9988E94EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyNhanVien.MVVM.View.SubView;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QuanLyNhanVien.MVVM.View.HeThongSubView {
    
    
    /// <summary>
    /// LichSuChinhSuaView
    /// </summary>
    public partial class LichSuChinhSuaView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox phongCbx;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox boPhanCbx;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maNVTbx;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button locBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lsChinhSuaDtg;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button xoaBtn;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lamMoiBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/mvvm/view/hethongsubview/lichsuchinhsuaview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.phongCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.boPhanCbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.boPhanCbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.boPhanCbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.maNVTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.maNVTbx.KeyDown += new System.Windows.Input.KeyEventHandler(this.tenNVTbx_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.locBtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.locBtn.Click += new System.Windows.RoutedEventHandler(this.locBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lsChinhSuaDtg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 61 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.lsChinhSuaDtg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dsNhanVienDtg_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.lsChinhSuaDtg.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lsChinhSuaDtg_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.xoaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.xoaBtn.Click += new System.Windows.RoutedEventHandler(this.xoaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lamMoiBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\..\MVVM\View\HeThongSubView\LichSuChinhSuaView.xaml"
            this.lamMoiBtn.Click += new System.Windows.RoutedEventHandler(this.lamMoiBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

