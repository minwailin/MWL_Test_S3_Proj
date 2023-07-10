# MWL_Test_S3_Proj
Sensor Device API Technical Documentation
-----------------------------------------
Overview
SensorDeviceAPI is a simple API built with .NET Core that allows you to receive payloads containing sensor data 
and store the main information in a database. The API is designed to handle exceptions, implement logging, 
and provide clean code structure for easy maintenance and extension.

Prerequisites
Before running SensorAPI, ensure that you have the following software installed on your machine:
.NET Core SDK

Installation and Setup
Clone the SensorAPI repository from GitHub or extract the project files to your desired directory.
Open a terminal or command prompt and navigate to the project directory.
Run the following command to restore the project dependencies:
bash
Copy code
dotnet restore
Once the dependencies are restored, the API is ready to be built and run.

Database Connection

The Api Project is currently with InMemoryDatabase.
If you want to make with your SQL Database you need to configure these of the following steps .
To configure the database connection, follow these steps:

Open the appsettings.json file located in the project root.
Locate the ConnectionStrings section.
Set the appropriate connection string for your chosen database provider.
Save the file and Add migration .

The logs are written to the console by default.

SensorDeviceAPI is a simple yet extensible API built with .NET Core that allows you to receive sensor data payloads 
and store the main information in a database. With its exception handling and logging capabilities, 
SensorAPI provides a solid foundation for building more complex sensor data processing systems.

