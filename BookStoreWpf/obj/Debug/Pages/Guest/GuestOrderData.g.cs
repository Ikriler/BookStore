﻿#pragma checksum "..\..\..\..\Pages\Guest\GuestOrderData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36CD6D4DDCDA2D5666FA13A91CFD8CB315C77B532DD9085253B1C5126B319D10"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStoreWpf.Pages.Guest;
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


namespace BookStoreWpf.Pages.Guest {
    
    
    /// <summary>
    /// GuestOrderData
    /// </summary>
    public partial class GuestOrderData : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTB;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleNameTB;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressTB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStoreWpf;component/pages/guest/guestorderdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
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
            this.FirstNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MiddleNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LastNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddressTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SaveOrder = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\Guest\GuestOrderData.xaml"
            this.SaveOrder.Click += new System.Windows.RoutedEventHandler(this.SaveOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
