﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98BAF1BE8C34BD51DBC5FB499408BCA2A0FDE0BA7F9A414DEE097D045A670B73"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ExperimentWithControls;
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


namespace ExperimentWithControls {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock number;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox myListBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox readOnlyComboBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox editableComboBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider smallSlider;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider bigSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/ExperimentWithControls;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.number = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.numberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.numberTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.numberTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 31 "..\..\MainWindow.xaml"
            this.numberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numberTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.myListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.myListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.myListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.readOnlyComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\MainWindow.xaml"
            this.readOnlyComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.readOnlyComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.editableComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 65 "..\..\MainWindow.xaml"
            this.editableComboBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numberTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 66 "..\..\MainWindow.xaml"
            this.editableComboBox.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.editableComboBox_TextChanged));
            
            #line default
            #line hidden
            return;
            case 12:
            this.smallSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.smallSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.bigSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 74 "..\..\MainWindow.xaml"
            this.bigSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.bigSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
