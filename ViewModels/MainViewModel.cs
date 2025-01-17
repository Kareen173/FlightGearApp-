﻿using FlightSimulatorApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FlightSimulatorApp.ViewModels
{
    public partial class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ISimulatorModel model;
        private readonly ConnectionButtonsViewModel ConnectionButtons_vm;
        private readonly DashboardViewModel Dashboard_vm;
    //    private readonly MapViewModel Map_vm;
        private readonly FlightControlsViewModel FlightControls_vm;
        public MainViewModel(ISimulatorModel m)
        {
            model = m;
            ConnectionButtons_vm = new ConnectionButtonsViewModel(this.model);
            Dashboard_vm = new DashboardViewModel(this.model);
          //  Map_vm = new MapViewModel(this.model);
            FlightControls_vm = new FlightControlsViewModel(this.model);
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //Getters
        public ConnectionButtonsViewModel ConnectionButtonsVM {
             get { return ConnectionButtons_vm; }
        }
        public DashboardViewModel DashboardVM
        {
            get { return Dashboard_vm; }
        }
        public FlightControlsViewModel FlightControlsVM
        {
            get { return FlightControls_vm; }
        }
        //public MapViewModel MapVM
       // {
          //  get { return Map_vm; }
       // }
        public void Connect()
        {
            ConnectionButtons_vm.Connect(ConnectionButtons_vm.VM_IPaddress, ConnectionButtons_vm.VM_Port);
        }
        public void Start()
        {
            model.Start();
        }
    }
}
