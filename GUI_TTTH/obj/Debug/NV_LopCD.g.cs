﻿#pragma checksum "..\..\NV_LopCD.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5ED931E271599EE041383E31E6303EFF4568D2E86F0033C08E954C8C6F080D7"
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
    /// NV_LopCD
    /// </summary>
    public partial class NV_LopCD : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_title;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_chuyende;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_back;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_add;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_off;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\NV_LopCD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbb_student;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_TTTH;component/nv_lopcd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NV_LopCD.xaml"
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
            this.lb_title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.dtg_chuyende = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\NV_LopCD.xaml"
            this.dtg_chuyende.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dtg_chuyende_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 11 "..\..\NV_LopCD.xaml"
            this.dtg_chuyende.Loaded += new System.Windows.RoutedEventHandler(this.dtg_chuyende_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_back = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\NV_LopCD.xaml"
            this.bt_back.Click += new System.Windows.RoutedEventHandler(this.bt_back_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_add = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\NV_LopCD.xaml"
            this.bt_add.Click += new System.Windows.RoutedEventHandler(this.bt_add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bt_off = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\NV_LopCD.xaml"
            this.bt_off.Click += new System.Windows.RoutedEventHandler(this.bt_off_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbb_student = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 14 "..\..\NV_LopCD.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.dtg_chuyende_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}
