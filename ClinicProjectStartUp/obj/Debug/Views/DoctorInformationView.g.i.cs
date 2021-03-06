﻿#pragma checksum "..\..\..\Views\DoctorInformationView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AF609F35610699293A4B6DDF1BBD9F7F47E2935"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClinicProjectStartUp.Views;
using DevExpress.Core;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
using DevExpress.Xpf.NavBar;
using DevExpress.Xpf.Ribbon;
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


namespace ClinicProjectStartUp.Views {
    
    
    /// <summary>
    /// DoctorInformationView
    /// </summary>
    public partial class DoctorInformationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\Views\DoctorInformationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem Create_Doctor;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\DoctorInformationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem Delete_Doctor;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\DoctorInformationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.GridControl gc_doctor_list;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Views\DoctorInformationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Grid.TableView gc_patient_tbl;
        
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
            System.Uri resourceLocater = new System.Uri("/ClinicProjectStartUp;component/views/doctorinformationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DoctorInformationView.xaml"
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
            
            #line 15 "..\..\..\Views\DoctorInformationView.xaml"
            ((ClinicProjectStartUp.Views.DoctorInformationView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Create_Doctor = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            
            #line 65 "..\..\..\Views\DoctorInformationView.xaml"
            this.Create_Doctor.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(this.Create_Doctor_ItemClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete_Doctor = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            
            #line 70 "..\..\..\Views\DoctorInformationView.xaml"
            this.Delete_Doctor.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(this.Delete_Doctor_ItemClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gc_doctor_list = ((DevExpress.Xpf.Grid.GridControl)(target));
            return;
            case 5:
            this.gc_patient_tbl = ((DevExpress.Xpf.Grid.TableView)(target));
            
            #line 124 "..\..\..\Views\DoctorInformationView.xaml"
            this.gc_patient_tbl.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.gc_patient_tbl_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 125 "..\..\..\Views\DoctorInformationView.xaml"
            this.gc_patient_tbl.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.gc_patient_tbl_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

