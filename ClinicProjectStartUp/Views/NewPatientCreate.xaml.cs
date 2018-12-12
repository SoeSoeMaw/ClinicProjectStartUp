﻿using System;
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
            combo_doctor_name.Items.Add("Zaw Zaw");
            combo_doctor_name.Items.Add("Mg Mg");
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
            string pddress = address.Text;
            string phone = phoneno.Text;
            string page = age.Text;
            string health = healthstatus.Text;
            //save data from show dialog
            status_ok = true;
            this.Close();



        }
    }
}