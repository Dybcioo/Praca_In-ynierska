﻿using DataModel;
using SuperKurier.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperKurier.View
{
    /// <summary>
    /// Interaction logic for ParcelView.xaml
    /// </summary>
    public partial class ParcelView : Page
    {

        CompanyEntities companyEntities;

        public ParcelView()
        {
            InitializeComponent();

            this.companyEntities = new CompanyEntities();
            gridDataInitialize();
        }

        private void gridDataInitialize()
        {
            try
            {
                DataGridParcel.DataContext = companyEntities.Parcel.ToList();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnSearchParcel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnParcelAdd_Click(object sender, RoutedEventArgs e)
        {
            ((ParcelViewModel)DataContext).AddViewModel = new ParcelAddViewModel() { VisibilityOption = Visibility.Visible };
            frame.Visibility = Visibility;
        }
    }
}
