﻿#pragma checksum "..\..\..\..\Views\Modal\MSBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835CCF5156DAC4C3D0765CA30CC9D65041ACB858"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

using Jupiter.Views.Modal;
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


namespace Jupiter.Views.Modal {
    
    
    /// <summary>
    /// MSBox
    /// </summary>
    public partial class MSBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard sair_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card card;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _TituloStatos;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon _Icon;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _Titulo;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _MS;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel _OK;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel _SIMNOT;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\Views\Modal\MSBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Not;
        
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
            System.Uri resourceLocater = new System.Uri("/Jupiter;component/views/modal/msbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Modal\MSBox.xaml"
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
            this.sair_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.card = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 3:
            
            #line 106 "..\..\..\..\Views\Modal\MSBox.xaml"
            ((MaterialDesignThemes.Wpf.Card)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Card_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this._TituloStatos = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\Views\Modal\MSBox.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._Icon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 7:
            this._Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this._MS = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this._OK = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 165 "..\..\..\..\Views\Modal\MSBox.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this._SIMNOT = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            
            #line 180 "..\..\..\..\Views\Modal\MSBox.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_Not = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\..\..\Views\Modal\MSBox.xaml"
            this.btn_Not.Click += new System.Windows.RoutedEventHandler(this.btn_Not_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

