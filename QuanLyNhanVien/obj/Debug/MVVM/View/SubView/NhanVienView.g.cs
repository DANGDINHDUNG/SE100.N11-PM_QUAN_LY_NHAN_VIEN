﻿#pragma checksum "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A88AA65DD06FFF986D1F46B2970D1A977C91CD5EFCD121FF1F3DBCA4AAA1552C"
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


namespace QuanLyNhanVien.MVVM.View.SubView {
    
    
    /// <summary>
    /// NhanVienView
    /// </summary>
    public partial class NhanVienView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dsNhanVienDtg;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThemNhanVien;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button xoaBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuaNhanSu;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/mvvm/view/subview/nhanvienview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
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
            this.dsNhanVienDtg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
            this.dsNhanVienDtg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dsNhanVienDtg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnThemNhanVien = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
            this.btnThemNhanVien.Click += new System.Windows.RoutedEventHandler(this.btnThemNhanVien_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.xoaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
            this.xoaBtn.Click += new System.Windows.RoutedEventHandler(this.xoaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSuaNhanSu = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\..\MVVM\View\SubView\NhanVienView.xaml"
            this.btnSuaNhanSu.Click += new System.Windows.RoutedEventHandler(this.btnSuaNhanSu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

