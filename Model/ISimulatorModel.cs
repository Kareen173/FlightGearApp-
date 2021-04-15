using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FlightSimulatorApp.Model
{
    public interface ISimulatorModel : INotifyPropertyChanged
    {
        //Methods that are responsible for connecting to the simulator
        void Connect(string ip, string port);
        void Disconnect();
        void Start();
        void SendCommandToSimulator(string command);

        //Simulator Properties
        string Heading { get; set; }
        string VerticalSpeed { get; set; }
        string GroundSpeed { get; set; }
        string AirSpeed { get; set; }
        string Altitude { get; set; }
        string InternalRoll { get; set; }
        string InternalPitch { get; set; }
        string Altimeter { get; set; }

        //Activate actuators
        double Rudder { get; set; }
        double Elevator { get; set; }
        double Aileron { get; set; }
        double Throttle { get; set; }

        //Connection buttons' property
        string CurrStatus { get; set; }
        string Err { get; set; }
        string IPaddress { get; set; }
        string Port { get; set; }
        string fpath { get; set; }
    }
}
