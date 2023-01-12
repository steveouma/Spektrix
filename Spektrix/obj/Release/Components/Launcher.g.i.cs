﻿#pragma checksum "..\..\..\Components\Launcher.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2155A8140BA1520B38A5BD8AAD5A841EC170ED6C06A6C03A72AC501055FD7D37"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Spektrix.Components;
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


namespace Spektrix.Components {
    
    
    /// <summary>
    /// Launcher
    /// </summary>
    public partial class Launcher : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_panel_bar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle panel_bar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid panel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid main_meta_grid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid sub_meta_grid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ApplicationIcon;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Components\Launcher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ApplicationName;
        
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
            System.Uri resourceLocater = new System.Uri("/Spektrix;component/components/launcher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Components\Launcher.xaml"
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
            
            #line 9 "..\..\..\Components\Launcher.xaml"
            ((Spektrix.Components.Launcher)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.ActiveBackground);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Components\Launcher.xaml"
            ((Spektrix.Components.Launcher)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DefaultBackground);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Components\Launcher.xaml"
            ((Spektrix.Components.Launcher)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ExecuteLauncher);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_panel_bar = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.panel_bar = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.panel = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.main_meta_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.sub_meta_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.ApplicationIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.ApplicationName = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

