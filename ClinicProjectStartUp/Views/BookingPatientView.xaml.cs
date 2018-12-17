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
using MySql.Data.MySqlClient;
using System.Data;
using ClinicProjectStartUp.Common;

namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for BookingPatientView.xaml
    /// </summary>
    public partial class BookingPatientView : UserControl
    {
        private string selectedpatient;
        private string spatientname;
        public BookingPatientView()
        {
            InitializeComponent();
        }

        private void Create_Booking_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            BookingPatientCreateView npatient = new BookingPatientCreateView();
            npatient.ShowDialog();
            if (npatient.status_ok)
            {
                LoadPatientData();
            }
        }

        private void Cancel_Booking_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            if (WsApplication.pid != null)
            {
                MySqlConnection MyCon = WsApplication.ConnectionString();
                try
                {
                    MyCon.Open();
                    MySqlCommand cmd = MyCon.CreateCommand();
                    cmd.CommandText = "select name from patient where id='" + WsApplication.pid + "'";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //I would also check for DB.Null here before reading the value.
                            string item = reader.GetString(reader.GetOrdinal("name"));
                            WsApplication.pname = item;
                            spatientname = item;
                        }
                    }
                    MyCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBoxResult result = MessageBox.Show("Do you want to Cancel the Booking Patient =" + WsApplication.pname + " ?", "Confirm To Cancel Booking Patient!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        try
                        {
                            MyCon.Open();
                            MySqlCommand cmd = MyCon.CreateCommand();
                            cmd.CommandText = "delete from  patient  where id='" + WsApplication.pid + "'";
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MyCon.Close();
                            MessageBox.Show(" Successfully Cancel Booking Patient!!");
                            LoadPatientData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case MessageBoxResult.No:
                        LoadPatientData();
                        break;

                }
            }
            else
            {
                MessageBox.Show("No Patient to Cancel(Please Double Click To Select Booking Patient!!");
                LoadPatientData();
            }
        }

        private void gc_booking_patient_tbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gc_booking_patient_list.BeginSelection();
            foreach (int row_handler in gc_booking_patient_list.GetSelectedRowHandles())
            {
                selectedpatient = gc_booking_patient_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.pid = selectedpatient;
        }

        private void gc_booking_patient_tbl_RowDoubleClick(object sender, DevExpress.Xpf.Grid.RowDoubleClickEventArgs e)
        {
            gc_booking_patient_list.BeginSelection();
            foreach (int row_handler in gc_booking_patient_list.GetSelectedRowHandles())
            {
                selectedpatient = gc_booking_patient_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.pid = selectedpatient;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();

                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "select p.id,p.name,p.address,p.age,p.m_status,p.health_status,d.doctorName,p.p_status from patient p left join doctor d on p.doctor_id=d.id order by p.ts desc";
                MySqlDataReader reader = cmd.ExecuteReader();
                gc_booking_patient_list.ItemsSource = reader;

                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
