﻿#pragma checksum "..\..\..\WindowView\LyDoNghiViec.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3EE6A5E58C99928E93D195A0CD2A6A2FCF8C9ACB21E79402CC9D4E66CE166676"
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
    /// LyDoNghiViec
    /// </summary>
    public partial class LyDoNghiViec : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\WindowView\LyDoNghiViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tenNVTbk;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\WindowView\LyDoNghiViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock maNVTbk;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\WindowView\LyDoNghiViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lyDoNghiViecTbx;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\WindowView\LyDoNghiViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hoanThanhBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/windowview/lydonghiviec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowView\LyDoNghiViec.xaml"
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
            
            #line 13 "..\..\..\WindowView\LyDoNghiViec.xaml"
            ((QuanLyNhanVien.WindowView.LyDoNghiViec)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tenNVTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.maNVTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lyDoNghiViecTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.hoanThanhBtn = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\WindowView\LyDoNghiViec.xaml"
            this.hoanThanhBtn.Click += new System.Windows.RoutedEventHandler(this.hoanThanhBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

