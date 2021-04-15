# README

        Our app deals with: Flight investigation

We will build an app that will allow us to view flight data on a dedicated simulator and explore them.
Our users are flight researchers or pilots who want to view data, sampled at a certain rate during a flight. 
The flight data includes the steering mode, speed, altitude direction, etc., and are recorded into a text file, which can be loaded in our app. 
The app will play the data like a movie from the beginning of the recording until the end,
it will graphically display the plane in relation to the earth, the rudder position, 
and additional flight data in a number of different views, including a view designed to find anomalies in the data.

        Pictures of the app for illustration:
<img src="https://user-images.githubusercontent.com/49268743/114751945-76c46080-9d5e-11eb-900f-4f566266043d.png">

The Joystick:

<img src="https://user-images.githubusercontent.com/49268743/114753222-e1c26700-9d5f-11eb-9211-d4407e32998a.png">

The different data about the flight:

<img src="https://user-images.githubusercontent.com/49268743/114753694-6e6d2500-9d60-11eb-812f-fd52787cc0c6.png">

The given graph after pressing on an item from the list above:

<img src="https://user-images.githubusercontent.com/49268743/114754202-fb17e300-9d60-11eb-9165-7b4809dff4a8.png">

The linear regression line between the two most correlative data:

<img src="https://user-images.githubusercontent.com/49268743/114755166-07507000-9d62-11eb-83c6-afc6a95a3dc9.png">

        Documentation and general explanation of the structure of the folders and main files in the project:
Model: ISimulatorModel-an interface of Model,
       MySimulatorModel- the implementation of the Model interface.
       
ViewModel: ConnectionButtonsViewModel,
           DashboardViewModel,
           FlightControlsViewModel.
           
View:      MainWindow, 
           JoystickView, 
           Sliders,
           Board1.
           
        Installations are required from any developer who wants to work on your project:
In order to run our application, you need to download the FlightGear application - there is a link https://www.flightgear.org/download/ .
In addition, you need to up the .Net Framework version 4.6.1  - there is a link https://dotnet.microsoft.com/download/dotnet-framework .

        Documented and UML charts:
There is UML charts of the main classes:
<img src="https://user-images.githubusercontent.com/49268743/114918284-95465c80-9e2f-11eb-9df0-740c7f9b118f.png">

        Video:
There is a link to a video where we demonstrate the user stories of the project:








