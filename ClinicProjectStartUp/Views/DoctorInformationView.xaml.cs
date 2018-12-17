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
    /// Interaction logic for DoctorInformationView.xaml
    /// </summary>
    public partial class DoctorInformationView : UserControl
    {
        private string selecteddoctor;
        private string selecteddoctorname;
        public DoctorInformationView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDoctorDate();
        }

        private void Create_Doctor_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            AddDoctorView npatient = new AddDoctorView();
            npatient.ShowDialog();
            if (npatient.status_Ok)
            {
                MessageBox.Show("Created Successfully");
                LoadDoctorDate();
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
                    cmd.CommandText = "select doctorName from doctor where id='" + WsApplication.d_id + "'";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            string item = reader.GetString(reader.GetOrdinal("doctorName"));
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
                            cmd.CommandText = "delete from  doctor  where id='" + WsApplication.d_id + "'";
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MyCon.Close();
                            MessageBox.Show(" Successfully Delete Doctor!!");
                            LoadDoctorDate();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case MessageBoxResult.No:
                        LoadDoctorDate();
                        break;

                }
            }
            else
            {
                MessageBox.Show("No Doctor to Delete(Please Double Click To Select Doctor !!");
                LoadDoctorDate();
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
        private void LoadDoctorDate()
        {
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();

                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "select d.doctorName,d.position,d.specialist,d.work_experience,d.age,d.degree,d.id from doctor d order by d.ts desc;";
                MySqlDataReader reader = cmd.ExecuteReader();
                gc_doctor_list.ItemsSource = reader;

                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
