﻿#pragma checksum "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7EE49992C810D44948623CC5EBC33F16267223396F76D680E385976E434852FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStoreWpf.Pages.Admin;
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


namespace BookStoreWpf.Pages.Admin {
    
    
    /// <summary>
    /// AdminCreateProduct
    /// </summary>
    public partial class AdminCreateProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QunatityTB;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImagePathTB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTB;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStoreWpf;component/pages/admin/admincreateproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
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
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DescriptionTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.QunatityTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ImagePathTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PriceTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SaveProduct = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\Admin\AdminCreateProduct.xaml"
            this.SaveProduct.Click += new System.Windows.RoutedEventHandler(this.SaveProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

