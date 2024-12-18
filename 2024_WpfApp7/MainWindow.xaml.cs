﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2024_WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string aqiURL = "https://data.moenv.gov.tw/api/v2/aqf_p_01?api_key=e8dd42e6-9b8b-43f8-991e-b3dee723a52d&limit=1000&sort=publishtime%20desc&format=JSON";

		public MainWindow()
        {
            InitializeComponent();
			urlTextBox.Text = aqiURL;
		}

		private void btnGetAQI_Click(object sender, RoutedEventArgs e)
		{
             
		}
	}
}