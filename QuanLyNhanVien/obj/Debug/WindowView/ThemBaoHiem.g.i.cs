﻿#pragma checksum "..\..\..\WindowView\ThemBaoHiem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "268B9533A9B5C4612CC15227F20D28A39E1BDB4FDCFB6567F208700C39788088"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyNhanVien;
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


namespace QuanLyNhanVien.WindowView {
    
    
    /// <summary>
    /// ThemBaoHiem
    /// </summary>
    public partial class ThemBaoHiem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maBHTbx;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox maNVCbx;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ngayCapTbx;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox noiCapTbx;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ghiChuTbx;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHuy;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\WindowView\ThemBaoHiem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnThemSua;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/windowview/thembaohiem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowView\ThemBaoHiem.xaml"
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
            this.maBHTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\WindowView\ThemBaoHiem.xaml"
            this.maBHTbx.Loaded += new System.Windows.RoutedEventHandler(this.maBHTbx_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.maNVCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ngayCapTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.noiCapTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ghiChuTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnHuy = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\WindowView\ThemBaoHiem.xaml"
            this.btnHuy.Click += new System.Windows.RoutedEventHandler(this.btnHuy_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnThemSua = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\WindowView\ThemBaoHiem.xaml"
            this.btnThemSua.Click += new System.Windows.RoutedEventHandler(this.btnThemSua_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

