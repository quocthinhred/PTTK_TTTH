﻿#pragma checksum "..\..\HocPhi_LCC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA9495B064F0E85DC2E60A726761290FA6CB332E872F7D2BBEBDA7770221DE2F"
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
    /// HocPhi_LCC
    /// </summary>
    public partial class HocPhi_LCC : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\HocPhi_LCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_fee;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\HocPhi_LCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_ok;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\HocPhi_LCC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_back;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_TTTH;component/hocphi_lcc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HocPhi_LCC.xaml"
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
            this.dtg_fee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\HocPhi_LCC.xaml"
            this.dtg_fee.Loaded += new System.Windows.RoutedEventHandler(this.dtg_fee_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bt_ok = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\HocPhi_LCC.xaml"
            this.bt_ok.Click += new System.Windows.RoutedEventHandler(this.bt_ok_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_back = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\HocPhi_LCC.xaml"
            this.bt_back.Click += new System.Windows.RoutedEventHandler(this.bt_back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

