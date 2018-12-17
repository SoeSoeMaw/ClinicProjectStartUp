using ClinicProjectStartUp.Common;
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
    /// Interaction logic for ReferByDoctorView.xaml
    /// </summary>
    public partial class ReferByDoctorView : UserControl
    {
        private string selecteddoctor;
        private string selecteddoctorname;
        public ReferByDoctorView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDoctorData();
        }
        private void LoadDoctorData()
        {
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();

                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "select r.id,r.name,r.address,r.remark from refer_doctor r order by r.ts;";
                MySqlDataReader reader = cmd.ExecuteReader();
                gc_doctor_list.ItemsSource = reader;

                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Create_Doctor_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            AddReferByDoctorView npatient = new AddReferByDoctorView();
            npatient.ShowDialog();
            if (npatient.status_Ok)
            {
                MessageBox.Show("Created Successfully");
                LoadDoctorData();
            }
        }
    

        private void Delete_Doctor_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            if (WsApplication.d_id != null)
            {
                MySqlConnection MyCon = WsApplication.ConnectionString();
                try
                {
                    MyCon.Open();
                    MySqlCommand cmd = MyCon.CreateCommand();
                    cmd.CommandText = "select name from refer_doctor where id='" + WsApplication.d_id + "'";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            string item = reader.GetString(reader.GetOrdinal("name"));
                            WsApplication.d_name = item;
                            selecteddoctorname = item;
                        }
                    }
                    MyCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBoxResult result = MessageBox.Show("Do you want to Delete The Doctor =" + WsApplication.d_name + " ?", "Confirm To Delete Doctor!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        try
                        {
                            MyCon.Open();
                            MySqlCommand cmd = MyCon.CreateCommand();
                            cmd.CommandText = "delete from  refer_doctor  where id='" + WsApplication.d_id + "'";
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MyCon.Close();
                            MessageBox.Show(" Successfully Delete Doctor!!");
                            LoadDoctorData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case MessageBoxResult.No:
                        LoadDoctorData();
                        break;

                }
            }
            else
            {
                MessageBox.Show("No Doctor to Delete(Please Double Click To Select Doctor !!");
                LoadDoctorData();
            }
        }

        private void gc_patient_tbl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gc_doctor_list.BeginSelection();
            foreach (int row_handler in gc_doctor_list.GetSelectedRowHandles())
            {
                selecteddoctor = gc_doctor_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.d_id = selecteddoctor;
        }

        private void gc_patient_tbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gc_doctor_list.BeginSelection();
            foreach (int row_handler in gc_doctor_list.GetSelectedRowHandles())
            {
                selecteddoctor = gc_doctor_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.d_id = selecteddoctor;
        }
    }
}
