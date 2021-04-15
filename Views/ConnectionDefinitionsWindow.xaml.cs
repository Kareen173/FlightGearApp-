using FlightSimulatorApp.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlightSimulatorApp.Views
{
    /// <summary>
    /// Interaction logic for ConnectionDefinitionsWindow.xaml
    /// </summary>
    public partial class ConnectionDefinitionsWindow : Window
    {
        private readonly ConnectionButtonsViewModel vm;
        public FlightControlsViewModel controllerViewModel;

        public object CSV_button { get; private set; }
        public object XML_button { get; private set; }

        public ConnectionDefinitionsWindow()
        {
            InitializeComponent();
            MainViewModel Main_VM = (Application.Current as App).MainVM;
            vm = Main_VM.ConnectionButtonsVM;
            DataContext = vm;
        }
    
        public void ClickedOnConnect(object sender, RoutedEventArgs e)
        {
            (Application.Current as App).MainWindowView = new MainWindow();
            (Application.Current as App).MainWindowView.Show();
            this.Close();
        }

        private void txtPort_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) // CSV butoon
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            readCSVfile();
        }
        private void readCSVfile()
        {
            try
            {
                String[] csvLine = File.ReadAllLines(controllerViewModel.VM_fpath);
                controllerViewModel.VM_CSVcopy = csvLine;
            } catch(Exception e)
            {
                Console.WriteLine("error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // XML button
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                readXMLfile();
                
        }
        private void readXMLfile()
        {
            try
            {
                String[] csvLine = File.ReadAllLines(controllerViewModel.VM_fpath);
                controllerViewModel.VM_CSVcopy = csvLine;
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
        }
    }
}
