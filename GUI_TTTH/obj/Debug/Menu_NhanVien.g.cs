﻿#pragma checksum "..\..\Menu_NhanVien.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A721AB3DA1C74741CD417B86C76F11ABE68C08F371D73FAE6536ACCA905025C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI_TTTH;
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


namespace GUI_TTTH {
    
    
    /// <summary>
    /// Menu_NhanVien
    /// </summary>
    public partial class Menu_NhanVien : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Menu_NhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_student;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Menu_NhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_teacher;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Menu_NhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_class;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_TTTH;component/menu_nhanvien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu_NhanVien.xaml"
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
            this.bt_student = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Menu_NhanVien.xaml"
            this.bt_student.Click += new System.Windows.RoutedEventHandler(this.bt_student_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt_teacher = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Menu_NhanVien.xaml"
            this.bt_teacher.Click += new System.Windows.RoutedEventHandler(this.bt_teacher_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_class = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Menu_NhanVien.xaml"
            this.bt_class.Click += new System.Windows.RoutedEventHandler(this.bt_class_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
