using DevExpress.Xpf.Core;
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
            string fs = dtpFromDate.SelectedDate.Value.ToShortDateString() + " 00:00:00";
            string ts = dtpToDate.SelectedDate.Value.ToShortDateString() + " 23:59:59";

            from_date = Convert.ToDateTime(fs);
            to_date = Convert.ToDateTime(ts);
            status_ok = true;
            patientstatus = combo_patient_type.SelectedItem.ToString();
            this.Close();
        }

      
    }
}
