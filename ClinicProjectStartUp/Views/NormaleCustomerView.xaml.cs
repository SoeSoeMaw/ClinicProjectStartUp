using ClinicProjectStartUp.Common;
using ClinicProjectStartUp.model;
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
using DevExpress.Xpf.Core;
using MySql.Data.MySqlClient;
using System.Data;


namespace ClinicProjectStartUp.Views
{
    /// <summary>
    /// Interaction logic for NormaleCustomerView.xaml
    /// </summary>
   
    public class CodeValueEventArgs : EventArgs
    {
        public List<CodeValue> CodeValues { get; set; }
    }
    public partial class NormaleCustomerView : UserControl
    {
        public event NavHandler navhandler;
        public delegate void NavHandler(CodeValueEventArgs e);
        private string selectedpatient;
        private string spatientname;
        public NormaleCustomerView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            WsApplication.pid = null;
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            MySqlConnection MyCon = WsApplication.ConnectionString();
            try
            {
                MyCon.Open();

                MySqlCommand cmd = MyCon.CreateCommand();
                cmd.CommandText = "select p.id,p.name,p.address,p.age,p.m_status,p.health_status,d.doctorName,p.p_status from patient p left join doctor d on p.doctor_id=d.id";
                MySqlDataReader reader = cmd.ExecuteReader();
                gc_patient_list.ItemsSource = reader;

                MyCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Create_New_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            NewPatientCreate npatient = new NewPatientCreate();
            npatient.ShowDialog();
            if (npatient.status_ok)
            {
                LoadPatientData();
            }
        }

        private void Delete_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            if(WsApplication.pid != null)
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
                MessageBoxResult result = MessageBox.Show("Do you want to delete the  Patient =" + WsApplication.pname + " Information?", "Confirm To Add Patient History!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        try
                        {
                            MyCon.Open();
                            MySqlCommand cmd = MyCon.CreateCommand();
                            cmd.CommandText = "delete from patient where id='" + WsApplication.pid + "'";
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MyCon.Close();
                            MyCon.Open();
                            MySqlCommand cmd1 = MyCon.CreateCommand();
                            cmd1.CommandText = "delete from history where patient_id='" + WsApplication.pid + "'";
                            MySqlDataReader reader1 = cmd1.ExecuteReader();
                            MyCon.Close();
                            MessageBox.Show("Deleted Successfully!!");
                            LoadPatientData();
                        }
                        catch(Exception ex)
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
                MessageBox.Show("No Patient to Delete");
            }
            
        }

        private void View_Patient_History_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
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
                MessageBoxResult result = MessageBox.Show("Do You View History of Patient=" + spatientname + "?", "Confirm To Add Patient History!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        ViewPatientHistory npatient = new ViewPatientHistory();
                        npatient.ShowDialog();
                        if (npatient.status_ok)
                        {
                            LoadPatientData();
                        }
                        break;
                    case MessageBoxResult.No:
                        LoadPatientData();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Please Select At Least One Patient to Add History");
            }
        }

        private void Add_Patient_History_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            if(WsApplication.pid != null)
            {
                MySqlConnection MyCon = WsApplication.ConnectionString();
                try
                {
                    MyCon.Open();
                    MySqlCommand cmd = MyCon.CreateCommand();
                    cmd.CommandText = "select name from patient where id='"+WsApplication.pid+"'";
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
                MessageBoxResult result = MessageBox.Show("Do You Want to History For Patient=" + spatientname + "?", "Confirm To Add Patient History!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        AddPatientHistory npatient = new AddPatientHistory();
                        npatient.ShowDialog();
                        if (npatient.status_ok)
                        {
                            LoadPatientData();
                        }
                        break;
                    case MessageBoxResult.No:
                        LoadPatientData();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Please Select At Least One Patient to Add History");
            }
        }

        private void Confirm_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
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
                MessageBoxResult result = MessageBox.Show("Do you want to Upate the  Patient =" + WsApplication.pname + " To Completed?", "Confirm To Add Patient History!!", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        try
                        {
                            MyCon.Open();
                            MySqlCommand cmd = MyCon.CreateCommand();
                            cmd.CommandText = "update patient set p_status='Completed' where id='" + WsApplication.pid + "'";
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MyCon.Close();
                            MessageBox.Show(" Successfully Updated!!");
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
                MessageBox.Show("No Patient to Update");
                LoadPatientData();
            }
        }

        private void filter_patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            
            PatientListFilter pFilter = new PatientListFilter();
            pFilter.ShowDialog();
            if (pFilter.status_ok)
            {
                MySqlConnection MyCon = WsApplication.ConnectionString();
                try
                {
                    MyCon.Open();

                    MySqlCommand cmd = MyCon.CreateCommand();
                    cmd.CommandText = "select p.id,p.name,p.address,p.age,p.m_status,p.health_status,d.doctorName,p.p_status from patient p left join doctor d on p.doctor_id=d.id where p.ts>='"+WsApplication.fd+"' and  p.ts<='"+WsApplication.td+"'";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    gc_patient_list.ItemsSource = reader;

                    MyCon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(pFilter.patientstatus);
                pFilter.Close();
                
            }
        }

        private void gc_patient_tbl_RowDoubleClick(object sender, DevExpress.Xpf.Grid.RowDoubleClickEventArgs e)
        {
            gc_patient_list.BeginSelection();
            foreach (int row_handler in gc_patient_list.GetSelectedRowHandles())
            {
                selectedpatient = gc_patient_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.pid = selectedpatient;
        }

        private void gc_patient_tbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gc_patient_list.BeginSelection();
            foreach (int row_handler in gc_patient_list.GetSelectedRowHandles())
            {
                selectedpatient = gc_patient_list.GetCellValue(row_handler, "id").ToString();

                break;
            }
            WsApplication.pid = selectedpatient;
        }

        private void Add_Doctor_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            AddDoctorView npatient = new AddDoctorView();
            npatient.ShowDialog();
            if (npatient.status_Ok)
            {
                MessageBox.Show("Created Successfully");
                LoadPatientData();
            }
        }
    }
}
