﻿#pragma checksum "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF595592DA13C34878CD609B76F9077BF55908FB7396A46897FA92DB43981BCB"
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


namespace музыка {
    
    
    /// <summary>
    /// InstrumentPage5
    /// </summary>
    public partial class InstrumentPage5 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Min;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Img;
        
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
            System.Uri resourceLocater = new System.Uri("/музыка;component/page/instrumentspage/instrumentspage5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
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
            this.Min = ((System.Windows.Controls.Image)(target));
            
            #line 14 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
            this.Min.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Min_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
            this.CloseButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Img = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 50 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 53 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\..\..\Page\InstrumentsPage\InstrumentsPage5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

