﻿#pragma checksum "..\..\Character2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00C0BC7E740DBCA9EEA57E04A1128A68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Chickenrun;
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


namespace Chickenrun {
    
    
    /// <summary>
    /// Character2
    /// </summary>
    public partial class Character2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sasuke;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botton4;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sonic;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botton5;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _return;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label coin;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Character2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lv;
        
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
            System.Uri resourceLocater = new System.Uri("/Chickenrun;component/character2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Character2.xaml"
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
            
            #line 12 "..\..\Character2.xaml"
            ((System.Windows.Controls.Canvas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Canvas_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sasuke = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.botton4 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Character2.xaml"
            this.botton4.Click += new System.Windows.RoutedEventHandler(this.botton4_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sonic = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.botton5 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Character2.xaml"
            this.botton5.Click += new System.Windows.RoutedEventHandler(this.botton5_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._return = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Character2.xaml"
            this._return.Click += new System.Windows.RoutedEventHandler(this.return_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Character2.xaml"
            this.home.Click += new System.Windows.RoutedEventHandler(this.home_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.coin = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lv = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
