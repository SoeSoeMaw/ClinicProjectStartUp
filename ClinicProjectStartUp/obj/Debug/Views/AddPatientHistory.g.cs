﻿#pragma checksum "..\..\..\Views\AddPatientHistory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A795B269FFE6C163EFE97642DCC09645496F7C37"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
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
    /// AddPatientHistory
    /// </summary>
    public partial class AddPatientHistory : DevExpress.Xpf.Core.ThemedWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patientname;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox history_status;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox history_amount;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox doctor_fee;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDate;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_doctor_name;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox servicecharges;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tax;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox handovercheck;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_handover_doctor;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Views\AddPatientHistory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/ClinicProjectStartUp;component/views/addpatienthistory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddPatientHistory.xaml"
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
            
            #line 10 "..\..\..\Views\AddPatientHistory.xaml"
            ((ClinicProjectStartUp.Views.AddPatientHistory)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ThemedWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.patientname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.history_status = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.history_amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.doctor_fee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dtpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.combo_doctor_name = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.servicecharges = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.handovercheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 153 "..\..\..\Views\AddPatientHistory.xaml"
            this.handovercheck.Checked += new System.Windows.RoutedEventHandler(this.handovercheck_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.combo_handover_doctor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.btnCreateHistory = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\Views\AddPatientHistory.xaml"
            this.btnCreateHistory.Click += new System.Windows.RoutedEventHandler(this.btnCreateHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

