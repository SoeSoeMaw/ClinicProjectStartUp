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
using ClinicProjectStartUp.Common;
using MySql.Data.MySqlClient;

namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for ViewPatientHistory.xaml
    /// </summary>
    public partial class ViewPatientHistory : ThemedWindow
    {
        public bool status_ok;
        public ViewPatientHistory()
        {
            InitializeComponent();
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();
                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "select p.name,p.address,p.phone,p.age,p.m_status,p.health_status,p.service_charges,d.doctorName as doctor_name,p.ts from patient p left join doctor d on p.doctor_id=d.id where p.id='" + WsApplication.pid + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //I would also check for DB.Null here before reading the value.
                        string item = reader.GetString(reader.GetOrdinal("name"));
                        WsApplication.pname = item;
                        patientname.Text= reader.GetString(reader.GetOrdinal("name"));
                        address.Text = reader.GetString(reader.GetOrdinal("address"));
                        phoneno.Text = reader.GetString(reader.GetOrdinal("phone"));
                        age.Text = reader.GetString(reader.GetOrdinal("age"));
                        marital_status.Text = reader.GetString(reader.GetOrdinal("m_status"));
                        healthstatus.Text = reader.GetString(reader.GetOrdinal("health_status"));
                        servicecharges.Text = reader.GetString(reader.GetOrdinal("service_charges"));
                        dtpDate.SelectedDate = reader.GetDateTime(reader.GetOrdinal("ts"));
                        doctor_name.Text = reader.GetString(reader.GetOrdinal("doctor_name"));

                    }
                }
                MyCon.Close();
                MyCon.Open();
                MySqlCommand cmd1 = MyCon.CreateCommand();
                cmd.CommandText = "select h.lineno,p.name,h.history_amount,h.history_status,h.doctor_fee,h.medical_fee,h.tax,h.service_charges,h.appointment_date,d.doctorName as doctor_name,d1.doctorName as hand_over_name from history h left join patient p on h.patient_id=p.id left join doctor d on d.id=h.doctor_id left join doctor d1 on d1.id=h.hand_over_by where p.id='" + WsApplication.pid + "'";
                MySqlDataReader reader1 = cmd.ExecuteReader();
                gc_patient_history.ItemsSource = reader1;
                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            status_ok = true;
            
        }
    }
}
