﻿#pragma checksum "..\..\NV_LopHoc.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E5D3765CC7F42FCC385BD41FD9658667AD55038CD20B1C92FFD64E1ABD720FE"
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
    /// NV_LopHoc
    /// </summary>
    public partial class NV_LopHoc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\NV_LopHoc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_LopKTV;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\NV_LopHoc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_LopCC;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NV_LopHoc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_LopCD;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NV_LopHoc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_addCourse;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_TTTH;component/nv_lophoc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NV_LopHoc.xaml"
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
            this.bt_LopKTV = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\NV_LopHoc.xaml"
            this.bt_LopKTV.Click += new System.Windows.RoutedEventHandler(this.bt_LopKTV_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt_LopCC = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\NV_LopHoc.xaml"
            this.bt_LopCC.Click += new System.Windows.RoutedEventHandler(this.bt_LopCC_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_LopCD = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\NV_LopHoc.xaml"
            this.bt_LopCD.Click += new System.Windows.RoutedEventHandler(this.bt_LopCD_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_addCourse = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\NV_LopHoc.xaml"
            this.bt_addCourse.Click += new System.Windows.RoutedEventHandler(this.bt_addCourse_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

