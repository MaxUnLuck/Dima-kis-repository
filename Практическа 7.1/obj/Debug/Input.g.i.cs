﻿#pragma checksum "..\..\Input.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C6485150878A926FE850C522D2A7FC0815A3973D3CC564650E8371BD829C7BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Практическа_7._1;


namespace Практическа_7._1 {
    
    
    /// <summary>
    /// Input
    /// </summary>
    public partial class Input : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calc;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CalcTB;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Num1TextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Num2TextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Division;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Comparison;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Composition;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Rounding;
        
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
            System.Uri resourceLocater = new System.Uri("/Практическа 7.1;component/input.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Input.xaml"
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
            this.Calc = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Input.xaml"
            this.Calc.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CalcTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Input.xaml"
            this.CalcTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Num1TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\Input.xaml"
            this.Num1TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Num1TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Num2TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\Input.xaml"
            this.Num2TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Division = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\Input.xaml"
            this.Division.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Comparison = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.Composition = ((System.Windows.Controls.RadioButton)(target));
            
            #line 75 "..\..\Input.xaml"
            this.Composition.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Rounding = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            
            #line 77 "..\..\Input.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

