﻿#pragma checksum "..\..\..\Pages\DrinkPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C3AE93D8BF114ABF6F64E21329AB3D2EF548461A10AE5AD1D4A6EE9BF3994F52"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MachineDrinks.Pages;
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


namespace MachineDrinks.Pages {
    
    
    /// <summary>
    /// DrinkPage
    /// </summary>
    public partial class DrinkPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\DrinkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvDrinks;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\DrinkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiAdd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\DrinkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiEdit;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\DrinkPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MachineDrinks;component/pages/drinkpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DrinkPage.xaml"
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
            this.LvDrinks = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.MiAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\..\Pages\DrinkPage.xaml"
            this.MiAdd.Click += new System.Windows.RoutedEventHandler(this.MiAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MiEdit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\..\Pages\DrinkPage.xaml"
            this.MiEdit.Click += new System.Windows.RoutedEventHandler(this.MiEdit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MiDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\Pages\DrinkPage.xaml"
            this.MiDelete.Click += new System.Windows.RoutedEventHandler(this.MiDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

