﻿#pragma checksum "..\..\UyeOl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F8D023C2E35AE62414D85645E0B7106AAB8FD2C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using girisii;


namespace girisii {
    
    
    /// <summary>
    /// UyeOl
    /// </summary>
    public partial class UyeOl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ad;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Soyad;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telefon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eposta;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Adres;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Kullanıcı;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UyeOl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sıfre;
        
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
            System.Uri resourceLocater = new System.Uri("/girisii;component/uyeol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UyeOl.xaml"
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
            
            #line 16 "..\..\UyeOl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Soyad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Telefon = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\UyeOl.xaml"
            this.Telefon.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Telefon_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Eposta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Adres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Kullanıcı = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Sıfre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 25 "..\..\UyeOl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
