﻿#pragma checksum "..\..\Character.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3DB21FF8686F4F8096E4D97D560BAB8"
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
    /// Character
    /// </summary>
    public partial class Character : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image sanji;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image luffy;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image naruto;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botton1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botton2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button botton3;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Character.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label coin;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Character.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Chickenrun;component/character.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Character.xaml"
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
            
            #line 12 "..\..\Character.xaml"
            ((System.Windows.Controls.Canvas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Canvas_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sanji = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.luffy = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.naruto = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.botton1 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Character.xaml"
            this.botton1.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.botton2 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Character.xaml"
            this.botton2.Click += new System.Windows.RoutedEventHandler(this.botton2_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.botton3 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Character.xaml"
            this.botton3.Click += new System.Windows.RoutedEventHandler(this.botton3_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Character.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Character.xaml"
            this.home.Click += new System.Windows.RoutedEventHandler(this.home_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.coin = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lv = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

