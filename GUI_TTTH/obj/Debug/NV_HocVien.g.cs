﻿#pragma checksum "..\..\NV_HocVien.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "076BB6D4340F17EBB4C02005827A58EB4CC320E20360CF5DECBE17082E8796E8"
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
    /// NV_HocVien
    /// </summary>
    public partial class NV_HocVien : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\NV_HocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_student;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NV_HocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_back;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NV_HocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_edit;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\NV_HocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_add;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NV_HocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_TTTH;component/nv_hocvien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NV_HocVien.xaml"
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
            this.dtg_student = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\NV_HocVien.xaml"
            this.dtg_student.Loaded += new System.Windows.RoutedEventHandler(this.dtg_student_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt_back = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\NV_HocVien.xaml"
            this.bt_back.Click += new System.Windows.RoutedEventHandler(this.bt_back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_edit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.bt_add = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\NV_HocVien.xaml"
            this.bt_add.Click += new System.Windows.RoutedEventHandler(this.bt_add_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_delete = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\NV_HocVien.xaml"
            this.bt_delete.Click += new System.Windows.RoutedEventHandler(this.bt_delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

