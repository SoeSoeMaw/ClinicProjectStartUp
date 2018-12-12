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
        public NormaleCustomerView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Create_New_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            NewPatientCreate npatient = new NewPatientCreate();
            npatient.ShowDialog();
            if (npatient.status_ok)
            {
                // Return Back To List
                MessageBox.Show("Save Successfully");
            }
        }

        private void Delete_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void View_Patient_History_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void Add_Patient_History_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void Confirm_Patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void filter_patient_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            //WsApplication.main.Subscribe(this);
            //if (navhandler != null)
            //{
            //    CodeValueEventArgs args = new CodeValueEventArgs();
            //    args.CodeValues = new List<CodeValue>
            //                {
            //                    new CodeValue() {code = "queueNo", value = selected_row_queueNo }
            //                };
            //    navhandler(args);
            //    WsApplication.main.Subscribe(this);
            //}
            PatientListFilter pFilter = new PatientListFilter();
            pFilter.ShowDialog();
            if (pFilter.status_ok)
            {
                MessageBox.Show(pFilter.patientstatus);
                //ApiHelper apihelper = new ApiHelper();

                //var token = apihelper.getAuthToken(WsApplication.authuser);
                //if (token != null)
                //{
                //    List<object> queues = apihelper.getAllOrderHdrByFilter(token.token, ordFilter.from_date, ordFilter.to_date, ordFilter.is_deliver);
                //    gc_sale_order_hdr.ItemsSource = queues;
                //    foreach (object obj in queues)
                //    {
                //        JObject ord = JObject.Parse(obj.ToString());
                //        selected_row_orderno = (string)ord["orderno"];
                //        WsApplication.orderNo = (string)ord["orderno"];
                //        WsApplication.queueNo = (string)ord["queueNo"];
                //        loadOrderDetail(selected_row_orderno);
                //        loadPreviewOrderRpt(selected_row_orderno);
                //        break;
                //    }

                //}
            }
        }

        private void gc_patient_tbl_RowDoubleClick(object sender, DevExpress.Xpf.Grid.RowDoubleClickEventArgs e)
        {

        }

        private void gc_patient_tbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
