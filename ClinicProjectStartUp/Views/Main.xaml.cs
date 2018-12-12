using ClinicProjectStartUp.Common;
using ClinicProjectStartUp.model;
using DevExpress.Xpf.NavBar;
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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public void Subscribe(NormaleCustomerView m)
        {
            m.navhandler += new NormaleCustomerView.NavHandler(OpenIt);
        }
        private void OpenIt(CodeValueEventArgs e)
        {
            foreach (CodeValue cv in e.CodeValues)
            {
                if (cv.code.ToUpper() == "queueNo".ToUpper())
                {
                    //WsApplication.queueNo = cv.value.ToString();
                    navframe.Navigate("SaleOrderList");
                    break;
                }

            }
        }
        public Main()
        {
            InitializeComponent();
            navbar.View.ItemSelecting += new NavBarItemSelectingEventHandler(navBar_ItemSelecting);
            navframe.Navigate("NormaleCustomerView");
        }

        private void navBar_ItemSelecting(object sender, NavBarItemSelectingEventArgs e)
        {
            if (e.NewItem.Content.ToString() == "Booking Patients")
            {
                navframe.Navigate("BookingPatientView");
            }                
            else if (e.NewItem.Content.ToString()== "Normal Patients")
            {
                navframe.Navigate("NormaleCustomerView");
            }
        }

        private void RibbonControl_Loaded(object sender, RoutedEventArgs e)
        {
            WsApplication.main = this;
        }
    }
}
