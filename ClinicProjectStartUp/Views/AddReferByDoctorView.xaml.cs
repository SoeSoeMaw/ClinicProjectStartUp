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
using ClinicProjectStartUp.Common;

namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for AddReferByDoctorView.xaml
    /// </summary>
    public partial class AddReferByDoctorView : ThemedWindow
    {
        public bool status_Ok;
        public AddReferByDoctorView()
        {
            InitializeComponent();
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreateDoctor_Click(object sender, RoutedEventArgs e)
        {
            string docName = doctorName.Text;
            string d_address = address.Text;
            string d_remark = remark.Text;
           
            status_Ok = true;
            this.Close();
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();
                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "insert into refer_doctor(name,address,remark,count_point,active,is_delete,ts) values('" + docName + "','" + d_address + "','" + d_remark + "','" + 0 + "','" + 1 + "','" + 0 + "','" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "');";
                MySqlDataReader reader = cmd.ExecuteReader();
                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
