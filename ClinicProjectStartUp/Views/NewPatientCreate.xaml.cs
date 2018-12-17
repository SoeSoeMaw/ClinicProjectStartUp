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
    /// Interaction logic for NewPatientCreate.xaml
    /// </summary>
    public partial class NewPatientCreate : ThemedWindow
    {
        public bool status_ok { get; set; }
        public NewPatientCreate()
        {
            InitializeComponent();
            PrepareData();
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void PrepareData()
        {
            dtpDate.SelectedDate = DateTime.Now;
            //MySqlConnection MyCon = WsApplication.ConnectionString();

            //try
            //{
            //    MyCon.Open();
            //    MySqlCommand cmd = MyCon.CreateCommand();
            //    cmd.CommandText = "select id,doctorName from doctor ";
            //    MessageBox.Show("OPen");
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    combo_doctor_name.ItemsSource = reader;
            //    combo_doctor_name.SelectedValuePath = "id";
            //    combo_doctor_name.DisplayMemberPath = "doctorName";
            //    MyCon.Close();
               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            combo_doctor_name.Items.Add(1);
            combo_doctor_name.Items.Add(2);
            combo_marital_status.Items.Add("Single");
            combo_marital_status.Items.Add("Marriage");
            combo_gender.Items.Add("Male");
            combo_gender.Items.Add("Female");
        }

        private void refercheck_Checked(object sender, RoutedEventArgs e)
        {
            referdoctor.IsEnabled = true;
            referdaddress.IsEnabled = true;
            referremark.IsEnabled = true;

        }

        private void btnFilterPatient_Click(object sender, RoutedEventArgs e)
        {
            string pname = patientname.Text;
            string paddress = address.Text;
            string phone = phoneno.Text;
            int page = Int32.Parse(age.Text);
            string m_status = combo_marital_status.SelectedValue.ToString();
            string h_status = healthstatus.Text;
            string d_id = combo_doctor_name.SelectedValue.ToString();
            Decimal scharges =Decimal.Parse(servicecharges.Text);
            string pstatus = "Normal";
            decimal tamt = 0;
            status_ok = true;
            this.Close();
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();
                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "insert into patient(name,address,phone,doctor_id,age,m_status,health_status,service_charges,p_status,total_amount,active,is_delete,ts) values('"+pname+"','"+paddress+"','"+phone+"','"+d_id + "','"+page + "','"+m_status + "','"+h_status + "','"+ scharges + "','"+pstatus + "','"+tamt + "','"+1+ "','"+0 + "','" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "');"; 
                MySqlDataReader reader = cmd.ExecuteReader();
                MyCon.Close();
                if (refercheck.IsChecked == true)
                {
                    string refname = referdoctor.Text;
                    string refaddress = referdaddress.Text;
                    string refremark = referremark.Text;
                    int copoint = 1;
                    string s = "";
                    MyCon.Open();
                    MySqlCommand cmd1 = MyCon.CreateCommand();
                    cmd1.CommandText = "insert into refer_doctor(name,address,remark,count_point,active,is_delete,ts,refer_doctorcol) values('" + refname + "','" + refaddress + "','" + refremark  + "','" + copoint + "','" + 1 + "','" + 0 + "','" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") +"','"+s+ "');";
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    MyCon.Close();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
