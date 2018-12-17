using ClinicProjectStartUp.Common;
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for PatientListFilter.xaml
    /// </summary>
    public partial class PatientListFilter : ThemedWindow
    {
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public string  patientstatus { get; set; }
        public bool status_ok { get; set; }
        public PatientListFilter()
        {
            InitializeComponent();
            PrepareData();
        }
        private void PrepareData()
        {
            dtpFromDate.SelectedDate = DateTime.Now;
            dtpToDate.SelectedDate = DateTime.Now;
            combo_patient_type.Items.Add("Processing Patient");
            combo_patient_type.Items.Add("Completed Patient");
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnFilterPatient_Click(object sender, RoutedEventArgs e)
        {
            
            //DateTime fs = new DateTime(dtpFromDate.SelectedDate.Value.Year,
            //   dtpFromDate.SelectedDate.Value.Month, dtpFromDate.SelectedDate.Value.Day, 0, 0, 0);
            //DateTime ts = new DateTime(dtpToDate.SelectedDate.Value.Year,
            //   dtpToDate.SelectedDate.Value.Month, dtpToDate.SelectedDate.Value.Day, 23, 59, 59);
           
            status_ok = true;
            patientstatus = combo_patient_type.SelectedItem.ToString();
            WsApplication.fd = dtpFromDate.SelectedDate.Value.ToString("yyyy-MM-dd 00:00:00");
            WsApplication.td = dtpToDate.SelectedDate.Value.ToString("yyyy-MM-dd 23:59:59");
            WsApplication.pstatus = patientstatus;
            this.Close();
        }

      
    }
}
