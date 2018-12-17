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
    /// Interaction logic for AddDoctorView.xaml
    /// </summary>
    public partial class AddDoctorView : ThemedWindow
    {
        public bool status_Ok;
        public AddDoctorView()
        {
            InitializeComponent();
        }

        private void btnCreateDoctor_Click(object sender, RoutedEventArgs e)
        {
            string docName = doctorName.Text;
            string dpo = position.Text;
            string dsp = specialist.Text;
            string wexp = work_experience.Text;
            int dage = int.Parse(age.Text);
            string ddegree = degree.Text;
            status_Ok = true;
            this.Close();
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();
                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "insert into doctor(doctorName,position,specialist,work_experience,age,degree,active,is_delete,ts) values('" + docName + "','" + dpo + "','" + dsp + "','" + wexp + "','" + dage + "','" + ddegree + "','" + 1 + "','" + 0 + "','" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "');";
                MySqlDataReader reader = cmd.ExecuteReader();
                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemedWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
