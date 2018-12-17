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
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;
using System.Data;
using ClinicProjectStartUp.Common;


namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for AddPatientHistory.xaml
    /// </summary>
    public partial class AddPatientHistory : ThemedWindow
    {
        public bool status_ok { get; set; }
        public AddPatientHistory()
        {
            InitializeComponent();
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dtpDate.SelectedDate = DateTime.Now;
            combo_doctor_name.Items.Add(1);
            combo_handover_doctor.Items.Add(1);
            patientname.Text = WsApplication.pname;
            patientname.IsEnabled = false;
            combo_handover_doctor.IsEnabled = false;
        }

        private void btnCreateHistory_Click(object sender, RoutedEventArgs e)
        {
            string lineno = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Millisecond.ToString();
            lineno = "111";
            string h_status = history_status.Text;
            decimal h_amount = Decimal.Parse(history_amount.Text);
            decimal d_fee = Decimal.Parse(doctor_fee.Text);
            decimal m_fee = Decimal.Parse(history_amount.Text);
            decimal ptax = Decimal.Parse(tax.Text);
            decimal s_charges = Decimal.Parse(servicecharges.Text);
            //DateTime fs = new DateTime(dtpDate.SelectedDate.Value.Year,
            //   dtpDate.SelectedDate.Value.Month, dtpDate.SelectedDate.Value.Day, dtpDate.SelectedDate.Value.Hour, dtpDate.SelectedDate.Value.Minute, dtpDate.SelectedDate.Value.Second);
            string fs = dtpDate.SelectedDate.Value.ToString("yyyy-MM-dd 00:00:00");
            string d_id = combo_doctor_name.SelectedItem.ToString();
            string h_id = "";
            if(handovercheck.IsChecked == true)
            {
                 h_id = combo_handover_doctor.SelectedItem.ToString();
            }
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();
                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "insert into history(patient_id,lineno,history_status,history_amount,doctor_fee,medical_fee,tax,service_charges,appointment_date,doctor_id,hand_over_by,active,is_delete,ts) values('" + WsApplication.pid + "','" + lineno + "','" + h_status + "','" + h_amount + "','" + d_fee + "','" + m_fee + "','" + ptax + "','" + s_charges + "','" + fs + "','" + d_id + "','"+ h_id + "','" + 1 + "','" + 0 + "','" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "');";
                MySqlDataReader reader = cmd.ExecuteReader();
                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            status_ok = true;
            this.Close();
        }

        private void handovercheck_Checked(object sender, RoutedEventArgs e)
        {
            combo_handover_doctor.IsEnabled = true;
        }
    }
}
