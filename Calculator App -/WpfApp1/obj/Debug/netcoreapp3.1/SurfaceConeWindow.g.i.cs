﻿#pragma checksum "..\..\..\SurfaceConeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182C839954AB7077C0234021E25ACF6A25878471"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// SurfaceConeWindow
    /// </summary>
    public partial class SurfaceConeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SurfaceCone;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button goSurfaceCone;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox radiusInputSurfaceCone;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox heightInputSurfaceCone;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label radiusPointerSurfaceCone;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SurfaceConeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label heightPointerSurfaceCone;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/surfaceconewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SurfaceConeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SurfaceCone = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.goSurfaceCone = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\SurfaceConeWindow.xaml"
            this.goSurfaceCone.Click += new System.Windows.RoutedEventHandler(this.goSurfaceCone_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.radiusInputSurfaceCone = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.heightInputSurfaceCone = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.radiusPointerSurfaceCone = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.heightPointerSurfaceCone = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

