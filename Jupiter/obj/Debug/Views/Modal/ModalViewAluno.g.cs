﻿#pragma checksum "..\..\..\..\Views\Modal\ModalViewAluno.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CA5B85A21C494A507B5FEEEBE29E9E78E8465D6E"
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
    /// ModalViewAluno
    /// </summary>
    public partial class ModalViewAluno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button p_foto;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _nome;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statos;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textMes;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_detlhes;
        
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
            System.Uri resourceLocater = new System.Uri("/Jupiter;component/views/modal/modalviewaluno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
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
            
            #line 17 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.p_foto = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this._nome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.statos = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.textMes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 147 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_detlhes = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\Views\Modal\ModalViewAluno.xaml"
            this.btn_detlhes.Click += new System.Windows.RoutedEventHandler(this.btn_detlhes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

