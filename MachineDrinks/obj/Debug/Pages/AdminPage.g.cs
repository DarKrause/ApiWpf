#pragma checksum "..\..\..\Pages\AdminPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F05692D8587D2AFD1624778F7B9B5B43CDC3F9B357DAB8A569839A60AC845A6"
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
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCoin;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDrinks;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOtchet;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrm;
        
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
            System.Uri resourceLocater = new System.Uri("/MachineDrinks;component/pages/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AdminPage.xaml"
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
            this.BtnCoin = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\AdminPage.xaml"
            this.BtnCoin.Click += new System.Windows.RoutedEventHandler(this.BtnCoin_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnDrinks = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Pages\AdminPage.xaml"
            this.BtnDrinks.Click += new System.Windows.RoutedEventHandler(this.BtnDrinks_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnOtchet = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\AdminPage.xaml"
            this.BtnOtchet.Click += new System.Windows.RoutedEventHandler(this.BtnOtchet_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainFrm = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

