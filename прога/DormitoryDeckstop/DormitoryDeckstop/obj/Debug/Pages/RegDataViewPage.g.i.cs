// Updated by XamlIntelliSenseFileGenerator 17.05.2021 15:54:50
#pragma checksum "..\..\..\Pages\RegDataViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC78651B54BC1B354B85F960C1C08F7DDD1FDA4A78071012A62874B70C02E66C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DormitoryDeckstop.Pages;
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


namespace DormitoryDeckstop.Pages
{


    /// <summary>
    /// RegDataViewPage
    /// </summary>
    public partial class RegDataViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 30 "..\..\..\Pages\RegDataViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;

#line default
#line hidden


#line 39 "..\..\..\Pages\RegDataViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid userdatagrid;

#line default
#line hidden


#line 49 "..\..\..\Pages\RegDataViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletebtn;

#line default
#line hidden


#line 56 "..\..\..\Pages\RegDataViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updatebtn;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DormitoryDeckstop;component/pages/regdataviewpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\RegDataViewPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 7 "..\..\..\Pages\RegDataViewPage.xaml"
                    ((DormitoryDeckstop.Pages.RegDataViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.back = ((System.Windows.Controls.Button)(target));

#line 37 "..\..\..\Pages\RegDataViewPage.xaml"
                    this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.userdatagrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 4:
                    this.deletebtn = ((System.Windows.Controls.Button)(target));

#line 55 "..\..\..\Pages\RegDataViewPage.xaml"
                    this.deletebtn.Click += new System.Windows.RoutedEventHandler(this.deletebtn_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.updatebtn = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\..\Pages\RegDataViewPage.xaml"
                    this.updatebtn.Click += new System.Windows.RoutedEventHandler(this.updatebtn_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox search;
    }
}

